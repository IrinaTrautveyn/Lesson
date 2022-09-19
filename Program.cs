// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.WriteLine($"Возведене числа A в натуральную степень B");

int Exponentiation(int numA, int numB){
  int result = 1;
  for(int i=1; i <= numB; i++){
    result = result * numA;
  }
    // int result = Math.Pow(numberA, numberB);
    return result;
}

  Console.Write("Введите число A: ");
  int numA = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите число B: ");
  int numB = Convert.ToInt32(Console.ReadLine());

  int exponentiation = Exponentiation(numA, numB);
  Console.WriteLine("-> " + exponentiation);



//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

  int SumNumber(int numberN){
    
    int counter = Convert.ToString(numberN).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++){
      advance = numberN - numberN % 10;
      result = result + (numberN - advance);
      numberN = numberN / 10;
    }
   return result;
  }

int sumNumber = SumNumber(numberN);
Console.WriteLine("Сумма цифр в числе: " + sumNumber);

// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


Console.Write("Введите через запятую ряд чисел : ");
string seriesOfNumbers = Console.ReadLine();

seriesOfNumbers = seriesOfNumbers + ",";    // дополнительня запятая для обозначения конца строки

// функция удаления пробелов из строки 
string RemovingSpaces (string element){
  string elementNew = "";
  for (int i = 0; i < element.Length; i++)
  {
    if (element[i] != ' ') 
    {
      elementNew += element[i];
    }
  }
  return elementNew;
}

//  функция  проверки на правильность ввода 
void СheckNumber2 (int  element){

      if (element == '0'||element == '1'||element == '2'
      ||element == '3'||element == '4'||element == '5'||element == '6'
      ||element == '7'||element == '8'||element == '9'||element == ','
      ||element == '-')
      {
      }
        else {
          Console.WriteLine($"Ошибка ввода символа. Вводите цифры.");

      }
}

// функция  создания и заполнения массива из строки
int[] ArrayOfNumbers(string elementNew){ 

  int[] arrayOfNumbers = new int[1];    // инициализация массива из 1 элемента

  int f =0;

  for (int i = 0; i < elementNew.Length; i++){
    string elementNew1 = "";

    while (elementNew[i] != ',' && i < elementNew.Length){
      elementNew1 += elementNew[i];
      СheckNumber2(elementNew[i]);
      i++;
    }
    arrayOfNumbers[f] = Convert.ToInt32(elementNew1);    // заполняет массив значениями из строки
    if (i < elementNew.Length-1){
      arrayOfNumbers = arrayOfNumbers.Concat(new int[] {0}).ToArray();    // добавляет новый нулевой элемент в конец массива
    }
    f++;
  }
  return arrayOfNumbers;
}

// функция  вывода массива на печать 
void PrintArray(int[] coll){
  int count = coll.Length;
  int index = 0;
  Console.Write("[");
  while(index < count){
    Console.Write(coll[index]);
    index++;
    if (index < count){
      Console.Write(", ");
    }
  }
  Console.Write("]");
} 


string elementNew = RemovingSpaces(seriesOfNumbers);

int[] arrayOfNumbers =  ArrayOfNumbers(elementNew);

PrintArray(arrayOfNumbers);