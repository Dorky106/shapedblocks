using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.ShapedBlocks.Decor
{
	[AttributePlayerRecipe]
	public class bricksfourstepstairscornerRecipe : BaseRecipe
	{
		public bricksfourstepstairscornerRecipe() : base("bricksfourstepstairscornerrecipe")
		{
			Requirements.Add(new InventoryItem("stonebricks", 1));
			Result.Add(new InventoryItem("bricksfourstepstairscorner", 1));
		}
	}
	
	[AttributeType]
	public class bricksfourstepstairscorner : DecorativeType
	{
		public bricksfourstepstairscorner() : base("bricks", "fourstepstairscorner",
			Utilities.MultiCombine(ShapedBlocks.ModIconDirectory, "bricksfourstepstairscorner.png"))
		{
			this.SideAll = "bricks";
		}
	}

	[AttributeType]
	public class bricksfourstepstairscornerXMinus : DecorativeTypeXMinus
	{
		public bricksfourstepstairscornerXMinus() : base("bricks", "fourstepstairscorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("fourstepstairscornerx-");
		}
	}

	[AttributeType]
	public class bricksfourstepstairscornerXPlus : DecorativeTypeXPlus
	{
		public bricksfourstepstairscornerXPlus() : base("bricks", "fourstepstairscorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("fourstepstairscornerx+");
		}
	}

	[AttributeType]
	public class bricksfourstepstairscornerZMinus : DecorativeTypeZMinus
	{
		public bricksfourstepstairscornerZMinus() : base("bricks", "fourstepstairscorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("fourstepstairscornerz-");
		}
	}

	[AttributeType]
	public class bricksfourstepstairscornerZPlus : DecorativeTypeZPlus
	{
		public bricksfourstepstairscornerZPlus() : base("bricks", "fourstepstairscorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("fourstepstairscornerz+");
		}
	}
}