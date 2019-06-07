using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.ShapedBlocks.Decor
{
	[AttributePlayerRecipe]
	public class ironblockslopecorneredgeRecipe : BaseRecipe
	{
		public ironblockslopecorneredgeRecipe() : base("ironblockslopecorneredgerecipe")
		{
			Requirements.Add(new InventoryItem("stonebricks", 1));
			Result.Add(new InventoryItem("ironblockslopecorneredge", 1));
		}
	}
	
	[AttributeType]
	public class ironblockslopecorneredge : DecorativeType
	{
		public ironblockslopecorneredge() : base("ironblock", "slopecorneredge",
			Utilities.MultiCombine(ShapedBlocks.ModIconDirectory, "ironblockslopecorneredge.png"))
		{
			this.SideAll = "ironblock";
		}
	}

	[AttributeType]
	public class ironblockslopecorneredgeXMinus : DecorativeTypeXMinus
	{
		public ironblockslopecorneredgeXMinus() : base("ironblock", "slopecorneredge", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("slopecorneredgex-");
		}
	}

	[AttributeType]
	public class ironblockslopecorneredgeXPlus : DecorativeTypeXPlus
	{
		public ironblockslopecorneredgeXPlus() : base("ironblock", "slopecorneredge", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("slopecorneredgex+");
		}
	}

	[AttributeType]
	public class ironblockslopecorneredgeZMinus : DecorativeTypeZMinus
	{
		public ironblockslopecorneredgeZMinus() : base("ironblock", "slopecorneredge", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("slopecorneredgez-");
		}
	}

	[AttributeType]
	public class ironblockslopecorneredgeZPlus : DecorativeTypeZPlus
	{
		public ironblockslopecorneredgeZPlus() : base("ironblock", "slopecorneredge", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("slopecorneredgez+");
		}
	}
}