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
                if (i == wantedValue)
                {
                    Console.WriteLine("Got it! " + i);
                    return i;  // Return the index if the wanted int is found
                    
                }
                
            }
            Console.WriteLine("Where is it?");
            return 0;  // Return 0 if the wanted int is not found

        }
        int low;
        int high;

        int mid;
        public int binarySearch()
        {
            wantedValue = 4;
            low = 0;
            high = Nums.Length - 1;

            while (low <= high)
            {
                mid = (low + high) / 2;

                if (mid == wantedValue)
                {
                    Console.WriteLine("Found it! " + mid);
                    return mid;  // Return the index if the wanted value is found
                }
                else if (mid < wantedValue)
                {
                    low = mid + 1;  // Continue searching in the right half
                }
                else
                {
                    high = mid - 1;  // Continue searching in the left half
                }
            }
            Console.WriteLine("Couldn't find it");
            return 0;  // Return 0 if the target is not found

        }
        public int InterpolationSearch()
        {
            int low = 0;
            int high = Nums.Length - 1;

            wantedValue = 95;

            while (low <= high && wantedValue >= low && wantedValue <= high)
            {
                // Calculate the estimated position
                int position = low + ((wantedValue - low) * (high - low) / (high - low));

                if (position == wantedValue)
                {
                    Console.WriteLine("Found it! " + position);
                    return position;  // wanted value is found
                }
                // Search in the right half
                if (position < wantedValue)
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

