using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public sealed class MainFormSingleton
    {
        private static readonly FormMain sr_Instance = new FormMain();

        private MainFormSingleton()
        {
                
        }

        public static FormMain Instance
        {
            get
            {
                return sr_Instance;
            }
        }
    }
}
