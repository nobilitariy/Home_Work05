/*Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
double[] GetPoints(){
    Console.WriteLine("Enter four numbers to defie two lines");
    double[] points = new double[4];
    for(int i = 0; i < points.Length; i++){
        points[i] = Convert.ToInt32(Console.ReadLine());
    }
    return points;
}

void IntersecCalc(double[] Array){
    if(Array[0] ==Array[2] && Array[1] ==Array[3]){
        Console.WriteLine("Lines Coincide");
    }
    else if(Array[1] == Array[3] &&  Array[0] != Array[2]){
        Console.WriteLine("Lines are parallel");
    }
    { 
        double x = ((Array[2]-Array[0])/(Array[1]-Array[3]));
        double y = x*Array[1]+Array[0];
        Console.WriteLine($"Intersection points ({x}; {y})");
    }
}

double[] result = GetPoints();
IntersecCalc(result);
