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
    public partial class Horario : Form
    {
        String[] horasP = { "7:00-8:00", "8:00-9:00", "9:00-10:00", "10:00-11:00", "11:00-12:00", "12:00-13:00" };
        String[] horasI = { "13:00-14:00", "14:00-15:00", "15:00-16:00", "16:00-17:00", "17:00-18:00", "18:00-19:00" };
        String[] horas;

        private static String Diego = "http://192.168.1.70/my_sge/verCalif.php";
        private static String Marco = "http://192.168.1.10/my_sge/verCalif.php";

        private String ws = Marco;

        int indice = Form1.index;

        public Horario()
        {
            InitializeComponent();
        }

        private async void Horario_Load(object sender, EventArgs e)
        {

            tablaH.RowTemplate.Height = 70;

            try
            {
                HttpClient client = new HttpClient();
                //mandando parametros para accesar a la bd con ws
                String content = await client.GetStringAsync(ws + "/?usr=" +indice);

                JObject jmaterias = JObject.Parse(content);
                JArray jOutput = (JArray)jmaterias.GetValue("output");

                int s = Form1.semestre;
                if (s % 2 == 0)
                {
                    horas = horasP;
                }
                else
                {
                    horas = horasI;
                }
               
                for (int i = 0; i < jOutput.Count; i++)
                {
                    JObject a = (JObject)jOutput[i];
    
                    String[] rowArray = { horas[i], $"{a.GetValue("nombre_materia")}", $"{a.GetValue("nombre_materia")}", 
                    $"{a.GetValue("nombre_materia")}", $"{a.GetValue("nombre_materia")}", $"{a.GetValue("nombre_materia")}" };
                    tablaH.Rows.Insert(i, rowArray);

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: "+ex);
                MessageBox.Show("Error, intente mas tarde...");
                throw;
            }


        }
    }
}
