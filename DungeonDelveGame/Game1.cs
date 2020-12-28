using DungeonDelveGame.GameStates;
using DungeonDelveGame.Interfaces;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace DungeonDelveGame
{
	public class Game1 : Game
	{
		private GraphicsDeviceManager _graphics;
		private SpriteBatch _spriteBatch;
		private readonly GameSceneManager _gameSceneManager;

		public Game1()
		{
			_graphics = new GraphicsDeviceManager( this );
			_graphics.PreferredBackBufferWidth = 800;
			_graphics.PreferredBackBufferHeight = 600;
			_graphics.ApplyChanges();

			Content.RootDirectory = "Content";

			_gameSceneManager = new GameSceneManager();
			_gameSceneManager.AddGameScene( new PlayingScene() );
			_gameSceneManager.SetGameScene( "Playing" );

			IsMouseVisible = true;
		}

		protected override void Initialize()
		{
			// TODO: Add your initialization logic here

			base.Initialize();
		}

		protected override void LoadContent()
		{
			_spriteBatch = new SpriteBatch( GraphicsDevice );
			_gameSceneManager.GetCurrentGameScene().LoadContent( Content );
			// TODO: use this.Content to load your game content here
		}

		protected override void Update( GameTime gameTime )
		{
			if( GamePad.GetState( PlayerIndex.One ).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown( Keys.Escape ) )
				Exit();

			// TODO: Add your update logic here
			_gameSceneManager.GetCurrentGameScene().Update( gameTime );

			base.Update( gameTime );
		}

		protected override void Draw( GameTime gameTime )
		{
			GraphicsDevice.Clear( Color.CornflowerBlue );

			// TODO: Add your drawing code here
			_spriteBatch.Begin();
			_gameSceneManager.GetCurrentGameScene().Draw( gameTime, _spriteBatch );
			_spriteBatch.End();

			base.Draw( gameTime );
		}
	}
}
