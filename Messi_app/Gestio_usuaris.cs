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

        private void Gestio_usuaris_Load(object sender, EventArgs e)
        {
            Classes_Messi.Xarxes cls = new Classes_Messi.Xarxes();

            txtHostName.Text = cls.GetHostname();
            txtMAC.Text = cls.GetMac();
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
    }
}
