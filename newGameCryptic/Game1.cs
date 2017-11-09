using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace newGameCryptic
{
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            graphics.PreferredBackBufferWidth = 1280;
            graphics.PreferredBackBufferHeight = 720;
            graphics.ApplyChanges();

            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            //SCM------------------------------------------------------------------
            ScreenManager.Instance.LoadContent(Content);

        }

        protected override void UnloadContent()
        {
            //SCM------------------------------------------------------------------
            ScreenManager.Instance.UnloadContent();
        }

        protected override void Update(GameTime gameTime)
        {
            //SCM------------------------------------------------------------------
            ScreenManager.Instance.Update(gameTime);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            //SCM------------------------------------------------------------------
            ScreenManager.Instance.Draw(spriteBatch);

            base.Draw(gameTime);
        }
    }
}
