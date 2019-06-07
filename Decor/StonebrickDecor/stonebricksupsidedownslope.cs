using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.ShapedBlocks.Decor
{
	[AttributePlayerRecipe]
	public class stonebricksupsidedownslopeRecipe : BaseRecipe
	{
		public stonebricksupsidedownslopeRecipe() : base("stonebricksupsidedownsloperecipe")
		{
			Requirements.Add(new InventoryItem("stonebricks", 1));
			Result.Add(new InventoryItem("stonebricksupsidedownslope", 1));
		}
	}
	
	[AttributeType]
	public class stonebricksupsidedownslope : DecorativeType
	{
		public stonebricksupsidedownslope() : base("stonebricks", "upsidedownslope",
			Utilities.MultiCombine(ShapedBlocks.ModIconDirectory, "stonebricksupsidedownslope.png"))
		{
			this.SideAll = "stonebricks";
		}
	}

	[AttributeType]
	public class stonebricksupsidedownslopeXMinus : DecorativeTypeXMinus
	{
		public stonebricksupsidedownslopeXMinus() : base("stonebricks", "upsidedownslope", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedownslopex-");
		}
	}

	[AttributeType]
	public class stonebricksupsidedownslopeXPlus : DecorativeTypeXPlus
	{
		public stonebricksupsidedownslopeXPlus() : base("stonebricks", "upsidedownslope", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedownslopex+");
		}
	}

	[AttributeType]
	public class stonebricksupsidedownslopeZMinus : DecorativeTypeZMinus
	{
		public stonebricksupsidedownslopeZMinus() : base("stonebricks", "upsidedownslope", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedownslopez-");
		}
	}

	[AttributeType]
	public class stonebricksupsidedownslopeZPlus : DecorativeTypeZPlus
	{
		public stonebricksupsidedownslopeZPlus() : base("stonebricks", "upsidedownslope", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedownslopez+");
		}
	}
}