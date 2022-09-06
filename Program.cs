
// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// int[] CreateArray(int size){
//     int[] array = new int[size];
//     for (int i=0; i < size; i++){
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }


// void ShowArray(int[] array){
//     Console.Write("[ ");
//     for(int i=0; i<array.Length; i++){
//         Console.Write($"{array[i]} ");
//     }
//     Console.Write("]");
// }

// int Func(int[] array){
//     int sum = 0;
//     for(int i=0; i < array.Length; i++){
//         if(array[i] > 0) sum++;
//     }
//     return sum;
// }

// Console.Write("Enter the size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter the numbers: ");
// int[] array = CreateArray(size);
// ShowArray(array);
// int sum = Func(array);
// Console.WriteLine();
// Console.WriteLine($"Positive numbers: {sum}");


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.


// void Point(int k1, int k2, int b1, int b2){
//    int x = (b2 - b1) / (k1 - k2);
//    int y = k1 * x + b1;
//    Console.WriteLine($"({x};{y})"); 
// }



// Console.Write("Enter k1: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter k2: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter b1: ");
// int c = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter b2: ");
// int d = Convert.ToInt32(Console.ReadLine());
// Point(a, b, c, d);