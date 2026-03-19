using Godot;
using System;

public partial class ItemUI : Button
{
	[Export] public Label Chest;

	private string[] prefixes = {"Shiny","Broken","Rusty","Smelly","Cursed","Mythic"};
	private string[] suffixes = {"of Doom", "of skellefteå", "of speed", "of yes exactly"};
	private string[] types = {"Ak-47", "Hammer", "Parmesan", "Twig", "Strand of hair"};

	public override void _Pressed()
	{
		Random random = new Random();

		Item newItem = new Builder()
		.SetPrefix(prefixes[random.Next(prefixes.Length)])
		.SetType(types[random.Next(types.Length)])
		.SetSuffix(suffixes[random.Next(suffixes.Length)])
		.SetDamage((float)random.NextDouble()*50)
		.Build();

		Chest.Text = "Item generated: " + newItem.CreateName();
	}
}
