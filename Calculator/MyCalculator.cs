using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class MyCalculator
    {
        public ArrayList HomeWorkSum<T> (string columValue, int numberValue, IEnumerable<T> actualSum) //泛型才可以計算各種欄位
        {
            ArrayList columSum = new ArrayList();

            int count = 0;
            int sum = 0;  //宣告總和為零
            foreach (var item in actualSum)
            {
                count++;
                sum += Convert.ToInt32(item.GetType().GetProperty(columValue).GetValue(item).ToString()); //GetType型別 .toint32轉整數

                if (count % numberValue == 0)
                {
                    columSum.Add(sum); //加總
                    sum = 0; //重算
                }


            }

            if (count % numberValue != 0 && count == actualSum.Count())
            {
                columSum.Add(sum); //補上最後一個加總
            }

            return columSum;
           
        }
    }

}
