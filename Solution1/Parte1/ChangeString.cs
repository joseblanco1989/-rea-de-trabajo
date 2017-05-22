using System;

namespace Parte1
{
    public class ChangeString
    {
        public ChangeString()
        { }

        public string build(ref string sModificar)
        {
            var array = sModificar.ToCharArray();
            int indiceChar = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if ((Convert.ToInt32(array[i]) >= 97 && Convert.ToInt32(array[i]) <= 122) ||
                    (Convert.ToInt32(array[i]) >= 65 && Convert.ToInt32(array[i]) <= 90) ||
                    (Convert.ToInt32(array[i]) == 241) ||
                    (Convert.ToInt32(array[i]) == 209))
                {
                    indiceChar = Convert.ToInt32(array[i]) + 1;
                    switch (indiceChar)
                    {
                        case 79:
                            indiceChar = 209;
                            break;
                        case 91:
                            indiceChar = 65;
                            break;
                        case 111:
                            indiceChar = 241;
                            break;
                        case 123:
                            indiceChar = 97;
                            break;
                        case 210:
                            indiceChar = 79;
                            break;
                        case 242:
                            indiceChar = 111;
                            break;
                    }
                    array[i] = Convert.ToChar(Char.ConvertFromUtf32(indiceChar));
                }
            }
            return new string(array);
        }
    }
}
