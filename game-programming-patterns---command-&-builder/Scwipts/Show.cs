using Godot;
using System;
using System.Security.Cryptography.X509Certificates;

public partial class Show : ICommands
{
	private Node3D box;

	public Show(Node3D boxx)
	{
		box = boxx;
	}

	public void Execute()
	{
		box.GetNode<MeshInstance3D>("MeshInstance3D").Visible = true;
	}

	public void Undo()
	{
		box.GetNode<MeshInstance3D>("MeshInstance3D").Visible = false;
	}
}


