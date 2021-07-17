using System;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using OpenTK.Graphics;
using System.Collections.Generic;

namespace ProjectXTwo
{
    public class Espaldar : ObjetoGeneral
    {


        public Espaldar()
        {
         
        }

        public override void Dibujar()
        {
            ////espaldar
            ///


            GL.PushMatrix();
            GL.Translate(this.position_x, this.position_y, this.position_z);
            GL.Rotate(this.anguloRotacion, 1, 0, 0);
            GL.Rotate(this.anguloRotacion, 0, 1, 0);
            GL.Rotate(this.anguloRotacion, 0, 0, 1);
            GL.Scale(this.escalaX, this.escalaY, this.escalaZ);
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(1.0, 0.0, 0.0);

            GL.Vertex3(1 + (this.position_x), 1 + (this.position_y), -6 + (this.position_z));
            GL.Vertex3(1 + (this.position_x), 10 + (this.position_y), -6 + (this.position_z));
            GL.Vertex3(10 + (this.position_x), 10 + (this.position_y), -6 + (this.position_z));
            GL.Vertex3(10 + (this.position_x), 1 + (this.position_y), -6 + (this.position_z));

            GL.End();
            GL.PopMatrix();
        }
    

            public override void Escalar(double x, double y, double z)
            {
            this.escalaX = x;
            this.escalaY = y;
            this.escalaZ = z;
            }

            public override void Rotar(double angulo, double x, double y, double z )
             {
            
                
           
            }

            public override void Trasladar()
            {
                
                
            }

    }
}
