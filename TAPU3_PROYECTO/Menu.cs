using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAPU3_PROYECTO
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            //Carga en el formulario
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
            //Se abre el formulario de examenes
        }
    }
}
