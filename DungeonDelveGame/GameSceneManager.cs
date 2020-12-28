using DungeonDelveGame.GameStates;
using DungeonDelveGame.Interfaces;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DungeonDelveGame
{
	public class GameSceneManager
	{
		private List<IGameScene> _allGameScenes;
		private IGameScene _currentGameState;

		public GameSceneManager()
		{
			_allGameScenes = new List<IGameScene>();
		}

		public void AddGameScene( IGameScene scene )
		{
			_allGameScenes.Add( scene );
		}

		public void SetGameScene( string sceneName )
		{
			_currentGameState = _allGameScenes.Where( x => x.Name == sceneName ).FirstOrDefault();
		}

		public IGameScene GetCurrentGameScene()
		{
			return _currentGameState;
		}
	}
}
