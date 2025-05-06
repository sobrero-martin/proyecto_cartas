using Godot;
using System;

public partial class GameBoard : Control
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	
	private void BackButtonPress()
	{
		GetParent().AddChild(GD.Load<PackedScene>("res://src/main_ui.tscn").Instantiate<Control>());

		QueueFree();
	}
}
