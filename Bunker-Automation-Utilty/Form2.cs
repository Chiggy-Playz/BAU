using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bunker_Automation_Utilty
{
    public partial class Form2 : Form
    { int value;
        public Form2()
        {
            InitializeComponent();
           
            
                }
        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //Load data
            this.progressBar1.Visible = true;
        }

        public void setProgress(int val)
        {
            this.progressBar1.Value = val;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
