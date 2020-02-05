using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LGashiAssignment1
{
    enum TileType
    {
        None,
        Hero,
        Wall,
        Box,
        Destination,
        HeroLeft,
        HeroRight,
        BlueBox,
    }

    class Tile : PictureBox
    {
        int row;
        int col;

        /// <summary>
        /// This property gets the types of tiles and lets the user
        /// to set their values in order to make the game
        /// </summary>
        public TileType Type { get; set; }

        const int OFFSET = 20;
        const int TILE_SIZE = 50;

        /// <summary>
        /// Will instantiate a tile by passing the values for row and column
        /// </summary>
        /// <param name="row">The number of row</param>
        /// <param name="col">The number of column</param>
        public Tile(int row, int col)
        {
            this.row = row;
            this.col = col;
            Type = TileType.None;

            this.Size = new Size(TILE_SIZE, TILE_SIZE);

            int x = OFFSET + (col * TILE_SIZE);
            int y = OFFSET + (row * TILE_SIZE);

            this.Location = new Point(x, y);
            this.BorderStyle = BorderStyle.Fixed3D;
        }

        /// <summary>
        /// Will instantiate a tile by passing the values for row, col and tileType
        /// </summary>
        /// <param name="row">The number of rows</param>
        /// <param name="col">The number of column</param>
        /// <param name="tileType">The type of tile</param>
        public Tile(int row, int col, int tileType)
        {

            this.row = row;
            this.col = col;
            Type = TileType.None;

            SetTileType((TileType)tileType);
            
            this.Size = new Size(TILE_SIZE, TILE_SIZE);

            int x = OFFSET + (col * TILE_SIZE);
            int y = OFFSET + (row * TILE_SIZE);

            this.Location = new Point(x, y);
        }

        /// <summary>
        /// Sets the type of tile based on the parameter of tile we pass in
        /// </summary>
        /// <param name="tileType">The type of tile</param>
        public void SetTileType(TileType tileType)
        {
            switch ((TileType)tileType)
            {
                case TileType.None:
                    this.Image = null;
                    this.Type = TileType.None;
                    break;
                case TileType.Hero:
                    this.Image = LGashiAssignment1.Properties.Resources.gaby;
                    this.SizeMode = PictureBoxSizeMode.Zoom;
                    this.Type = TileType.Hero;
                    break;
                case TileType.Wall:
                    this.Image = LGashiAssignment1.Properties.Resources.wall_tile;
                    this.Type = TileType.Wall;
                    this.SizeMode = PictureBoxSizeMode.Normal;
                    this.BorderStyle = BorderStyle.Fixed3D;                    
                    break;
                case TileType.Box:
                    this.Image = LGashiAssignment1.Properties.Resources.box_tile;
                    this.SizeMode = PictureBoxSizeMode.Zoom;
                    this.Type = TileType.Box;
                    break;
                case TileType.Destination:
                    this.Image = LGashiAssignment1.Properties.Resources.yellow;
                    this.SizeMode = PictureBoxSizeMode.Zoom;
                    this.Type = TileType.Destination;
                    break;
                case TileType.HeroLeft:
                    this.Image = LGashiAssignment1.Properties.Resources.gabyLeft;
                    this.SizeMode = PictureBoxSizeMode.Zoom;
                    this.Type = TileType.HeroLeft;
                    break;
                case TileType.HeroRight:
                    this.Image = LGashiAssignment1.Properties.Resources.gabyRight;
                    this.SizeMode = PictureBoxSizeMode.Zoom;
                    this.Type = TileType.HeroRight;
                    break;
                case TileType.BlueBox:
                    this.Image = LGashiAssignment1.Properties.Resources.blueBox;
                    this.SizeMode = PictureBoxSizeMode.Zoom;
                    this.Type = TileType.BlueBox;
                    break;
            }
        }

        /// <summary>
        /// Will return a string which is the way we want to save our 
        /// information of the game to the text file
        /// </summary>
        /// <returns></returns>
        public string SaveToFile()
        {
            return $"{row}\n{col}\n{(int)Type}";
        }

        

    }
}
