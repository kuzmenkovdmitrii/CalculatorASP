using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public enum Actions { Sum, Subtraction, Multiplication, Division, SqrtX, DegreeY, Default};

namespace Calculator.Models
{
    public class CalcModel
    {
        public double A { get; set; }
        public double B { get; set; }
        public Action Operation { get; set; }
    }
}