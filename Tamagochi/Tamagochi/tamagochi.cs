
    public class tamagochi
    {
        private int hunger;
        private int boredom;
        private bool isAlive;
         private List<string> words = new List<string>() {"hello"};
        public string name;

        public tamagochi()
        {
            isAlive = true;
        }

        public void ReduceBoredom()
        {
        Console.WriteLine($" [{name}] is now less bored!");
        boredom -= 2;
            if (boredom < 0)
                
                {
                    boredom = 0;
                }
        }

        public void Feed()
        {
            Console.WriteLine($" [{name}] är mindre hungrig nu");
            hunger =- 3;
            if (hunger < 0)
            {
                isAlive = false;
            }

        }

        public void Hi()
        {
            int wordNum = Random.Shared.Next(words.Count);
            Console.WriteLine($" [{name}] says: {words[wordNum]}");
            ReduceBoredom();
        }

        public void Teach(string word)
        {
            Console.WriteLine($" [{name}] learns: {word}");
            words.Add(word);
            ReduceBoredom();
            
        }

        public void Tick()
        {
            hunger ++;
            boredom ++;
            if (boredom > 10 || hunger > 10) 
            {
                isAlive = false;
            }
        }

        public void PrintStats()
        {
            Console.WriteLine($"Name: {name} || Hunger: {hunger} || Boredom: {boredom} || Vocabulary: {words.Count} words");
        }

        public bool GetAlive()
        {
            return isAlive;
        }

        
    }

