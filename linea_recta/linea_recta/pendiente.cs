/*using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace linea_recta
{
     public class pendiente
    {
        private TextBox txt_X1, txt_Y1,txt_X2,txt_Y2,txt_pendiente;
        private PictureBox pb_grafica;
        private Graphics vector;
        private Pen lapiz;
        double x, y, m, b;
        private double x1, y1, x2, y2;
        double a, a1, b2, b3;

        public pendiente(TextBox txt_X1, TextBox txt_Y1, TextBox txt_X2, TextBox txt_Y2,TextBox txt_pendiente, PictureBox pb_grafica)
        {
            this.txt_X1 = txt_X1;
            this.txt_Y1 = txt_Y1; //inicializar los objetos y sus parametros
            this.txt_X2 = txt_X2;
            this.txt_Y2 = txt_Y2;
            this.txt_pendiente = txt_pendiente;
            this.pb_grafica = pb_grafica;
            Pen lapizNegro = new Pen(Color.Blue, 8);
            x = pb_grafica.Width / 2;
            y = pb_grafica.Height / 2;
        }

        public void coordenadasXY()
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

        

        x1 = (Convert.ToDouble(x) + Convert.ToDouble(txt_X1.Text));
        y1 = (Convert.ToDouble(y) - Convert.ToDouble(txt_Y1.Text));
        x2 = (Convert.ToDouble(x) + Convert.ToDouble(txt_X2.Text));
        y2 = (Convert.ToDouble(y) - Convert.ToDouble(txt_Y2.Text));


        for (x = -10; x <= 10; x++)
        {
            y = (y2-y1)/(x2-x1);


            vector = pb_grafica.CreateGraphics();

            vector.DrawLine(lapiz, Convert.ToInt32(x1), Convert.ToInt32(y1), Convert.ToInt32(x2), Convert.ToInt32(y2));
        }
    }
    }
}*/
