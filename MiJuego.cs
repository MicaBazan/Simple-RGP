using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPG
{
    public partial class MiJuego : Form
    {
        private Player _player;


        //Construstor
        public MiJuego()
        {
            InitializeComponent();

            _player = new Player();
            _player.CurrentHitPoints = 10;
            _player.MaximumHitPoints = 10;
            _player.Gold = 20;
            _player.ExperiencePoints = 0;
            _player.Level = 1;
            lblPuntosDeImpacto.Text = _player.CurrentHitPoints.ToString();
            lblOro.Text = _player.Gold.ToString();
            lblExperiencia.Text = _player.ExperiencePoints.ToString();
            lblNivel.Text = _player.Level.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
