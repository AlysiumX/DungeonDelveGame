using DungeonDelveGame.Interfaces;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonDelveGame.GameStates
{
	//TODO : This scene will probably be pretty involved so it will probably have to be split at some point.
	//TODO : I also do not really like this name.
	public class PlayingScene : IGameScene
	{
		public string Name => "Playing";

		private GameSceneManager _gameSceneManager;
		private LevelManager _levelManager;
		public void SetGameSceneManager( GameSceneManager gameSceneManager ) { _gameSceneManager = gameSceneManager; }

		public void LoadContent( ContentManager content )
		{
			_levelManager = new LevelManager();
			_levelManager.LoadContent( content );
			//throw new NotImplementedException();
		}

		public void Update( GameTime gameTime )
		{
			//throw new NotImplementedException();
		}

		public void Draw( GameTime gameTime, SpriteBatch _spriteBatch )
		{
			_levelManager.Draw( _spriteBatch );
			//throw new NotImplementedException();
		}
	}
}
