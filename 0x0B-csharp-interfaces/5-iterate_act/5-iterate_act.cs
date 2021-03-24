using System;
using System.Collections.Generic;

/// <summary>
/// Base class
/// </summary>
public abstract class Base
{
	/// <summary>
	/// Name given
	/// </summary>
	public string name;

	/// <summary>
	/// Overrides default ToString() method.
	/// </summary>
	public override string ToString()
	{
		return name + " is a " + this.GetType();
	}
}

interface IInteractive
{
	void Interact();
}

interface IBreakable
{
	int durability { get; set; }
	void Break();
}

interface ICollectable
{
	bool isCollected { get; set; }
	void Collect();
}

class Door : Base, IInteractive
{
	public Door(string value = "Door")
	{
		name = value;
	}

	public void Interact()
	{
		Console.WriteLine("You try to open the {0}. It's locked.", name);
	}
}

class Decoration : Base, IInteractive, IBreakable
{
	public bool isQuestItem = false;
	public int durability { get; set; }

	public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
	{
		if (durability <= 0)
			throw new Exception("Durability must be greater than 0");
		this.name = name;
		this.durability = durability;
		this.isQuestItem = isQuestItem;
	}
	public void Interact()
	{
		if (durability <= 0)
			Console.WriteLine("The {0} has been broken.", name);
		else if (isQuestItem)
			Console.WriteLine("You look at the {0}. There's a key inside.", name);
		else
			Console.WriteLine("You look at the {0}. Not much to see here.", name);
	}
	public void Break()
	{
		durability--;
		if (durability > 0)
			Console.WriteLine("You hit the {0}. It cracks.", name);
		if (durability == 0)
			Console.WriteLine("You smash the {0}. What a mess.", name);
		if (durability < 0)
			Console.WriteLine("The {0} is already broken.", name);
	}
}

class Key : Base, ICollectable
{
	public bool isCollected { get; set; }
	public Key(string name = "Key", bool isCollected = false)
	{
		this.name = name;
		this.isCollected = isCollected;
	}
	public void Collect()
	{
		if (!isCollected)
		{
			isCollected = true;
			Console.WriteLine("You pick up the {0}.", name);
		}
		else
		{
			Console.WriteLine("You have already picked up the {0}.", name);
		}
	}
}

class RoomObjects
{
	public static void IterateAction(List<Base> roomObjects, Type type)
	{
		foreach (Base obj in roomObjects)
		{
			if (type.IsInstanceOfType(obj))
			{
				if (type == typeof(IBreakable))
					((IBreakable)obj).Break();
				if (type == typeof(ICollectable))
					((ICollectable)obj).Collect();
				if (type == typeof(IInteractive))
					((IInteractive)obj).Interact();
			}
		}
	}
}