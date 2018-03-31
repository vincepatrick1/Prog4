// File: ParcelCostOrder.cs
// This class provides an IComparer for the Parcel class
// that orders the objects based on the type of parcel in ascending order
// then if they are the same type, order by cost in descending order
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog1
{
    class ParcelCostOrder : Comparer<Parcel>
    {
        // Precondition:  None
        // Postcondition: Returns parcels sorted by type ascending, then cost descending
        //                When p1 < p2, method returns positive #
        //                When p1 == p2, method returns zero
        //                When p1 > p2, method returns negative #
        public override int Compare(Parcel p1, Parcel p2)
        {
            // Ensure correct handling of null values (in .NET, null less than anything)
            if (p1 == null && p2 == null) // Both null
                return 0;                 // Equal

            if (p1 == null) // only p1 is null
                return -1;  // null is less than any actual parcel type

            if (p2 == null) // only p2 is null
                return 1;   // Any parcel type is greater than null

            if (p1.GetType().ToString().CompareTo(p2.GetType().ToString()) != 0) // first see if types are same
            {
                return p1.GetType().ToString().CompareTo(p2.GetType().ToString()); // if not same compare types
            }
            else    // if types are same, compare costs
            {
                return (-1) * p1.CalcCost().CompareTo(p2.CalcCost()); // return cost decending 
            }
           

        }
    }
}
