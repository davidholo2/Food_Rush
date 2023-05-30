using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace WinFormsApp1
{
    public partial class Game : Form
    {
       
        public Game()
        {
            InitializeComponent();
            over.Visible = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Black.Visible = false;
            Brown.Visible = false;
            Chicken.Visible = false;
            Parrot.Visible = false;
            Rainbow.Visible = false;
            Twilight.Visible = false;
            Ostrich.Visible = false;
            Penguin.Visible = false;
            Lion.Visible = false;
            win.Visible = false;
            loss.Visible = false;

        }

        protected Animal _mainAnimal;
        protected PictureBox main_pb;
        int gameSpeed = 0;
        readonly Random rnd = new Random();
        int x, y;
        int collectedFood = 0;
        int Hit;
        bool start_move = true;
        public void SetMainAnimal(Animal animal)
        {
            _mainAnimal = animal;
            if (animal.GetType() == AnimalType.Bird)
            {
                Bird bird = (Bird)animal;
                if (bird.GetBreed() == BirdBreed.Parrot)
                {
                    Parrot.Visible = true;
                    main_pb = Parrot;
                }
                else if (bird.GetBreed() == BirdBreed.Chicken)
                {
                    Chicken.Visible = true;
                    main_pb = Chicken;

                }
                else if (bird.GetBreed() == BirdBreed.Ostrich)
                {
                    Ostrich.Visible = true;
                    main_pb = Ostrich;
                }
                else if (bird.GetBreed() == BirdBreed.Penguin)
                {
                    Penguin.Visible = true;
                    main_pb = Penguin;

                }
                

            }
            else if(animal.GetType() == AnimalType.Horse)
            {
                Horse horse = (Horse)animal;
                if (horse.GetBreed() == HorseBreed.Rainbow)
                {
                    Rainbow.Visible = true;
                    main_pb = Rainbow;
                }
                else if (horse.GetBreed() == HorseBreed.Brown)
                {
                    Brown.Visible = true;
                    main_pb = Brown;
                }
                else if (horse.GetBreed() == HorseBreed.Black)
                {
                    Black.Visible = true;
                    main_pb = Black;
                }
                else if (horse.GetBreed() == HorseBreed.Twilight)
                {
                    Twilight.Visible = true;
                    main_pb = Twilight;
                }
            }
            else
            {
                Lion.Visible = true;
                main_pb = Lion;
            }
            Hit = _mainAnimal.GetLives();
            txt_hit.Text = "Lives Left:" + Hit.ToString();
            label2.Text = "Max Speed:" + _mainAnimal.GetSpeed();
        }

        
        void Bombs(int speed)
        {
            if (bomb1.Top >= 850)
            {
                x = rnd.Next(150, 1300);
                bomb1.Location = new Point(x, 0);

            }
            else
            {
                bomb1.Top += speed;
            }
            if (bomb2.Top >= 850)
            {
                x = rnd.Next(150, 1300);
                bomb2.Location = new Point(x, 0);
            }
            else
            {
                bomb2.Top += speed;
            }
        }

        void GameOver()
        {
            if (main_pb.Bounds.IntersectsWith(bomb1.Bounds))
            {
                Hit--;
                txt_hit.Text = "Lives Left:" + Hit.ToString();
                x = rnd.Next(200, 1200);
                bomb1.Location = new Point(x, 0);
                if (Hit ==0)
                {
                    timer1.Enabled = false;
                    over.Visible = true;
                    loss.Visible = true;
                }
            }
            if (main_pb.Bounds.IntersectsWith(bomb2.Bounds))
            {
                Hit--;
                txt_hit.Text = "Lives Left:" + Hit.ToString();
                x = rnd.Next(200, 1200);
                bomb2.Location = new Point(x, 0);
                if (Hit == 0)
                {
                    timer1.Enabled = false;
                    over.Visible = true;
                    loss.Visible = true;
                }
            }
            if(collectedFood==50)
            {
                timer1.Enabled = false;
                over.Visible = true;
                win.Visible = true;
            }

        }
        void Foods(int speed)
        {
            if (food1.Top >= 850)
            {
                x = rnd.Next(200, 1200);
                food1.Location = new Point(x, 0);
            }
            else
            {
                food1.Top += speed;
            }
            if (food2.Top >= 850)
            {
                x = rnd.Next(200, 1200);
                food2.Location = new Point(x, 0);
            }
            else
            {
                food2.Top += speed;
            }
            if (food3.Top >= 850)
            {
                x = rnd.Next(200, 1200);
                food3.Location = new Point(x, 0);
            }
            else
            {
                food3.Top += speed;
            }
        }

        void Foodcolletion()
        {
            if (main_pb.Bounds.IntersectsWith(food1.Bounds))
            {
                collectedFood++;
                txt_food.Text = "Food:" + collectedFood.ToString();
                x = rnd.Next(200, 1200);
                y = rnd.Next(200, 1200);
                food1.Location = new Point(x, y);

                if (collectedFood % 5 == 0 && collectedFood != 0 && gameSpeed < _mainAnimal.GetSpeed())
                {
                    gameSpeed += 5;
                }
            }
            if (main_pb.Bounds.IntersectsWith(food2.Bounds))
            {
                collectedFood++;
                txt_food.Text = "Food:" + collectedFood.ToString();
                food2.Location = new Point(x, 0);

                if (collectedFood % 5 == 0 && collectedFood != 0 && gameSpeed < _mainAnimal.GetSpeed())
                {
                    gameSpeed += 5;
                }
            }
            if (main_pb.Bounds.IntersectsWith(food3.Bounds))
            {
                collectedFood++;
                txt_food.Text = "Food:" + collectedFood.ToString();
                food3.Location = new Point(x, 0);

                if (collectedFood % 5 == 0 && collectedFood != 0 && gameSpeed < _mainAnimal.GetSpeed())
                {
                    gameSpeed += 5;
                }
            }
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            label3.Visible =false;
            if (e.KeyCode == Keys.Left)
            {
                if (main_pb.Left > 0)
                    main_pb.Left += -50;
            }
            if (e.KeyCode == Keys.Right)
            {
                if (main_pb.Right < 1500)
                    main_pb.Left += 50;
                main_pb.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            }
            if (e.KeyCode == Keys.Up && start_move == true)
            {
                gameSpeed += 10;
                start_move = false;
            }

        }

        private void Game_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                main_pb.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            }
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {

            Foods(gameSpeed);
            Foodcolletion();
            Bombs(gameSpeed);
            GameOver();
            label1.Text = "Speed:" + gameSpeed.ToString();

        }
    }
}

