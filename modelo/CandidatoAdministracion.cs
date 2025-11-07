using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMarco_RRHH.modelo
{
    internal class CandidatoAdministracion : Candidato
    {
        public string NivelInformaticaCalculo { get; set; }
        public string NivelInformaticaInternet { get; set; }
        public string NivelInformaticaTexto { get; set; }
        public CandidatoAdministracion() : base()
        {
        }

        // Constructor simple con los datos básicos
        public CandidatoAdministracion(string nombre, string apellidos, string dni) : base()
        {
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Dni = dni;
        }
    }
}
