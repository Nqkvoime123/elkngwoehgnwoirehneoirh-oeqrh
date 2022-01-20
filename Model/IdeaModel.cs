using System;
using System.Collections.Generic;
using System.Text;

namespace elkngwoehgnwoirehneoirh_oeqrh
{
    class IdeaModel
    {
        public string IdeaName
        {
            get => IdeaName;
            set
            {
                if (value.Length > 15)
                    throw new Exception("Името не може да  е повече от 14 символа");
                IdeaName = value;
            }
        }
        public string IdeaValue
        {
            get => IdeaValue;
            set
            {
                if (value.Length < 9)
                    throw new Exception("Стойността на идеята трябва да е над 10 символа");
                IdeaValue = value;
            }
        }
        string ideaName;
        string ideaValue;

        public int ValueCount;
        public void CountValue()
        {
            ValueCount = ideaValue.Length;
        }
    }
}
