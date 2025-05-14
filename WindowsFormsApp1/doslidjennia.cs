using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class doslidjennia : Form
    {
        public doslidjennia()
        {
            InitializeComponent();
        }

        private void doslidjennia_Load(object sender, EventArgs e)
        {
            this.Height = 320;

            // Прив’язка таблиці до DataGridView і BindingNavigator
            h.bs1 = new BindingSource();
            h.bs1.DataSource = h.myfunDt("SELECT * FROM doslidjennia");
            dataGridView1.DataSource = h.bs1;
            bindingNavigator1.BindingSource = h.bs1;

            DGWFormat();

            // Отримуємо межі Id_doslidjennia
            DataTable dtBorder = h.myfunDt("SELECT MIN(Id_doslidjennia), MAX(Id_doslidjennia) FROM doslidjennia");

            if (dtBorder.Rows.Count > 0)
            {
                txtIDDJ.Text = dtBorder.Rows[0][0].ToString(); // мінімальний Id
                txtIDDJ.Text = dtBorder.Rows[0][1].ToString();   // максимальний Id
            }

            // comboBox1: Живі організми та Їжа
            comboBox1.Items.Clear();
            comboBox1.Items.Add("");
            comboBox1.Items.Add("Живі організми");
            comboBox1.Items.Add("Їжа");
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Text = "";

            // comboBox2: Грунти, Трави, Організми, Будинки, Продукти
            comboBox2.Items.Clear();
            comboBox2.Items.Add("");
            comboBox2.Items.Add("Грунти");
            comboBox2.Items.Add("Трави");
            comboBox2.Items.Add("Організми");
            comboBox2.Items.Add("Будинки");
            comboBox2.Items.Add("Продукти");
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.Text = "";

            // comboBox3: Паразити та Санітари
            comboBox3.Items.Clear();
            comboBox3.Items.Add("");
            comboBox3.Items.Add("Паразити");
            comboBox3.Items.Add("Санітари");
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.Text = "";
        }




        void DGWFormat()
        {
            dataGridView1.Columns[0].Width = 25;
            dataGridView1.Columns[1].HeaderText = "N";
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
                //label1.Visible = false;
                //txtFind.Visible = false;
                //txtFind.Text = "";
                //for (int i = 0; i < dataGridView1.RowCount; i++)
                    //dataGridView1.Rows[i].Selected = false;
                    CancelFind();

            }

        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().ToLower().Contains(txtFind.Text.ToLower()))
                        {
                            dataGridView1.Rows[i].Selected = true;
                            break;
                        }

            }
        }

        private void txtFind_Leave(object sender, EventArgs e)
        {
            //btnFind.Checked = false;
            //label1.Visible = false;
            // txtFind.Visible = false;
            //txtFind.Text = "";
            //for(int i=0; i<dataGridView1.RowCount; i++)
            //dataGridView1.Rows[i].Selected = false;

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

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            {
                Graphics gfx = e.Graphics;
                Pen p = new Pen(Color.DarkViolet, 1); // колір і товщина рамки
                gfx.DrawLine(p, 0, 5, 5, 5); // верхня горизонтальна лінія до Text
                gfx.DrawLine(p, 35, 5, e.ClipRectangle.Width - 2, 5); // верхня горизонтальна лінія після Text
                gfx.DrawLine(p, 0, 5, 0, e.ClipRectangle.Height - 2); // ліва вертикальна лінія
                gfx.DrawLine(p, e.ClipRectangle.Width - 2, 5, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2); // права вертикальна лінія
                gfx.DrawLine(p, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2, 0, e.ClipRectangle.Height - 2); // нижня горизонтальна лінія

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if(btnFilter.Checked)
            {
                this.Height = 450;
                groupBox1.Visible = true;
            }
            else
            {
                this.Height = 320;
                groupBox1.Visible = false;
            }
        }

        private void btnFilterOk_Click(object sender, EventArgs e)
        {
            string strFilter = "1=1"; // початковий фільтр (завжди істинний)

            // Фільтр по Id_doslidjennia (межі)
            if (!string.IsNullOrWhiteSpace(txtIDDJ.Text))
                strFilter += " AND Id_doslidjennia >= " + txtIDDJ.Text;
            if (!string.IsNullOrWhiteSpace(txtIDDJ.Text))
                strFilter += " AND Id_doslidjennia <= " + txtIDDJ.Text;

            // Фільтр по comboBox1 (тип: Живі організми / Їжа)
            if (!string.IsNullOrWhiteSpace(comboBox1.Text))
                strFilter += $" AND type = '{comboBox1.Text}'";

            // Фільтр по comboBox2 (розміщення: Грунти, Трави...)
            if (!string.IsNullOrWhiteSpace(comboBox2.Text))
                strFilter += $" AND rozmichennia = '{comboBox2.Text}'";

            // Фільтр по comboBox3 (значення: Паразити, Санітари)
            if (!string.IsNullOrWhiteSpace(comboBox3.Text))
                strFilter += $" AND znachennia = '{comboBox3.Text}'";

            // Виводимо фільтр у повідомлення (для перевірки)
            MessageBox.Show(strFilter);

            // Застосовуємо фільтр
            h.bs1.Filter = strFilter;
        }



        private void btnFilterCancel_Click(object sender, EventArgs e)
        {
            h.bs1.RemoveFilter();
        }
    }
}
