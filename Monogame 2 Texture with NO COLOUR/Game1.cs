using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Reflection.Metadata.Ecma335;

namespace Monogame_2_Texture_with_NO_COLOUR
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        Texture2D taintTexture, burnbaseTexture, patchouTexture, tforgorTexture, lilrTexture;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            _graphics.PreferredBackBufferWidth = 800;
            _graphics.PreferredBackBufferHeight = 500;
            _graphics.ApplyChanges();
            this.Window.Title = "frank the monogame project";
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here

            taintTexture = Content.Load<Texture2D>("taint");
            burnbaseTexture = Content.Load<Texture2D>("burnbase");
            lilrTexture = Content.Load<Texture2D>("lilrt");
            tforgorTexture = Content.Load<Texture2D>("tforgor");
            patchouTexture = Content.Load<Texture2D>("patchou");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Lavender);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            _spriteBatch.Draw(burnbaseTexture, new Vector2(0, 0), Color.White);
            _spriteBatch.Draw(taintTexture, new Vector2(190, 190), Color.White);
            _spriteBatch.Draw(lilrTexture, new Vector2(450, 300), Color.White);
            _spriteBatch.Draw(tforgorTexture, new Vector2(300, 3), Color.White);
            _spriteBatch.Draw(patchouTexture, new Vector2(350, 234), Color.White);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}