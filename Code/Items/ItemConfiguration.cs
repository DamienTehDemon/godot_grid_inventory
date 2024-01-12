using Godot;
using System;
using GodotGridInventory.Code.Items.Enums;

[GlobalClass, Icon("res://icon.svg")]
public partial class ItemConfiguration : Resource
{
    [Export] public string Id { get; set; }
    [Export] public string Name { get; set; }
    [Export] public string Description { get; set; }
    [Export] public Vector2 Size { get; set; }
    [Export] public Texture2D Texture { get; set; }
    [Export] public EnumItemActions Actions { get; set; }
    [Export] public string[] Slots { get; set; }
}