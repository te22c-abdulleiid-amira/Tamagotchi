
    public class tamagochi
    {
        private int hunger;
        private int boredom;
        private bool isAlive;

        public string name;

        private void ReduceBoredom()
        {
            boredom =- 3;
        }

        public void Feed()
        {
            hunger =- 3;
            if (hunger < 1)
            {
                isAlive = false;
            }

        }

        public void Hi()
        {

        }

        public void Teach(string word)
        {
            
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

        }

        public bool GetAlive()
        {
            return isAlive;
        }

        
    }

