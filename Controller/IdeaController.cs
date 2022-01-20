using System;
using System.Collections.Generic;
using System.Text;

namespace elkngwoehgnwoirehneoirh_oeqrh
{
    class IdeaController
    {
        Display display;
        IdeaModel idea;

        public IdeaController()
        {
            display = new Display();
            StartApp();
        }

        public void StartApp()
        {
            try
            {
                display.Input();
                if (display.Choice == 1)
                    newRecord();
                else if (display.Choice == 2)
                    displayAllRecords();
                else if (display.Choice == 0)
                    Console.Clear();
                else if (display.Choice == 9)
                    Environment.Exit(0);
                else
                    defaultChoice();
            }
            catch (Exception ex)
            {
                display.Error(ex);
            }
            StartApp();
        }
        void newRecord()
        {
            idea = new IdeaModel();
            display.NewIdeaName();
            idea.IdeaName = display.IdeaName;

            display.AddRecord(idea);
            display.Successful();
        }
        void displayAllRecords()
        {
            display.ShowAllRecords();
        }

        void defaultChoice()
        {
            display.DefaultChoice();
            StartApp();
        }
    }
}

