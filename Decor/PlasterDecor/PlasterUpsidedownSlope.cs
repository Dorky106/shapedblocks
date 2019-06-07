using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.ShapedBlocks.Decor
{
	[AttributePlayerRecipe]
	public class plasterblockupsidedownslopeRecipe : BaseRecipe
	{
		public plasterblockupsidedownslopeRecipe() : base("plasterblockupsidedownsloperecipe")
		{
			Requirements.Add(new InventoryItem("stonebricks", 1));
			Result.Add(new InventoryItem("plasterblockupsidedownslope", 1));
		}
	}
	
	[AttributeType]
	public class plasterblockupsidedownslope : DecorativeType
	{
		public plasterblockupsidedownslope() : base("plasterblock", "upsidedownslope",
			Utilities.MultiCombine(ShapedBlocks.ModIconDirectory, "plasterblockupsidedownslope.png"))
		{
			this.SideAll = "plasterblock";
		}
	}

	[AttributeType]
	public class plasterblockupsidedownslopeXMinus : DecorativeTypeXMinus
	{
		public plasterblockupsidedownslopeXMinus() : base("plasterblock", "upsidedownslope", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedownslopex-");
		}
	}

	[AttributeType]
	public class plasterblockupsidedownslopeXPlus : DecorativeTypeXPlus
	{
		public plasterblockupsidedownslopeXPlus() : base("plasterblock", "upsidedownslope", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedownslopex+");
		}
	}

	[AttributeType]
	public class plasterblockupsidedownslopeZMinus : DecorativeTypeZMinus
	{
		public plasterblockupsidedownslopeZMinus() : base("plasterblock", "upsidedownslope", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedownslopez-");
		}
	}

	[AttributeType]
	public class plasterblockupsidedownslopeZPlus : DecorativeTypeZPlus
	{
		public plasterblockupsidedownslopeZPlus() : base("plasterblock", "upsidedownslope", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedownslopez+");
		}
	}
}