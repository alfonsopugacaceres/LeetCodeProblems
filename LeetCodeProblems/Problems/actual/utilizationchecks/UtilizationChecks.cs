using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.actual.utilizationchecks
{
    public class UtilizationChecks
    {
        public static int finalInstances(int instances, List<int> averageUtil)
        {
            //coded the edge cases first
            if(averageUtil.Count < 1 || averageUtil.Count > 100000)
            {
                return 0;
            }
            else
            {
                int i = 0;
                while (i < averageUtil.Count)
                {
                    //code edgecase 
                    if(averageUtil[i] < 0 || averageUtil[i] > 100)
                    {
                        return 0;
                    }
                    else if (averageUtil[i] < 25)
                    {
                        if(instances > 1)//we only perform actions if we have more than 1 instance in case of utilization under 25%
                        {
                            decimal temp = Convert.ToDecimal(averageUtil[i]);
                            instances = Convert.ToInt32(Math.Ceiling(temp / 2));
                            i += 10;//this line acts as the skipping 10 seconds
                        }
                    }
                    else if (averageUtil[i] > 60)
                    {
                        int tempDouble = instances * 2;//storing in temporary to not change instances unless necessary
                        if(tempDouble < 200000000)//check to determine if an action will be taken
                        {
                            instances = tempDouble;
                            i += 10;//this line acts as the skipping 10 seconds
                        }
                    }
                    i++;
                }
                return instances;
            }

        }

    }
}
