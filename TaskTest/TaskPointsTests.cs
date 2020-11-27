using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task;

namespace TaskTests
{
    [TestClass]
    public class TaskPointsTests
    {
        [TestMethod]
        public void Points_30divide6()
        {
            //arrange
            Logic.H = 10;
            Logic.A = new Logic.Points(0, 0);
            Logic.L = 30;
            Logic.Alfa = 30;

            //act
            List<Logic.Points> result = Logic.GetAllPoints();
            List<Logic.Points> resultforcheck = new List<Logic.Points>
            {
                new Logic.Points(0.00, 0.00),
                new Logic.Points(5.00, 0.00),
                new Logic.Points(15.00, 0.00),
                new Logic.Points(25.00, 0.00),
                new Logic.Points(30.00, 10.00),
                new Logic.Points(20.00, 15.77),
                new Logic.Points(15.00, 18.66),
                new Logic.Points(10.00, 15.77),
                new Logic.Points(0.00, 10.00)
            };
            Assert.ReferenceEquals(resultforcheck, result);




        }
    }
}
