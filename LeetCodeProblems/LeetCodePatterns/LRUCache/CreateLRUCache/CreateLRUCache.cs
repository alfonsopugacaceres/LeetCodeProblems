using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.LeetCodePatterns.LRUCache.CreateLRUCache
{
    class CreateLRUCache
    {
		public class LRUCache
		{
			int _capacity;
			int _count;
			DoubleList head;
			DoubleList tail;
			Dictionary<int, DoubleList> cache;

			public void AddFront(DoubleList node)
			{
				node.next = head.next;
				head.next.prev = node;
				node.prev = head;
				head.next = node;
			}

			public void Remove(DoubleList node)
			{
				var prev = node.prev;
				var next = node.next;

				prev.next = next;
				next.prev = prev;
			}

			public DoubleList RemoveTail()
			{
				var node = tail.prev;
				Remove(node);
				return node;
			}

			public LRUCache(int capacity)
			{
				_capacity = capacity;
				_count = 0;
				head = new DoubleList();
				tail = new DoubleList();
				head.next = tail;
				tail.prev = head;
				cache = new Dictionary<int, DoubleList>();
			}

			public int Get(int key)
			{
				if (!cache.ContainsKey(key))
					return -1;

				var node = cache[key];
				Remove(node);
				AddFront(node);
				return node.val;
			}

			public void Put(int key, int value)
			{
				if (cache.ContainsKey(key))
				{
					var node1 = cache[key];
					node1.val = value;
					Remove(node1);
					AddFront(node1);
					return;
				}

				var node = new DoubleList();
				node.val = value;
				node.key = key;
				AddFront(node);
				cache.Add(key, node);

				_count++;
				if (_count > _capacity)
				{
					var node1 = RemoveTail();
					cache.Remove(node1.key);
					_count--;
				}
			}
		}

		public class DoubleList
		{
			public int val;
			public int key;
			public DoubleList prev;
			public DoubleList next;
		}

	}
}
