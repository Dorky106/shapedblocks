using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.ShapedBlocks.Decor
{
	[AttributePlayerRecipe]
	public class bricksupsidedownslopeinsidecornerRecipe : BaseRecipe
	{
		public bricksupsidedownslopeinsidecornerRecipe() : base("bricksupsidedownslopeinsidecornerrecipe")
		{
			Requirements.Add(new InventoryItem("stonebricks", 1));
			Result.Add(new InventoryItem("bricksupsidedownslopeinsidecorner", 1));
		}
	}
	
	[AttributeType]
	public class bricksupsidedownslopeinsidecorner : DecorativeType
	{
		public bricksupsidedownslopeinsidecorner() : base("bricks", "upsidedownslopeinsidecorner",
			Utilities.MultiCombine(ShapedBlocks.ModIconDirectory, "bricksupsidedownslopeinsidecorner.png"))
		{
			this.SideAll = "bricks";
		}
	}

	[AttributeType]
	public class bricksupsidedownslopeinsidecornerXMinus : DecorativeTypeXMinus
	{
		public bricksupsidedownslopeinsidecornerXMinus() : base("bricks", "upsidedownslopeinsidecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedownslopeinsidecornerx-");
		}
	}

	[AttributeType]
	public class bricksupsidedownslopeinsidecornerXPlus : DecorativeTypeXPlus
	{
		public bricksupsidedownslopeinsidecornerXPlus() : base("bricks", "upsidedownslopeinsidecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedownslopeinsidecornerx+");
		}
	}

	[AttributeType]
	public class bricksupsidedownslopeinsidecornerZMinus : DecorativeTypeZMinus
	{
		public bricksupsidedownslopeinsidecornerZMinus() : base("bricks", "upsidedownslopeinsidecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedownslopeinsidecornerz-");
		}
	}

	[AttributeType]
	public class bricksupsidedownslopeinsidecornerZPlus : DecorativeTypeZPlus
	{
		public bricksupsidedownslopeinsidecornerZPlus() : base("bricks", "upsidedownslopeinsidecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedownslopeinsidecornerz+");
		}
	}
}