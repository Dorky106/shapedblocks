using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.ShapedBlocks.Decor
{
	[AttributePlayerRecipe]
	public class brickscurveRecipe : BaseRecipe
	{
		public brickscurveRecipe() : base("brickscurverecipe")
		{
			Requirements.Add(new InventoryItem("stonebricks", 1));
			Result.Add(new InventoryItem("brickscurve", 1));
		}
	}
	
	[AttributeType]
	public class brickscurve : DecorativeType
	{
		public brickscurve() : base("bricks", "curve",
			Utilities.MultiCombine(ShapedBlocks.ModIconDirectory, "brickscurve.png"))
		{
			this.SideAll = "bricks";
		}
	}

	[AttributeType]
	public class brickscurveXMinus : DecorativeTypeXMinus
	{
		public brickscurveXMinus() : base("bricks", "curve", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("curvex-");
		}
	}

	[AttributeType]
	public class brickscurveXPlus : DecorativeTypeXPlus
	{
		public brickscurveXPlus() : base("bricks", "curve", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("curvex+");
		}
	}

	[AttributeType]
	public class brickscurveZMinus : DecorativeTypeZMinus
	{
		public brickscurveZMinus() : base("bricks", "curve", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("curvez-");
		}
	}

	[AttributeType]
	public class brickscurveZPlus : DecorativeTypeZPlus
	{
		public brickscurveZPlus() : base("bricks", "curve", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("curvez+");
		}
	}
}