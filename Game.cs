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

            Evento.eventoLanzado(x , this.escenario);

        }


        protected override void OnRenderFrame(FrameEventArgs e)
        {
            GL.LoadIdentity();
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit );
            GL.Translate(0.0 , 0.0 , -40.0);


            GL.PushMatrix();

            this.escenario.Dibujar();


            GL.PopMatrix();


            Context.SwapBuffers();

            

            base.OnRenderFrame(e);
        }

    }
}
