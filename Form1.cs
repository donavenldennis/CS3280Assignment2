namespace Assignment2
{
    public partial class DieGuessingGame : Form
    {
        #region InisalizeDieGameClass

        public DieGuessingGame()
        {
            InitializeComponent();
        }
        #endregion

        #region GameValues
        /// <summary>
        /// these are global values for the game
        /// </summary>
        private int rollCount = 0;
        private int winCount = 0;
        private int lossCount = 0;
        private int[] rolls = { 0, 0, 0, 0, 0, 0 };
        private int[] guesses = { 0, 0, 0, 0, 0, 0 };
        private double[] percent = { 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 };
        private string[] DieFaces =
        {
            "die1.gif",
            "die2.gif",
            "die3.gif",
            "die4.gif",
            "die5.gif",
            "die6.gif"
        };
        private int guess;
        #endregion

        #region OnLoadForm1
        /// <summary>
        /// will run on load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateStats();
        }
        #endregion

        #region GuessEntry
        /// <summary>
        /// This method action check will activate every time that the user
        /// guess is changed. 
        /// 
        /// Id the guess entered is between 1 and 6 it will
        /// enable the roll button and display a green message informing the 
        /// user of the valid entry. it will also save the last entered valid
        /// value as the user guess.
        /// 
        /// I the entry is invalid it will display a message in red explaining 
        /// what is wrong with the entry. it will also disable the roll button 
        /// prevent the player from continuing until a valid entry is made.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserGuess_TextChanged(object sender, EventArgs e)
        {
            // try to capture an int entry
            try
            {
                // will run if valid entry
                if (int.Parse(UserGuess.Text) > 0 && int.Parse(UserGuess.Text) <= 6)
                {
                    guess = int.Parse(UserGuess.Text);
                    RollDie.Enabled = true;
                    Message2User.ForeColor = Color.Green;
                    Message2User.Text = "That is a Valid Guess";
                }
                // will run if value is int but too low
                else if (int.Parse(UserGuess.Text) <= 0)
                {
                    RollDie.Enabled = false;
                    Message2User.ForeColor = Color.Red;
                    Message2User.Text = "That guess is too low. Please enter a valid guess";
                }
                // will run if int but in all other cases
                else
                {
                    RollDie.Enabled = false;
                    Message2User.ForeColor = Color.Red;
                    Message2User.Text = "That guess is too high. Please enter a valid guess";
                }
            }
            //will run if not a int value
            catch
            {
                RollDie.Enabled = false;
                Message2User.ForeColor = Color.Red;
                Message2User.Text = "That is not a valid entry. Please enter a integer from 1-6";
            }

        }
        #endregion

        #region OnDieRoll
        /// <summary>
        /// This action method will handle the dice roll and updating game stats
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void RollDie_Click(object sender, EventArgs e)
        {
            RollDie.Enabled = false;
            UserGuess.Enabled = false;
            rollCount++; // increment number of rolls
            guess--; // decrement by on for comparison and array interaction
            int roll = ImageRoll();
            rolls[roll]++; // increment roll
            guesses[guess]++; // increment guess
            if (roll != guess) { lossCount++; }
            else { winCount++; }
            UpdatePercentage();
            UpdateStats();
        }
        #endregion

        #region ResetGame
        /// <summary>
        /// this method will reset all of the statistic of the game to default values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Reset_Click(object sender, EventArgs e)
        {
            RollDie.Enabled = false;
            rollCount = 0;
            winCount = 0;
            lossCount = 0;
            for (int i = 0; i < 6; i++)
            {
                rolls[i] = 0;
                guesses[i] = 0;
                percent[i] = 0.0;
            }
            UpdateStats();
        }
        #endregion

        #region UpdateStatsView
        /// <summary>
        /// This method will be used to update all stats visible to the
        /// user whenever needed whenever needed
        /// </summary>
        private void UpdateStats()
        {
            RollesCount.Text = rollCount.ToString();
            WinsCount.Text = winCount.ToString();
            LossCount.Text = lossCount.ToString();
            UserGuess.Text = "";
            Message2User.Text = "";
                RollStats.Text  = "FACE     FREQUENCY   PERCENT     TIMES GUESSED\n";
            for (int i = 0;i < 6;i++) 
            {
                RollStats.Text += " " + (i + 1) + "                     " + rolls[i] + "    " +
                    "                " + percent[i] + "%                     " + guesses[i] + "\n";
            }
            UserGuess.Enabled = true;
        }
        #endregion

        #region DiceImageRoll
        /// <summary>
        /// This method will call and return a random roll value and also 
        /// simulate the rolling of a die for the user.
        /// </summary>
        /// <returns></returns>
        private int ImageRoll()
        {
            RandomRoll randomRoll = new RandomRoll(); // generate new dice roll number from 0 to 5 (works better with arrays)
            int roll = randomRoll.GetFace(); // get die value
            for (int i = 0; i < 30; i++)
            {
                RandomRoll randomRolls = new RandomRoll(); // generate new dice roll number from 0 to 5 (works better with arrays)
                int j = randomRolls.GetFace(); 
                DieFace.Image = Image.FromFile(DieFaces[j]); // displays the die value that corresponds to j % 6 in dieFaces array
                DieFace.Refresh(); // refresh image property
                Thread.Sleep(5 + i * 5); //delays for longer times on each iteration
            }
            DieFace.Image = Image.FromFile(DieFaces[roll]); // displays the die value that corresponds to i % 6 in dieFaces array
            DieFace.Refresh(); // refresh image property
            return roll; // returns rolled value
        }
        #endregion

        #region UpdatePercentage
        /// <summary>
        /// will recalculate and store the values of all percentage stats
        /// </summary>
        private void UpdatePercentage()
        {
            for (int i = 0; i < 6; i++)
            {
                // Will re-access the value of each percentage based on new count
                // and store as a double to the rounded to the nearest 100th
                percent[i] = Math.Round(Convert.ToDouble(rolls[i]) * 100 / Convert.ToDouble(rollCount), 2) ;
            }
        }
        #endregion
    }
}
