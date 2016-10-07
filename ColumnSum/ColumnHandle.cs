using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ColumnSum
{
    public class ColumnHandlet<T>
    {

        public List<int> SumList(int rowSum)
        {
            IEnumerable<T> columnData = GetColumnData();
            int number;
            var returnList = columnData.Select((v, i) => new { val = v, index = i + 1 })
                  .Where(x => int.TryParse(x.val.ToString(), out number))
                  .GroupBy(x => Convert.ToInt16(Math.Ceiling((double)x.index / rowSum)))
                  .Select(x =>
                  new
                  {
                      Index = x.Key,
                      SumValue = x.Sum(w => int.Parse(w.val.ToString()))
                  });

            return returnList.Select(x => x.SumValue).ToList<int>();
        }

        private IEnumerable<T> _data;

        public void SetData(IEnumerable<T> data)
        {
            this._data = data;
        }

        protected virtual IEnumerable<T> GetColumnData()
        {
            return this._data;
        }
    }

    public class Table
    {
        public List<Order> Get()
        {
            List<Order> orderList = new List<Order>();
            orderList.Add(new Order() { Id = 1, Cost = 1, Revenue = 11, SellPrice = 21, Other = 1 });
            orderList.Add(new Order() { Id = 2, Cost = 2, Revenue = 12, SellPrice = 22, Other = 1 });
            orderList.Add(new Order() { Id = 3, Cost = 3, Revenue = 13, SellPrice = 23, Other = 1 });
            orderList.Add(new Order() { Id = 4, Cost = 4, Revenue = 14, SellPrice = 24, Other = "" });
            orderList.Add(new Order() { Id = 5, Cost = 5, Revenue = 15, SellPrice = 25, Other = 1 });
            orderList.Add(new Order() { Id = 6, Cost = 6, Revenue = 16, SellPrice = 26, Other = "test" });
            orderList.Add(new Order() { Id = 7, Cost = 7, Revenue = 17, SellPrice = 27, Other = 1 });
            orderList.Add(new Order() { Id = 8, Cost = 8, Revenue = 18, SellPrice = 28, Other = 1 });
            orderList.Add(new Order() { Id = 9, Cost = 9, Revenue = 19, SellPrice = 29, Other = 0 });
            orderList.Add(new Order() { Id = 10, Cost = 10, Revenue = 20, SellPrice = 30, Other = 1 });
            orderList.Add(new Order() { Id = 11, Cost = 11, Revenue = 21, SellPrice = 31, Other = 1 });

            return orderList;
        }
    }

    public class Order
    {
        public int Id { get; set; }
        public int Cost { get; set; }
        public int Revenue { get; set; }
        public int SellPrice { get; set; }

        public object Other { get; set; }
    }
}
