﻿using GameLibrary;
using GenericRPG.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GenericRPG
{
    public partial class FrmCharacterSelect : Form
    {
        public static string sprite;

        public FrmCharacterSelect()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            FrmMap frmMap = new FrmMap();

            frmMap.Show();
            Hide();

            frmMap.character.SelectCharacter(Resources.ResourceManager.GetObject("character") as Bitmap, "Mega Man", 10, 10, 40);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmMap frmMap = new FrmMap();

            frmMap.Show();
            Hide();

            Game.GetGame().map.CharacterSprite = "mario";
            frmMap.character.SelectCharacter(Resources.ResourceManager.GetObject("mario") as Bitmap, "Mario", 10, 15, 25);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sprite = "character3";
            FrmMap frmMap = new FrmMap();

            frmMap.Show();
            Hide();

            Game.GetGame().map.CharacterSprite = "link";
            frmMap.character.SelectCharacter(Resources.ResourceManager.GetObject("link") as Bitmap, "Link", 12, 8, 10);
        }
    }
}
