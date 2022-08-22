// Task 25

Console.WriteLine("\nTask 25. Elevating the number A to the natural power of B");
double Elevation(int A, int B){
double result = 1;
// Если основывать на исследованном материале - решается через цикл   for(int i=1; i <= numberB; i++){result = result * numberA;};
for (int power = 1; power <= B; power++){
result = Math.Pow(A, power);
Console.WriteLine($"{A}^{power} = {(long)Math.Pow(A, power)}");
}
return result;  
}

Console.Write("Enter Number A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter Number B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

double elevation = Elevation(numberA, numberB);
Console.WriteLine("Answer: " + elevation);

// Task 27
Console.WriteLine("\nTask 27. Sum of digits in a number");

  int Sumber(int number){
    
    int counter = Convert.ToString(number).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++){
      advance = number - number % 10;
      result = result + (number - advance);
      number = number / 10;
    }
   return result;
  }

Console.Write("Please, enter your number: ");
int number = Convert.ToInt32(Console.ReadLine());

int sumber1 = Sumber(number);
Console.WriteLine("Sum of digits in your number is: " + sumber1);

// Task 29

Console.WriteLine("\nTask 29. Generation and display of an array of 8 elements");
Console.WriteLine("Generating an Array.");

int[] NumericalArray = new int [8];
int Amount = NumericalArray.Length;
var RND_NUM = new Random();
for (int i = 0; i < Amount; i++)
{
  NumericalArray[i] = RND_NUM.Next(0,10);
  Console.WriteLine("{0} element of an array is: {1}", i+1, NumericalArray[i]); 
}

Console.WriteLine("The Array is filled. Printing.");

void Print_Array(int[] Array){
  int count = Array.Length;
  int Arr_I = 0;
  Console.Write("[");
  while(Arr_I < count){
    Console.Write(Array[Arr_I]);
    Arr_I++;
    if (Arr_I < count){
      Console.Write(", ");
    }
  }
  Console.Write("]");
} 

Print_Array(NumericalArray);