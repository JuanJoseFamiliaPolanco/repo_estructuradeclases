﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estructuradeclases
{
    public class Administrador : Docente
    {
        public string AreaDeAdministrador { get; set; }

        public Administrador(string Nombre, int Edad, int Id, string Departamento, string Materia, decimal? Sueldo, string AreaDeAdministrador)
                             : base(Nombre, Edad, Id, Departamento, Materia, Sueldo)
        {
            this.AreaDeAdministrador = AreaDeAdministrador;

        }

        public override void InformacionCiudadano()
        {
            Console.WriteLine("\nADMINISTRADOR");
            Console.WriteLine($"Id: {Id}, Nombre: {Nombre}, Edad: {Edad}, Departamento: {Departamento}, Materia: {Materia}, " +
                              $"Area administrada: {AreaDeAdministrador}, Sueldo: {Sueldo} ");


        }
    }
}
