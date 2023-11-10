namespace Colorful_Words
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.pnlWordContainer = new System.Windows.Forms.Panel();
            this.pnlBoxColorContainer = new System.Windows.Forms.Panel();
            this.btnBoxColor5 = new System.Windows.Forms.Button();
            this.btnBoxColor4 = new System.Windows.Forms.Button();
            this.btnBoxColor3 = new System.Windows.Forms.Button();
            this.btnBoxColor2 = new System.Windows.Forms.Button();
            this.btnBoxColor1 = new System.Windows.Forms.Button();
            this.pnlLetterColorContainer = new System.Windows.Forms.Panel();
            this.btnLetterColor5 = new System.Windows.Forms.Button();
            this.btnLetterColor4 = new System.Windows.Forms.Button();
            this.btnLetterColor1 = new System.Windows.Forms.Button();
            this.btnLetterColor3 = new System.Windows.Forms.Button();
            this.btnLetterColor2 = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btnMenu = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnlBoxColorContainer.SuspendLayout();
            this.pnlLetterColorContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1079, 54);
            this.panel1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(84)))), ((int)(((byte)(64)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(999, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 45);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(84)))), ((int)(((byte)(64)))));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(920, 4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(75, 45);
            this.btnMinimize.TabIndex = 0;
            this.btnMinimize.Text = "-";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // pnlWordContainer
            // 
            this.pnlWordContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(74)))), ((int)(((byte)(64)))));
            this.pnlWordContainer.Location = new System.Drawing.Point(92, 114);
            this.pnlWordContainer.Name = "pnlWordContainer";
            this.pnlWordContainer.Size = new System.Drawing.Size(891, 216);
            this.pnlWordContainer.TabIndex = 2;
            // 
            // pnlBoxColorContainer
            // 
            this.pnlBoxColorContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(74)))), ((int)(((byte)(64)))));
            this.pnlBoxColorContainer.Controls.Add(this.btnBoxColor5);
            this.pnlBoxColorContainer.Controls.Add(this.btnBoxColor4);
            this.pnlBoxColorContainer.Controls.Add(this.btnBoxColor3);
            this.pnlBoxColorContainer.Controls.Add(this.btnBoxColor2);
            this.pnlBoxColorContainer.Controls.Add(this.btnBoxColor1);
            this.pnlBoxColorContainer.Enabled = false;
            this.pnlBoxColorContainer.Location = new System.Drawing.Point(92, 332);
            this.pnlBoxColorContainer.Name = "pnlBoxColorContainer";
            this.pnlBoxColorContainer.Size = new System.Drawing.Size(444, 80);
            this.pnlBoxColorContainer.TabIndex = 3;
            // 
            // btnBoxColor5
            // 
            this.btnBoxColor5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(74)))), ((int)(((byte)(64)))));
            this.btnBoxColor5.FlatAppearance.BorderSize = 0;
            this.btnBoxColor5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnBoxColor5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(74)))), ((int)(((byte)(80)))));
            this.btnBoxColor5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBoxColor5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoxColor5.Location = new System.Drawing.Point(354, 9);
            this.btnBoxColor5.Name = "btnBoxColor5";
            this.btnBoxColor5.Size = new System.Drawing.Size(80, 64);
            this.btnBoxColor5.TabIndex = 12;
            this.btnBoxColor5.Text = "BOX";
            this.btnBoxColor5.UseVisualStyleBackColor = false;
            this.btnBoxColor5.Click += new System.EventHandler(this.btnBoxColor5_Click);
            // 
            // btnBoxColor4
            // 
            this.btnBoxColor4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(74)))), ((int)(((byte)(64)))));
            this.btnBoxColor4.FlatAppearance.BorderSize = 0;
            this.btnBoxColor4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnBoxColor4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(74)))), ((int)(((byte)(80)))));
            this.btnBoxColor4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBoxColor4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoxColor4.Location = new System.Drawing.Point(268, 9);
            this.btnBoxColor4.Name = "btnBoxColor4";
            this.btnBoxColor4.Size = new System.Drawing.Size(80, 64);
            this.btnBoxColor4.TabIndex = 11;
            this.btnBoxColor4.Text = "BOX";
            this.btnBoxColor4.UseVisualStyleBackColor = false;
            this.btnBoxColor4.Click += new System.EventHandler(this.btnBoxColor4_Click);
            // 
            // btnBoxColor3
            // 
            this.btnBoxColor3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(74)))), ((int)(((byte)(64)))));
            this.btnBoxColor3.FlatAppearance.BorderSize = 0;
            this.btnBoxColor3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnBoxColor3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(74)))), ((int)(((byte)(80)))));
            this.btnBoxColor3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBoxColor3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoxColor3.Location = new System.Drawing.Point(181, 9);
            this.btnBoxColor3.Name = "btnBoxColor3";
            this.btnBoxColor3.Size = new System.Drawing.Size(80, 64);
            this.btnBoxColor3.TabIndex = 10;
            this.btnBoxColor3.Text = "BOX";
            this.btnBoxColor3.UseVisualStyleBackColor = false;
            this.btnBoxColor3.Click += new System.EventHandler(this.btnBoxColor3_Click);
            // 
            // btnBoxColor2
            // 
            this.btnBoxColor2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(74)))), ((int)(((byte)(64)))));
            this.btnBoxColor2.FlatAppearance.BorderSize = 0;
            this.btnBoxColor2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnBoxColor2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(74)))), ((int)(((byte)(80)))));
            this.btnBoxColor2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBoxColor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoxColor2.Location = new System.Drawing.Point(95, 9);
            this.btnBoxColor2.Name = "btnBoxColor2";
            this.btnBoxColor2.Size = new System.Drawing.Size(80, 64);
            this.btnBoxColor2.TabIndex = 9;
            this.btnBoxColor2.Text = "BOX";
            this.btnBoxColor2.UseVisualStyleBackColor = false;
            this.btnBoxColor2.Click += new System.EventHandler(this.btnBoxColor2_Click);
            // 
            // btnBoxColor1
            // 
            this.btnBoxColor1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(74)))), ((int)(((byte)(64)))));
            this.btnBoxColor1.FlatAppearance.BorderSize = 0;
            this.btnBoxColor1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnBoxColor1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(74)))), ((int)(((byte)(80)))));
            this.btnBoxColor1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBoxColor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoxColor1.Location = new System.Drawing.Point(9, 9);
            this.btnBoxColor1.Name = "btnBoxColor1";
            this.btnBoxColor1.Size = new System.Drawing.Size(80, 64);
            this.btnBoxColor1.TabIndex = 8;
            this.btnBoxColor1.Text = "BOX";
            this.btnBoxColor1.UseVisualStyleBackColor = false;
            this.btnBoxColor1.Click += new System.EventHandler(this.btnBoxColor1_Click);
            // 
            // pnlLetterColorContainer
            // 
            this.pnlLetterColorContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(74)))), ((int)(((byte)(64)))));
            this.pnlLetterColorContainer.Controls.Add(this.btnLetterColor5);
            this.pnlLetterColorContainer.Controls.Add(this.btnLetterColor4);
            this.pnlLetterColorContainer.Controls.Add(this.btnLetterColor1);
            this.pnlLetterColorContainer.Controls.Add(this.btnLetterColor3);
            this.pnlLetterColorContainer.Controls.Add(this.btnLetterColor2);
            this.pnlLetterColorContainer.Enabled = false;
            this.pnlLetterColorContainer.Location = new System.Drawing.Point(539, 332);
            this.pnlLetterColorContainer.Name = "pnlLetterColorContainer";
            this.pnlLetterColorContainer.Size = new System.Drawing.Size(444, 80);
            this.pnlLetterColorContainer.TabIndex = 4;
            // 
            // btnLetterColor5
            // 
            this.btnLetterColor5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(74)))), ((int)(((byte)(64)))));
            this.btnLetterColor5.FlatAppearance.BorderSize = 0;
            this.btnLetterColor5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnLetterColor5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(74)))), ((int)(((byte)(80)))));
            this.btnLetterColor5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLetterColor5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLetterColor5.Location = new System.Drawing.Point(355, 9);
            this.btnLetterColor5.Name = "btnLetterColor5";
            this.btnLetterColor5.Size = new System.Drawing.Size(80, 64);
            this.btnLetterColor5.TabIndex = 17;
            this.btnLetterColor5.Text = "LETTER";
            this.btnLetterColor5.UseVisualStyleBackColor = false;
            this.btnLetterColor5.Click += new System.EventHandler(this.btnLetterColor5_Click);
            // 
            // btnLetterColor4
            // 
            this.btnLetterColor4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(74)))), ((int)(((byte)(64)))));
            this.btnLetterColor4.FlatAppearance.BorderSize = 0;
            this.btnLetterColor4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnLetterColor4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(74)))), ((int)(((byte)(80)))));
            this.btnLetterColor4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLetterColor4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLetterColor4.Location = new System.Drawing.Point(269, 9);
            this.btnLetterColor4.Name = "btnLetterColor4";
            this.btnLetterColor4.Size = new System.Drawing.Size(80, 64);
            this.btnLetterColor4.TabIndex = 16;
            this.btnLetterColor4.Text = "LETTER";
            this.btnLetterColor4.UseVisualStyleBackColor = false;
            this.btnLetterColor4.Click += new System.EventHandler(this.btnLetterColor4_Click);
            // 
            // btnLetterColor1
            // 
            this.btnLetterColor1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(74)))), ((int)(((byte)(64)))));
            this.btnLetterColor1.FlatAppearance.BorderSize = 0;
            this.btnLetterColor1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnLetterColor1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(74)))), ((int)(((byte)(80)))));
            this.btnLetterColor1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLetterColor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLetterColor1.Location = new System.Drawing.Point(10, 9);
            this.btnLetterColor1.Name = "btnLetterColor1";
            this.btnLetterColor1.Size = new System.Drawing.Size(80, 64);
            this.btnLetterColor1.TabIndex = 13;
            this.btnLetterColor1.Text = "LETTER";
            this.btnLetterColor1.UseVisualStyleBackColor = false;
            this.btnLetterColor1.Click += new System.EventHandler(this.btnLetterColor1_Click);
            // 
            // btnLetterColor3
            // 
            this.btnLetterColor3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(74)))), ((int)(((byte)(64)))));
            this.btnLetterColor3.FlatAppearance.BorderSize = 0;
            this.btnLetterColor3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnLetterColor3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(74)))), ((int)(((byte)(80)))));
            this.btnLetterColor3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLetterColor3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLetterColor3.Location = new System.Drawing.Point(182, 9);
            this.btnLetterColor3.Name = "btnLetterColor3";
            this.btnLetterColor3.Size = new System.Drawing.Size(80, 64);
            this.btnLetterColor3.TabIndex = 15;
            this.btnLetterColor3.Text = "LETTER";
            this.btnLetterColor3.UseVisualStyleBackColor = false;
            this.btnLetterColor3.Click += new System.EventHandler(this.btnLetterColor3_Click);
            // 
            // btnLetterColor2
            // 
            this.btnLetterColor2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(74)))), ((int)(((byte)(64)))));
            this.btnLetterColor2.FlatAppearance.BorderSize = 0;
            this.btnLetterColor2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnLetterColor2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(74)))), ((int)(((byte)(80)))));
            this.btnLetterColor2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLetterColor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLetterColor2.Location = new System.Drawing.Point(96, 9);
            this.btnLetterColor2.Name = "btnLetterColor2";
            this.btnLetterColor2.Size = new System.Drawing.Size(80, 64);
            this.btnLetterColor2.TabIndex = 14;
            this.btnLetterColor2.Text = "LETTER";
            this.btnLetterColor2.UseVisualStyleBackColor = false;
            this.btnLetterColor2.Click += new System.EventHandler(this.btnLetterColor2_Click);
            // 
            // btnTest
            // 
            this.btnTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(84)))), ((int)(((byte)(64)))));
            this.btnTest.Enabled = false;
            this.btnTest.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnTest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnTest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTest.ForeColor = System.Drawing.Color.White;
            this.btnTest.Location = new System.Drawing.Point(92, 415);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(444, 58);
            this.btnTest.TabIndex = 5;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = false;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(84)))), ((int)(((byte)(64)))));
            this.btnRestart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnRestart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnRestart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(84)))), ((int)(((byte)(40)))));
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.ForeColor = System.Drawing.Color.White;
            this.btnRestart.Location = new System.Drawing.Point(539, 415);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(366, 58);
            this.btnRestart.TabIndex = 6;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(74)))), ((int)(((byte)(64)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(92, 73);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(891, 39);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "Guess the color of the boxes and the letters";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            // 
            // timer2
            // 
            this.timer2.Interval = 2500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(84)))), ((int)(((byte)(64)))));
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Location = new System.Drawing.Point(908, 415);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(75, 58);
            this.btnMenu.TabIndex = 8;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1078, 510);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.pnlLetterColorContainer);
            this.Controls.Add(this.pnlBoxColorContainer);
            this.Controls.Add(this.pnlWordContainer);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.pnlBoxColorContainer.ResumeLayout(false);
            this.pnlLetterColorContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Panel pnlWordContainer;
        private System.Windows.Forms.Panel pnlBoxColorContainer;
        private System.Windows.Forms.Panel pnlLetterColorContainer;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btnBoxColor1;
        private System.Windows.Forms.Button btnBoxColor5;
        private System.Windows.Forms.Button btnBoxColor4;
        private System.Windows.Forms.Button btnBoxColor3;
        private System.Windows.Forms.Button btnBoxColor2;
        private System.Windows.Forms.Button btnLetterColor5;
        private System.Windows.Forms.Button btnLetterColor4;
        private System.Windows.Forms.Button btnLetterColor1;
        private System.Windows.Forms.Button btnLetterColor3;
        private System.Windows.Forms.Button btnLetterColor2;
        private System.Windows.Forms.Button btnMenu;
    }
}

