using Dapper;
using System;
using System.Data.SQLite;
using System.Text;
using System.Timers;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WhoWantsToBeAMillionere_lab03
{
    public partial class Form1 : Form
    {
        const string connectionString = "Data Source = \"C:\\Users\\PCevd\\WWTBM_lab03.db\";Version=3;";
        int level = 0;
        Question currentQuestion;
        Random rnd = new Random();
        bool[] tips = new bool[5];
        string name;
        int[] money = new int[] { 3000000, 1500000, 800000, 400000, 200000, 100000, 50000, 25000, 15000, 10000, 5000, 3000, 2000, 1000, 500 };
        private System.Timers.Timer timer;
        private const int timeLimit = 30;
        int noBurnSum;
        bool mistakeAvailable;
        bool mistakeAvailableClicked;

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(bool[] tips, string name, string noBurnSum)
        {
            InitializeComponent();
            this.tips = tips;
            this.name = name;
            this.noBurnSum = int.Parse(noBurnSum.Replace(" ", ""));
            mistakeAvailable = tips[3];
            Array.Reverse(money);
            for (int i = 0; i < tips.Length; i++)
            {
                if (!tips[i])
                {
                    switch (i)
                    {
                        case 0:
                            btnPeople.BackgroundImage = imageList1.Images[0];
                            btnPeople.Enabled = false;
                            break;
                        case 1:
                            btnFiftyFifty.BackgroundImage = imageList1.Images[0];
                            btnFiftyFifty.Enabled = false;
                            break;
                        case 2:
                            btnCall.BackgroundImage = imageList1.Images[0];
                            btnCall.Enabled = false;
                            break;
                        case 3:
                            btnAvailableMistake.BackgroundImage = imageList1.Images[0];
                            btnAvailableMistake.Enabled = false;
                            break;
                        case 4:
                            btnskipQuestion.BackgroundImage = imageList1.Images[0];
                            btnskipQuestion.Enabled = false;
                            break;
                    }
                }
            }
            StartGame();
        }
        private void StartGame()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = "C:/Users/PCevd/source/repos/WhoWantsToBeAMillionere_lab03/WhoWantsToBeAMillionere_lab03/hello-new-punter-2008-long.wav";
            player.Play();

            level = 0;
            NextStep();
        }
        private void EndGame()
        {
            if (level > 1)
            {
                SaveUser();
            }
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = "C:/Users/PCevd/source/repos/WhoWantsToBeAMillionere_lab03/WhoWantsToBeAMillionere_lab03/khsm_q6-correct.wav";
            player.Play();
            Close();
        }

        private void ShowQuestion(Question q)
        {
            lblQuestion.Text = q.Text;
            Aanswer.Text = q.Answer1;
            BAnswer.Text = q.Answer2;
            CAnswer.Text = q.Answer3;
            DAnswer.Text = q.Answer4;
        }

        private Question GetQuestion(int level)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                var query = "SELECT text, answer1, answer2, answer3, answer4, rightAnswer, level FROM questions WHERE level = @Level ORDER BY RANDOM() LIMIT 1";
                var question = connection.QuerySingleOrDefault<Question>(query, new { Level = level });
                return question;
            }
        }

        private void NextStep()
        {
            Button[] btns = new Button[] { Aanswer, BAnswer,
            CAnswer, DAnswer };

            foreach (Button btn in btns)
                btn.Enabled = true;

            level++;
            if (level == 16)
            {
                MessageBox.Show($"Вы выиграли! Ваш выигрыш составил {money[15]}!");
            }
            currentQuestion = GetQuestion(level);
            ShowQuestion(currentQuestion);
            listBox1.SelectedIndex = listBox1.Items.Count - level;
            mistakeAvailableClicked = false;
        }

        private void SaveUser()
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                var query = "INSERT INTO leaderboard (name, level, money)  VALUES (@Name, @Level, @Money)";
                connection.Execute(query, new { Name = name, Level = level, Money = money[level - 2] });
            }
        }
        public static void ShowLeaderBoard()
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                string res = "";
                var query = "SELECT * FROM leaderboard ORDER BY level DESC LIMIT 10";
                var leaderboard = connection.Query(query);
                StringBuilder sb = new StringBuilder();
                foreach (var item in leaderboard)
                {
                    sb.AppendLine($"Имя: {item.name}, Кол-во вопросов: {item.level}, Выигрыш: {item.money}");
                }
                MessageBox.Show(sb.ToString(), "Таблица лидеров");
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (currentQuestion.RightAnswer == int.Parse(button.Tag.ToString()))
                NextStep();
            else if (mistakeAvailable && mistakeAvailableClicked)
            {
                MessageBox.Show("Неверный ответ! Но вас спасла подсказка!");
                NextStep();
                mistakeAvailable = false;
                btnAvailableMistake.Enabled = false;
            }
            else if (money[level - 1] >= noBurnSum)
            {
                MessageBox.Show($"Поздравляем! Ваш выигрыш в виде несгораемой суммы составил {noBurnSum}!");
                EndGame();
            }
            else
            {
                MessageBox.Show("Неверный ответ! Вы проиграли.");
                EndGame();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (currentQuestion.RightAnswer == int.Parse(button.Tag.ToString()))
                NextStep();
            else if (mistakeAvailable && mistakeAvailableClicked)
            {
                MessageBox.Show("Неверный ответ! Но вас спасла подсказка!");
                NextStep();
                mistakeAvailable = false;
                btnAvailableMistake.Enabled = false;
            }
            else if (money[level - 1] >= noBurnSum)
            {
                MessageBox.Show($"Поздравляем! Ваш выигрыш в виде несгораемой суммы составил {noBurnSum}!");
                EndGame();
            }
            else
            {
                MessageBox.Show("Неверный ответ! Вы проиграли.");
                EndGame();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Aanswer_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (currentQuestion.RightAnswer == int.Parse(button.Tag.ToString()))
                NextStep();
            else if (mistakeAvailable && mistakeAvailableClicked)
            {
                MessageBox.Show("Неверный ответ! Но вас спасла подсказка!");
                NextStep();
                mistakeAvailable = false;
                btnAvailableMistake.Enabled = false;
            }
            else if (money[level - 1] >= noBurnSum)
            {
                MessageBox.Show($"Поздравляем! Ваш выигрыш в виде несгораемой суммы составил {noBurnSum}!");
                EndGame();
            }
            else
            {
                MessageBox.Show("Неверный ответ! Вы проиграли.");
                EndGame();
            }

        }

        private void DAnswer_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (currentQuestion.RightAnswer == int.Parse(button.Tag.ToString()))
                NextStep();
            else if (mistakeAvailable && mistakeAvailableClicked)
            {
                MessageBox.Show("Неверный ответ! Но вас спасла подсказка!");
                NextStep();
                mistakeAvailable = false;
                btnAvailableMistake.Enabled = false;
            }
            else if (money[level-1] >= noBurnSum)
            {
                MessageBox.Show($"Поздравляем! Ваш выигрыш в виде несгораемой суммы составил {noBurnSum}!");
            }
            else
            {
                MessageBox.Show("Неверный ответ! Вы проиграли.");
                EndGame();
            }
        }

        private void btnFiftyFifty_Click(object sender, EventArgs e)
        {
            Button[] btns = new Button[] { Aanswer, BAnswer,
                CAnswer, DAnswer};
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = "C:/Users/PCevd/source/repos/WhoWantsToBeAMillionere_lab03/WhoWantsToBeAMillionere_lab03/khsm_50-50.wav";
            player.Play();
            int count = 0;
            while (count < 2)
            {
                int n = rnd.Next(4);
                int answer = int.Parse(btns[n].Tag.ToString());

                if (answer != currentQuestion.RightAnswer && btns[n].Enabled)
                {
                    btns[n].Enabled = false;
                    count++;
                }
            }
            btnFiftyFifty.Enabled = false;

        }

        private void btnCall_Click(object sender, EventArgs e)
        {
            timer = new System.Timers.Timer(timeLimit * 1000);
            timer.Elapsed += OnTimedEvent;
            timer.AutoReset = false;
            timer.Start();
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = "C:/Users/PCevd/source/repos/WhoWantsToBeAMillionere_lab03/WhoWantsToBeAMillionere_lab03/khsm_phone_countdown.wav";
            player.Play();
            DialogResult result = MessageBox.Show($"Звонок другу\n\nВопрос: {currentQuestion.Text}\n\nОтветы:\nA: {Aanswer.Text}\nB: {BAnswer.Text}\nC: {CAnswer.Text}\nD: {DAnswer.Text}\n\nУ вас есть {timeLimit} секунд на выбор.", "Звонок другу", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (result == DialogResult.OK) 
            {
                timer.Elapsed -= OnTimedEvent;
                timer.Stop();
                player.Stop();
            }
            btnCall.Enabled = false;
        }
        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            this.Invoke(new Action(() => { SendKeys.Send("{ESC}"); }));
            timer.Stop();
        }

        private void btnPeople_Click(object sender, EventArgs e)
        {
            Form helpForm = new Form();
            helpForm.Text = "Помощь зала";

            Chart chart = new Chart();
            chart.Dock = DockStyle.Fill;

            ChartArea chartArea = new ChartArea();
            chart.ChartAreas.Add(chartArea);

            Series series = new Series();
            series.ChartType = SeriesChartType.Column;
            chart.Series.Add(series);

            int correctAnswer = currentQuestion.RightAnswer;
            int[] audience = new int[4];

            audience[0] = rnd.Next(51, 80);
            int remains = 100 - audience[0];
            for (int i = 1; i < 4; i++)
            {
                audience[i] = rnd.Next(0, remains + 1);
                remains -= audience[i];
            }

            if (remains > 0)
            {
                for (int i = 1; i < 4; i++)
                {
                    if (remains > 0)
                    {
                        audience[i]++;
                        remains--;
                    }
                }
            }
            if (correctAnswer == 1)
            {
                series.Points.AddXY("A", audience[0]);
                series.Points.AddXY("B", audience[1]);
                series.Points.AddXY("C", audience[2]);
                series.Points.AddXY("D", audience[3]);

            }
            else if (correctAnswer == 2)
            {
                series.Points.AddXY("A", audience[1]);
                series.Points.AddXY("B", audience[0]);
                series.Points.AddXY("C", audience[2]);
                series.Points.AddXY("D", audience[3]);
            }
            else if (correctAnswer == 3)
            {
                series.Points.AddXY("A", audience[1]);
                series.Points.AddXY("B", audience[2]);
                series.Points.AddXY("C", audience[0]);
                series.Points.AddXY("D", audience[3]);
            }
            else if (correctAnswer == 4)
            {
                series.Points.AddXY("A", audience[1]);
                series.Points.AddXY("B", audience[3]);
                series.Points.AddXY("C", audience[2]);
                series.Points.AddXY("D", audience[0]);
            }
            helpForm.Controls.Add(chart);
            helpForm.ShowDialog();
            btnPeople.Enabled = false;

        }

        private void btnskipQuestion_Click(object sender, EventArgs e)
        {
            level--;
            NextStep();
            btnskipQuestion.Enabled = false;
        }

        private void btnAvailableMistake_Click(object sender, EventArgs e)
        {
            mistakeAvailableClicked = true;
            btnAvailableMistake.Enabled = false;
        }

        private void btnTakeMoney_Click(object sender, EventArgs e)
        {
            if (level >= 1)
            {
                SaveUser();
                MessageBox.Show($"Поздравляем! Ваш выигрыш составил {money[level - 2]}!");
                EndGame();
            }
            else
            {
                MessageBox.Show($"Пока рано!");
            }
            
        }
    }

}
