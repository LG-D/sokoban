using System;
using System.IO;
using System.Windows.Forms;

namespace LGashiAssignment1
{
    // enumeration of directions
    enum Direction
    {
        UP,
        DOWN,
        LEFT,
        RIGHT
    }

    public partial class PlayForm : Form
    {
        int heroRow;
        int heroColumn;
        int numberOfMoves = 0;
        int numberOfPushes = 0;
        int numberOfDestinations = 0;

        // Will store the current tile under hero
        TileType underHeroTile = TileType.None;

        // Will store the row and column of tiles
        Tile[,] tiles;

        public PlayForm()
        {
            InitializeComponent();
        }

        /// <summary>
        ///  Will load the game file and create tiles with correct number of 
        ///  rows and columns, and show the tile type
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearControls();

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Game Files (*.game, *.skbn)| *.game;*.skbn";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = openFileDialog.FileName;
                    using (StreamReader reader = new StreamReader(fileName))
                    {
                        string[] lines = File.ReadAllLines(fileName);
                        int rowNo = int.Parse(lines[0]);
                        int colNo = int.Parse(lines[1]);

                        tiles = new Tile[rowNo, colNo];

                        int tileTypeLine = 4;
                        for (int row = 0; row < rowNo; row++)
                        {
                            for (int col = 0; col < colNo; col++)
                            {
                                if (int.Parse(lines[tileTypeLine]) == 1)
                                {
                                    heroRow = row;
                                    heroColumn = col;
                                }
                                Tile tile = new Tile(row, col, int.Parse(lines[tileTypeLine]));
                                if (tile.Type == TileType.Destination)
                                {
                                    numberOfDestinations++;
                                }
                                tileTypeLine += 3;
                                pnlBoard.Controls.Add(tile);
                                tiles[row, col] = tile;

                                pnlController.Enabled = true;
                            }
                        }
                        underHeroTile = TileType.None;
                    }
                }
            }
        }

        /// <summary>
        /// Will move the hero up 
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUp_Click(object sender, EventArgs e)
        {
            MoveHeroByDirection(Direction.UP);
        }

        /// <summary>
        /// Will move the hero left based on the next tile type
        /// and will check for tiles that are none, destination, and box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLeft_Click(object sender, EventArgs e)
        {
            MoveHeroByDirection(Direction.LEFT);
        }

        /// <summary>
        /// Will move the hero down based on the next tile type
        /// and will check for tiles that are none, destination, and box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDown_Click(object sender, EventArgs e)
        {
            MoveHeroByDirection(Direction.DOWN);
        }

        /// <summary>
        /// Will move the hero right based on the next tile type
        /// and will check for tiles that are none, destination, and box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRight_Click(object sender, EventArgs e)
        {
            MoveHeroByDirection(Direction.RIGHT);
        }


        /// <summary>
        /// Will exit the playForm 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Gets the current tile located in row and column
        /// </summary>
        /// <param name="row"></param>
        /// <param name="column"></param>
        /// <returns></returns>
        private Tile GetTile(int row, int column)
        {
            return tiles[row, column];
        }

        /// <summary>
        /// Will switch the direction and move the hero based on the coordinates
        /// to go up, down, right or left.
        /// </summary>
        /// <param name="direction">Enum, has 4 directions: UP,DOWN,RIGHT,LEFT</param>
        private void MoveHeroByDirection(Direction direction)
        {
            switch (direction)
            {
                case Direction.UP:
                    MoveHero(-1, 0, TileType.Hero);
                    break;
                case Direction.DOWN:
                    MoveHero(1, 0, TileType.Hero);
                    break;
                case Direction.RIGHT:
                    MoveHero(0, 1, TileType.HeroRight);
                    break;
                case Direction.LEFT:
                    MoveHero(0, -1, TileType.HeroLeft);
                    break;
            }
        }

        /// <summary>
        /// Will move the hero to desired row and column and will set hero 
        /// and checks what's the next tile type and decide if he can move up, down, left or right
        /// based on the desiredRow and desiredColumn passed from MoveHeroByDirection method
        /// </summary>
        /// <param name="desiredRow">The row which hero wants to move to</param>
        /// <param name="desiredColumn">The column which hero wants to move to</param>
        /// <param name="heroPosition">The position hero has to return to</param>
        private void MoveHero(int desiredRow, int desiredColumn, TileType heroPosition)
        {
            int desiredBoxRow = 0;
            int desiredBoxColumn = 0;
            
            // Checking that the row we want to push the box
            // is negative or positive, defines which directions to move
            if (desiredRow < 0)
            {
                desiredBoxRow = -2;
            }
            else if (desiredRow > 0)
            {
                desiredBoxRow = 2;
            }

            if (desiredColumn < 0)
            {
                desiredBoxColumn = -2;
            }
            else if (desiredColumn > 0)
            {
                desiredBoxColumn = 2;
            }

            // Getting the current tile, desiredTile(where we wanna go) and desiredBoxTile(when we push a box)
            Tile currentTile = GetTile(heroRow, heroColumn);
            Tile desiredTile = GetTile(heroRow + desiredRow, heroColumn + desiredColumn);
            Tile desiredBoxTile = null;

            if (desiredTile.Type != TileType.Wall)
            {
                desiredBoxTile = GetTile(heroRow + desiredBoxRow, heroColumn + desiredBoxColumn);
            }

            // If the next row is a none tileType then set the currentTile to whatever the hero had
            // under him before, and then set the new heroPosition to the desiredTile
            if (desiredTile.Type == TileType.None)
            {
                currentTile.SetTileType(underHeroTile);
                desiredTile.SetTileType(heroPosition);
                underHeroTile = TileType.None;

                heroRow = heroRow + desiredRow;
                heroColumn = heroColumn + desiredColumn;

                IncreaseNumberOfMoves();
            }
            else if (desiredTile.Type == TileType.Destination) // Same check for destination
            {
                currentTile.SetTileType(underHeroTile);
                underHeroTile = TileType.Destination;

                heroRow = heroRow + desiredRow;
                heroColumn = heroColumn + desiredColumn;

                desiredTile.SetTileType(heroPosition);
                IncreaseNumberOfMoves();
            }
            else if (desiredTile.Type == TileType.Box || desiredTile.Type == TileType.BlueBox) 
            {
                if (desiredBoxTile != null && desiredBoxTile.Type == TileType.None)
                {
                    currentTile.SetTileType(underHeroTile);
                    if (desiredTile.Type == TileType.Box)
                    {
                        underHeroTile = TileType.None;
                    }
                    else if (desiredTile.Type == TileType.BlueBox)
                    {
                        underHeroTile = TileType.Destination;
                    }
                    IncreaseNumberOfMoves();
                    IncreaseNumberOfPushes();

                    desiredBoxTile.SetTileType(TileType.Box);
                    desiredTile.SetTileType(heroPosition);

                    heroRow = heroRow + desiredRow;
                    heroColumn = heroColumn + desiredColumn;
                }
                else if (desiredBoxTile != null && desiredBoxTile.Type == TileType.Destination)
                {
                    currentTile.SetTileType(underHeroTile);

                    if (desiredTile.Type == TileType.Box)
                    {
                        underHeroTile = TileType.None;
                    }
                    else if (desiredTile.Type == TileType.BlueBox)
                    {
                        underHeroTile = TileType.Destination;
                    }
                    IncreaseNumberOfMoves();
                    IncreaseNumberOfPushes();

                    desiredBoxTile.SetTileType(TileType.BlueBox);
                    desiredTile.SetTileType(heroPosition);

                    heroRow = heroRow + desiredRow;
                    heroColumn = heroColumn + desiredColumn;

                    CheckIfGameIsOver();
                }
                else
                {
                    currentTile.SetTileType(heroPosition);
                }
            }
            pnlController.Focus();
        }

        /// <summary>
        /// Will check if the game is over by looping throught the array
        /// and checking if all destination tiles are filled with blue boxes tiles
        /// </summary>
        private void CheckIfGameIsOver()
        {
            int numberOfBlueBox = 0;
            for (int row = 0; row < tiles.GetLength(0); row++)
            {
                for (int col = 0; col < tiles.GetLength(1); col++)
                {
                    if (GetTile(row, col).Type == TileType.BlueBox)
                    {
                        numberOfBlueBox++;
                    }
                }
            }
            
            if (numberOfDestinations == numberOfBlueBox)
            {
                MessageBox.Show($"Game end!\n Total Moves: {numberOfMoves}\n Total Pushes: {numberOfPushes}", "Sokoban", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                ClearControls();
            }
        }

        /// <summary>
        /// Will clear the form's controls and reset the form to begin fresh
        /// </summary>
        private void ClearControls()
        {
            pnlBoard.Controls.Clear();
            txtMovesNumber.Clear();
            txtPushesNumber.Clear();
            numberOfMoves = 0;
            numberOfPushes = 0;
            numberOfDestinations = 0;
            underHeroTile = TileType.None;
            pnlController.Enabled = false;
        }


        /// <summary>
        /// Enables the use of keyboard to navigate the game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlayForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (pnlController.Enabled)
            {
                switch (e.KeyCode)
                {
                    case Keys.Up:
                        btnUp_Click(sender, e);
                        break;
                    case Keys.Down:
                        btnDown_Click(sender, e);
                        break;
                    case Keys.Left:
                        btnLeft_Click(sender, e);
                        break;
                    case Keys.Right:
                        btnRight_Click(sender, e);
                        break;
                }
            }
        }

        /// <summary>
        /// Will increase the number of pushes 
        /// the hero does and display it in the textbox
        /// </summary>
        private void IncreaseNumberOfPushes()
        {
            numberOfPushes++;
            txtPushesNumber.Text = numberOfPushes.ToString();
        }

        /// <summary>
        /// Will increase the number of moves the hero does
        /// and display it in the textbox
        /// </summary>
        private void IncreaseNumberOfMoves()
        {
            numberOfMoves++;
            txtMovesNumber.Text = numberOfMoves.ToString();
        }
    }
}