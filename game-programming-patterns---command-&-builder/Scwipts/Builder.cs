using Godot;
using System;

public class Builder
{
	private Item item = new Item();

	public Builder SetPrefix(string prefix)
	{
		item.prefix = prefix;
		return this;
	}

	public Builder SetType(string type)
	{
		item.type = type;
		return this;
	}

	public Builder SetSuffix(string suffix)
	{
		item.suffix = suffix;
		return this;
	}
	
	public Builder SetDamage(float damage)
	{
		item.damage = damage;
		return this;
	}

	public Item Build()
	{
		return item;
	}

}

