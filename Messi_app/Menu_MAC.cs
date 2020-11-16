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

        private static Messi_Dades.Dades bbdd = new Messi_Dades.Dades();

        //Creacio variables Xarxes
        private string MAC;
        private string HostName;

        private void Menu_MAC_Load(object sender, EventArgs e)
        {
            //Obrim la classe xarxes
            Classes_Messi.Xarxes xarxes = new Classes_Messi.Xarxes();

            //Donem valors a les variables de xarxes
            MAC = xarxes.GetMac();
            HostName = xarxes.GetHostname();

            txtMAC.Text = MAC;
            txtHostName.Text = HostName;

            //Comprovem si esta emmagatzemat a la BBDD  
            string query = "Select * from TrustedDevices " +  
                "where MAC = '" + MAC + "' and HostName = '" + HostName + "'" ;
            DataSet Exist = bbdd.PortarPerConsulta(query);

            if(Exist.Tables[0].Rows.Count == 1)
            {
                btnSave.Hide();
            }
            else
            {
                btnDelete.Hide();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataSet dts = bbdd.PortarTaula("TrustedDevices");
            DataRow dr = dts.Tables[0].NewRow();
           
            dr["MAC"] = MAC;
            dr["HostName"] = HostName;
            
            dts.Tables[0].Rows.Add(dr);
            string query = "select * from TrustedDevices";
            bbdd.Actualitzar(dts, query);

            btnSave.Hide();
            btnDelete.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string query = "select * from TrustedDevices " +
                "where MAC = '" + MAC + "' and HostName = '" + HostName + "'";
            DataSet dts = bbdd.PortarPerConsulta(query);
            if (dts.Tables[0].Rows.Count > 0)
            {
                dts.Tables[0].Rows[0].Delete();
                bbdd.Actualitzar(dts, query);
                btnSave.Show();
                btnDelete.Hide();
            }         
            
        }
    }
}
