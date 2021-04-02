using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp
{
    class JumpingClouds
    {
        /// This is just a placeholder until I can think of a description
        ///
        ///
        public static int JumpingOnClouds(int[] c) {
            // Brute force solution

        // Initiate the stepCount
        int stepCount = 0;

        // Loop through the array and count the steps
        for(int i=0; i < c.Count()-1; i++) {
            // Check for end of array
            
            // If next step is a thundercloud jump to the next
            if(c[i]==1) {
                stepCount++;
                i += 1;
            }

            // If next step is a cumulus check the next and do the appropriate jump
            if(i != c.Count()-1) {
                if(c[i]==0 && c[i+1]==0) {
                    stepCount++;
                    i += 1;
                } else {
                    stepCount++;
                    i += 1;
                }
            }
        }

        // Return the stepcount
        return stepCount;
        }
    }
    
}