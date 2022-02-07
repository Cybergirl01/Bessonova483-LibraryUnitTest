using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Bessonova483_classLibrary;

namespace Bessonova483___UnitTestProjectLibrary
{
    [TestClass]
    public class UnitTestQuadraticEquation
    {
        [TestMethod]
        public void TwoRoots()
        {
            Quadratic_Equation q = new Quadratic_Equation(); //новый Quadratic_Equation
            q.a = 2.0f;
            q.b = 10.0f;
            q.c = 4.0f;

            float[] x;
            int n = q.Solve(out x);

            const float r1 = -1.5f;
            const float r2 = -0.5f;

            const float e = 0.0001f;

            if (x == null) Assert.Fail("array is not initiated");
            if(x.Length != n) Assert.Fail("array doesn't match with the number of roots.");
            if (n!= 2) Assert.Fail("wrong number of roots.");

           if(x[0] < r1 - e && x[0]> r1 + e) Assert.Fail("root 1 is incorrect");
           if (x[1] < r2 - e && x[1] > r2 + e) Assert.Fail("root 2 is incorrect");

            
            
        }

        [TestMethod]
        public void OneRoot()
        {
            Quadratic_Equation q = new Quadratic_Equation(); //новый Quadratic_Equation
            q.a = 1.0f;
            q.b = 4.0f;
            q.c = 4.0f;

            float[] x;
            int n = q.Solve(out x);

            const float r1 = -1.5f;

            const float e = 0.0001f;

            if (x == null) Assert.Fail("array is not initiated");
            if (x.Length != n) Assert.Fail("array doesn't match with the number of roots.");
            if (n != 1) Assert.Fail("wrong number of roots.");

            if (x[0] < r1 - e && x[0] > r1 + e) Assert.Fail("root 1 is incorrect");
           



        }
        [TestMethod]
        public void NoRoots() { 
            Quadratic_Equation q = new Quadratic_Equation(); //новый Quadratic_Equation
            q.a = 0.0f;
            q.b = 0.0f;
            q.c = -1.0f;

            float[] x;
            int n = q.Solve(out x);

            if (x == null && n == 0) Assert.IsNull(n);



            




        }
    }
}
