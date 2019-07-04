/*
  An array is monotonic if it is either monotone increasing or monotone decreasing.
  An array A is monotone increasing if for all i <= j, A[i] <= A[j].  An array A is monotone decreasing if for all i <= j, A[i] >= A[j].
  Return true if and only if the given array A is monotonic.
--------------------
Input: [1,2,2,3]
Output: true
--------------------
Input: [6,5,4,4]
Output: true
--------------------
Input: [1,3,2]
Output: false
--------------------
*/
class Program
{
  //One Pass
  public bool isMonotonicHardLevele(int[] A)
  {
    int store = 0;
    for (int i = 0; i < A.Length - 1; ++i)
    {
      int c = A[i].CompareTo(A[i + 1]);
      if (c != 0)
      {
        if (c != store && store != 0)
          return false;
        store = c;
      }
    }
    return true;
  }
// Two Pass
  public bool isMonotonic(int[] A)
  {
    return increase(A) || decrease(A);
  } 

  public bool increase(int[] array)
  {
    for (int i = 0; i < array.Length - 1; i++)
        if (array[i] > array[i + 1]) return false;
    return true;
  }

  public bool decrease(int[] array)
  {
    for (int i = 0; i < array.Length - 1; i++)
        if (array[i] < array[i + 1]) return false;
    return true;
  }
  static void Main(string[] args)
  {
    Program pr = new Program();
    int[] A = { 1, 1, 1, 1, 2, 3 };

    try
    {
        if (pr.isMonotonicHardLevele(A))
        {
            Console.WriteLine("Is Monotone ");

        }
        else
        {
            Console.WriteLine("Isn't Monotone");
        }

    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }


  }
}
