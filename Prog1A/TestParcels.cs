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

// File: TestParcels.cs
// This is a simple, console application designed to exercise the Parcel hierarchy.
// It creates several different Parcels and prints them. Also,
// It displays the orginal parcel list then applies different sorts
// and displays them to the screen one at a time

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog1
{
    class TestParcels
    {
        // Precondition:  None
        // Postcondition: Parcels have been created and displayed
        static void Main(string[] args)
        {
            // Test Data - Magic Numbers OK
            Address a1 = new Address("John Smith", "123 Any St.", "Apt. 45",
                "Louisville", "KY", 40202); // Test Address 1
            Address a2 = new Address("Jane Doe", "987 Main St.", "",
                "Beverly Hills", "CA", 90210); // Test Address 2
            Address a3 = new Address("James Kirk", "654 Roddenberry Way", "Suite 321",
                "El Paso", "TX", 79901); // Test Address 3
            Address a4 = new Address("John Crichton", "678 Pau Place", "Apt. 7",
                "Portland", "ME", 04101); // Test Address 4
            Address a5 = new Address("Luke Sky", "698 Force St.", "Apt. 3",
                       "Las Vegas", "NV", 30202); // Test Address 5
            Address a6 = new Address("Frodo Bag", "124 Bagshot St.", "",
                "San Francisco", "CA", 80410); // Test Address 6
            Address a7 = new Address("Walt Whit", "621 Blue Way", "Suite 001",
                "Albuquerque", "New Mexico", 59901); // Test Address 7
            Address a8 = new Address("John Dorian", "678 Sacred Heart", "Apt. 8",
                "Phoenix", "AZ", 18101); // Test Address 8

            Letter letter1 = new Letter(a1, a2, 3.95M);                            // Letter test object
            GroundPackage gp1 = new GroundPackage(a3, a4, 14, 10, 5, 12.5);        // Ground test object
            NextDayAirPackage ndap1 = new NextDayAirPackage(a1, a3, 25, 15, 15,    // Next Day test object
                85, 7.50M);
            TwoDayAirPackage tdap1 = new TwoDayAirPackage(a4, a1, 46.5, 39.5, 28.0, // Two Day test object
                80.5, TwoDayAirPackage.Delivery.Saver);
            TwoDayAirPackage tdap2 = new TwoDayAirPackage(a6, a8, 80, 20, 24.0, // Two Day test object
                92.5, TwoDayAirPackage.Delivery.Early);                        
            GroundPackage gp2 = new GroundPackage(a7, a5, 12, 15, 8, 10);   // Ground test object
            Letter letter2 = new Letter(a1, a8, 5.80M);                     // Letter object
            NextDayAirPackage ndap2 = new NextDayAirPackage(a7, a6, 28, 11, 14,    // Next Day test object
                105, 10.75M);
            GroundPackage gp3 = new GroundPackage(a8, a4, 15, 20, 18, 24); // Ground test object
            TwoDayAirPackage tdap3 = new TwoDayAirPackage(a2, a5, 50, 30, 28.0, // Two Day test object
                100.5, TwoDayAirPackage.Delivery.Early);
            List<Parcel> parcels;      // List of test parcels

            parcels = new List<Parcel>();

            parcels.Add(letter1); // Populate list
            parcels.Add(gp1);
            parcels.Add(ndap1);
            parcels.Add(tdap1);
            parcels.Add(letter2);
            parcels.Add(gp2);
            parcels.Add(ndap2);
            parcels.Add(tdap2);
            parcels.Add(gp3);
            parcels.Add(tdap3);
            // Display Orginal list
            Console.WriteLine("Original List:");
            Console.WriteLine("====================");
            foreach (Parcel p in parcels) // Steps through list
            {
                Console.WriteLine(p); // display every parcel in the list
                Console.WriteLine("====================");
            }
            Pause(); // Pause the screen until user hits enter

            parcels.Sort();  // Sort the parcels list by its default, cost ascending
            // Display parcels sorted by cost
            Console.WriteLine("Sorted List by Cost:");
            Console.WriteLine("====================");         
            foreach (Parcel p in parcels) // Steps through list
            {
                Console.WriteLine(p);  // display every parcel in the sorted list
                Console.WriteLine("====================");
            }
            Pause(); // Pause the screen until user hits enter

            parcels.Sort(new DescendingZipOrder()); // Sort the parcels list by Destination zip in descending order
            // Display parcels sorted in the descending destination zip order
            Console.WriteLine("Sorted List by Zip Descending:");
            Console.WriteLine("====================");
            foreach (Parcel p in parcels) // Steps through list
            {
                Console.WriteLine(p); // display every parcel in the sorted list
                Console.WriteLine("====================");
            }
            Pause(); // Pause the screen until user hits enter

            parcels.Sort(new ParcelCostOrder()); // Sort the parcels list by type of parcel in ascending
                                                 // and then cost in descending order
            // Display the parcels sorted using ParcelCostOrder
            Console.WriteLine("Sorted List by Type then Cost:");
            Console.WriteLine("====================");
            foreach (Parcel p in parcels)  // Steps through list
            {
                Console.WriteLine(p); // display every parcel in the sorted list
                Console.WriteLine("====================");
            }
            Pause(); // Pause the screen until user hits enter
        }

        // Precondition:  None
        // Postcondition: Pauses program execution until user presses Enter and
        //                then clears the screen
        public static void Pause()
        {
            Console.WriteLine("Press Enter to Continue...");
            Console.ReadLine();

            Console.Clear(); // Clear screen
        }
    }
}
