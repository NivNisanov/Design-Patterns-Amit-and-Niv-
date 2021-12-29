using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class FindAndPrepareBirthdaysForm : Form
    {
        private DateTime m_StartTime;
        private DateTime m_EndTime;
        private readonly User r_UserLoggedIn;
        private readonly FacebookAppLogicFacade r_AppLogicFacade;

        public FindAndPrepareBirthdaysForm()
        {
            InitializeComponent();
            r_UserLoggedIn = FormMain.Instance.LoggedInUser;
            profilePic.Image = r_UserLoggedIn.ImageNormal;
            r_AppLogicFacade = new FacebookAppLogicFacade();
            if (r_UserLoggedIn.Albums[1].Photos[0] != null)
            {
                coverPic.Image = r_UserLoggedIn.Albums[1].Photos[0].ImageNormal;
            }
            else
            {
                coverPic.ForeColor = Color.DodgerBlue;
            }
        }

        private void searchEventsButton_Click(object sender, EventArgs e)
        {
            listOfEvents.Items.Clear();
            m_StartTime = startDateTimePicker.Value;
            m_EndTime = endDateTimePicker.Value;
            try
            {
                List<string> friendsBirthdays = r_AppLogicFacade.FetchFriendsBirthdaysAtTime(m_StartTime, m_EndTime);
                foreach (string birthday in friendsBirthdays)
                {
                    listOfEvents.Items.Add(birthday);
                }
                generateCalendarButton.Enabled = true;
                generateCalendarButton.Visible = true;
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void GenerateCalendarButton_Click(object sender, EventArgs e)
        {
            r_AppLogicFacade.ExportAndOpenCalander();
        }
    }
}
