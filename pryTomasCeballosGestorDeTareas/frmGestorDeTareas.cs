using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pryTomasCeballosGestorDeTareas
{
    public partial class frmGestorDeTareas : Form
    {
        public frmGestorDeTareas()
        {
            InitializeComponent();
        }

        private void frmGestorDeTareas_Load(object sender, EventArgs e)
        {
            cmbPrioridad.Items.Clear();

            // Agrega las opciones a la lista desplegable
            cmbPrioridad.Items.Add("Alta");
            cmbPrioridad.Items.Add("Media");
            cmbPrioridad.Items.Add("Baja");

            // Deja seleccionada la opción "Alta" por defecto al abrir la ventana
            cmbPrioridad.SelectedIndex = 0;
        }
    }
}   
