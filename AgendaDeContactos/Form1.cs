using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AgendaDeContactos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dgvContactos.AutoGenerateColumns = false;
            lblVacio.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarContactos("");
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            MostrarContactos(txtBuscar.Text);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormAgregar ventana = new FormAgregar();
            ventana.ShowDialog();
            MostrarContactos(txtBuscar.Text);
        }

        private void btnCalendario_Click(object sender, EventArgs e)
        {
            FormCalendario ventana = new FormCalendario();
            ventana.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvContactos.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un contacto para eliminar.");
                return;
            }

            Contacto elegido = dgvContactos.CurrentRow.DataBoundItem as Contacto;

            if (elegido == null)
            {
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Eliminar a " + elegido.Nombre + "?",
                "Confirmar",
                MessageBoxButtons.YesNo);

            if (respuesta == DialogResult.Yes)
            {
                Agenda.Contactos.Remove(elegido);
                MostrarContactos(txtBuscar.Text);
            }
        }

        private void timerRecordatorios_Tick(object sender, EventArgs e)
        {
            timerRecordatorios.Stop();

            foreach (Recordatorio r in Agenda.Recordatorios)
            {
                if (!r.Avisado && r.Fecha <= DateTime.Now)
                {
                    r.Avisado = true;

                    string mensaje = "Recordatorio del día de hoy:\n" + r.Texto;

                    if (!string.IsNullOrEmpty(r.NombreContacto))
                    {
                        mensaje += "\nContacto: " + r.NombreContacto;
                    }

                    MessageBox.Show(mensaje, "Recordatorio",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            timerRecordatorios.Start();
        }

        private void MostrarContactos(string texto)
        {
            string buscado = texto.Trim().ToLower();
            List<Contacto> resultado = new List<Contacto>();

            foreach (Contacto c in Agenda.Contactos)
            {
                if (c.Nombre.ToLower().Contains(buscado) || c.Telefono.Contains(buscado))
                {
                    resultado.Add(c);
                }
            }

            dgvContactos.DataSource = null;
            dgvContactos.DataSource = resultado;

            if (Agenda.Contactos.Count == 0)
            {
                lblVacio.Text = "No hay contactos agregados";
                lblVacio.Visible = true;
            }
            else if (resultado.Count == 0)
            {
                lblVacio.Text = "No se encontraron contactos";
                lblVacio.Visible = true;
            }
            else
            {
                lblVacio.Visible = false;
            }
        }

        private void lblVacio_Click(object sender, EventArgs e)
        {

        }
    }
}
