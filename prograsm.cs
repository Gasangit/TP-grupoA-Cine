﻿using System.Diagnostics;

namespace TP_grupoA_Cine
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Padre());

            //Cine miCine = Cine.Instancia;

            //miCine.obtenerObjetoDeLista(3490, "usuario");
            //miCine.altaSala("Av. La Plata 55 sala A", 150);
            //miCine.altaPelicula("El Padrino", "Cosas de la mafia", 175);
            //Funcion funcion1 = miCine.altaFuncion(sala1, pelicula1, new DateTime(2023,4,15,21,0,0), 800);
            //miCine.altaUsuario(29476878, "Gaston","Mansilla","gaston@gmail.com","123", new DateTime(1982,04,02), true);
            //miCine.altaUsuario(35890765, "Lucas", "Marenco", "lucas@gmail.com","123", new DateTime(1995,10,03), true);
            //miCine.bajaUsuario(3);


            //miCine.cargarCredito(usuario1.ID, 3000);
            //miCine.cargarCredito(usuario2.ID, 3000);
            //miCine.comprarEntrada(usuario1.ID, funcion1.ID, 2);

        }
    }
}
