using System;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using OpenTK.Graphics;
using System.Collections.Generic;

namespace ProjectXTwo
{
    public class TerceraPata : ObjetoGeneral , IObjeto
    {

  

        public TerceraPata(double px, double py, double pz, double escala, double teta)
        {
            this.position_x = px;
            this.position_y = py;
            this.position_z = pz;
            this.escala = escala;
            this.teta = teta;
        }

        public void Dibujar()
        {
            ///primera pata

            GL.Begin(PrimitiveType.Quads);

            GL.Color3(0.0, 5, 0);

            //parte superior

            GL.Vertex3(10 + (this.position_x), -2 + (this.position_y), 1 + (this.position_z));
            GL.Vertex3(10 + (this.position_x), -2 + (this.position_y), 0 + (this.position_z));
            GL.Vertex3(8 + (this.position_x), -2 + (this.position_y), 0 + (this.position_z));
            GL.Vertex3(8 + (this.position_x), -2 + (this.position_y), 1 + (this.position_z));

            GL.End();

            GL.Begin(PrimitiveType.Quads);

            GL.Color3(0.0, 5, 0);

            //parte trasera
            GL.Vertex3(10 + (this.position_x), -2 + (this.position_y), 1 + (this.position_z));
            GL.Vertex3(8 + (this.position_x), -2 + (this.position_y), 1 + (this.position_z));
            GL.Vertex3(8 + (this.position_x), 1 + (this.position_y), 1 + (this.position_z));
            GL.Vertex3(10 + (this.position_x), 1 + (this.position_y), 1 + (this.position_z));

            GL.End();

            GL.Begin(PrimitiveType.Quads);

            GL.Color3(0.0, 5, 0);

            //lateral derecho
            GL.Vertex3(8 + (this.position_x), -2 + (this.position_y), 1 + (this.position_z));
            GL.Vertex3(8 + (this.position_x), -2 + (this.position_y), 0 + (this.position_z));
            GL.Vertex3(8 + (this.position_x), 1 + (this.position_y), 0 + (this.position_z));
            GL.Vertex3(8 + (this.position_x), 1 + (this.position_y), 1 + (this.position_z));

            GL.End();

            GL.Begin(PrimitiveType.Quads);

            GL.Color3(0.0, 5, 0);

            //lateral izquierda
            GL.Vertex3(10 + (this.position_x), -2 + (this.position_y), 1 + (this.position_z));
            GL.Vertex3(10 + (this.position_x), 1 + (this.position_y), 1 + (this.position_z));
            GL.Vertex3(10 + (this.position_x), 1 + (this.position_y), 0 + (this.position_z));
            GL.Vertex3(10 + (this.position_x), -2 + (this.position_y), 0 + (this.position_z));

            GL.End();

            GL.Begin(PrimitiveType.Quads);

            GL.Color3(0.0, 0.0, 1.0); ///azul

            //parte abajo

            GL.Vertex3(10 + (this.position_x), 1 + (this.position_y), 1 + (this.position_z));
            GL.Vertex3(10 + (this.position_x), 1 + (this.position_y), 0 + (this.position_z));
            GL.Vertex3(8 + (this.position_x), 1 + (this.position_y), 0 + (this.position_z));
            GL.Vertex3(8 + (this.position_x), 1 + (this.position_y), 1 + (this.position_z));

            GL.End();

            GL.Begin(PrimitiveType.Quads);

            GL.Color3(0.0, 5, 0);

            //parte frontal
            GL.Vertex3(10 + (this.position_x), -2 + (this.position_y), 0 + (this.position_z));
            GL.Vertex3(10 + (this.position_x), 1 + (this.position_y), 0 + (this.position_z));
            GL.Vertex3(8 + (this.position_x), 1 + (this.position_y), 0 + (this.position_z));
            GL.Vertex3(8 + (this.position_x), -2 + (this.position_y), 0 + (this.position_z));

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
            GL.Translate(x, y, z);

        }
    }
}
