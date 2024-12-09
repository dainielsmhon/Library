using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library
{
    public class GlobFunc
    {
        public static int GetMax(int[] arr)
        {
            int max = arr[0];

            for (int i = 0; i < arr.Length; i++)
                if (arr[i] > max)
                    max = arr[i];
            return max;
        }



            public static float GetMax(float[] arr)
            {
                float max = arr[0];

                for (int i = 0; i < arr.Length; i++)
                    if (arr[i] > max)
                        max = arr[i];
                return max;



            }


            public static T GetMax<T>(T[] arr)
            {
                T max = arr[0];

                for (int i = 0; i < arr.Length; i++)
                    if (arr[i].ToString().CompareTo(max.ToString()) > 0)
                        max = arr[i];
                return max;





            }
            public static void func()
            {
                int[] arr = new int[] { 4, 7, 2, 8, 5 };
                int max = GetMax<int>(arr);
                float[] arr2 = new float[] { 4, 7, 2, 8, 5 };
            }

    }
}
