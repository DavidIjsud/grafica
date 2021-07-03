using System;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using OpenTK.Graphics;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace ProjectXTwo
{
    public class Escenario : ObjetoGeneral, IObjeto
    {

       public Dictionary<string, IObjeto> listaObjetos;

        public Escenario()
        {
            
            this.listaObjetos = new Dictionary<string, IObjeto>();

            this.listaObjetos.Add("Silla", new Chair());
            this.listaObjetos.Add("Mesa", new Mesa());
            this.listaObjetos.Add("Robot" , new Robot());

        }


        public Animacion[] cargarJson()
        {
            Animacion[] a = null;
            string archivoJson;
            string path = @"/Users/davidgarcia/Documents/David things/UAGRM/Topico avanzado de programacion/ProyectoGrafica/archivo.json";

            using (var reader = new StreamReader(path))
            {
                archivoJson = reader.ReadToEnd();

            }
                a = JsonConvert.DeserializeObject<Animacion[]>(archivoJson);


           
            return a;
        }


        public void Dibujar()
        {
            
            foreach (KeyValuePair<string, IObjeto> element in this.listaObjetos)
            {
                element.Value.Dibujar();
            }
        }

        public void Escalar( double x , double y , double z)
        {
            foreach (KeyValuePair<string, IObjeto> element in this.listaObjetos)
            {
                element.Value.Escalar( x  , y , z);
            }
        }

        public void Rotar(double angulo, double x, double y, double z)
        {
            foreach (KeyValuePair<string, IObjeto> element in this.listaObjetos)
            {
                element.Value.Rotar( angulo, x , y , z );
            }
        }

        public void Trasladar()
        {
            foreach (KeyValuePair<string, IObjeto> element in this.listaObjetos)
            {
 
                element.Value.Trasladar( );
               
            }
        }

    }
}
