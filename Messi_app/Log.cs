using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Messi_app
{
    public partial class Log : Form
    {
        public Log()
        {
            InitializeComponent();
        }

        int Error = 0;
        int contador_s = 0;

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {

            Messi_Dades.Dades bbdd = new Messi_Dades.Dades();

            DataSet Users = bbdd.PortarPerConsulta("select codeUser, password " +
                "from Users where codeUser = '" + txtUser.Text + "' and password = '" + txtPassword.Text + "'");
            //DataSet MessiUsers = bbdd.PortarPerConsulta("select * from MessiUsers where idMessiUser = '" +  idDevice idUser")

            if (Users.Tables[0].Rows.Count > 0)
            {
                label3.Hide();
                txtUser.Enabled = false;
                txtPassword.Enabled = false;
                label4.Text = ("Bon dia " + txtUser.Text + ", estem validant les seves credencials");
                //pictureBox2.Image = Image.FromFile(@"C:\Users\rprod\Pictures\Star.gif");
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                timer2.Enabled = true;
                timer2.Start();
            }
            else
            {
                Error++;

                if (Error == 3)
                {
                    timer1.Enabled = true;
                    string Hora_Actual, Data_Actual;
                    Hora_Actual = DateTime.Now.ToString("hhmmss");
                    Data_Actual = DateTime.Now.ToString("yyyyMMdd");
                    string path = @"C:\Users\rprod\Desktop\Logs_guardados\log_errors.log";

                    FileInfo fi = new FileInfo(path);


                    if (!File.Exists(path))
                    {
                        //Open file for Read\Write
                        FileStream fs = fi.Open(FileMode.OpenOrCreate, FileAccess.Write);

                        //Create StreamWriter object to write string to FileSream
                        StreamWriter sw = new StreamWriter(fs);
                        sw.WriteLine(Data_Actual + ":" + Hora_Actual + ":" + txtUser.Text);
                        sw.Close();
                    }
                    else
                    {
                        //Open file for Read\Write
                        FileStream fs = fi.Open(FileMode.Append, FileAccess.Write);
                        StreamWriter sw = new StreamWriter(fs);
                        sw.WriteLine(Data_Actual + ":" + Hora_Actual + ":" + txtUser.Text);
                        sw.Close();
                    }
                    Application.Exit();
                }
                else
                {
                    label3.Text = ("Usuari i Contrasenya incorrectes, intents restants " + (String)(3 - Error).ToString());
                }
                txtUser.Clear();
                txtPassword.Clear();
            }
        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            contador_s++;
            if (contador_s == 5)
            {
                Menu_usuari obj = new Menu_usuari();
                obj.Show();
                this.Hide();
            }
        }
    }
}
