// File: DescendingZipOrder.cs
// This class provides an IComparer for the Parcel class
// that orders the objects based on destination zip in descending order
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog1
{
    class DescendingZipOrder : Comparer<Parcel> 
    {
        // Precondition:  None
        // Postcondition: Returns and reverses destination zip order, so it is descending
        //                When p1 < p2, method returns positive #
        //                When p1 == p2, method returns zero
        //                When p1 > p2, method returns negative #
        public override int Compare(Parcel p1, Parcel p2)
        {
            // Ensure correct handling of null values (in .NET, null less than anything)
            if (p1 == null && p2 == null) // Both null
                return 0;                 // Equal

            if (p1 == null) // only p1 is null
                return -1;  // null is less than any zip

            if (p2 == null) // only p2 is null
                return 1;   // Any zip is greater than null

            // Reverses natural order, so it is descending by using negative 1
                return (-1) * p1.DestinationAddress.Zip.CompareTo(p2.DestinationAddress.Zip); // compares destination zips
           

        }
    }
}
