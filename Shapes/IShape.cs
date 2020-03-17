using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Напишите библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу
//и треугольника по трем сторонам.Дополнительно к работоспособности оценим:
//Юнит-тесты
//Легкость добавления других фигур
//Вычисление площади фигуры без знания типа фигуры
//Проверку на то, является ли треугольник прямоугольным
namespace Shapes
{
    public interface IShape
    {
        double GetArea();
    }

}
