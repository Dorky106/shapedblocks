using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.ShapedBlocks.Decor
{
	[AttributePlayerRecipe]
	public class plasterblockslopecorneredgeRecipe : BaseRecipe
	{
		public plasterblockslopecorneredgeRecipe() : base("plasterblockslopecorneredgerecipe")
		{
			Requirements.Add(new InventoryItem("stonebricks", 1));
			Result.Add(new InventoryItem("plasterblockslopecorneredge", 1));
		}
	}
	
	[AttributeType]
	public class plasterblockslopecorneredge : DecorativeType
	{
		public plasterblockslopecorneredge() : base("plasterblock", "slopecorneredge",
			Utilities.MultiCombine(ShapedBlocks.ModIconDirectory, "plasterblockslopecorneredge.png"))
		{
			this.SideAll = "plasterblock";
		}
	}

	[AttributeType]
	public class plasterblockslopecorneredgeXMinus : DecorativeTypeXMinus
	{
		public plasterblockslopecorneredgeXMinus() : base("plasterblock", "slopecorneredge", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("slopecorneredgex-");
		}
	}

	[AttributeType]
	public class plasterblockslopecorneredgeXPlus : DecorativeTypeXPlus
	{
		public plasterblockslopecorneredgeXPlus() : base("plasterblock", "slopecorneredge", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("slopecorneredgex+");
		}
	}

	[AttributeType]
	public class plasterblockslopecorneredgeZMinus : DecorativeTypeZMinus
	{
		public plasterblockslopecorneredgeZMinus() : base("plasterblock", "slopecorneredge", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("slopecorneredgez-");
		}
	}

	[AttributeType]
	public class plasterblockslopecorneredgeZPlus : DecorativeTypeZPlus
	{
		public plasterblockslopecorneredgeZPlus() : base("plasterblock", "slopecorneredge", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("slopecorneredgez+");
		}
	}
}