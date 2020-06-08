using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Russian_Roullete
{
    public partial class game : Form
    {
        public game()
        {
            InitializeComponent();
        }
        //CREATED a class
        russianclass russianclass = new russianclass();
        // random number created
        Random spinrandom = new Random();
        // added sound here
        SoundPlayer sound= new SoundPlayer(Russian_Roullete.Properties.Resources.spinnn);
        private void loadbtn_Click(object sender, EventArgs e)
        {
          
            // 1 bullet loaded from random number
            russianclass.bulleteload = 1;
            // spin and load are enabled here
            spinbut.Enabled = true;
            loadbut.Enabled = false;
            //message box to be displayed afterr clicking
            MessageBox.Show("Bullet load");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // retry button to play again the game
            (new game()).Show();
            this.Hide();
        }

        private void buttonSpin_Click(object sender, EventArgs e)
        {
            // added sound play here
            sound.Play();
            russianclass.loadchamber = spinrandom.Next(1, 6);
           
            shootbut.Enabled = true;
            
            spinbut.Enabled = false;

            MessageBox.Show("Bullet spinned");
        }

        private void buttonShoot_Click(object sender, EventArgs e)
        {
            
           // for shoot button program
            int win = 0;
            win = russianclass.Shooter();

            if (win==1)
            {

                MessageBox.Show("You Loose");

                loadbut.Enabled = false;
                shootbut.Enabled = false;
                spinbut.Enabled = false;
               



            }
            else if (win==2)
            {
                

                MessageBox.Show("Bullet Missed");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // application close or exit
            Close();
        }

        private void game_Load(object sender, EventArgs e)
        {

        }
    }
    }

