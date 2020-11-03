using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data;

namespace Messi_Control
{
    public partial class Boto_return : Button
    {
        public Boto_return()
        {
            InitializeComponent();
        }

        public Boto_return(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        private void Boto_return_Click(object sender, EventArgs e)
        {
            Form frm = this.FindForm();
            frm.Close();
        }
    }
}
