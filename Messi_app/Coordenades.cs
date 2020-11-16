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
    public partial class Coordenades : Form
    {
        public Coordenades()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Messi_Dades.Dades bbdd = new Messi_Dades.Dades();
            string delete = "Delete from Admincoordinates";
            int a = bbdd.Executa(delete);

            Dictionary<string, string> dic_coord = new Dictionary<string, string>();

            for(char l = 'A'; l < 'E'; l++)
            {
                for(int n = 1; n < 6; n++)
                {
                    Random rnd = new Random();

                    int num_rnd = rnd.Next(9999);

                    while (dic_coord.ContainsValue(num_rnd.ToString()))
                    {
                        num_rnd = rnd.Next(9999);       
                    }

                    dic_coord.Add(l.ToString() + n.ToString(), num_rnd.ToString());
                }
            }
            Dictionary<string, string> dic_coord_final = new Dictionary<string, string>();

            //Posar 0 a la esquerra si fa falta
            foreach (KeyValuePair<string, string> kvp in dic_coord)
            {
                string num_rand_string = "";

                if (kvp.Value.Length == 3)
                {
                    num_rand_string = "0" + kvp.Value;
                }
                else if (kvp.Value.Length == 2)
                {
                    num_rand_string = "00" + kvp.Value;
                }
                else if (kvp.Value.Length == 1)
                {
                    num_rand_string = "000" + kvp.Value;
                }
                else
                {
                    num_rand_string = kvp.Value;
                }
                dic_coord_final.Add(kvp.Key, num_rand_string);

                ////
                DataSet dts = bbdd.PortarTaula("AdminCoordinates");
                DataRow dr = dts.Tables[0].NewRow();

                dr["Coordinate"] = kvp.Key;
                dr["Value"] = num_rand_string;

                dts.Tables[0].Rows.Add(dr);
                string query = "select * from AdminCoordinates";
                bbdd.Actualitzar(dts, query);

            }

                foreach (KeyValuePair<string, string> kvp in dic_coord_final)
            {
                Label lblNums = new Label();
                tableLayoutPanel1.Controls.Add(lblNums);
                lblNums.Text = kvp.Value;
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Visible = true;
        }
    }
        }
    

