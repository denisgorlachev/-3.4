//Горлачев базовый уровень 
double x = 2;
double y = 0;
do 
{
    y = Math.Abs(Math.Log(x)) - Math.Pow(x - 2, 2);
}
while ((x += 0.2) <= 4.1) ;
Console.WriteLine("Ответ: "+y);