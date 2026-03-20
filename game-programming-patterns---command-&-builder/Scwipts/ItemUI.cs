using Godot;
using System;

public partial class ItemUI : Button
{
	[Export] public Label Chest;

	private string[] prefixes = {"Shiny","Broken","Rusty","Smelly","Cursed","Mythic"}; // All prefixes
	private string[] suffixes = {"of Doom", "of skellefteå", "of speed", "of yes exactly"}; // All suffixes
	private string[] types = {"Ak-47", "Hammer", "Parmesan", "Twig", "Strand of hair"}; // All types

	public override void _Pressed()
	{
		Random random = new Random();

		//Creates the random combination of strings for the item
		Item newItem = new Builder()
		.SetPrefix(prefixes[random.Next(prefixes.Length)])
		.SetType(types[random.Next(types.Length)])
		.SetSuffix(suffixes[random.Next(suffixes.Length)])
		.SetDamage((float)random.NextDouble()*50)
		.Build();

		Chest.Text = "Item generated: " + newItem.CreateName(); // Writes the text
	}
}
