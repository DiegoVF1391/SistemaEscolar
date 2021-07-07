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
        public static int index;
        public static String passi;
        private String Diego = "http://192.168.1.70/my_sge/acceso.php";
        private String Marco = "http://192.168.1.10/my_sge/acceso.php";
        //private String myWs = "Diego";
        private String apiClima = "https://api.openweathermap.org/data/2.5/weather?q=Morelia&lang=es&units=metric&appid=d7830285419c508e732ba5357594d148";
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

            if (textNoControl.Text == "" && textPass.Text == "")
            {
                MessageBox.Show("Ingrese los datos correspondientes");
            }
            else
            {
                HttpClient client = new HttpClient();
                //mandando parametros para accesar a la bd con ws
                String content = await client.GetStringAsync(Marco + "/?usr=" + usr + "&pass=" + pass);

                Console.WriteLine(content);

                try
                {
                    //pasar datos del alumno al otro formulario y abrirlo... formulario "inicio "
                    JObject jsonObject = JObject.Parse(content);
                    JArray jOutput = (JArray)jsonObject.GetValue("output");
                    Console.WriteLine(jOutput.ToString());
                    JObject jIndex = (JObject)jOutput[0];

                    

                    index = (int)jIndex.GetValue("id");
                    passi = (string)jIndex.GetValue("contrasenia");
                    MessageBox.Show("indice elegido: " + index);
                    // utilizar este indice para entrar a los datos del alumno elegido....
                    new Menu().Show();

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error " + ex);
                    MessageBox.Show("Error en la lectura.No se encuentra el usuario y/o contraseña");
                }
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            new Registro().Show(); //Se abre la ventana de registro
        }
    }
}
