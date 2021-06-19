using System;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using OpenTK.Graphics;
using System.Collections.Generic;

namespace ProjectXTwo
{
    public class Espaldar : ObjetoGeneral, IObjeto
    {


        public Espaldar(double px, double py, double pz, double escala, double teta)
        {
            this.position_x = px;
            this.position_y = py;
            this.position_z = pz;
            this.escala = escala;
            this.teta = teta;
        }

        public void Dibujar()
        {
            ////espaldar
            ///


            
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(1.0, 0.0, 0.0);

            GL.Vertex3(1 + (this.position_x), 1 + (this.position_y), -6 + (this.position_z));
            GL.Vertex3(1 + (this.position_x), 10 + (this.position_y), -6 + (this.position_z));
            GL.Vertex3(10 + (this.position_x), 10 + (this.position_y), -6 + (this.position_z));
            GL.Vertex3(10 + (this.position_x), 1 + (this.position_y), -6 + (this.position_z));

            GL.End();

        }
    

            public void Escalar(double x, double y, double z)
            {
            GL.Scale(x, y , z);
            }

            public void Rotar(double angulo, double x, double y, double z )
            {
            GL.Rotate(angulo , x , y , z );

            }

            public void Trasladar(double x, double y, double z)
            {
                
                    
                
            }

    }
}
