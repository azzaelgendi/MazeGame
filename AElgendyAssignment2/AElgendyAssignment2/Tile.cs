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
/// <summary>
/// tile class used at design form
/// </summary>
namespace AElgendyAssignment2
{/// <summary>
/// inherit from picture box
/// </summary>
    public class Tile : PictureBox
    {/// <summary>
     ///  variables
     /// </summary>
        private const int WIDTH = 50;
        private const int HEIGHT = 50;
        public int pictureIndex { get; set; } = 0;
        /// <summary>
        /// constructor
        /// </summary>
        public Tile()
        {
            this.Width = WIDTH;
            this.Height = HEIGHT;
            this.Visible = true;
            this.BorderStyle
                = BorderStyle.FixedSingle;
            this.SizeMode
                = PictureBoxSizeMode.Zoom;//fit photo
            this.BringToFront();
        }
        /// <summary>
        /// function switch the images
        /// </summary>
        /// <param name="PictureIndex"></param>
        public void TileIndex(int PictureIndex)
        {
            this.pictureIndex = PictureIndex;
            //storing the photo index to pictureBox tag
            //assign picture to picturebox
            switch (pictureIndex)
            {
                case 0:
                    if (this.Image != null)
                    {
                        this.Image.Dispose();
                        this.Image = null;
                        this.Tag = pictureIndex.ToString();
                    }
                    break;
                case 1:
                    this.Tag = PictureIndex.ToString();
                    this.Image = Properties.Resources.wall2;
                    break;
                case 2:
                    this.Tag = PictureIndex.ToString();
                    this.Image = Properties.Resources.doorBlue;
                    break;
                case 3:
                    this.Tag = PictureIndex.ToString();
                    this.Image = Properties.Resources.doorYellow;
                    break;
                case 4:
                    this.Tag = PictureIndex.ToString();
                    this.Image = Properties.Resources.doorRed;
                    break;
                case 5:
                    this.Tag = PictureIndex.ToString();
                    this.Image = Properties.Resources.doorGreen;
                    break;
                case 6:
                    this.Tag = PictureIndex.ToString();
                    this.Image = Properties.Resources.boxesGreen;
                    break;
                case 7:
                    this.Tag = PictureIndex.ToString();
                    this.Image = Properties.Resources.boxesYellow;
                    break;
                case 8:
                    this.Tag = PictureIndex.ToString();
                    this.Image = Properties.Resources.boxesBlue;
                    break;
                case 9:
                    this.Tag = PictureIndex.ToString();
                    this.Image = Properties.Resources.boxesRed;
                    break;
                default:
                    break;
            }
        }

    }
}
