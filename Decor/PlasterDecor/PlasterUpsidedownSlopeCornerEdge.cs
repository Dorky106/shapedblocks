using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.ShapedBlocks.Decor
{
	[AttributePlayerRecipe]
	public class plasterblockupsidedownslopecorneredgeRecipe : BaseRecipe
	{
		public plasterblockupsidedownslopecorneredgeRecipe() : base("plasterblockupsidedownslopecorneredgerecipe")
		{
			Requirements.Add(new InventoryItem("stonebricks", 1));
			Result.Add(new InventoryItem("plasterblockupsidedownslopecorneredge", 1));
		}
	}
	
	[AttributeType]
	public class plasterblockupsidedownslopecorneredge : DecorativeType
	{
		public plasterblockupsidedownslopecorneredge() : base("plasterblock", "upsidedownslopecorneredge",
			Utilities.MultiCombine(ShapedBlocks.ModIconDirectory, "plasterblockupsidedownslopecorneredge.png"))
		{
			this.SideAll = "plasterblock";
		}
	}

	[AttributeType]
	public class plasterblockupsidedownslopecorneredgeXMinus : DecorativeTypeXMinus
	{
		public plasterblockupsidedownslopecorneredgeXMinus() : base("plasterblock", "upsidedownslopecorneredge", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedownslopecorneredgex-");
		}
	}

	[AttributeType]
	public class plasterblockupsidedownslopecorneredgeXPlus : DecorativeTypeXPlus
	{
		public plasterblockupsidedownslopecorneredgeXPlus() : base("plasterblock", "upsidedownslopecorneredge", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedownslopecorneredgex+");
		}
	}

	[AttributeType]
	public class plasterblockupsidedownslopecorneredgeZMinus : DecorativeTypeZMinus
	{
		public plasterblockupsidedownslopecorneredgeZMinus() : base("plasterblock", "upsidedownslopecorneredge", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedownslopecorneredgez-");
		}
	}

	[AttributeType]
	public class plasterblockupsidedownslopecorneredgeZPlus : DecorativeTypeZPlus
	{
		public plasterblockupsidedownslopecorneredgeZPlus() : base("plasterblock", "upsidedownslopecorneredge", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedownslopecorneredgez+");
		}
	}
}