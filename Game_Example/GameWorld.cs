using System;
using System.Drawing;

namespace Game_Example
{
    class GameWorld
    {
        private Graphics dc;
        private BufferedGraphics backBuffer;
        private Color backgroundColor;
        private Size worldSize;
        private GameObject gameObject;

        public GameWorld(Rectangle displayRectangle, Graphics graphics)
        {
            this.worldSize = displayRectangle.Size;
            this.dc = graphics;
            this.backBuffer = BufferedGraphicsManager.Current.Allocate(graphics, displayRectangle);
            this.dc = backBuffer.Graphics;
            backgroundColor = ColorTranslator.FromHtml("#000c41");
            gameObject = new GameObject(graphics, new Point(worldSize.Width/2, worldSize.Height));
        }
        public void Update()
        {
            dc.Clear(backgroundColor);
            gameObject.Update();
            backBuffer.Render();
        }

    }
}
