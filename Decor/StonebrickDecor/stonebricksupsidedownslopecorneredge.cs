using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.ShapedBlocks.Decor
{
	[AttributePlayerRecipe]
	public class stonebricksupsidedownslopecorneredgeRecipe : BaseRecipe
	{
		public stonebricksupsidedownslopecorneredgeRecipe() : base("stonebricksupsidedownslopecorneredgerecipe")
		{
			Requirements.Add(new InventoryItem("stonebricks", 1));
			Result.Add(new InventoryItem("stonebricksupsidedownslopecorneredge", 1));
		}
	}
	
	[AttributeType]
	public class stonebricksupsidedownslopecorneredge : DecorativeType
	{
		public stonebricksupsidedownslopecorneredge() : base("stonebricks", "upsidedownslopecorneredge",
			Utilities.MultiCombine(ShapedBlocks.ModIconDirectory, "stonebricksupsidedownslopecorneredge.png"))
		{
			this.SideAll = "stonebricks";
		}
	}

	[AttributeType]
	public class stonebricksupsidedownslopecorneredgeXMinus : DecorativeTypeXMinus
	{
		public stonebricksupsidedownslopecorneredgeXMinus() : base("stonebricks", "upsidedownslopecorneredge", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedownslopecorneredgex-");
		}
	}

	[AttributeType]
	public class stonebricksupsidedownslopecorneredgeXPlus : DecorativeTypeXPlus
	{
		public stonebricksupsidedownslopecorneredgeXPlus() : base("stonebricks", "upsidedownslopecorneredge", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedownslopecorneredgex+");
		}
	}

	[AttributeType]
	public class stonebricksupsidedownslopecorneredgeZMinus : DecorativeTypeZMinus
	{
		public stonebricksupsidedownslopecorneredgeZMinus() : base("stonebricks", "upsidedownslopecorneredge", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedownslopecorneredgez-");
		}
	}

	[AttributeType]
	public class stonebricksupsidedownslopecorneredgeZPlus : DecorativeTypeZPlus
	{
		public stonebricksupsidedownslopecorneredgeZPlus() : base("stonebricks", "upsidedownslopecorneredge", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedownslopecorneredgez+");
		}
	}
}