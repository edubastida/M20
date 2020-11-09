using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Messi_app
{
    public partial class Menu_MAC : Form
    {
        public Menu_MAC()
        {
            InitializeComponent();
        }
        private void Menu_MAC_Load(object sender, EventArgs e)
        {
            Classes_Messi.Xarxes cls = new Classes_Messi.Xarxes();

            txtMAC.Text = cls.GetMac();
            txtHostName.Text = cls.GetHostname();

            Messi_Dades.Dades bbdd = new Messi_Dades.Dades(); 
            string query = "Select * from TrustedDevices " +  
                "where MAC = '" + txtMAC.Text + "' and HostName = '" + txtHostName.Text + "'" ;
            DataSet Exist = bbdd.PortarPerConsulta(query);

            if(Exist.Tables[0].Rows.Count == 1)
            {
                btnSave.Enabled = false;
            }
            else
            {
                btnDelete.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Messi_Dades.Dades bbdd = new Messi_Dades.Dades();

            string query = "insert into TrustedDevices " +
                "values ('" + txtMAC.Text + "' , '" + txtHostName.Text + "')";
            int TrustedDevices = bbdd.Executa(query);

            btnSave.Enabled = false;
            btnDelete.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Messi_Dades.Dades bbdd = new Messi_Dades.Dades();

            string query = "delete from TrustedDevices " +
                "where MAC = '" + txtMAC.Text + "' and HostName = '" + txtHostName.Text + "'";
            int TrustedDevices = bbdd.Executa(query);

            btnSave.Enabled = true;
            btnDelete.Enabled = false;
        }
    }
}
