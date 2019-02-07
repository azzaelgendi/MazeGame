/*Assignment 2
 * Game Programming
 * Play the Game 
 * Revision History
 * Created by:Azza Elgendy
 * Section 2
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
/// used at playform
/// </summary>
namespace AElgendyAssignment2
{/// <summary>
/// to assign configration to the tile
/// 
/// </summary>
    class TileConfig
    {/// <summary>
     /// the props.
     /// </summary>
        public Bitmap Image { get; set; }
        public string Category { get; set; }
        public string TileType { get; set; }
    }
}
