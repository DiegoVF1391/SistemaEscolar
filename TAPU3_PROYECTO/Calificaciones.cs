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
    public partial class Calificaciones : Form
    {

        private static String Diego = "http://192.168.1.70/my_sge/verCalif.php";
        private static String Marco = "http://192.168.1.10/my_sge/verCalif.php";

        //cambiar valor segun el usuario 
        String ws = Marco;

        public Calificaciones()
        {
            InitializeComponent();
        }





        private void tablaC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void Calificaciones_Load(object sender, EventArgs e)
        {
            

            HttpClient client = new HttpClient();
            String califs = await client.GetStringAsync(ws + "?usr=" + Form1.index);
            Console.WriteLine(califs);

            //nombre_materia y calificacion 

            try
            {
                JObject jsonObject = JObject.Parse(califs);
                JArray jOutput = (JArray)jsonObject.GetValue("output");

                for (int i = 0; i < jOutput.Count; i++)
                {
                    JObject jmateria = (JObject)jOutput[i];
                    String[] row = {jmateria.GetValue("nombre_materia").ToString(),
                    jmateria.GetValue("calificacion").ToString()};
                    tablaC.Rows.Insert(i, row);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(e);
                MessageBox.Show("Error al consultar");
                throw;
            }



        }
    }
}
