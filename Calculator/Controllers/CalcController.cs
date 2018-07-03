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
        // GET: Calc
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Calculate(double a, double b, Actions operation)
        {
            double calculateValue = 0;
            if (operation == Actions.Sum)
            {
                calculateValue = Sum(a, b);
            }
            else if (operation == Actions.Subtraction)
            {
                calculateValue = Subtraction(a, b);
            }
            else if (operation == Actions.Multiplication)
            {
                calculateValue = Multiplication(a, b);
            }
            else if (operation == Actions.Division)
            {
                calculateValue = Division(a, b);
            }
            else if (operation == Actions.SqrtX)
            {
                calculateValue = SqrtX(a, b);
            }
            else if (operation == Actions.DegreeY)
            {
                calculateValue = DegreeY(a, b);
            }

            operation = Actions.Default;
            ViewBag.CalculateValue = calculateValue;

            return View("Index");
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

        double DegreeY(double a, double b)
        {
            return Math.Pow(a, b);
        }

        public ActionResult Sqrt(double a)
        {
            ViewBag.CalculateValue = Math.Sqrt(a);
            return View("Index");
        }

        public ActionResult Square(double a)
        {
            ViewBag.CalculateValue = Math.Pow(a, 2.0);
            return View("Index");
        }
    }
}