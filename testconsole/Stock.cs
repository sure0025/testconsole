using System;
using System.Globalization;

namespace testconsole
{
    internal class Stock : IAsset 
    {
               
      
        // constuctor
        public Stock()
        {
            
        }

      
        //Constructor with properties
        public Stock(string v1, double v2 , int v3 )
        {
            this.Symbol = v1;
            this.PricePerShare = v2;
            this.NumShares = v3;
          
        }

        //Properties
        public int NumShares { get; internal set; }
        public double PricePerShare { get; internal set; }
        public string Symbol { get; internal set; }

        //returns GetValue
        public double GetValue()
        {
            return PricePerShare * NumShares; 
        }

        //returns TotalValue
        internal static double TotalValue(IAsset[] stocks)
        {
            double result = 0 ;
            for (int i = 0; i < stocks.Length; i++)
            {
                result = result + stocks[i].GetValue(); 
            }
                return result; 

        }

            
        public override string ToString()
        {
            return "Stock[symbol=" + Symbol + ",pricePerShare=" +PricePerShare.ToString(CultureInfo.CreateSpecificCulture("en-GB"))+ ",numShares=" + NumShares+ "]";
        }
     
       public bool Equals(Stock obj)
        {
            if (this.Symbol == obj.Symbol && this.PricePerShare == obj.PricePerShare && this.NumShares == obj.NumShares)
            {
                return true;
            }
            return false;
        }

        
    }
}