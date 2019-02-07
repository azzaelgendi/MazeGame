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

namespace AElgendyAssignment2
{
    public partial class DesignForm : Form
    {
        Tile.ImageType imageType = Tile.ImageType.None;
        public int pictureIndex = 0;
        //for the size of the grid
        public int rowsNumber = 0;
        public int colNumber = 0;
        public int x;
        public int y;
        public int VGAP;
        //array of pictureboxes
        Tile[,] pictureBoxMatrix;

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public DesignForm()
        {
            InitializeComponent();
        }
        public void GetImage()
        {
            //declaring local variables
            x = 50;
            y = 50;
            VGAP = 200;
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
                    MessageBox.Show("The level created successfully  " +
                     "select the desired building block");
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

        private void PictureBox_Click1(object sender, EventArgs e)
        {
            PictureBox pictureBoxImage = (PictureBox)sender;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            GetImage();
        }

        private void DesignForm_Load(object sender, EventArgs e)
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

        private void save(string fileName)
        {
            #region Save to File 
            //  declare the local variables like  to be saved
            string data = "";
            // add first line to represent the grid size colxrow
            data = colNumber + ":" + rowsNumber + ":";
            // navigate the grid , get which picture index in  current cell
            //  get the picture set so 
            //, adapted the click on image box func (PictureBox_Click1)
            //  used the tag property to store the selected PIC :) 
            for (int k = 0; k < pictureBoxMatrix.GetLength(0); k++)
            {
                for (int l = 0; l < pictureBoxMatrix.GetLength(1); l++)
                {
                    //adding delimitar and save the values in one string
                    data += k + ":" + l + ":"
                         + (pictureBoxMatrix[k, l].Tag
                         == null ? "0" : pictureBoxMatrix[k, l].Tag.ToString())
                         + ":";
                }
            }
            //split the saved string into string array, write it to the file
            string[] line = data.Split(':');
            try
            {
                StreamWriter writer = new StreamWriter(fileName);
                // write data to file 
                for (int i = 0; i < line.Length; i++)
                {
                    writer.WriteLine(line[i]);
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

        private void btnNone_Click(object sender, EventArgs e)
        {

            imageType = Tile.ImageType.None;
            pictureIndex = 0;
        }

        private void btnWall_Click(object sender, EventArgs e)
        {
            imageType = Tile.ImageType.wall;
            pictureIndex = 1;
        }
    }
}
