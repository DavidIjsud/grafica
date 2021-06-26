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
        Chair silla;
        Mesa mesa;


        double angulo = 0.0;
        double anguloMesa = 0.0;
        double escala = 1.0;
        double escalaMesa = 1.0;

        public Game(int width, int height, string title) : base(width, height, GraphicsMode.Default, title) {

            this.escenario = new Escenario(0.0, 0.0, 0.0, 0.0, 0.0);
            silla = (Chair)this.escenario.listaObjetos["Silla"];
            mesa = (Mesa)this.escenario.listaObjetos["Mesa"];
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


        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            //base.OnKeyPress(e);

            Console.WriteLine("Key Press :" + e.KeyChar);
           

        }

        protected override void OnKeyDown(KeyboardKeyEventArgs e)
        {
          
        }


        protected override void OnKeyUp(KeyboardKeyEventArgs e)
        {
         
        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            base.OnUpdateFrame(e);
            KeyboardState x = OpenTK.Input.Keyboard.GetState();
            if ( x.IsKeyDown(Key.R) && x.IsKeyDown(Key.S) ) {
                this.angulo += 1.0;
                if (this.angulo == 360)
                {
                    this.angulo -= 360;
                }
            }

            if (x.IsKeyDown(Key.R) && x.IsKeyDown(Key.M))
            {
                this.anguloMesa += 1.0;
                if (this.anguloMesa == 360)
                {
                    this.anguloMesa -= 360;
                }
            }

            if (x.IsKeyDown(Key.Plus) && x.IsKeyDown(Key.S))
            {
                this.escala += 0.1;
            }

            if (x.IsKeyDown(Key.Minus) && x.IsKeyDown(Key.S))
            {
                this.escala -= 0.1;
            }

            if (x.IsKeyDown(Key.Plus) && x.IsKeyDown(Key.M))
            {
                this.escalaMesa += 0.1;
            }

            if (x.IsKeyDown(Key.Minus) && x.IsKeyDown(Key.M))
            {
                this.escalaMesa -= 0.1;
            }
        }


        protected override void OnRenderFrame(FrameEventArgs e)
        {
            GL.LoadIdentity();
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit );


            

            GL.PushMatrix();
             GL.Translate(-5.0, 0.0, -40.0);
            
            this.silla.Escalar(this.escala, this.escala , this.escala);
            this.silla.Rotar(this.angulo , 1 ,1 , 0);
            this.silla.Dibujar();

            
            GL.PopMatrix();

            GL.PushMatrix();
            GL.Translate(-5.0, 0.0, -40.0);

            this.mesa.Escalar(this.escalaMesa, this.escalaMesa, this.escalaMesa);
            this.mesa.Rotar(this.anguloMesa, 1 , 1, 0);
            this.mesa.Dibujar();


            GL.PopMatrix();


            Context.SwapBuffers();

            

            base.OnRenderFrame(e);
        }

    }
}
