using System;

namespace LineComparisionComputation
{
   public class Program
    {
        static void Main(string[] args)
        {
              Console.WriteLine("*****Welcome To Line Comparison Computation Program***********");
              Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");

              Console.WriteLine("*******Output For The Length Of Line Using Cartician System.********");
              Length case1 = new Length();
              case1.CheckLengthOfLine();

               Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");
               Console.WriteLine("******Output For Equality of Line Based On The End Points********");
               EqualityOfLines case2 = new EqualityOfLines();
               case2.CheckEqualityOfTwoLines();

               Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");
               Console.WriteLine("*******Output For Comparing Two Line,In That, One Line Is Equal ,Greater  Or Less Than The Other Line Based On The End Points.******* ");
               ComparingTheLine case3 = new ComparingTheLine();
               case3.CheckComparisionOfLines();

               Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");
               Console.WriteLine("********Output For Checking The Points And The Equality Of Lines");
               LineAndPointEqual case4 = new LineAndPointEqual();
               case4.CheckingEqualityOfPointsAndLength();
             


        }
        
    }
}
