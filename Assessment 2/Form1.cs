using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;

namespace Assessment_2
{
    public partial class Form1 : Form
    {
        public int R, C, a, b, c;

        Creator mc = new ConcreteCreator();


        private void btnMinus_Click(object sender, EventArgs e)
        {
            if ((dataGridView1.RowCount == dataGridView2.RowCount)&&(dataGridView1.ColumnCount == dataGridView2.ColumnCount))
            {
                Imatrix Matrix1 = mc.GetMatrixSide(dataGridView1);
                Imatrix Matrix2 = mc.GetMatrixSide(dataGridView2);

                Matrix<double> result = Matrix1.createMatrix(dataGridView1) - Matrix2.createMatrix(dataGridView2);

                dataGridView3.RowCount = (Convert.ToInt32(tbRow1.Text));
                R = dataGridView3.RowCount;
                dataGridView3.AllowUserToResizeColumns = true;
                dataGridView3.AutoResizeRows();

                dataGridView3.ColumnCount = (Convert.ToInt32(tbColumn1.Text));
                C = dataGridView3.ColumnCount;
                dataGridView3.AutoResizeColumns();


                for (R = 0; R < dataGridView1.Rows.Count; R++)
                {
                    for (C = 0; C < dataGridView1.ColumnCount; C++)
                    {

                        dataGridView3.Rows[R].Cells[C].Value = result[R, C];

                    }
                }
            }

            else
            {
                MessageBox.Show("Matrix A row and column must be same with Matrix B row and column!");
            }

           
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (dataGridView1.ColumnCount == dataGridView2.RowCount)
            {
                Imatrix Matrix1 = mc.GetMatrixSide(dataGridView1);
                Imatrix Matrix2 = mc.GetMatrixSide(dataGridView2);

                Matrix<double> result = Matrix1.createMatrix(dataGridView1) * Matrix2.createMatrix(dataGridView2);

                dataGridView3.RowCount = (Convert.ToInt32(tbRow1.Text));
                dataGridView3.AllowUserToResizeColumns = true;
                dataGridView3.AutoResizeRows();

                dataGridView3.ColumnCount = (Convert.ToInt32(tbColumn2.Text));

                dataGridView3.AutoResizeColumns();


                for (int r = 0; r < dataGridView3.RowCount; r++)
                {
                    for (int c = 0; c < dataGridView3.ColumnCount; c++)
                    {
                        dataGridView3.Rows[r].Cells[c].Value = result[r, c];
                    }
                }
            }

            else
            {
                MessageBox.Show("Matrix A Column should be same with Matrix B Row!");
            }

           
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            Imatrix Matrix1 = mc.GetMatrixSide(dataGridView1);

            if(tbRow1.Text != "" && tbColumn1.Text != "")
            {
                Matrix<double> result = Matrix1.createMatrix(dataGridView1).Transpose();


                dataGridView3.RowCount = (Convert.ToInt32(tbColumn1.Text));
                dataGridView3.AllowUserToResizeColumns = true;
                dataGridView3.AutoResizeRows();

                dataGridView3.ColumnCount = (Convert.ToInt32(tbRow1.Text));

                dataGridView3.AutoResizeColumns();


                for (int r = 0; r < dataGridView3.RowCount; r++)
                {
                    for (int c = 0; c < dataGridView3.ColumnCount; c++)
                    {
                        dataGridView3.Rows[r].Cells[c].Value = result[r, c];
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Fill in the Matrix A text Box.");
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView2.Columns.Clear();
            dataGridView2.Rows.Clear();
            tbRow1.Clear();
            tbColumn1.Clear();
            tbColumn2.Clear();
            tbRow2.Clear();
            groupBox2.Enabled = false;
            btnMinus.Enabled = false;
            btnMultiply.Enabled = false;
            btnPlus.Enabled = false;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tbColumn2_TextChanged(object sender, EventArgs e)
        {
   
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if ((dataGridView1.RowCount == dataGridView2.RowCount) && (dataGridView1.ColumnCount == dataGridView2.ColumnCount))
            {
                Imatrix Matrix1 = mc.GetMatrixSide(dataGridView1);
                Imatrix Matrix2 = mc.GetMatrixSide(dataGridView2);

                Matrix<double> result = Matrix1.createMatrix(dataGridView1) + Matrix2.createMatrix(dataGridView2);

                dataGridView3.RowCount = (Convert.ToInt32(tbRow1.Text));
                R = dataGridView3.RowCount;
                dataGridView3.AllowUserToResizeColumns = true;
                dataGridView3.AutoResizeRows();

                dataGridView3.ColumnCount = (Convert.ToInt32(tbColumn1.Text));
                C = dataGridView3.ColumnCount;
                dataGridView3.AutoResizeColumns();


                for (R = 0; R < dataGridView1.Rows.Count; R++)
                {
                    for (C = 0; C < dataGridView1.ColumnCount; C++)
                    {

                        dataGridView3.Rows[R].Cells[C].Value = result[R, C];

                    }
                }
            }

            else
            {
                MessageBox.Show("Matrix A row and column must be same with Matrix B row and column!");
            }
          
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate1_Click(object sender, EventArgs e)
        {
            //Create rows
            if (tbRow1.Text != "" && tbColumn1.Text != "")
            {
                dataGridView1.RowCount = (Convert.ToInt32(tbRow1.Text));
                R = dataGridView1.RowCount;
                dataGridView1.AllowUserToResizeColumns = true;
                dataGridView1.AutoResizeRows();

                dataGridView1.ColumnCount = (Convert.ToInt32(tbColumn1.Text));
                C = dataGridView1.ColumnCount;
                dataGridView1.AutoResizeColumns();

                btnTranspose.Enabled = true;
                groupBox2.Enabled = true;
            }
            else
            {
                MessageBox.Show("Please fill in the blank");
            }
        }

        private void btnCreate2_Click(object sender, EventArgs e)
        {
            if (tbRow2.Text != "" && tbColumn2.Text != "")
            {
                dataGridView2.RowCount = (Convert.ToInt32(tbRow2.Text));
                R = dataGridView2.RowCount;
                dataGridView2.AllowUserToResizeColumns = true;
                dataGridView2.AutoResizeRows();

                dataGridView2.ColumnCount = (Convert.ToInt32(tbColumn2.Text));
                C = dataGridView2.ColumnCount;
                dataGridView2.AutoResizeColumns();

                btnMinus.Enabled = true;
                btnMultiply.Enabled = true;
                btnPlus.Enabled = true;


            }

            else
            {
                MessageBox.Show("Please fill in the blank");
            }
        }
    }
}
