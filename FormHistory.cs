using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FortuneTeller
{
    public partial class FormHistory : Form
    {
        List<string> history;
        Form form1;

        public FormHistory(Form1 form)
        {
            this.form1 = form;
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }
    }
}
