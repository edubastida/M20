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
    public partial class Boto_exit : Button
    {
        public Boto_exit()
        {
            InitializeComponent();
        }

        public Boto_exit(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        private void Boto_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
