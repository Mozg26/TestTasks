using TestTasks.Models;

namespace TestTasks.Services
{
    public class ArrayProcessingService
    {
        public int moduloSumEverySecondOddNumber(ElemArray elemArray)
        {
            bool flag = false;
            int sum = 0;
            for (int i = 0; i < elemArray.GetLength(); i++)
            {
                if (elemArray.GetElement(i) % 2 != 0)
                    if (flag == true)
                    {
                        sum += Math.Abs(elemArray.GetElement(i));
                        flag = false;
                    }

                    else
                        flag = true;
            }
            return sum;
        }

        public string getArrayString(ElemArray elemArray)
        {
            return elemArray.GetArrayString();
        }
    }
}
