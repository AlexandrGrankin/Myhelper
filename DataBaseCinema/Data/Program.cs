using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseCinema
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GeneralForm());
        }

        public class MyData
        {
            //Промежуточное значение для Добавить Изменить Удалить
            public static DBCinema value { get; set; }
            //Промежуточное значение для импорта
            public static List<DBCinema> listValue = new List<DBCinema>();
            public static int day  { get; set; }
            public static int mounth { get; set; }
            public static int year { get; set; }
            public static DateTime date { get; set; }


        }
    }
}
