using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.ShapedBlocks.Decor
{
	[AttributePlayerRecipe]
	public class planksupsidedownslopecorneredgeRecipe : BaseRecipe
	{
		public planksupsidedownslopecorneredgeRecipe() : base("planksupsidedownslopecorneredgerecipe")
		{
			Requirements.Add(new InventoryItem("stonebricks", 1));
			Result.Add(new InventoryItem("planksupsidedownslopecorneredge", 1));
		}
	}
	
	[AttributeType]
	public class planksupsidedownslopecorneredge : DecorativeType
	{
		public planksupsidedownslopecorneredge() : base("planks", "upsidedownslopecorneredge",
			Utilities.MultiCombine(ShapedBlocks.ModIconDirectory, "planksupsidedownslopecorneredge.png"))
		{
			this.SideAll = "planks";
		}
	}

	[AttributeType]
	public class planksupsidedownslopecorneredgeXMinus : DecorativeTypeXMinus
	{
		public planksupsidedownslopecorneredgeXMinus() : base("planks", "upsidedownslopecorneredge", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedownslopecorneredgex-");
		}
	}

	[AttributeType]
	public class planksupsidedownslopecorneredgeXPlus : DecorativeTypeXPlus
	{
		public planksupsidedownslopecorneredgeXPlus() : base("planks", "upsidedownslopecorneredge", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedownslopecorneredgex+");
		}
	}

	[AttributeType]
	public class planksupsidedownslopecorneredgeZMinus : DecorativeTypeZMinus
	{
		public planksupsidedownslopecorneredgeZMinus() : base("planks", "upsidedownslopecorneredge", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedownslopecorneredgez-");
		}
	}

	[AttributeType]
	public class planksupsidedownslopecorneredgeZPlus : DecorativeTypeZPlus
	{
		public planksupsidedownslopecorneredgeZPlus() : base("planks", "upsidedownslopecorneredge", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedownslopecorneredgez+");
		}
	}
}