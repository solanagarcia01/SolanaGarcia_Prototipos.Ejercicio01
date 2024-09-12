using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolanaGarcia_Prototipos.Ejercicio01.DatosPersona
{
    public partial class DatosPersonaForm : Form
    {
        private DatosPersonaModel modelo = new();
        public DatosPersonaForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var persona = new Persona();

            persona.Dni = textBox1.Text;


            var error = modelo.Ingresar(persona);

            if (error != null) {

                MessageBox.Show("Se han ingresado los datos correctamente");

            }
            else
            {
                MessageBox.Show(error);
            }
        }
    }
}
