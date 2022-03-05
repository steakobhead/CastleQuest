// created by: kaiden terrana
// creation date: 3/5/22
// abstract class, represents
// every Game Object in Game

using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Castle_Quest
{
    abstract class GameObject
    {
        // ----- fields -----

        /// <summary>
        /// texture of the game object
        /// </summary>
        Texture2D texture;

        /// <summary>
        /// location of game object
        /// </summary>
        Rectangle rectangle;

        // ----- properties -----

        /// <summary>
        /// set and get texture
        /// useful for when textures get added to game
        /// </summary>
        public Texture2D Texture { get { return texture; } set { texture = value; } }

        /// <summary>
        /// get and set x value for rectangle
        /// </summary>
        public int XRectangle { get { return rectangle.X; } set { rectangle.X = value; } }

        /// <summary>
        /// get and set y value for rectangle
        /// </summary>
        public int YRectangle { get { return rectangle.Y; } set { rectangle.Y = value; } }

        public Rectangle Rectangle { get { return rectangle; } set { rectangle = value; } }


        //constructor
        public GameObject(Texture2D pTexture, int pX, int pY, int pWidth, int pHeight)
        {
            texture = pTexture;
            rectangle = new Rectangle(pX, pY, pWidth, pHeight);
        }

        // ----- methods -----

        /// <summary>
        /// checks if current rect intersects other object
        /// </summary>
        /// <param name="gameObject">object checked against</param>
        /// <returns>true if collision, false otherwise</returns>
        public bool CheckCollisions(GameObject gameObject)
        {
            if (Rectangle.Intersects(gameObject.Rectangle))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// draws game object to screen
        /// </summary>
        /// <param name="sb"></param>
        public virtual void Draw(SpriteBatch sb)
        {
            sb.Draw(Texture, Rectangle, Color.White);
        }
    }
}