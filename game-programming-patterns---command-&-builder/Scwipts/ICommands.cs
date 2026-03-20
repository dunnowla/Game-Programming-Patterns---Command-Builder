using Godot;
using System;

public interface ICommands
{
	void Execute(); // Executes an action
	void Undo(); // Undos an action
}
