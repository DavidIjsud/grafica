using System;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using OpenTK.Graphics;
using System.Collections.Generic;
namespace ProjectXTwo
{
    public class ApoyadorPoto : ObjetoGeneral, IObjeto
    {

    

        public ApoyadorPoto(double px, double py, double pz, double escala, double teta)
        {
            this.position_x = px;
            this.position_y = py;
            this.position_z = pz;
            this.escala = escala;
            this.teta = teta;
        }

        public void Dibujar()
        {
            ///apoyador de poto
            ///

            GL.Begin(PrimitiveType.Quads);
            GL.Color3(0.5, 0.5, 0.5);

            GL.Vertex3(1 + (this.position_x), 1 + (this.position_y), 0 + (this.position_z));
            GL.Vertex3(1 + (this.position_x), 1 + (this.position_y), -6 + (this.position_z));
            GL.Vertex3(10 + (this.position_x), 1 + (this.position_y), -6 + (this.position_z));
            GL.Vertex3(10 + (this.position_x), 1 + (this.position_y), 0 + (this.position_z));

            GL.End();
        }

        public void Escalar(double x, double y, double z)
        {
            GL.Scale(x, y, z);
        }

        public void Rotar(double angulo, double x, double y, double z)
        {
            GL.Rotate(angulo, x, y, z);
        }

        public void Trasladar(double x, double y, double z)
        {
            
            
            
        }
    }
}
