using Godot;
using System;

public partial class Remove : ICommands
{
	private Node3D box;

	public Remove(Node3D boxx)
	{
		box = boxx;
	}

	public void Execute()
	{
		box.GetNode<MeshInstance3D>("MeshInstance3D").Visible = false;
	}

	public void Undo()
	{
		box.GetNode<MeshInstance3D>("MeshInstance3D").Visible = true;
	}
}

