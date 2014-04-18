#region Using
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
#endregion

namespace Pacman
{
    class Objects
    {
        /// <summary>
        /// The texture of the object
        /// </summary>
        public Texture2D Texture = null;

        /// <summary>
        /// The texture name of the object
        /// </summary>
        public string TextureName = String.Empty;

        /// <summary>
        /// The center of the texture
        /// </summary>
        public Vector2 Center = Vector2.Zero;

        /// <summary>
        /// The position of the object on the screen
        /// </summary>
        public Vector2 Position = Vector2.Zero;

        public Objects(Vector2 pos)
        {

        }

        public virtual void LoadContent(ContentManager content)
        {

        }

        public virtual void Update(GameTime gameTime)
        {

        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {

        }
    }
}
