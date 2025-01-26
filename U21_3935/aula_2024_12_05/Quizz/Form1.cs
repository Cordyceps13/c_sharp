using NAudio.Wave;

namespace Quizz
{
    public partial class Form1 : Form
    {
        // Objeto para gerar números aleatórios
        Random rand = new Random();

        // Variáveis para guardar os números gerados pelo objeto "rand"
        int adendo1;
        int adendo2;

        int minuendo;
        int subtrator;

        int multiplicando;
        int multiplicador;

        int dividendo;
        int divisor;

        int tempo;

        bool solucao = false;

        private void StartQuizz()
        {
            time_label.BackColor = Color.Green;

            adendo1 = rand.Next(51);
            adendo2 = rand.Next(51);
            plusLeftLabel.Text = adendo1.ToString();
            plusRightLabel.Text = adendo2.ToString();
            soma.Value = 0;

            minuendo = rand.Next(1, 101);
            subtrator = rand.Next(1, minuendo);
            minusLeftLabel.Text = minuendo.ToString();
            minusRightLabel.Text = subtrator.ToString();
            diferenca.Value = 0;

            multiplicando = rand.Next(2, 11);
            multiplicador = rand.Next(2, 11);
            timesLeftLabel.Text = multiplicando.ToString();
            timesRightLabel.Text = multiplicador.ToString();
            produto.Value = 0;

            divisor = rand.Next(2, 11);
            int temp = rand.Next(2, 11);
            dividendo = divisor * temp;
            dividedLeftLabel.Text = dividendo.ToString();
            dividedRightLabel.Text = divisor.ToString();
            quociente.Value = 0;

            tempo = 30;
            time_label.Text = tempo.ToString() + " segundos";
            timer1.Start();

        }
        private void NumericUpDown_ValueChanged(object sender, EventArgs e)
        {

            if (solucao)
            {
                return;
            }
            NumericUpDown control = (NumericUpDown)sender;

            if (control != null)
            {
                bool correct = false;

                // Check which control triggered the event and validate the answer.
                if (control == soma && soma.Value == adendo1 + adendo2)
                {
                    correct = true;
                }
                else if (control == diferenca && diferenca.Value == minuendo - subtrator)
                {
                    correct = true;
                }
                else if (control == produto && produto.Value == multiplicando * multiplicador)
                {
                    correct = true;
                }
                else if (control == quociente && quociente.Value == dividendo / divisor)
                {
                    correct = true;
                }

                // Play a sound if the answer is correct.
                if (correct)
                {
                    PlaySound("star.wav");
                }
            }
        }


        private void startBtn_Click(object sender, EventArgs e)
        {
            StartQuizz();
            StartBtn.Enabled = false;
        }

        private async void PlaySound(string fileName)
        {
            string directory = Application.StartupPath;
            string fullFilePath = Path.Combine(directory, "sounds", fileName);

            await Task.Run(() =>
            {
                using (var audioFile = new AudioFileReader(fullFilePath))
                using (var outputDevice = new WaveOutEvent())
                {
                    outputDevice.Init(audioFile);
                    outputDevice.Play();
                    while (outputDevice.PlaybackState == PlaybackState.Playing)
                    {
                        System.Threading.Thread.Sleep(10);
                    }
                }
            });
        }

        private bool verificacao()
        {
            if ((adendo1 + adendo2 == soma.Value)
                && (minuendo - subtrator == diferenca.Value)
                && (multiplicando * multiplicador == produto.Value)
                && (dividendo / divisor == quociente.Value))
                return true;
            else
                return false;
        }

        public Form1()
        {
            InitializeComponent();

            // Attach ValueChanged events
            soma.ValueChanged += NumericUpDown_ValueChanged;
            diferenca.ValueChanged += NumericUpDown_ValueChanged;
            produto.ValueChanged += NumericUpDown_ValueChanged;
            quociente.ValueChanged += NumericUpDown_ValueChanged;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (verificacao())
            {
                // If CheckTheAnswer() returns true, then the user 
                // got the answer right. Stop the timer  
                // and show a MessageBox.
                //vitoria.PlaySync();
                timer1.Stop();
                PlaySound("yamete.wav");
                MessageBox.Show("Acertaste!", "Parabéns!");
                StartBtn.Enabled = true;
            }
            else if (tempo > 0)
            {
                
                if (tempo <= 11)
                {
                    time_label.BackColor = Color.Yellow;
                }

                if (tempo <= 6) 
                {
                    time_label.BackColor = Color.Red;
                }
                // If CheckTheAnswer() returns false, keep counting
                // down. Decrease the time left by one second and 
                // display the new time left by updating the 
                // Time Left label.
                tempo = tempo - 1;
                time_label.Text = tempo + " segundos";
            }
            else
            {
                // If the user ran out of time, stop the timer, show
                // a MessageBox, and fill in the answers.
                //derrota.PlaySync();
                timer1.Stop();
                PlaySound("gameover.wav");
                time_label.Text = "Game Over";
                
                solucao = true;

                soma.Value = adendo1 + adendo2;
                diferenca.Value = minuendo - subtrator;
                produto.Value = multiplicando * multiplicador;
                quociente.Value = dividendo / divisor;
                MessageBox.Show("Tenta para a próxima :)", "Não terminaste a tempo.");

                solucao = false;

                StartBtn.Enabled = true;
            }

        }

        private void submeter_resposta(object sender, EventArgs e)
        {
            // Select the whole answer in the NumericUpDown control.
            NumericUpDown answerBox = (NumericUpDown)sender;

            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }

        }
    }
}
