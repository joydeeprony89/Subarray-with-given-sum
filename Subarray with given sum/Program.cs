// https://practice.geeksforgeeks.org/problems/subarray-with-given-sum/0
// Given an unsorted array A of size N of non-negative integers, find a continuous sub-array which adds to a given number S.

//Input:
//The first line of input contains an integer T denoting the number of test cases.
//Then T test cases follow.Each test case consists of two lines.
//The first line of each test case is N and S, where N is the size of array and S is the sum.
//The second line of each test case contains N space separated integers denoting the array elements.

//Output:
//For each testcase, in a new line, print the starting and ending positions(1 indexing) of first such occuring subarray from the left if sum equals to subarray, else print -1.

//Constraints:
//1 <= T <= 100
//1 <= N <= 107
//1 <= Ai <= 1010

//Example:
//Input:
//2
//5 12
//1 2 3 7 5
//10 15
//1 2 3 4 5 6 7 8 9 10
//Output:
//2 4
//1 5

//Explanation : 
//Testcase1: sum of elements from 2nd position to 4th position is 12
//Testcase2: sum of elements from 1st position to 5th position is 15

using System;

namespace Subarray_with_given_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int noOfTesCase = Convert.ToInt32(Console.ReadLine());
            while (noOfTesCase > 0)
            {
                noOfTesCase--;
                string sizeAndSum = Console.ReadLine();
                int[] convertedSizeAndSum = Array.ConvertAll<string, int>(sizeAndSum.Split(" "), Int32.Parse);
                int size = convertedSizeAndSum[0];
                int sum = convertedSizeAndSum[1];
                int[] inputArray = Array.ConvertAll<string, int>(Console.ReadLine().Split(" "), Int32.Parse);
                for (int i = 0; i < inputArray.Length - 1; i++)
                {
                    int j = i;
                    int elementSum = 0;
                    while (elementSum <= sum)
                    {
                        if (elementSum == sum)
                        {
                            Console.WriteLine("{0} {1}", i + 1, j);
                            break;
                        }
                        elementSum = elementSum + inputArray[j];
                        j++;
                    }
                }
            }
            Console.WriteLine(-1);
            Console.ReadKey();
        }
    }
}
