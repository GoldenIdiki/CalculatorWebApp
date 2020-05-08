using System;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorApplicationWeb.Controllers
{
    public class CalcController : Controller
    {
        [HttpGet]
        public ActionResult Squareroot()
        {
            return View();
        }
       [HttpPost]
       public ActionResult Squareroot(string firstnumber, string secondnumber)
       {
           int numberOne = int.Parse(firstnumber);
           int numberTwo = int.Parse(secondnumber);
           string ErrorMessage = "Invalid Numbers Entered";
           int n = 0;
           bool IsNumericOne = int.TryParse("firstnumber", out n);
           bool IsNumericTwo = int.TryParse("second number", out n);
           double resultOne = Math.Sqrt(numberOne);
           double resultTwo = Math.Sqrt(numberTwo);
           ViewBag.ResultOne = resultOne;
           ViewBag.ResultTwo = resultTwo;
           ViewBag.NumberOne = numberOne;
           ViewBag.NumberTwo = numberTwo;
           ViewBag.NumericOne = IsNumericOne;
           ViewBag.NumericTwo = IsNumericTwo;
           ViewBag.ErrorMessage = ErrorMessage;
           
           return View(); 
       } 
       
        
    }
    
    
}