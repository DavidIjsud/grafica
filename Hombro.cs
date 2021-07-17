using System;
using OpenTK.Graphics.OpenGL;

namespace ProjectXTwo
{
    public class Hombro : ObjetoGeneral
    {
        public Hombro()
        {
        }

        public override void Dibujar()
        {
            ///hombros
            GL.PushMatrix();
            GL.Translate(this.position_x, this.position_y, this.position_z);
            GL.Rotate(this.anguloRotacion, 1, 0, 0);
            GL.Rotate(this.anguloRotacion, 0, 1, 0);
            GL.Rotate(this.anguloRotacion, 0, 0, 1);
            GL.Scale(this.escalaX, this.escalaY, this.escalaZ);
            GL.Begin(PrimitiveType.LineStrip);
            GL.Color3(1.0, 0.0, 0.0);

            GL.Vertex3(0.2 + (this.position_x), -1 + (this.position_y), 0 + (this.position_z));
            GL.Vertex3(3 + (this.position_x), -1 + (this.position_y), 0 + (this.position_z));

            GL.End();
            GL.PopMatrix();
        }

        public override void Escalar(double x, double y, double z)
        {
           
        }

        public override void Rotar(double angulo, double x, double y, double z)
        {
        }

        public override void Trasladar()
        {
            
        }
    }
}
