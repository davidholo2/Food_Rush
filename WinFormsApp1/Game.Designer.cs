
namespace WinFormsApp1
{
    partial class Game
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.food1 = new System.Windows.Forms.PictureBox();
            this.food2 = new System.Windows.Forms.PictureBox();
            this.food3 = new System.Windows.Forms.PictureBox();
            this.txt_food = new System.Windows.Forms.Label();
            this.bomb1 = new System.Windows.Forms.PictureBox();
            this.bomb2 = new System.Windows.Forms.PictureBox();
            this.txt_hit = new System.Windows.Forms.Label();
            this.over = new System.Windows.Forms.PictureBox();
            this.Black = new System.Windows.Forms.PictureBox();
            this.Brown = new System.Windows.Forms.PictureBox();
            this.Chicken = new System.Windows.Forms.PictureBox();
            this.Parrot = new System.Windows.Forms.PictureBox();
            this.Rainbow = new System.Windows.Forms.PictureBox();
            this.Twilight = new System.Windows.Forms.PictureBox();
            this.Ostrich = new System.Windows.Forms.PictureBox();
            this.Penguin = new System.Windows.Forms.PictureBox();
            this.Lion = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.win = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.loss = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.food1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.food2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.food3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bomb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bomb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.over)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Black)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Brown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chicken)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Parrot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rainbow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Twilight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ostrich)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Penguin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.win)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loss)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // food1
            // 
            this.food1.BackColor = System.Drawing.Color.Transparent;
            this.food1.Image = global::WinFormsApp1.Properties.Resources.food;
            this.food1.Location = new System.Drawing.Point(219, 123);
            this.food1.Margin = new System.Windows.Forms.Padding(5);
            this.food1.Name = "food1";
            this.food1.Size = new System.Drawing.Size(70, 70);
            this.food1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.food1.TabIndex = 19;
            this.food1.TabStop = false;
            // 
            // food2
            // 
            this.food2.BackColor = System.Drawing.Color.Transparent;
            this.food2.Image = global::WinFormsApp1.Properties.Resources.food;
            this.food2.Location = new System.Drawing.Point(701, 350);
            this.food2.Margin = new System.Windows.Forms.Padding(5);
            this.food2.Name = "food2";
            this.food2.Size = new System.Drawing.Size(70, 70);
            this.food2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.food2.TabIndex = 20;
            this.food2.TabStop = false;
            // 
            // food3
            // 
            this.food3.BackColor = System.Drawing.Color.Transparent;
            this.food3.Image = global::WinFormsApp1.Properties.Resources.food;
            this.food3.Location = new System.Drawing.Point(1215, 65);
            this.food3.Margin = new System.Windows.Forms.Padding(5);
            this.food3.Name = "food3";
            this.food3.Size = new System.Drawing.Size(70, 70);
            this.food3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.food3.TabIndex = 21;
            this.food3.TabStop = false;
            // 
            // txt_food
            // 
            this.txt_food.AutoSize = true;
            this.txt_food.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_food.ForeColor = System.Drawing.Color.Black;
            this.txt_food.Location = new System.Drawing.Point(1171, 9);
            this.txt_food.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.txt_food.Name = "txt_food";
            this.txt_food.Size = new System.Drawing.Size(99, 30);
            this.txt_food.TabIndex = 23;
            this.txt_food.Text = "Food:0";
            // 
            // bomb1
            // 
            this.bomb1.BackColor = System.Drawing.Color.Transparent;
            this.bomb1.Image = global::WinFormsApp1.Properties.Resources.bomb;
            this.bomb1.Location = new System.Drawing.Point(368, 219);
            this.bomb1.Margin = new System.Windows.Forms.Padding(5);
            this.bomb1.Name = "bomb1";
            this.bomb1.Size = new System.Drawing.Size(74, 80);
            this.bomb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bomb1.TabIndex = 25;
            this.bomb1.TabStop = false;
            // 
            // bomb2
            // 
            this.bomb2.BackColor = System.Drawing.Color.Transparent;
            this.bomb2.Image = global::WinFormsApp1.Properties.Resources.bomb;
            this.bomb2.Location = new System.Drawing.Point(1069, 207);
            this.bomb2.Margin = new System.Windows.Forms.Padding(5);
            this.bomb2.Name = "bomb2";
            this.bomb2.Size = new System.Drawing.Size(77, 80);
            this.bomb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bomb2.TabIndex = 26;
            this.bomb2.TabStop = false;
            // 
            // txt_hit
            // 
            this.txt_hit.AutoSize = true;
            this.txt_hit.Font = new System.Drawing.Font("Showcard Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_hit.ForeColor = System.Drawing.Color.Black;
            this.txt_hit.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.txt_hit.Location = new System.Drawing.Point(1312, 9);
            this.txt_hit.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.txt_hit.Name = "txt_hit";
            this.txt_hit.Size = new System.Drawing.Size(129, 28);
            this.txt_hit.TabIndex = 28;
            this.txt_hit.Text = "Lives Left:";
            // 
            // over
            // 
            this.over.BackColor = System.Drawing.Color.Transparent;
            this.over.Image = global::WinFormsApp1.Properties.Resources.gameOver;
            this.over.Location = new System.Drawing.Point(597, 93);
            this.over.Margin = new System.Windows.Forms.Padding(5);
            this.over.Name = "over";
            this.over.Size = new System.Drawing.Size(297, 154);
            this.over.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.over.TabIndex = 29;
            this.over.TabStop = false;
            // 
            // Black
            // 
            this.Black.BackColor = System.Drawing.Color.Transparent;
            this.Black.Image = global::WinFormsApp1.Properties.Resources.black_horse;
            this.Black.Location = new System.Drawing.Point(651, 683);
            this.Black.Name = "Black";
            this.Black.Size = new System.Drawing.Size(76, 105);
            this.Black.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Black.TabIndex = 30;
            this.Black.TabStop = false;
            // 
            // Brown
            // 
            this.Brown.BackColor = System.Drawing.Color.Transparent;
            this.Brown.Image = global::WinFormsApp1.Properties.Resources.brown_horse;
            this.Brown.Location = new System.Drawing.Point(651, 681);
            this.Brown.Name = "Brown";
            this.Brown.Size = new System.Drawing.Size(76, 105);
            this.Brown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Brown.TabIndex = 31;
            this.Brown.TabStop = false;
            // 
            // Chicken
            // 
            this.Chicken.BackColor = System.Drawing.Color.Transparent;
            this.Chicken.Image = global::WinFormsApp1.Properties.Resources.chicken;
            this.Chicken.Location = new System.Drawing.Point(651, 683);
            this.Chicken.Name = "Chicken";
            this.Chicken.Size = new System.Drawing.Size(76, 103);
            this.Chicken.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Chicken.TabIndex = 32;
            this.Chicken.TabStop = false;
            // 
            // Parrot
            // 
            this.Parrot.BackColor = System.Drawing.Color.Transparent;
            this.Parrot.Image = global::WinFormsApp1.Properties.Resources.Parrot;
            this.Parrot.Location = new System.Drawing.Point(651, 683);
            this.Parrot.Name = "Parrot";
            this.Parrot.Size = new System.Drawing.Size(76, 103);
            this.Parrot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Parrot.TabIndex = 33;
            this.Parrot.TabStop = false;
            // 
            // Rainbow
            // 
            this.Rainbow.BackColor = System.Drawing.Color.Transparent;
            this.Rainbow.Image = global::WinFormsApp1.Properties.Resources.pony_rainbow;
            this.Rainbow.Location = new System.Drawing.Point(651, 681);
            this.Rainbow.Name = "Rainbow";
            this.Rainbow.Size = new System.Drawing.Size(76, 105);
            this.Rainbow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Rainbow.TabIndex = 35;
            this.Rainbow.TabStop = false;
            // 
            // Twilight
            // 
            this.Twilight.BackColor = System.Drawing.Color.Transparent;
            this.Twilight.Image = global::WinFormsApp1.Properties.Resources.pony_twilight;
            this.Twilight.Location = new System.Drawing.Point(651, 681);
            this.Twilight.Name = "Twilight";
            this.Twilight.Size = new System.Drawing.Size(76, 105);
            this.Twilight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Twilight.TabIndex = 36;
            this.Twilight.TabStop = false;
            // 
            // Ostrich
            // 
            this.Ostrich.BackColor = System.Drawing.Color.Transparent;
            this.Ostrich.Image = global::WinFormsApp1.Properties.Resources.ostrich;
            this.Ostrich.Location = new System.Drawing.Point(651, 681);
            this.Ostrich.Name = "Ostrich";
            this.Ostrich.Size = new System.Drawing.Size(76, 105);
            this.Ostrich.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ostrich.TabIndex = 37;
            this.Ostrich.TabStop = false;
            // 
            // Penguin
            // 
            this.Penguin.BackColor = System.Drawing.Color.Transparent;
            this.Penguin.Image = global::WinFormsApp1.Properties.Resources.penguin___2_;
            this.Penguin.Location = new System.Drawing.Point(651, 681);
            this.Penguin.Name = "Penguin";
            this.Penguin.Size = new System.Drawing.Size(76, 105);
            this.Penguin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Penguin.TabIndex = 38;
            this.Penguin.TabStop = false;
            // 
            // Lion
            // 
            this.Lion.BackColor = System.Drawing.Color.Transparent;
            this.Lion.Image = global::WinFormsApp1.Properties.Resources.Lion;
            this.Lion.Location = new System.Drawing.Point(651, 681);
            this.Lion.Name = "Lion";
            this.Lion.Size = new System.Drawing.Size(76, 105);
            this.Lion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Lion.TabIndex = 39;
            this.Lion.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = global::WinFormsApp1.Properties.Resources.bg_game;
            this.pictureBox2.Location = new System.Drawing.Point(-20, -18);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1558, 978);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 40;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(1014, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 30);
            this.label1.TabIndex = 41;
            this.label1.Text = "Speed:";
            // 
            // win
            // 
            this.win.BackColor = System.Drawing.Color.Transparent;
            this.win.Image = global::WinFormsApp1.Properties.Resources.you_won;
            this.win.Location = new System.Drawing.Point(597, 266);
            this.win.Margin = new System.Windows.Forms.Padding(5);
            this.win.Name = "win";
            this.win.Size = new System.Drawing.Size(297, 154);
            this.win.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.win.TabIndex = 42;
            this.win.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(816, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 30);
            this.label2.TabIndex = 43;
            this.label2.Text = "Max Speed:";
            // 
            // loss
            // 
            this.loss.BackColor = System.Drawing.Color.Transparent;
            this.loss.Image = global::WinFormsApp1.Properties.Resources.loss;
            this.loss.Location = new System.Drawing.Point(597, 266);
            this.loss.Margin = new System.Windows.Forms.Padding(5);
            this.loss.Name = "loss";
            this.loss.Size = new System.Drawing.Size(297, 154);
            this.loss.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loss.TabIndex = 44;
            this.loss.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(597, 425);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(303, 30);
            this.label3.TabIndex = 45;
            this.label3.Text = "Collect 50 hays to win";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1528, 843);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.loss);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.win);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_hit);
            this.Controls.Add(this.txt_food);
            this.Controls.Add(this.Lion);
            this.Controls.Add(this.Penguin);
            this.Controls.Add(this.Ostrich);
            this.Controls.Add(this.Twilight);
            this.Controls.Add(this.Rainbow);
            this.Controls.Add(this.Parrot);
            this.Controls.Add(this.Chicken);
            this.Controls.Add(this.Brown);
            this.Controls.Add(this.Black);
            this.Controls.Add(this.over);
            this.Controls.Add(this.bomb2);
            this.Controls.Add(this.bomb1);
            this.Controls.Add(this.food3);
            this.Controls.Add(this.food2);
            this.Controls.Add(this.food1);
            this.Controls.Add(this.pictureBox2);
            this.Enabled = false;
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Food Rush";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Game_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.food1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.food2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.food3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bomb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bomb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.over)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Black)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Brown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chicken)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Parrot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rainbow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Twilight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ostrich)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Penguin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.win)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loss)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox food1;
        private System.Windows.Forms.PictureBox food2;
        private System.Windows.Forms.PictureBox food3;
        private System.Windows.Forms.Label txt_food;
        private System.Windows.Forms.PictureBox bomb1;
        private System.Windows.Forms.PictureBox bomb2;
        private System.Windows.Forms.Label txt_hit;
        private System.Windows.Forms.PictureBox over;
        private System.Windows.Forms.PictureBox Black;
        private System.Windows.Forms.PictureBox Brown;
        private System.Windows.Forms.PictureBox Chicken;
        private System.Windows.Forms.PictureBox Parrot;
        private System.Windows.Forms.PictureBox Rainbow;
        private System.Windows.Forms.PictureBox Twilight;
        private System.Windows.Forms.PictureBox Ostrich;
        private System.Windows.Forms.PictureBox Penguin;
        private System.Windows.Forms.PictureBox Lion;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox win;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox loss;
        private System.Windows.Forms.Label label3;
    }
}

