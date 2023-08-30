using WinFormsApp1;

namespace WinFormsApp1
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

            
        }

        
        class Postava
        {
            Postava(string _jmeno) { 
                jmeno = _jmeno;
            }
            string jmeno;
            int zivoty = 100;
            int umeniBoje = 25;



            public static void main(string[] args)
            {
                Postava hrac1 = new Postava("hrac1");

                Postava hrac2 = new Postava("hrac2");

            }
        }

    }
}