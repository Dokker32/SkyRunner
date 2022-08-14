using System.Drawing;
using System.Windows.Forms;

namespace Game_Example
{
    class GameObject
    {
        private Image sprite;
        private Graphics graphics;
        private Transform transform;
        private Point point;
        private Color backgroundColor;

        public GameObject(Graphics graphics)
        {
            sprite = Image.FromFile(@"Sprites/player.png");
            this.graphics = graphics;
            transform.position = new Vector2(GameWorld.worldSize.Width/2-sprite.Width/2, GameWorld.worldSize.Height-sprite.Height);
            this.position = position;
            this.position.Y = sprite.Height;
            this.position.X = sprite.Width/2;
        }

       

        public void Update()
        {
            //if (Keyboard.IsKeyDown(Keys.D))
            //{
            //    position.X += 1;
            //}
            //if (Keyboard.IsKeyDown(Keys.A))
            //{
            //    position.X -= 1;
            //}
            //if (Keyboard.IsKeyDown(Keys.S))
            //{
            //    position.Y -= 1;
            //}
            //if (Keyboard.IsKeyDown(Keys.W))
            //{
            //    position.Y += 1;
            //}
            graphics.DrawImage(sprite, transform.Position.x, transform.Position.Y);
        }
    }
}
