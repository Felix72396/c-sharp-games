namespace Mine_Seeker
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
            this.pnlTabBar = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.pnlAside = new System.Windows.Forms.Panel();
            this.txtMinesA = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.btnMark = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.pnlRight2 = new System.Windows.Forms.Panel();
            this.pnlLevel = new System.Windows.Forms.Panel();
            this.rdBIntermediate = new System.Windows.Forms.RadioButton();
            this.rdBAdvance = new System.Windows.Forms.RadioButton();
            this.rdBBeginner = new System.Windows.Forms.RadioButton();
            this.pnlTop2 = new System.Windows.Forms.Panel();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlTabBar.SuspendLayout();
            this.pnlAside.SuspendLayout();
            this.pnlLevel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTabBar
            // 
            this.pnlTabBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(142)))), ((int)(((byte)(220)))));
            this.pnlTabBar.Controls.Add(this.btnClose);
            this.pnlTabBar.Controls.Add(this.btnMinimize);
            this.pnlTabBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTabBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTabBar.Name = "pnlTabBar";
            this.pnlTabBar.Size = new System.Drawing.Size(612, 50);
            this.pnlTabBar.TabIndex = 0;
            this.pnlTabBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTabBar_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(120)))), ((int)(((byte)(220)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnClose.Location = new System.Drawing.Point(535, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(72, 44);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "x";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(120)))), ((int)(((byte)(220)))));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnMinimize.Location = new System.Drawing.Point(461, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(72, 44);
            this.btnMinimize.TabIndex = 0;
            this.btnMinimize.Text = "-";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            this.btnMinimize.Enter += new System.EventHandler(this.btnMinimize_Enter);
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(182)))), ((int)(((byte)(220)))));
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 50);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(5, 479);
            this.pnlLeft.TabIndex = 22;
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(182)))), ((int)(((byte)(220)))));
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(607, 50);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(5, 479);
            this.pnlRight.TabIndex = 23;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(182)))), ((int)(((byte)(220)))));
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(5, 50);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(602, 5);
            this.pnlTop.TabIndex = 24;
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(182)))), ((int)(((byte)(220)))));
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(5, 524);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(602, 5);
            this.pnlBottom.TabIndex = 25;
            // 
            // pnlAside
            // 
            this.pnlAside.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(142)))), ((int)(((byte)(220)))));
            this.pnlAside.Controls.Add(this.txtMinesA);
            this.pnlAside.Controls.Add(this.txtTime);
            this.pnlAside.Controls.Add(this.btnMark);
            this.pnlAside.Controls.Add(this.btnRestart);
            this.pnlAside.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlAside.Location = new System.Drawing.Point(463, 55);
            this.pnlAside.Name = "pnlAside";
            this.pnlAside.Size = new System.Drawing.Size(144, 469);
            this.pnlAside.TabIndex = 26;
            // 
            // txtMinesA
            // 
            this.txtMinesA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(142)))), ((int)(((byte)(220)))));
            this.txtMinesA.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinesA.ForeColor = System.Drawing.Color.White;
            this.txtMinesA.Location = new System.Drawing.Point(5, 256);
            this.txtMinesA.Multiline = true;
            this.txtMinesA.Name = "txtMinesA";
            this.txtMinesA.Size = new System.Drawing.Size(135, 51);
            this.txtMinesA.TabIndex = 3;
            this.txtMinesA.Text = "99";
            this.txtMinesA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTime
            // 
            this.txtTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(142)))), ((int)(((byte)(220)))));
            this.txtTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime.ForeColor = System.Drawing.Color.White;
            this.txtTime.Location = new System.Drawing.Point(6, 199);
            this.txtTime.Multiline = true;
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(135, 51);
            this.txtTime.TabIndex = 2;
            this.txtTime.Text = "000";
            this.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnMark
            // 
            this.btnMark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMark.ForeColor = System.Drawing.Color.White;
            this.btnMark.Location = new System.Drawing.Point(5, 76);
            this.btnMark.Name = "btnMark";
            this.btnMark.Size = new System.Drawing.Size(135, 66);
            this.btnMark.TabIndex = 1;
            this.btnMark.Text = "Mark";
            this.btnMark.UseVisualStyleBackColor = true;
            // 
            // btnRestart
            // 
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.ForeColor = System.Drawing.Color.White;
            this.btnRestart.Location = new System.Drawing.Point(5, 4);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(135, 66);
            this.btnRestart.TabIndex = 0;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // pnlRight2
            // 
            this.pnlRight2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(182)))), ((int)(((byte)(220)))));
            this.pnlRight2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight2.Location = new System.Drawing.Point(458, 55);
            this.pnlRight2.Name = "pnlRight2";
            this.pnlRight2.Size = new System.Drawing.Size(5, 469);
            this.pnlRight2.TabIndex = 28;
            // 
            // pnlLevel
            // 
            this.pnlLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(142)))), ((int)(((byte)(220)))));
            this.pnlLevel.Controls.Add(this.rdBIntermediate);
            this.pnlLevel.Controls.Add(this.rdBAdvance);
            this.pnlLevel.Controls.Add(this.rdBBeginner);
            this.pnlLevel.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLevel.Location = new System.Drawing.Point(5, 55);
            this.pnlLevel.Name = "pnlLevel";
            this.pnlLevel.Size = new System.Drawing.Size(453, 47);
            this.pnlLevel.TabIndex = 29;
            // 
            // rdBIntermediate
            // 
            this.rdBIntermediate.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdBIntermediate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(142)))), ((int)(((byte)(220)))));
            this.rdBIntermediate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdBIntermediate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBIntermediate.ForeColor = System.Drawing.Color.White;
            this.rdBIntermediate.Location = new System.Drawing.Point(153, 4);
            this.rdBIntermediate.Name = "rdBIntermediate";
            this.rdBIntermediate.Size = new System.Drawing.Size(145, 40);
            this.rdBIntermediate.TabIndex = 17;
            this.rdBIntermediate.Text = "Intermediate";
            this.rdBIntermediate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdBIntermediate.UseVisualStyleBackColor = false;
            this.rdBIntermediate.CheckedChanged += new System.EventHandler(this.rdBIntermediate_CheckedChanged);
            // 
            // rdBAdvance
            // 
            this.rdBAdvance.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdBAdvance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(142)))), ((int)(((byte)(220)))));
            this.rdBAdvance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdBAdvance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBAdvance.ForeColor = System.Drawing.Color.White;
            this.rdBAdvance.Location = new System.Drawing.Point(302, 4);
            this.rdBAdvance.Name = "rdBAdvance";
            this.rdBAdvance.Size = new System.Drawing.Size(146, 40);
            this.rdBAdvance.TabIndex = 18;
            this.rdBAdvance.Text = "Advance";
            this.rdBAdvance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdBAdvance.UseVisualStyleBackColor = false;
            this.rdBAdvance.CheckedChanged += new System.EventHandler(this.rdBAdvance_CheckedChanged);
            // 
            // rdBBeginner
            // 
            this.rdBBeginner.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdBBeginner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(142)))), ((int)(((byte)(220)))));
            this.rdBBeginner.Checked = true;
            this.rdBBeginner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdBBeginner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBBeginner.ForeColor = System.Drawing.Color.White;
            this.rdBBeginner.Location = new System.Drawing.Point(4, 4);
            this.rdBBeginner.Name = "rdBBeginner";
            this.rdBBeginner.Size = new System.Drawing.Size(146, 40);
            this.rdBBeginner.TabIndex = 16;
            this.rdBBeginner.TabStop = true;
            this.rdBBeginner.Text = "Beginner";
            this.rdBBeginner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdBBeginner.UseVisualStyleBackColor = false;
            this.rdBBeginner.CheckedChanged += new System.EventHandler(this.rdBBeginner_CheckedChanged);
            // 
            // pnlTop2
            // 
            this.pnlTop2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(182)))), ((int)(((byte)(220)))));
            this.pnlTop2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop2.Location = new System.Drawing.Point(5, 102);
            this.pnlTop2.Name = "pnlTop2";
            this.pnlTop2.Size = new System.Drawing.Size(453, 5);
            this.pnlTop2.TabIndex = 30;
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(5, 107);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(453, 417);
            this.pnlContainer.TabIndex = 22;
            this.pnlContainer.Click += new System.EventHandler(this.pnlContainer_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(612, 529);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.pnlTop2);
            this.Controls.Add(this.pnlLevel);
            this.Controls.Add(this.pnlRight2);
            this.Controls.Add(this.pnlAside);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlTabBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlTabBar.ResumeLayout(false);
            this.pnlAside.ResumeLayout(false);
            this.pnlAside.PerformLayout();
            this.pnlLevel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTabBar;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel pnlAside;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Panel pnlRight2;
        private System.Windows.Forms.Panel pnlLevel;
        private System.Windows.Forms.RadioButton rdBIntermediate;
        private System.Windows.Forms.RadioButton rdBAdvance;
        private System.Windows.Forms.RadioButton rdBBeginner;
        private System.Windows.Forms.Panel pnlTop2;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.TextBox txtMinesA;
        private System.Windows.Forms.TextBox txtTime;
        internal System.Windows.Forms.Timer timer1;
        internal System.Windows.Forms.Button btnMark;
    }
}

