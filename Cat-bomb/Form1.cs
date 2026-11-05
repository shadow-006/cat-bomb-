
using System;
using System.Windows.Forms;
using System.Media;

namespace Cat_bomb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random r = new Random();
        int bombNum, score = 0;
        bool gameOver = false;
        bool open1 = false, open2 = false, open3 = false , open4 = false, open5 = false, open6 = false;
        

        string path = "C:\\Users\\xalid\\Downloads\\";

        private void Form1_Load(object sender, EventArgs e)
        {
            NewGame();
        }

        private void NewGame()
        {
            score = 0;
            gameOver = false;
            bombNum = r.Next(1, 7);

            open1 = open2 = open3 =  open4 = open5 = open6 = false;
            

            label2.Text = "0";

            pictureBox1.ImageLocation = path + "question.png";
            pictureBox2.ImageLocation = path + "question.png";
            pictureBox3.ImageLocation = path + "question.png";
            pictureBox4.ImageLocation = path + "question.png";
            pictureBox5.ImageLocation = path + "question.png";
            pictureBox6.ImageLocation = path + "question.png";
        }

        private void Check(PictureBox pb, int num)
        {
            if (num == bombNum)
            {
                pb.ImageLocation = path + "bomba.png";
                new SoundPlayer(path + "explosion.wav").Play();
                gameOver = true;
                MessageBox.Show("Oyun bitdi!");
            }
            else
            {
                pb.ImageLocation = path + "cat.png";
                score++;
                label2.Text = score.ToString();

                if (score == 5)
                {
                    gameOver = true;
                    MessageBox.Show("Təbriklər! Oyunu qazandınız!");
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (gameOver || open1) return;
            open1 = true;
            Check(pictureBox1, 1);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (gameOver || open2) return;
            open2 = true;
            Check(pictureBox2, 2);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (gameOver || open3) return;
            open3 = true;
            Check(pictureBox3, 3);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (gameOver || open4) return;
            open4 = true;
            Check(pictureBox4, 4);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (gameOver || open5) return;
            open5 = true;
            Check(pictureBox5, 5);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (gameOver || open6) return;
            open6 = true;
            Check(pictureBox6, 6);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            NewGame();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
