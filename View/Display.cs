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
            Console.WriteLine("Добре дошли в нашето приложение. Какво искате да правите");
        }
        public void Input()
        {
            Console.WriteLine("1 - Направате нов запис.");
            Console.WriteLine("2 - Покажете всички записи.");
            Console.WriteLine("8 - Изчисти конзолата.");
            Console.WriteLine("9 - Изхос.");
            try
            {
                Choice = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                if (ex.Message == "Input string не беше правилен формат.")
                    Choice = 0;
                else
                    throw;
            }

        }
        public void DefaultChoice()
        {
            Console.WriteLine("Гречен избор, Моля изберете на ново.");
        }
        public void NewIdeaName()
        {
            Console.WriteLine("моля въведете име на идеята");
            IdeaName = Console.ReadLine();
        }
        public void NewIdeaValue()
        {
            Console.WriteLine($"Моля въведете вашата идеа {IdeaName}");
            IdeaValue = Console.ReadLine();
        }
        public void Successful()
        {
            Console.WriteLine("Вие успешно добавихте нов запис");
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
                Console.WriteLine($"Име на Идея: {Ideas[i].IdeaName}");
                Console.WriteLine($"Стойност на идея: {Ideas[i].IdeaValue}");
                Console.WriteLine("");
            }
        }
    }
}