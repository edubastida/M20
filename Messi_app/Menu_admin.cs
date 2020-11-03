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
    public partial class Menu_admin : Form
    {
        public Menu_admin()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Menu_MAC obj = new Menu_MAC();
            obj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Gestio_usuaris obj = new Gestio_usuaris();
            obj.Show();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Coordenades obj = new Coordenades();
            obj.Show();
        }
    }
}
