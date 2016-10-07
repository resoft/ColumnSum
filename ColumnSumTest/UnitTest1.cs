using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ColumnSum;
using System.Collections.Generic;
using ExpectedObjects;
using System.Linq;

namespace ColumnSumTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestRowSumBy_3()
        {
            List<int> expected = new List<int> { 6, 15, 24, 21 };

            IEnumerable<int> columnData = new Table().Get().Select(x => x.Cost);
            
            var columnHandle = new ColumnHandlet<int>();
            columnHandle.SetData(columnData);

            List<int> actual = columnHandle.SumList(3);

            expected.ToExpectedObject().ShouldEqual(actual);

            //Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestRowSumBy_4()
        {
            List<int> expected = new List<int> { 50, 66, 60 };

            IEnumerable<int> columnData = new Table().Get().Select(x => x.Revenue);

            var columnHandle = new ColumnHandlet<int>();
         
            columnHandle.SetData(columnData);

            List<int> actual = columnHandle.SumList(4);

            expected.ToExpectedObject().ShouldEqual(actual);

            //Assert.AreEqual(expected, actual);
        }
      
    }
}
