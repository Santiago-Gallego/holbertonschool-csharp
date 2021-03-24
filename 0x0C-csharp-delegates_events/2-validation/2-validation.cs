using System;

/// <summary>
/// Delegate to change health.
/// </summary>
/// <param name="amt">The amount of health to be changed.</param>
delegate void CalculateHealth(float amt);

/// <summary>
/// Defines a player.
/// </summary>
public class Player
{
	private string name;
	private float maxHp;
	private float hp;

	/// <summary>
	/// Constructor for player.
	/// </summary>
	/// <param name="name">The name of the player.</param>
	/// <param name="maxHp">The player's maximum hit points.</param>
	public Player(string name = "Player", float maxHp = 100f)
	{
		if (maxHp <= 0f)
		{
			this.maxHp = 100f;
			Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
		}
		else
			this.maxHp = maxHp;
		this.name = name;
		this.hp = this.maxHp;
	}

	/// <summary>
	/// Prints the player's health.
	/// </summary>
	public void PrintHealth()
	{
		Console.WriteLine("{0} has {1} / {2} health", this.name, this.hp, this.maxHp);
	}

	/// <summary>
	/// Player takes damage. Follows CalculateHealth delegate.
	/// </summary>
	/// <param name="damage">The amount of damage taken.</param>
	public void TakeDamage(float damage)
	{
		float newHp = this.hp;
		if (damage < 0f)
			damage = 0f;
		Console.WriteLine("{0} takes {1} damage!", this.name, damage);
		newHp -= damage;
		ValidateHP(newHp);
	}

	/// <summary>
	/// Player heals HP. Follows CalculateHealth delegate.
	/// </summary>
	/// <param name="heal">The amount of HP player heals.</param>
	public void HealDamage(float heal)
	{
		float newHp = this.hp;
		if (heal < 0f)
			heal = 0f;
		Console.WriteLine("{0} heals {1} HP!", this.name, heal);
		newHp += heal;
		ValidateHP(newHp);
	}

	/// <summary>
	/// Changes the Player's hp depending on damage or heal.
	/// </summary>
	/// <param name="newHp">The newHp of the Player.</param>
	public void ValidateHP(float newHp)
	{
		if (newHp < 0f)
			this.hp = 0f;
		else if (newHp > this.maxHp)
			this.hp = this.maxHp;
		else
			this.hp = newHp;
	}
}
