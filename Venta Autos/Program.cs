namespace Venta_Autos
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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string userName = "nombre_de_usuario"; // Aquí debes proporcionar el valor correcto
            string password = "contraseña"; // Aquí debes proporcionar el valor correcto
            Application.Run(new Vista_de_autoscs(userName, password));
        }
    }
}