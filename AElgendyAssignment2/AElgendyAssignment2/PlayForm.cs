/*Assignment 2
 * Game Programming
 * Play the Game 
 * Revision History
 * Created by:Azza Elgendy
 * Section 1
 * created on October15th 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
/// <summary>
/// the code will load the saved file
/// create the grid
/// play the game
/// </summary>
namespace AElgendyAssignment2
{/// <summary>
/// play form which load the game to play
/// </summary>
    public partial class PlayForm : Form
    {/// <summary>
     /// declare the global variables
     /// </summary>
        //for the size of the grid
        public int rowsNumber = 0;
        public int colNumber = 0;
        //for location of the grid
        public int x;
        public int y;
        public int VGAP;
        //for reading the saved game
        string[] lines;
        //global variable counters
        int counter;
        int boxCounter = 0;
        int movesCounter = 0;
        TilePlay tile = new TilePlay();
        TilePlay[,] pictureBoxMatrix; //2d array of pictureboxes
        Dictionary<int, TileConfig> images
            = new Dictionary<int, TileConfig>();
        /// <summary>
        /// Read the saved file 
        /// </summary>
        /// <param name="fileName">string filename</param>
        private void load(string fileName)
        {
            //read all lines
            try
            {
                lines = File.ReadAllLines(fileName);
                //get first two lines for rows, cols
                try
                {
                    rowsNumber = int.Parse(lines[0]);
                    colNumber = int.Parse(lines[1]);
                }
                catch (FormatException ex)
                {

                    MessageBox.Show("file must be numbers only" + ex.Message);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error reading the file" + ex.Message);
            }
            counter = 2; //this to keep the sequence of images 
            GetImage();
        }
        /// <summary>
        /// will remove the grid from the form 
        /// </summary>
        public void RemoveGrid()
        {
            for (int i = 0; i < colNumber; i++)
            {
                for (int j = 0; j < rowsNumber; j++)
                {
                    this.Controls.Remove(pictureBoxMatrix[i, j]);
                }
            }
            DisableButtons();
            movesCounter = 0;
            labelShowMoves.Text = "";
        }
        /// <summary>
        /// function to create the level load the images
        /// </summary>
        public void GetImage()
        {
            //declaring local variables
            x = 50;
            y = 50;
            VGAP = 100;

            //the dictionary of images
            //assign type &catogery to the tile
            images[0] = new TileConfig()
            {
                Image = null
                ,TileType = "none"
                ,Category = "none"
            };
            images[1] = new TileConfig()
            {
                Image = Properties.Resources.wall2
                ,TileType = "wall"
                ,Category = "wall"
            };
            images[2] = new TileConfig()
            {
                Image = Properties.Resources.doorBlue
                ,TileType = "door"
                ,Category = "blue"
            };
            images[3] = new TileConfig()
            {
                Image = Properties.Resources.doorYellow
                ,TileType = "door"
                ,Category = "yellow"
            };
            images[4] = new TileConfig()
            {
                Image = Properties.Resources.doorRed
                ,TileType = "door"
                ,Category = "red"
            };
            images[5] = new TileConfig()
            {
                Image = Properties.Resources.doorGreen
                ,TileType = "door"
                , Category = "green"
            };
            images[6] = new TileConfig()
            {
                Image = Properties.Resources.boxesGreen
                ,TileType = "box"
                ,Category = "green"
            };
            images[7] = new TileConfig()
            {
                Image = Properties.Resources.boxesYellow
                ,TileType = "box"
                ,Category = "yellow"
            };
            images[8] = new TileConfig()
            {
                Image = Properties.Resources.boxesBlue
                ,TileType = "box"
                ,Category = "blue"
            };
            images[9] = new TileConfig()
            {
                Image = Properties.Resources.boxesRed
                ,TileType = "box"
                ,Category = "red"
            };
            try
            {//create the grid load the image
                pictureBoxMatrix = new TilePlay[colNumber, rowsNumber];
                try
                {
                    for (int i = 0; i < colNumber; i++)
                    {
                        for (int j = 0; j < rowsNumber; j++)
                        {
                            var config = images[int.Parse(lines[counter])];
                            TilePlay myTile = new TilePlay();
                            myTile.Location
                                = new Point(i * x + VGAP, j * x + y);
                            myTile.Image = config.Image;
                            myTile.TileType = config.TileType;
                            myTile.TileCategory = config.Category;
                            myTile.Row = j;
                            myTile.Col = i;
                            myTile.Click += PictureBox_Click;

                            //check the number of boxes
                            if (myTile.TileType == "box")
                            {

                                boxCounter++;

                            }
                            pictureBoxMatrix[i, j] = myTile;
                            this.Controls.Add(pictureBoxMatrix[i, j]);

                            counter++;

                        }
                    }
                    MessageBox.Show("The level created successfully");
                    //disable load menu
                    loadGameToolStripMenuItem.Enabled = false;
                    //enable the navigation buttons
                    this.btnUp.Enabled = true;
                    this.btnRight.Enabled = true;
                    this.btnleft.Enabled = true;
                    this.btnDown.Enabled = true;
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error in creating the grid "
                        + ex.Message);
                }
            }
            catch (FormatException ex)
            {
                //when input is not number
                MessageBox.Show("Invalid format: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Entries " + ex.Message);
            }
        }
        /// <summary>
        /// make the tile click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBox_Click(object sender, EventArgs e)
        {

            tile = (TilePlay)sender;
        }
        /// <summary>
        /// load the form comp.
        /// </summary>
        public PlayForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// open dialog to loal the file
        /// </summary>
        /// <param name="fileName">loacl string carry file name</param>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadGameToolStripMenuItem_Click(
            object sender, EventArgs e)
        {
            DialogResult r = dlgLoad.ShowDialog();
            switch (r)
            {
                case DialogResult.None:
                    break;
                case DialogResult.OK:
                    try
                    {
                        string fileName = dlgLoad.FileName;
                        load(fileName);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error in file load");
                    }
                    break;
                case DialogResult.Cancel:
                    break;
                case DialogResult.Abort:
                    break;
                case DialogResult.Retry:
                    break;
                case DialogResult.Ignore:
                    break;
                case DialogResult.Yes:
                    break;
                case DialogResult.No:
                    break;
                default:
                    break;
            }
        }
        /// <summary>
        /// Exit the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// disable navigation buttons
        /// </summary>
        public void DisableButtons()
        {
            loadGameToolStripMenuItem.Enabled = true;
            this.btnleft.Enabled = false;
            this.btnUp.Enabled = false;
            this.btnRight.Enabled = false;
            this.btnDown.Enabled = false;
            labelShowMoves.Enabled = false;
            labelShowMoves.Text = 0.ToString();
        }
        /// <summary>
        /// assign 0 type
        /// </summary>
        public void TileConfigration()
        {
            TileConfig tc = images[0];
            tile.Image = tc.Image;
            tile.TileCategory = tc.Category;
            tile.TileType = tc.TileType;
            tile.Click -= PictureBox_Click;
            tile.BorderStyle = BorderStyle.None;
            //tile.BackColor = Color.Beige;
        }
        /// <summary>
        /// load the game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlayForm_Load(object sender, EventArgs e)
        {//load the image of the navigation buttons
            
            DisableButtons();
            this.btnDown.Image
                = (Image)(new Bitmap(Properties.Resources.dawn
                , new Size(30, 30)));
            this.btnRight.Image
              = (Image)(new Bitmap(Properties.Resources.right
              , new Size(30, 30)));
            this.btnleft.Image
              = (Image)(new Bitmap(Properties.Resources.left
              , new Size(30, 30)));
            this.btnUp.Image
              = (Image)(new Bitmap(Properties.Resources.up
              , new Size(30, 30)));
        }
        #region Navigation buttons
        /// <summary>
        /// move up
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUp_Click(object sender, EventArgs e)
        {
            bool bttnUp = true;
            movesCounter++;
            labelShowMoves.Text = movesCounter.ToString();
            if (tile.TileType == "box")//check the type
            {//make the movement until stopped by another tile
                do
                {
                    TilePlay adj = pictureBoxMatrix[tile.Col, tile.Row - 1];
                    //check the seclected tile click
                    if (tile.TileCategory
                        == adj.TileCategory && adj.TileType == "door")
                    {//remove the box
                        bttnUp = false;
                        TileConfigration();
                        //this.Controls.Remove(tile);
                        boxCounter--;
                        if (boxCounter == 0)
                        {
                            MessageBox.Show("Game Finished");
                            RemoveGrid();
                        }
                    }

                    if (adj.TileCategory == "none")
                    {

                        adj.Image = tile.Image;
                        adj.TileCategory = tile.TileCategory;
                        adj.TileType = tile.TileType;

                        pictureBoxMatrix[tile.Col, tile.Row].Image = images[0].Image;
                        pictureBoxMatrix[tile.Col, tile.Row].TileCategory = images[0].Category;
                        pictureBoxMatrix[tile.Col, tile.Row].TileType = images[0].TileType;

                        tile = adj;
                    }
                    else
                    {
                        bttnUp = false;
                    }
                } while (bttnUp);

            }
            else
            {
                MessageBox.Show("Select box first");
            }
        }
        /// <summary>
        /// move left
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnleft_Click(object sender, EventArgs e)
        {
            movesCounter++;
            labelShowMoves.Text = movesCounter.ToString();
            bool bttnLeft = true;
            if (tile.TileType == "box")
            {
                do
                {

                    TilePlay adj = pictureBoxMatrix[tile.Col - 1, tile.Row];
                    if (tile.TileCategory
                        == adj.TileCategory && adj.TileType == "door")
                    {
                        bttnLeft = false;
                        TileConfigration();
                        //this.Controls.Remove(tile);
                        boxCounter--;
                        if (boxCounter == 0)
                        {
                            MessageBox.Show("Game Finished");
                            RemoveGrid();

                        }
                    }
                    if (adj.TileCategory == "none")
                    {

                        adj.Image = tile.Image;
                        adj.TileCategory = tile.TileCategory;
                        adj.TileType = tile.TileType;

                        pictureBoxMatrix[tile.Col, tile.Row].Image = images[0].Image;
                        pictureBoxMatrix[tile.Col, tile.Row].TileCategory = images[0].Category;
                        pictureBoxMatrix[tile.Col, tile.Row].TileType = images[0].TileType;

                        tile = adj;
                    }
                    else
                    {
                        bttnLeft = false;
                    }
                } while (bttnLeft);
            }
            else
            {
                MessageBox.Show("select box first");
            }
        }
        /// <summary>
        /// move right
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRight_Click(object sender, EventArgs e)
        {
            movesCounter++;
            labelShowMoves.Text = movesCounter.ToString();
            bool bttnRight = true;
            if (tile.TileType == "box")
            {
                do
                {
                    TilePlay adj = pictureBoxMatrix[tile.Col + 1, tile.Row];
                    if (adj.TileCategory == "none")
                    {
                        adj.Image = tile.Image;
                        adj.TileCategory = tile.TileCategory;
                        adj.TileType = tile.TileType;

                        pictureBoxMatrix[tile.Col, tile.Row].Image = images[0].Image;
                        pictureBoxMatrix[tile.Col, tile.Row].TileCategory = images[0].Category;
                        pictureBoxMatrix[tile.Col, tile.Row].TileType = images[0].TileType;
                        tile = adj;
                    }
                    else
                    {
                        bttnRight = false;
                    }
                    if (tile.TileCategory
                        == adj.TileCategory && adj.TileType == "door")
                    {
                        bttnRight = false;
                        TileConfigration();
                        // this.Controls.Remove(tile);
                        boxCounter--;
                        if (boxCounter == 0)
                        {
                            MessageBox.Show("Game Finished");
                            RemoveGrid();
                            
                        }
                    } 
                } while (bttnRight);
            }
            else
            {
                MessageBox.Show("select box first");
            }
        }
        /// <summary>
        /// Move Dawn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDown_Click(object sender, EventArgs e)
        {
            movesCounter++;
            labelShowMoves.Text = movesCounter.ToString();
            bool btnDwn = true;
            if (tile.TileType == "box")
            {
                do
                {

                    TilePlay adj = pictureBoxMatrix[tile.Col, tile.Row + 1];
                    if (tile.TileCategory
                        == adj.TileCategory && adj.TileType == "door")
                    {
                        btnDwn = false;
                        TileConfigration();
                        //this.Controls.Remove(tile);
                        boxCounter--;
                        if (boxCounter == 0)
                        {
                            MessageBox.Show("Game Finished");
                            RemoveGrid();

                        }
                    }
                    if (adj.TileCategory == "none")
                    {

                        adj.Image = tile.Image;
                        adj.TileCategory = tile.TileCategory;
                        adj.TileType = tile.TileType;

                        pictureBoxMatrix[tile.Col, tile.Row].Image = images[0].Image;
                        pictureBoxMatrix[tile.Col, tile.Row].TileCategory = images[0].Category;
                        pictureBoxMatrix[tile.Col, tile.Row].TileType = images[0].TileType;

                        tile = adj;
                    }
                    else
                    {
                        btnDwn = false;
                    }
                } while (btnDwn);
            }
            else
            {
                MessageBox.Show("select box first");
            }
        }
        #endregion
    }
}
