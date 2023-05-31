public class RandomizedSet {
    private Dictionary<int, int> dictKeys;
    private Dictionary<int, int> dictValues;
    private HashSet<int> deletedKeys;
    private int KeyCounter, start;
    private Random rand;

    public RandomizedSet() {
        dictKeys = new Dictionary<int, int>();
        dictValues = new Dictionary<int, int>();
        deletedKeys = new HashSet<int>();
        KeyCounter = 1; start = 1;
        rand = new Random();
    }
    
    public bool Insert(int val) {
        if(!dictValues.ContainsKey(val)) {
            dictKeys.Add(KeyCounter, val);
            dictValues.Add(val, KeyCounter);
            KeyCounter++;
            return true;
        }
        return false;
    }
    
    public bool Remove(int val) {
        if(dictValues.ContainsKey(val)){
            int key = dictValues[val];
            dictValues.Remove(val);
            dictKeys.Remove(key);
            deletedKeys.Add(key);
            return true;
        }
        return false;
    }
    
    public int GetRandom() {
        int randIndex = rand.Next(start, KeyCounter);
        while(deletedKeys.Contains(randIndex)) {
            while(deletedKeys.Contains(start))
                start++;
            randIndex = rand.Next(start, KeyCounter);
        }
        return dictKeys[randIndex];
    }
}

/**
 * Your RandomizedSet object will be instantiated and called as such:
 * RandomizedSet obj = new RandomizedSet();
 * bool param_1 = obj.Insert(val);
 * bool param_2 = obj.Remove(val);
 * int param_3 = obj.GetRandom();
 */