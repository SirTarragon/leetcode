public class Solution {
    public int[] RelativeSortArray(int[] arr1, int[] arr2) {
        var dict = new Dictionary<int,int>();
        for(int i = 0; i < arr2.Length; i++) {
            dict.Add(arr2[i], i);
        }

        var sorting = new PriorityQueue<int, int>();
        for(int i = 0; i < arr1.Length; i++) {
            if(dict.TryGetValue(arr1[i], out int index))
                sorting.Enqueue(arr1[i], index);
            else
                sorting.Enqueue(arr1[i], arr2.Length + arr1[i]);
        }

        var output = new int[sorting.Count];
        for(int i = 0; i < output.Length; i++)
            output[i] = sorting.Dequeue();

        return output;
    }
}