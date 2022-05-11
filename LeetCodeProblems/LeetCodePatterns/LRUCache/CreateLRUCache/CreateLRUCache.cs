using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.LeetCodePatterns.LRUCache.CreateLRUCache
{
    class CreateLRUCache
    {
		public class LRUCache
		{
			/// <summary>
			/// DoublyLinkedNode
			/// </summary>
			public class DoublyLinkedNode
			{
				public int val;//value
				public int key;//key
				public DoublyLinkedNode prev;//previous
				public DoublyLinkedNode next;//next
				private bool _isHeadTail;//toggle to see if its tail or head

				public bool IsHeadTail { get { return this._isHeadTail; } }//property to get the private
                public DoublyLinkedNode()//default constructor
                {

				}
				public DoublyLinkedNode(bool toggle)//constructor for head or tail
				{
					_isHeadTail = toggle;
				}
				public DoublyLinkedNode(int key, int value)//constructor with key and value
                {
					this.val = key;
					this.val = value;
                }

			}

			/// <summary>
			/// create the skeleton for a doubly linked list
			/// </summary>
			public class DoublyLinkedList
			{
				DoublyLinkedNode head;//head of list
				DoublyLinkedNode tail;//tail of list


				public DoublyLinkedList()//default constructor
                {
					head = new DoublyLinkedNode(true);//create head
					tail = new DoublyLinkedNode(true);//create tail
					head.next = tail;//initialize the head pointer
					tail.prev = head;//initialize tail pointer

				}

				/// <summary>
				/// Add a node to the front of the list, the front of the list
				/// is the next of the head
				/// </summary>
				/// <param name="node"></param>
				public void AddFront(DoublyLinkedNode node)
				{
					node.prev = head;//node prev is the head
					node.next = head.next;//node next is the head next
					head.next.prev = node;//head next prev is the new node
					head.next = node;//head next is the node
				}

				/// <summary>
				/// since we have a head and a tail, we can link nodes back together
				/// easily. 
				/// </summary>
				/// <param name="node"></param>
				public void Remove(DoublyLinkedNode node)
				{
					if (node.IsHeadTail)
						return;
                    else
					{
						var prev = node.prev;
						var next = node.next;

						prev.next = next;
						next.prev = prev;
					}
				}

				/// <summary>
				/// Remove the previous from the tail
				/// </summary>
				/// <returns></returns>
				public DoublyLinkedNode RemoveTail()
				{
					var node = tail.prev;//check the tail prev
                    if (!node.IsHeadTail)//if its not the head call remove node
					{
						Remove(node);
						return node;//remove the node that was removed from the linked list
					}
					return null;//if you land here, you cannot remove, return null
				}

				/// <summary>
				/// swap to front removes the node from the list, and then we add it again, this causes the
				/// node to now be at the front of the list
				/// </summary>
				/// <param name="node"></param>
				public void SwapToFront(DoublyLinkedNode node)
				{
					this.Remove(node);
					this.AddFront(node);
				}
			}


			int _capacity;//capacity variable for max capacity
			int _count;//current count
			DoublyLinkedList list;//head of the list
			Dictionary<int, DoublyLinkedNode> cache;//hashtable with integers and nodes

			/// <summary>
			/// initialize the lru cache with the given capacity
			/// </summary>
			/// <param name="capacity"></param>
			public LRUCache(int capacity)
			{
				_capacity = capacity;
				_count = 0;
				list = new DoublyLinkedList();//this is the linked list 
				cache = new Dictionary<int, DoublyLinkedNode>();//this is the cache of nodes
			}

			/// <summary>
			/// The get function checks the cache, if its not in the cache return -1. Otherwise
			/// use the cache to get the node, then use the node and swap it to the front. Finally
			/// return the value of the node. Swaping to the front allows you to know the node was
			/// recently accessed, so you will not delete it
			/// </summary>
			/// <param name="key"></param>
			/// <returns></returns>
			public int Get(int key)
			{
				if (!cache.ContainsKey(key))
					return -1;

				var node = cache[key];
				this.list.SwapToFront(node);
				return node.val;
			}

			/// <summary>
			/// Add a new entry to the LRU cache. If
			/// </summary>
			/// <param name="key"></param>
			/// <param name="value"></param>
			public void Put(int key, int value)
			{
				if (cache.ContainsKey(key))
				{
					var node1 = cache[key];
					node1.val = value;
					this.list.SwapToFront(node1);
					return;
				}

				var node = new DoublyLinkedNode(key,value);
				node.val = value;
				node.key = key;
				this.list.AddFront(node);
				cache.Add(key, node);

				_count++;
				if (_count > _capacity)
				{
					var node1 = this.list.RemoveTail();
					cache.Remove(node1.key);
					_count--;
				}
			}
		}


	}
}
