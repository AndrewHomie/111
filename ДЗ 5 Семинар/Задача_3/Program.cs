// Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

class Program
{
    static void Main(string[] args)
    {
        int a, i, n, sum = 0, sumo = 0;
        int[] m = new int[100];
    
        Random rand = new Random();
        n = 11;
        Console.WriteLine("Исходный массив");
        for (i = 0; i < n; i++)
        {
            m[i] = rand.Next(0, 10);
            Console.Write(m[i] + " ");
        }
 
        var min = m[0];
        var max = m[0];
 
        for (i = 0; i < n; i++)
        {
            if (m[i] < m[min])
            {
                min =i;
            }
            else if (m[i] > m[max])
            {
                max =i;
            }
        }
        Console.WriteLine("\nМинимальный элемент: " + m[min]);
        Console.WriteLine("Максимальный элемент: " + m[max]);
        for (i = 0; i < n; i++);
            
      
        Console.WriteLine(m[max] - m[min]);
            
    }
}
 

