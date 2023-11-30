//от 1 до, скажем, миллиарда, притом если число кратно трем, то вместо числа выводится Fizz, если кратно пяти, то Buzz, а если и трем, и пяти, то FizzBuzz.

int ReadNum(string message)
{
    System.Console.Write(message);

    int number = Convert.ToInt32(Console.ReadLine());

    return number;

}
void FizzBuzz(int[] array, int num1, int num2)
{
    for (int i = 0; i < array.Length; i++)
    {
     if (array[i]%num1 == 0 && array[i]%num2 == 0) System.Console.WriteLine(" FizzBuzz");
     else if (array[i]%num1 == 0) System.Console.Write(" Fizz");
     else if (array[i]%num2 == 0) System.Console.Write(" Buzz");
     else System.Console.Write($" {array[i]}");
    }
}

int [] ConvertToArray (int number)
{
    int[] array = new int[number];
    for (int i = 0; i < number; i++)
    {
        array[i] = i + 1;
    }
    return array;
}

int number = ReadNum("Введите число для генерации: ");
int number1 = ReadNum("Введите 1е кратное: ");
int number2 = ReadNum("Введите 2е кратное: ");
int [] array = ConvertToArray(number);
FizzBuzz(array, number1, number2);
