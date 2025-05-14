using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class akarologia : Form
    {
        public akarologia()
        {
            InitializeComponent();
        }



        private void akarologia_Load(object sender, EventArgs e)
        {
            this.Height = 320;
            h.bs1 = new BindingSource();
            h.bs1.DataSource = h.myfunDt("SELECT * FROM akarologia");
            dataGridView1.DataSource = h.bs1;
            bindingNavigator1.BindingSource = h.bs1;

            dataGridView1.RowHeadersVisible = false;
            //h.bs1.Sort = "idAkarologia, pidvyd";
            //DGWFormat();

            //DataTable dtBorder = h.myfunDt("SELECT MIN(idAkarologia), MAX(idAkarologia) FROM akarologia");

            //if (dtBorder.Rows.Count > 0)
            //{
            //    label2.Text = dtBorder.Rows[0][0].ToString(); // Мінімальний ID
            //    label3.Text = dtBorder.Rows[0][1].ToString(); // Максимальний ID
            //}

            comboBox1.Items.Clear();
            comboBox1.Items.Add("");
            comboBox1.Items.Add("Львів");
            comboBox1.Items.Add("Київ");
            comboBox1.Items.Add("Одеса");
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Text = "";

            comboBox2.Items.Clear();
            comboBox2.Items.Add("");
            comboBox2.Items.Add("рослиноїд");
            comboBox2.Items.Add("хижак");
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.Text = "";
        }

        void DGWFormat()
        {
            if (dataGridView1.Columns.Count > 0)
            {
                dataGridView1.Columns[0].Width = 50;
                dataGridView1.Columns[0].HeaderText = "ID";
                dataGridView1.Columns[1].HeaderText = "Місце дослідження";
                dataGridView1.Columns[2].HeaderText = "Підвид";
                // Додай інші заголовки за потреби
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (btnFind.Checked)
            {
                label1.Visible = true;
                txtFind.Visible = true;
                txtFind.Focus();
            }
            else
            {
                CancelFind();
            }
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                    {
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().ToLower().Contains(txtFind.Text.ToLower()))
                        {
                            dataGridView1.Rows[i].Selected = true;
                            break;
                        }
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
            for (int i = 0; i < dataGridView1.RowCount; i++)
                dataGridView1.Rows[i].Selected = false;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            string strFilter = "1=1";

            if (!string.IsNullOrWhiteSpace(txtIDDJ.Text))
            {
                strFilter += $" AND idAkarologia = {txtIDDJ.Text}";
            }

            if (!string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                strFilter += $" AND Misce_doslidjennia = '{comboBox1.Text}'";
            }

            if (!string.IsNullOrWhiteSpace(comboBox2.Text))
            {
                strFilter += $" AND pidvyd = '{comboBox2.Text}'";
            }

            h.bs1.Filter = strFilter;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            h.bs1.RemoveFilter();
        }
    }
}

