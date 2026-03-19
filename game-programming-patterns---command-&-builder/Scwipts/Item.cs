using Godot;
using System;

public class Item
{
	public string prefix = "";
	public string type = "";
	public string suffix = "";
	public float damage = 0;

	public string CreateName()
	{
		string name = $"{prefix}{type}{suffix}";
		return $"{name} (Damage: {damage:F1})";
	}

}
