using Godot;
using System;

public partial class MainUi : Control
{ 
	
	private string lastMenu;
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		lastMenu = "MainMenu"; 
	}
	
	private void SwitchMenu(string hideMenu, string newMenu){
		GetNode<Control>("UIContainer/CurrentMenu/" + hideMenu).Hide();
		GetNode<Control>("UIContainer/CurrentMenu/" + newMenu).Show();
		lastMenu = newMenu;
	}
	
	private void ButtonMainPressed(){
		GD.Print("This is ButtonMain");
 		SwitchMenu(lastMenu, "MainMenu");
	}
	
	private void ButtonShopPressed(){
		GD.Print("This is ButtonShop");
		SwitchMenu(lastMenu, "ShopMenu");
	}
	
	private void ButtonInvPressed(){
		GD.Print("This is ButtonInv");
		
	}
	
	private void ButtonFriendsPressed(){
		GD.Print("This is ButtonFriends");
		SwitchMenu(lastMenu, "FriendsMenu");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
