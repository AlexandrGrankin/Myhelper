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
    public partial class ChangeForm : Form
    {
        DBCinema dBCinema;
        public ChangeForm(DBCinema dBCinema)
        {
            InitializeComponent();
            this.dBCinema = dBCinema;
        }

        private void ChangeForm_Load(object sender, EventArgs e)
        {
            nameCinema.Text = dBCinema.NameCinema;
            dayCheck.Value = dBCinema.DayCheck;
            dayCheckNext.Value = dBCinema.DayCheckNext;
            mounthCheck.Value = dBCinema.MounthCheck;
            mounthCheckNext.Value = dBCinema.MounthCheckNext;
            yearCheck.Value = dBCinema.YearCheck;
            yearCheckNext.Value = dBCinema.YearCheckNext;
            checkBoxPlanned.Checked = dBCinema.Planned;
        }

        private void add_Click(object sender, EventArgs e)
        {
            
            if (!nameCinema.Text.Equals(""))
            {
                MyData.value = new DBCinema(nameCinema.Text,
                (int)dayCheck.Value,
                (int)mounthCheck.Value,
                (int)yearCheck.Value,
                (int)dayCheckNext.Value,
                (int)mounthCheckNext.Value,
                (int)yearCheckNext.Value,
                (bool)checkBoxPlanned.Checked);
            }

            Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
