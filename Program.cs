//Задача2.Напишите программу, которая на вход принимает два числа и выдает, какое число больше, а какое меньшее.
/*
Console.WriteLine("ВВедите Первое число:");
int num1 = Convert.ToInt32(Console.ReadLine() );

Console.WriteLine("ВВедите Второе число:");
int num2 = Convert.ToInt32(Console.ReadLine() );

if(num1 > num2){
    Console.WriteLine($"{num1} Большее число");
}else{
Console.WriteLine($"{num2} Большее число ");
};


//Задача4. Напишите программу, которая принимает на вхолд три числа и 
//выдает максимальное из этих чисел

Console.WriteLine("ВВедите Первое число:");
int num1 = Convert.ToInt32(Console.ReadLine() );

Console.WriteLine("ВВедите Второе число:");
int num2 = Convert.ToInt32(Console.ReadLine() );

Console.WriteLine("ВВедите Третье число:");
int num3 = Convert.ToInt32(Console.ReadLine() );

int maxInt = num1;

if(num2 >= maxInt && num2 >= num3){
    maxInt = num2;
}else if(num3 >= maxInt && num3 >=num2){
    maxInt = num3;
};
Console.WriteLine($"{maxInt} наибольшее число из {num1}, {num2}, {num3}");


//Задача6.Нaпишите программу, которая на вход принимает число и выдает 
//является ли число четным (делится ли оно на два без остатка)

Console.WriteLine("ВВедите число для проверки на четность:");
int num = Convert.ToInt32(Console.ReadLine() );

if(num % 2 == 0){
    Console.WriteLine($"{num} является ЧЕТНЫМ (even)");
}else{
     Console.WriteLine($"{num} НЕЧЕТНОЕ ЧЕТНЫМ (odd)");
};

*/
//Задача8. Напишите программу, которая на вход принимает число (N) 
//а на выходе показывает все четные числа от 1 до N

Console.WriteLine("ВВедите число :");
int integer = Convert.ToInt32(Console.ReadLine() );

int count = 1;

while(count <= integer){
    if(count % 2 == 0){
        Console.WriteLine($"this {count} is even out of {integer} numbers in a row");
    };
    count++;
};
