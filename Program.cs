namespace Sortowanie___Selection_sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int tableSize = 20;
            int[] tab = new int[tableSize];
            for (int i=0; i<tableSize; i++)
            {
                tab[i] = rnd.Next(0,20);
            }

            Console.WriteLine(String.Join(",", tab));
            int currentIndexToCheck;
            int minIndex;
            int currentIndex;
            for (int i=0; i < tab.Length; i++)
            {
                currentIndexToCheck = i;
                minIndex =i;
                for (int j=i+1; j < tab.Length; j++)
                {
                    currentIndex = j;
                    if (tab[minIndex] > tab[currentIndex] )
                    {
                        minIndex = j;

                    }
                }

                (tab[currentIndexToCheck], tab[minIndex]) = (tab[minIndex], tab[currentIndexToCheck]);
                Console.WriteLine(String.Join(",", tab));


            }

        }
    }
}