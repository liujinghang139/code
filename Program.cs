﻿using System;

class Calculator
{
    static void Main(string[] args)
    {
        // 提示用户输入第一个数字  
        Console.Write("请输入第一个数字: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        // 提示用户输入第二个数字  
        Console.Write("请输入第二个数字: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        // 提示用户输入运算符  
        Console.Write("请输入运算符 (+, -, *, /): ");
        char operation = Console.ReadLine()[0];

        double result = 0;

        // 根据运算符执行相应的运算  
        switch (operation)
        {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                if (num2 != 0)
                    result = num1 / num2;
                else
                {
                    Console.WriteLine("错误: 除数不能为零。");
                    return;
                }
                break;
            default:
                Console.WriteLine("错误: 无效的运算符。");
                return;
        }

        // 打印结果  
        Console.WriteLine("计算结果: " + result);
    }
}
