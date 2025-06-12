namespace boardingCostCalculator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tbSpecies = new TextBox();
            tbPet = new TextBox();
            tbLength = new TextBox();
            btnCalc = new Button();
            lblCostTitle = new Label();
            lblLength = new Label();
            lblPet = new Label();
            lblSpecies = new Label();
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            lblP2 = new Label();
            lblP1 = new Label();
            lblOutput = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tbSpecies
            // 
            tbSpecies.Location = new Point(319, 250);
            tbSpecies.Name = "tbSpecies";
            tbSpecies.Size = new Size(100, 23);
            tbSpecies.TabIndex = 0;
            // 
            // tbPet
            // 
            tbPet.Location = new Point(319, 294);
            tbPet.Name = "tbPet";
            tbPet.Size = new Size(100, 23);
            tbPet.TabIndex = 1;
            tbPet.TextChanged += tbPet_TextChanged;
            // 
            // tbLength
            // 
            tbLength.Location = new Point(319, 347);
            tbLength.Name = "tbLength";
            tbLength.Size = new Size(100, 23);
            tbLength.TabIndex = 2;
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(486, 347);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(100, 23);
            btnCalc.TabIndex = 3;
            btnCalc.Text = "Calculate";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // lblCostTitle
            // 
            lblCostTitle.AutoSize = true;
            lblCostTitle.ForeColor = Color.Red;
            lblCostTitle.Location = new Point(259, 394);
            lblCostTitle.Name = "lblCostTitle";
            lblCostTitle.Size = new Size(63, 15);
            lblCostTitle.TabIndex = 4;
            lblCostTitle.Text = "Total Cost:";
            // 
            // lblLength
            // 
            lblLength.AutoSize = true;
            lblLength.ForeColor = Color.Red;
            lblLength.Location = new Point(236, 355);
            lblLength.Name = "lblLength";
            lblLength.Size = new Size(72, 15);
            lblLength.TabIndex = 5;
            lblLength.Text = "Stay Length:";
            // 
            // lblPet
            // 
            lblPet.AutoSize = true;
            lblPet.ForeColor = Color.Red;
            lblPet.Location = new Point(236, 302);
            lblPet.Name = "lblPet";
            lblPet.Size = new Size(68, 15);
            lblPet.TabIndex = 6;
            lblPet.Text = "Pet Weight:";
            // 
            // lblSpecies
            // 
            lblSpecies.AutoSize = true;
            lblSpecies.ForeColor = Color.Red;
            lblSpecies.Location = new Point(248, 253);
            lblSpecies.Name = "lblSpecies";
            lblSpecies.Size = new Size(49, 15);
            lblSpecies.TabIndex = 7;
            lblSpecies.Text = "Species:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(134, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(285, 104);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.ForeColor = Color.DeepSkyBlue;
            lblTitle.Location = new Point(535, 65);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(139, 15);
            lblTitle.TabIndex = 9;
            lblTitle.Text = "Boarding Cost Calculator";
            // 
            // lblP2
            // 
            lblP2.AutoSize = true;
            lblP2.Location = new Point(104, 185);
            lblP2.Name = "lblP2";
            lblP2.Size = new Size(389, 15);
            lblP2.TabIndex = 10;
            lblP2.Text = "just enter a few simple bits of information and the cost will be calculated";
            // 
            // lblP1
            // 
            lblP1.Location = new Point(104, 132);
            lblP1.Name = "lblP1";
            lblP1.Size = new Size(594, 53);
            lblP1.TabIndex = 11;
            lblP1.Text = "The boarding cost calculator allows you to quickly and easily see the applicable cost of using the animal boarding services of Ticked Off Vet.";
            // 
            // lblOutput
            // 
            lblOutput.AutoSize = true;
            lblOutput.Location = new Point(342, 394);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(13, 15);
            lblOutput.TabIndex = 12;
            lblOutput.Text = "a";
            lblOutput.Click += lblOutput_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblOutput);
            Controls.Add(lblP1);
            Controls.Add(lblP2);
            Controls.Add(lblTitle);
            Controls.Add(pictureBox1);
            Controls.Add(lblSpecies);
            Controls.Add(lblPet);
            Controls.Add(lblLength);
            Controls.Add(lblCostTitle);
            Controls.Add(btnCalc);
            Controls.Add(tbLength);
            Controls.Add(tbPet);
            Controls.Add(tbSpecies);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbSpecies;
        private TextBox tbPet;
        private TextBox tbLength;
        private Button btnCalc;
        private Label lblCostTitle;
        private Label lblLength;
        private Label lblPet;
        private Label lblSpecies;
        private PictureBox pictureBox1;
        private Label lblTitle;
        private Label lblP2;
        private Label lblP1;
        private Label lblOutput;
    }
}
