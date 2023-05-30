
using System;

namespace WinFormsApp1
{
    partial class Editor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.animalName = new System.Windows.Forms.TextBox();
            this.animalNameLabel = new System.Windows.Forms.Label();
            this.startGame = new System.Windows.Forms.Button();
            this.results = new System.Windows.Forms.Label();
            this.animlType = new System.Windows.Forms.ComboBox();
            this.birdBreed = new System.Windows.Forms.ComboBox();
            this.birdBreedLabel = new System.Windows.Forms.Label();
            this.TextAnimalType = new System.Windows.Forms.Label();
            this.saveAnimals = new System.Windows.Forms.Button();
            this.addAnimal = new System.Windows.Forms.Button();
            this.chooseAnimal = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.loadAnimals = new System.Windows.Forms.Button();
            this.removeAnimal = new System.Windows.Forms.Button();
            this.horseBreedLabel = new System.Windows.Forms.Label();
            this.horseBreed = new System.Windows.Forms.ComboBox();
            this.horseSizeLabel = new System.Windows.Forms.Label();
            this.horseSize = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.birdSizeLabel = new System.Windows.Forms.Label();
            this.birdSize = new System.Windows.Forms.ComboBox();
            this.secret = new System.Windows.Forms.Label();
            this.secret_txtbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // animalName
            // 
            this.animalName.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.animalName.Location = new System.Drawing.Point(207, 253);
            this.animalName.Name = "animalName";
            this.animalName.Size = new System.Drawing.Size(125, 35);
            this.animalName.TabIndex = 19;
            // 
            // animalNameLabel
            // 
            this.animalNameLabel.AutoSize = true;
            this.animalNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.animalNameLabel.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.animalNameLabel.Location = new System.Drawing.Point(19, 259);
            this.animalNameLabel.Name = "animalNameLabel";
            this.animalNameLabel.Size = new System.Drawing.Size(177, 29);
            this.animalNameLabel.TabIndex = 21;
            this.animalNameLabel.Text = "Animal\'s Name";
            // 
            // startGame
            // 
            this.startGame.BackColor = System.Drawing.Color.Gold;
            this.startGame.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.startGame.ForeColor = System.Drawing.SystemColors.InfoText;
            this.startGame.Location = new System.Drawing.Point(635, 415);
            this.startGame.Name = "startGame";
            this.startGame.Size = new System.Drawing.Size(362, 67);
            this.startGame.TabIndex = 22;
            this.startGame.Text = "Start Game";
            this.startGame.UseVisualStyleBackColor = false;
            this.startGame.Click += new System.EventHandler(this.StartGame_Click);
            // 
            // results
            // 
            this.results.AutoSize = true;
            this.results.Location = new System.Drawing.Point(270, 332);
            this.results.Name = "results";
            this.results.Size = new System.Drawing.Size(0, 20);
            this.results.TabIndex = 23;
            // 
            // animlType
            // 
            this.animlType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.animlType.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.animlType.FormattingEnabled = true;
            this.animlType.Items.AddRange(new object[] {
            "Bird",
            "Horse"});
            this.animlType.Location = new System.Drawing.Point(207, 92);
            this.animlType.Name = "animlType";
            this.animlType.Size = new System.Drawing.Size(115, 36);
            this.animlType.TabIndex = 24;
            this.animlType.SelectedIndexChanged += new System.EventHandler(this.animalType_SelectedIndexChanged);
            // 
            // birdBreed
            // 
            this.birdBreed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.birdBreed.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.birdBreed.FormattingEnabled = true;
            this.birdBreed.Location = new System.Drawing.Point(207, 198);
            this.birdBreed.Name = "birdBreed";
            this.birdBreed.Size = new System.Drawing.Size(115, 36);
            this.birdBreed.TabIndex = 25;
            // 
            // birdBreedLabel
            // 
            this.birdBreedLabel.AutoSize = true;
            this.birdBreedLabel.BackColor = System.Drawing.Color.Transparent;
            this.birdBreedLabel.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.birdBreedLabel.Location = new System.Drawing.Point(61, 205);
            this.birdBreedLabel.Name = "birdBreedLabel";
            this.birdBreedLabel.Size = new System.Drawing.Size(131, 29);
            this.birdBreedLabel.TabIndex = 26;
            this.birdBreedLabel.Text = "Bird Breed";
            this.birdBreedLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.birdBreedLabel.Click += new System.EventHandler(this.TextAnimalBreed_Click);
            // 
            // TextAnimalType
            // 
            this.TextAnimalType.AutoSize = true;
            this.TextAnimalType.BackColor = System.Drawing.Color.Transparent;
            this.TextAnimalType.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TextAnimalType.Location = new System.Drawing.Point(34, 98);
            this.TextAnimalType.Name = "TextAnimalType";
            this.TextAnimalType.Size = new System.Drawing.Size(167, 29);
            this.TextAnimalType.TabIndex = 27;
            this.TextAnimalType.Text = "Animal\'s Type";
            // 
            // saveAnimals
            // 
            this.saveAnimals.BackColor = System.Drawing.Color.Transparent;
            this.saveAnimals.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.saveAnimals.Location = new System.Drawing.Point(313, 382);
            this.saveAnimals.Name = "saveAnimals";
            this.saveAnimals.Size = new System.Drawing.Size(140, 41);
            this.saveAnimals.TabIndex = 30;
            this.saveAnimals.Text = "Save";
            this.saveAnimals.UseVisualStyleBackColor = false;
            this.saveAnimals.Click += new System.EventHandler(this.saveAnimals_Click);
            // 
            // addAnimal
            // 
            this.addAnimal.BackColor = System.Drawing.Color.Transparent;
            this.addAnimal.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addAnimal.Location = new System.Drawing.Point(19, 323);
            this.addAnimal.Name = "addAnimal";
            this.addAnimal.Size = new System.Drawing.Size(140, 41);
            this.addAnimal.TabIndex = 31;
            this.addAnimal.Text = "Add";
            this.addAnimal.UseVisualStyleBackColor = false;
            this.addAnimal.Click += new System.EventHandler(this.addAnimal_Click);
            // 
            // chooseAnimal
            // 
            this.chooseAnimal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chooseAnimal.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chooseAnimal.FormattingEnabled = true;
            this.chooseAnimal.Location = new System.Drawing.Point(193, 379);
            this.chooseAnimal.Name = "chooseAnimal";
            this.chooseAnimal.Size = new System.Drawing.Size(115, 36);
            this.chooseAnimal.TabIndex = 32;
            this.chooseAnimal.SelectedIndexChanged += new System.EventHandler(this.chooseAnimal_SelectedIndexChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // loadAnimals
            // 
            this.loadAnimals.BackColor = System.Drawing.Color.Transparent;
            this.loadAnimals.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loadAnimals.Location = new System.Drawing.Point(313, 430);
            this.loadAnimals.Name = "loadAnimals";
            this.loadAnimals.Size = new System.Drawing.Size(140, 41);
            this.loadAnimals.TabIndex = 34;
            this.loadAnimals.Text = "Load";
            this.loadAnimals.UseVisualStyleBackColor = false;
            this.loadAnimals.Click += new System.EventHandler(this.loadAnimals_Click);
            // 
            // removeAnimal
            // 
            this.removeAnimal.BackColor = System.Drawing.Color.Transparent;
            this.removeAnimal.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.removeAnimal.Location = new System.Drawing.Point(168, 323);
            this.removeAnimal.Name = "removeAnimal";
            this.removeAnimal.Size = new System.Drawing.Size(140, 41);
            this.removeAnimal.TabIndex = 37;
            this.removeAnimal.Text = "Remove";
            this.removeAnimal.UseVisualStyleBackColor = false;
            this.removeAnimal.Click += new System.EventHandler(this.removeAnimal_Click);
            // 
            // horseBreedLabel
            // 
            this.horseBreedLabel.AutoSize = true;
            this.horseBreedLabel.BackColor = System.Drawing.Color.Transparent;
            this.horseBreedLabel.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.horseBreedLabel.Location = new System.Drawing.Point(322, 205);
            this.horseBreedLabel.Name = "horseBreedLabel";
            this.horseBreedLabel.Size = new System.Drawing.Size(150, 29);
            this.horseBreedLabel.TabIndex = 39;
            this.horseBreedLabel.Text = "Horse Breed";
            this.horseBreedLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // horseBreed
            // 
            this.horseBreed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.horseBreed.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.horseBreed.FormattingEnabled = true;
            this.horseBreed.Location = new System.Drawing.Point(468, 202);
            this.horseBreed.Name = "horseBreed";
            this.horseBreed.Size = new System.Drawing.Size(115, 36);
            this.horseBreed.TabIndex = 38;
            // 
            // horseSizeLabel
            // 
            this.horseSizeLabel.AutoSize = true;
            this.horseSizeLabel.BackColor = System.Drawing.Color.Transparent;
            this.horseSizeLabel.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.horseSizeLabel.Location = new System.Drawing.Point(322, 154);
            this.horseSizeLabel.Name = "horseSizeLabel";
            this.horseSizeLabel.Size = new System.Drawing.Size(130, 29);
            this.horseSizeLabel.TabIndex = 41;
            this.horseSizeLabel.Text = "Horse Size";
            this.horseSizeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // horseSize
            // 
            this.horseSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.horseSize.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.horseSize.FormattingEnabled = true;
            this.horseSize.Items.AddRange(new object[] {
            "Regular",
            "Pony"});
            this.horseSize.Location = new System.Drawing.Point(456, 151);
            this.horseSize.Name = "horseSize";
            this.horseSize.Size = new System.Drawing.Size(115, 36);
            this.horseSize.TabIndex = 40;
            this.horseSize.SelectedIndexChanged += new System.EventHandler(this.horseSize_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(10, 386);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 29);
            this.label3.TabIndex = 42;
            this.label3.Text = "Choose Animal";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(379, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 35);
            this.label1.TabIndex = 43;
            this.label1.Text = "The Food Rush";
            // 
            // birdSizeLabel
            // 
            this.birdSizeLabel.AutoSize = true;
            this.birdSizeLabel.BackColor = System.Drawing.Color.Transparent;
            this.birdSizeLabel.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.birdSizeLabel.Location = new System.Drawing.Point(61, 158);
            this.birdSizeLabel.Name = "birdSizeLabel";
            this.birdSizeLabel.Size = new System.Drawing.Size(111, 29);
            this.birdSizeLabel.TabIndex = 44;
            this.birdSizeLabel.Text = "Bird Size";
            this.birdSizeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // birdSize
            // 
            this.birdSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.birdSize.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.birdSize.FormattingEnabled = true;
            this.birdSize.Items.AddRange(new object[] {
            "Small",
            "Big"});
            this.birdSize.Location = new System.Drawing.Point(207, 147);
            this.birdSize.Name = "birdSize";
            this.birdSize.Size = new System.Drawing.Size(115, 36);
            this.birdSize.TabIndex = 45;
            this.birdSize.SelectedIndexChanged += new System.EventHandler(this.birdSize_SelectedIndexChanged);
            // 
            // secret
            // 
            this.secret.AutoSize = true;
            this.secret.BackColor = System.Drawing.Color.Transparent;
            this.secret.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.secret.Location = new System.Drawing.Point(568, 95);
            this.secret.Name = "secret";
            this.secret.Size = new System.Drawing.Size(279, 29);
            this.secret.TabIndex = 46;
            this.secret.Text = "Secret Animal Password";
            // 
            // secret_txtbox
            // 
            this.secret_txtbox.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.secret_txtbox.Location = new System.Drawing.Point(839, 93);
            this.secret_txtbox.Name = "secret_txtbox";
            this.secret_txtbox.Size = new System.Drawing.Size(125, 35);
            this.secret_txtbox.TabIndex = 47;
            this.secret_txtbox.TextChanged += new System.EventHandler(this.secret_txtbox_TextChanged);
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.BackgroundImage = global::WinFormsApp1.Properties.Resources.farm_bg;
            this.ClientSize = new System.Drawing.Size(1008, 491);
            this.Controls.Add(this.secret_txtbox);
            this.Controls.Add(this.secret);
            this.Controls.Add(this.birdSize);
            this.Controls.Add(this.birdSizeLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.horseSizeLabel);
            this.Controls.Add(this.horseSize);
            this.Controls.Add(this.horseBreedLabel);
            this.Controls.Add(this.horseBreed);
            this.Controls.Add(this.removeAnimal);
            this.Controls.Add(this.loadAnimals);
            this.Controls.Add(this.chooseAnimal);
            this.Controls.Add(this.addAnimal);
            this.Controls.Add(this.saveAnimals);
            this.Controls.Add(this.TextAnimalType);
            this.Controls.Add(this.birdBreedLabel);
            this.Controls.Add(this.birdBreed);
            this.Controls.Add(this.animlType);
            this.Controls.Add(this.results);
            this.Controls.Add(this.startGame);
            this.Controls.Add(this.animalNameLabel);
            this.Controls.Add(this.animalName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Editor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Food Rush";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void removeAnimal_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < animallist.NextIndex; i++)
            {
                if (chooseAnimal.SelectedItem == null)
                {
                    break;
                }
                if (chooseAnimal.SelectedItem.ToString() == animallist[i].GetName())
                {
                    chooseAnimal.Items.Remove(animallist[i].GetName());
                    animallist.Remove(animallist[i]);
                }
            }

            if (chooseAnimal.SelectedIndex > -1)
            {
                startGame.Enabled = true;
            }
            else
            {
                startGame.Enabled = false;
            }
        }
        private void TextAnimalBreed_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        #endregion
        private System.Windows.Forms.TextBox animalName;
        private System.Windows.Forms.Label animalNameLabel;
        private System.Windows.Forms.Button startGame;
        private System.Windows.Forms.Label results;
        private System.Windows.Forms.ComboBox animlType;
        private System.Windows.Forms.ComboBox birdBreed;
        private System.Windows.Forms.Label birdBreedLabel;
        private System.Windows.Forms.Label TextAnimalType;
        private System.Windows.Forms.Button saveAnimals;
        private System.Windows.Forms.Button addAnimal;
        private System.Windows.Forms.ComboBox chooseAnimal;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button loadAnimals;
        private System.Windows.Forms.Button removeAnimal;
        private System.Windows.Forms.Label horseSizeLabel;
        private System.Windows.Forms.ComboBox horseSize;
        private System.Windows.Forms.Label horseBreedLabel;
        private System.Windows.Forms.ComboBox horseBreed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox birdSize;
        private System.Windows.Forms.Label birdSizeLabel;
        private System.Windows.Forms.TextBox secret_txtbox;
        private System.Windows.Forms.Label secret;
    }
}