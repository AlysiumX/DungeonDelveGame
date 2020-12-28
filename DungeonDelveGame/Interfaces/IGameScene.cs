using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonDelveGame.Interfaces
{
	public interface IGameScene
	{
		string Name { get; }
		void SetGameSceneManager( GameSceneManager gameSceneManager );
		void LoadContent( ContentManager content );
		void Update( GameTime gameTime );
		void Draw( GameTime gameTime, SpriteBatch _spriteBatch );
	}
}
