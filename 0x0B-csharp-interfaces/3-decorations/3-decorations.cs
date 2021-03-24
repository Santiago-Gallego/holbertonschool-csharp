using System;

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
		if (this.durability <= 0)
			Console.WriteLine("The {0} has been broken.", this.name);
		else if (this.isQuestItem)
			Console.WriteLine("You look at the {0}. There's a key inside.", this.name);
		else
			Console.WriteLine("You look at the {0}. Not much to see here.", this.name);
	}
	public void Break()
	{
		this.durability--;
		if (this.durability > 0)
			Console.WriteLine("You hit the {0}. It cracks.", this.name);
		if (this.durability == 0)
			Console.WriteLine("You smash the {0}. What a mess.", this.name);
		if (this.durability < 0)
			Console.WriteLine("The {0} is already broken.", this.name);
	}
}