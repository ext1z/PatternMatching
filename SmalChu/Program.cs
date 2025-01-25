


// 6. https://acm.timus.ru/problem.aspx?space=1&num=1268



// Kop voqt ketti))




class Program
{
    static void Main(string[] args)
    {
        int countOftests = Convert.ToInt32(Console.ReadLine()!);
        int[] daysPerWeek = new int[countOftests];

        for (int i = 0; i < countOftests; i++)
        {
            daysPerWeek[i] = Convert.ToInt32(Console.ReadLine());

        }

        for (int i = 0; i < daysPerWeek.Length; i++)
        {
            Console.WriteLine(GetMaximumLenght(daysPerWeek[i]));
        }

    
    }

    static int GetMaximumLenght(int daysPerWeek)
    {
        int previosSequenceLenght = 0;
        int previousDay = 0;

        for (int i = 1; i < daysPerWeek; i++)
        {
            int currentSequenceLenght = 0;

            for (int j = 1; j < daysPerWeek; j++)
            {
                if (Math.Pow(i, j) % daysPerWeek == 1)
                {
                    currentSequenceLenght++;
                    if (currentSequenceLenght >= previosSequenceLenght)
                    {
                        previousDay = i;
                        previosSequenceLenght = currentSequenceLenght;
                    }

                    currentSequenceLenght = 0;
                    break;
                }
                else
                {
                    currentSequenceLenght++;
                }
            }
        }
        return previousDay;
    }
}