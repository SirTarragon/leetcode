public class Solution {
    public string[] FindRestaurant(string[] list1, string[] list2) {
        Dictionary<string, int> dict = list1.Select((s, index) => new { s, index })
                                            .ToDictionary(x => x.s, x => x.index);
        List<string> answer = new List<string>();
        
        int minSum = int.MaxValue;

        for(int i = 0; i < list2.Length; i++) {
            if(dict.ContainsKey(list2[i])) {
                dict[list2[i]] += i;
                int check = dict[list2[i]];
                if(check < minSum) {
                    if(answer.Count > 0)
                        answer.Clear();
                    answer.Add(list2[i]);
                    minSum = check;
                } else if(check == minSum) {
                    answer.Add(list2[i]);
                }
            }
        }

        return answer.ToArray();
    }
}