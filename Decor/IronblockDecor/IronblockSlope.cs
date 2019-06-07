using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.ShapedBlocks.Decor
{
	[AttributePlayerRecipe]
	public class ironblockslopeRecipe : BaseRecipe
	{
		public ironblockslopeRecipe() : base("ironblocksloperecipe")
		{
			Requirements.Add(new InventoryItem("stonebricks", 1));
			Result.Add(new InventoryItem("ironblockslope", 1));
		}
	}
	
	[AttributeType]
	public class ironblockslope : DecorativeType
	{
		public ironblockslope() : base("ironblock", "slope",
			Utilities.MultiCombine(ShapedBlocks.ModIconDirectory, "ironblockslope.png"))
		{
			this.SideAll = "ironblock";
		}
	}

	[AttributeType]
	public class ironblockslopeXMinus : DecorativeTypeXMinus
	{
		public ironblockslopeXMinus() : base("ironblock", "slope", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("slopex-");
		}
	}

	[AttributeType]
	public class ironblockslopeXPlus : DecorativeTypeXPlus
	{
		public ironblockslopeXPlus() : base("ironblock", "slope", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("slopex+");
		}
	}

	[AttributeType]
	public class ironblockslopeZMinus : DecorativeTypeZMinus
	{
		public ironblockslopeZMinus() : base("ironblock", "slope", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("slopez-");
		}
	}

	[AttributeType]
	public class ironblockslopeZPlus : DecorativeTypeZPlus
	{
		public ironblockslopeZPlus() : base("ironblock", "slope", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("slopez+");
		}
	}
}