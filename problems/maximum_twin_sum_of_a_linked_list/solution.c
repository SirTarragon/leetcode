#define max(a,b) \
   ({ __typeof__ (a) _a = (a); \
       __typeof__ (b) _b = (b); \
     _a > _b ? _a : _b; })
/**
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     struct ListNode *next;
 * };
 */
int pairSum(struct ListNode* head){
    struct ListNode* cur = head;
    int size = 0;
    int maxSum = 0;

    while(cur != NULL) {
        size++;
        cur = cur->next;
    }

    int vals[size];
    cur = head;

    for(int i = 0; i < size && cur != NULL; i++, cur = cur->next) {
        vals[i] = cur->val;
    }

    for(int i = 0; i <= (size / 2) - 1; i++) {
        maxSum = max(maxSum, vals[i] + vals[size - 1 - i]);
    }

    return maxSum;
}