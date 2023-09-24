using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace linea_recta
{
    //clase que esta enfocada en graficar la linea de los puntos de coordenadas en A y B
    public class coordenasdas_linea
    {
        private Pen lapiz;
        private Graphics vector;
        private TextBox txt_X1, txt_Y1, txt_X2, txt_Y2;//llamamos a los metodos de windows form
        private PictureBox pb_grafica;
        private double x1,y1, x2, y2;
        private int x,y;


        public coordenasdas_linea(TextBox txt_X1, TextBox txt_Y1, TextBox txt_X2, TextBox txt_Y2, PictureBox pb_grafica) 
        {
            this.txt_X1 = txt_X1;
            this.txt_Y1 = txt_Y1; //inicializar los objetos y sus parametros
            this.txt_X2 = txt_X2;
            this.txt_Y2 = txt_Y2;
            this.pb_grafica = pb_grafica;
             x = pb_grafica.Width / 2;
             y = pb_grafica.Height / 2;
        }
        public void graficar()
        {
            if (txt_X1.Text == "")
            {
                txt_X1.Focus();
            }
            else
            {
                if (txt_X2.Text == "")
                {
                    txt_X2.Focus();
                }
                else
                {
                    if (txt_Y1.Text == "")
                    {
                        txt_Y1.Focus();
                    }
                    else
                    {
                        if (txt_Y2.Text == "")
                        {
                            txt_Y2.Focus();
                        }
                        else
                        {
                            dibujo();

                        }
                    }
                }
            }
        }
        private void dibujo()
        {
            double b = Convert.ToDouble(txt_X1.Text);
            double c = Convert.ToDouble(txt_Y1.Text);
            double b1 = Convert.ToDouble(txt_X2.Text);
            double c1 = Convert.ToDouble(txt_Y2.Text);

            x1 = (Convert.ToDouble(x) + Convert.ToDouble(txt_X1.Text));
            y1 = (Convert.ToDouble(y) - Convert.ToDouble(txt_Y1.Text));
            x2 = (Convert.ToDouble(x) + Convert.ToDouble(txt_X2.Text));
            y2 = (Convert.ToDouble(y) - Convert.ToDouble(txt_Y2.Text));

            vector = pb_grafica.CreateGraphics();
            lapiz = new Pen(Color.Black);

            lapiz.Color = Color.Blue;

            vector.DrawLine(lapiz, Convert.ToInt32(x1), Convert.ToInt32(y1), Convert.ToInt32(x2), Convert.ToInt32(y2));

            lapiz.Dispose();
            vector.Dispose();
        }



    }
}
