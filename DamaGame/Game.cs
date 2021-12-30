using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        private string gamePhase;

        public Game(bool isDebugMode, string playerOneName, string playerTwoName)
        {
            this.isDebugMode = isDebugMode;
            this.playerOne = new Player(this.isDebugMode, playerOneName);
            this.playerTwo = new Player(this.isDebugMode, playerTwoName);
            this.playfield = new Playfield(this.isDebugMode);

            if (this.isDebugMode) Console.WriteLine($"Game is generated");

            AddEventListeners();
            SelectStartingPlayer();
            EnableFiguresForNextPlayer();
        }

        private void AddEventListeners()
        {
            for (int i = 0; i < this.playfield.Fields.GetLength(0); i++)
            {
                for (int j = 0; j < this.playfield.Fields.GetLength(1); j++)
                {
                    this.playfield.Fields[i, j].Background.Click += OnClickField;

                    if (this.playfield.Fields[i, j].Figure != null)
                    {
                        this.playfield.Fields[i, j].Figure.Background.Click += OnClickFigure;
                    }
                }
            }
        }

        private void OnClickFigure(object sender, EventArgs e)
        {
            EnableFieldsForNextPlayer();
        }

        private void OnClickField(object sender, EventArgs e)
        {
            Move();
            CheckWinStatus();

            if (this.gamePhase != "clearWin" || this.gamePhase != "stuckWin")
            {
                SearchDama();
                SwitchNextPlayer();
                EnableFiguresForNextPlayer();
            }
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

        private void SwitchNextPlayer()
        {
            this.nextPlayer = this.nextPlayer == this.playerOne ? this.playerTwo : this.playerOne;

            if (this.isDebugMode) Console.WriteLine($"Next player is {this.nextPlayer.Name}/{this.nextPlayer.Color}");
        }

        private bool IsThereHitCompForNextPlayer()
        {
            bool founded = false;
            for (int i = 0; i < this.playfield.Fields.GetLength(0); i++)
            {
                for (int j = 0; j < this.playfield.Fields.GetLength(1); j++)
                {
                    if (this.playfield.Fields[i, j].Figure != null)
                    {
                        if (this.playfield.Fields[i, j].Figure.IsDama)
                        {
                            
                        } else
                        {
                            if (this.playfield.Fields[i, j].Figure.Color == "dark" && this.nextPlayer.Color == "dark")
                            {
                                if (i < 6 && j > 1 && this.playfield.Fields[i + 1, j - 1].Figure != null && this.playfield.Fields[i + 1, j - 1].Figure.Color == "light" &&
                                   this.playfield.Fields[i + 2, j - 2].Figure == null)
                                {
                                    this.playfield.Fields[i, j].EnableFigure();
                                    founded = true;
                                }

                                if (i < 6 && j < 6 && this.playfield.Fields[i + 1, j + 1].Figure != null && this.playfield.Fields[i + 1, j + 1].Figure.Color == "light" &&
                                    this.playfield.Fields[i + 2, j + 2].Figure == null)
                                {
                                    this.playfield.Fields[i, j].EnableFigure();
                                    founded = true;
                                }

                            } else if (this.playfield.Fields[i, j].Figure.Color == "light" && this.nextPlayer.Color == "light")
                            {
                                if (i > 1 && j > 1 && this.playfield.Fields[i - 1, j - 1].Figure != null && this.playfield.Fields[i - 1, j - 1].Figure.Color == "dark" &&
                                    this.playfield.Fields[i - 2, j - 2].Figure == null)
                                {
                                    this.playfield.Fields[i, j].EnableFigure();
                                    founded = true;
                                }

                                if (i > 1 && j < 6 && this.playfield.Fields[i - 1, j + 1].Figure != null && this.playfield.Fields[i - 1, j + 1].Figure.Color == "dark" &&
                                    this.playfield.Fields[i - 2, j + 2].Figure == null)
                                {
                                    this.playfield.Fields[i, j].EnableFigure();
                                    founded = true;
                                }
                            }
                        }
                    }
                }
            }
            if (founded)
            {
                this.gamePhase = "hitComp";
            } else
            {
                this.gamePhase = "move";
            }
            return founded;
        }

        private void EnableFiguresForNextPlayer()
        {
            DisableEverything();
            if (!IsThereHitCompForNextPlayer())
            {
                for (int i = 0; i < this.playfield.Fields.GetLength(0); i++)
                {
                    for (int j = 0; j < this.playfield.Fields.GetLength(1); j++)
                    {
                        if (this.playfield.Fields[i, j].Figure != null && this.playfield.Fields[i,j].Figure.Color == this.nextPlayer.Color)
                        {
                            if (this.playfield.Fields[i, j].Figure.IsDama)
                            {
                                if ((j > 0 && i < 7 && this.playfield.Fields[i + 1, j - 1].Figure == null) || (j < 7 && i < 7 && this.playfield.Fields[i + 1, j + 1].Figure == null) || (j > 0 && this.playfield.Fields[i - 1, j - 1].Figure == null) || (j < 7 && this.playfield.Fields[i - 1, j + 1].Figure == null))
                                {
                                    this.playfield.Fields[i, j].EnableFigure();
                                }
                            }

                            if (this.playfield.Fields[i, j].Figure.Color == "dark" && i < 7)
                            {
                                if ((j > 0 && this.playfield.Fields[i + 1, j - 1].Figure == null) || (j < 7 && this.playfield.Fields[i + 1, j + 1].Figure == null))
                                {
                                    this.playfield.Fields[i, j].EnableFigure();
                                }
                            }

                            if (this.playfield.Fields[i, j].Figure.Color == "light" && i > 0)
                            {
                                if ((j > 0 && this.playfield.Fields[i - 1, j - 1].Figure == null) || (j < 7 && this.playfield.Fields[i - 1, j + 1].Figure == null))
                                {
                                    this.playfield.Fields[i, j].EnableFigure();
                                }
                            }
                        }
                    }
                }
            }
        } 

        private void EnableFieldsForNextPlayer()
        {
            DisableEverything();

            if(this.gamePhase == "move")
            {
                for (int i = 0; i < this.playfield.Fields.GetLength(0); i++)
                {
                    for (int j = 0; j < this.playfield.Fields.GetLength(1); j++)
                    {
                        if (this.playfield.Fields[i, j].Figure != null && this.playfield.Fields[i, j].Figure.IsSelected())
                        {
                            if (this.playfield.Fields[i, j].Figure.IsDama)
                            {
                                int offset = 0;

                                while (i + offset < this.playfield.Fields.GetLength(0) - 1 && j + offset < this.playfield.Fields.GetLength(1) - 1)
                                {
                                    offset++;
                                    if (this.playfield.Fields[i + offset, j + offset].Figure == null)
                                    {
                                        this.playfield.Fields[i + offset, j + offset].EnableFieldForStep();
                                    } else if (i + offset < this.playfield.Fields.GetLength(0) - 1 && j + offset < this.playfield.Fields.GetLength(1) - 1 && this.playfield.Fields[i + offset, j + offset].Figure != null && this.playfield.Fields[i + offset ,j + offset].Figure.Color != this.nextPlayer.Color && this.playfield.Fields[i + offset + 1, j + offset + 1].Figure == null) 
                                    {
                                        this.playfield.Fields[i + offset + 1, j + offset + 1].EnableFieldForHit();
                                        break;
                                    } else
                                    {
                                        break;
                                    }
                                }

                                offset = 0;

                                while (i + offset < this.playfield.Fields.GetLength(0) - 1 && j - offset > 0)
                                {
                                    offset++;
                                    if (this.playfield.Fields[i + offset, j - offset].Figure == null)
                                    {
                                        this.playfield.Fields[i + offset, j - offset].EnableFieldForStep();
                                    }else if (i + offset < this.playfield.Fields.GetLength(0) - 1 && j - offset > 0 && this.playfield.Fields[i + offset, j - offset].Figure != null && this.playfield.Fields[i + offset, j - offset].Figure.Color != this.nextPlayer.Color && this.playfield.Fields[i + offset + 1, j - offset - 1].Figure == null)
                                    {
                                        this.playfield.Fields[i + offset + 1, j - offset - 1].EnableFieldForHit();
                                        break;
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }

                                offset = 0;

                                while (i - offset > 0 && j + offset < this.playfield.Fields.GetLength(1) - 1)
                                {
                                    offset++;
                                    if (this.playfield.Fields[i - offset, j + offset].Figure == null)
                                    {
                                        this.playfield.Fields[i - offset, j + offset].EnableFieldForStep();
                                    }else if (i - offset > 0 && j + offset < this.playfield.Fields.GetLength(1) - 1 && this.playfield.Fields[i - offset, j + offset].Figure != null && this.playfield.Fields[i - offset, j + offset].Figure.Color != this.nextPlayer.Color && this.playfield.Fields[i - offset - 1, j + offset + 1].Figure == null)
                                    {
                                        this.playfield.Fields[i - offset - 1, j + offset + 1].EnableFieldForHit();
                                        break;
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }

                                offset = 0;

                                while (i - offset > 0 && j - offset > 0)
                                {
                                    offset++;
                                    if (this.playfield.Fields[i - offset, j - offset].Figure == null)
                                    {
                                        this.playfield.Fields[i - offset, j - offset].EnableFieldForStep();
                                    }else if (i - offset > 0 && j - offset > 0 && this.playfield.Fields[i - offset, j - offset].Figure != null && this.playfield.Fields[i - offset, j - offset].Figure.Color != this.nextPlayer.Color && this.playfield.Fields[i - offset - 1, j - offset - 1].Figure == null)
                                    {
                                        this.playfield.Fields[i - offset - 1, j - offset - 1].EnableFieldForHit();
                                        break;
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                            } else
                            {
                                if (this.playfield.Fields[i, j].Figure.Color == "dark")
                                {
                                    if (j > 0 && this.playfield.Fields[i + 1, j - 1].Figure == null)
                                    {
                                        this.playfield.Fields[i + 1, j - 1].EnableFieldForStep();
                                    }

                                    if (j < 7 && this.playfield.Fields[i + 1, j + 1].Figure == null)
                                    {
                                        this.playfield.Fields[i + 1, j + 1].EnableFieldForStep();
                                    }
                                }

                                if (this.playfield.Fields[i, j].Figure.Color == "light")
                                {
                                    if (j > 0 && this.playfield.Fields[i - 1, j - 1].Figure == null)
                                    {
                                        this.playfield.Fields[i - 1, j - 1].EnableFieldForStep();
                                    }

                                    if (j < 7 && this.playfield.Fields[i - 1, j + 1].Figure == null)
                                    {
                                        this.playfield.Fields[i - 1, j + 1].EnableFieldForStep();
                                    }
                                }
                            }
                        }
                    }
                }
            } else if (this.gamePhase == "hitComp")
            {
                for (int i = 0; i < this.playfield.Fields.GetLength(0); i++)
                {
                    for (int j = 0; j < this.playfield.Fields.GetLength(1); j++)
                    {
                        if (this.playfield.Fields[i, j].Figure != null && this.playfield.Fields[i, j].Figure.IsSelected())
                        {
                            if (this.playfield.Fields[i, j].Figure.Color == "dark" && i < 6)
                            {
                                if (j > 1 && this.playfield.Fields[i + 1, j - 1].Figure != null && this.playfield.Fields[i + 1, j - 1].Figure.Color == "light" && this.playfield.Fields[i + 2, j - 2].Figure == null)
                                {
                                    this.playfield.Fields[i + 2, j - 2].EnableFieldForHit();
                                }

                                if (j < 6 && this.playfield.Fields[i + 1, j + 1].Figure != null && this.playfield.Fields[i + 1, j + 1].Figure.Color == "light" && this.playfield.Fields[i + 2, j + 2].Figure == null)
                                {
                                    this.playfield.Fields[i + 2, j + 2].EnableFieldForHit();
                                }
                            }

                            if (this.playfield.Fields[i, j].Figure.Color == "light" && i > 1)
                            {
                                if (j > 1 && this.playfield.Fields[i - 1, j - 1].Figure != null && this.playfield.Fields[i - 1, j - 1].Figure.Color == "dark" && this.playfield.Fields[i - 2, j - 2].Figure == null)
                                {
                                    this.playfield.Fields[i - 2, j - 2].EnableFieldForHit();
                                }

                                if (j < 6 && this.playfield.Fields[i - 1, j + 1].Figure != null && this.playfield.Fields[i - 1, j + 1].Figure.Color == "dark" && this.playfield.Fields[i - 2, j + 2].Figure == null)
                                {
                                    this.playfield.Fields[i - 2, j + 2].EnableFieldForHit();
                                }
                            }
                        }
                    }
                }
            }

            if (this.isDebugMode) Console.WriteLine($"Fields enabled for {this.nextPlayer.Name}");
        }

        private void DisableEverything()
        {
            for (int i = 0; i < this.playfield.Fields.GetLength(0); i++)
            {
                for (int j = 0; j < this.playfield.Fields.GetLength(1); j++)
                {
                    this.playfield.Fields[i, j].DisableField();
                    this.playfield.Fields[i, j].DisableFigure();
                }
            }

            Console.WriteLine("Every field and figure disabled");
        }

        private void Move()
        {
            int[] selectedFigureLocation = new int[2];
            int[] targetFieldLocation = new int[2];

            for (int i = 0; i < this.playfield.Fields.GetLength(0); i++)
            {
                for (int j = 0; j < this.playfield.Fields.GetLength(1); j++)
                {
                    if (this.playfield.Fields[i, j].Figure != null && this.playfield.Fields[i, j].Figure.IsSelected())
                    {
                        selectedFigureLocation[0] = i;
                        selectedFigureLocation[1] = j;
                    }

                    if (this.playfield.Fields[i, j].Figure == null && this.playfield.Fields[i, j].IsSelected())
                    {
                        targetFieldLocation[0] = i;
                        targetFieldLocation[1] = j;
                    }
                }
            }

            //deselect the figure and field
            this.playfield.Fields[selectedFigureLocation[0], selectedFigureLocation[1]].Figure.Deselect();
            this.playfield.Fields[targetFieldLocation[0], targetFieldLocation[1]].Deselect();


            //move in the 2d array
            this.playfield.Fields[targetFieldLocation[0], targetFieldLocation[1]].Figure = this.playfield.Fields[selectedFigureLocation[0], selectedFigureLocation[1]].Figure;
            this.playfield.Fields[selectedFigureLocation[0], selectedFigureLocation[1]].Figure = null;

            //hit detection

            if (Math.Abs(selectedFigureLocation[0] - targetFieldLocation[0]) == 2 && !this.playfield.Fields[targetFieldLocation[0], targetFieldLocation[1]].Figure.IsDama)
            {
                Hit((selectedFigureLocation[0] + targetFieldLocation[0]) / 2, (selectedFigureLocation[1] + targetFieldLocation[1]) / 2);
            }

            if (this.playfield.Fields[targetFieldLocation[0], targetFieldLocation[1]].Figure.IsDama)
            {
                int offSet = 0;

                if (targetFieldLocation[0] > selectedFigureLocation[0] && targetFieldLocation[1] > selectedFigureLocation[1])
                {
                    while (selectedFigureLocation[0] + offSet != targetFieldLocation[0] && selectedFigureLocation[1] + offSet != targetFieldLocation[1])
                    {
                        offSet++;
                        if (this.playfield.Fields[selectedFigureLocation[0] + offSet, selectedFigureLocation[1] + offSet].Figure!= null && this.playfield.Fields[selectedFigureLocation[0] + offSet, selectedFigureLocation[1] + offSet].Figure.Color != this.nextPlayer.Color) {
                            Hit(selectedFigureLocation[0] + offSet, selectedFigureLocation[1] + offSet);
                        }
                    }

                } else if (targetFieldLocation[0] > selectedFigureLocation[0] && targetFieldLocation[1] < selectedFigureLocation[1])
                {
                    while (selectedFigureLocation[0] + offSet != targetFieldLocation[0] && selectedFigureLocation[1] - offSet != targetFieldLocation[1])
                    {
                        offSet++;
                        if (this.playfield.Fields[selectedFigureLocation[0] + offSet, selectedFigureLocation[1] - offSet].Figure != null && this.playfield.Fields[selectedFigureLocation[0] + offSet, selectedFigureLocation[1] - offSet].Figure.Color != this.nextPlayer.Color)
                        {
                            Hit(selectedFigureLocation[0] + offSet, selectedFigureLocation[1] - offSet);
                        }
                    }

                } else if (targetFieldLocation[0] < selectedFigureLocation[0] && targetFieldLocation[1] < selectedFigureLocation[1])
                {
                    while (selectedFigureLocation[0] - offSet != targetFieldLocation[0] && selectedFigureLocation[1] - offSet != targetFieldLocation[1])
                    {
                        offSet++;
                        if (this.playfield.Fields[selectedFigureLocation[0] - offSet, selectedFigureLocation[1] - offSet].Figure != null && this.playfield.Fields[selectedFigureLocation[0] - offSet, selectedFigureLocation[1] - offSet].Figure.Color != this.nextPlayer.Color)
                        {
                            Hit(selectedFigureLocation[0] - offSet, selectedFigureLocation[1] - offSet);
                        }
                    }

                } else if (targetFieldLocation[0] < selectedFigureLocation[0] && targetFieldLocation[1] > selectedFigureLocation[1])
                {
                    while(selectedFigureLocation[0] - offSet != targetFieldLocation[0] && selectedFigureLocation[1] + offSet != targetFieldLocation[1])
                    {
                        offSet++;
                        if (this.playfield.Fields[selectedFigureLocation[0] - offSet, selectedFigureLocation[1] + offSet].Figure != null && this.playfield.Fields[selectedFigureLocation[0] - offSet, selectedFigureLocation[1] + offSet].Figure.Color != this.nextPlayer.Color)
                        {
                            Hit(selectedFigureLocation[0] - offSet, selectedFigureLocation[1] + offSet);
                        }
                    }

                }

            }

            if (this.isDebugMode) Console.WriteLine($"Figure moved");
        }

        

        private void SearchDama()
        {
            for (int i = 0; i < this.playfield.Fields.GetLength(0); i++)
            {
                for (int j = 0; j < this.playfield.Fields.GetLength(1); j++)
                {
                    if (this.playfield.Fields[i, j].Figure != null)
                    {
                        if (this.playfield.Fields[i, j].Figure.Color == "dark" && i == 7)
                        {
                            this.playfield.Fields[i, j].Figure.TurnIntoDama();
                        }

                        if (this.playfield.Fields[i, j].Figure.Color == "light" && i == 0)
                        {
                            this.playfield.Fields[i, j].Figure.TurnIntoDama();
                        }
                    }
                }
            }
        }

        private void Hit(int row, int col)
        {
            this.playfield.Fields[row, col].Figure.Hit();
            this.playfield.Fields[row, col].Figure = null;
        }

        private void CheckWinStatus()
        {
            int dark = 0;
            int light = 0;
            int enabledDark = 0;
            int enabledLight = 0;

            for (int i = 0; i < this.playfield.Fields.GetLength(0); i++)
            {
                for (int j = 0; j < this.playfield.Fields.GetLength(1); j++)
                {
                    if (this.playfield.Fields[i, j].Figure != null)
                    {
                        if (this.playfield.Fields[i, j].Figure.Color == "dark")
                        {
                            dark++;

                            if (this.playfield.Fields[i, j].Figure.IsEnabled())
                            {
                                enabledDark++;
                            }
                        }
                        else if (this.playfield.Fields[i, j].Figure.Color == "light")
                        {
                            light++;

                            if (this.playfield.Fields[i, j].Figure.IsEnabled())
                            {
                                enabledLight++;
                            }
                        }
                    }
                }
            }

            if (dark == 0 || light == 0)
            {
                this.gamePhase = "clearWin";
                DisableEverything();
            } else if (enabledDark == 0 || enabledLight == 0)
            {
                this.gamePhase = "stuckWin";
                DisableEverything();
            }
        }

        public bool IsDebugMode => isDebugMode;

        public Random Random => random;

        internal Player PlayerOne { get => playerOne; set => playerOne = value; }
        internal Player PlayerTwo { get => playerTwo; set => playerTwo = value; }
        internal Playfield Playfield { get => playfield; set => playfield = value; }
    }
}
