using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.ShapedBlocks.Decor
{
	[AttributePlayerRecipe]
	public class plasterblockslopeRecipe : BaseRecipe
	{
		public plasterblockslopeRecipe() : base("plasterblocksloperecipe")
		{
			Requirements.Add(new InventoryItem("stonebricks", 1));
			Result.Add(new InventoryItem("plasterblockslope", 1));
		}
	}
	
	[AttributeType]
	public class plasterblockslope : DecorativeType
	{
		public plasterblockslope() : base("plasterblock", "slope",
			Utilities.MultiCombine(ShapedBlocks.ModIconDirectory, "plasterblockslope.png"))
		{
			this.SideAll = "plasterblock";
		}
	}

	[AttributeType]
	public class plasterblockslopeXMinus : DecorativeTypeXMinus
	{
		public plasterblockslopeXMinus() : base("plasterblock", "slope", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("fourstepstairsx-");
		}
	}

	[AttributeType]
	public class plasterblockslopeXPlus : DecorativeTypeXPlus
	{
		public plasterblockslopeXPlus() : base("plasterblock", "slope", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("fourstepstairsx+");
		}
	}

	[AttributeType]
	public class plasterblockslopeZMinus : DecorativeTypeZMinus
	{
		public plasterblockslopeZMinus() : base("plasterblock", "slope", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("fourstepstairsz-");
		}
	}

	[AttributeType]
	public class plasterblockslopeZPlus : DecorativeTypeZPlus
	{
		public plasterblockslopeZPlus() : base("plasterblock", "slope", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("fourstepstairsz+");
		}
	}
}