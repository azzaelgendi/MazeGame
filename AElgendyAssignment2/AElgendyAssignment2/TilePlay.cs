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
/// This Class inherit picturebox
/// using it in the play form
/// </summary>
namespace AElgendyAssignment2
{
    /// <summary>
    /// gives the additional specifications 
    /// </summary>
    public class TilePlay : PictureBox
    {
        /// <summary>
        /// declare variables
        /// </summary>
        private const int WIDTH = 50;
        private const int HEIGHT = 50;
        //public int pictureIndex { get; set; } = 0;
        public int Row { get; set; }
        public int Col { get; set; }
        public string TileType { get; set; }
        public string TileCategory { get; set; }
        /// <summary>
        /// constructor
        /// </summary>
        public TilePlay()
        {

            this.Width = WIDTH;
            this.Height = HEIGHT;
            this.Visible = true;
            this.BorderStyle
                = BorderStyle.None;
            this.SizeMode
                = PictureBoxSizeMode.Zoom;//fit photo
            this.BringToFront();

        }
    }
}
