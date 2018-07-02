using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Calculator.Controllers
{
    public class CalcController : Controller
    {
        private double a = 0;

        // GET: Calc
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public void PutA(double a)
        {
            this.a = a;
        }

        [HttpPost]
        public double Sum(double b)
        {
            return a + b;
        }

        [HttpPost]
        public double Subtraction(double b) //вычитание
        {
            return a - b;
        }

        [HttpPost]
        public double Multiplication(double b)
        {
            return a * b;
        }

        [HttpPost]
        public double Division(double b)
        {
            return a / b;
        }

        [HttpPost]
        public double SqrtX(double b)
        {
            return Math.Pow(a, 1 / b);
        }

        [HttpPost]
        public double DegreeY(double b)
        {
            return Math.Pow(a, b);
        }

        [HttpPost]
        public double Sqrt()
        {
            return Math.Sqrt(a);
        }

        [HttpPost]
        public double Square()
        {
            return Math.Pow(a, 2.0);
        }
    }
}