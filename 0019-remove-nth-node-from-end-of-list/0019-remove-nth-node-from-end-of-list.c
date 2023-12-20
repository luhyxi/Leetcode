#include <stdlib.h>

struct ListNode* removeNthFromEnd(struct ListNode* head, int n) {
    if (head == NULL || n <= 0) {
        return NULL;
    }

    struct ListNode dummy = {0, head};
    struct ListNode *fast = &dummy;
    struct ListNode *slow = &dummy;

    for (int i = 0; i <= n; i++) {
        if (fast == NULL) {
            return NULL; 
        }
        fast = fast->next;
    }

    while (fast != NULL) {
        fast = fast->next;
        slow = slow->next;
    }

    struct ListNode *temp = slow->next;
    slow->next = slow->next->next;
    free(temp);

    return dummy.next;
}
