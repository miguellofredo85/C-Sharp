﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lambda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            //Expressão lambda que tem uma expressão como corpo:
            //(input - parameters) => expression

            //Instrução lambda que tem um bloco de instrução como corpo:
            //(input - parameters) => { < sequence - of - statements > }

            //Func<int, int> square = y => y * y;

            ////label1.Text = "O resultado é " + square(5);

            //Expression<Func<int, int>> ex = x => x + x;

            //// label1.Text = ex.ToString();

            //int[] numbers = { 2, 3, 4, 5 };
            //var squaredNumbers = numbers.Select(x => x * x);
            //label1.Text = string.Join(" ", squaredNumbers);

            //Action<string> greet = name =>
            //{
            //    string greeting = $"Hello {name}!";
            //    label1.Text = greeting;
            //};

            //greet("Gabriel");

            //Action line = () => Console.WriteLine();

            //Console.WriteLine("Gabriel");
            //line();
            //Console.WriteLine("Artigas");

            Func<int, int, bool> testForEquality = (x, y) => x == y;
            label1.Text = testForEquality(10,10).ToString();
        }

        int quadrado(int x)
        {
            return x * x;
        }
    }
}
