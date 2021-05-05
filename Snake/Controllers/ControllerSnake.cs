﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Snake.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Snake.Controllers
{
    class ControllerSnake
    {

        private readonly ModelSnake _snake;
        private static ControllerBiscuit _controllerBiscuit;

        public ControllerSnake(ContentManager content, GraphicsDeviceManager graphics)
        {
            _snake = new ModelSnake(content, graphics);
        }

        public void setControllerBiscuit(ref ControllerBiscuit controllerBiscuit)
        {
            _controllerBiscuit = controllerBiscuit;
        }

        public bool Collided { get; private set; }

        public void Update(GameTime gameTime, GraphicsDeviceManager graphics)
        {
            _snake.RectBiscuit = _controllerBiscuit.RectBiscuit;
            _snake.Update(gameTime, graphics);
            Collided = _snake.Collided;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            _snake.Draw(spriteBatch);
        }

    }
}
