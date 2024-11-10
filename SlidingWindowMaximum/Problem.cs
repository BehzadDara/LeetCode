namespace SlidingWindowMaximum;

public static class Problem
{
    public static int[] Solve(int[] nums, int k)
    {
        var myLinkedList = new MyLinkedList();
        var result = new int[nums.Length - k + 1];

        for (int i = 0; i < nums.Length; i++)
        {
            while (myLinkedList.Count > 0 && nums[myLinkedList.GetLast()] < nums[i])
            {
                myLinkedList.RemoveLast();
            }

            if (myLinkedList.Count > 0 && myLinkedList.GetFirst() == i - k)
            {
                myLinkedList.RemoveFirst();
            }

            myLinkedList.Add(i);

            if (i < k - 1)
            {
                continue;
            }

            result[i - k + 1] = nums[myLinkedList.GetFirst()];
        }
        return result;
    }

    class MyLinkedList
    {
        public MyNode Head { get; set; } = new MyNode();
        public MyNode Tail { get; set; } = new MyNode();
        public int Count { get; private set; } = 0;

        public int GetFirst()
        {
            return Head.Value;
        }
        public int GetLast()
        {
            return Tail.Value;
        }

        public void RemoveFirst()
        {
            Head = Head.Next ?? new MyNode();
            Count--;
        }

        public void RemoveLast()
        {
            Tail = Tail.Previous ?? new MyNode();
            Count--;
        }

        public void Add(int value)
        {
            var myNode = new MyNode
            {
                Value = value
            };

            if (Count == 0)
            {
                Head = myNode;
                Tail = myNode;
            }
            else
            {
                myNode.Previous = Tail;
                Tail.Next = myNode;
                Tail = myNode;
            }
            Count++;
        }
    }

    class MyNode
    {
        public int Value { get; set; }
        public MyNode? Previous { get; set; }
        public MyNode? Next { get; set; }
    }
}
