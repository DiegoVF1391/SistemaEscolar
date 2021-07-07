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
    public partial class Datos : Form
    {
        int indexx = Form1.index;
        String semestre;
        String nombre, n_control, contrasenia; 

        private String Diego = "http://192.168.1.70/my_sge/infoE.php";
        private String Marco = "http://192.168.1.10/my_sge/infoE.php";

        private String DiegoP = "http://192.168.1.70/my_sge/newPass.php";
        private String MarcoP = "http://192.168.1.10/my_sge/newPass.php";

        private async void btnCambiar_ClickAsync(object sender, EventArgs e)
        {
            String newPassword;

            if (textNueva.Text != "")
            {
                newPassword = textNueva.Text.ToString();

                try
                {
                    HttpClient contra = new HttpClient();
                    //mandando parametros para registrar en la bd, cambiar nombre del integrante segun se requiera
                    String newPass = await contra.GetStringAsync(DiegoP + "?pass=" + newPassword + "&id=" + indexx);
                    Console.WriteLine(newPass);

                    MessageBox.Show("Se registró su contraseña");
                    this.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar, intente mas tarde...");
                    Console.WriteLine("Error: " + ex);
                    throw;
                }
            }
            else{
                MessageBox.Show("Ingrese la contraseña que quiere cambiar");
            }
        }

        public Datos()
        {
            InitializeComponent();
        }

        private async void Datos_LoadAsync(object sender, EventArgs e)
        {
            //Se realiza la ejecución del web service para consultar los datos del alumno
            HttpClient client = new HttpClient();
            String content = await client.GetStringAsync(Diego + "?id=" + indexx);

            try
            {
                JObject jsonObject = JObject.Parse(content);
                JArray jOutput = (JArray)jsonObject.GetValue("output");
                Console.WriteLine(jOutput.ToString());
                JObject jIndex = (JObject)jOutput[0];

                //Se obtienen los valores del JSON en variables
                nombre = (String)jIndex.GetValue("nombre");
                n_control = (String)jIndex.GetValue("n_control");
                contrasenia = (String)jIndex.GetValue("contrasenia");
                semestre = (String)jIndex.GetValue("semestre");

                //Se llenan en los campos correspondientes
                textNombre.Text = nombre;
                textNoControl.Text = n_control;
                textSemestre.Text = semestre;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error " + ex);
                MessageBox.Show("Error en la lectura");
            }
        }
    }
}
