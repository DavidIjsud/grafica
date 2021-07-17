using System;
using OpenTK.Graphics.OpenGL;
using OpenTK.Graphics;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace ProjectXTwo
{
    public class Robot : ObjetoGeneral
    {

        public Dictionary<string, IObjeto> listaPartes;

        double posicionAdelante = 0.1;
        double posicionDerecha = 0.1;

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

        public override void Dibujar()
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
            oTimer.Start();

           

        }


        /*private  void EjecutarAccion(Object source, System.Timers.ElapsedEventArgs e)
        {

            

            Animacion[] a = null;
            string archivoJson;
            string path = @"/Users/davidgarcia/Documents/David things/UAGRM/Topico avanzado de programacion/ProyectoGrafica/archivo.json";

            using (var reader = new StreamReader(path))
            {
                archivoJson = reader.ReadToEnd();

            }

            a = JsonConvert.DeserializeObject<Animacion[]>(archivoJson);


            if (posicionAdelante != a[0].PasosAdelante)
            {
                posicionAdelante += 0.2;
                this.position_z = posicionAdelante;
                posicionDerecha += 0.2;
                this.position_x = posicionDerecha;
            }
            else {

                posicionDerecha += 0.2;
                this.position_x = posicionDerecha;

            }

        } */

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
