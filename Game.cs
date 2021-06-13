using System;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using OpenTK.Graphics;
using System.Collections.Generic;

namespace ProjectXTwo
{
    public class  Game : GameWindow
    {

        Dictionary<string, IObjeto> listaObjetos;

        public Game(int width, int height, string title) : base(width, height, GraphicsMode.Default, title) {

            fillOfElementsInGame();
            
            this.Run(1.0/60.0);
        }

        private void fillOfElementsInGame() {

            this.listaObjetos = new Dictionary<string, IObjeto>();
            this.listaObjetos.Add("Escenario" , new Escenario(4.0, 10.0, 10.0, 1.0, 1.0));

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

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            GL.LoadIdentity();
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit );

            GL.Translate(-10.0, -15.0, -40.0);


            foreach(KeyValuePair<string, IObjeto> element in this.listaObjetos) {
                element.Value.Dibujar();      
            }
            

            Context.SwapBuffers();
            

            base.OnRenderFrame(e);
        }

    }
}
