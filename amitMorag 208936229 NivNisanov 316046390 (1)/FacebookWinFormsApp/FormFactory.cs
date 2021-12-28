using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System.Text.RegularExpressions;


namespace BasicFacebookFeatures
{
    public static class FormFactory
    {
        public static Form createForm(string i_formToCreate)
        {
            Form formToReturn = null;
            if (i_formToCreate.Equals("generateComment"))
            {
                formToReturn =  new FormGenerateComment();
            }

            if (i_formToCreate.Equals("findAndPrepareBirthdayWishesToCal"))
            {
                formToReturn =  new FindAndPrepareBirthdaysForm();
            }
            return formToReturn; 
        }
    }
}
