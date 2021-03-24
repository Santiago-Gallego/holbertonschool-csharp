﻿using System;

/// <summary>
/// Modifier to attack.
/// </summary>
public enum Modifier
{
	/// <summary> Half strong attack. </summary>
	Weak,
	/// <summary> Normal attack. </summary>
	Base,
	/// <summary> 1.5 times stronger attack. </summary>
	Strong
}

/// <summary>
/// Determines the strength of attack modifer.
/// </summary>
/// <param name="baseValue">Normal attack.</param>
/// <param name="modifier">Modifier to apply to baseValue.</param>
/// <returns></returns>
public delegate float CalculateModifier(float baseValue, Modifier modifier);

/// <summary>
/// Delegate to change health.
/// </summary>
/// <param name="amt">The amount of health to be changed.</param>
public delegate void CalculateHealth(float amt);



/// <summary>
/// Defines a player.
/// </summary>
public class Player
{
	private string name;
	private float maxHp;
	private float hp;
	private string status;
	EventHandler<CurrentHPArgs> HPCheck;

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
		this.status = $"{this.name} is ready to go!";
		HPCheck += CheckStatus;
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
		OnCheckStatus(new CurrentHPArgs(this.hp));
	}

	/// <summary>
	/// Applies modifier to attack.
	/// </summary>
	/// <param name="baseValue">The normal attack power.</param>
	/// <param name="modifier">Modifies the attack power.</param>
	public float ApplyModifier(float baseValue, Modifier modifier)
	{
		if (modifier == Modifier.Weak)
			return baseValue * 0.5f;
		else if (modifier == Modifier.Base)
			return baseValue;
		else
			return baseValue * 1.5f;
	}

	private void CheckStatus(object sender, CurrentHPArgs e)
	{
		if (e.currentHp == this.maxHp)
			this.status = $"{this.name} is in perfect health!";
		else if (e.currentHp >= (this.maxHp * 0.5f) && e.currentHp < this.maxHp)
			this.status = $"{this.name} is doing well!";
		else if (e.currentHp >= (this.maxHp * 0.25f) && e.currentHp < (this.maxHp * 0.5f))
			this.status = $"{this.name} isn't doing too great...";
		else if (e.currentHp > 0 && e.currentHp < (this.maxHp * 0.5f))
			this.status = $"{this.name} needs help!";
		else
			this.status = $"{this.name} is knocked out!";
		Console.WriteLine(this.status);
	}

	private void HPValueWarning(object sender, CurrentHPArgs e)
	{
		if (e.currentHp == 0)
			Console.WriteLine("Health has reached zero!");
		else
			Console.WriteLine("Health is low!");
	}

	void OnCheckStatus(CurrentHPArgs e)
	{
		if (e.currentHp < (this.maxHp * 0.25f))
			HPCheck += HPValueWarning;
		HPCheck(this, e);
	}
}

class CurrentHPArgs : EventArgs
{
	public readonly float currentHp;

	public CurrentHPArgs(float newHp)
	{
		this.currentHp = newHp;
	}
}