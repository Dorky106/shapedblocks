using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.ShapedBlocks.Decor
{
	[AttributePlayerRecipe]
	public class bricksslopecornerRecipe : BaseRecipe
	{
		public bricksslopecornerRecipe() : base("bricksslopecornerrecipe")
		{
			Requirements.Add(new InventoryItem("stonebricks", 1));
			Result.Add(new InventoryItem("bricksslopecorner", 1));
		}
	}
	
	[AttributeType]
	public class bricksslopecorner : DecorativeType
	{
		public bricksslopecorner() : base("bricks", "slopecorner",
			Utilities.MultiCombine(ShapedBlocks.ModIconDirectory, "bricksslopecorner.png"))
		{
			this.SideAll = "bricks";
		}
	}

	[AttributeType]
	public class bricksslopecornerXMinus : DecorativeTypeXMinus
	{
		public bricksslopecornerXMinus() : base("bricks", "slopecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("slopecornerx-");
		}
	}

	[AttributeType]
	public class bricksslopecornerXPlus : DecorativeTypeXPlus
	{
		public bricksslopecornerXPlus() : base("bricks", "slopecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("slopecornerx+");
		}
	}

	[AttributeType]
	public class bricksslopecornerZMinus : DecorativeTypeZMinus
	{
		public bricksslopecornerZMinus() : base("bricks", "slopecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("slopecornerz-");
		}
	}

	[AttributeType]
	public class bricksslopecornerZPlus : DecorativeTypeZPlus
	{
		public bricksslopecornerZPlus() : base("bricks", "slopecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("slopecornerz+");
		}
	}
}