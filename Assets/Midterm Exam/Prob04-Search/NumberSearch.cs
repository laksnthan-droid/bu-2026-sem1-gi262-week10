using System;

namespace MidtermExam.Prob04
{
    public class NumberSearch
    {
        public int AS04_SequentialSearch(int[] values, int target)
        {
            if (values == null || values.Length == 0)
            {
                return -1;
            }
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return i;
                }
            }
            return -1;
        }
        public int AS05_BinarySearch(int[] sortedValues, int target)
        {
            if (sortedValues == null || sortedValues.Length == 0)
            { return -1; }

            int left = 0;
            int right = sortedValues.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (sortedValues[mid] == target)
                {
                    return mid;
                }
                if (sortedValues[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return -1;
        }
    }
}