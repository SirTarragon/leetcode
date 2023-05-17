/**
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     ListNode *next;
 *     ListNode() : val(0), next(nullptr) {}
 *     ListNode(int x) : val(x), next(nullptr) {}
 *     ListNode(int x, ListNode *next) : val(x), next(next) {}
 * };
 */
class Solution {
public:
    int pairSum(ListNode* head) {
        if(head == NULL) return 0;
        
        int max = 0;
        vector<int> list;

        for(ListNode* cur = head; cur != NULL; cur = cur->next)
            list.push_back(cur->val);

        for(int i = 0; i <= (list.size() / 2) - 1; i++)
            max = std::max(max, list[i] + list[list.size() - 1 - i]);

        return max;
    }
};