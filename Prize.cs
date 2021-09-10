using System;

namespace Quest
{
    public class Prize
    {
        private string _description;

        public Prize(string description)
        {
            _description = description;
        }

        public void ShowDescription(Adventurer adventurer)
        {
            if(adventurer.Awesomeness > 0)
            {
                for(int i = 0; i < adventurer.Awesomeness; i++)
                {
                    Console.WriteLine(_description);
                }
            } else {
                Console.WriteLine("Too bad, no prize this time");
            }
        }
    }
}