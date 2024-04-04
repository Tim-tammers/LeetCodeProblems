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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        ListNode sortedList = new ListNode();
        var dummyNode = sortedList;
        if(list1 == null && list2 == null){
            return null;
        }
        while(list1 != null || list2 != null){
            if(list1 != null && list2 != null && list1.val >= list2.val){
            dummyNode.next =  list2;
                list2 = list2.next;
            dummyNode = dummyNode.next;
            }
            if(list1 != null && list2 != null && list1.val < list2.val){
            dummyNode.next =  list1;
                list1 = list1.next;
            dummyNode = dummyNode.next;
            }
            if(list1 != null && list2 == null){
                dummyNode.next = list1;
                list1 = list1.next;
                dummyNode = dummyNode.next;
            }
               if(list2 != null && list1 == null){
                dummyNode.next = list2;
                list2 = list2.next;
                dummyNode = dummyNode.next;
            }

        }
        return sortedList.next;
    }
}