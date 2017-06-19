using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory_Game
{
    public partial class levelopitions : UserControl
    {
        public levelopitions()
        {
            InitializeComponent();
        }

        private void easyB_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            easyScreen es = new easyScreen();
            f.Controls.Add(es);
        }

        private void mediumB_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            mediumScreen ms = new mediumScreen();
            f.Controls.Add(ms);
        }

        private void hardB_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            hardScreen hs = new hardScreen();
            f.Controls.Add(hs);
        }
    }
}
