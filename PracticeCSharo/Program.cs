using System;

namespace TechDoctor
{
    public class Test
    {
        private int score = 0;
        private static int myScore = 0;
        public Test(int score)
        {
            this.score = score;
        }


        static void Func( Test t)
        {
            t.AddScore(1);
        }

        
        public void AddScore(int score)
        {
            score += 10;
        }
        public void AddScore(Test score)
        {
            score = new Test(1);
            score.score += 10;
        }

        public void Print()
        {
            Console.Out.WriteLine($"Score:  {score}");
            //Func();
            myScore = 0;
        }

        /*static void Main(string[] args)
        {
           Test t = new Test(1);
           t.Print();
           
           t.AddScore(t);
           t.Print();
           
        }*/

        static void Main(string[] args)
        {
            //Discards.TestDiscards();
            
            /*OutVariables outVariables = new OutVariables();
            outVariables.TestOutVariables();
            outVariables.TestOutVariablesNewWay();*/
            
            PatternMatching patternMatching = new PatternMatching();
            patternMatching.IsExpression();


        }
    }
    

}