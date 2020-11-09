using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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

        private string HostName;
        private string Mac;

        private void Gestio_usuaris_Load(object sender, EventArgs e)
        {
            Classes_Messi.Xarxes cls = new Classes_Messi.Xarxes();

             HostName = cls.GetHostname();
             Mac = cls.GetMac();

            txtHostName.Text = HostName;
            txtMAC.Text = Mac;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            

            string user = combUser.Text;
            string user_valid = "TustedUser";
            var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = configFile.AppSettings.Settings;
            if (settings[user_valid] == null)
            {
                settings.Add(user_valid, user);
            }
            else
            {
                settings[user_valid].Value = user;
            }
            configFile.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            Messi_Dades.Dades bbdd = new Messi_Dades.Dades();
            DataSet dts = bbdd.PortarTaula("Users");

            string query = "select * from TrustedDevices" +
                " where HostName = '" + HostName + "' and MAC = '" + Mac + "'";
            DataSet esta = bbdd.PortarPerConsulta(query);

            if (esta.Tables[0].Rows.Count == 0)
            {
                this.Hide();
            }





            string user = combUser.Text;
            string user_valid = "TustedUser";
            var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = configFile.AppSettings.Settings;


        }
    }
}
