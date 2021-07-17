using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;

namespace ProjectXTwo.Animacion
{
    public class Libreto
    {

        List<Animacion> listaAnimacion;
        Escenario escenario;

        public Libreto( Escenario es )
        {
            this.listaAnimacion = new List<Animacion>();
            this.escenario = es;
            llenarListaDeAnimacion();



        }

        private void llenarListaDeAnimacion() {

            string archivoJson;
            string path = @"/Users/davidgarcia/Documents/David things/UAGRM/Topico avanzado de programacion/ProyectoGrafica/archivo.json";

            using (var reader = new StreamReader(path))
            {
                archivoJson = reader.ReadToEnd();

            }
            Animacion[] a = null;
            a = JsonConvert.DeserializeObject<Animacion[]>(archivoJson);

            foreach ( Animacion anim in a  ) {
                this.listaAnimacion.Add(anim);
            }

        }


        public async void animarLibreto() {

            foreach ( Animacion a in this.listaAnimacion ) {

               a.escenario = this.escenario;
               await a.animar(  );

            }
             

        }

    }
}
