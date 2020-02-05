using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LGashiAssignment1
{
    public partial class MazeDesignerForm : Form
    {
        // This property holds reference to the current tool the user clicked
        int activeTool = 0;

        // The number of rows and columns
        int rowNo;
        int colNo;

        string fileName;

        public MazeDesignerForm()
        {
            InitializeComponent();

            rdbNone.Tag = 0;
            rdbHero.Tag = 1;
            rdbWall.Tag = 2;
            rdbBox.Tag = 3;
            rdbDestination.Tag = 4;
        }

        /// <summary>
        /// When the button is clicked, will generate the game board which 
        /// depends on the number of rows and columns the user enters
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            const int MAX_SIZE = 25;

            // Will check for input validation from user 
            if (int.TryParse(txtRows.Text, out rowNo) && int.TryParse(txtColumns.Text, out colNo))
            {
                if ((rowNo <= MAX_SIZE && rowNo != 0) && (colNo <= MAX_SIZE && colNo !=0))
                {
                    ClearControls();

                    for (int row = 0; row < rowNo; row++)
                    {
                        for (int col = 0; col < colNo; col++)
                        {
                            Tile tile = new Tile(row, col);
                            tile.Click += tile_Click;

                            pnlGameBoard.Controls.Add(tile);
                        }
                    }
                    saveToolStripMenuItem.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Please provide numbers less than or equal to 25.", "Sokoban", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearControls();
                    saveToolStripMenuItem.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Please provide valid data for rows and columns (Both must be integers)", "Sokoban", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearControls();
                saveToolStripMenuItem.Enabled = false;
            }
        }

        /// <summary>
        /// Will handle the clicked tile by the user and will set
        /// the correct image or tile type
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tile_Click(object sender, EventArgs e)
        {
            Tile tile = (Tile)sender;

            switch ((TileType)activeTool)
            {
                case TileType.None:
                    tile.Image = null;
                    tile.Type = TileType.None;
                    break;
                case TileType.Hero:
                    foreach (Tile t in pnlGameBoard.Controls)
                    {
                        if (t.Type == TileType.Hero)
                        {
                            MessageBox.Show("There is already one hero in this game!","Sokoban",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                            return;
                        }
                    }
                    tile.Image = picHero.Image;
                    tile.SizeMode = PictureBoxSizeMode.Zoom;
                    tile.Type = TileType.Hero;
                    break;
                case TileType.Wall:
                    tile.Image = picWall.Image;
                    tile.Type = TileType.Wall;
                    tile.SizeMode = PictureBoxSizeMode.Normal;
                    break;
                case TileType.Box:
                    tile.Image = picBox.Image;
                    tile.SizeMode = PictureBoxSizeMode.Zoom;
                    tile.Type = TileType.Box;
                    break;
                case TileType.Destination:
                    tile.Image = picDestination.Image;
                    tile.SizeMode = PictureBoxSizeMode.Zoom;
                    tile.Type = TileType.Destination;
                    break;
            }
        }

        /// <summary>
        /// Will give the checked tool(radiobutton) from the user 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tool_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton tool = (RadioButton)sender;
            activeTool = (int)tool.Tag;
        }

        /// <summary>
        /// When clicking, will save the game as a text file in which 
        /// there will be information about the rows, columns and tile types
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveCurrentLevel();
        }

        /// <summary>
        /// Will ask user to save their work or exit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MazeDesignerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (pnlGameBoard.Controls.Count != 0 || fileName == string.Empty)
            {
                DialogResult result = MessageBox.Show("Would you like to save your work?", "Sokoban", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.Yes)
                {
                    SaveCurrentLevel();
                }
            }
        }

        /// <summary>
        /// Will exit the designer form and call the closing event which asks user to save their work
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Will save the current level into a text file 
        /// </summary>
        private void SaveCurrentLevel()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Game Files|*.game";
            saveFileDialog.DefaultExt = "game";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = saveFileDialog.FileName;
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    writer.WriteLine($"{rowNo}\n{colNo}");

                    foreach (Tile tile in pnlGameBoard.Controls)
                    {
                        writer.WriteLine(tile.SaveToFile());
                    }
                }
                MessageBox.Show("File saved successfully.","Sokoban",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            }
        }
        /// <summary>
        /// Will clear the controls such as the textboxes and game board panel
        /// </summary>
        private void ClearControls()
        {
            txtRows.Clear();
            txtColumns.Clear();
            pnlGameBoard.Controls.Clear();
            txtRows.Focus();
        }
    }
}
