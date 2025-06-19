using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roguelike_Game
{
    //TODO
    // Floors
    // Attack & enemy variety
    // Fix wacky drawing problem with the past moves display
    // Animations for attacks, winning or losing a fight
    // Hotkeys for actions
    // Stat tracking
    // Items
    // Loot rooms as options for nodes
    // Condence and optimize code
    // Comments
    // Stop the connecter line in map screen from appearing in the middle of the next node
    // Tweak difficulty to make it harder
    // Add status effects like burn, bleed, poison, etc
    // Get sprites that aren't stolen...
    // Randomize map generation

    /*
     * Use an array of enemies that can appear on a specific floor (?)
    */

    public partial class Form1 : Form
    {
        public static Map map = new Map();
        public static Player player;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Start the game centered on the main menu
            ChangeScreen(this, new MenuScreen());
        }

        public static void ChangeScreen(object sender, UserControl next)
        {
            Form f;

            if (sender is Form)
            {
                f = (Form)sender;
            }
            else
            {
                UserControl current = (UserControl)sender;
                f = current.FindForm();
                f.Controls.Remove(current);
            }

            next.Location = new Point((f.ClientSize.Width - next.Width) / 2,
                (f.ClientSize.Height - next.Height) / 2);
            f.Controls.Add(next);
            next.Focus();
        }
    }
}
