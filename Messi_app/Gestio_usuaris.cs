using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
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
        private static Messi_Dades.Dades bbdd = new Messi_Dades.Dades();

        private string HostName;
        private string Mac;

        private string idUser;
        private string idDevice;

        private void Gestio_usuaris_Load(object sender, EventArgs e)
        {
            //Agafa el HostName i la Mac del PC i els mostra
            Classes_Messi.Xarxes cls = new Classes_Messi.Xarxes();

            HostName = cls.GetHostname();
            Mac = cls.GetMac();
            txtHostName.Text = HostName;
            txtMAC.Text = Mac;

            //Omple el combobox amb els usuaris de la BBDD
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

            btnDelete.Hide();
            btnRegister.Hide();
   
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            DataSet dts = bbdd.PortarTaula("MessiUsers");
            DataRow dr = dts.Tables[0].NewRow();

            string queryidUser = "select idUser from Users where codeUser = '" + combUser.Text + "'";
            DataSet dtsidUser = bbdd.PortarPerConsulta(queryidUser);
            idUser = dtsidUser.Tables[0].Rows[0]["idUser"].ToString();

            string queryidDevice = "select idDevice from TrustedDevices" +
                " where HostName = '" + HostName + "' and MAC = '" + Mac + "'";
            DataSet dtsidDevice = bbdd.PortarPerConsulta(queryidDevice);
            idDevice = dtsidDevice.Tables[0].Rows[0]["idDevice"].ToString();

            string query2 = "select * from MessiUsers where idUser = '" + idUser + "' and idDevice = '" + idDevice + "'";
            DataSet dts2 = bbdd.PortarPerConsulta(query2);

            if (dts2.Tables[0].Rows.Count > 0)
            {
                btnRegister.Hide();
                btnDelete.Show();
            }
            else
            {
                btnRegister.Show();
                btnDelete.Hide();
            }

            string user = combUser.Text;
            string user_valid = "TustedUser";
            var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = configFile.AppSettings.Settings;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            DataSet dts = bbdd.PortarTaula("MessiUsers");
            DataRow dr = dts.Tables[0].NewRow();

            string queryidUser = "select idUser from Users where codeUser = '" + combUser.Text + "'";
            DataSet dtsidUser = bbdd.PortarPerConsulta(queryidUser);
            idUser = dtsidUser.Tables[0].Rows[0]["idUser"].ToString();
            dr["idUser"] = idUser;

            string queryidDevice = "select idDevice from TrustedDevices" +
                " where HostName = '" + HostName + "' and MAC = '" + Mac + "'";
            DataSet dtsidDevice = bbdd.PortarPerConsulta(queryidDevice);
            idDevice = dtsidDevice.Tables[0].Rows[0]["idDevice"].ToString();
            dr["idDevice"] = idDevice;

            dts.Tables[0].Rows.Add(dr);
            string query = "select * from MessiUsers";
            bbdd.Actualitzar(dts, query);

            btnRegister.Hide();

            //Enviar Gmail usuari registrat
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("ALOHA@gmail.com");
            mail.To.Add("mireia.martinez@sarria.salesians.cat");
            mail.Subject = "Has sido registrado correctamente";
            mail.Body = "Te has registrado en la base de datos MESSI.";
            mail.Priority = MailPriority.Normal;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.UseDefaultCredentials = true;
            smtp.Credentials = new System.Net.NetworkCredential("rubnestida@gmail.com", "edu12345678");
            smtp.Send(mail);


            //Trusted User
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

        

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string queryidUser = "select idUser from Users where codeUser = '" + combUser.Text + "'";
            DataSet dtsidUser = bbdd.PortarPerConsulta(queryidUser);
            idUser = dtsidUser.Tables[0].Rows[0]["idUser"].ToString();

            string queryidDevice = "select idDevice from TrustedDevices" +
                " where HostName = '" + HostName + "' and MAC = '" + Mac + "'";
            DataSet dtsidDevice = bbdd.PortarPerConsulta(queryidDevice);
            idDevice = dtsidDevice.Tables[0].Rows[0]["idDevice"].ToString();


            string query = "select * from MessiUsers " +
                "where idDevice = '" + idDevice + "' and idUser = '" + idUser + "'";
            DataSet dts = bbdd.PortarPerConsulta(query);
            if (dts.Tables[0].Rows.Count > 0)
            {
                dts.Tables[0].Rows[0].Delete();
                bbdd.Actualitzar(dts, query);
                btnDelete.Hide();
            }

            
        }
    }
}
