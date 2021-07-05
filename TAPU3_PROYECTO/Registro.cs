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
    public partial class Registro : Form
    {
        private String Diego = "http://192.168.1.70/my_sge/registro.php";
        private String Marco = "http://192.168.1.10/my_sge/registro.php";

        private String n_control;
        private String nombre;
        private int semestre;
        private String pass;

        public Registro()
        {
            InitializeComponent();
        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }

        private async void btnRegistrar_Click(object sender, EventArgs e)
        {
            n_control = textNoControl.Text.ToString();
            nombre = textNombre.Text.ToString();
            pass = textPass.Text.ToString();
            semestre = (int)selectSemester.Value;


            HttpClient client = new HttpClient();
            //mandando parametros para registrar en la bd, cambiar nombre del integrante segun se requiera
            String content = await client.GetStringAsync(Marco
                +"?ncontrol="+n_control+"&pass="+pass+"&name="+nombre+"&sem="+semestre);

            Console.WriteLine(content);


            //this.Dispose();//Se cierra la ventana de registro
            //Comentario en rama modificaciones 
        }

      
    }
}
