 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace newGameCryptic
{
    public class ScreenManager
    {
        private static ScreenManager instance;

        public Vector2 Dimension { private set; get; }
        public ContentManager Content { private set; get; }

        GameScreen currentScreen; 

        public static ScreenManager Instance
        {
            get
            {
                if (instance == null)
                    instance = new ScreenManager();

                return instance;
            }
        }

        public ScreenManager()
        {
            Dimension = new Vector2(1280, 720);

            currentScreen = new SplashScreen();
        }

        public void LoadContent(ContentManager content)
        {
            this.Content = new ContentManager(content.ServiceProvider, "Content");
            currentScreen.LoadContent();
        }

        public void UnloadContent()
        {
            currentScreen.UnloadContent();
        }

        public void Update(GameTime gametime)
        {
            currentScreen.Update(gametime);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            currentScreen.Draw(spriteBatch); 
        }
    }
}
