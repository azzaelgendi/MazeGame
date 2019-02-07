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
/// the main for 
/// navigate to the design and play forms
/// </summary>
namespace AElgendyAssignment2
{/// <summary>
/// code logic
/// </summary>
    public partial class ControlPanelForm : Form
    {/// <summary>
    /// initialize
    /// </summary>
        public ControlPanelForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// open the design form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDesign_Click(object sender, EventArgs e)
        {
            DesignForm designForm = new DesignForm();
            designForm.Show();
        }
        /// <summary>
        /// open the play form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPlay_Click(object sender, EventArgs e)
        {
            PlayForm playForm = new PlayForm();
            playForm.Show();
        }
        /// <summary>
        /// exit the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
