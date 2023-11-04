// See https://aka.ms/new-console-template for more information
Console.WriteLine("--- Operadores aritméticos");
double x = 5;
double y = -3;
double soma = x + y;
double subtracao = x - y;
double multiplicacao = x * y;
double divisao = x / y;
Console.WriteLine($"{x} + {y} = {soma}");
Console.WriteLine($"{x} - {y} = {subtracao}");
Console.WriteLine($"{x} * {y} = {multiplicacao}");
Console.WriteLine($"{x} / {y} = {divisao}");

Console.WriteLine("--- Precedência");
double n1 = 2, n2 = 3, n3 = 1;
double r1 = n1 * n2 + n3; 
Console.WriteLine($"{n1} * {n2} + {n3} = {r1}");
double r2 = n1 * (n2 + n3);
Console.WriteLine($"{n1} * ({n2} + {n3}) = {r2}");

Console.WriteLine("--- Divisão inteira");
int a = 7;
int b = 2;
int quocienteInteiro = a / b;
Console.WriteLine($"{a} / {b} = {quocienteInteiro}");
int restoInteiro = a % b;
Console.WriteLine($"{a} / {b} = {restoInteiro}");

Console.WriteLine("--- Funções matemáticas");
double doisAoCubo = Math.Pow(2, 3);
Console.WriteLine($"{2}³ = {doisAoCubo}");
double raizQuadradaDeDois = Math.Sqrt(2);
Console.WriteLine($"√2 = {raizQuadradaDeDois}");

Console.WriteLine("--- Funções trigonométricas");
double pi = Math.PI;
Console.WriteLine($"π = {pi}");
double seno30 = Math.Sin(30 * pi / 180);
Console.WriteLine($"seno de 30º = {seno30}");
double cosseno60 = Math.Cos(60 * pi / 180);
Console.WriteLine($"cosseno de 60º = {cosseno60}");
double tangente45 = Math.Tan(45 * pi / 180);
Console.WriteLine($"tangente de 45º = {tangente45}");

Console.WriteLine("--- Arredondamento");
double piArredondado6 = Math.Round (pi, 6);
double piArredondado2 = Math.Round (pi, 2);
double piArredondado0 = Math.Round (pi, 0);
Console.WriteLine($"π com 6 casas = {piArredondado6}");
Console.WriteLine($"π com 2 casas = {piArredondado2}");
Console.WriteLine($"π com 0 casas = {piArredondado0}");





