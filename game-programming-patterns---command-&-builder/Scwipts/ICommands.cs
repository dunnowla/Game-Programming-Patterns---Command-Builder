using Godot;
using System;

public interface ICommands
{
	void Execute();
	void Undo();
}
