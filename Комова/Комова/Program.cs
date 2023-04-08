using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Комова
{
    static class Program
    {
        //Создание рецепта
        public static int id_recept;
        public static int sebestoimost;
        public static int ves_bluda;
        //Повар
        public static int rows;
        public static int column;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Avtorizcia());
        }
    }
}
