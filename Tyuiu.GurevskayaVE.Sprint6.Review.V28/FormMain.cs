using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.GurevskayaVE.Sprint6.Review.V28.Lib;

namespace Tyuiu.GurevskayaVE.Sprint6.Review.V28
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        //int[,] matrix;
        DataService ds = new DataService();
        private void buttonGenerate_GVE_Click(object sender, EventArgs e)
        {
            try
            {
                Random rnd = new Random();


                int rows = Convert.ToInt32(textBoxN_GVE.Text);
                int columns = Convert.ToInt32(textBoxM_GVE.Text);
                int[,] matrix = new int[rows, columns];
                int n1 = Convert.ToInt32(textBoxN1_GVE.Text);
                int n2 = Convert.ToInt32(textBoxN2_GVE.Text);

                dataGridViewIn_GVE.ColumnCount = columns;
                dataGridViewIn_GVE.RowCount = rows;

                for (int i = 0; i < columns; i++)
                {
                    dataGridViewIn_GVE.Columns[i].Width = 50;
                }

                for (int i = 0; i < rows; i++) //stroki
                {
                    for (int j = 0; j < columns; j++) //stolbci
                    {
                        dataGridViewIn_GVE.Rows[i].Cells[j].Value = rnd.Next(Convert.ToInt32(textBoxN1_GVE.Text), Convert.ToInt32(textBoxN2_GVE.Text));
                        if (j % 2 == 0)
                        {
                            if ((Convert.ToInt32(dataGridViewIn_GVE.Rows[i].Cells[j].Value) % 2 == 0))
                            {
                                dataGridViewIn_GVE.Rows[i].Cells[j].Value = dataGridViewIn_GVE.Rows[i].Cells[j].Value;
                            }
                            else
                            {
                                dataGridViewIn_GVE.Rows[i].Cells[j].Value = Convert.ToInt32(dataGridViewIn_GVE.Rows[i].Cells[j].Value) + 1;
                                if(Convert.ToInt32(dataGridViewIn_GVE.Rows[i].Cells[j].Value) > n2)
                                {
                                    dataGridViewIn_GVE.Rows[i].Cells[j].Value = Convert.ToInt32(dataGridViewIn_GVE.Rows[i].Cells[j].Value) - 1;
                                }
                            }
                        }
                        else
                        {
                            if((Convert.ToInt32(dataGridViewIn_GVE.Rows[i].Cells[j].Value) % 2 != 0))
                            {
                                dataGridViewIn_GVE.Rows[i].Cells[j].Value = dataGridViewIn_GVE.Rows[i].Cells[j].Value;
                            }
                            else
                            {
                                dataGridViewIn_GVE.Rows[i].Cells[j].Value = Convert.ToInt32(dataGridViewIn_GVE.Rows[i].Cells[j].Value) + 1;
                                if (Convert.ToInt32(dataGridViewIn_GVE.Rows[i].Cells[j].Value) > n2)
                                {
                                    dataGridViewIn_GVE.Rows[i].Cells[j].Value = Convert.ToInt32(dataGridViewIn_GVE.Rows[i].Cells[j].Value) - 1;
                                }
                            }
                        }
                        
                        
                    }
                } 
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonDone_GVE_Click(object sender, EventArgs e) 
        {
            int rows = Convert.ToInt32(textBoxN_GVE.Text);
            int columns = Convert.ToInt32(textBoxM_GVE.Text);
            int[,] matrix = new int[rows,columns];
            textBoxRes_GVE.Clear();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = Convert.ToInt32(dataGridViewIn_GVE.Rows[i].Cells[j].Value.ToString());
                }
            }

            int C = Convert.ToInt32(textBoxC_GVE.Text);
            int K = Convert.ToInt32(textBoxK_GVE.Text);
            int L = Convert.ToInt32(textBoxL_GVE.Text);
            int n1 = Convert.ToInt32(textBoxN1_GVE.Text);
            int n2 = Convert.ToInt32(textBoxN2_GVE.Text);
            textBoxRes_GVE.Text = Convert.ToString(ds.GetMatrix(matrix, n1, n2, K, L, C));
        }

        private void groupBoxIn_GVE_Enter(object sender, EventArgs e)
        {
            //
        }
    }
}
