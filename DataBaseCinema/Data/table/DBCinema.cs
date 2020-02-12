using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseCinema
{

    public class DBCinema {
        //Название
        private string nameCinema;
        //Дата последней проверки
        private int dayCheck;
        private int mounthCheck;
        private int yearCheck;
        //Дата следующей теоретической/запланированной проверки
        private int dayCheckNext;
        private int mounthCheckNext;
        private int yearCheckNext;

        //Условие является ли она запланированной
        bool planned;

        [DisplayName("Наименование")]
        public string NameCinema { get => nameCinema; set => nameCinema = value; }
        [DisplayName("День")]
        public int DayCheck { get => dayCheck; set => dayCheck = value; }
        [DisplayName("Месяц")]
        public int MounthCheck { get => mounthCheck; set => mounthCheck = value; }
        [DisplayName("Год")]
        public int YearCheck { get => yearCheck; set => yearCheck = value; }
        [DisplayName("День")]
        public int DayCheckNext { get => dayCheckNext; set => dayCheckNext = value; }
        [DisplayName("Месяц")]
        public int MounthCheckNext { get => mounthCheckNext; set => mounthCheckNext = value; }
        [DisplayName("Год")]
        public int YearCheckNext { get => yearCheckNext; set => yearCheckNext = value; }
        [DisplayName("Запланированно")]
        public bool Planned { get => planned; set => planned = value; }

        //Конструктор без DataTime
        public DBCinema(string nameCinema, 
            int dayCheck, 
            int mounthCheck, 
            int yearCheck, 
            int dayCheckNext, 
            int mounthCheckNext, 
            int yearCheckNext,
            bool planned)
        {
            this.NameCinema = nameCinema;
            this.DayCheck = dayCheck;
            this.MounthCheck = mounthCheck;
            this.YearCheck = yearCheck;
            this.DayCheckNext = dayCheckNext;
            this.MounthCheckNext = mounthCheckNext;
            this.YearCheckNext = yearCheckNext;
            this.planned = planned;
        }

        public override bool Equals(object obj)
        {
            return obj is DBCinema cinema &&
                   NameCinema == cinema.NameCinema &&
                   DayCheck == cinema.DayCheck &&
                   MounthCheck == cinema.MounthCheck &&
                   YearCheck == cinema.YearCheck &&
                   DayCheckNext == cinema.DayCheckNext &&
                   MounthCheckNext == cinema.MounthCheckNext &&
                   YearCheckNext == cinema.YearCheckNext &&
                   Planned == cinema.Planned;
        }

        public override int GetHashCode()
        {
            var hashCode = -2114540231;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(NameCinema);
            hashCode = hashCode * -1521134295 + DayCheck.GetHashCode();
            hashCode = hashCode * -1521134295 + MounthCheck.GetHashCode();
            hashCode = hashCode * -1521134295 + YearCheck.GetHashCode();
            hashCode = hashCode * -1521134295 + DayCheckNext.GetHashCode();
            hashCode = hashCode * -1521134295 + MounthCheckNext.GetHashCode();
            hashCode = hashCode * -1521134295 + YearCheckNext.GetHashCode();
            hashCode = hashCode * -1521134295 + Planned.GetHashCode();
            return hashCode;
        }
    }
}
