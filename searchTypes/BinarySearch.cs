using System;
namespace searchTypes
{
	public class BinarySearch
	{
        public int[] Nums;
        public string[] fileLines;
        public string fileDirectory;

        public int wantedValue;

        public BinarySearch()
		{
            
            //this line gives in the path of the file into a string
            fileDirectory = "/Users/devinsalgado35/Desktop/ListSearching/searchTypes/scores.txt";
            Nums = fileCovertToArray(fileDirectory);
        }

       
        public int[] fileCovertToArray(string fileDirectory)
        {
            fileLines = File.ReadAllLines(fileDirectory);

            Nums = new int[fileLines.Length];
            //int value;
            for (int i = 0; i < fileLines.Length; i++)
            {
                if (int.TryParse(fileLines[i], out int value))
                {
                    Nums[i] = value;
                }
            }
            return Nums;
        }

        public int LinearSearch()
		{
            wantedValue = 88;

            for (int i = 0; i < Nums.Length; i++)
            {
                if (Nums[i] == wantedValue)
                {
                    Console.WriteLine("Got it! " + i);
                    return i;  // Return the int if the wanted index is found
                    
                }
                
            }
            Console.WriteLine("Where is it?");
            return 0;  // Return 0 if the wanted index is not found

        }
        
        
        public int binarySearch()
        {
            Array.Sort(Nums);

            wantedValue = 88;
            int low = 0;
            int high = Nums.Length - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;

                if (wantedValue == Nums[mid])
                {
                    Console.WriteLine("Found it! " + mid);
                    return ++mid;  // Return the int if the wanted value is found
                }
                else if (wantedValue < Nums[mid])
                {
                    high = mid - 1;  // Continue searching in the left half of the array
                }
                else
                {
                    low = mid + 1;  // Continue searching in the right half of the array
                    
                }
            }
            Console.WriteLine("Couldn't find it");
            return 0;  // Return 0 if the wanted value is not found

        }

       
        public int InterpolationSearch()
        {
            Array.Sort(Nums);
            int low = 0;
            int high = Nums.Length - 1;

            wantedValue = 88;

            while (low <= high && wantedValue >= Nums[low] && wantedValue <= Nums[high])
            {
                // Calculate the estimated position
                int position = low + ((wantedValue - Nums[low]) * (high - low) / (Nums[high] - Nums[low]));

                if (Nums[position] == wantedValue)
                {
                    Console.WriteLine("Found it! " + position);
                    return position;  // wanted value is found
                }
                // Search in the right half
                if (Nums[position] < wantedValue)
                {
                    low = position + 1;
                }
                // Search in the left half
                else
                {
                    high = position - 1;
                }
            }
            Console.WriteLine("Couldn't find it");
            return 0;  // wanted value not found

            
        }
    }
}

