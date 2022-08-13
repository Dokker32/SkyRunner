using System.Windows.Forms;

namespace Game_Example
{
    public partial class Form1 : Form
    {
        private GameWorld gameWorld;
        public Form1()
        {
            InitializeComponent();

            gameWorld = new GameWorld(DisplayRectangle,CreateGraphics());
           
        }

        private void GameLoop_Tick(object sender, System.EventArgs e)
        {
            gameWorld.Update();
        }
    }
    }
