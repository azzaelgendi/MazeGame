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
/// Class contain the code
/// to design the game level
/// </summary>
namespace AElgendyAssignment2
{/// <summary>
/// design the game
/// </summary>
    public partial class DesignForm : Form
    {/// <summary>
     /// declare the global variables
     /// </summary>
        public int pictureIndex = 0;
        //for the size of the grid
        public int rowsNumber = 0;
        public int colNumber = 0;
        public int x;
        public int y;
        public int VGAP;
        //array of pictureboxes
        Tile[,] pictureBoxMatrix;
        /// <summary>
        ///  method executes when menu exit clicked
        /// close the for
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Constructor of the form
        /// initialize 
        /// </summary>
        public DesignForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// create the grid add the image
        /// </summary>
        public void GetImage()
        {
            //declaring local variables
            x = 50;
            y = 50;
            VGAP = 400;
            //getting array size from textboxes

            try
            {
                //Convert input values to numeric variables.

                rowsNumber = int.Parse(txtRows.Text);
                colNumber = int.Parse(txtColumn.Text);
                if (colNumber <= 0 || rowsNumber <= 0)
                {
                    throw new Exception(" rows and colunms"
                        + " Must be more than Zero");
                }
                pictureBoxMatrix = new Tile[colNumber, rowsNumber];
                try
                {
                    for (int i = 0; i < colNumber; i++)
                    {
                        for (int j = 0; j < rowsNumber; j++)
                        {
                            pictureBoxMatrix[i, j] = new Tile();
                            pictureBoxMatrix[i, j].Location
                                = new Point(i * x + VGAP, j * x + y);

                            //generate the click event for the picturebox
                            pictureBoxMatrix[i, j].Click += PictureBox_Click1;
                            this.Controls.Add(pictureBoxMatrix[i, j]);
                        }
                    }
                    MessageBox.Show("The level created successfully"
                        + "select the desired building block");
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
        /// method executes when the picturebox is clicked
        /// </summary>
        /// <param name="sender">tile</param>
        /// <param name="e"></param>
        private void PictureBox_Click1(object sender, EventArgs e)
        {
            Tile tile = new Tile();
            tile = (Tile)sender;
            tile.TileIndex(pictureIndex);

        }
        /// <summary>
        /// excutes the generate when click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            GetImage();

        }
        /// <summary>
        /// load images into buttons
        /// </summary>
        public void ButtonImages()
        {
            this.btnBlueBox.Image
               = (Image)(new Bitmap(Properties.Resources.boxesBlue
               , new Size(70, 60)));
            this.btnBlueDoor.Image
                = (Image)(new Bitmap(Properties.Resources.doorBlue
                , new Size(70, 60)));
            this.btnGreenBox.Image
                = (Image)(new Bitmap(Properties.Resources.boxesGreen
                , new Size(70, 60)));
            this.btnGreenDoor.Image
                = (Image)(new Bitmap(Properties.Resources.doorGreen
                , new Size(70, 60)));
            this.btnRedDoor.Image
                = (Image)(new Bitmap(Properties.Resources.doorRed
                , new Size(70, 60)));
            this.btnRedBox.Image
                = (Image)(new Bitmap(Properties.Resources.boxesRed
                , new Size(70, 60)));
            this.btnYellowDoor.Image
                = (Image)(new Bitmap(Properties.Resources.doorYellow
                , new Size(70, 60)));
            this.btnYellowBox.Image
                = (Image)(new Bitmap(Properties.Resources.boxesYellow
                , new Size(70, 60)));
            this.btnWall.Image
                = (Image)(new Bitmap(Properties.Resources.wall2
                , new Size(70, 60)));
        }
        /// <summary>
        /// this method excutes when form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DesignForm_Load(object sender, EventArgs e)
        {
            ButtonImages();
        }
        /// <summary>
        /// method to save the file
        /// </summary>
        /// <param name="fileName"></param>
        private void save(string fileName)
        {
            #region Save to File 

            // navigate the grid , get which picture index in  current cell
            //  get the picture set so 
            //, adapted the click on image box func (PictureBox_Click1)
            //  used the tag property to store the selected PIC :) 

            //i will declare list and save values inside better 
            List<int> list = new List<int>();
            // add row and cols 
            list.Add(rowsNumber);
            list.Add(colNumber);

            var item = 0;
            for (int k = 0; k < pictureBoxMatrix.GetLength(0); k++)
            {
                for (int l = 0; l < pictureBoxMatrix.GetLength(1); l++)
                {
                    item = pictureBoxMatrix[k, l].Tag
                        == null ? 0 : int.Parse(pictureBoxMatrix[k, l]
                        .Tag.ToString());
                    list.Add(item);
                }
            }

            try
            {
                StreamWriter writer = new StreamWriter(fileName);


                //loop over the list and add 
                foreach (var i in list)
                {
                    writer.WriteLine(i);
                }

                writer.Close();//close the writer 
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error while writing to the file"
                    + ex.Message);
            }
            #endregion
        }
        /// <summary>
        /// menu to open save dialoge
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //declare string carry the file name to be saved 
            string fileName = "";
            //open dialog
            DialogResult r = dlgSave.ShowDialog();
            //switch options for dialoge result
            switch (r)
            {
                case DialogResult.None:
                    break;
                case DialogResult.OK:
                    //handel errors while saving
                    try
                    {
                        fileName = dlgSave.FileName;
                        save(fileName);
                        MessageBox.Show("Level Saved");//confirm file saving
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error in file save" + ex.Message);
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
        #region buttons events 
        /// <summary>
        /// give the picture boxes the desired image
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNone_Click(object sender, EventArgs e)
        {
            pictureIndex = 0;
        }
        /// <summary>
        /// for wall
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWall_Click(object sender, EventArgs e)
        {
            pictureIndex = 1;

        }
        /// <summary>
        /// for blue door
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBlueDoor_Click(object sender, EventArgs e)
        {
            pictureIndex = 2;
        }
        /// <summary>
        /// for yellow door
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnYellowDoor_Click(object sender, EventArgs e)
        {
            pictureIndex = 3;
        }
        /// <summary>
        /// for red door
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRedDoor_Click(object sender, EventArgs e)
        {
            pictureIndex = 4;
        }
        /// <summary>
        /// for green door
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGreenDoor_Click(object sender, EventArgs e)
        {
            pictureIndex = 5;
        }
        /// <summary>
        /// for blue box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBlueBox_Click(object sender, EventArgs e)
        {
            pictureIndex = 8;
        }
        /// <summary>
        /// for red box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRedBox_Click(object sender, EventArgs e)
        {
            pictureIndex = 9;
        }
        /// <summary>
        /// for green box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGreenBox_Click(object sender, EventArgs e)
        {
            pictureIndex = 6;
        }
        /// <summary>
        /// for yellow box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnYellowBox_Click(object sender, EventArgs e)
        {
            pictureIndex = 7;
        }
        #endregion
    }
}
