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
