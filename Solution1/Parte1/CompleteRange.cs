using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parte1
{
    public class CompleteRange
    {
        public CompleteRange()
        { }

        public int[] build(int[] ColInt)
        {
            int mayor = 0;
            foreach (int item in ColInt)
                if (item > mayor) mayor = item;

            int[] iRetorno = new int[mayor];
            for (int i = 0; i < mayor; i++)
                iRetorno[i] = i + 1;

            return iRetorno;
        }
    }
}
