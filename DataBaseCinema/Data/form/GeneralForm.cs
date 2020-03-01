using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using static DataBaseCinema.Program;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace DataBaseCinema
{
    public partial class GeneralForm : Form
    {
        //Адаптер для таблиц
        MyTableAdapter tableAdapter;
        MyTableCreate allCinemaTables;
        public GeneralForm()
        {
            InitializeComponent();

            //Создали таблицы
            allCinemaTables = new MyTableCreate(allCinemaTable, allCinemaPage, "Все фирмы");
            MyTableCreate expectCheckTables = new MyTableCreate(expectCheckTable, expectCheckPage, "Ожидают проверки");
            MyTableCreate passCheckTables = new MyTableCreate(passCheckTable, passCheckPage, "Прошли проверку");
            MyTableCreate cheduleCheckTables = new MyTableCreate(cheduleCheckTable, cheduleCheckPage, "Запланированная проверка");
            //Передаем управление адаптеру
            tableAdapter = new MyTableAdapter(allCinemaTables, expectCheckTables, passCheckTables, cheduleCheckTables);

            loadDataBase();
            //comboBox1.DataSource = list;
        }

        private void GeneralForm_Load(object sender, EventArgs e)
        {
            //Настройка TextBox
            //comboBox1.Multiline = true;
            //comboBox1.ScrollBars = ScrollBars.Vertical;

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
        //Заполняет comboBox1 по нажатию на таблицу
        private void allCinemaTable_SelectionChanged(object sender, EventArgs e)
        {
            /*
            //Выкидывает ошибку при выделении и сортировке
            try
            {
                //получаем таблицу
                Control indexTable = allCinemaControl.SelectedTab.Controls[0];
                //Получаем номер таблицы
                int indexElement = allCinemaControl.SelectedIndex;
                DataGridView table = (DataGridView)indexTable;

                //Надо искать активную вкладку
                comboBox1.Text = tableAdapter.getNameSelectElement(indexElement, table.CurrentRow.Index).NameCinema;
            }
            catch(Exception exp)
            {
                Console.WriteLine("Предупреждение, НЕ ОШИБКА!");
            }
            */
        }
        //Заполняет comboBox1 по нажатию на таблицу
        private void expectCheckTable_SelectionChanged(object sender, EventArgs e)
        {
            /*
            try
            {
                //получаем таблицу
                Control indexTable = allCinemaControl.SelectedTab.Controls[0];
                //Получаем номер таблицы
                int indexElement = allCinemaControl.SelectedIndex;
                DataGridView table = (DataGridView)indexTable;

                //Надо искать активную вкладку
                comboBox1.Text = tableAdapter.getNameSelectElement(indexElement, table.CurrentRow.Index).NameCinema;
            }
            catch (Exception exp)
            {
                Console.WriteLine("Предупреждение, НЕ ОШИБКА!");
            }
            */
        }
        //Заполняет comboBox1 по нажатию на таблицу
        private void passCheckTable_SelectionChanged(object sender, EventArgs e)
        {
            /*
            try
            {
                //получаем таблицу
                Control indexTable = allCinemaControl.SelectedTab.Controls[0];
                //Получаем номер таблицы
                int indexElement = allCinemaControl.SelectedIndex;
                DataGridView table = (DataGridView)indexTable;

                //Надо искать активную вкладку
                comboBox1.Text = tableAdapter.getNameSelectElement(indexElement, table.CurrentRow.Index).NameCinema;
            }
            catch (Exception exp)
            {
                Console.WriteLine("Предупреждение, НЕ ОШИБКА!");
            }
            */
        }
        //Заполняет comboBox1 по нажатию на таблицу
        private void cheduleCheckTable_SelectionChanged(object sender, EventArgs e)
        {
            /*
            try
            {
                //получаем таблицу
                Control indexTable = allCinemaControl.SelectedTab.Controls[0];
                //Получаем номер таблицы
                int indexElement = allCinemaControl.SelectedIndex;
                DataGridView table = (DataGridView)indexTable;

                //Надо искать активную вкладку
                comboBox1.Text = tableAdapter.getNameSelectElement(indexElement, table.CurrentRow.Index).NameCinema;
            }
            catch (Exception exp)
            {
                Console.WriteLine("Предупреждение, НЕ ОШИБКА!");
            }
            */
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

        //Импорт данных
        private void importFile_Click(object sender, EventArgs e)
        {
            MyData.listValue.Clear();
            DataBaseCinema.Data.form.ImportForm importForm = new DataBaseCinema.Data.form.ImportForm();
            importForm.Owner = this;
            importForm.ShowDialog();
            if(MyData.listValue.Count == 0)
            {
                Console.WriteLine("Данные не импортированны!");
                return;
            }

            tableAdapter.addListImport(this);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            String str ="";

            try
            {
                Console.WriteLine(comboBox1.SelectedItem.ToString());
                str = comboBox1.SelectedItem.ToString();
            }
            catch(Exception exp) { }
            comboBox1.Items.Clear();
            //получаем таблицу
            Control indexTable = allCinemaControl.SelectedTab.Controls[0];
            //Получаем номер таблицы
            int indexElement = allCinemaControl.SelectedIndex;
            DataGridView table = (DataGridView)indexTable;

            //перехоd!!!!!!!!!!!!!!!!!!!!!!!!
            for(int i = 0; i < table.Rows.Count; i++)
            {
                if (table.Rows[i].Cells[0].Value.ToString().Equals(str))
                {
                    table.CurrentCell = table.Rows[i].Cells[0];
                    textBox1.Text = "Начните писать текст для поиска по таблице...";
                    break;
                }
            }
        }

        BindingList<String> list = new BindingList<string>();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            comboBox1.DroppedDown = false;
            Console.WriteLine("work");
            if (textBox1.Text.Length != 0 && !textBox1.Text.Equals("Начните писать текст для поиска по таблице..."))
            {
                comboBox1.DroppedDown = false;
            }
            else return;

            comboBox1.Items.Clear();

            //получаем таблицу
            Control indexTable = allCinemaControl.SelectedTab.Controls[0];
            //Получаем номер таблицы
            int indexElement = allCinemaControl.SelectedIndex;
            DataGridView table = (DataGridView)indexTable;

            for (int i = 0; i < table.Rows.Count; i++)
            {
                if (table.Rows[i].Cells[0].Value.ToString().IndexOf(textBox1.Text) > -1)
                    comboBox1.Items.Add(table.Rows[i].Cells[0].Value);
            }

            //comboBox1.SelectionStart = comboBox1.Text.Length;
            comboBox1.DroppedDown = true;
            Cursor.Current = Cursors.Default;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void saveChange_Click(object sender, EventArgs e)
        {

            DBCinema[] db = new DBCinema[allCinemaTables.data.Count];

            for(int i = 0; i < allCinemaTables.data.Count; i++)
            {
                db[i] = allCinemaTables.data[i];
            }


            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fs = new FileStream("DataBase.dat", FileMode.OpenOrCreate))
            {
                // сериализуем весь массив people
                formatter.Serialize(fs, db);

                MessageBox.Show("Сохранение данных прошло успешно!", "Сохранение...");
                Console.WriteLine("Объект сериализован");
            }
        }

        private void loadDataBase()
        {

            BinaryFormatter formatter = new BinaryFormatter();
            // десериализация
            using (FileStream fs = new FileStream("DataBase.dat", FileMode.OpenOrCreate))
            {
                DBCinema[] deserilizePeople = new DBCinema[0];
                try
                {
                    deserilizePeople = (DBCinema[])formatter.Deserialize(fs);
                }catch(Exception exp)
                {  }
                MyData.listValue.Clear();

                foreach (DBCinema p in deserilizePeople)
                {
                    MyData.listValue.Add(p);
                }
            }

            tableAdapter.addListImport(this);
            
        }

    }
}