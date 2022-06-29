using System.Collections.Generic;
using CurrencyApp.Models;

namespace CurrencyApp.Data
{
    public class CurrencyData
    {
        public static List<CurrencyModel> Currencies = new List<CurrencyModel>()
        {
            new CurrencyModel {Currency = "PHP", Name = "Philippines"},
            new CurrencyModel {Currency = "USD", Name = "United States"},
            new CurrencyModel {Currency = "JPY", Name = "Japan"},
            new CurrencyModel {Currency = "SGD", Name = "Singapore"},
            new CurrencyModel {Currency = "EUR", Name = "Spain"},
            new CurrencyModel {Currency = "EUR", Name = "Vatican City"},
            new CurrencyModel {Currency = "THB", Name = "Thailand"},
            new CurrencyModel {Currency = "KRW", Name = "South Korean Won"},
            new CurrencyModel {Currency = "USD", Name = "Puerto Rico"},
            new CurrencyModel {Currency = "NOK", Name = "Norway"},
            new CurrencyModel {Currency = "EUR", Name = "Italy"}
        };
    }
}
