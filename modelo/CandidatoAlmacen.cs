using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMarco_RRHH.modelo
{
    internal class CandidatoAlmacen : Candidato
    {
        // Propiedades específicas de candidatos de almacén
        public string CarnetCamion { get; set; }      // 'SI' o 'NO'
        public string CarnetCarretilla { get; set; }  // 'SI' o 'NO'
        public string CarnetConducir { get; set; }    // 'SI' o 'NO'

        // Constructor
        public CandidatoAlmacen() : base()
        {
        }

        // Constructor con parámetros
        public CandidatoAlmacen(string nombre, string apellidos, string dni) : base()
        {
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Dni = dni;
        }
    }
}
