using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DataBaseCinema.Program;

namespace DataBaseCinema
{
    class MyTableCreate
    {
        //Список автоматически обновляющий таблицу
        public BindingList<DBCinema> data;

        DataGridView dataGridGlobal;
        TabPage page;
        String namePage;
        public MyTableCreate(DataGridView dataGrid, TabPage tabPage, String namePage)
        {
            //Настраиваем сортировку по умолчанию
            IEnumerable<DBCinema> items = new BindingList<DBCinema>();
            System.Collections.ObjectModel.ObservableCollection<DBCinema> observableItems = new System.Collections.ObjectModel.ObservableCollection<DBCinema>(items);
            data = observableItems.ToBindingList();
            dataGridGlobal = dataGrid;
            //Применяем данные в таблицу
            dataGridGlobal.DataSource = data;
            page = tabPage;
            this.namePage = namePage;

            updateHeaders();

            //Удаляет первый пустой столбец
            dataGridGlobal.RowHeadersVisible = false;

            //Задаем размер столбцам 
            dataGridGlobal.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridGlobal.Columns[0].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridGlobal.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dataGridGlobal.Columns[1].Width = 38;
            dataGridGlobal.Columns[2].Width = 50;
            dataGridGlobal.Columns[3].Width = 50;
            dataGridGlobal.Columns[4].Width = 38;
            dataGridGlobal.Columns[5].Width = 50;
            dataGridGlobal.Columns[6].Width = 50;
            //dataGrid.Columns[1].SortMode = DataGridViewColumnSortMode.Automatic;

            //Выбирается только одна строка
            dataGridGlobal.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //Запрет на выбор несколких строк
            dataGridGlobal.MultiSelect = false;
            //Запрет на изменение размера строки
            dataGridGlobal.AllowUserToResizeRows = false;
        }

        public void add()
        {
            data.Add(new DBCinema(MyData.value.NameCinema,
                MyData.value.DayCheck,
                MyData.value.MounthCheck,
                MyData.value.YearCheck,
                MyData.value.DayCheckNext,
                MyData.value.MounthCheckNext,
                MyData.value.YearCheckNext,
                MyData.value.Planned
                ));
            updateHeaders();
        }
        public void add(DBCinema dBCinema)
        {
            data.Add(dBCinema);
            updateHeaders();
        }

        public void del(DBCinema dBCinema)
        {
            try
            {
                //Удаляем выбраный элемент
                data.Remove(dBCinema);
                updateHeaders();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Элемент пуст, а хочешь что то удалить! Не критично, безопасно (уже)!");
            }

        }

        public void delName(String name)
        {
            try
            {
                //Удаляем выбраный элемент
                for (int i = 0; i < data.Count; i++)
                {
                    if (data[i].NameCinema.Equals(name))
                    {
                        data.Remove(data[i]);
                        break;
                    }
                }

                updateHeaders();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Элемент пуст, а хочешь что то удалить! Не критично, безопасно (уже)!");
            }

        }

        public void change(DBCinema dBCinema, DBCinema newDBCinema)
        {
            try
            {
                data.Remove(dBCinema);
                data.Add(newDBCinema);
            } catch(Exception exp)
            {
                Console.WriteLine("Ошибка при изменении!");
            }
        }

        private void updateHeaders()
        {
            //Приравниваем текст с количеством данных
            page.Text = namePage + " (" + data.Count + ")";
        }

        public bool searchName(String name)
        {

            foreach (DBCinema s in data)
            {
                if (s.NameCinema.Equals(name))
                    return true;
            }
            return false;
        }

    }
}
