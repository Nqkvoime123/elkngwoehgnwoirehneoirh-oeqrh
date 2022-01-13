using System;
using System.Collections.Generic;
using System.Text;

namespace elkngwoehgnwoirehneoirh_oeqrh
{
    class Display
    {
        List<IdeaModel> Ideas;

        public string IdeaName;
        public string IdeaValue;
        public int Choice;
        public Display()
        {
            Ideas = new List<IdeaModel>();
            Console.WriteLine("Dobre doshli v nashiq app. Kakwo iskate da pravite");
        }
        public void Input()
        {
            Console.WriteLine("1 - Napravete nov zapis.");
            Console.WriteLine("2 - pokajete vsichki zapisi.");
            Console.WriteLine("8 - izchisti konzolata.");
            Console.WriteLine("9 - Exit.");
            try
            {
                Choice = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                if (ex.Message == "Input string was not in a correct format.")
                    Choice = 0;
                else
                    throw;
            }

        }
        public void DefaultChoice()
        {
            Console.WriteLine("Greshen izbor, Molq izberete na novo.");
        }
        public void NewIdeaName()
        {
            Console.WriteLine("Molq vuvedete ime na ideqta");
            IdeaName = Console.ReadLine();
        }
        public void NewIdeaValue()
        {
            Console.WriteLine($"Molq vuvedete vashata ideq {IdeaName}");
            IdeaValue = Console.ReadLine();
        }
        public void Successful()
        {
            Console.WriteLine("Vie uspeshno dobavihte nov zapis");
        }
        public void AddRecord(IdeaModel idea)
        {
            Ideas.Add(idea);
        }
        public void Error(Exception ex)
        {
            Console.WriteLine("An error occured with the app. Error: {ex.Message}");
        }
        public void ShowAllRecords()
        {
            for (int i = 0; i < Ideas.Count; i++)
            {
                Console.WriteLine($"Ime na ideq: {Ideas[i].IdeaName}");
                Console.WriteLine($"Stoinost na ideq: {Ideas[i].IdeaValue}");
                Console.WriteLine("");
            }
        }
    }
}