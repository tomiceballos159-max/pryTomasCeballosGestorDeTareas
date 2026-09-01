using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.MonthCalendar;

namespace pryTomasCeballosGestorDeTareas
{
    public partial class frmGestorDeTareas : Form
    {
        public frmGestorDeTareas()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTarea.Text))
            {
                MessageBox.Show("Por favor, ingrese una tarea.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tarea = txtTarea.Text;
            string prioridad = cmbPrioridad.SelectedItem.ToString();
            string fecha = dtpFecha.Value.ToString("dd/MM/yyyy");

            // Formato que se mostrará en la lista
            string itemTexto = $"{tarea} - {prioridad} ({fecha})";

            // Limpiar campo de texto
            txtTarea.Clear();
            txtTarea.Focus();
            lstTarea.Items.Add(itemTexto, false);
        }

        private void btnCompletar_Click(object sender, EventArgs e)
        {
            if (lstTarea.SelectedIndex != -1)
            {
                int index = lstTarea.SelectedIndex;
                bool estadoActual = lstTarea.GetItemChecked(index);

                // Cambia el estado del checkbox
                lstTarea.SetItemChecked(index, !estadoActual);
            }
            else
            {
                MessageBox.Show("Seleccione una tarea de la lista para marcar o desmarcar.", "Atención");

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            {
                if (lstTarea.SelectedIndex != -1)
                {

                }
                else
                {
                    MessageBox.Show("Seleccione una tarea de la lista para eliminar.", "Atención");
                }
                lstTarea.Items.RemoveAt(lstTarea.SelectedIndex);
            }
        }
    }
    }


