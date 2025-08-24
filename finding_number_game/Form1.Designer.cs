namespace finding_number_game
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
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbGameSetup = new System.Windows.Forms.GroupBox();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.nudAttempts = new System.Windows.Forms.NumericUpDown();
            this.lblAttempts = new System.Windows.Forms.Label();
            this.txtSecretNumber = new System.Windows.Forms.TextBox();
            this.lblSecretNumber = new System.Windows.Forms.Label();
            this.gbGamePlay = new System.Windows.Forms.GroupBox();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblTimeLeft = new System.Windows.Forms.Label();
            this.btnGuess = new System.Windows.Forms.Button();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.lblGuess = new System.Windows.Forms.Label();
            this.lblAttemptsLeft = new System.Windows.Forms.Label();
            this.lblAttemptsLeftValue = new System.Windows.Forms.Label();
            this.lstHistory = new System.Windows.Forms.ListBox();
            this.lblHistory = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnShowScores = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.gbGameSetup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAttempts)).BeginInit();
            this.gbGamePlay.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(200, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Sayı Bulma Oyunu";
            // 
            // gbGameSetup
            // 
            this.gbGameSetup.Controls.Add(this.btnStartGame);
            this.gbGameSetup.Controls.Add(this.nudAttempts);
            this.gbGameSetup.Controls.Add(this.lblAttempts);
            this.gbGameSetup.Controls.Add(this.txtSecretNumber);
            this.gbGameSetup.Controls.Add(this.lblSecretNumber);
            this.gbGameSetup.Location = new System.Drawing.Point(12, 50);
            this.gbGameSetup.Name = "gbGameSetup";
            this.gbGameSetup.Size = new System.Drawing.Size(300, 150);
            this.gbGameSetup.TabIndex = 1;
            this.gbGameSetup.TabStop = false;
            this.gbGameSetup.Text = "Oyun Ayarları";
            // 
            // btnStartGame
            // 
            this.btnStartGame.Location = new System.Drawing.Point(100, 110);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(100, 30);
            this.btnStartGame.TabIndex = 4;
            this.btnStartGame.Text = "Oyunu Başlat";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // nudAttempts
            // 
            this.nudAttempts.Location = new System.Drawing.Point(150, 70);
            this.nudAttempts.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudAttempts.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAttempts.Name = "nudAttempts";
            this.nudAttempts.Size = new System.Drawing.Size(100, 23);
            this.nudAttempts.TabIndex = 3;
            this.nudAttempts.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lblAttempts
            // 
            this.lblAttempts.AutoSize = true;
            this.lblAttempts.Location = new System.Drawing.Point(20, 72);
            this.lblAttempts.Name = "lblAttempts";
            this.lblAttempts.Size = new System.Drawing.Size(124, 15);
            this.lblAttempts.TabIndex = 2;
            this.lblAttempts.Text = "Maksimum Hak Sayısı:";
            // 
            // txtSecretNumber
            // 
            this.txtSecretNumber.Location = new System.Drawing.Point(150, 30);
            this.txtSecretNumber.MaxLength = 4;
            this.txtSecretNumber.Name = "txtSecretNumber";
            this.txtSecretNumber.PasswordChar = '*';
            this.txtSecretNumber.Size = new System.Drawing.Size(100, 23);
            this.txtSecretNumber.TabIndex = 1;
            // 
            // lblSecretNumber
            // 
            this.lblSecretNumber.AutoSize = true;
            this.lblSecretNumber.Location = new System.Drawing.Point(20, 33);
            this.lblSecretNumber.Name = "lblSecretNumber";
            this.lblSecretNumber.Size = new System.Drawing.Size(124, 15);
            this.lblSecretNumber.TabIndex = 0;
            this.lblSecretNumber.Text = "Gizli Sayı (4 haneli):";
            // 
            // gbGamePlay
            // 
            this.gbGamePlay.Controls.Add(this.lblTimer);
            this.gbGamePlay.Controls.Add(this.lblTimeLeft);
            this.gbGamePlay.Controls.Add(this.btnGuess);
            this.gbGamePlay.Controls.Add(this.txtGuess);
            this.gbGamePlay.Controls.Add(this.lblGuess);
            this.gbGamePlay.Controls.Add(this.lblAttemptsLeft);
            this.gbGamePlay.Controls.Add(this.lblAttemptsLeftValue);
            this.gbGamePlay.Enabled = false;
            this.gbGamePlay.Location = new System.Drawing.Point(12, 220);
            this.gbGamePlay.Name = "gbGamePlay";
            this.gbGamePlay.Size = new System.Drawing.Size(300, 150);
            this.gbGamePlay.TabIndex = 2;
            this.gbGamePlay.TabStop = false;
            this.gbGamePlay.Text = "Oyun";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTimer.Location = new System.Drawing.Point(150, 100);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(30, 21);
            this.lblTimer.TabIndex = 6;
            this.lblTimer.Text = "60";
            // 
            // lblTimeLeft
            // 
            this.lblTimeLeft.AutoSize = true;
            this.lblTimeLeft.Location = new System.Drawing.Point(20, 105);
            this.lblTimeLeft.Name = "lblTimeLeft";
            this.lblTimeLeft.Size = new System.Drawing.Size(124, 15);
            this.lblTimeLeft.TabIndex = 5;
            this.lblTimeLeft.Text = "Kalan Süre (saniye):";
            // 
            // btnGuess
            // 
            this.btnGuess.Location = new System.Drawing.Point(100, 70);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(100, 30);
            this.btnGuess.TabIndex = 4;
            this.btnGuess.Text = "Tahmin Et";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // txtGuess
            // 
            this.txtGuess.Location = new System.Drawing.Point(150, 30);
            this.txtGuess.MaxLength = 4;
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(100, 23);
            this.txtGuess.TabIndex = 3;
            this.txtGuess.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGuess_KeyPress);
            // 
            // lblGuess
            // 
            this.lblGuess.AutoSize = true;
            this.lblGuess.Location = new System.Drawing.Point(20, 33);
            this.lblGuess.Name = "lblGuess";
            this.lblGuess.Size = new System.Drawing.Size(124, 15);
            this.lblGuess.TabIndex = 2;
            this.lblGuess.Text = "Tahmininiz (4 haneli):";
            // 
            // lblAttemptsLeft
            // 
            this.lblAttemptsLeft.AutoSize = true;
            this.lblAttemptsLeft.Location = new System.Drawing.Point(20, 70);
            this.lblAttemptsLeft.Name = "lblAttemptsLeft";
            this.lblAttemptsLeft.Size = new System.Drawing.Size(74, 15);
            this.lblAttemptsLeft.TabIndex = 1;
            this.lblAttemptsLeft.Text = "Kalan Hak:";
            // 
            // lblAttemptsLeftValue
            // 
            this.lblAttemptsLeftValue.AutoSize = true;
            this.lblAttemptsLeftValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAttemptsLeftValue.Location = new System.Drawing.Point(100, 68);
            this.lblAttemptsLeftValue.Name = "lblAttemptsLeftValue";
            this.lblAttemptsLeftValue.Size = new System.Drawing.Size(19, 21);
            this.lblAttemptsLeftValue.TabIndex = 0;
            this.lblAttemptsLeftValue.Text = "0";
            // 
            // lstHistory
            // 
            this.lstHistory.FormattingEnabled = true;
            this.lstHistory.ItemHeight = 15;
            this.lstHistory.Location = new System.Drawing.Point(330, 50);
            this.lstHistory.Name = "lstHistory";
            this.lstHistory.Size = new System.Drawing.Size(300, 319);
            this.lstHistory.TabIndex = 3;
            // 
            // lblHistory
            // 
            this.lblHistory.AutoSize = true;
            this.lblHistory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHistory.Location = new System.Drawing.Point(330, 20);
            this.lblHistory.Name = "lblHistory";
            this.lblHistory.Size = new System.Drawing.Size(100, 21);
            this.lblHistory.TabIndex = 4;
            this.lblHistory.Text = "Tahmin Geçmişi";
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(12, 390);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(100, 30);
            this.btnNewGame.TabIndex = 5;
            this.btnNewGame.Text = "Yeni Oyun";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnShowScores
            // 
            this.btnShowScores.Location = new System.Drawing.Point(130, 390);
            this.btnShowScores.Name = "btnShowScores";
            this.btnShowScores.Size = new System.Drawing.Size(100, 30);
            this.btnShowScores.TabIndex = 6;
            this.btnShowScores.Text = "Skor Listesi";
            this.btnShowScores.UseVisualStyleBackColor = true;
            this.btnShowScores.Click += new System.EventHandler(this.btnShowScores_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 450);
            this.Controls.Add(this.btnShowScores);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.lblHistory);
            this.Controls.Add(this.lstHistory);
            this.Controls.Add(this.gbGamePlay);
            this.Controls.Add(this.gbGameSetup);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Sayı Bulma Oyunu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbGameSetup.ResumeLayout(false);
            this.gbGameSetup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAttempts)).EndInit();
            this.gbGamePlay.ResumeLayout(false);
            this.gbGamePlay.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitle;
        private GroupBox gbGameSetup;
        private Button btnStartGame;
        private NumericUpDown nudAttempts;
        private Label lblAttempts;
        private TextBox txtSecretNumber;
        private Label lblSecretNumber;
        private GroupBox gbGamePlay;
        private Label lblTimer;
        private Label lblTimeLeft;
        private Button btnGuess;
        private TextBox txtGuess;
        private Label lblGuess;
        private Label lblAttemptsLeft;
        private Label lblAttemptsLeftValue;
        private ListBox lstHistory;
        private Label lblHistory;
        private Button btnNewGame;
        private Button btnShowScores;
        private System.Windows.Forms.Timer timer;
    }
}
