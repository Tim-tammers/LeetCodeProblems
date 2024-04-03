/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {

        ListNode temp = new ListNode(0);
        ListNode result = temp;
        int carry = 0;
        int v1 = 0;
        int v2 = 0;

        while(l1 != null || l2 != null || carry > 0){
            v1 = l1 != null ? l1.val : 0;
            v2 = l2 != null ? l2.val : 0;

            var sum = v1+v2+carry;
            carry = sum /10;
            sum = sum%10;

            temp.next = new ListNode(sum);
            temp = temp.next;
            if(l1 != null) l1 = l1.next; 
            if(l2 != null) l2 = l2.next;
        }

        return result.next;

    }
}