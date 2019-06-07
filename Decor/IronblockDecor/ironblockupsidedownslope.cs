using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.ShapedBlocks.Decor
{
	[AttributePlayerRecipe]
	public class ironblockupsidedownslopeRecipe : BaseRecipe
	{
		public ironblockupsidedownslopeRecipe() : base("ironblockupsidedownsloperecipe")
		{
			Requirements.Add(new InventoryItem("stonebricks", 1));
			Result.Add(new InventoryItem("ironblockupsidedownslope", 1));
		}
	}
	
	[AttributeType]
	public class ironblockupsidedownslope : DecorativeType
	{
		public ironblockupsidedownslope() : base("ironblock", "upsidedownslope",
			Utilities.MultiCombine(ShapedBlocks.ModIconDirectory, "ironblockupsidedownslope.png"))
		{
			this.SideAll = "ironblock";
		}
	}

	[AttributeType]
	public class ironblockupsidedownslopeXMinus : DecorativeTypeXMinus
	{
		public ironblockupsidedownslopeXMinus() : base("ironblock", "upsidedownslope", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedownslopex-");
		}
	}

	[AttributeType]
	public class ironblockupsidedownslopeXPlus : DecorativeTypeXPlus
	{
		public ironblockupsidedownslopeXPlus() : base("ironblock", "upsidedownslope", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedownslopex+");
		}
	}

	[AttributeType]
	public class ironblockupsidedownslopeZMinus : DecorativeTypeZMinus
	{
		public ironblockupsidedownslopeZMinus() : base("ironblock", "upsidedownslope", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedownslopez-");
		}
	}

	[AttributeType]
	public class ironblockupsidedownslopeZPlus : DecorativeTypeZPlus
	{
		public ironblockupsidedownslopeZPlus() : base("ironblock", "upsidedownslope", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedownslopez+");
		}
	}
}