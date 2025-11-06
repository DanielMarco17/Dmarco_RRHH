using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DMarco_RRHH.modelo
{
    internal class Candidato
    {
        public string Apellidos { get; set; }
        public int Cp { get; set; }
        public string Direccion { get; set; }
        public string Dni { get; set; }
        public string Email { get; set; }
        public string NivelEstudios { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public byte[] Foto { get; set; }
        public string Localidad { get; set; }
        public string Nombre { get; set; }
        public string Observaciones { get; set; }
        public int Tlfno { get; set; }
        public string UsuarioRegistrador { get; set; }

        public Candidato()
        {
            FechaAlta = DateTime.Now;
        }

        
    }
}
