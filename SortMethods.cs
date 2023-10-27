using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sem2_lab4 {
  public static class SortMethods {
    public static TimeSpan[] timeExecution = new TimeSpan[5];

    public static double?[,] BubbleSort(double?[,] arr) {
      double?[] arrForSort = GlueArr(arr);

      var stopWatch = new Stopwatch();

      stopWatch.Start();

      double? temp;
      for (int indexRow = 0; indexRow < arrForSort.Length; indexRow++) {
        for (int indexColumn = indexRow + 1; indexColumn < arrForSort.Length; indexColumn++) {
          if (arrForSort[indexRow] > arrForSort[indexColumn]) {
            temp = arrForSort[indexRow];
            arrForSort[indexRow] = arrForSort[indexColumn];
            arrForSort[indexColumn] = temp;
          }
        }
      }

      stopWatch.Stop();

      timeExecution[0] = stopWatch.Elapsed;

      return UnGlueArr(arr, arrForSort);
    }

    public static double?[,] BubbleSortRev(double?[,] arr) {
      double?[] arrForSort = GlueArr(arr);

      var stopWatch = new Stopwatch();

      stopWatch.Start();

      double? temp;
      for (int indexRow = 0; indexRow < arrForSort.Length; indexRow++) {
        for (int indexColumn = indexRow + 1; indexColumn < arrForSort.Length; indexColumn++) {
          if (arrForSort[indexRow] > arrForSort[indexColumn]) {
            temp = arrForSort[indexRow];
            arrForSort[indexRow] = arrForSort[indexColumn];
            arrForSort[indexColumn] = temp;
          }
        }
      }

      stopWatch.Stop();

      timeExecution[0] = stopWatch.Elapsed;

      Array.Reverse(arrForSort);

      return UnGlueArr(arr, arrForSort);
    }

    public static double?[,] PastSort(double?[,] arr) {
      double?[] arrForSort = GlueArr(arr);

      var stopWatch = new Stopwatch();

      stopWatch.Start();

      for (int index = 1; index < arrForSort.Length; ++index) {
        double? currElement = arrForSort[index];
        int prevElement = index - 1;

        while (prevElement >= 0 && arrForSort[prevElement] > currElement) {
          arrForSort[prevElement + 1] = arrForSort[prevElement];
          arrForSort[prevElement] = currElement;
          --prevElement;
        }
      }

      stopWatch.Stop();

      timeExecution[1] = stopWatch.Elapsed;

      return UnGlueArr(arr, arrForSort);
    }

    public static double?[,] PastSortRev(double?[,] arr) {
      double?[] arrForSort = GlueArr(arr);

      var stopWatch = new Stopwatch();

      stopWatch.Start();

      for (int index = 1; index < arrForSort.Length; ++index) {
        double? currElement = arrForSort[index];
        int prevElement = index - 1;

        while (prevElement >= 0 && arrForSort[prevElement] > currElement) {
          arrForSort[prevElement + 1] = arrForSort[prevElement];
          arrForSort[prevElement] = currElement;
          --prevElement;
        }
      }

      stopWatch.Stop();

      timeExecution[1] = stopWatch.Elapsed;

      Array.Reverse(arrForSort);

      return UnGlueArr(arr, arrForSort);
    }

    public static double?[,] ShakerSort(double?[,] arr) {
      double?[] arrForSort = GlueArr(arr);

      var stopWatch = new Stopwatch();

      stopWatch.Start();

      int leftBorder = 0;
      int rightBorder = arr.Length - 1;
      bool exchange;

      do {
        exchange = false;

        BubbleForShaker(ref arrForSort, leftBorder, rightBorder, ref exchange);
        --rightBorder;

        BubbleForShaker(ref arrForSort, rightBorder, leftBorder, ref exchange);
        ++leftBorder;
      } while (exchange);

      stopWatch.Stop();

      timeExecution[2] = stopWatch.Elapsed;

      return UnGlueArr(arr, arrForSort);
    }

    public static double?[,] ShakerSortRev(double?[,] arr) {
      double?[] arrForSort = GlueArr(arr);

      var stopWatch = new Stopwatch();

      stopWatch.Start();

      int leftBorder = 0;
      int rightBorder = arr.Length - 1;
      bool exchange;

      do {
        exchange = false;

        BubbleForShaker(ref arrForSort, leftBorder, rightBorder, ref exchange);
        --rightBorder;

        BubbleForShaker(ref arrForSort, rightBorder, leftBorder, ref exchange);
        ++leftBorder;
      } while (exchange);

      stopWatch.Stop();

      timeExecution[2] = stopWatch.Elapsed;

      Array.Reverse(arrForSort);

      return UnGlueArr(arr, arrForSort);
    }

    private static void BubbleForShaker(ref double?[] b, int n, int m, ref bool exchange) {
      double? temp;

      if (m == n) return;

      if (n < m) {
        for (int i = n; i < m; i++) {
          if (b[i] > b[i + 1]) {
            temp = b[i];
            b[i] = b[i + 1];
            b[i + 1] = temp;
            exchange = true;
          }
        }
      } else {
        for (int i = n; i > m; i--) {
          if (b[i] < b[i - 1]) {
            temp = b[i];
            b[i] = b[i - 1];
            b[i - 1] = temp;
            exchange = true;
          }
        }
      }
      return;
    }

    public static double?[,] QuickSort(double?[,] arr) {
      double?[] arrForSort = GlueArr(arr);

      var stopWatch = new Stopwatch();

      stopWatch.Start();

      int minIndex = 0;
      int maxIndex = arrForSort.Length - 1;

      arrForSort = QuickSortRecursion(arrForSort, minIndex, maxIndex);

      stopWatch.Stop();

      timeExecution[3] = stopWatch.Elapsed;

      return UnGlueArr(arr, arrForSort);
    }

    public static double?[,] QuickSortRev(double?[,] arr) {
      double?[] arrForSort = GlueArr(arr);

      var stopWatch = new Stopwatch();

      stopWatch.Start();

      int minIndex = 0;
      int maxIndex = arrForSort.Length - 1;

      arrForSort = QuickSortRecursion(arrForSort, minIndex, maxIndex);

      stopWatch.Stop();

      timeExecution[3] = stopWatch.Elapsed;

      Array.Reverse(arrForSort);

      return UnGlueArr(arr, arrForSort);
    }

    private static double?[] QuickSortRecursion(double?[] arr, int minIndex, int maxIndex) {
      if (minIndex >= maxIndex) {
        return arr;
      }

      int pivot = QuickSortFindPivot(arr, minIndex, maxIndex);

      QuickSortRecursion(arr, minIndex, pivot - 1);
      QuickSortRecursion(arr, pivot + 1, maxIndex);

      return arr;
    }

    private static int QuickSortFindPivot(double?[] arr, int minIndex, int maxIndex) {
      int pivot = minIndex - 1;
      double? temp = 0;

      for (int index = minIndex; index < maxIndex; ++index) {
        if (arr[index] < arr[maxIndex]) {
          ++pivot;
          temp = arr[pivot];
          arr[pivot] = arr[index];
          arr[index] = temp;
        }
      }

      ++pivot;

      temp = arr[pivot];
      arr[pivot] = arr[maxIndex];
      arr[maxIndex] = temp;

      return pivot;
    }

    public static double?[,] BogoSort(double?[,] arr) {
      double?[] arrForSort = GlueArr(arr);

      var stopWatch = new Stopwatch();

      stopWatch.Start();

      while (!IsSorted(arrForSort)) {
        arrForSort = RandomPermutation(arrForSort);
      }

      stopWatch.Stop();

      timeExecution[4] = stopWatch.Elapsed;

      return UnGlueArr(arr, arrForSort);
    }

    public static double?[,] BogoSortRev(double?[,] arr) {
      double?[] arrForSort = GlueArr(arr);

      var stopWatch = new Stopwatch();

      stopWatch.Start();

      while (!IsSorted(arrForSort)) {
        arrForSort = RandomPermutation(arrForSort);
      }

      stopWatch.Stop();

      timeExecution[4] = stopWatch.Elapsed;

      Array.Reverse(arrForSort);

      return UnGlueArr(arr, arrForSort);
    }

    private static bool IsSorted(double?[] arr) {
      for (int index = 0; index < arr.Length - 1; ++index) {
        if (arr[index] > arr[index + 1]) {
          return false;
        }
      }

      return true;
    }

    private static double?[] RandomPermutation(double?[] arr) {
      Random random = new Random();
      int arrCount = arr.Length;

      while (arrCount > 1) {
        --arrCount;

        int index = random.Next(arrCount + 1);
        double? temp = arr[index];

        arr[index] = arr[arrCount];
        arr[arrCount] = temp;
      }

      return arr;
    }

    public static double?[] GlueArr(double?[,] arr) {
      double?[] newArr = new double?[arr.Length];

      int newArrIndex = default;
      for (int indexRow = 0; indexRow < arr.GetLength(0); ++indexRow) {
        for (int indexColumn = 0; indexColumn < arr.GetLength(1); ++indexColumn) {
          newArr[newArrIndex] = arr[indexRow, indexColumn];
          ++newArrIndex;
        }
      }

      return newArr;
    }

    public static double?[,] UnGlueArr(double?[,] arr, double?[] singleArr) {
      int newArrIndex = default;
      for (int indexRow = 0; indexRow < arr.GetLength(0); ++indexRow) {
        for (int indexColumn = 0; indexColumn < arr.GetLength(1); ++indexColumn) {
          arr[indexRow, indexColumn] = singleArr[newArrIndex];
          ++newArrIndex;
        }
      }

      return arr;
    }
  }
}
