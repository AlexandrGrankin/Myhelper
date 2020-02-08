﻿using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using static DataBaseCinema.Program;

//Доделать выборку строки (подстветка её полностью) и получение 

namespace DataBaseCinema
{
    public partial class GeneralForm : Form
    {
        //Адаптер для таблиц
        MyTableAdapter tableAdapter;

        public GeneralForm()
        {
            InitializeComponent();

            //Создали талицы
            MyTableCreate allCinemaTables = new MyTableCreate(allCinemaTable, allCinemaPage, "Все фирмы");
            MyTableCreate expectCheckTables = new MyTableCreate(expectCheckTable, expectCheckPage, "Ожидают проверки");
            MyTableCreate passCheckTables = new MyTableCreate(passCheckTable, passCheckPage, "Прошли проверку");
            MyTableCreate cheduleCheckTables = new MyTableCreate(cheduleCheckTable, cheduleCheckPage, "Запланированная проверка");
            //Передаем управление адаптеру
            tableAdapter = new MyTableAdapter(allCinemaTables, expectCheckTables, passCheckTables, cheduleCheckTables);
        }

        private void GeneralForm_Load(object sender, EventArgs e)
        {
            //Настройка TextBox
            textSearch.Multiline = true;
            textSearch.ScrollBars = ScrollBars.Vertical;

            //Установка даты глобально
            MyData.day = DateTime.Now.Day;
            MyData.mounth = DateTime.Now.Month;
            MyData.year = DateTime.Now.Year;
            MyData.date = DateTime.Now;
            labelDate.Text = "Дата сегодня: " + MyData.day +"." + MyData.mounth +"."+ MyData.year;
        }

        private void addCinema_Click(object sender, EventArgs e)
        {
            //Добовляем элемент в таблицу
            tableAdapter.add(this);
        }

        private void deleteCinema_Click(object sender, EventArgs e)
        {
            //получаем таблицу
            Control indexTable = allCinemaControl.SelectedTab.Controls[0];
            //Получаем номер таблицы
            int indexElement = allCinemaControl.SelectedIndex;

            DataGridView table = (DataGridView)indexTable;
            try
            {
                Console.WriteLine(table.CurrentRow.Index + " " + indexElement);
            } catch(Exception exp) {
                return;
            }

            tableAdapter.del(this, indexElement, table.CurrentRow.Index);
        }

        private void allCinemaTable_SelectionChanged(object sender, EventArgs e)
        {
            //Выкидывает ошибку при выделении и сортировке
            try
            {
                //получаем таблицу
                Control indexTable = allCinemaControl.SelectedTab.Controls[0];
                //Получаем номер таблицы
                int indexElement = allCinemaControl.SelectedIndex;
                DataGridView table = (DataGridView)indexTable;

                //Надо искать активную вкладку
                textSearch.Text = tableAdapter.getNameSelectElement(indexElement, table.CurrentRow.Index).NameCinema;
            }
            catch(Exception exp)
            {
                Console.WriteLine("Предупреждение, НЕ ОШИБКА!");
            }
        }

        private void expectCheckTable_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                //получаем таблицу
                Control indexTable = allCinemaControl.SelectedTab.Controls[0];
                //Получаем номер таблицы
                int indexElement = allCinemaControl.SelectedIndex;
                DataGridView table = (DataGridView)indexTable;

                //Надо искать активную вкладку
                textSearch.Text = tableAdapter.getNameSelectElement(indexElement, table.CurrentRow.Index).NameCinema;
            }
            catch (Exception exp)
            {
                Console.WriteLine("Предупреждение, НЕ ОШИБКА!");
            }
        }

        private void passCheckTable_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                //получаем таблицу
                Control indexTable = allCinemaControl.SelectedTab.Controls[0];
                //Получаем номер таблицы
                int indexElement = allCinemaControl.SelectedIndex;
                DataGridView table = (DataGridView)indexTable;

                //Надо искать активную вкладку
                textSearch.Text = tableAdapter.getNameSelectElement(indexElement, table.CurrentRow.Index).NameCinema;
            }
            catch (Exception exp)
            {
                Console.WriteLine("Предупреждение, НЕ ОШИБКА!");
            }
        }

        private void cheduleCheckTable_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                //получаем таблицу
                Control indexTable = allCinemaControl.SelectedTab.Controls[0];
                //Получаем номер таблицы
                int indexElement = allCinemaControl.SelectedIndex;
                DataGridView table = (DataGridView)indexTable;

                //Надо искать активную вкладку
                textSearch.Text = tableAdapter.getNameSelectElement(indexElement, table.CurrentRow.Index).NameCinema;
            }
            catch (Exception exp)
            {
                Console.WriteLine("Предупреждение, НЕ ОШИБКА!");
            }
        }

        private void changeCinema_Click(object sender, EventArgs e)
        {
            try
            {
                //получаем таблицу
                Control indexTable = allCinemaControl.SelectedTab.Controls[0];
                //Получаем номер таблицы
                int indexElement = allCinemaControl.SelectedIndex;
                DataGridView table = (DataGridView)indexTable;

                tableAdapter.change(this, indexElement, table.CurrentRow.Index);
            }
            catch (Exception exp)
            {
                Console.WriteLine("Предупреждение, НЕ ОШИБКА!");
            }
        }
    }
}
