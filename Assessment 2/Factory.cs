using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;
using System.Windows.Forms;

namespace Assessment_2
{
    interface Imatrix
    {
        Matrix<double> createMatrix(DataGridView gridview);
    }

    class ConcreteMatrix : Imatrix
    {
        public Matrix<double> createMatrix(DataGridView gridview)
        {


            int RowCount = gridview.Rows.Count;
            int ColumnCount = gridview.Columns.Count;


            int i, j, f, p;


            double[,] M = new double[RowCount, ColumnCount];
        



            for (i = 0; i < gridview.Rows.Count; i++)
            {
                for (j = 0; j < gridview.Columns.Count; j++)
                {
                    M[i, j] = Convert.ToDouble(gridview.Rows[i].Cells[j].Value);
                }
            }

            Matrix<double> Matrix = DenseMatrix.OfArray(M);

            return Matrix;



        }



    }

   

    abstract class Creator
    {
        public abstract Imatrix GetMatrixSide(DataGridView gridview);
    }

    class ConcreteCreator : Creator
    {
        public override Imatrix GetMatrixSide(DataGridView gridview)
        {
            string gridviewn = Convert.ToString(gridview.Name);


            switch (gridviewn)
            {
                case "dataGridView1": return new ConcreteMatrix();
                case "dataGridView2": return new ConcreteMatrix();
                default: throw new ArgumentException("Invalid type", "type");
            }
        }
    }
}
