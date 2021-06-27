using System;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using OpenTK.Graphics;
using System.Collections.Generic;
using OpenTK.Input;

namespace ProjectXTwo
{
    public class  Game : GameWindow
    {

      

        Escenario escenario;
        
        
        public Game(int width, int height, string title) : base(width, height, GraphicsMode.Default, title) {

            
            this.escenario = new Escenario();
            this.Run(1.0/60.0);

        }



        protected override void OnLoad(EventArgs e)
        {
            GL.ClearColor(0.0f, 0.0f, 0.0f, 0.0f);
            GL.Enable( EnableCap.DepthTest );
            base.OnLoad(e);
        }

        protected override void OnResize(EventArgs e)
        {
            GL.Viewport(0, 0, Width, Height);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();

           
           Matrix4 matrix = Matrix4.Perspective(45.0f, Width / Height, 1.0f,100.0f);
           GL.LoadMatrix( ref matrix );
            GL.MatrixMode(MatrixMode.Modelview);

            base.OnResize(e);
        }


        

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            base.OnUpdateFrame(e);
            KeyboardState x = OpenTK.Input.Keyboard.GetState();


            ///ESTO PARA ROTAR Y ESCALAR TODO EL ESCENARIO

           

            if (x.IsKeyDown(Key.R) && x.IsKeyDown(Key.E))
            {

                this.escenario.Rotar( this.escenario.anguloRotacion , 1 , 0 ,0 );
                //this.escenario.Rotar(this.escenario.anguloRotacion,0 , 1, 0);
                //this.escenario.Rotar(this.escenario.anguloRotacion, 0, 0, 1);

                this.escenario.anguloRotacion += 1.0;
                if ( this.escenario.anguloRotacion > 360 ) {
                    this.escenario.anguloRotacion -= 360; 
                }

           
            }


            if (x.IsKeyDown(Key.Plus) && x.IsKeyDown(Key.E))
            {

                this.escenario.escalaX = this.escenario.escalaX + 0.1;
                this.escenario.escalaY = this.escenario.escalaY + 0.1;
                this.escenario.escalaZ = this.escenario.escalaZ + 0.1;


                this.escenario.Escalar(this.escenario.escalaX, this.escenario.escalaY, this.escenario.escalaZ);
            }

            if (x.IsKeyDown(Key.Minus) && x.IsKeyDown(Key.E))
            {

                this.escenario.escalaX = this.escenario.escalaX - 0.1;
                this.escenario.escalaY = this.escenario.escalaY - 0.1;
                this.escenario.escalaZ = this.escenario.escalaZ - 0.1;


                this.escenario.Escalar(this.escenario.escalaX, this.escenario.escalaY, this.escenario.escalaZ);
            }



            ///ESTO PARA MOVER LA SILLA SOLAMENTE (trasladar)
            if ( x.IsKeyDown(Key.S)  && x.IsKeyDown(Key.Up) ) { // hacia arriba en Y

              ObjetoGeneral silla =   (ObjetoGeneral)this.escenario.listaObjetos["Silla"];
                silla.position_y = silla.position_y + 0.5;              
            }

            if (x.IsKeyDown(Key.S) && x.IsKeyDown(Key.Down)) // hacia abajo en Y
            {

                ObjetoGeneral silla = (ObjetoGeneral)this.escenario.listaObjetos["Silla"];
                silla.position_y = silla.position_y - 0.5;
            }

            if (x.IsKeyDown(Key.S) && x.IsKeyDown(Key.Right))
            { // hacia derecha en X

                ObjetoGeneral silla = (ObjetoGeneral)this.escenario.listaObjetos["Silla"];
                silla.position_x = silla.position_x + 0.5;
            }

            if (x.IsKeyDown(Key.S) && x.IsKeyDown(Key.Left)) // hacia izquierda en X
            {

                ObjetoGeneral silla = (ObjetoGeneral)this.escenario.listaObjetos["Silla"];
                silla.position_x = silla.position_x - 0.5;
            }


