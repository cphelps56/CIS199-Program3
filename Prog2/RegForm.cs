// Program 3
// CIS 199-01
// Due: 4/7/15
// By: Colin Phelps

// Also by: Andrew Wright

// This application calculates the earliest registration date
// and time for an undergraduate student given their credit hours
// and last name.
// Decisions based on UofL Spring 2015 Priority Registration Schedule

// Solution 3
// This solution keeps the first letter of the last name as a char
// and uses if/else logic for the times.
// It uses defined strings for the dates and times to make it easier
// to maintain.
// It performs validation on the entered last name.
// It only uses programming elements introduced in the text or
// in class.
// This solution takes advantage of the fact that there really are
// only two different time patterns used. One for juniors and seniors
// and one for sophomores and freshmen. The pattern for sophomores
// and freshmen is complicated by the fact the certain letter ranges
// get one date and other letter ranges get another date.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Prog2
{
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
        }
        // Precondition: Press the button, must have at least one character in the textbox.
        // Postcondition: The registration date and time corresponding with the users grade and last name will be displayed.
        private void findRegTimeBtn_Click(object sender, EventArgs e)
        {
            const string DAY1 = "April 1";  // 1st day of registration
            const string DAY2 = "April 2"; // 2nd day of registration
            const string DAY3 = "April 3"; // 3rd day of registration
            const string DAY4 = "April 6"; // 4th day of registration
            const string DAY5 = "April 7"; // 5th day of registration
            const string DAY6 = "April 8"; // 6th day of registration

            const string TIME1 = "8:30 AM";  // 1st time block
            const string TIME2 = "10:00 AM"; // 2nd time block
            const string TIME3 = "11:30 AM"; // 3rd time block
            const string TIME4 = "2:00 PM";  // 4th time block
            const string TIME5 = "4:00 PM";  // 5th time block

            string lastNameStr;       // Entered last name
            char lastNameLetterCh;    // First letter of last name, as char
            string dateStr = "Error"; // Holds date of registration
            string timeStr = "Error"; // Holds time of registration

            char[] jsLowerLimit = {'A','E','J','P','T'}; // Holds the lower limits of the letter groups for juniors and seniors
            string[] jsTimes = { TIME2, TIME3, TIME4, TIME5, TIME1 }; // Holds the time slots for juniors and seniors

            char[] fsLowerLimit = { 'A', 'C', 'E', 'G', 'J', 'M', 'P', 'R', 'T', 'W' }; // Holds the lower limits of the letter groups for freshmen and sophomores
            string[] fsTimes = { TIME3, TIME4, TIME5, TIME1, TIME2, TIME3, TIME4, TIME5, TIME1, TIME2 }; // Holds the time slots for freshmen and sophomores

            int sub; // Holds the element number for the arrays

            lastNameStr = lastNameTxt.Text;

            if (lastNameStr == "") // Empty text box
                MessageBox.Show("Please enter last name!");
            else
            {
                lastNameLetterCh = lastNameStr[0]; // As in text, p. 466-467

                if (!char.IsLetter(lastNameLetterCh)) // Is it a letter or not?
                    MessageBox.Show("Please ensure a letter is in first position of last name!");
                else
                {
                    lastNameLetterCh = char.ToUpper(lastNameLetterCh); // Ensure upper case

                    // Juniors and Seniors share same schedule but different days
                    if (juniorBtn.Checked || seniorBtn.Checked)
                    {
                        if (seniorBtn.Checked)
                            dateStr = DAY1;
                        else // Must be juniors
                            dateStr = DAY2;

                        sub = jsLowerLimit.Length - 1; // Assigns the correct amount to the sub variable

                        while (sub >= 0 && lastNameLetterCh < jsLowerLimit[sub]) // Finds the correct time for the given last name letter
                            sub--;
                        timeStr = jsTimes[sub]; // Assigns the correct time slot to the timeStr variable
                        
                    }
                    // Sophomores and Freshmen
                    else // Must be soph/fresh
                    {
                        if (sophBtn.Checked)
                        {
                            // G-S on one day
                            if ((lastNameLetterCh >= 'G') && // >= G and
                                (lastNameLetterCh <= 'S'))   // <= S
                                dateStr = DAY4;
                            else // All other letters on previous day
                                dateStr = DAY3;
                        }
                        else // must be freshman
                        {
                            // G-S on one day
                            if ((lastNameLetterCh >= 'G') && // >= G and
                                (lastNameLetterCh <= 'S'))   // <= S
                                dateStr = DAY6;
                            else // All other letters on previous day
                                dateStr = DAY5;
                        }

                        sub = fsLowerLimit.Length - 1; 

                        while (sub >= 0 && lastNameLetterCh < fsLowerLimit[sub])
                            sub--;
                        timeStr = fsTimes[sub];
                    }

                    dateTimeLbl.Text = dateStr + " at " + timeStr;
                }
            }
        }
    }
}
