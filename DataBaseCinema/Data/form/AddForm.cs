using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DataBaseCinema.Program;

namespace DataBaseCinema
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            //MyData.value = new DBCinema("qwe", 1, 2, 3, 4, 5, 6);
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (nameCinema.Text.Equals(""))
            { 
                MessageBox.Show("Поле \"Наименование \" не должно быть пустым! ", "Ошибка!", MessageBoxButtons.OK);
                return;
            }

                
            if (new DateTime((int)yearCheck.Value,(int)mounthCheck.Value,(int)dayCheck.Value) > new DateTime((int)yearCheckNext.Value, (int)mounthCheckNext.Value, (int)dayCheckNext.Value))
            {
                MessageBox.Show("Дата прошлой проверки позже, даты следующей! ", "Ошибка!", MessageBoxButtons.OK);
                return;
            }

            if (new DateTime((int)yearCheck.Value, (int)mounthCheck.Value, (int)dayCheck.Value) == new DateTime((int)yearCheckNext.Value, (int)mounthCheckNext.Value, (int)dayCheckNext.Value))
            {
                MessageBox.Show("Дата прошлой проверки равна дате следующей! ", "Ошибка!", MessageBoxButtons.OK);
                return;
            }

            MyData.value = new DBCinema(nameCinema.Text, 
                (int)dayCheck.Value, 
                (int)mounthCheck.Value, 
                (int)yearCheck.Value, 
                (int)dayCheckNext.Value, 
                (int)mounthCheckNext.Value, 
                (int)yearCheckNext.Value,
                (bool)checkBoxPlanned.Checked
                );
            Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