            if (x.IsKeyDown(Key.S) && x.IsKeyDown(Key.Up) && x.IsKeyDown(Key.Z))
            { // hacia Z +

                ObjetoGeneral silla = (ObjetoGeneral)this.escenario.listaObjetos["Silla"];
                silla.position_z = silla.position_z + 0.5;
            }

            if (x.IsKeyDown(Key.S) && x.IsKeyDown(Key.Down) && x.IsKeyDown(Key.Z)) // hacia Z -
            {

                ObjetoGeneral silla = (ObjetoGeneral)this.escenario.listaObjetos["Silla"];
                silla.position_z = silla.position_z - 0.5;
            }

            ///ESTO ES PARA ROTAR SOLO LA SILLA
            ///

            if (x.IsKeyDown(Key.R) && x.IsKeyDown(Key.S)) { //angulo positivo

                ObjetoGeneral silla = (ObjetoGeneral)this.escenario.listaObjetos["Silla"];
                silla.anguloRotacion = silla.anguloRotacion + 1.0;
                
            }


            ///ESTO ES PARA ESCALAR SOLO LA SILLA
            ///

            if (x.IsKeyDown(Key.R) && x.IsKeyDown(Key.S))
            {
                ObjetoGeneral silla = (ObjetoGeneral)this.escenario.listaObjetos["Silla"];
                silla.anguloRotacion = silla.anguloRotacion + 1.0;
               
            }



            ///ESTO PARA MOVER LA MEsa SOLAMENTE (trasladar)
            if (x.IsKeyDown(Key.M) && x.IsKeyDown(Key.Up))
            { // hacia arriba en Y

                ObjetoGeneral mesa = (ObjetoGeneral)this.escenario.listaObjetos["Mesa"];
                mesa.position_y = mesa.position_y + 0.5;
            }

            if (x.IsKeyDown(Key.M) && x.IsKeyDown(Key.Down)) // hacia abajo en Y
            {

                ObjetoGeneral mesa = (ObjetoGeneral)this.escenario.listaObjetos["Mesa"];
                mesa.position_y = mesa.position_y - 0.5;
            }

            if (x.IsKeyDown(Key.M) && x.IsKeyDown(Key.Right))
            { // hacia derecha en X

                ObjetoGeneral mesa = (ObjetoGeneral)this.escenario.listaObjetos["Msa"];
                mesa.position_x = mesa.position_x + 0.5;
            }

            if (x.IsKeyDown(Key.M) && x.IsKeyDown(Key.Left)) // hacia izquierda en X
            {

                ObjetoGeneral mesa = (ObjetoGeneral)this.escenario.listaObjetos["Mesa"];
                mesa.position_x = mesa.position_x - 0.5;
            }


            if (x.IsKeyDown(Key.M) && x.IsKeyDown(Key.Up) && x.IsKeyDown(Key.Z))
            { // hacia Z +

                ObjetoGeneral mesa = (ObjetoGeneral)this.escenario.listaObjetos["Mesa"];
                mesa.position_z = mesa.position_z + 0.5;
            }

            if (x.IsKeyDown(Key.M) && x.IsKeyDown(Key.Down) && x.IsKeyDown(Key.Z)) // hacia Z -
            {

                ObjetoGeneral mesa = (ObjetoGeneral)this.escenario.listaObjetos["Mesa"];
                mesa.position_z = mesa.position_z - 0.5;
            }

            ///ESTO ES PARA ROTAR SOLO LA MESA
            ///

            if (x.IsKeyDown(Key.R) && x.IsKeyDown(Key.M))
            { //angulo positivo

                ObjetoGeneral mesa = (ObjetoGeneral)this.escenario.listaObjetos["Mesa"];
                mesa.anguloRotacion = mesa.anguloRotacion + 1.0;

            }


