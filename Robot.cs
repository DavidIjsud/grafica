using System;
using OpenTK.Graphics.OpenGL;
using OpenTK.Graphics;
using System.Collections.Generic;

namespace ProjectXTwo
{
    public class Robot : ObjetoGeneral, IObjeto
    {

        public Dictionary<string, IObjeto> listaPartes;

        public Robot()
        {

            this.listaPartes = new Dictionary<string, IObjeto>();
            this.listaPartes.Add("Cabeza", new Cabeza());
            this.listaPartes.Add("Cuello", new Cuello());
            this.listaPartes.Add("Hombro", new Hombro());
            this.listaPartes.Add("BrazoIzquierdo", new BrazoIzquierdo());
            this.listaPartes.Add("BrazoDerecho", new BrazoDerecho());
            this.listaPartes.Add("Cuerpo", new Cuerpo());
            this.listaPartes.Add("Cadera", new Cadera());
            this.listaPartes.Add("PiernaDerecha", new PiernaDerecha());
            this.listaPartes.Add("PiernaIzquierda", new PiernaIzquierda());
        }

        public void Dibujar()
        {
            GL.PushMatrix();
            GL.Translate(this.position_x, this.position_y, this.position_z);
            GL.Rotate(this.anguloRotacion, 0, 0, 0);
            GL.Scale(this.escalaX, this.escalaY, this.escalaZ);
            foreach (KeyValuePair<string, IObjeto> element in this.listaPartes)
            {
                element.Value.Dibujar();
            }
            GL.PopMatrix();


        }

        public void animar() {

            System.Timers.Timer oTimer = new System.Timers.Timer();
            oTimer.Interval = 1000;
            oTimer.Elapsed += EjecutarAccion;

            this.escalaX = this.escalaX + 0.2;
            this.escalaY = this.escalaY + 0.2;
            this.escalaZ = this.escalaZ + 0.2;

        }


        private  void EjecutarAccion(Object source, System.Timers.ElapsedEventArgs e)
        {

            this.escalaX = this.escalaX + 0.2;
            this.escalaY = this.escalaY + 0.2;
            this.escalaZ = this.escalaZ + 0.2;


        }

        public void Escalar(double x, double y, double z)
        {
            
        }

        public void Rotar(double angulo, double x, double y, double z)
        {
           
        }

        public void Trasladar()
        {
            
        }
    }
}
