﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Pong.Components.UI;

public class MenuItem : GameObject
{
    private readonly Pong _game;

    public sealed override string Name { get; set; }
    public override Vector2 Position { get; set; }
    public override Texture2D Texture { get; set; }
    public override Rectangle Collision { get; set; }
    public override float Depth { get; set; }
    public override bool hasTexture { get; set; }

    public const float Spacing = 60f;
    
    public MenuItem(Pong game, string name, bool hasTexture) : base(game, name, hasTexture)
    {
        _game = game;
        Name = name;
        this.hasTexture = hasTexture;
    }

    public override void AddAnimation(string name, int index)
    {
        throw new System.NotImplementedException();
    }

    public override void PlayAnimation(string name)
    {
        throw new System.NotImplementedException();
    }
}