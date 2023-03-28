// Напишите программу, которая найдёт точку пересечения двух 
// прямых, заданных уравнениями 
// y = k1 * x + b1, 
// y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// пример : b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

const int coeff = 0;
const int constant = 1;
const int x_coord = 0;
const int y_coord = 1;
const int line1 = 1;
const int line2 = 2;

double[] lineData1 = InputLineData(line1);
double[] lineData2 = InputLineData(line2);

if (ValidateLines (lineData1, lineData2))
{
   double[] coord = FindCoords (lineData1, lineData2);
   Console.Write($"ТОчка пересечения y={lineData1[coeff]}*x + {lineData1[constant]} и y={lineData2[coeff]}*x + {lineData2[constant]}");
   Console.WriteLine($"  имеет координаты х = ({coord[x_coord]}), y = ({coord[y_coord]})");
}

///

double ImputNumber (string message)
{
   System.Console.Write(message);
   string value = Console.ReadLine();
   double result = Convert.ToDouble(value);
   return result;
}

double[] InputLineData (int numberOfLine)
{
    double[] lineData = new double [2];
    lineData[coeff] = ImputNumber($"Введите коэфициент для {numberOfLine} прямой >");
    lineData[constant] = ImputNumber($"Введите константу для {numberOfLine} прямой >");
    return lineData;
}

double[] FindCoords ( double[] lineData1, double[] lineData2 )
{
    double[] coord = new double [2];
    coord[x_coord] = (lineData1[constant]- lineData2[constant]) / (lineData2[coeff] - lineData1[coeff]);
    coord[y_coord] = lineData1[constant] * coord[x_coord] + lineData1[constant]; 
    return coord;
}

bool ValidateLines(double[] lineData1, double[] lineData2 )
{
    if(lineData1[coeff] == lineData2[coeff])
       if(lineData1[constant] == lineData2[constant])
       {
        Console.WriteLine("ПРямые совпадают");
        return false;
       }
       else
       {
        Console.WriteLine("ПРямые параллельны");
        return false;
       }

    return true;   
}