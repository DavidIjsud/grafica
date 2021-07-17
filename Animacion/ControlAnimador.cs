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

                    Thread t = new Thread( ControlAnimador.ThreadProcTrasladarEnXMas  );
                    t.Start(animacion);
                    break;
                case nameof( Acciones.TrasladarEnYMas ):
                    Thread tt = new Thread(ControlAnimador.ThreadProcTrasladarEnYMas);
                    tt.Start(animacion);

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
