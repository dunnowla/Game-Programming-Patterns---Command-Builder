using Godot;
using System;
using System.Collections.Generic;

public partial class BoxThingaMajig : Node3D
{
	private Stack<ICommands> undoStack = new Stack<ICommands>();

	public void AddAction(ICommands command)
	{
		command.Execute();
		undoStack.Push(command);
	}

    public void UndoButton()
    {
        if (undoStack.Count > 0)
        {
            undoStack.Pop().Undo();
        }
    }
}
