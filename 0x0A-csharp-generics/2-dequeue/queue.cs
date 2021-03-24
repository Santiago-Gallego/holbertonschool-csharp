using System;

/// <summary>
/// Generic class.
/// </summary>
/// <typeparam name="T">The type of object.</typeparam>
class Queue<T>
{
	/// <summary>
	/// Each node of the list.
	/// </summary>
	public class Node
	{
		public T value;
		public Node next = null;
		public Node(T type)
		{
			this.value = type;
		}
	}
	public Node head;
	public Node tail;
	int count = 0;

	/// <summary>
	/// Returns the number of nodes in a list.
	/// </summary>
	public int Count()
	{
		return this.count;
	}

	/// <summary>
	/// Adds a node to the end of a list.
	/// </summary>
	/// <param name="t">The value of the node.</param>
	public void Enqueue(T t)
	{
		Node node = new Node(t);

		if (this.head == null)
			this.head = node;
		if (this.tail != null)
			this.tail.next = node;
		this.tail = node;
		this.count++;
	}

	/// <summary>
	/// Checks type of object.
	/// </summary>
	/// <returns>Object type.</returns>
	public Type CheckType()
	{
		return typeof(T);
	}

	/// <summary>
	/// Removes the first node in the queue.
	/// </summary>
	/// <returns>Value of the first node.</returns>
	public T Dequeue()
	{
		Node node;
		if (this.head == null)
		{
			Console.WriteLine("Queue is empty");
			return default(T);
		}
		node = this.head;
		this.head = node.next;
		count--;
		return node.value;
	}
}
