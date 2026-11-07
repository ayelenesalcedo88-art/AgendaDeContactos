using System;
using System.Windows.Forms;

namespace AgendaDeContactos
{
    
    public partial class FormCalendario : Form
    {
        public FormCalendario()
        {
            InitializeComponent();

           
            calCalendario.MinDate = DateTime.Today;

            
            dtpHora.Value = DateTime.Now.AddMinutes(1);

            ActualizarFecha();
            CargarContactos();
            MostrarRecordatorios();
        }

        
        private void calCalendario_DateChanged(object sender, DateRangeEventArgs e)
        {
            ActualizarFecha();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string texto = txtRecordatorio.Text.Trim();

            if (texto == "")
            {
                MessageBox.Show("Escribe qué quieres que te recordemos.");
                return;
            }

           
            DateTime fechaHora = calCalendario.SelectionStart.Date + dtpHora.Value.TimeOfDay;

            if (fechaHora <= DateTime.Now)
            {
                MessageBox.Show("La fecha y la hora deben ser posteriores al momento actual.");
                return;
            }

            Recordatorio nuevo = new Recordatorio();
            nuevo.Fecha = fechaHora;
            nuevo.Texto = texto;
            nuevo.NombreContacto = "";
            nuevo.Avisado = false;

            
            if (cmbContacto.SelectedIndex > 0)
            {
                nuevo.NombreContacto = cmbContacto.Text;
            }

            Agenda.Recordatorios.Add(nuevo);

            
            Agenda.Recordatorios.Sort((a, b) => a.Fecha.CompareTo(b.Fecha));

            txtRecordatorio.Clear();
            cmbContacto.SelectedIndex = 0;
            MostrarRecordatorios();

            MessageBox.Show("Recordatorio guardado.", "Agenda",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int posicion = lstRecordatorios.SelectedIndex;

            if (posicion < 0)
            {
                MessageBox.Show("Selecciona un recordatorio para eliminar.");
                return;
            }

            Agenda.Recordatorios.RemoveAt(posicion);
            MostrarRecordatorios();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

       
        private void ActualizarFecha()
        {
            lblFecha.Text = calCalendario.SelectionStart.ToString("dddd, d 'de' MMMM 'de' yyyy");
        }

        
        private void CargarContactos()
        {
            cmbContacto.Items.Clear();
            cmbContacto.Items.Add("(ninguno)");

            foreach (Contacto c in Agenda.Contactos)
            {
                cmbContacto.Items.Add(c.Nombre);
            }

            cmbContacto.SelectedIndex = 0;
        }

        
        private void MostrarRecordatorios()
        {
            lstRecordatorios.DataSource = null;
            lstRecordatorios.DataSource = Agenda.Recordatorios;
            lstRecordatorios.SelectedIndex = -1;   
        }

        private void FormCalendario_Load(object sender, EventArgs e)
        {

        }

        private void lstRecordatorios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
