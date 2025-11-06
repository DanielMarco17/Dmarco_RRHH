using Microsoft.Extensions.Configuration;
using System.IO;


namespace DMarco_RRHH.Bbdd
{
    internal class bbddConfig
    {
        private static IConfigurationRoot config;

        /// <summary>
        /// Accede al .json de configuración de conexión a base de datos para extraer
        /// los parámetros de conexión y mapearlos. Así podemos mantener ocultos los parámetros
        /// en repositorios públicos.
        /// </summary>
        static bbddConfig()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("bbddsettings.json");

            config = builder.Build();
        }

        /// <summary>
        /// Accede al string con parámetros de conexión a bbdd que hemos mapeado en
        /// el constructor Conexion()
        /// </summary>
        /// <returns>String con parámetros de conexión a la base de datos</returns>
        public static string GetConnectionString()
        {
            return config.GetConnectionString("DefaultConnection");
        }
    }
}

