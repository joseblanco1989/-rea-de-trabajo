using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parte1
{
    public class MoneyParts
    {
        public MoneyParts()
        { }

        public string build(string monto)
        {
            decimal[] valores = new decimal[] { 0.05m, 0.1m, 0.2m, 0.5m, 1, 2, 5, 10, 20, 50, 100, 200 };
            string retorno = string.Empty;
            decimal dMonto = Convert.ToDecimal(monto);
            for (int i = 0; i < valores.Length; i++)
            {
                resta(ref retorno, ref dMonto, valores[i]);
            }
            return retorno;
        }

        private void resta(ref string retorno, ref decimal dMonto, decimal moneda)
        {
            if (moneda > 0.5m)
            {
                if (Convert.ToInt32(dMonto) % moneda == 0)
                {
                    int restar = Convert.ToInt32(dMonto / moneda);
                    for (int i = 0; i < restar; i++)
                    {
                        retorno += moneda.ToString() + "|";
                    }
                }
            }
            else
            {
                if (dMonto % moneda == 0)
                {
                    int restar = Convert.ToInt32(dMonto / moneda);
                    for (int i = 0; i < restar; i++)
                    {
                        retorno += moneda.ToString() + "|";
                    }
                }
            }
        }
    }
}
