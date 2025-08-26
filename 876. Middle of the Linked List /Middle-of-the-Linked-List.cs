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
    public ListNode MiddleNode(ListNode head) {
        ListNode tail = head;
        ListNode node = head;
        while(node!= null&&node.next!=null)
        {
            node = node.next.next;
            tail = tail.next;
        }
        return tail;
    }
}