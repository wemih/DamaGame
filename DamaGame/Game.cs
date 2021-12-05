﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DamaGame
{
    class Game
    {
        readonly private bool isDebugMode;
        readonly private Random random = new Random();
        private Player playerOne;
        private Player playerTwo;
        private Player nextPlayer;
        private Playfield playfield;

        public Game(bool isDebugMode, string playerOneName, string playerTwoName)
        {
            this.isDebugMode = isDebugMode;
            this.playerOne = new Player(this.isDebugMode, playerOneName);
            this.playerTwo = new Player(this.isDebugMode, playerTwoName);
            this.playfield = new Playfield(this.isDebugMode);

            if (this.isDebugMode) Console.WriteLine($"Game is generated");

            SelectStartingPlayer();
        }

        private void SelectStartingPlayer()
        {
            int randomNumber = this.random.Next(1, 3);

            if (randomNumber == 1)
            {
                this.playerOne.Color = "dark";
                this.playerTwo.Color = "light";
                this.nextPlayer = this.playerOne;
            } else
            {
                this.playerOne.Color = "light";
                this.playerTwo.Color = "dark";
                this.nextPlayer = this.playerTwo;
            }

            if (this.isDebugMode) Console.WriteLine($"Starting player is {this.nextPlayer.Name}");
        }

        private void EnableFiguresForNextPlayer()
        {
            for (int i = 0; i < this.playfield.Fields.GetLength(0); i++)
            {
                for (int j = 0; j < this.playfield.Fields.GetLength(1); j++)
                {
                    if (this.playfield.Fields[i, j] != null && this.playfield.Fields[i,j].Figure.Color == this.nextPlayer.Color)
                    {
                        this.playfield.Fields[i, j].Figure.Enable();
                    }
                }
            }

            if (this.isDebugMode) Console.WriteLine($"{this.nextPlayer.Color} figures enabled for {this.nextPlayer.Name}");
        }

        

        private void ChangeNextPlayer()
        {
            this.nextPlayer = this.nextPlayer == this.playerOne ? this.playerTwo : this.playerOne;

            if (this.isDebugMode) Console.WriteLine($"Next player changed to {this.nextPlayer.Name}");
        }

        public bool IsDebugMode => isDebugMode;

        public Random Random => random;

        internal Player PlayerOne { get => playerOne; set => playerOne = value; }
        internal Player PlayerTwo { get => playerTwo; set => playerTwo = value; }
        internal Playfield Playfield { get => playfield; set => playfield = value; }
    }
}
