using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.ShapedBlocks.Decor
{
	[AttributePlayerRecipe]
	public class brickstwostepstairscornerRecipe : BaseRecipe
	{
		public brickstwostepstairscornerRecipe() : base("brickstwostepstairscornerrecipe")
		{
			Requirements.Add(new InventoryItem("stonebricks", 1));
			Result.Add(new InventoryItem("brickstwostepstairscorner", 1));
		}
	}
	
	[AttributeType]
	public class brickstwostepstairscorner : DecorativeType
	{
		public brickstwostepstairscorner() : base("bricks", "twostepstairscorner",
			Utilities.MultiCombine(ShapedBlocks.ModIconDirectory, "brickstwostepstairscorner.png"))
		{
			this.SideAll = "bricks";
		}
	}

	[AttributeType]
	public class brickstwostepstairscornerXMinus : DecorativeTypeXMinus
	{
		public brickstwostepstairscornerXMinus() : base("bricks", "twostepstairscorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("twostepstairscornerx-");
		}
	}

	[AttributeType]
	public class brickstwostepstairscornerXPlus : DecorativeTypeXPlus
	{
		public brickstwostepstairscornerXPlus() : base("bricks", "twostepstairscorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("twostepstairscornerx+");
		}
	}

	[AttributeType]
	public class brickstwostepstairscornerZMinus : DecorativeTypeZMinus
	{
		public brickstwostepstairscornerZMinus() : base("bricks", "twostepstairscorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("twostepstairscornerz-");
		}
	}

	[AttributeType]
	public class brickstwostepstairscornerZPlus : DecorativeTypeZPlus
	{
		public brickstwostepstairscornerZPlus() : base("bricks", "twostepstairscorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("twostepstairscornerz+");
		}
	}
}