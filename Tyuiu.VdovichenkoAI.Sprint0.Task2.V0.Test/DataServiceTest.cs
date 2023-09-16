using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.VdovichenkoAI.Sprint0.Task2.V0.Lib;
namespace Tyuiu.VdovichenkoAI.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            // Область создания методов тестрирования, методов из библиотеки
            var name = "Алина";
            var res = DataService.GetMessage(name);

            // Вызываем класс Assert и метод AreEqual
            Assert.AreEqual("Привет..., Алина", res);
        }
    }
}
