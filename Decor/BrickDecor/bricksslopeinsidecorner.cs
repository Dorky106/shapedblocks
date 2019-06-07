using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.ShapedBlocks.Decor
{
	[AttributePlayerRecipe]
	public class bricksslopeinsidecornerRecipe : BaseRecipe
	{
		public bricksslopeinsidecornerRecipe() : base("bricksslopeinsidecornerrecipe")
		{
			Requirements.Add(new InventoryItem("stonebricks", 1));
			Result.Add(new InventoryItem("bricksslopeinsidecorner", 1));
		}
	}
	
	[AttributeType]
	public class bricksslopeinsidecorner : DecorativeType
	{
		public bricksslopeinsidecorner() : base("bricks", "slopeinsidecorner",
			Utilities.MultiCombine(ShapedBlocks.ModIconDirectory, "bricksslopeinsidecorner.png"))
		{
			this.SideAll = "bricks";
		}
	}

	[AttributeType]
	public class bricksslopeinsidecornerXMinus : DecorativeTypeXMinus
	{
		public bricksslopeinsidecornerXMinus() : base("bricks", "slopeinsidecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("slopeinsidecornerx-");
		}
	}

	[AttributeType]
	public class bricksslopeinsidecornerXPlus : DecorativeTypeXPlus
	{
		public bricksslopeinsidecornerXPlus() : base("bricks", "slopeinsidecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("slopeinsidecornerx+");
		}
	}

	[AttributeType]
	public class bricksslopeinsidecornerZMinus : DecorativeTypeZMinus
	{
		public bricksslopeinsidecornerZMinus() : base("bricks", "slopeinsidecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("slopeinsidecornerz-");
		}
	}

	[AttributeType]
	public class bricksslopeinsidecornerZPlus : DecorativeTypeZPlus
	{
		public bricksslopeinsidecornerZPlus() : base("bricks", "slopeinsidecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("slopeinsidecornerz+");
		}
	}
}