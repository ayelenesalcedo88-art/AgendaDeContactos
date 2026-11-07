using System;

namespace AgendaDeContactos
{

    public class Recordatorio
    {
        public DateTime Fecha { get; set; }
        public string Texto { get; set; }
        public string NombreContacto { get; set; }
        public bool Avisado { get; set; }


        public override string ToString()
        {
            string linea = Fecha.ToString("dd/MM/yyyy  hh:mm tt") + "   " + Texto;

            if (!string.IsNullOrEmpty(NombreContacto))
            {
                linea += "  (" + NombreContacto + ")";
            }

            if (Avisado)
            {
                linea += "  [avisado]";
            }

            return linea;
        }
    }
}
