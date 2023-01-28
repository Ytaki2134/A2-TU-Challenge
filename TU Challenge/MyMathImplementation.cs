using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge
{
    public class MyMathImplementation
    {
        public static Func<int, int, int> IsInOrderDesc { get; set; }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static List<int> GenericSort(List<int> toSort, Func<int, int, int> isInOrder)
        {
            int tempSwitch;
            while (!IsListInOrder(toSort))
            {
                for (int i = 0; i < toSort.Count - 1; i++)
                {
                    if (IsInOrder(toSort[i], toSort[i + 1]) == isInOrder(1,0))
                    {
                        tempSwitch = toSort[i];
                        toSort[i] = toSort[i + 1];
                        toSort[i + 1] = tempSwitch;
                    }
                }
            }
            return toSort;
        }

        public static List<int> GetAllPrimary(int a)
        {
            List<int> primaryList = new List<int>();
            for (int i = 2; i <= a; i++)
            {
                if (IsPrimary(i))
                {
                    primaryList.Add(i);
                }
            }
            return primaryList;
        }

        public static bool IsDivisible(int a, int b)
        {
            if(a % b == 0)
            {
                return true;
            }
            return false;
        }

        public static bool IsEven(int a)
        {
            if (a % 2 == 0)
            {
                return true;
            }
            return false;
        }

        public static int IsInOrder(int a, int b)
        {
            if (a == b)
            {
                return 0;
            }
            else if (a < b)
            {
                return 1;
            }
            else if (b < a)
            {
                return -1;
            }
            throw new ArgumentException();
        }

        public static bool IsListInOrder(List<int> list)
        {
            int? tempResult = null;
            for (int i = 0; i < list.Count - 1; i++)
            {
                if (tempResult == null)
                {
                    tempResult = IsInOrder(list[i], list[i + 1]);
                }
                if (IsInOrder(list[i], list[i + 1]) != tempResult)
                {
                    return false;
                }
                tempResult = IsInOrder(list[i], list[i + 1]);
            }
            return true;
        }

        public static bool IsMajeur(int age)
        {
            if (age < 0 || age >= 150)
            {
                throw new ArgumentException();
            }
            else if (age < 18)
            {
                return false;
            }
            return true;
        }

        public static bool IsPrimary(int a)
        {
            if(a == 1)
            {
                return false;
            }
           for(int i = 2; i < a; i++)
            {
                if(a % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static int Power(int a, int b)
        {
            int tempA = a;
            for (int i = 1; i < b; i++)
            {
                a = a * tempA;
            }
            return a;
        }

        public static int Power2(int a)
        {
            return a * a;
        }

        public static List<int> Sort(List<int> toSort)
        {
            int tempSwitch;
            while (!IsListInOrder(toSort))
            {
                for (int i = 0; i < toSort.Count - 1; i++)
                {
                    if (IsInOrder(toSort[i], toSort[i + 1]) == -1)
                    {
                        tempSwitch = toSort[i];
                        toSort[i] = toSort[i + 1];
                        toSort[i + 1] = tempSwitch;
                    }
                }
            }
            return toSort;
        }
    }
}
