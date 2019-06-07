using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.ShapedBlocks.Decor
{
	[AttributePlayerRecipe]
	public class ironblockupsidedownslopecorneredgeRecipe : BaseRecipe
	{
		public ironblockupsidedownslopecorneredgeRecipe() : base("ironblockupsidedownslopecorneredgerecipe")
		{
			Requirements.Add(new InventoryItem("stonebricks", 1));
			Result.Add(new InventoryItem("ironblockupsidedownslopecorneredge", 1));
		}
	}
	
	[AttributeType]
	public class ironblockupsidedownslopecorneredge : DecorativeType
	{
		public ironblockupsidedownslopecorneredge() : base("ironblock", "upsidedownslopecorneredge",
			Utilities.MultiCombine(ShapedBlocks.ModIconDirectory, "ironblockupsidedownslopecorneredge.png"))
		{
			this.SideAll = "ironblock";
		}
	}

	[AttributeType]
	public class ironblockupsidedownslopecorneredgeXMinus : DecorativeTypeXMinus
	{
		public ironblockupsidedownslopecorneredgeXMinus() : base("ironblock", "upsidedownslopecorneredge", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedownslopecorneredgex-");
		}
	}

	[AttributeType]
	public class ironblockupsidedownslopecorneredgeXPlus : DecorativeTypeXPlus
	{
		public ironblockupsidedownslopecorneredgeXPlus() : base("ironblock", "upsidedownslopecorneredge", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedownslopecorneredgex+");
		}
	}

	[AttributeType]
	public class ironblockupsidedownslopecorneredgeZMinus : DecorativeTypeZMinus
	{
		public ironblockupsidedownslopecorneredgeZMinus() : base("ironblock", "upsidedownslopecorneredge", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedownslopecorneredgez-");
		}
	}

	[AttributeType]
	public class ironblockupsidedownslopecorneredgeZPlus : DecorativeTypeZPlus
	{
		public ironblockupsidedownslopecorneredgeZPlus() : base("ironblock", "upsidedownslopecorneredge", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedownslopecorneredgez+");
		}
	}
}