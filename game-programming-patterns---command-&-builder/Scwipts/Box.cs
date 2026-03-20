using Godot;
using System;
using System.Numerics;

public partial class Box : StaticBody3D
{
	[Export] public BoxThingaMajig manager;
	// Says what box was clicked
    public override void _InputEvent(Camera3D cam, InputEvent @event, Godot.Vector3 position, Godot.Vector3 normal, int shapeIdx)
    {
        if(@event is InputEventMouseButton mouseButton && mouseButton.Pressed)
		{
			if(mouseButton.ButtonIndex == MouseButton.Left)
			{
				manager.AddAction(new Show(this)); // Makes a box visible if leftclick
			}
			else if (mouseButton.ButtonIndex == MouseButton.Right)
			{
				manager.AddAction(new Remove(this)); // Makes box invisible if rightclick
			}
		}
    }

}
