using System;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using OpenTK.Graphics;
using System.Collections.Generic;

namespace ProjectXTwo
{
    public class SegundaPata : ObjetoGeneral , IObjeto
    {
        public SegundaPata()
        {
          
        }

        public void Dibujar()
        {
            ///pata trasera 
            GL.PushMatrix();
            GL.Translate(this.position_x, this.position_y, this.position_z);
            GL.Rotate(this.anguloRotacion, 1, 0, 0);
            GL.Rotate(this.anguloRotacion, 0, 1, 0);
            GL.Rotate(this.anguloRotacion, 0, 0, 1);
            GL.Scale(this.escalaX, this.escalaY, this.escalaZ);


            GL.Begin(PrimitiveType.Quads);

            GL.Color3(0.0, 5, 0);

            //parte superior

            GL.Vertex3(10 + (this.position_x), -2 + (this.position_y), -6 + (this.position_z));
            GL.Vertex3(10 + (this.position_x), -2 + (this.position_y), -7 + (this.position_z));
            GL.Vertex3(8 + (this.position_x), -2 + (this.position_y), -7 + (this.position_z));
            GL.Vertex3(8 + (this.position_x), -2 + (this.position_y), -6 + (this.position_z));

         

            GL.Color3(0.0, 5, 0);

            //parte trasera
            GL.Vertex3(10 + (this.position_x), -2 + (this.position_y), -6 + (this.position_z));
            GL.Vertex3(8 + (this.position_x), -2 + (this.position_y), -6 + (this.position_z));
            GL.Vertex3(8 + (this.position_x), 1 + (this.position_y), -6 + (this.position_z));
            GL.Vertex3(10 + (this.position_x), 1 + (this.position_y), -6 + (this.position_z));

          
            GL.Color3(0.0, 5, 0);

            //lateral derecho
            GL.Vertex3(8 + (this.position_x), -2 + (this.position_y), -6 + (this.position_z));
            GL.Vertex3(8 + (this.position_x), -2 + (this.position_y), -7 + (this.position_z));
            GL.Vertex3(8 + (this.position_x), 1 + (this.position_y), -7 + (this.position_z));
            GL.Vertex3(8 + (this.position_x), 1 + (this.position_y), -6 + (this.position_z));

           

            GL.Color3(0.0, 5, 0);

            //lateral izquierda
            GL.Vertex3(10 + (this.position_x), -2 + (this.position_y), -6 + (this.position_z));
            GL.Vertex3(10 + (this.position_x), 1 + (this.position_y), -6 + (this.position_z));
            GL.Vertex3(10 + (this.position_x), 1 + (this.position_y), -7 + (this.position_z));
            GL.Vertex3(10 + (this.position_x), -2 + (this.position_y), -7 + (this.position_z));

         

            GL.Color3(0.0, 1.0, 0.0); //negro

            //parte abajo

            GL.Vertex3(10 + (this.position_x), 1 + (this.position_y), -6 + (this.position_z));
            GL.Vertex3(10 + (this.position_x), 1 + (this.position_y), -7 + (this.position_z));
            GL.Vertex3(8 + (this.position_x), 1 + (this.position_y), -7 + (this.position_z));
            GL.Vertex3(8 + (this.position_x), 1 + (this.position_y), -6 + (this.position_z));



            GL.Color3(0.0, 5, 0);

            //parte frontal
            GL.Vertex3(10 + (this.position_x), -2 + (this.position_y), -7 + (this.position_z));
            GL.Vertex3(10 + (this.position_x), 1 + (this.position_y), -7 + (this.position_z));
            GL.Vertex3(8 + (this.position_x), 1 + (this.position_y), -7 + (this.position_z));
            GL.Vertex3(8 + (this.position_x), -2 + (this.position_y), -7 + (this.position_z));

            GL.End();
            GL.PopMatrix();
        }

        public void Escalar(double x, double y, double z)
        {
            this.escalaX = x;
            this.escalaY = y;
            this.escalaZ = z;
        }

        public void Rotar(double angulo, double x, double y, double z)
        {
         
        }

        public void Trasladar()
        {


        }
    }
}
