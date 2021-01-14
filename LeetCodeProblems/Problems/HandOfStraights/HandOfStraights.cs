using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeProblems.Problems.HandOfStraights
{
    public class HandOfStraights
    {
        public bool IsNStraightHand(int[] hand, int W)
        {
            //if we cannot evenly divide the total cards in W hands then we return false
            if (hand.Length % W != 0)
            {
                return false;
            }
            else
            {
                int handLen = hand.Length;
                int numberOfHands = handLen / W; //number of hands we will have

                Array.Sort(hand);//sort the hand

                List<int> handList = hand.ToList();//turn array into a list for manipulation

                while (numberOfHands > 0)//while we still need to create hands
                {
                    int i = 0;

                    List<int> currentHand = new List<int>(numberOfHands);//create a current list to manipulate 

                    //loop and add entries to the current hand while we still have space
                    while (i != handList.Count && currentHand.Count != W)
                    {
                        //  
                        if (currentHand.Count == 0)
                        {
                            currentHand.Add(handList[i]);
                        }
                        else
                        {
                            // make sure the sequence is being followed
                            if (handList[i] - currentHand[currentHand.Count - 1] == 1)
                            {
                                currentHand.Add(handList[i]);
                            }
                        }
                        i++; // increment the counting var
                    }

                    // Check the validity of the current bucket by checking its count
                    if (currentHand.Count != W)
                    {
                        return false;
                    }
                    else
                    {
                        // Remove the elements already added from the main list
                        for (int j = 0; j < currentHand.Count; j++)
                        {
                            handList.Remove(currentHand[j]);
                        }

                        // Decreemnt the no of buckets
                        numberOfHands--;
                    }

                }
                return true;
            }



        }
    }
}