            ///ESTO ES PARA ESCALAR SOLO LA MESA
            ///

            if (x.IsKeyDown(Key.R) && x.IsKeyDown(Key.M))
            {
                ObjetoGeneral mesa = (ObjetoGeneral)this.escenario.listaObjetos["Mesa"];
                mesa.anguloRotacion = mesa.anguloRotacion + 1.0;

            }



            ////////////////////////////////////////////////////////////////////////////////////PATA DE MESA////////////////////////////////////////////////////////////////////
            ///

            ///ESTO PARA MOVER LA MEsa SOLAMENTE una pata (trasladar)
            if (x.IsKeyDown(Key.Up) && x.IsKeyDown(Key.P))
            { // hacia arriba en Y

                Mesa mesa = (Mesa)this.escenario.listaObjetos["Mesa"];
                PrimeraPata primeraPata = (PrimeraPata)mesa.listaPartes["PrimeraPata"];
                 primeraPata.position_y = mesa.position_y + 0.5;
            }

            if (x.IsKeyDown(Key.Down) && x.IsKeyDown(Key.P)) // hacia abajo en Y
            {

                Mesa mesa = (Mesa)this.escenario.listaObjetos["Mesa"];
                PrimeraPata primeraPata = (PrimeraPata)mesa.listaPartes["PrimeraPata"];
                primeraPata.position_y = mesa.position_y - 0.5;
            }

            if (x.IsKeyDown(Key.Right) && x.IsKeyDown(Key.P))
            { // hacia derecha en X

                Mesa mesa = (Mesa)this.escenario.listaObjetos["Mesa"];
                PrimeraPata primeraPata = (PrimeraPata)mesa.listaPartes["PrimeraPata"];
                primeraPata.position_x = mesa.position_x + 0.5;
            }

            if ( x.IsKeyDown(Key.Left) && x.IsKeyDown(Key.P)) // hacia izquierda en X
            {

                Mesa mesa = (Mesa)this.escenario.listaObjetos["Mesa"];
                PrimeraPata primeraPata = (PrimeraPata)mesa.listaPartes["PrimeraPata"];
                primeraPata.position_x = mesa.position_x - 0.5;
            }


            if (x.IsKeyDown(Key.Up) && x.IsKeyDown(Key.Z) && x.IsKeyDown(Key.P))
            { // hacia Z +

                Mesa mesa = (Mesa)this.escenario.listaObjetos["Mesa"];
                PrimeraPata primeraPata = (PrimeraPata)mesa.listaPartes["PrimeraPata"];
                primeraPata.position_z = mesa.position_z + 0.5;
            }

            if ( x.IsKeyDown(Key.Down) && x.IsKeyDown(Key.Z) && x.IsKeyDown(Key.P)) // hacia Z -
            {

                Mesa mesa = (Mesa)this.escenario.listaObjetos["Mesa"];
                PrimeraPata primeraPata = (PrimeraPata)mesa.listaPartes["PrimeraPata"];
                primeraPata.position_z = mesa.position_z - 0.5;
            }

            ///ESTO ES PARA ROTAR SOLO LA MESA
            ///

            if (x.IsKeyDown(Key.R) && x.IsKeyDown(Key.M) && x.IsKeyDown(Key.P))
            { //angulo positivo

                Mesa mesa = (Mesa)this.escenario.listaObjetos["Mesa"];
                PrimeraPata primeraPata = (PrimeraPata)mesa.listaPartes["PrimeraPata"];
                primeraPata.anguloRotacion = mesa.anguloRotacion + 1.0;

            }




        }


        protected override void OnRenderFrame(FrameEventArgs e)
        {
            GL.LoadIdentity();
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit );



            GL.PushMatrix();

            this.escenario.Dibujar();


            GL.PopMatrix();


            Context.SwapBuffers();

            

            base.OnRenderFrame(e);
        }

    }
}
