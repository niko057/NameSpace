

namespace NameSpace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] array1 = { 1, 2, 3, 4, 5 };
            //int[] array2 = { 3,2,4};

            //bool result = IsArrayContains(array1, array2);

            //Console.WriteLine(result);

            Student student = new Student();

            student.Run();

         

          
           
        }

        static bool IsArrayContains(int[] array1, int[] array2)
        {
            if (array2.Length > array1.Length)
                return false;

            for (int i = 0; i <= array1.Length - array2.Length; i++)
            {
                bool found = true;
                for (int j = 0; j < array2.Length; j++)
                {
                    if (array1[i + j] != array2[j])
                    {
                        found = false;
                        break;
                    }
                }
                if (found)
                    return true;
            }
            return false;
        }


    }

}


