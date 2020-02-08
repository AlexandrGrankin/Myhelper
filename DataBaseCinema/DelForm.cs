using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseCinema
{
    public partial class DelForm : Form
    {
        DBCinema dBCinema;
        public DelForm(DBCinema dBCinema)
        {
            InitializeComponent();
            this.dBCinema = dBCinema;
        }

        private void DelForm_Load(object sender, EventArgs e)
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
            Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
