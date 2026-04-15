using GameEngine;

namespace MyGame
{
    public class GameScene : Scene
    {
        public GameScene()
        {
            Ship ship = new Ship();
            AddGameObject(ship);
        }
    }
}