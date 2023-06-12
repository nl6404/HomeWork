using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XOGame
{
    public partial class XOGame : Form
    {
        public XOGame()
        {
            InitializeComponent();
            InitializeGameBoard();
            this.KeyDown += new KeyEventHandler(Form_KeyDown);
        }
        private char[,] gameBoard = new char[3, 3]; // 九宮格狀態
        private char Player = 'X'; // 當前輪到的玩家，'X' 或 'O'

       

        private void InitializeGameBoard()
        {
            // 初始化九宮格狀態為空
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    gameBoard[row, col] = '\0';
                }
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int index = int.Parse(button.Name.Substring(3)); // 取得按鈕的索引

            int row = index / 3;
            int col = index % 3;

            if (gameBoard[row, col] == '\0') // 確保該格子是空的
            {
                gameBoard[row, col] = Player;
                button.Text = Player.ToString();

                // 檢查是否有玩家獲勝或遊戲平局
                if (CheckWin(Player))
                {
                    MessageBox.Show($"{Player}手獲勝!");
                    ResetGame();
                }
                else if (IsBoardFull())
                {
                    MessageBox.Show("平手!按下確定重新開始");
                    ResetGame();
                }
                else
                {
                    Player = (Player == 'X') ? 'O' : 'X'; // 換下一個玩家
                }
            }
        }

        private bool CheckWin(char player)
        {
            // 檢查行
            for (int row = 0; row < 3; row++)
            {
                if (gameBoard[row, 0] == player && gameBoard[row, 1] == player && gameBoard[row, 2] == player)
                {
                    return true;
                }
            }

            // 檢查列
            for (int col = 0; col < 3; col++)
            {
                if (gameBoard[0, col] == player && gameBoard[1, col] == player && gameBoard[2, col] == player)
                {
                    return true;
                }
            }

            // 檢查對角線
            if ((gameBoard[0, 0] == player && gameBoard[1, 1] == player && gameBoard[2, 2] == player) ||
                (gameBoard[0, 2] == player && gameBoard[1, 1] == player && gameBoard[2, 0] == player))
            {
                return true;
            }

            return false;
        }

        private bool IsBoardFull()
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    if (gameBoard[row, col] == '\0')
                    {
                        return false; // 還有空格子，遊戲尚未平局
                    }
                }
            }

            return true; // 所有格子都已經被填滿，遊戲平局
        }

        private void ResetGame()
        {
            // 清空九宮格狀態和按鈕文字
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    gameBoard[row, col] = '\0';
                    Controls.Find($"btn{row * 3 + col}", true)[0].Text = string.Empty;
                }
            }

            Player = 'X'; // 當前玩家重置為 'X'
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetGame();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.R)
            {
                ResetGame();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}
