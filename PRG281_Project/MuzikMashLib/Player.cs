using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuzikMashLib
{
    public class Player
    {
        private int userId;
        private string userName;
        private int score;
        private bool hasWon;
        /// <summary>
        /// Player constructor
        /// </summary>
        /// <param name="userId">Player ID</param>
        /// <param name="userName">Player name</param>
        /// <param name="score">Score</param>
        /// <param name="hasWon">True if player has won the game</param>
        public Player(int userId, string userName, int score, bool hasWon)
        {
            this.userId = userId;
            this.userName = userName;
            this.score = score;
            this.hasWon = hasWon;
        }

        public int UserId { get => userId; set => userId = value; }
        public string UserName { get => userName; set => userName = value; }
        public int Score { get => score; set => score = value; }
        public bool HasWon { get => hasWon; set => hasWon = value; }
 
        /// <summary>
        /// Updates user name
        /// </summary>
        /// <param name="username">New UserName</param>
        public void UpdateUserName(string username)
        {
            this.userName = username;
        }
    }
}
