using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.ShapedBlocks.Decor
{
	[AttributePlayerRecipe]
	public class planksslopecorneredgeRecipe : BaseRecipe
	{
		public planksslopecorneredgeRecipe() : base("planksslopecorneredgerecipe")
		{
			Requirements.Add(new InventoryItem("stonebricks", 1));
			Result.Add(new InventoryItem("planksslopecorneredge", 1));
		}
	}
	
	[AttributeType]
	public class planksslopecorneredge : DecorativeType
	{
		public planksslopecorneredge() : base("planks", "slopecorneredge",
			Utilities.MultiCombine(ShapedBlocks.ModIconDirectory, "planksslopecorneredge.png"))
		{
			this.SideAll = "planks";
		}
	}

	[AttributeType]
	public class planksslopecorneredgeXMinus : DecorativeTypeXMinus
	{
		public planksslopecorneredgeXMinus() : base("planks", "slopecorneredge", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("slopecorneredgex-");
		}
	}

	[AttributeType]
	public class planksslopecorneredgeXPlus : DecorativeTypeXPlus
	{
		public planksslopecorneredgeXPlus() : base("planks", "slopecorneredge", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("slopecorneredgex+");
		}
	}

	[AttributeType]
	public class planksslopecorneredgeZMinus : DecorativeTypeZMinus
	{
		public planksslopecorneredgeZMinus() : base("planks", "slopecorneredge", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("slopecorneredgez-");
		}
	}

	[AttributeType]
	public class planksslopecorneredgeZPlus : DecorativeTypeZPlus
	{
		public planksslopecorneredgeZPlus() : base("planks", "slopecorneredge", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("slopecorneredgez+");
		}
	}
}