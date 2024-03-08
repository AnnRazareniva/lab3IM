using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;


namespace lab3IM
{
    

    public partial class Form1 : Form
    {
        
        int N = 10, M = 15, number;
        int i, j;
        string New, pic;

        int[,] matrix;

        public Form1()
        {
            InitializeComponent();
            
            matrix = new int[M, N];//первое значение количество столбцов второе строк

            var grid = new MatrixGrid() 
            { 
                Parent = kletka, 
                Dock = DockStyle.Fill,
                GridSize = new Size(M, N),
                BorderStyle = BorderStyle.FixedSingle,
            };

            grid.CellNeeded += grid_CellNeeded;
            grid.CellClick += grid_CellClick;
        }
        void grid_CellClick(object sender, MatrixGrid.CellClickEventArgs e)
        {
            matrix[e.Cell.X, e.Cell.Y] = 1 - matrix[e.Cell.X, e.Cell.Y];
        }

        void grid_CellNeeded(object sender, MatrixGrid.CellNeededEventArgs e)
        {
            e.BackColor = matrix[e.Cell.X, e.Cell.Y] == 1 ? Color.Blue : Color.White;
        }

        private void button2_Click(object sender, EventArgs e)//кнопка очистки, если что чистка рисунка задерживается(может это только на ноутбуке) нужно ждать
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = 0;
                }
            }
        }

        Random rand = new Random();

        private void btRandom_Click(object sender, EventArgs e)
        {
            for (i = 0; i < matrix.GetLength(0); i++)
            {
                matrix[i, 0] = rand.Next(0, 2);//заполнение от 0 до 1 //i-столбец, 0-строка, реализацию брала в интернете, там отдельным классом сделали matrixGrid, у них строки со столбцами перепутаны
            }

            Invalidate(true);
        }
      
        private void button1_Click(object sender, EventArgs e)
        {

            //START

            string picHelp;        

            for (i = 0; i < M; ++i)
            {
                if (matrix[i, 0] == 1)
                {
                    pic = pic + "1";
                }
                else
                {
                    pic = pic + "0";

                }
            }
           
            for (j = 0; j < N-1; ++j)
            {
                picHelp = pic;
                pic = String.Empty;
                New = "";

                for (i = 0; i < M; ++i)
                {
                    if (i == 0)
                    {
                        Rule(picHelp[picHelp.Length - 1], picHelp[i], picHelp[i + 1]);
                        if (New[i] == '1')
                        {
                            matrix[i, j + 1] = 1;
                            pic = pic + "1";
                        }
                        else
                        {
                            matrix[i, j + 1] = 0;
                            pic = pic + "0";
                        }
                    }
                    else
                    if (i == picHelp.Length - 1)
                    {
                        Rule(picHelp[i - 1], picHelp[i], picHelp[0]);
                        if (New[i] == '1')
                        {
                            matrix[i, j + 1] = 1;
                            pic = pic + "1";
                        }
                        else
                        {
                            matrix[i, j + 1] = 0;
                            pic = pic + "0";
                        }
                    }
                    else
                    {
                        Rule(picHelp[i - 1], picHelp[i], picHelp[i + 1]);
                        if (New[i] == '1')
                        {
                            matrix[i, j + 1] = 1;
                            pic = pic + "1";
                        }
                        else
                        {
                            matrix[i, j + 1] = 0;
                            pic = pic + "0";
                        }
                    }
                }
            }
        }

        public void Rule(char x, char y, char z)
        {
            number = (int)Num.Value;
            string numberBin = Convert.ToString(number, 2);

            while (numberBin.Length < 8)
            {
                numberBin = "0" + numberBin;
            }

            string three = x.ToString() + y.ToString() + z.ToString();

            if (three == "111")
            {
                New = New + numberBin[0];
            }
            else
                if (three == "110")
            {
                New = New + numberBin[1];
            }
            else
                if (three == "101")
            {
                New = New + numberBin[2];
            }
            else
                if (three == "100")
            {
                New = New + numberBin[3];
            }
            else
                if (three == "011")
            {
                New = New + numberBin[4];
            }
            else
                if (three == "010")
            {
                New = New + numberBin[5];
            }
            else
                if (three == "001")
            {
                New = New + numberBin[6];
            }
            else
                if (three == "000")
            {
                New = New + numberBin[7];
            }
        }

        //Сначала попробовала через dataGridView

        //public void DrawLinePoint(PaintEventArgs e)
        //{
        //    dataGridView1.RowCount = N;
        //    dataGridView1.ColumnCount = M;
        //    int i, j;

        //    //START

        //    for (i = 0; i < M; ++i)
        //    {
        //        if (i == 6 || i == 7 || i == 11)//заполнение ячеек цветом(цифрами) вызывая правило 110)
        //        {
        //            dataGridView1.Rows[0].Cells[i].Style.BackColor = Color.Blue;
        //        }
        //        else
        //        {
        //            dataGridView1.Rows[0].Cells[i].Style.BackColor = Color.White;
        //        }
        //    }



        //    for (i = 0; i < M; ++i)
        //    {
        //        if (dataGridView1.Rows[0].Cells[i].Style.BackColor == Color.Blue)//заполнение ячеек цветом(цифрами) вызывая правило 110)
        //        {
        //            pic = pic + "1";
        //        }
        //        else
        //        {
        //             pic = pic + "0";
        //        }
        //    }

        //    for (j = 0; j < N; ++j)
        //    {
        //        for (i = 0; i < M; ++i)
        //        { 
        //            if(i == 0)
        //            {
        //                Rule(pic[pic.Length - 1], pic[i], pic[i + 1]);
        //                if (New[i] == '1')//заполнение ячеек цветом(цифрами) вызывая правило 110)
        //                {
        //                    dataGridView1.Rows[j].Cells[i].Style.BackColor = Color.Blue;
        //                }
        //                else
        //                {
        //                    dataGridView1.Rows[j].Cells[i].Style.BackColor = Color.White;
        //                }
        //            }
        //            else
        //            if(i == pic.Length - 1)
        //            {
        //                Rule(pic[i - 1], pic[i], pic[0]);
        //                if (New[i] == '1')//заполнение ячеек цветом(цифрами) вызывая правило 110)
        //                {
        //                    dataGridView1.Rows[j].Cells[i].Style.BackColor = Color.Blue;
        //                }
        //                else
        //                {
        //                    dataGridView1.Rows[j].Cells[i].Style.BackColor = Color.White;
        //                }
        //            }
        //            else
        //            {
        //                Rule(pic[i - 1], pic[i], pic[i + 1]);
        //                if (New[i] == '1')//заполнение ячеек цветом(цифрами) вызывая правило 110)
        //                {
        //                    dataGridView1.Rows[j].Cells[i].Style.BackColor = Color.Blue;
        //                }
        //                else
        //                {
        //                    dataGridView1.Rows[j].Cells[i].Style.BackColor = Color.White;
        //                }
        //            }

        //        }
        //    }
        //}



    }

}

