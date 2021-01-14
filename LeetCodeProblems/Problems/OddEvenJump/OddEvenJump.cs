//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace LeetCodeProblems.Problems.GoogleProblems
//{
//    public class OddEvenJump
//    {

//        public OddEvenJump()
//        {

//        }

//        public int OddEvenJumps(int[] A)
//        {
//            if(A.Length < 1 || A.Length > 10000)
//            {
//                return -1;
//            }
//            else
//            {
//                bool isEven = false;
//                bool isGood = false;
//                IDictionary<int, IList<int>> valueWithIndicesList = new Dictionary<int, IList<int>>();


//                for(int i = 0; i < A.Length; i++)
//                {
//                    if (valueWithIndicesList.ContainsKey(A[i]))
//                    {
//                        valueWithIndicesList[A[i]].Add(i);
//                    }
//                    else
//                    {
//                        valueWithIndicesList[A[i]] = new List<int>();
//                        valueWithIndicesList[A[i]].Add(i);
//                    }
//                }




//                int jump = 1;
//                IList<int> incidenceList = new List<int>();
//                for (int i = 0; i < A.Length; i++)
//                {

//                    int maxmin = 0;
//                    isEven = (jump % 2 == 0) ? true : false;
//                    if (isEven)
//                    {

//                    }
//                    else
//                    {
//                        int min = 10001;
//                        int cur = i + 1;
//                        while (cur < A.Length)
//                        {
//                            if(A[cur] <= A[i] && min > A[cur])
//                            {
//                                min = A[cur];
//                                incidenceList.Add(cur);//keep track of the indeces
//                            }
//                        }


//                    }
//                    jump++;


//                }

//                return -1;
//            }
//        }

//        public int JumpOdd()
//        {

//        }

//        public int JumpEven()
//        {

//        }

//    }
//}
