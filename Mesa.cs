using System;
using System.Collections.Generic;
using OpenTK.Graphics.OpenGL;
using OpenTK.Graphics;

namespace ProjectXTwo
{
    public class Mesa : ObjetoGeneral
    {

        public Dictionary<string, IObjeto> listaPartes;

        public Mesa()
        {
          
            fillElementsOfChair();
        }

        private void fillElementsOfChair()
        {

            this.listaPartes = new Dictionary<string, IObjeto>();
            this.listaPartes.Add("Apoyador", new ApoyadorPoto());
            this.listaPartes.Add("PrimeraPata", new PrimeraPata());
            this.listaPartes.Add("SegundaPata", new SegundaPata());
            this.listaPartes.Add("TerceraPata", new TerceraPata());
            this.listaPartes.Add("CuartaPata", new CuartaPata());
        }

        public override void Dibujar()
        {

            GL.PushMatrix();
            GL.Translate(this.position_x, this.position_y , this.position_z);
            GL.Rotate(this.anguloRotacion, 1, 0, 0);
            GL.Scale(this.escalaX, this.escalaY, this.escalaZ);
            foreach (KeyValuePair<string, IObjeto> element in this.listaPartes)
            {
                element.Value.Dibujar();
            }
            GL.PopMatrix();
        }

        public override void Escalar(double x, double y, double z)
        {
            this.escalaX = x;
            this.escalaY = y;
            this.escalaZ = z;
        }

        public override void Rotar(double angulo, double x, double y, double z)
        {
            this.anguloRotacion = angulo;
        }

        public override void Trasladar()
        {
           
        }
    }
}
