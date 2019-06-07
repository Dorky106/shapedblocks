using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.ShapedBlocks.Decor
{
	[AttributePlayerRecipe]
	public class bricksupsidedownslopecorneredgeRecipe : BaseRecipe
	{
		public bricksupsidedownslopecorneredgeRecipe() : base("bricksupsidedownslopecorneredgerecipe")
		{
			Requirements.Add(new InventoryItem("stonebricks", 1));
			Result.Add(new InventoryItem("bricksupsidedownslopecorneredge", 1));
		}
	}
	
	[AttributeType]
	public class bricksupsidedownslopecorneredge : DecorativeType
	{
		public bricksupsidedownslopecorneredge() : base("bricks", "upsidedownslopecorneredge",
			Utilities.MultiCombine(ShapedBlocks.ModIconDirectory, "bricksupsidedownslopecorneredge.png"))
		{
			this.SideAll = "bricks";
		}
	}

	[AttributeType]
	public class bricksupsidedownslopecorneredgeXMinus : DecorativeTypeXMinus
	{
		public bricksupsidedownslopecorneredgeXMinus() : base("bricks", "upsidedownslopecorneredge", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedownslopecorneredgex-");
		}
	}

	[AttributeType]
	public class bricksupsidedownslopecorneredgeXPlus : DecorativeTypeXPlus
	{
		public bricksupsidedownslopecorneredgeXPlus() : base("bricks", "upsidedownslopecorneredge", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedownslopecorneredgex+");
		}
	}

	[AttributeType]
	public class bricksupsidedownslopecorneredgeZMinus : DecorativeTypeZMinus
	{
		public bricksupsidedownslopecorneredgeZMinus() : base("bricks", "upsidedownslopecorneredge", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedownslopecorneredgez-");
		}
	}

	[AttributeType]
	public class bricksupsidedownslopecorneredgeZPlus : DecorativeTypeZPlus
	{
		public bricksupsidedownslopecorneredgeZPlus() : base("bricks", "upsidedownslopecorneredge", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedownslopecorneredgez+");
		}
	}
}