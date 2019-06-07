using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.ShapedBlocks.Decor
{
	[AttributePlayerRecipe]
	public class bricksslopeRecipe : BaseRecipe
	{
		public bricksslopeRecipe() : base("brickssloperecipe")
		{
			Requirements.Add(new InventoryItem("stonebricks", 1));
			Result.Add(new InventoryItem("bricksslope", 1));
		}
	}
	
	[AttributeType]
	public class bricksslope : DecorativeType
	{
		public bricksslope() : base("bricks", "slope",
			Utilities.MultiCombine(ShapedBlocks.ModIconDirectory, "bricksslope.png"))
		{
			this.SideAll = "bricks";
		}
	}

	[AttributeType]
	public class bricksslopeXMinus : DecorativeTypeXMinus
	{
		public bricksslopeXMinus() : base("bricks", "slope", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("fourstepstairsx-");
		}
	}

	[AttributeType]
	public class bricksslopeXPlus : DecorativeTypeXPlus
	{
		public bricksslopeXPlus() : base("bricks", "slope", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("fourstepstairsx+");
		}
	}

	[AttributeType]
	public class bricksslopeZMinus : DecorativeTypeZMinus
	{
		public bricksslopeZMinus() : base("bricks", "slope", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("fourstepstairsz-");
		}
	}

	[AttributeType]
	public class bricksslopeZPlus : DecorativeTypeZPlus
	{
		public bricksslopeZPlus() : base("bricks", "slope", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("fourstepstairsz+");
		}
	}
}