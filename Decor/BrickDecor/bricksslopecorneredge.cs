using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.ShapedBlocks.Decor
{
	[AttributePlayerRecipe]
	public class bricksslopecorneredgeRecipe : BaseRecipe
	{
		public bricksslopecorneredgeRecipe() : base("bricksslopecorneredgerecipe")
		{
			Requirements.Add(new InventoryItem("stonebricks", 1));
			Result.Add(new InventoryItem("bricksslopecorneredge", 1));
		}
	}
	
	[AttributeType]
	public class bricksslopecorneredge : DecorativeType
	{
		public bricksslopecorneredge() : base("bricks", "slopecorneredge",
			Utilities.MultiCombine(ShapedBlocks.ModIconDirectory, "bricksslopecorneredge.png"))
		{
			this.SideAll = "bricks";
		}
	}

	[AttributeType]
	public class bricksslopecorneredgeXMinus : DecorativeTypeXMinus
	{
		public bricksslopecorneredgeXMinus() : base("bricks", "slopecorneredge", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("slopecorneredgex-");
		}
	}

	[AttributeType]
	public class bricksslopecorneredgeXPlus : DecorativeTypeXPlus
	{
		public bricksslopecorneredgeXPlus() : base("bricks", "slopecorneredge", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("slopecorneredgex+");
		}
	}

	[AttributeType]
	public class bricksslopecorneredgeZMinus : DecorativeTypeZMinus
	{
		public bricksslopecorneredgeZMinus() : base("bricks", "slopecorneredge", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("slopecorneredgez-");
		}
	}

	[AttributeType]
	public class bricksslopecorneredgeZPlus : DecorativeTypeZPlus
	{
		public bricksslopecorneredgeZPlus() : base("bricks", "slopecorneredge", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("slopecorneredgez+");
		}
	}
}