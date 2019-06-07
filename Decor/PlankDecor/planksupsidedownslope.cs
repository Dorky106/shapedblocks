using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.ShapedBlocks.Decor
{
	[AttributePlayerRecipe]
	public class planksupsidedownslopeRecipe : BaseRecipe
	{
		public planksupsidedownslopeRecipe() : base("planksupsidedownsloperecipe")
		{
			Requirements.Add(new InventoryItem("stonebricks", 1));
			Result.Add(new InventoryItem("planksupsidedownslope", 1));
		}
	}
	
	[AttributeType]
	public class planksupsidedownslope : DecorativeType
	{
		public planksupsidedownslope() : base("planks", "upsidedownslope",
			Utilities.MultiCombine(ShapedBlocks.ModIconDirectory, "planksupsidedownslope.png"))
		{
			this.SideAll = "planks";
		}
	}

	[AttributeType]
	public class planksupsidedownslopeXMinus : DecorativeTypeXMinus
	{
		public planksupsidedownslopeXMinus() : base("planks", "upsidedownslope", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedownslopex-");
		}
	}

	[AttributeType]
	public class planksupsidedownslopeXPlus : DecorativeTypeXPlus
	{
		public planksupsidedownslopeXPlus() : base("planks", "upsidedownslope", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedownslopex+");
		}
	}

	[AttributeType]
	public class planksupsidedownslopeZMinus : DecorativeTypeZMinus
	{
		public planksupsidedownslopeZMinus() : base("planks", "upsidedownslope", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedownslopez-");
		}
	}

	[AttributeType]
	public class planksupsidedownslopeZPlus : DecorativeTypeZPlus
	{
		public planksupsidedownslopeZPlus() : base("planks", "upsidedownslope", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedownslopez+");
		}
	}
}