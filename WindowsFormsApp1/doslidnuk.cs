using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class doslidnuk : Form
    {
        private OleDbConnection conn;
        private BindingSource bs1;

        public doslidnuk()
        {
            InitializeComponent();
            this.Load += new EventHandler(doslidnuk_Load);
        }

        private void doslidnuk_Load(object sender, EventArgs e)
        {
            this.Height = 320;

            //string connStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=your_database_path.accdb;";
            //conn = new OleDbConnection(connStr);

            DataTable dt = new DataTable();
            //OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM doslidnuk", conn);
            //this.Height = 320;
            h.bs1 = new BindingSource();
            h.bs1.DataSource = h.myfunDt("SELECT * FROM doslidnuk");
            dataGridView1.DataSource = h.bs1;
            bindingNavigator1.BindingSource = h.bs1;

            bs1 = new BindingSource();
            bs1.DataSource = dt;

            dataGridView1.DataSource = bs1;
            bindingNavigator1.BindingSource = bs1;

            dataGridView1.RowHeadersVisible = false;

            // Комбобокси
            cmbWork.Items.AddRange(new string[] { "", "Біолог", "Акролог" });
            cmbWork.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbWork.Text = "";

            cmbPosada.Items.AddRange(new string[] { "", "Дослідник", "Лаборант", "Старший дослідник" });
            cmbPosada.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPosada.Text = "";

            // Кнопки з ToolStrip
            btnFind.Click += new EventHandler(btnFind_Click);
            btnFilter.Click += new EventHandler(btnFilter_Click);

            // Пошук
            txtFind.TextChanged += new EventHandler(txtFind_TextChanged);
            txtFind.Leave += new EventHandler(txtFind_Leave);

            // Фільтрація
            btnFilterOk.Click += new EventHandler(btnFilterOk_Click);
            btnFilterCancel.Click += new EventHandler(btnFilterCancel_Click);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            bool show = btnFind.Checked;
            label1.Visible = show;
            txtFind.Visible = show;

            if (show) txtFind.Focus();
            else CancelFind();
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    var val = dataGridView1.Rows[i].Cells[j].Value;
                    if (val != null &&
                        val.ToString().IndexOf(txtFind.Text, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        dataGridView1.Rows[i].Selected = true;
                        break;
                    }
                }
            }
        }

        private void txtFind_Leave(object sender, EventArgs e)
        {
            btnFind.Checked = false;
            CancelFind();
        }

        private void CancelFind()
        {
            label1.Visible = false;
            txtFind.Visible = false;
            txtFind.Text = "";
            foreach (DataGridViewRow row in dataGridView1.Rows)
                row.Selected = false;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            bool show = btnFilter.Checked;
            groupBox1.Visible = show;
            this.Height = show ? 450 : 320;
        }

        private void btnFilterOk_Click(object sender, EventArgs e)
        {
            string strFilter = "1=1";

            if (!string.IsNullOrWhiteSpace(txtName.Text))
                strFilter += $" AND Name LIKE '%{txtName.Text}%'";

            if (!string.IsNullOrWhiteSpace(txtIddoslidnuka.Text))
                strFilter += $" AND Iddoslidnuk = {txtIddoslidnuka.Text}";

            if (!string.IsNullOrWhiteSpace(txtYearsOld.Text))
                strFilter += $" AND YearsOld = {txtYearsOld.Text}";

            if (!string.IsNullOrWhiteSpace(cmbWork.Text))
                strFilter += $" AND Work = '{cmbWork.Text}'";

            if (!string.IsNullOrWhiteSpace(cmbPosada.Text))
                strFilter += $" AND Posada = '{cmbPosada.Text}'";

            bs1.Filter = strFilter;
        }

        private void btnFilterCancel_Click(object sender, EventArgs e)
        {
            bs1.RemoveFilter();
        }

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics gfx = e.Graphics;
            Pen p = new Pen(Color.DarkViolet, 1);
            gfx.DrawLine(p, 0, 5, 5, 5);
            gfx.DrawLine(p, 35, 5, e.ClipRectangle.Width - 2, 5);
            gfx.DrawLine(p, 0, 5, 0, e.ClipRectangle.Height - 2);
            gfx.DrawLine(p, e.ClipRectangle.Width - 2, 5, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2);
            gfx.DrawLine(p, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2, 0, e.ClipRectangle.Height - 2);
        }
    }
}

