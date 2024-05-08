namespace Assignment2
{
    partial class DieGuessingGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DieGuessingGame));
            WindowTitle = new Label();
            RollesLabel = new Label();
            LossLabel = new Label();
            WinsLabel = new Label();
            RollesCount = new Label();
            WinsCount = new Label();
            LossCount = new Label();
            RollDie = new Button();
            Reset = new Button();
            DieFace = new PictureBox();
            GuessLabel = new Label();
            GuessInstruction = new Label();
            UserGuess = new TextBox();
            Message2User = new Label();
            RollStats = new Label();
            ((System.ComponentModel.ISupportInitialize)DieFace).BeginInit();
            SuspendLayout();
            // 
            // WindowTitle
            // 
            resources.ApplyResources(WindowTitle, "WindowTitle");
            WindowTitle.BackColor = Color.Transparent;
            WindowTitle.Name = "WindowTitle";
            // 
            // RollesLabel
            // 
            resources.ApplyResources(RollesLabel, "RollesLabel");
            RollesLabel.BackColor = Color.Transparent;
            RollesLabel.Name = "RollesLabel";
            // 
            // LossLabel
            // 
            resources.ApplyResources(LossLabel, "LossLabel");
            LossLabel.BackColor = Color.Transparent;
            LossLabel.ForeColor = Color.Red;
            LossLabel.Name = "LossLabel";
            // 
            // WinsLabel
            // 
            resources.ApplyResources(WinsLabel, "WinsLabel");
            WinsLabel.BackColor = Color.Transparent;
            WinsLabel.ForeColor = Color.Lime;
            WinsLabel.Name = "WinsLabel";
            // 
            // RollesCount
            // 
            resources.ApplyResources(RollesCount, "RollesCount");
            RollesCount.BackColor = Color.Transparent;
            RollesCount.Name = "RollesCount";
            // 
            // WinsCount
            // 
            resources.ApplyResources(WinsCount, "WinsCount");
            WinsCount.BackColor = Color.Transparent;
            WinsCount.ForeColor = Color.Lime;
            WinsCount.Name = "WinsCount";
            // 
            // LossCount
            // 
            resources.ApplyResources(LossCount, "LossCount");
            LossCount.BackColor = Color.Transparent;
            LossCount.ForeColor = Color.Red;
            LossCount.Name = "LossCount";
            // 
            // RollDie
            // 
            resources.ApplyResources(RollDie, "RollDie");
            RollDie.BackColor = Color.White;
            RollDie.ForeColor = Color.Black;
            RollDie.Name = "RollDie";
            RollDie.UseVisualStyleBackColor = false;
            RollDie.Click += RollDie_Click;
            // 
            // Reset
            // 
            resources.ApplyResources(Reset, "Reset");
            Reset.BackColor = Color.White;
            Reset.ForeColor = Color.Black;
            Reset.Name = "Reset";
            Reset.UseVisualStyleBackColor = false;
            Reset.Click += Reset_Click;
            // 
            // DieFace
            // 
            resources.ApplyResources(DieFace, "DieFace");
            DieFace.BackColor = Color.Transparent;
            DieFace.Name = "DieFace";
            DieFace.TabStop = false;
            // 
            // GuessLabel
            // 
            resources.ApplyResources(GuessLabel, "GuessLabel");
            GuessLabel.BackColor = Color.Transparent;
            GuessLabel.Name = "GuessLabel";
            // 
            // GuessInstruction
            // 
            resources.ApplyResources(GuessInstruction, "GuessInstruction");
            GuessInstruction.BackColor = Color.Transparent;
            GuessInstruction.Name = "GuessInstruction";
            // 
            // UserGuess
            // 
            resources.ApplyResources(UserGuess, "UserGuess");
            UserGuess.Name = "UserGuess";
            UserGuess.TextChanged += UserGuess_TextChanged;
            // 
            // Message2User
            // 
            resources.ApplyResources(Message2User, "Message2User");
            Message2User.BackColor = Color.Transparent;
            Message2User.ForeColor = Color.White;
            Message2User.Name = "Message2User";
            // 
            // RollStats
            // 
            resources.ApplyResources(RollStats, "RollStats");
            RollStats.BackColor = Color.Transparent;
            RollStats.Name = "RollStats";
            // 
            // DieGuessingGame
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            Controls.Add(RollStats);
            Controls.Add(Message2User);
            Controls.Add(UserGuess);
            Controls.Add(GuessInstruction);
            Controls.Add(GuessLabel);
            Controls.Add(DieFace);
            Controls.Add(Reset);
            Controls.Add(RollDie);
            Controls.Add(LossCount);
            Controls.Add(WinsCount);
            Controls.Add(RollesCount);
            Controls.Add(WinsLabel);
            Controls.Add(LossLabel);
            Controls.Add(RollesLabel);
            Controls.Add(WindowTitle);
            ForeColor = SystemColors.Window;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "DieGuessingGame";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)DieFace).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label WindowTitle;
        private Label RollesLabel;
        private Label LossLabel;
        private Label WinsLabel;
        private Label RollesCount;
        private Label WinsCount;
        private Label LossCount;
        private Button RollDie;
        private Button Reset;
        private PictureBox DieFace;
        private Label GuessLabel;
        private Label GuessInstruction;
        private TextBox UserGuess;
        private Label Message2User;
        private Label RollStats;
    }
}
