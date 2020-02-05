using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZadanieA2
{
    public partial class FormA2 : Form
    {
        /// <summary>
        /// constructor
        /// </summary>
        public FormA2()
        {
            InitializeComponent();
        }

        /// <summary>
        /// event method of button A2 Start
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonA2_Click(object sender, EventArgs e)
        {
            TimerOfStartButton.Enabled = true; //start intervals of timer
        }

        /// <summary>
        /// event of timer intervals
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimerOfStartButton_Tick(object sender, EventArgs e)
        {
            ButtonA2.Location = new System.Drawing.Point(ButtonA2.Location.X + 5, ButtonA2.Location.Y - 5);//5 px to the right and 5px up
        }
    }
}
