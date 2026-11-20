// === ВЫЗОВЫ МЕТОДОВ (ВЕРХ ФАЙЛА) ===

// // Задание 1
// PrintHeader("Отчёт за месяц");
// PrintHeader("Итоги года");

// // Задание 2.1
// Console.WriteLine(Max(10, 25));
// Console.WriteLine(Max(7, 3));

// // Задание 2.2
// Console.WriteLine(IsEven(4));
// Console.WriteLine(IsEven(7));
// Console.WriteLine(IsEven(0));

// // Задание 3
// int[] prices = { 120, 45, 300, 80, 15, 210 };
// Console.WriteLine($"Среднее: {Average(prices)}");
// Console.WriteLine($"Дороже 100: {CountGreater(prices, 100)}");

// // Задание 4
// Console.WriteLine($"0 °C = {ToFahrenheit(0)} °F");
// Console.WriteLine($"100 °C = {ToFahrenheit(100)} °F");
// Console.WriteLine($"37 °C = {ToFahrenheit(37)} °F");

// // Задание 5
// Console.WriteLine($"5! = {Factorial(5)}");
// Console.Write("Простые числа от 2 до 50: ");
// for (int i = 2; i <= 50; i++) {
//     if (IsPrime(i)) {
//         Console.Write(i + " ");
//     }
// }
// Console.WriteLine();

// // Задание 6
// int a6 = ReadPositive("Введите первое положительное число: ");
// int b6 = ReadPositive("Введите второе положительное число: ");
// Console.WriteLine($"Сумма: {a6 + b6}");

// // Дополнительное задание
// Console.WriteLine($"Gcd(48, 18) = {Gcd(48, 18)}");
// Console.WriteLine($"Lcm(4, 6) = {Lcm(4, 6)}");

// Итоговая задача. «Меню-калькулятор»
int choice;
do {
    Console.WriteLine("\n1 — сумма двух чисел");
    Console.WriteLine("2 — большее из двух чисел");
    Console.WriteLine("3 — факториал");
    Console.WriteLine("0 — выход");
    Console.Write("Выберите пункт: ");
    choice = Convert.ToInt32(Console.ReadLine());

    switch (choice) {
        case 1:
            Console.Write("Первое число: ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Второе число: ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Сумма: {Sum(x1, y1)}");
            break;
        case 2:
            Console.Write("Первое число: ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Второе число: ");
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Большее: {Max(x2, y2)}");
            break;
        case 3:
            int n = ReadPositive("Введите положительное число: ");
            Console.WriteLine($"Факториал: {Factorial(n)}");
            break;
        case 0:
            Console.WriteLine("Выход из программы.");
            break;
        default:
            Console.WriteLine("Нет такого пункта");
            break;
    }
} while (choice != 0);


// === ОБЪЯВЛЕНИЕ МЕТОДОВ (НИЗ ФАЙЛА) ===

static void PrintLine() {
    Console.WriteLine("^_^ ^_^ ^_^");
}

static void PrintHeader(string title) {
    PrintLine();
    Console.WriteLine(title);
    PrintLine();
}

static int Sum(int a, int b) {
    return a + b;
}

static int Max(int a, int b) {
    if (a > b) {
        return a;
    }
    return b;
}

static bool IsEven(int n) {
    return n % 2 == 0;
}

static double Average(int[] arr) {
    int sum = 0;
    foreach (int x in arr) {
        sum += x;
    }
    return (double)sum / arr.Length;
}

static int CountGreater(int[] arr, int limit) {
    int count = 0;
    foreach (int x in arr) {
        if (x > limit) {
            count++;
        }
    }
    return count;
}

static double ToFahrenheit(double celsius) {
    return celsius * 9 / 5 + 32;
}

static long Factorial(int n) {
    long res = 1;
    for (int i = 1; i <= n; i++) {
        res *= i;
    }
    return res;
}

static bool IsPrime(int n) {
    if (n < 2) {
        return false;
    }
    for (int i = 2; i < n; i++) {
        if (n % i == 0) {
            return false;
        }
    }
    return true;
}

static int ReadPositive(string message) {
    int num;
    do {
        Console.Write(message);
        num = Convert.ToInt32(Console.ReadLine());
    } while (num <= 0);
    return num;
}

static int Gcd(int a, int b) {
    while (b != 0) {
        int temp = b;
        b = a % b;
        a = temp;
    }
    return a;
}

static int Lcm(int a, int b) {
    return a / Gcd(a, b) * b;
}
