using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace linea_recta
{

    //clase enfocada a dibujar el plano cartesiano, el eje x y eje y
    internal class grafica
    {
        Pen lapiz = new Pen(Color.Red);
        Pen lapizr = new Pen(Color.Black);

        Graphics dibujo;

        public void plano(PictureBox pb_grafica)
        {
            int x = pb_grafica.Width /2;
            int y = pb_grafica.Height /2;

            dibujo = pb_grafica.CreateGraphics(); 
            dibujo.TranslateTransform (x, y);    
            dibujo.ScaleTransform(1, -1);

            dibujo.DrawLine(lapizr, x * -1, 0, x * 1, 0);
            dibujo.DrawLine(lapizr, 0 ,y , 0, y * -1);

            for (int i = -x; i < x; i += 10 )//mostramos en la grafica el espacio de las barras indicadoras de coordenadas
            {                                   //se hace un recorrido de 8 en 8
                dibujo.DrawLine(lapiz, 5, i, -5, i);
                dibujo.DrawLine(lapiz, i, 5, i, -5);

              
            }
        }
    }
}
