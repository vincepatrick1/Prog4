// Program 4
// CIS 200-01
// Fall 2016
// Due: 11/29/2016
// By: C6181/ Andrew L. Wright (students use Grading ID)
// Description: This program allows the user to sort a list of parcels 
// by implementing the IComparable interface in Parcel.cs and extending 
// it using Comparer in DescendingZipOrder.cs and ParcelCostOrder.cs
// then displays the list and sorted lists to the console application
// in TestParcels.cs

// File: Parcel.cs
// Parcel serves as the abstract base class of the Parcel hierachy.
// Supports the IComparable Interface and makes default sort order 
// for parcels be by cost ascending. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class Parcel : IComparable<Parcel>
{
    // Precondition:  None
    // Postcondition: The parcel is created with the specified values for
    //                origin address and destination address
    public Parcel(Address originAddress, Address destAddress)
    {
        OriginAddress = originAddress;
        DestinationAddress = destAddress;
    }

    public Address OriginAddress
    {
        // Precondition:  None
        // Postcondition: The parcel's origin address has been returned
        get;

        // Precondition:  None
        // Postcondition: The parcel's origin address has been set to the
        //                specified value
        set;
    }

    public Address DestinationAddress
    {
        // Precondition:  None
        // Postcondition: The parcel's destination address has been returned
        get;

        // Precondition:  None
        // Postcondition: The parcel's destination address has been set to the
        //                specified value
        set;
    }

    // Precondition:  None
    // Postcondition: The parcel's cost has been returned
    public abstract decimal CalcCost();

    // Precondition:  None
    // Postcondition: A String with the parcel's data has been returned
    public override String ToString()
    {
        return String.Format("Origin Address:{3}{0}{3}{3}Destination Address:{3}{1}{3}Cost: {2:C}",
            OriginAddress, DestinationAddress, CalcCost(), Environment.NewLine);
    }
    // Precondition:  None
    // Postcondition: Returns parcels by cost in ascending order
    //                When this < p2, method returns negative #
    //                When this == p2, method returns zero
    //                When this > p2, method returns positive #
    public int CompareTo(Parcel p2)
    {
        // Ensure correct handling of null values (in .NET, null less than anything)

        // Don't need to code these because if this is null, can't call CompareTo method
        //if (this == null && p2 == null) // Both null
        //    return 0;                   // Equal

        //if (this == null) // only this is null
        //    return -1;    // null is less than any cost

        if (p2 == null) // only p2 is null
            return 1;   // Any cost is greater than null
         
            return this.CalcCost().CompareTo(p2.CalcCost());      // compare the cost, returns in ascending order  
       
    }

}
