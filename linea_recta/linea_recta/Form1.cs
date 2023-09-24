using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace linea_recta
{
    public partial class Form1 : Form
    {
        grafica obj_grafica = new grafica();
        coordenasdas_linea coordenadas;
        grafica plano = new grafica();
        public Form1()
        {
            InitializeComponent();
            coordenadas = new coordenasdas_linea(txt_X1, txt_Y1, txt_X2, txt_Y2, pb_grafica);

        }
        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_y2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Mostrar_Click(object sender, EventArgs e)
        {

            obj_grafica.plano(pb_grafica);
            coordenadas.graficar();

            double x1 = double.Parse(txt_X1.Text);
            double y1 = double.Parse(txt_Y1.Text);
            double x2 = double.Parse(txt_X2.Text);
            double y2 = double.Parse(txt_Y2.Text);
            double pendiente = 0;
            double a, b;

            if (txt_pendiente.Text == "")
            {
                txt_xy.Text = "";
                txt_x.Text = "";
                a = (y2 - y1);
                b = (x2 - x1);
                pendiente = (a / b);

                if (y2 < y1 && x2 < x1)//verificacion los valores es las casillas
                {
                 
                    b = b*(-1);
                    a = a * (-1);

                    long y = Convert.ToInt64(b);
                    long c = Convert.ToInt64(a);
                    int x = Convert.ToInt32(x1);
                    int z = Convert.ToInt32(x2);
                    int g = Convert.ToInt32(y1);
                    int h = Convert.ToInt32(y2);

                    if (pendiente < 1)
                    {
                        for (long i = 0; i <= y; i++) // Cambiamos a long
                        {
                            double nuevoValor = y1 - (pendiente * i);
                            txt_xy.Text += nuevoValor.ToString() + Environment.NewLine;

                        }

                        for (int i = x; i >= z; i--)
                        {
                            txt_x.Text += i.ToString() + Environment.NewLine;
                        }
                    }
                    else
                    {
                        double nn = 1 / pendiente;

                        for (long i = 0; i <= c; i++) // Cambiamos a long
                        {
                            double nuevoValor = x1 - (nn * i);
                            txt_x.Text += nuevoValor.ToString() + Environment.NewLine;

                        }

                        for (int i = g; i >= h; i--)
                        {
                            txt_xy.Text += i.ToString() + Environment.NewLine;
                        }

                    }

                }
                else
                {

                    long y = Convert.ToInt64(b);
                    long c = Convert.ToInt64(a);
                    int x = Convert.ToInt32(x1);
                    int z = Convert.ToInt32(x2);
                    int g = Convert.ToInt32(y1);
                    int h = Convert.ToInt32(y2);

                    if (pendiente < 1)
                    {
                        for (long i = 0; i <= y; i++) // Cambiamos a long
                        {
                            double nuevoValor = y1 + (pendiente * i);
                            txt_xy.Text += nuevoValor.ToString() + Environment.NewLine;

                        }

                        for (int i = x; i <= z; i++)
                        {
                            txt_x.Text += i.ToString() + Environment.NewLine;
                        }
                    }
                    else
                    {
                        double nn = 1 / pendiente;

                        for (long i = 0; i <= c; i++) // Cambiamos a long
                        {
                            double nuevoValor = x1 + (nn * i);
                            txt_x.Text += nuevoValor.ToString() + Environment.NewLine;

                        }

                        for (int i = g; i <= h; i++)
                        {
                            txt_xy.Text += i.ToString() + Environment.NewLine;
                        }

                    }
                }
            }
            else
            {
               

            }
            txt_pendiente.Text = pendiente.ToString();
             
        }
        
        private void lbl_X2_Click(object sender, EventArgs e)
        {

        }

        private void lbl_x1_Click_1(object sender, EventArgs e)
        {

        }

        private void lbl_y1_Click(object sender, EventArgs e)
        {

        }

        private void txt_X1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Y1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_X2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Y2_TextChanged(object sender, EventArgs e)
        {

        }
       
        private void pb_grafica_Click(object sender, EventArgs e)
        {

            /*obj_grafica.plano_coordenadas(pb_grafica);
            coordenadas.graficar();*/

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbl_pendeinte_Click(object sender, EventArgs e)
        {

        }

        private void txt_pendiente_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void lbl_A_Click(object sender, EventArgs e)
        {

        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_X1.Clear();
            txt_Y1.Clear();
            txt_X2.Clear();
            txt_Y2.Clear();
            txt_x.Clear();
            txt_xy.Clear();
            txt_pendiente.Clear();
            
        }

        private void pnl_puntosPasa_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_xy_Click(object sender, EventArgs e)
        {

        }

        private void txt_xy_TextChanged(object sender, EventArgs e)
        {
            // Cambia el ancho (Width) y el alto (Height) del TextBox
            //txt_xy.Width = 50;
            //txt_xy.Height = 500;

        }

        private void txt_x_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
