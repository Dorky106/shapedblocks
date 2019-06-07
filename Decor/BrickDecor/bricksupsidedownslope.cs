using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.ShapedBlocks.Decor
{
	[AttributePlayerRecipe]
	public class bricksupsidedownslopeRecipe : BaseRecipe
	{
		public bricksupsidedownslopeRecipe() : base("bricksupsidedownsloperecipe")
		{
			Requirements.Add(new InventoryItem("stonebricks", 1));
			Result.Add(new InventoryItem("bricksupsidedownslope", 1));
		}
	}
	
	[AttributeType]
	public class bricksupsidedownslope : DecorativeType
	{
		public bricksupsidedownslope() : base("bricks", "upsidedownslope",
			Utilities.MultiCombine(ShapedBlocks.ModIconDirectory, "bricksupsidedownslope.png"))
		{
			this.SideAll = "bricks";
		}
	}

	[AttributeType]
	public class bricksupsidedownslopeXMinus : DecorativeTypeXMinus
	{
		public bricksupsidedownslopeXMinus() : base("bricks", "upsidedownslope", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedownslopex-");
		}
	}

	[AttributeType]
	public class bricksupsidedownslopeXPlus : DecorativeTypeXPlus
	{
		public bricksupsidedownslopeXPlus() : base("bricks", "upsidedownslope", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedownslopex+");
		}
	}

	[AttributeType]
	public class bricksupsidedownslopeZMinus : DecorativeTypeZMinus
	{
		public bricksupsidedownslopeZMinus() : base("bricks", "upsidedownslope", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedownslopez-");
		}
	}

	[AttributeType]
	public class bricksupsidedownslopeZPlus : DecorativeTypeZPlus
	{
		public bricksupsidedownslopeZPlus() : base("bricks", "upsidedownslope", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedownslopez+");
		}
	}
}