using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.ShapedBlocks.Decor
{
	[AttributePlayerRecipe]
	public class brickscurverotatedRecipe : BaseRecipe
	{
		public brickscurverotatedRecipe() : base("brickscurverotatedrecipe")
		{
			Requirements.Add(new InventoryItem("stonebricks", 1));
			Result.Add(new InventoryItem("brickscurverotated", 1));
		}
	}
	
	[AttributeType]
	public class brickscurverotated : DecorativeType
	{
		public brickscurverotated() : base("bricks", "curverotated",
			Utilities.MultiCombine(ShapedBlocks.ModIconDirectory, "brickscurverotated.png"))
		{
			this.SideAll = "bricks";
		}
	}

	[AttributeType]
	public class brickscurverotatedXMinus : DecorativeTypeXMinus
	{
		public brickscurverotatedXMinus() : base("bricks", "curverotated", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("curverotatedx-");
		}
	}

	[AttributeType]
	public class brickscurverotatedXPlus : DecorativeTypeXPlus
	{
		public brickscurverotatedXPlus() : base("bricks", "curverotated", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("curverotatedx+");
		}
	}

	[AttributeType]
	public class brickscurverotatedZMinus : DecorativeTypeZMinus
	{
		public brickscurverotatedZMinus() : base("bricks", "curverotated", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("curverotatedz-");
		}
	}

	[AttributeType]
	public class brickscurverotatedZPlus : DecorativeTypeZPlus
	{
		public brickscurverotatedZPlus() : base("bricks", "curverotated", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("curverotatedz+");
		}
	}
}