using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Jordan
{
    public partial class Form1 : Form
    {
        string change_name = "";
        int rows, colms, raz_row, raz_col;
        double razr_elem;
        double[,] matrix;
        void setsize(DataGridView getter) //задаем размер матрицы
        {
            int columnCount = getter.ColumnCount;
            if (columnCount != 0)
                getter.Columns.Clear();
            DataGridViewColumn col;
            for (int j = 0; j < colms; j++)
            {
                col = new DataGridViewTextBoxColumn();
                col.Width = 50;
                getter.Columns.Add(col);
            }
            for (int i = 0; i < rows; i++)
                getter.Rows.Add();
        }

        public Form1()
        {
            InitializeComponent();
        }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void button1_Click_1(object sender, EventArgs e) //
        {
            try
            {
                colms = Convert.ToInt32(textBox1.Text);
                rows = Convert.ToInt32(textBox2.Text);
                matrix = new double[rows, colms];
                setsize(dataGridView1);
                for (int i = 1; i < dataGridView1.Columns.Count; i++)
                {
                    dataGridView1.Columns[i].HeaderCell.Value
                        = "-x"+i.ToString();
                }
                dataGridView1.Columns[0].HeaderCell.Value = "1";
                for (int j = 0; j < dataGridView1.Rows.Count-1; j++)
                {
                    dataGridView1.Rows[j].HeaderCell.Value
                        = "x"+(j+1+rows).ToString();
                }
                dataGridView1.Rows[rows-2].HeaderCell.Value = "f:";
                dataGridView1.Rows[rows-1].HeaderCell.Value = "g:";

                setsize(dataGridView2);
                for (int i = 1; i < dataGridView2.Columns.Count; i++)
                {
                    dataGridView2.Columns[i].HeaderCell.Value
                        = "-x" + i.ToString();
                }
                dataGridView2.Columns[0].HeaderCell.Value = "1";
                for (int j = 0; j < dataGridView2.Rows.Count-1; j++)
                {
                    dataGridView2.Rows[j].HeaderCell.Value
                        = "x"+(j+1+rows).ToString();
                }
                dataGridView2.Rows[rows-2].HeaderCell.Value = "f:";
                dataGridView2.Rows[rows-1].HeaderCell.Value = "g:";
            }
            catch (Exception)
            {
                MessageBox.Show("ОШИБКА! Проверьте корректность данных");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            raz_row = Convert.ToInt16(textBox3.Text);
            raz_col = Convert.ToInt16(textBox4.Text);
            double[,] spokuha = new double [rows, colms];
            razr_elem = Convert.ToDouble(dataGridView1[raz_col, raz_row].Value);

            change_name = Convert.ToString(dataGridView1.Rows[raz_row].HeaderCell.Value);
            dataGridView1.Rows[raz_row].HeaderCell.Value = dataGridView1.Columns[raz_col].HeaderCell.Value;
            dataGridView1.Columns[raz_col].HeaderCell.Value = change_name;

            for (int i = 0; i < rows; i++) 
                for (int j = 0; j < colms; j++) 
                {
                    matrix[i, j] = raz_row;
                    matrix[i, j] = raz_col;
                    matrix[i, j] = Convert.ToDouble(dataGridView1[j, i].Value);
                    matrix[raz_row, j] = Convert.ToDouble(dataGridView1[j, raz_row].Value);
                    matrix[i, raz_col] = Convert.ToDouble(dataGridView1[raz_col, i].Value);

                    if (dataGridView1.Rows[rows - 1].Cells[j].Value == null)
                    {
                        double sum = 0;
                        for (int a = 0; a < rows - 2; a++)
                        {
                            sum = sum + Convert.ToDouble(dataGridView1.Rows[a].Cells[j].Value) * -1;
                            dataGridView1.Rows[rows - 1].Cells[j].Value = sum.ToString();
                        }
                    }

                    if ((i == raz_row) && (j == raz_col))
                    {
                        spokuha[i, j] = 1 / razr_elem;
                        dataGridView2.Rows[i].Cells[j].Value = spokuha[i, j].ToString();
                    }
                    if ((i == raz_row) && (j != raz_col))
                    {
                        spokuha[i, j] = matrix[raz_row, j] / razr_elem;
                        dataGridView2.Rows[i].Cells[j].Value = spokuha[i, j].ToString();
                    }
                    if ((i != raz_row) && (j == raz_col))
                    {
                        spokuha[i, j] = matrix[i, raz_col] * (-1);
                        dataGridView2.Rows[i].Cells[j].Value = spokuha[i, j].ToString();
                    }
                    if ((i != raz_row) && (j != raz_col))
                    {
                        spokuha[i, j] = ((matrix[i, j] * razr_elem) - (matrix[i, raz_col] * matrix[raz_row, j])) / razr_elem;
                        dataGridView2.Rows[i].Cells[j].Value = spokuha[i, j].ToString();
                    }
                }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < colms; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = null;
                    dataGridView1.Rows[i].Cells[j].Value = dataGridView2.Rows[i].Cells[j].Value;
                    dataGridView2.Rows[i].Cells[j].Value = null;  
                }
        }
   }
}
