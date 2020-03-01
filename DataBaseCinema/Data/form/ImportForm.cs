using OfficeOpenXml;
using OfficeOpenXml.FormulaParsing.Excel.Functions.DateTime;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DataBaseCinema.Program;

namespace DataBaseCinema.Data.form
{
    
    public partial class ImportForm : Form
    {
        public BindingList<DBCinema> data;

        DataGridView dataGridGlobal;

        public ImportForm()
        {
            InitializeComponent();

            //Настраиваем сортировку по умолчанию
            IEnumerable<DBCinema> items = new BindingList<DBCinema>();
            System.Collections.ObjectModel.ObservableCollection<DBCinema> observableItems = new System.Collections.ObjectModel.ObservableCollection<DBCinema>(items);
            data = observableItems.ToBindingList();
            dataGridGlobal = dataGridViewImport;
            //Применяем данные в таблицу
            dataGridGlobal.DataSource = data;

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

        private void browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog myDialog = new OpenFileDialog();
            myDialog.Filter = "Microsoft Excel (*.xls*)|*.xls*";
            myDialog.Title = "Выберите документ Excel";
            myDialog.CheckFileExists = true;
            myDialog.Multiselect = false;
            if (myDialog.ShowDialog() == DialogResult.OK)
            {
                path.Text = myDialog.FileName;
            }

            //Открыть файл
            //Прочитать все нужные столбцы
            //Добавить их в наш список таблицы

            //Opening an existing Excel file
            FileInfo fi = new FileInfo(path.Text);
            using (ExcelPackage excelPackage = new ExcelPackage(fi))
            {
                //Get a WorkSheet by index. Note that EPPlus indexes are base 1, not base 0!
                ExcelWorksheet firstWorksheet = excelPackage.Workbook.Worksheets[1];

                //Get a WorkSheet by name. If the worksheet doesn't exist, throw an exeption
                //ExcelWorksheet namedWorksheet = excelPackage.Workbook.Worksheets["SomeWorksheet"];

                //If you don't know if a worksheet exists, you could use LINQ,
                //So it doesn't throw an exception, but return null in case it doesn't find it
                //ExcelWorksheet anotherWorksheet = excelPackage.Workbook.Worksheets.FirstOrDefault(x => x.Name == "SomeWorksheet");

                //Get the content from cells A1 and B1 as string, in two different notations
                int count = 24;
                while (true)
                {//Строка столец
                    string nameCinema;
                    String dateLastCheck;
                    String dateNextCheck;
                    try
                    {
                        if (firstWorksheet.Cells[count, 2].Value == null)
                            break;

                        nameCinema = firstWorksheet.Cells[count, 2].Value.ToString();

                        //dateLastCheck
                        if (firstWorksheet.Cells[count, 10].Value == null)
                        {
                            if (firstWorksheet.Cells[count, 9].Value == null)
                            {
                                dateLastCheck = "";
                            }
                            else
                            {
                                dateLastCheck = firstWorksheet.Cells[count, 9].Value.ToString();
                            }
                        }
                        else
                        {
                            dateLastCheck = firstWorksheet.Cells[count, 10].Value.ToString();
                        }
                        //dateNextCheck
                        if (firstWorksheet.Cells[count, 13].Value == null)
                        {                         
                                dateNextCheck = ""; 
                        }
                        else
                        {
                            dateNextCheck = firstWorksheet.Cells[count, 13].Value.ToString();
                        }
                        
                        try
                        {
                            DateTime datLast = new DateTime();
                            DateTime datNext = new DateTime();

                            if (!dateLastCheck.Equals(""))
                            {
                                datLast = DateTime.Parse(dateLastCheck);
                            }
                            else
                            {
                                datLast = DateTime.Parse("1.1.1111");
                            }

                            if (!dateNextCheck.Equals(""))
                            {
                                datNext = DateTime.Parse(dateNextCheck);
                            }
                            else
                            {
                                datNext = DateTime.Parse("1.1.1111");
                            }

                            data.Add(new DBCinema(nameCinema, datLast.Day, datLast.Month, datLast.Year, datNext.Day, datNext.Month, datNext.Year, true));
                        }
                        catch(Exception exp)
                        {

                        }

                        //DateTime myDate = DateTime.ParseExact("2009-05-08 14:40:52,531", "yyyy-MM-dd HH:mm:ss,fff", System.Globalization.CultureInfo.InvariantCulture);
                    }
                    catch (Exception exp)
                    {
                        break;
                    }
                    //Console.WriteLine(dateLastCheck);


                    count++;
                }



                //Save your file
                try
                {
                    excelPackage.Save();
                }
                catch (Exception exp)
                {

                }
            }
        }

        private void importing_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Новые данные, заменят совподающие существующие! \n Продолжить?", "Импортирование...", MessageBoxButtons.YesNo);

            if (DialogResult.No == result)
            {
                Close();
                return;
            }


            foreach (DBCinema p in data)
            {
                MyData.listValue.Add(p);
            }

            Close();

        }
    }
}
