using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario
{
    public partial class FormFormulario : Form
    {
        public FormFormulario()
        {
            InitializeComponent();
        }

        private void buttonSaludar_Click(object sender, EventArgs e)
        {
            string saludo = $"Hola{textBoxNombre.Text} es un gusto saludarte";
            MessageBox.Show(saludo, "Saludos :)");
        }

        private void labelNombre_Click(object sender, EventArgs e)
        {

        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            string carnet = textBoxCarnet.Text;
            string nombre = textBoxNombre.Text;
            string seccion = textBoxSeccion.Text;
            string email = textBoxCorreo.Text;
            int resultado = AgregarAlumno(carnet, nombre, seccion, email);
        }

        private void labelCorreo_Click(object sender, EventArgs e)
        {

        }

        private void FormFormulario_Load(object sender, EventArgs e)
        {

        }

        private int AgregarAlumno(string carnet, string nombre, string seccion, string email)
        {
            MessageBox.Show($"Alumno registrado:\nCarnet: {carnet}\nNombre: {nombre}\nSección: {seccion}\nEmail: {email}", "Registro Exitoso");
            return 1;
        }
    }
}
    
    

