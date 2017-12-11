using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfTriangle
{   //Класс для нахождения площади прямоугольного треугольника
    public class FoundArea
    {
        //Метод для вычисления площади прямоугольного треугольника
        public double areaOfTringle(double width, double height, double hypotenuse)
        {
            double area = 0.0;
            //Проверка на неотрицательность
            if (width >= 0 && height >= 0 && hypotenuse >= 0)
            {
                //Проверка на самую длинную сторону
                if (width > height && width > hypotenuse)
                {
                    area = height * hypotenuse / 2;
                }
                else if (height > width && height > hypotenuse)
                {
                    area = width * hypotenuse / 2;
                }
                else if (hypotenuse > width && hypotenuse > height)
                {
                    area = width * height / 2;
                }
            }
            return area;
        }
    }
}
