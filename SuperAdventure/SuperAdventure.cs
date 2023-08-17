using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Engine;

namespace SuperAdventure
{
    public partial class SuperAdventure : Form
    {
        private Player player = new Player(10, 10, 20, 0, 1);

        public SuperAdventure()
        {
            InitializeComponent();
            lblHitPoints.Text = player.currentHitPoints.ToString();
            lblGold.Text = player.gold.ToString();
            lblExperience.Text = player.experiencePoints.ToString();
            lblLevel.Text = player.level.ToString();

        }
        
    }
}
