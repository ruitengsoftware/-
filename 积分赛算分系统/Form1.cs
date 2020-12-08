using Aspose.Cells;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 积分赛算分系统
{
    public partial class Form1 : Form
    {
        List<PersonInfo> list_p = new List<PersonInfo>();
        List<RuleInfo> list_ruleinfo = new List<RuleInfo>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //获得规则
            Workbook mywbk = new Workbook(@".\rule.xlsx");
            Worksheet mysht = mywbk.Worksheets[0];
            list_ruleinfo = new List<RuleInfo>();
            RuleInfo myinfo = null;
            for (int i = 1; i < mysht.Cells.LastCell.Row+1; i++)
            {
               myinfo = new RuleInfo() { 
                _fencha=mysht.Cells[i,0].IntValue,
                _gaosheng=mysht.Cells[i,1].IntValue,
                _gaobai=mysht.Cells[i,2].IntValue
                };
                list_ruleinfo.Add(myinfo);
            }
            //获得人员,同时加载dgv_score的下拉列表项
            DataGridViewComboBoxColumn cola = dgv_score.Columns[0] as DataGridViewComboBoxColumn;
            DataGridViewComboBoxColumn colb = dgv_score.Columns[1] as DataGridViewComboBoxColumn;


            mywbk = new Workbook(@".\personinfo.xlsx");
            mysht = mywbk.Worksheets[0];
            list_p = new List<PersonInfo>();
            PersonInfo pi = null;
            for (int i = 1; i < mysht.Cells.LastCell.Row+1; i++)
            {
                pi = new PersonInfo()
                {
                    _xuhao= mysht.Cells[i,0].IntValue,
                    _xingming= mysht.Cells[i, 1].StringValue,
                    _xingbie= mysht.Cells[i, 2].StringValue,
                    _shoujihaoma = mysht.Cells[i, 3].StringValue,
                    _shenfenzheng = mysht.Cells[i, 4].StringValue,
                    _chushijifen = mysht.Cells[i, 5].IntValue,
                    _dangqianjifen = mysht.Cells[i, 6].IntValue
                };
                list_p.Add(pi);
                cola.Items.Add(pi._xingming);
                colb.Items.Add(pi._xingming);
            }


        }

        private void btn_jisuan_Click(object sender, EventArgs e)
        {
            dgv_result.Rows.Clear();
            //循环判断dgvscore中A,B 分别是 高分还是低分
            for (int i = 0; i < dgv_score.Rows.Count-1; i++)
            {
                var myrow = dgv_score.Rows[i];
                //获得A的personinfo
                PersonInfo pa = list_p.Find((PersonInfo pi)=>pi._xingming==myrow.Cells[0].Value.ToString());
                PersonInfo pb = list_p.Find((PersonInfo pi) => pi._xingming == myrow.Cells[1].Value.ToString());
                //计算二者分差，获得加减分，加到每个人的当前积分中
                int fencha = Math.Abs(pa._dangqianjifen - pb._dangqianjifen);
                RuleInfo ri = null;
                for (int j = 0; j < list_ruleinfo.Count; j++)
                {
                    if (fencha==0)
                    {
                        ri = list_ruleinfo[0];
                        break;
                    }
                    if (list_ruleinfo[j]._fencha>=fencha && list_ruleinfo[j-1]._fencha<fencha)
                    {
                        ri = list_ruleinfo[j];
                        break;
                    }
                }
                //判断pa和pb的输赢
                int scorea = Convert.ToInt32(myrow.Cells[2].Value.ToString().Substring(0,1));
                int scoreb = Convert.ToInt32(myrow.Cells[2].Value.ToString().Substring(1, 1));

                //如果A 输了，如果A是高分，如果A是低分
                if (scorea<scoreb)
                {
                    if (pa._dangqianjifen>=pb._dangqianjifen)
                    {
                        pa._dangqianjifen -= ri._gaobai;
                        pb._dangqianjifen += ri._gaobai;
                    }
                    else if (pa._dangqianjifen < pb._dangqianjifen)
                    {
                        pa._dangqianjifen -= ri._gaosheng;
                        pb._dangqianjifen += ri._gaosheng;
                    }

                }
                else//如果a胜
                {
                    if (pa._dangqianjifen >= pb._dangqianjifen)//A如果分数本来就高
                    {
                        pa._dangqianjifen += ri._gaosheng;
                        pb._dangqianjifen -= ri._gaosheng;
                    }
                    else if (pa._dangqianjifen < pb._dangqianjifen)
                    {
                        pa._dangqianjifen += ri._gaobai;
                        pb._dangqianjifen -= ri._gaobai;
                    }
                }
            }
            //计算之后在dgv_result中显示所有人的成绩
            int index = 0;
            for (int p = 0; p < list_p.Count; p++)
            {
                var pi = list_p[p];
                index = dgv_result.Rows.Add();
                dgv_result.Rows[index].Cells[0].Value = index + 1;
                dgv_result.Rows[index].Cells[1].Value = pi._xingming;
                dgv_result.Rows[index].Cells[2].Value = pi._chushijifen;

                dgv_result.Rows[index].Cells[3].Value = pi._dangqianjifen;
            }
        }

        private void btn_daochu_Click(object sender, EventArgs e)
        {
            //导出所有的personinfo
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel 工作簿|*.xlsx";
            if (sfd.ShowDialog()==DialogResult.OK)
            {
                Workbook mywbk = new Workbook();
                Worksheet mysht = mywbk.Worksheets[0];
                //添加表头
                mysht.Cells[0, 0].Value = "序号";
                mysht.Cells[0, 1].Value = "姓名";
                mysht.Cells[0, 2].Value = "性别";
                mysht.Cells[0, 3].Value = "手机号码";
                mysht.Cells[0, 4].Value = "身份证号码";
                mysht.Cells[0, 5].Value = "初始积分";
                mysht.Cells[0, 6].Value = "当前积分";

                //循环添加人员信息
                for (int i = 0; i < list_p.Count; i++)
                {
                    mysht.Cells[i + 1, 0].Value = list_p[i]._xuhao;
                    mysht.Cells[i + 1, 1].Value = list_p[i]._xingming;
                    mysht.Cells[i + 1, 2].Value = list_p[i]._xingbie;
                    mysht.Cells[i + 1, 3].Value = list_p[i]._shoujihaoma;
                    mysht.Cells[i + 1, 4].Value = list_p[i]._shenfenzheng;
                    mysht.Cells[i + 1, 5].Value = list_p[i]._chushijifen;
                    mysht.Cells[i + 1, 6].Value = list_p[i]._dangqianjifen;
                }
                mywbk.Save(sfd.FileName);
                MessageBox.Show("保存完成！");
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            dgv_score.Rows.Clear();
        }

        private void btn_cundang_Click(object sender, EventArgs e)
        {
            Workbook mywbk = new Workbook();
            Worksheet mysht = mywbk.Worksheets[0];
            //添加表头
            mysht.Cells[0, 0].Value = "序号";
            mysht.Cells[0, 1].Value = "姓名";
            mysht.Cells[0, 2].Value = "性别";
            mysht.Cells[0, 3].Value = "手机号码";
            mysht.Cells[0, 4].Value = "身份证号码";
            mysht.Cells[0, 5].Value = "初始积分";
            mysht.Cells[0, 6].Value = "当前积分";

            //循环添加人员信息
            for (int i = 0; i < list_p.Count; i++)
            {
                mysht.Cells[i + 1, 0].Value = list_p[i]._xuhao;
                mysht.Cells[i + 1, 1].Value = list_p[i]._xingming;
                mysht.Cells[i + 1, 2].Value = list_p[i]._xingbie;
                mysht.Cells[i + 1, 3].Value = list_p[i]._shoujihaoma;
                mysht.Cells[i + 1, 4].Value = list_p[i]._shenfenzheng;
                mysht.Cells[i + 1, 5].Value = list_p[i]._chushijifen;
                mysht.Cells[i + 1, 6].Value = list_p[i]._dangqianjifen;
            }
            mywbk.Save(@".\personinfo.xlsx");

            MessageBox.Show("保存成功！");
        }
    }
}
