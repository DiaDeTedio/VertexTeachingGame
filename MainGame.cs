using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using VertexTeachingGame.Rendering.Models;
using VertexTeachingGame.Rendering.Services;

namespace VertexTeachingGame
{
    public class MainGame : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private MeshRenderer _renderer;

        public MainGame()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;

            _renderer = new MeshRenderer(_graphics);
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        Mesh mesh;
        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            CreateMesh();
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        void CreateMesh()
        {
            mesh = new Mesh(_graphics.GraphicsDevice, new[]
                {
                    new VertexPositionColor(new Vector3(-1, -1, 0), Color.White),
                    new VertexPositionColor(new Vector3(1, -1, 0), Color.Red),
                    new VertexPositionColor(new Vector3(0, 1, 0), Color.Blue),
                },
                new[]
                {
                    new Triangle(0, 1, 2),
                }
            );
            mesh.GenerateMeshData();
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            _renderer.DrawMesh(mesh);

            base.Draw(gameTime);
        }
    }
}
