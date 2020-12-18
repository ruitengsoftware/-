using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 积分赛算分系统
{
    public partial class UCScore : UserControl
    {
        public UCScore()
        {
            InitializeComponent();

        }
        private List<string> list_name = new List<string>();
        public UCScore(List<string> l)
        {
            InitializeComponent();
            list_name = l;

        }

        private void cbb_a_TextUpdate(object sender, EventArgs e)
        {
            ComboBox cbBox = (ComboBox)sender;
            List<string> listNew = new List<string>();
            cbBox.Items.Clear();
            foreach (var item in list_name)  //已有数据
            {
                if (item.Contains(cbBox.Text))
                {
                    listNew.Add(item);
                }
            }
            cbBox.Items.AddRange(listNew.ToArray());
            cbBox.SelectionStart = cbBox.Text.Length;
            Cursor = Cursors.Default;
            cbBox.DroppedDown = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void UCScore_Load(object sender, EventArgs e)
        {
            cbb_a.Items.AddRange(list_name.ToArray());
            cbb_b.Items.AddRange(list_name.ToArray());

        }
    }
}
