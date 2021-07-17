using System;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using OpenTK.Graphics;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using ProjectXTwo.Animacion;

namespace ProjectXTwo
{
    public class Escenario : ObjetoGeneral
    {

       public Dictionary<string, IObjeto> listaObjetos;
        private Libreto libreto;

        public Escenario()
        {
            
            this.listaObjetos = new Dictionary<string, IObjeto>();

            this.listaObjetos.Add("Silla", new Chair());
            this.listaObjetos.Add("Mesa", new Mesa());

            this.libreto = new Libreto(this);

        }


        public void AnimarEscena() {

            this.libreto.animarLibreto();

        }


        public override  void Dibujar()
        {
            
            foreach (KeyValuePair<string, IObjeto> element in this.listaObjetos)
            {
                element.Value.Dibujar();
            }
        }

        public override void Escalar( double x , double y , double z)
        {
            foreach (KeyValuePair<string, IObjeto> element in this.listaObjetos)
            {
                element.Value.Escalar( x  , y , z);
            }
        }

        public override void Rotar(double angulo, double x, double y, double z)
        {
            foreach (KeyValuePair<string, IObjeto> element in this.listaObjetos)
            {
                element.Value.Rotar( angulo, x , y , z );
            }
        }

        public override void Trasladar()
        {
            foreach (KeyValuePair<string, IObjeto> element in this.listaObjetos)
            {
 
                element.Value.Trasladar( );
               
            }
        }

    }
}
