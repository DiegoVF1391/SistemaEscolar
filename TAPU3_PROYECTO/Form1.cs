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
    public partial class Form1 : Form
    {

        private String myWs = "http://192.168.0.10:443/WS2021/my_sge/acceso.php";
        private String usr;
        private String pass;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void btnIngresar_Click(object sender, EventArgs e)
        {
            usr = textNoControl.Text.ToString();
            pass = textPass.Text.ToString();

            HttpClient client = new HttpClient();
            //mandando parametros para accesar a la bd con ws
            String content = await client.GetStringAsync(myWs+"/?usr="+usr+"&pass="+pass);

            try
            {
                //pasar datos del alumno al otro formulario y abrirlo... formulario "inicio "
                JObject jsonObject = JObject.Parse(content);
                JArray jOutput = (JArray)jsonObject.GetValue("output");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error "+ex);

                throw;
            }

          

       
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            new Registro().Show(); //Se abre la ventana de registro
        }
    }
}
