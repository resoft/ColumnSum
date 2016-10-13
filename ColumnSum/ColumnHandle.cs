using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ColumnSum
{
    public static class ColumnHandlet
    {
        public static IEnumerable<int> GetSum<TSource>(this IEnumerable<TSource> source, Func<TSource, int> selector, int rowSum)
        {
            int index = 0;
            while (index < source.Count())
            {
                yield return source.Skip(index).Take(rowSum).Sum(selector);
                index += rowSum;
            }
        }

        //public List<int> SumList(int rowSum)
        //{
        //    IEnumerable<T> columnData = GetColumnData();
        //    int number;
        //    var returnList = columnData.Select((v, i) => new { val = v, index = i + 1 })
        //          .Where(x => int.TryParse(x.val.ToString(), out number))
        //          .GroupBy(x => Convert.ToInt16(Math.Ceiling((double)x.index / rowSum)))
        //          .Select(x =>
        //          new
        //          {
        //              Index = x.Key,
        //              SumValue = x.Sum(w => int.Parse(w.val.ToString()))
        //          });

        //    return returnList.Select(x => x.SumValue).ToList<int>();
        //}

        //private IEnumerable<T> _data;

        //public void SetData(IEnumerable<T> data)
        //{
        //    this._data = data;
        //}

        //protected virtual IEnumerable<T> GetColumnData()
        //{
        //    return this._data;
        //}


    }
}
