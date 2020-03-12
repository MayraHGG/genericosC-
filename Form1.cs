using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U1A2_Genericos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Equipo<Futbolista> equipo = new Equipo<Futbolista>("juan", 10, "F");
            Futbolista futbolista = new Futbolista
            {
                No_Control = "",
                ApePat = "",
                ApeMat = "",
                Nombre = "",
                Edad = 0,
                Sexo = "",
                Estatura = 0,
                Peso = 0,
                Posicion = "",
                GolesAnotados = 0,
                TAmarillas = 0,
                TRojas = 0
            };
            // validar las condiciones (Predicaod)
            if (Predicados.ValidarSexo(futbolista))
            {
                equipo.AgregarIntegrante(futbolista);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Equipo<Deportista> basquet = new Equipo<Deportista>("juan", 10, "F");



                //Equipo<Deportista> deportista = new Equipo<Deportista>();
        }
    }
}
