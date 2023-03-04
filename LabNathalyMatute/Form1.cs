using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;
namespace LabNathalyMatute
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            //label9.Enabled = false;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                int fil = Convert.ToInt32(txtfila.Text);
                int colum = Convert.ToInt32(txtcolumna.Text);

                matriz1 = new TextBox[fil, colum];
                for (int a = 0; a < fil; a++)
                {
                    for (int b = 0; b < colum; b++)
                    {
                        matriz1[a, b] = new TextBox();
                        matriz1[a, b].Text = "";
                        matriz1[a, b].Width = 80;
                        matriz1[a, b].BackColor = Color.AliceBlue;
                        matriz1[a, b].Location = new Point(50 + 100 * b, 35 + 50 * a);
                        matriz1[a, b].TabIndex = 100 * a + 2 * b;

                        panel1.Controls.Add(matriz1[a, b]);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                int filB = int.Parse(txtfilab.Text);
                int columB = int.Parse(txtcolumnab.Text);

                matriz2 = new TextBox[filB, columB];
                for (int a = 0; a < filB; a++)
                {
                    for (int b = 0; b < columB; b++)
                    {
                        matriz2[a, b] = new TextBox();
                        matriz2[a, b].Text = "";
                        matriz2[a, b].Width = 80;
                        matriz2[a, b].BackColor = Color.AliceBlue;
                        matriz2[a, b].Location = new Point(70 + 70 * (columB * 2) + 100 * b, 50 + 50 * (filB + 2) + 50 * a);
                        matriz2[a, b].TabIndex = 80 * a + 2 * b;

                        panel1.Controls.Add(matriz2[a, b]);
                    }
                }
                

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            MessageBox.Show("Se han generado las matrices correctamente", "Exito", MessageBoxButtons.OK);
           


        }
        int[,] mult;
        TextBox[,] matriz1;
        TextBox[,] matriz2;
        TextBox[,] mt;
        public static TextBox matrizresultado;

        public void generarMatriz()
        {
            


        }
        public void multiplicar()
        {
            




        }


        private void button2_Click(object sender, EventArgs e)
        {
            txtfila.Clear();
            txtcolumna.Clear();
            txtfilab.Clear();
            txtcolumnab.Clear();
            panel1.Controls.Clear();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mult = new int[100, 100];
            mt = new TextBox[1000, 1000];
            int filas1 = matriz1.GetLength(0);
            int columnas1 = matriz1.GetLength(1);
            int filas2 = matriz2.GetLength(0);
            int columnas2 = matriz2.GetLength(1);
            int colu, fili;
            colu = int.Parse(txtcolumna.Text);
            fili = int.Parse(txtfilab.Text);

            if (colu == fili)
            {
                for (int a = 0; a < filas1; a++)
                {
                    for (int b = 0; b < columnas2; b++)
                    {
                        mult[a, b] = 0;
                        for (int c = 0; c < columnas1; c++)
                        {
                            mult[a, b] = mult[a, b] + (int.Parse(matriz2[a, c].Text) * int.Parse(matriz1[c, b].Text));
                        }
                        matrizresultado = new TextBox();
                        mt[a, b] = matrizresultado;
                        panel1.Controls.Add(mt[a, b]);

                        matrizresultado.Top = 200 + (a * 30);
                        matrizresultado.Left = 100 + (b * 50);
                        matrizresultado.BackColor = Color.AliceBlue;
                        matrizresultado.Height = 25;
                        matrizresultado.Width = 25;

                        matrizresultado.Name = "c" + (a + 1) + (b + 1);
                        mt[a, b].Text = Convert.ToString(mult[a, b]);



                    }
                }

                for (int a = 0; a < filas1; a++)
                {
                    for (int b = 0; b < columnas2; b++)
                    {
                        mult[a, b] = 0;
                        for (int c = 0; c < columnas1; c++)
                        {
                            mult[a, b] = mult[a, b] + (int.Parse(matriz1[a, c].Text) * int.Parse(matriz2[c, b].Text));
                        }
                        matrizresultado = new TextBox();
                        mt[a, b] = matrizresultado;
                        panel1.Controls.Add(mt[a, b]);

                        matrizresultado.Top = 50 + (a * 30);
                        matrizresultado.Left = 350 + (b * 50);
                        matrizresultado.BackColor = Color.AliceBlue;
                        matrizresultado.Height = 25;
                        matrizresultado.Width = 25;

                        matrizresultado.Name = "c" + (a + 1) + (b + 1);
                        mt[a, b].Text = Convert.ToString(mult[a, b]);



                    }
                }



            }
            else
            {
                MessageBox.Show("la columna de la matriz A tiene que ser igual a fila de la matriz B ", "Exito", MessageBoxButtons.OK);
            }
           
        }
        private void label7_Click(object sender, EventArgs e)
        {
            
        }
    }
    }

