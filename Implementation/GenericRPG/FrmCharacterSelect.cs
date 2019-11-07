using GameLibrary;
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
        public FrmCharacterSelect()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            FrmMap frmMap = new FrmMap();

            frmMap.Show();
            Hide();

            frmMap.character.SelectCharacter(100, 100, 100);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmMap frmMap = new FrmMap();

            frmMap.Show();
            Hide();

            frmMap.character.SelectCharacter(100, 100, 100);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmMap frmMap = new FrmMap();

            frmMap.Show();
            Hide();

            frmMap.character.SelectCharacter(100, 100, 100);
        }
    }
}
