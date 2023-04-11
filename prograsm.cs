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
            Application.Run(new Form1());

            Cine miCine = Cine.Instancia;

            Usuario usuario1 = miCine.altaUsuario(29476878, "Gaston","Mansilla","gaston@gmail.com","123", new DateTime(1982, 04, 02), true);

            miCine.cargarCredito(usuario1.ID, 3000);

            Console.WriteLine(usuario1.Credito);

        }
    }
}
