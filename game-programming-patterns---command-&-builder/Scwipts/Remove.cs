using Godot;
using System;

public partial class Remove : ICommands
{
	private Node3D box;

	public Remove(Node3D boxx)
	{
		box = boxx; // says what box to affect
	}

	public void Execute()
	{
		box.GetNode<MeshInstance3D>("MeshInstance3D").Visible = false; // sets the box to invisible
	}

	public void Undo()
	{
		box.GetNode<MeshInstance3D>("MeshInstance3D").Visible = true; // sets the box to visible
	}
}

