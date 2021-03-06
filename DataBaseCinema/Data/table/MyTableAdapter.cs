﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DataBaseCinema.Program;

namespace DataBaseCinema
{
    class MyTableAdapter
    {
        MyTableCreate allCinemaTable;
        MyTableCreate expectCheckTable;
        MyTableCreate passCheckTable;
        MyTableCreate cheduleCheckTable;

        public MyTableAdapter(MyTableCreate allCinemaTable,
            MyTableCreate expectCheckTable,
            MyTableCreate passCheckTable,
            MyTableCreate cheduleCheckTable)
        {
            this.allCinemaTable = allCinemaTable;
            this.expectCheckTable = expectCheckTable;
            this.passCheckTable = passCheckTable;
            this.cheduleCheckTable = cheduleCheckTable;
        }
        //Добавить запись
        public void add(GeneralForm form, bool visibleForm = true)
        {
            if (visibleForm)
            {
                MyData.value = null;
                AddForm addForm = new AddForm();
                addForm.Owner = form;
                addForm.ShowDialog();
            }

            //Если ничего не передали то сразу на выход
            if (MyData.value == null)
                return;

            DateTime dateTime = new DateTime(MyData.value.YearCheck, MyData.value.MounthCheck, MyData.value.DayCheck);
            DateTime dateTimeCheck = new DateTime(MyData.value.YearCheck, MyData.value.MounthCheck, MyData.value.DayCheck);

            dateTimeCheck = dateTimeCheck.AddYears(3);

            allCinemaTable.add();
            if (dateTimeCheck < DateTime.Now)
                expectCheckTable.add();
            else
                passCheckTable.add();
            //особое условие по чек боксу =)
            if (MyData.value.Planned)
                cheduleCheckTable.add();

            MyData.value = null;
        }
        public void addListImport(GeneralForm form)
        {
            
            for (int i = 0; i < MyData.listValue.Count; i++)
            {
                
                DateTime dateTimeCheck = new DateTime(MyData.listValue.ElementAt<DBCinema>(i).YearCheck,
                   MyData.listValue.ElementAt<DBCinema>(i).MounthCheck,
                   MyData.listValue.ElementAt<DBCinema>(i).DayCheck
                   );

                
                delName(MyData.listValue.ElementAt<DBCinema>(i).NameCinema);
                dateTimeCheck = dateTimeCheck.AddYears(3);

                allCinemaTable.add(MyData.listValue.ElementAt<DBCinema>(i));
                if (dateTimeCheck < DateTime.Now)
                    expectCheckTable.add(MyData.listValue.ElementAt<DBCinema>(i));
                else
                    passCheckTable.add(MyData.listValue.ElementAt<DBCinema>(i));
                //особое условие по чек боксу =)
                if (MyData.listValue.ElementAt<DBCinema>(i).Planned)
                    cheduleCheckTable.add(MyData.listValue.ElementAt<DBCinema>(i));

            }
            MyData.listValue.Clear();
        }
        //Изменить запись
        public void change(GeneralForm form, int indexTable, int indexElement)
        {
            MyData.value = null;
            DBCinema element = getNameSelectElement(indexTable, indexElement);

            ChangeForm changeForm = new ChangeForm(element);
            changeForm.Owner = form;


            if (DialogResult.OK == changeForm.ShowDialog())
            {
                if (MyData.value == null)
                    return;
                del(form, indexTable, indexElement, false);
                add(form, false);
                //allCinemaTable.change(element, MyData.value);
                //expectCheckTable.change(element, MyData.value);
                //passCheckTable.change(element, MyData.value);
                //cheduleCheckTable.change(element, MyData.value);
            }

            MyData.value = null;
        }
        //Удалить запись
        public void del(GeneralForm form, int indexTable, int indexElement, bool visibleForm = true)
        {
            DBCinema element = getNameSelectElement(indexTable, indexElement);
            if (visibleForm)
            {
                DelForm delForm = new DelForm(element);
                delForm.Owner = form;

                if (DialogResult.OK == delForm.ShowDialog())
                {
                    allCinemaTable.del(element);
                    expectCheckTable.del(element);
                    passCheckTable.del(element);
                    cheduleCheckTable.del(element);
                    return;
                }
            }
            else
            {

                allCinemaTable.del(element);
                expectCheckTable.del(element);
                passCheckTable.del(element);
                cheduleCheckTable.del(element);
            }
        }

        public void delName(String name)
        {
            //Беру имя первой строки импорта, ищу в allcinema по имени если есть удаляю её вездеи добавляю, если нет то просто добавляю
            if (allCinemaTable.searchName(name))
            {
                Console.WriteLine("Нашли по имени! Теперь нужно везде удалить по имени!");
                allCinemaTable.delName(name);
                expectCheckTable.delName(name);
                passCheckTable.delName(name);
                cheduleCheckTable.delName(name);
                return;
            }

        }

        //Определение выбраного элемента в активной таблице
        public DBCinema getNameSelectElement(int indexTable, int indexElement)
        {
            DBCinema element = null;

            //Есть проблема с выводом (больше нет)
            switch (indexTable)
            {
                case 0:
                    element = allCinemaTable.data.ElementAt(indexElement);
                    break;
                case 1:
                    element = expectCheckTable.data.ElementAt(indexElement);
                    break;
                case 2:
                    element = passCheckTable.data.ElementAt(indexElement);
                    break;
                case 3:
                    element = cheduleCheckTable.data.ElementAt(indexElement);
                    break;
                default:
                    break;

            }

            return element;
        }
    }
}
