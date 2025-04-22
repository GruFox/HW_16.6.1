using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_16._6._1;

public class Calculator
{
    /// <summary>
    /// Вычисляет сумму чисел
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public int Additional(int a, int b)
    {
        return a + b;
    }

    /// <summary>
    /// Вычисляет разность чисел
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public int Subtraction(int a, int b)
    {
        return a - b;
    }

    /// <summary>
    /// Вычисляет произведение чисел
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public int Miltiplication(int a, int b)
    {
        return a * b;
    }

    /// <summary>
    /// Вычисляет частное чисел
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public int Division(int a, int b)
    {
        return a / b;
    }
}
