using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pandas_second_day
{
    class _8Pandas2
    {

        // Returns length of length common 
        // subsequence for str1[0..m-1], 
        // str2[0..n-1]
        static int lcs(string str1, string str2,
                                  int m, int n)
        {
            int[,] L = new int[m + 1, n + 1];
            int i, j;

            // Following steps build L[m+1][n+1] in
            // bottom up fashion. Note that L[i][j]
            // contains length of LCS of str1[0..i-1]
            // and str2[0..j-1] 
            for (i = 0; i <= m; i++)
            {
                for (j = 0; j <= n; j++)
                {
                    if (i == 0 || j == 0)
                        L[i, j] = 0;

                    else if (str1[i - 1] == str2[j - 1])
                        L[i, j] = L[i - 1, j - 1] + 1;

                    else
                        L[i, j] = Math.Max(L[i - 1, j],
                                           L[i, j - 1]);
                }
            }

            // L[m][n] contains length of LCS 
            // for X[0..n-1] and Y[0..m-1] 
            return L[m, n];
        }

        // function to find minimum number 
        // of deletions and insertions 
        static void printMinDelAndInsert(string str1,
                                         string str2)
        {
            int m = str1.Length;
            int n = str2.Length;

            int len = lcs(str1, str2, m, n);

            Console.Write("Minimum number of " +
                                    "deletions = ");
            Console.WriteLine(m - len);

            Console.Write("Minimum number of " +
                                   "insertions = ");
            Console.Write(n - len);
        }
        // Driver program to test above

        public void Run()
        {
            string str1 = "heap";
            string str2 = "pea";
            printMinDelAndInsert(str1, str2);
        }

    }
}

// This code is contributed by nitin mittal.