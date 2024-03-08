public class Solution {
    public int MaxFrequencyElements(int[] nums)
    {
        // Creating cool dictionary
        Dictionary<int, int> countMap = new Dictionary<int, int>();

        // Count the occurrences of each element
        foreach (int num in nums)
            if (!countMap.TryAdd(num, 1)) countMap[num]++;

        // Find the maximum occurrence count
        int maxCount = countMap.Values.Max();

        // Sum up the occurrences of elements with the maximum frequency
        int result = countMap.Values.Where(count => count == maxCount).Sum();

        return result;
    }
}