using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace newGameCryptic
{
    class SplashScreen : GameScreen
    {
        Texture2D image;
        string path;

        public override void LoadContent()
        {
            base.LoadContent();
            path = "RIdle1";
            image = content.Load<Texture2D>(path);
        }

        public override void UnloadContent()
        {
            base.UnloadContent();
        }

        public override void Update(GameTime gametime)
        {
            base.Update(gametime);
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(image, Vector2.Zero, Color.White);
            spriteBatch.End();
        }
    }
}
