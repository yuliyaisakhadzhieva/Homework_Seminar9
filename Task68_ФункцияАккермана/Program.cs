// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// Формула функции: А  (m,n)
// m=0 => n+1
// m>0, n=0 => A(m-1,1)
// m>0, n>0 => A(m-1, A(m, n-1))

Console.Write("Введите целое число m ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число n ");
int n = Convert.ToInt32(Console.ReadLine());

int AccermanRec (int m,int n)
{
if (m == 0) return (n+1);
else if (n == 0 && m>0) return AccermanRec (m-1, 1);
else return AccermanRec (m-1, AccermanRec(m, n-1));
}
Console.WriteLine ($"Значение функции Аккермана равно: {AccermanRec(m,n)}");

