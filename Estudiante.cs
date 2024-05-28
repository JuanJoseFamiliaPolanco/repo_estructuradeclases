﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estructuradeclases
{
    public class Estudiante : MiembroDeLaComunidad
    {
        public int Matricula { get; set; }
        public string Carrera { get; set; }

        public Estudiante(string Nombre, int Edad, int Matricula, string Carrera) : base(Nombre, Edad)
        {
            this.Matricula = Matricula;
            this.Carrera = Carrera;
        }

        public override void InformacionCiudadano()
        {
            Console.WriteLine("\nESTUDIANTE ");
            Console.WriteLine($"Estudiante: {Nombre}, Carrera: {Carrera}, Matricula: {Matricula}, Edad: {Edad}");
    

        }
    }
}
