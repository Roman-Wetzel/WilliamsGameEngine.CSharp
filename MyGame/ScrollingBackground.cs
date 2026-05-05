using GameEngine;
using SFML.Graphics;
using SFML.System;
using SFML.Window;

namespace MyGame
{
    class Background : GameObject
    {
        private const float Speed = 0.2f;
        
        private readonly Sprite _sprite= new Sprite();
        private readonly Sprite _sprite2= new Sprite();
        public Background()
        {
            _sprite.Texture = Game.GetTexture("Resources/background.png");
            _sprite2.Texture = Game.GetTexture("Resources/background.png");
            _sprite.Position = new Vector2f(0,0);
            _sprite2.Position = new Vector2f(750,0);

            //AssignTag("background");
        }
        public override void Draw()
        {
            Game.RenderWindow.Draw(_sprite);
            Game.RenderWindow.Draw(_sprite2);
        }
        public override void Update(Time elapsed)
        {
            int msElapsed = elapsed.AsMilliseconds();
            Vector2f pos = _sprite.Position;
            Vector2f pos2 = _sprite2.Position;

           
            if(pos.X < _sprite.GetGlobalBounds().Width * -1)
            {
                _sprite.Position = new Vector2f(pos.X + 2*_sprite.GetLocalBounds().Width, pos.Y);
            }
            else
            {
                _sprite.Position = new Vector2f(pos.X - Speed * msElapsed, pos.Y);
            }



            if(pos2.X < _sprite2.GetGlobalBounds().Width * -1)
            {
                _sprite2.Position = new Vector2f(pos2.X + 2*_sprite2.GetLocalBounds().Width, pos2.Y);
            }
            else
            {
                _sprite2.Position = new Vector2f(pos2.X - Speed * msElapsed, pos2.Y);
            }

            
        }
    }
}