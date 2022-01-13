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
                    throw new Exception("Imeto ne moje da e poveche ot 14 simvola");
                IdeaName = value;
            }
        }
        public string IdeaValue
        {
            get => IdeaValue;
            set
            {
                if (value.Length < 9)
                    throw new Exception("Stoinostta na ideqta trqbva da e nad 10 simvola");
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
