namespace Patterns_Game
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
            this.pnlBoxContainer = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblLevel = new System.Windows.Forms.Label();
            this.btnRestartLevel = new System.Windows.Forms.Button();
            this.btnRestartGame = new System.Windows.Forms.Button();
            this.lblPlayTime = new System.Windows.Forms.Label();
            this.pnlRestartLvl = new System.Windows.Forms.Panel();
            this.pnlTime = new System.Windows.Forms.Panel();
            this.pnlSecond = new System.Windows.Forms.Panel();
            this.lblSecondPlayTime = new System.Windows.Forms.Label();
            this.pnlLevel = new System.Windows.Forms.Panel();
            this.pnlScore = new System.Windows.Forms.Panel();
            this.lblScore = new System.Windows.Forms.Label();
            this.pnlPoint = new System.Windows.Forms.Panel();
            this.lblPoints = new System.Windows.Forms.Label();
            this.pnlLevelCount = new System.Windows.Forms.Panel();
            this.lblLevelCount = new System.Windows.Forms.Label();
            this.lblLevelLimit = new System.Windows.Forms.Label();
            this.pnlLevelLimit = new System.Windows.Forms.Panel();
            this.pnlRestartGame = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlControlsContainer = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pnlInfoTime = new System.Windows.Forms.Panel();
            this.lblInfoTime = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.btnHint = new System.Windows.Forms.Button();
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.pnlBoxContainer.SuspendLayout();
            this.pnlRestartLvl.SuspendLayout();
            this.pnlTime.SuspendLayout();
            this.pnlSecond.SuspendLayout();
            this.pnlLevel.SuspendLayout();
            this.pnlScore.SuspendLayout();
            this.pnlPoint.SuspendLayout();
            this.pnlLevelCount.SuspendLayout();
            this.pnlLevelLimit.SuspendLayout();
            this.pnlRestartGame.SuspendLayout();
            this.pnlControlsContainer.SuspendLayout();
            this.pnlInfoTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 44);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(919, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 36);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.Location = new System.Drawing.Point(840, 4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(75, 36);
            this.btnMinimize.TabIndex = 0;
            this.btnMinimize.Text = "-";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // pnlBoxContainer
            // 
            this.pnlBoxContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlBoxContainer.Controls.Add(this.btnStart);
            this.pnlBoxContainer.Location = new System.Drawing.Point(105, 91);
            this.pnlBoxContainer.Name = "pnlBoxContainer";
            this.pnlBoxContainer.Size = new System.Drawing.Size(785, 425);
            this.pnlBoxContainer.TabIndex = 2;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(205)))));
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.Cyan;
            this.btnStart.Location = new System.Drawing.Point(66, 77);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(637, 289);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(40, 656);
            this.panel2.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(960, 44);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(40, 656);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(40, 676);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(920, 24);
            this.panel5.TabIndex = 4;
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.ForeColor = System.Drawing.Color.Red;
            this.lblLevel.Location = new System.Drawing.Point(11, 4);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(104, 39);
            this.lblLevel.TabIndex = 5;
            this.lblLevel.Text = "Level";
            // 
            // btnRestartLevel
            // 
            this.btnRestartLevel.BackColor = System.Drawing.Color.Transparent;
            this.btnRestartLevel.Enabled = false;
            this.btnRestartLevel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnRestartLevel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnRestartLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestartLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestartLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnRestartLevel.Location = new System.Drawing.Point(3, 5);
            this.btnRestartLevel.Name = "btnRestartLevel";
            this.btnRestartLevel.Size = new System.Drawing.Size(216, 41);
            this.btnRestartLevel.TabIndex = 6;
            this.btnRestartLevel.Text = "Restart Level";
            this.btnRestartLevel.UseVisualStyleBackColor = false;
            this.btnRestartLevel.Click += new System.EventHandler(this.btnRestartLevel_Click);
            // 
            // btnRestartGame
            // 
            this.btnRestartGame.BackColor = System.Drawing.Color.Transparent;
            this.btnRestartGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnRestartGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnRestartGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestartGame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnRestartGame.Location = new System.Drawing.Point(3, 4);
            this.btnRestartGame.Name = "btnRestartGame";
            this.btnRestartGame.Size = new System.Drawing.Size(216, 41);
            this.btnRestartGame.TabIndex = 7;
            this.btnRestartGame.Text = "Restart Game";
            this.btnRestartGame.UseVisualStyleBackColor = false;
            this.btnRestartGame.Click += new System.EventHandler(this.btnRestartGame_Click);
            // 
            // lblPlayTime
            // 
            this.lblPlayTime.AutoSize = true;
            this.lblPlayTime.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblPlayTime.Location = new System.Drawing.Point(9, 4);
            this.lblPlayTime.Name = "lblPlayTime";
            this.lblPlayTime.Size = new System.Drawing.Size(97, 39);
            this.lblPlayTime.TabIndex = 8;
            this.lblPlayTime.Text = "Time";
            // 
            // pnlRestartLvl
            // 
            this.pnlRestartLvl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(108)))), ((int)(((byte)(240)))));
            this.pnlRestartLvl.Controls.Add(this.btnRestartLevel);
            this.pnlRestartLvl.Location = new System.Drawing.Point(558, 3);
            this.pnlRestartLvl.Name = "pnlRestartLvl";
            this.pnlRestartLvl.Size = new System.Drawing.Size(224, 48);
            this.pnlRestartLvl.TabIndex = 3;
            // 
            // pnlTime
            // 
            this.pnlTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(255)))), ((int)(((byte)(190)))));
            this.pnlTime.Controls.Add(this.lblPlayTime);
            this.pnlTime.Location = new System.Drawing.Point(3, 3);
            this.pnlTime.Name = "pnlTime";
            this.pnlTime.Size = new System.Drawing.Size(200, 48);
            this.pnlTime.TabIndex = 6;
            // 
            // pnlSecond
            // 
            this.pnlSecond.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pnlSecond.Controls.Add(this.lblSecondPlayTime);
            this.pnlSecond.Location = new System.Drawing.Point(3, 53);
            this.pnlSecond.Name = "pnlSecond";
            this.pnlSecond.Size = new System.Drawing.Size(200, 48);
            this.pnlSecond.TabIndex = 9;
            // 
            // lblSecondPlayTime
            // 
            this.lblSecondPlayTime.AutoSize = true;
            this.lblSecondPlayTime.BackColor = System.Drawing.Color.Transparent;
            this.lblSecondPlayTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondPlayTime.ForeColor = System.Drawing.Color.Yellow;
            this.lblSecondPlayTime.Location = new System.Drawing.Point(27, 3);
            this.lblSecondPlayTime.Name = "lblSecondPlayTime";
            this.lblSecondPlayTime.Size = new System.Drawing.Size(29, 39);
            this.lblSecondPlayTime.TabIndex = 8;
            this.lblSecondPlayTime.Text = "-";
            // 
            // pnlLevel
            // 
            this.pnlLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(108)))), ((int)(((byte)(255)))));
            this.pnlLevel.Controls.Add(this.lblLevel);
            this.pnlLevel.Location = new System.Drawing.Point(430, 3);
            this.pnlLevel.Name = "pnlLevel";
            this.pnlLevel.Size = new System.Drawing.Size(126, 48);
            this.pnlLevel.TabIndex = 4;
            // 
            // pnlScore
            // 
            this.pnlScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(108)))), ((int)(((byte)(255)))));
            this.pnlScore.Controls.Add(this.lblScore);
            this.pnlScore.Location = new System.Drawing.Point(205, 3);
            this.pnlScore.Name = "pnlScore";
            this.pnlScore.Size = new System.Drawing.Size(223, 48);
            this.pnlScore.TabIndex = 10;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblScore.Location = new System.Drawing.Point(53, 4);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(111, 39);
            this.lblScore.TabIndex = 6;
            this.lblScore.Text = "Score";
            // 
            // pnlPoint
            // 
            this.pnlPoint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(108)))), ((int)(((byte)(255)))));
            this.pnlPoint.Controls.Add(this.lblPoints);
            this.pnlPoint.Location = new System.Drawing.Point(205, 53);
            this.pnlPoint.Name = "pnlPoint";
            this.pnlPoint.Size = new System.Drawing.Size(223, 48);
            this.pnlPoint.TabIndex = 11;
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.BackColor = System.Drawing.Color.Transparent;
            this.lblPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoints.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblPoints.Location = new System.Drawing.Point(91, 3);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(37, 39);
            this.lblPoints.TabIndex = 6;
            this.lblPoints.Text = "0";
            // 
            // pnlLevelCount
            // 
            this.pnlLevelCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(108)))), ((int)(((byte)(255)))));
            this.pnlLevelCount.Controls.Add(this.lblLevelCount);
            this.pnlLevelCount.Location = new System.Drawing.Point(430, 53);
            this.pnlLevelCount.Name = "pnlLevelCount";
            this.pnlLevelCount.Size = new System.Drawing.Size(60, 48);
            this.pnlLevelCount.TabIndex = 6;
            // 
            // lblLevelCount
            // 
            this.lblLevelCount.AutoSize = true;
            this.lblLevelCount.BackColor = System.Drawing.Color.Transparent;
            this.lblLevelCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevelCount.ForeColor = System.Drawing.Color.Red;
            this.lblLevelCount.Location = new System.Drawing.Point(12, 3);
            this.lblLevelCount.Name = "lblLevelCount";
            this.lblLevelCount.Size = new System.Drawing.Size(32, 36);
            this.lblLevelCount.TabIndex = 5;
            this.lblLevelCount.Text = "1";
            // 
            // lblLevelLimit
            // 
            this.lblLevelLimit.AutoSize = true;
            this.lblLevelLimit.BackColor = System.Drawing.Color.Transparent;
            this.lblLevelLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevelLimit.ForeColor = System.Drawing.Color.Red;
            this.lblLevelLimit.Location = new System.Drawing.Point(4, 3);
            this.lblLevelLimit.Name = "lblLevelLimit";
            this.lblLevelLimit.Size = new System.Drawing.Size(49, 36);
            this.lblLevelLimit.TabIndex = 6;
            this.lblLevelLimit.Text = "20";
            // 
            // pnlLevelLimit
            // 
            this.pnlLevelLimit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(108)))), ((int)(((byte)(255)))));
            this.pnlLevelLimit.Controls.Add(this.lblLevelLimit);
            this.pnlLevelLimit.Location = new System.Drawing.Point(496, 53);
            this.pnlLevelLimit.Name = "pnlLevelLimit";
            this.pnlLevelLimit.Size = new System.Drawing.Size(60, 48);
            this.pnlLevelLimit.TabIndex = 7;
            // 
            // pnlRestartGame
            // 
            this.pnlRestartGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(108)))), ((int)(((byte)(240)))));
            this.pnlRestartGame.Controls.Add(this.btnRestartGame);
            this.pnlRestartGame.Location = new System.Drawing.Point(558, 53);
            this.pnlRestartGame.Name = "pnlRestartGame";
            this.pnlRestartGame.Size = new System.Drawing.Size(224, 48);
            this.pnlRestartGame.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Red;
            this.panel3.Location = new System.Drawing.Point(487, 53);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 48);
            this.panel3.TabIndex = 0;
            // 
            // pnlControlsContainer
            // 
            this.pnlControlsContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlControlsContainer.Controls.Add(this.panel3);
            this.pnlControlsContainer.Controls.Add(this.pnlRestartLvl);
            this.pnlControlsContainer.Controls.Add(this.pnlRestartGame);
            this.pnlControlsContainer.Controls.Add(this.pnlTime);
            this.pnlControlsContainer.Controls.Add(this.pnlLevelLimit);
            this.pnlControlsContainer.Controls.Add(this.pnlSecond);
            this.pnlControlsContainer.Controls.Add(this.pnlLevelCount);
            this.pnlControlsContainer.Controls.Add(this.pnlLevel);
            this.pnlControlsContainer.Controls.Add(this.pnlPoint);
            this.pnlControlsContainer.Controls.Add(this.pnlScore);
            this.pnlControlsContainer.Location = new System.Drawing.Point(105, 519);
            this.pnlControlsContainer.Name = "pnlControlsContainer";
            this.pnlControlsContainer.Size = new System.Drawing.Size(785, 104);
            this.pnlControlsContainer.TabIndex = 12;
            // 
            // timer1
            // 
            this.timer1.Interval = 1500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // pnlInfoTime
            // 
            this.pnlInfoTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlInfoTime.Controls.Add(this.lblInfoTime);
            this.pnlInfoTime.Location = new System.Drawing.Point(105, 50);
            this.pnlInfoTime.Name = "pnlInfoTime";
            this.pnlInfoTime.Size = new System.Drawing.Size(785, 40);
            this.pnlInfoTime.TabIndex = 13;
            this.pnlInfoTime.Visible = false;
            // 
            // lblInfoTime
            // 
            this.lblInfoTime.AutoSize = true;
            this.lblInfoTime.BackColor = System.Drawing.Color.Transparent;
            this.lblInfoTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblInfoTime.Location = new System.Drawing.Point(267, 1);
            this.lblInfoTime.Name = "lblInfoTime";
            this.lblInfoTime.Size = new System.Drawing.Size(405, 39);
            this.lblInfoTime.TabIndex = 0;
            this.lblInfoTime.Text = "Memorize the pattern in ";
            // 
            // timer3
            // 
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // btnHint
            // 
            this.btnHint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnHint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHint.ForeColor = System.Drawing.Color.Yellow;
            this.btnHint.Location = new System.Drawing.Point(105, 627);
            this.btnHint.Name = "btnHint";
            this.btnHint.Size = new System.Drawing.Size(203, 41);
            this.btnHint.TabIndex = 14;
            this.btnHint.Text = "Hint";
            this.btnHint.UseVisualStyleBackColor = true;
            this.btnHint.Visible = false;
            this.btnHint.Click += new System.EventHandler(this.btnHint_Click);
            // 
            // timer4
            // 
            this.timer4.Interval = 1000;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.btnHint);
            this.Controls.Add(this.pnlInfoTime);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlBoxContainer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlControlsContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.pnlBoxContainer.ResumeLayout(false);
            this.pnlRestartLvl.ResumeLayout(false);
            this.pnlTime.ResumeLayout(false);
            this.pnlTime.PerformLayout();
            this.pnlSecond.ResumeLayout(false);
            this.pnlSecond.PerformLayout();
            this.pnlLevel.ResumeLayout(false);
            this.pnlLevel.PerformLayout();
            this.pnlScore.ResumeLayout(false);
            this.pnlScore.PerformLayout();
            this.pnlPoint.ResumeLayout(false);
            this.pnlPoint.PerformLayout();
            this.pnlLevelCount.ResumeLayout(false);
            this.pnlLevelCount.PerformLayout();
            this.pnlLevelLimit.ResumeLayout(false);
            this.pnlLevelLimit.PerformLayout();
            this.pnlRestartGame.ResumeLayout(false);
            this.pnlControlsContainer.ResumeLayout(false);
            this.pnlInfoTime.ResumeLayout(false);
            this.pnlInfoTime.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Panel pnlBoxContainer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Button btnRestartLevel;
        private System.Windows.Forms.Button btnRestartGame;
        private System.Windows.Forms.Label lblPlayTime;
        private System.Windows.Forms.Panel pnlRestartLvl;
        private System.Windows.Forms.Panel pnlTime;
        private System.Windows.Forms.Panel pnlSecond;
        private System.Windows.Forms.Label lblSecondPlayTime;
        private System.Windows.Forms.Panel pnlLevel;
        private System.Windows.Forms.Panel pnlScore;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Panel pnlPoint;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Panel pnlLevelCount;
        private System.Windows.Forms.Label lblLevelLimit;
        private System.Windows.Forms.Label lblLevelCount;
        private System.Windows.Forms.Panel pnlLevelLimit;
        private System.Windows.Forms.Panel pnlRestartGame;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlControlsContainer;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel pnlInfoTime;
        private System.Windows.Forms.Label lblInfoTime;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Button btnHint;
        private System.Windows.Forms.Timer timer4;
    }
}

