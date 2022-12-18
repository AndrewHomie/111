// Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12




int numberN = 9012;

  int SumNumber(int numberN)
  
  {  
    int counter = Convert.ToString(numberN).Length;
    int variable = 0;
    int result = 0;

    for (int i = 0; i < counter; i++)
    {
      variable = numberN - numberN % 10;
      result = result + (numberN - variable);
      numberN = numberN / 10;
    }
   return result;
  }

int sumNumber = SumNumber(numberN);
Console.WriteLine(sumNumber);
