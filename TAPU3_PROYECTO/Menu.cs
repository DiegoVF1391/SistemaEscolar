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
    public partial class Menu : Form
    {
        //id del alumno elegido 
        int indexx = Form1.index;
        private String nombre1;

        private String Diego = "http://192.168.1.70/my_sge/infoE.php";
        private String Marco = "http://192.168.1.10/my_sge/infoE.php";

        public Menu()
        {
            InitializeComponent();
        }

        private async void Menu_Load(object sender, EventArgs e)
        {
            //Carga en el formulario

            HttpClient client = new HttpClient();
            String content = await client.GetStringAsync(Diego + "/?id="+indexx);

            try
            {
                JObject jsonObject = JObject.Parse(content);
                JArray jOutput = (JArray)jsonObject.GetValue("output");
                Console.WriteLine(jOutput.ToString());
                JObject jIndex = (JObject)jOutput[0];

                nombre1 = (String)jIndex.GetValue("nombre");
                labelNombre.Text +=": "+nombre1;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error " + ex);
                MessageBox.Show("Error en la lectura");
            }
        }

        private void btnCali_Click(object sender, EventArgs e)
        {
            new Calificaciones().Show(); //Se abre el formulario de calificaciones
        }

        private void btnReticula_Click(object sender, EventArgs e)
        {
            new Reticula().Show(); //Se abre el formulario de reticula
        }

     

        private void btnHorario_Click(object sender, EventArgs e)
        {
            new Horario().Show(); //Se abre el formulario de horario
        }

        private void btnExamen_Click(object sender, EventArgs e)
        {
            new Examenes().Show();//Se abre el formulario de examenes
        }

        private void btnDatos_Click(object sender, EventArgs e)
        {
            new Datos().Show();
        }
    }
}
