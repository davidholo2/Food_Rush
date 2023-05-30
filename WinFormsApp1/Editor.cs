using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;



namespace WinFormsApp1
{
    public partial class Editor : Form
    {
        private AnimalList animallist;

        public Editor()
        {
            InitializeComponent();
            animallist = new AnimalList();
            chooseAnimal.Items.Clear();
            startGame.Enabled = false;
        }

        private void StartGame_Click(object sender, EventArgs e)
        {
            Game mainGame = new Game();
            mainGame.Show();
            Animal ChosenAnimal = animallist[chooseAnimal.SelectedIndex];
            mainGame.SetMainAnimal(ChosenAnimal);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            hideAll();
        }
        private void horseSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            horseBreed.Items.Clear();
            if (horseSize.SelectedItem.ToString() == HorseSize.Regular.ToString())
            {
                horseBreed.Items.Add(HorseBreed.Brown);
                horseBreed.Items.Add(HorseBreed.Black);
            }
            else
            {
                horseBreed.Items.Add(HorseBreed.Rainbow);
                horseBreed.Items.Add(HorseBreed.Twilight);
            }
        }

        private void hideAll()
        {
            birdBreed.Visible = false;
            birdBreedLabel.Visible = false;
            horseBreed.Visible = false;
            horseBreedLabel.Visible = false;
            horseSize.Visible = false;
            horseSizeLabel.Visible = false;
            birdSize.Visible = false;
            birdSizeLabel.Visible = false;
        }

        private void animalType_SelectedIndexChanged(object sender, EventArgs e)
        {
            hideAll();
            if (animlType.SelectedItem.ToString() == AnimalType.Bird.ToString())
            {
                birdBreed.Visible = true;
                birdBreedLabel.Visible = true;
                birdSize.Visible = true;
                birdSizeLabel.Visible = true;
            }
            else if (animlType.SelectedItem.ToString() == AnimalType.Horse.ToString())
            {
                horseBreed.Visible = true;
                horseBreedLabel.Visible = true;
                horseSize.Visible = true;
                horseSizeLabel.Visible = true;
            }
        }

        private void addAnimal_Click(object sender, EventArgs e)
        {
            if (chooseAnimal.Items.IndexOf(animalName.Text) > -1)
            {
                errorProvider1.SetError(animalName, "Name is already taken.");
                return;
            }

            string name = animalName.Text;
            Animal animal;
            if (animlType.SelectedItem.ToString() == AnimalType.Bird.ToString())
            {
                BirdSize size = (BirdSize)Enum.Parse(typeof(BirdSize), birdSize.SelectedItem.ToString());
                BirdBreed breed = (BirdBreed)Enum.Parse(typeof(BirdBreed), birdBreed.SelectedItem.ToString());
                if(size==BirdSize.Small)
                {
                    animal = new Small(name, breed);
                }
                else
                {
                    animal = new Big(name, breed);
                }
            }
            else if(animlType.SelectedItem.ToString() == AnimalType.Horse.ToString()) //Horse
            {

                HorseSize size = (HorseSize)Enum.Parse(typeof(HorseSize), horseSize.SelectedItem.ToString());
                HorseBreed breed = (HorseBreed)Enum.Parse(typeof(HorseBreed), horseBreed.SelectedItem.ToString());
                if (size == HorseSize.Pony)
                {
                    animal = new Pony(name, breed);
                }
                else
                {
                    animal = new Regular(name, breed);
                }
            }
            else // Lion
            {
                animal = new Lion(name);
            }

            animallist.Add(animal);
            chooseAnimal.Items.Clear();

            for (int i = 0; i < animallist.NextIndex; i++)
            {
                chooseAnimal.Items.Add(animallist[i].GetName());
            }

        }

        private void loadAnimals_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = Directory.GetCurrentDirectory(),
                Filter = "model files (*.mdl)|*.mdl|All files (*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = true
            };
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Stream stream = File.Open(openFileDialog1.FileName, FileMode.Open);
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                animallist = (AnimalList)binaryFormatter.Deserialize(stream);
                chooseAnimal.Invalidate();
                chooseAnimal.Items.Clear();

                for (int i = 0; i < animallist.NextIndex; i++)
                {
                    chooseAnimal.Items.Add(animallist[i].GetName());
                }
            }
        }

        private void saveAnimals_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog
            {
                InitialDirectory = Directory.GetCurrentDirectory(),
                Filter = "model files (*.mdl)|*.mdl|All files (*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = true
            };
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                IFormatter formatter = new BinaryFormatter();
                using Stream stream = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write, FileShare.None);
                formatter.Serialize(stream, animallist);
            }
        }

        private void chooseAnimal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chooseAnimal.SelectedIndex > -1)
            {startGame.Enabled = true;}
            else
            { startGame.Enabled = false; }
        }

        private void birdSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            birdBreed.Items.Clear();
            if (birdSize.SelectedItem.ToString() == BirdSize.Small.ToString())
            {
                birdBreed.Items.Add(BirdBreed.Parrot);
                birdBreed.Items.Add(BirdBreed.Chicken);
            }
            else
            {
                birdBreed.Items.Add(BirdBreed.Ostrich);
                birdBreed.Items.Add(BirdBreed.Penguin);
            }
        }

        private void secret_txtbox_TextChanged(object sender, EventArgs e)
        {
            if(secret_txtbox.Text.ToString()=="Lion"|| secret_txtbox.Text.ToString() == "lion")
            {
                animlType.Items.Add(AnimalType.Lion);
            }
        }
    }
}
