using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AgendaDeContactos
{
    
    public partial class FormAgregar : Form
    {
        public FormAgregar()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            string nombre = txtNombre.Text.Trim();
            string telefono = txtTelefono.Text.Trim();
            string correo = txtCorreo.Text.Trim();

            
            if (nombre == "" || telefono == "")
            {
                MessageBox.Show("El nombre y el teléfono son obligatorios.");
                return;   
            }

            
            if (!TelefonoValido(telefono))
            {
                MessageBox.Show("El teléfono solo puede tener números (entre 7 y 15 caracteres).");
                return;
            }

            
            if (correo != "" && !CorreoValido(correo))
            {
                MessageBox.Show("El correo no tiene un formato válido (ejemplo: nombre@correo.com).");
                return;
            }

            
            Contacto nuevo = new Contacto();
            nuevo.Nombre = nombre;
            nuevo.Telefono = telefono;
            nuevo.Correo = correo;

            Agenda.Contactos.Add(nuevo);

            MessageBox.Show("Contacto guardado.", "Agenda",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();  
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        
        private bool CorreoValido(string correo)
        {
            return Regex.IsMatch(correo, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        private bool TelefonoValido(string telefono)
        {
            return Regex.IsMatch(telefono, @"^[0-9 +\-]{7,15}$");
        }
    }
}
