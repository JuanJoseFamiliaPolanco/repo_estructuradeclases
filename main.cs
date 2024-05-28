
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estructuradeclases
{
    public class main
    {
        static void Main(string[] args)
        {

            MiembroDeLaComunidad miembroDeLaComunidad = new Estudiante("Juan", 19, 20237854, "software");
            miembroDeLaComunidad.InformacionCiudadano();

            MiembroDeLaComunidad exAlumno = new ExAlumno("chepe", 29, 20236367, "multimedia", new(2023, 2, 2));
            exAlumno.InformacionCiudadano();

            Empleado administrativo = new Administrativo("oscar", 36, 1555, "informatica", "Gerente", 55000);
            administrativo.InformacionCiudadano();

            Docente maestro = new Maestro("pri", 25, 1824, "departamento de calculo", "calculo integral", 20000, "Universitario");
            maestro.InformacionCiudadano();

            Docente administrador = new Administrador("miguel", 55, 2025, "Software", "Programacion", 60000, "Gestion de Riesgos");
            administrador.InformacionCiudadano();

        }
    }
}
