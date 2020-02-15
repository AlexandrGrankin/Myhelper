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

namespace DataBaseCinema.Data.form
{
    public partial class ImportForm : Form
    {
        public ImportForm()
        {
            InitializeComponent();
        }

        private void browse_Click(object sender, EventArgs e)
        {

        }

        private void importing_Click(object sender, EventArgs e)
        {
            //Тест потом удалить
            //MyData.listValue.Add(new DBCinema("AddImport1AddImport1 AddImport1AddImport1AddI mport1AddImport1AddImport1AddImp ort1AddImport1AddImpor t1AddImport1AddImport1Add ort1AddImport1AddImport1Add Import1AddImport1AddImport1AddImpor t1AddImport1AddImport1Add Import1AddImport1AddImport1AddImport1", 1, 2, 1234, 3, 4, 5678, true));
            MyData.listValue.Add(new DBCinema("AddImport22", 1, 3, 1334, 3, 2, 5218, false));
            MyData.listValue.Add(new DBCinema("AddImport111", 1, 2, 1234, 3, 4, 5678, true));
            MyData.listValue.Add(new DBCinema("AddImport222", 1, 3, 1334, 3, 2, 5218, false));
            MyData.listValue.Add(new DBCinema("AddImport1111", 1, 2, 1234, 3, 4, 5678, true));
            MyData.listValue.Add(new DBCinema("AddImport2222", 1, 3, 1334, 3, 2, 5218, false));
            MyData.listValue.Add(new DBCinema("AddImport11111", 1, 2, 1234, 3, 4, 5678, true));
            MyData.listValue.Add(new DBCinema("AddImport22222", 1, 3, 1334, 3, 2, 5218, false));
            MyData.listValue.Add(new DBCinema("AddImport111111", 1, 2, 1234, 3, 4, 5678, true));
            MyData.listValue.Add(new DBCinema("AddImport222222", 1, 3, 1334, 3, 2, 5218, false));
            MyData.listValue.Add(new DBCinema("AddImport1111111", 1, 2, 1234, 3, 4, 5678, true));
            MyData.listValue.Add(new DBCinema("AddImport2222222", 1, 3, 1334, 3, 2, 5218, false));

            Close();

        }
    }
}
