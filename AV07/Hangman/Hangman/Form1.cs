using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class Form1 : Form
    {
        private HangmanWord hangmanWord;
        private IWordSelector wordSelector;
        private static readonly int TIME = 60 * 10;
        private int timeElapsed;

        public Form1()
        {
            InitializeComponent();
            wordSelector = new ArrayWordSelector();
            newGame();
        }
        
        private void newGame()
        {
            hangmanWord = new HangmanWord(wordSelector.pick());
            updateWordMask();
            updateGuessedLetters();
            timeElapsed = 0;
            updateTime();
            timer1.Start();
            pbVreme.Maximum = TIME;
            pbVreme.Value = TIME;
            pbGresniBukvi.Value = hangmanWord.WrongCount;
            pbGresniBukvi.Maximum = HangmanWord.MAX_WRONG_COUNT;
            tbBukva.Enabled = true;
            btnOK.Enabled = true;
        }

        private void updateWordMask()
        {
            lblZbor.Text = hangmanWord.WordMask();
        }

        private void updateGuessedLetters()
        {
            tbPogodeniBukvi.Text = hangmanWord.GuessedLettersMask();
        }

        private void updateTime()
        {
            int left = TIME - timeElapsed;
            int min = left / 60;
            int sec = left % 60;
            lblVreme.Text = string.Format("{0:00}:{1:00}", min, sec);
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newGame();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            enterLetter();
        }

        private void enterLetter()
        {
            if(tbBukva.Text.Length > 0)
            {
                char c = tbBukva.Text[0];
                tbBukva.Text = "";

                if(hangmanWord.GuessLetter(c))
                {
                    pbGresniBukvi.Value = hangmanWord.WrongCount;
                    updateWordMask();
                    updateGuessedLetters();
                    checkGameState();
                }
            }
        }

        private void checkGameState()
        {
            if (hangmanWord.IsGameOver())
            {
                string caption = string.Format("Неуспешно погодување", timeElapsed / 60, timeElapsed % 60);
                hangmanWord.EndGame();
                updateWordMask();
                timer1.Stop();
                tbBukva.Enabled = false;
                btnOK.Enabled = false;
                startNewGame(caption);

            }
            else
            {
                if (hangmanWord.IsGuessed())
                {
                    timer1.Stop();
                    string caption = string.Format("Го погодивте зборот за {0:00}:{1:00}", timeElapsed / 60, timeElapsed % 60);
                    tbBukva.Enabled = false;
                    btnOK.Enabled = false;
                    startNewGame(caption);
                }
            }
        }

        public void startNewGame(string caption)
        {
            if (MessageBox.Show("Нова игра?", caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                newGame();
            }
        }

        private void tbBukva_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                enterLetter();
                e.Handled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeElapsed++;
            pbVreme.Value = TIME - timeElapsed;

            if(timeElapsed == TIME)
            {
                hangmanWord.EndGame();
                tbBukva.Enabled = false;
                btnOK.Enabled = false;
                updateWordMask();
                timer1.Stop();
            }

            updateTime();
        }
    }
}
