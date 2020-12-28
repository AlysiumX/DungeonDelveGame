using DungeonDelveGame.Interfaces;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonDelveGame.GameStates
{
	public class TitleScene : IGameScene
	{
		public string Name { get => "Title"; }

		private GameSceneManager _gameSceneManager;
		public void SetGameSceneManager( GameSceneManager gameSceneManager ) { _gameSceneManager = gameSceneManager; }

		private Texture2D _titleBackground;

		public void LoadContent( ContentManager content )
		{
			_titleBackground = content.Load<Texture2D>( "title" );
		}

		public void Update( GameTime gameTime )
		{
			//throw new NotImplementedException();
		}

		public void Draw( GameTime gameTime, SpriteBatch spriteBatch )
		{
			spriteBatch.Draw( _titleBackground, new Vector2( 0, 0 ), Color.White );
		}
	}
}
