using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAPU3_PROYECTO
{
    public partial class Reticula : Form
    {
        private static String Diego = "http://192.168.1.70/my_sge/reticula.php";
        private static String Marco = "http://192.168.1.10/my_sge/reticula.php";

        private String ws = Marco;

        JObject m1, m2, m3, m4, m5, m6;
        String[] filas = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        public Reticula()
        {
            InitializeComponent();
        }

        private async void Reticula_Load(object sender, EventArgs e)
        {
            tablaR.RowTemplate.Height = 70;

            try
            {
                HttpClient client = new HttpClient();
                //mandando parametros para accesar a la bd con ws
                String content = await client.GetStringAsync(ws);

                JObject jmaterias = JObject.Parse(content);
                JArray jOutput = (JArray)jmaterias.GetValue("output");

                //MessageBox.Show(jOutput.ToString());

                //acomodar materias en grid 

                m1 = (JObject)jOutput[3];
                m2 = (JObject)jOutput[4];
                m3 = (JObject)jOutput[5];
                m4 = (JObject)jOutput[6];
                m5 = (JObject)jOutput[7];
                m6 = (JObject)jOutput[8];
                String[] rowArray = { filas[0], $"{m1.GetValue("nombre_materia")}", $"{m2.GetValue("nombre_materia")}", $"{m3.GetValue("nombre_materia")}",
                    $"{m4.GetValue("nombre_materia")}",$"{m5.GetValue("nombre_materia")}",$"{m6.GetValue("nombre_materia")}"};
                 tablaR.Rows.Insert(0, rowArray);

                m1 = (JObject)jOutput[0];
                m2 = (JObject)jOutput[10];
                m3 = (JObject)jOutput[11];
                m4 = (JObject)jOutput[12];
                m5 = (JObject)jOutput[13];
                m6 = (JObject)jOutput[14];
                String[] rowArray2 = { filas[1], $"{m1.GetValue("nombre_materia")}", $"{m2.GetValue("nombre_materia")}", $"{m3.GetValue("nombre_materia")}",
                    $"{m4.GetValue("nombre_materia")}",$"{m5.GetValue("nombre_materia")}",$"{m6.GetValue("nombre_materia")}"};
                tablaR.Rows.Insert(1, rowArray2);

                m1 = (JObject)jOutput[15];
                m2 = (JObject)jOutput[16];
                m3 = (JObject)jOutput[17];
                m4 = (JObject)jOutput[18];
                m5 = (JObject)jOutput[19];
                m6 = (JObject)jOutput[20];
                String[] rowArray3 = { filas[2], $"{m1.GetValue("nombre_materia")}", $"{m2.GetValue("nombre_materia")}", $"{m3.GetValue("nombre_materia")}",
                    $"{m4.GetValue("nombre_materia")}",$"{m5.GetValue("nombre_materia")}",$"{m6.GetValue("nombre_materia")}"};
                tablaR.Rows.Insert(2, rowArray3);

                m1 = (JObject)jOutput[1];
                m2 = (JObject)jOutput[21];
                m3 = (JObject)jOutput[22];
                m4 = (JObject)jOutput[23];
                m5 = (JObject)jOutput[24];
                m6 = (JObject)jOutput[25];
                String[] rowArray4 = { filas[3], $"{m1.GetValue("nombre_materia")}", $"{m2.GetValue("nombre_materia")}", $"{m3.GetValue("nombre_materia")}",
                    $"{m4.GetValue("nombre_materia")}",$"{m5.GetValue("nombre_materia")}",$"{m6.GetValue("nombre_materia")}"};
                tablaR.Rows.Insert(3, rowArray4);

                m1 = (JObject)jOutput[26];
                m2 = (JObject)jOutput[27];
                m3 = (JObject)jOutput[28];
                m4 = (JObject)jOutput[29];
                m5 = (JObject)jOutput[30];
                m6 = (JObject)jOutput[31];
                String[] rowArray5 = { filas[4], $"{m1.GetValue("nombre_materia")}", $"{m2.GetValue("nombre_materia")}", $"{m3.GetValue("nombre_materia")}",
                    $"{m4.GetValue("nombre_materia")}",$"{m5.GetValue("nombre_materia")}",$"{m6.GetValue("nombre_materia")}"};
                tablaR.Rows.Insert(4, rowArray5);

                m1 = (JObject)jOutput[2];
                m2 = (JObject)jOutput[32];
                m3 = (JObject)jOutput[33];
                m4 = (JObject)jOutput[34];
                m5 = (JObject)jOutput[35];
                m6 = (JObject)jOutput[36];
                String[] rowArray6 = { filas[5], $"{m1.GetValue("nombre_materia")}", $"{m2.GetValue("nombre_materia")}", $"{m3.GetValue("nombre_materia")}",
                    $"{m4.GetValue("nombre_materia")}",$"{m5.GetValue("nombre_materia")}",$"{m6.GetValue("nombre_materia")}"};
                tablaR.Rows.Insert(5, rowArray6);

                m1 = (JObject)jOutput[37];
                m2 = (JObject)jOutput[38];
                m3 = (JObject)jOutput[39];
                m4 = (JObject)jOutput[40];
                m5 = (JObject)jOutput[41];
                //m6 = (JObject)jOutput[42];
                String[] rowArray7 = { filas[6], $"{m1.GetValue("nombre_materia")}", $"{m2.GetValue("nombre_materia")}", $"{m3.GetValue("nombre_materia")}",
                    $"{m4.GetValue("nombre_materia")}",$"{m5.GetValue("nombre_materia")}"};
                tablaR.Rows.Insert(6, rowArray7);

                m1 = (JObject)jOutput[42];
                m2 = (JObject)jOutput[43];
                m3 = (JObject)jOutput[44];
                m4 = (JObject)jOutput[45];
                String[] rowArray8 = { filas[7], $"{m1.GetValue("nombre_materia")}", $"{m2.GetValue("nombre_materia")}", $"{m3.GetValue("nombre_materia")}",
                $"{m4.GetValue("nombre_materia")}"};
                tablaR.Rows.Insert(7, rowArray8);


                m1 = (JObject)jOutput[46];
                m2 = (JObject)jOutput[47];
                String[] rowArray9 = { filas[8], $"{m1.GetValue("nombre_materia")}", $"{m2.GetValue("nombre_materia")}" };
                tablaR.Rows.Insert(8, rowArray9);



            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
                MessageBox.Show("Error, intente mas tarde...");
                throw;
            }
        }

    }

}
