using System;

namespace Tyuiu.MaltsevVS.ConsoleApp.Lab4.V0.Lib
{
    public class ShadedAreaCalculator
    {
        public static bool IsInsideShadedArea(double x, double y)
        {
            double hypotenuse = Math.Sqrt(x * x + y * y);

            if (hypotenuse <= 1 && (x >= -1 && x <= 1 && y >= 0 && y <= 1))
            {
                // Проверяем, что точка не находится внутри четверти круга с центром в (0, 0) и радиусом 0.3
                if (hypotenuse >= 0.3 || x <= 0)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
