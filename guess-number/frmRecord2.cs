using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace GuessNum
{
    public partial class frmRecord2 : Form
    {
        public frmRecord2()
        {
            InitializeComponent();
        }

        Guess_Num_DB cn = new Guess_Num_DB();

        private void frmRecord2_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = cn.showData2();
            dataGridView1.DataSource = ds.Tables["record_times2"];
            dataGridView1.ClearSelection();

            createTableColumns();
        }

        private void createTableColumns()
        {
            dataGridView1.Columns.Clear();

            dataGridView1.ScrollBars = ScrollBars.Both;

            dataGridView1.RowsDefaultCellStyle.BackColor = Color.White;
            dataGridView1.RowsDefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Black;
            dataGridView1.AlternatingRowsDefaultCellStyle.ForeColor = Color.White;

            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dataGridView1.RowHeadersDefaultCellStyle.BackColor = Color.Black;

            DataGridViewTextBoxColumn times = new DataGridViewTextBoxColumn();
            times.DataPropertyName = "times";
            times.Width = 160;
            times.HeaderText = "Times";
            times.Frozen = true;
            times.ValueType = typeof(string);
            dataGridView1.Columns.Add(times);

            foreach (DataGridViewColumn dgvc in dataGridView1.Columns)
            {
                dgvc.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
    }
}
