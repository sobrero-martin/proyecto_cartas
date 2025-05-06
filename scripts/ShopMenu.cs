using Godot;
using System;

public partial class ShopMenu : Control
{
	
	public override void _Ready()
	{
		
	}
	
	private void OnButtonPressed()
	{
		GetNode<AcceptDialog>("VentanaInfo").PopupCentered();
	}
	
	private void OnButton4Pressed()
	{
		GetNode<AcceptDialog>("VentanaInfo4").PopupCentered();
	}
	
		private void OnButton2Pressed()
	{
		GetNode<AcceptDialog>("VentanaInfo2").PopupCentered();
	}
	
		private void OnButton3Pressed()
	{
		GetNode<AcceptDialog>("VentanaInfo3").PopupCentered();
	}
	
		private void OnButton5Pressed()
	{
		GetNode<AcceptDialog>("VentanaInfo5").PopupCentered();
	}
	
		private void OnButton6Pressed()
	{
		GetNode<AcceptDialog>("VentanaInfo6").PopupCentered();
	}
	
		private void OnButton7Pressed()
	{
		GetNode<AcceptDialog>("VentanaInfo7").PopupCentered();
	}
	
		private void OnButton8Pressed()
	{
		GetNode<AcceptDialog>("VentanaInfo8").PopupCentered();
	}
	
		private void OnButton9Pressed()
	{
		GetNode<AcceptDialog>("VentanaInfo9").PopupCentered();
	}
}
