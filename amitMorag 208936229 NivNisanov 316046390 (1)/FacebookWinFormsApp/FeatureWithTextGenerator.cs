using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    class FeatureWithTextGenerator
    {
        public TextGenerator m_textGenerator { get;set; }
        public FeatureWithTextGenerator(String i_GeneratorToCreate)
        {
            if (i_GeneratorToCreate.Equals("comment"))
            {
                m_textGenerator = new CommentGenerator();
            }
            else if (i_GeneratorToCreate.Equals("birthdayWishesToCal"))
            {
                m_textGenerator = new BirthdayWishGenerator();
            }
        }
    }
}
