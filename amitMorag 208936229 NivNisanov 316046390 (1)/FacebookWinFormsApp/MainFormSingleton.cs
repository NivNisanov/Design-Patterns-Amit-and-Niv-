using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public sealed class MainFormSingleton
    {

        private static FormMain s_Instance;
        private static readonly object sr_LockObject = new object();

        private MainFormSingleton()
        {
                
        }

        public static FormMain Instance
        {
            get
            {
                if(s_Instance == null)
                {
                    lock(sr_LockObject)
                    {
                        if(s_Instance == null)
                        {
                            ConstructorInfo constructor = null;
                            BindingFlags bindingFlags = BindingFlags.Instance | BindingFlags.NonPublic;
                            try
                            {
                                constructor = typeof(FormMain).GetConstructor(bindingFlags, null, new Type[0], null);
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e);
                                throw;
                            }
                            s_Instance = (FormMain)constructor.Invoke(null);
                        }
                    }
                }

                return s_Instance;
            }
        }
    }
}
