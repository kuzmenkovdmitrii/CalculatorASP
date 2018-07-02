using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Calculator.Models;

namespace Calculator.Controllers
{
    public class CalcController : Controller
    {
        double A = 0;
        double B = 0;
        Actions Operation = Actions.Default;

        // GET: Calc
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SetAAndOperation(double a, Actions operation)
        {
            if (A == 0)
            {
                A = a;
            }

            Operation = operation;
            return View("Index");
        }

        public double Calculate(double b)
        {
            B = b;
            if(Operation == Actions.Sum)
            {
                Operation = Actions.Default;
                B = 0;
                return A = Sum(A, B);
            }
            else if(Operation == Actions.Subtraction)
            {
                Operation = Actions.Default;
                B = 0;
                return A = Subtraction(A, B);
            }
            else if (Operation == Actions.Multiplication)
            {
                Operation = Actions.Default;
                B = 0;
                return A = Multiplication(A, B);
            }
            else if (Operation == Actions.Division)
            {
                Operation = Actions.Default;
                B = 0;
                return A = Division(A, B);
            }
            else if (Operation == Actions.SqrtX)
            {
                Operation = Actions.Default;
                B = 0;
                return A = SqrtX(A, B);
            }
            else if (Operation == Actions.DegreeY)
            {
                Operation = Actions.Default;
                B = 0;
                return A = DegreeY(A, B);
            }
            else if (Operation == Actions.Default)
            {
                return 0;
            }
            return 12;
        }

        double Sum(double a, double b)
        {
            return a + b;
        }

        double Subtraction(double a, double b)
        {
            return a - b;
        }

        double Multiplication(double a, double b)
        {
            return a * b;
        }

        double Division(double a, double b)
        {
            return a / b;
        }

        double SqrtX(double a, double b)
        {
            return Math.Pow(a, 1 / b);
        }

        public double DegreeY(double a, double b)
        {
            return Math.Pow(a, b);
        }

        [HttpPost]
        public double Sqrt(double a)
        {
            return A = Math.Sqrt(a);
        }

        [HttpPost]
        public double Square(double a)
        {
            return A = Math.Pow(a, 2.0);
        }

        public void Clear()
        {
            A = 0;
            B = 0;
            Operation = Actions.Default;
        }
    }
}