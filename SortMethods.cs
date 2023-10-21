using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

      arrForSort.Reverse();

      return UnGlueArr(arr, arrForSort);
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
