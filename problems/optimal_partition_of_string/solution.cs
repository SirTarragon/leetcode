public class Solution {
    public int PartitionString(string s) {
        int[] runningDict = Enumerable.Repeat(0,26).ToArray();
        StringBuilder runningB = new();
        int partitionCount = 0;
        foreach(char c in s) {
            if(runningDict[((int) c & 0x1F) - 1] != 0) {
                partitionCount++;
                foreach(char b in runningB.ToString())
                    runningDict[((int)b & 0x1F) - 1] = 0;
                runningB.Clear();
            }
            
            runningDict[((int)c & 0x1F) - 1]++;
            runningB.Append(c);
        }

        if(runningB.Length != 0) {
            partitionCount++;
        }

        return partitionCount;
    }
}