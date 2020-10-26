using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Messi_app
{
    public partial class Gestio_usuaris : Form
    {
        public Gestio_usuaris()
        {
            InitializeComponent();
        }

        private void Gestio_usuaris_Load(object sender, EventArgs e)
        {
            Classes_Messi.Xarxes cls = new Classes_Messi.Xarxes();

            txtHostName.Text = cls.GetHostname();
            txtMAC.Text = cls.GetMac();
        }
    }
}
