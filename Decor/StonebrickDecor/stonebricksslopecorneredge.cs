using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.ShapedBlocks.Decor
{
	[AttributePlayerRecipe]
	public class stonebricksslopecorneredgeRecipe : BaseRecipe
	{
		public stonebricksslopecorneredgeRecipe() : base("stonebricksslopecorneredgerecipe")
		{
			Requirements.Add(new InventoryItem("stonebricks", 1));
			Result.Add(new InventoryItem("stonebricksslopecorneredge", 1));
		}
	}
	
	[AttributeType]
	public class stonebricksslopecorneredge : DecorativeType
	{
		public stonebricksslopecorneredge() : base("stonebricks", "slopecorneredge",
			Utilities.MultiCombine(ShapedBlocks.ModIconDirectory, "stonebricksslopecorneredge.png"))
		{
			this.SideAll = "stonebricks";
		}
	}

	[AttributeType]
	public class stonebricksslopecorneredgeXMinus : DecorativeTypeXMinus
	{
		public stonebricksslopecorneredgeXMinus() : base("stonebricks", "slopecorneredge", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("slopecorneredgex-");
		}
	}

	[AttributeType]
	public class stonebricksslopecorneredgeXPlus : DecorativeTypeXPlus
	{
		public stonebricksslopecorneredgeXPlus() : base("stonebricks", "slopecorneredge", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("slopecorneredgex+");
		}
	}

	[AttributeType]
	public class stonebricksslopecorneredgeZMinus : DecorativeTypeZMinus
	{
		public stonebricksslopecorneredgeZMinus() : base("stonebricks", "slopecorneredge", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("slopecorneredgez-");
		}
	}

	[AttributeType]
	public class stonebricksslopecorneredgeZPlus : DecorativeTypeZPlus
	{
		public stonebricksslopecorneredgeZPlus() : base("stonebricks", "slopecorneredge", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("slopecorneredgez+");
		}
	}
}