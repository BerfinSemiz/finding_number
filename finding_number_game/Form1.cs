using System.Text;

namespace finding_number_game
{
    public partial class Form1 : Form
    {
        private string secretNumber = "";
        private int maxAttempts = 10;
        private int currentAttempts = 0;
        private int timeLeft = 300;
        private bool gameStarted = false;
        private List<string> gameHistory = new List<string>();
        private const string SCORES_FILE = "scores.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadScores();
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            string input = txtSecretNumber.Text.Trim();
            
            // Gizli sayı validasyonu
            if (string.IsNullOrEmpty(input) || input.Length != 4)
            {
                MessageBox.Show("Lütfen 4 haneli bir sayı girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!input.All(char.IsDigit))
            {
                MessageBox.Show("Lütfen sadece rakam girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tekrarsız rakam kontrolü
            if (input.Distinct().Count() != 4)
            {
                MessageBox.Show("Rakamlar tekrarsız olmalıdır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            secretNumber = input;
            maxAttempts = (int)nudAttempts.Value;
            currentAttempts = 0;
            timeLeft = 300;
            gameStarted = true;
            gameHistory.Clear();
            lstHistory.Items.Clear();

            // UI güncelleme
            gbGameSetup.Enabled = false;
            gbGamePlay.Enabled = true;
            lblAttemptsLeftValue.Text = maxAttempts.ToString();
            lblTimer.Text = timeLeft.ToString();
            txtGuess.Clear();
            txtGuess.Focus();

            // Timer başlat
            timer.Start();

            MessageBox.Show("Oyun başladı! 4 haneli sayıyı bulmaya çalışın.", "Oyun Başladı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            MakeGuess();
        }

        private void txtGuess_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                MakeGuess();
            }
        }

        private void MakeGuess()
        {
            if (!gameStarted) return;

            string guess = txtGuess.Text.Trim();

            // Tahmin validasyonu
            if (string.IsNullOrEmpty(guess) || guess.Length != 4)
            {
                MessageBox.Show("Lütfen 4 haneli bir sayı girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!guess.All(char.IsDigit))
            {
                MessageBox.Show("Lütfen sadece rakam girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (guess.Distinct().Count() != 4)
            {
                MessageBox.Show("Rakamlar tekrarsız olmalıdır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            currentAttempts++;
            lblAttemptsLeftValue.Text = (maxAttempts - currentAttempts).ToString();

            // Tahmin sonucunu hesapla
            string result = CalculateGuessResult(guess);
            string historyEntry = $"Tahmin {currentAttempts}: {guess} - {result}";
            
            gameHistory.Add(historyEntry);
            lstHistory.Items.Add(historyEntry);
            lstHistory.SelectedIndex = lstHistory.Items.Count - 1;

            txtGuess.Clear();
            txtGuess.Focus();

            // Oyun sonu kontrolü
            if (guess == secretNumber)
            {
                GameWon();
            }
            else if (currentAttempts >= maxAttempts)
            {
                GameLost();
            }
        }

        private string CalculateGuessResult(string guess)
        {
            int correctPosition = 0;
            int correctNumber = 0;

            for (int i = 0; i < 4; i++)
            {
                if (guess[i] == secretNumber[i])
                {
                    correctPosition++;
                }
                else if (secretNumber.Contains(guess[i]))
                {
                    correctNumber++;
                }
            }

            string result = "";
            if (correctPosition > 0)
            {
                result += $"{correctPosition} mavi ";
            }
            if (correctNumber > 0)
            {
                result += $"{correctNumber} kırmızı";
            }
            if (correctPosition == 0 && correctNumber == 0)
            {
                result = "Hiçbiri yok";
            }

            return result.Trim();
        }

        private void GameWon()
        {
            timer.Stop();
            gameStarted = false;
            
            int score = CalculateScore();
            SaveScore(score);
            
            MessageBox.Show($"Tebrikler! Sayıyı {currentAttempts} denemede buldunuz!\nSkorunuz: {score}", 
                "Oyun Kazanıldı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            ResetGame();
        }

        private void GameLost()
        {
            timer.Stop();
            gameStarted = false;
            
            MessageBox.Show($"Oyun bitti! Doğru sayı: {secretNumber}", 
                "Oyun Kaybedildi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            ResetGame();
        }

        private int CalculateScore()
        {
            // Skor hesaplama: 1000 puan - (deneme sayısı * 50) + (kalan süre * 10)
            int baseScore = 1000;
            int attemptPenalty = currentAttempts * 50;
            int timeBonus = timeLeft * 10;
            
            int finalScore = baseScore - attemptPenalty + timeBonus;
            return Math.Max(finalScore, 0); // Negatif skor olmasın
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timeLeft--;
            lblTimer.Text = timeLeft.ToString();

            if (timeLeft <= 0)
            {
                timer.Stop();
                gameStarted = false;
                MessageBox.Show($"Süre doldu! Doğru sayı: {secretNumber}", 
                    "Süre Doldu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetGame();
            }
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            if (gameStarted)
            {
                var result = MessageBox.Show("Oyun devam ediyor. Yeni oyun başlatmak istediğinizden emin misiniz?", 
                    "Yeni Oyun", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No) return;
            }

            ResetGame();
        }

        private void ResetGame()
        {
            timer.Stop();
            gameStarted = false;
            secretNumber = "";
            currentAttempts = 0;
            timeLeft = 300;
            gameHistory.Clear();
            lstHistory.Items.Clear();

            gbGameSetup.Enabled = true;
            gbGamePlay.Enabled = false;
            lblAttemptsLeftValue.Text = "0";
            lblTimer.Text = "300";
            txtSecretNumber.Clear();
            txtGuess.Clear();
        }

        private void btnShowScores_Click(object sender, EventArgs e)
        {
            ShowScores();
        }

        private void SaveScore(int score)
        {
            try
            {
                string scoreEntry = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - Deneme: {currentAttempts} - Süre: {60 - timeLeft}s - Skor: {score}";
                File.AppendAllText(SCORES_FILE, scoreEntry + Environment.NewLine, Encoding.UTF8);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Skor kaydedilirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadScores()
        {
            // Skor dosyası yoksa oluştur
            if (!File.Exists(SCORES_FILE))
            {
                try
                {
                    File.WriteAllText(SCORES_FILE, "=== SAYI BULMA OYUNU SKOR LİSTESİ ===\n", Encoding.UTF8);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Skor dosyası oluşturulurken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ShowScores()
        {
            try
            {
                if (File.Exists(SCORES_FILE))
                {
                    string scores = File.ReadAllText(SCORES_FILE, Encoding.UTF8);
                    if (string.IsNullOrEmpty(scores))
                    {
                        scores = "Henüz skor kaydedilmemiş.";
                    }
                    
                    MessageBox.Show(scores, "Skor Listesi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Henüz skor kaydedilmemiş.", "Skor Listesi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Skorlar okunurken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
