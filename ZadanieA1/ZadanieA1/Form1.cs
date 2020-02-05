using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZadanieA1
{
    public partial class FormA1 : Form
    {
        /// <summary>
        /// variables 
        /// </summary>
        string login;
        string password;
        int counterOfLogs;

        /// <summary>
        /// constructor
        /// </summary>
        public FormA1()
        {
            InitializeComponent();
        }


        /// <summary>
        /// event method for button A1 Zaloguj
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonA1_Click(object sender, EventArgs e)
        {
            //check if number of bad logs is equal to 3 times (0, 1, 2)
            if(counterOfLogs == 2)//due to start counting from 0
            {
                TextBoxLogIn.Visible = false;//make text boxes not visible
                TextBoxPassword.Visible = false;
            }

            login = TextBoxLogIn.Text; //assign values form text box to variables
            password = TextBoxPassword.Text;

            if(login == "admin" && password == "test")//check if login and password are correct
            {
                LabelAfterLog.Visible = true;
            }
            else
            {
                counterOfLogs += 1;//else increment counter
            }


        }
    }
}
