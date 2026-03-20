using Godot;
using System;

public class Builder
{
	private Item item = new Item(); // Creates an empty item

	public Builder SetPrefix(string prefix)
	{
		item.prefix = prefix; // assingns its prefix
		return this;
	}

	public Builder SetType(string type)
	{
		item.type = type; // assigns its type
		return this;
	}

	public Builder SetSuffix(string suffix)
	{
		item.suffix = suffix; // assigns its suffix
		return this;
	}
	
	public Builder SetDamage(float damage)
	{
		item.damage = damage; // sets its damage
		return this;
	}

	public Item Build()
	{
		return item; // returns the item
	}

}

