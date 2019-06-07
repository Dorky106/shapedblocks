using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.ShapedBlocks.Decor
{
	[AttributePlayerRecipe]
	public class stonebricksslopeRecipe : BaseRecipe
	{
		public stonebricksslopeRecipe() : base("stonebrickssloperecipe")
		{
			Requirements.Add(new InventoryItem("stonebricks", 1));
			Result.Add(new InventoryItem("stonebricksslope", 1));
		}
	}
	
	[AttributeType]
	public class stonebricksslope : DecorativeType
	{
		public stonebricksslope() : base("stonebricks", "slope",
			Utilities.MultiCombine(ShapedBlocks.ModIconDirectory, "stonebricksslope.png"))
		{
			this.SideAll = "stonebricks";
		}
	}

	[AttributeType]
	public class stonebricksslopeXMinus : DecorativeTypeXMinus
	{
		public stonebricksslopeXMinus() : base("stonebricks", "slope", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("fourstepstairsx-");
		}
	}

	[AttributeType]
	public class stonebricksslopeXPlus : DecorativeTypeXPlus
	{
		public stonebricksslopeXPlus() : base("stonebricks", "slope", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("fourstepstairsx+");
		}
	}

	[AttributeType]
	public class stonebricksslopeZMinus : DecorativeTypeZMinus
	{
		public stonebricksslopeZMinus() : base("stonebricks", "slope", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("fourstepstairsz-");
		}
	}

	[AttributeType]
	public class stonebricksslopeZPlus : DecorativeTypeZPlus
	{
		public stonebricksslopeZPlus() : base("stonebricks", "slope", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("fourstepstairsz+");
		}
	}
}