double x;
double y;
 
Console.WriteLine("   QUADRANTE CARTESIANO   ");
Console.WriteLine();
 
Console.Write("Coordenada X: ");
double.TryParse(Console.ReadLine()!, out x);
Console.WriteLine();
 
Console.Write("Coordenada Y: ");
double.TryParse(Console.ReadLine()!, out y);
Console.WriteLine();
 
if(x == 0 && y == 0)
{
    Console.WriteLine($"O ponto ({x}, {y}) fica na Origem ");
}
 
else if(x == 0)
{
    Console.WriteLine($"O ponto ({x}, {y}) fica no eixo das Ordenadas ");
}
 
else if(y == 0)
{
    Console.WriteLine($"O ponto ({x}, {y}) fica no eixo das Abcissas ");
}
 
else if(x > 0 && y > 0)
{
    Console.WriteLine($"O ponto ({x}, {y}) fica no Quadrante 1 ");
}
 
else if(y > 0 && x < 0)
{
    Console.WriteLine($"O ponto ({x}, {y}) fica no Quadrante 2 ");
}
 
else if(x < 0 && y < 0)
{
    Console.WriteLine($"O ponto ({x}, {y}) fica no Quadrante 3 ");
}
 
else if(x > 0 && y < 0)
{
    Console.WriteLine($"O ponto ({x}, {y}) fica no Quadrante 4 ");
}
