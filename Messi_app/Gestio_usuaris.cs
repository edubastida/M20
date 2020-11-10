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
            //Agafa el HostName i la Mac del PC i els mostra
            Classes_Messi.Xarxes cls = new Classes_Messi.Xarxes();

            HostName = cls.GetHostname();
            Mac = cls.GetMac();
            txtHostName.Text = HostName;
            txtMAC.Text = Mac;

            //Omple el combobox amb els usuaris de la BBDD
            Messi_Dades.Dades bbdd = new Messi_Dades.Dades();
            DataSet dts = bbdd.PortarTaula("Users");
            
            combUser.DataSource = dts.Tables[0];
            combUser.ValueMember = "idUser";
            combUser.DisplayMember = "codeUser";

            //Comprova que el HostName i la Mac s'han guardat a TrustedUsers, 
            //si no es aixi mostra un missatge i tanca la pesntanya 
            string query = "select * from TrustedDevices" +
                " where HostName = '" + HostName + "' and MAC = '" + Mac + "'";
            DataSet exist = bbdd.PortarPerConsulta(query);

            if (exist.Tables[0].Rows.Count <= 0)
            {
                this.Close();
                MessageBox.Show("Dispositiu no donat d'alta");
            }
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

            
            string user = combUser.Text;
            string user_valid = "TustedUser";
            var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = configFile.AppSettings.Settings;
        }
    }
}
