using LeetCodeSolutions.Shared;

namespace LeetCodeSolutions.Problems.Problem0021_MergeTwoSortedLists;

public static class Problem0021_MergeTwoSortedLists
{
    public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        ListNode cabecera = null;
        ListNode nodoActual;

        if (list1 != null && list2 != null)
        {
            if (list1.val >= list2.val)
            {
                cabecera = new ListNode(list2.val, list1);
                list2 = list2.next;
            }
            else
            {
                cabecera = new ListNode(list1.val, list2);
                list1 = list1.next;
            }
        }
        else if (list1 != null)
        {
            cabecera = list1;
            list1 = list1.next;
        }
        else if (list2 != null)
        {
            cabecera = list2;
            list2 = list2.next;
        }
        else
        {
            return cabecera;
        }

        nodoActual = cabecera;

        while (list1 != null || list2 != null)
        {
            if (list1 != null && list2 != null)
            {
                if (list1.val >= list2.val)
                {
                    nodoActual.next = new ListNode(list2.val, list1);
                    list2 = list2.next;
                }
                else
                {
                    nodoActual.next = new ListNode(list1.val, list2);
                    list1 = list1.next;
                }
            }
            else if (list1 != null)
            {
                nodoActual.next = list1;
                list1 = list1.next;
            }
            else if (list2 != null)
            {
                nodoActual.next = list2;
                list2 = list2.next;
            }

            nodoActual = nodoActual.next;
        }

        return cabecera;
    }
}
