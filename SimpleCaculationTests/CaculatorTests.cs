﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCaculation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SimpleCaculation.Tests
{
    [TestClass]
    public class CaculatorTests
    {
        [TestMethod]
        public void Add_AddedTwoInt_ReturnEqual()
        {
            var cal = new Caculator();

            var result = cal.Add(1, 3);

            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void Divide_TwoIntNotZero_ReturnEqual()
        {
            var divideNotZero = new Caculator();

            var result = divideNotZero.Devide(4,2);

            Assert.AreEqual(2, result);
        }
    }
}