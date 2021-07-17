using System;
using System.Threading;
using System.Threading.Tasks;

namespace ProjectXTwo.Animacion
{
    public class ControlAnimador
    {

    

        public ControlAnimador()
        {
          
        }

        public static async Task animar(  Animacion animacion ) {

       


            switch ( animacion.Accion ) {

                case  nameof( Acciones.TrasladarEnXMas ) :

                    await Task.Run(() => {
                        ThreadProcTrasladarEnXMas(animacion);
                       
                    });


                    break;
                case nameof( Acciones.TrasladarEnYMas ):
                    await Task.Run(() => {
                        ThreadProcTrasladarEnYMas(animacion);
                    });
                    break;

                case nameof(Acciones.Rotar):

                    await Task.Run(() => {
                        Rotar(animacion);
                    });

                    break;
                    

            }

            

        }

        private static void Rotar( Animacion a ) {

            switch (a.Objeto)
            {

                case nameof(Objetos.Silla):
                    int contador = 0;
                    Chair silla = (Chair)a.escenario.listaObjetos["Silla"];

                    while ( true ) {

                        silla.anguloRotacion += 1.0;
                        Thread.Sleep(90);

                        contador += 100;

                        if (contador > a.Tiempomili)
                        {

                            break;
                        }

                    }

                    

                    break;


            }

        }

        private static void MoverObjetoEnYMas(ObjetoGeneral objetoConcreto, int tiempo)
        {
            int contador = 0;
            while (true)
            {

                objetoConcreto.position_y += 0.05;

                Thread.Sleep(100);

                contador += 100;

                if (contador > tiempo)
                {

                    return;
                }


            }

        }

        private static void ThreadProcTrasladarEnYMas(object o)
        {

            Animacion a = (Animacion)o;

            switch (a.Objeto)
            {

                case nameof(Objetos.Mesa):

                    Mesa mesaToTraslate = (Mesa)a.escenario.listaObjetos["Mesa"];
                    MoverObjetoEnYMas(mesaToTraslate, a.Tiempomili);

                    break;


            }
        }

        private static void MoverObjetoEnXMas(ObjetoGeneral objetoConcreto , int tiempo) {
            int contador = 0;
            while (true) {

                objetoConcreto.position_x += 0.05;
                
                Thread.Sleep(100);

                contador += 100;

                if ( contador > tiempo ) {

                    return;
                }

               
            }

        }

        private static void ThreadProcTrasladarEnXMas( object o ) {

            Animacion a = (Animacion)o;

            switch (  a.Objeto  ) {

                case  nameof(Objetos.Mesa):

                    Mesa mesaToTraslate = (Mesa)a.escenario.listaObjetos["Mesa"];
                    MoverObjetoEnXMas(mesaToTraslate , a.Tiempomili);

                    break;


            }
        }

    }
}
