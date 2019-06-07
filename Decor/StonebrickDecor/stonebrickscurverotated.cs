using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.ShapedBlocks.Decor
{
	[AttributePlayerRecipe]
	public class stonebrickscurverotatedRecipe : BaseRecipe
	{
		public stonebrickscurverotatedRecipe() : base("stonebrickscurverotatedrecipe")
		{
			Requirements.Add(new InventoryItem("stonebricks", 1));
			Result.Add(new InventoryItem("stonebrickscurverotated", 1));
		}
	}
	
	[AttributeType]
	public class stonebrickscurverotated : DecorativeType
	{
		public stonebrickscurverotated() : base("stonebricks", "curverotated",
			Utilities.MultiCombine(ShapedBlocks.ModIconDirectory, "stonebrickscurverotated.png"))
		{
			this.SideAll = "stonebricks";
		}
	}

	[AttributeType]
	public class stonebrickscurverotatedXMinus : DecorativeTypeXMinus
	{
		public stonebrickscurverotatedXMinus() : base("stonebricks", "curverotated", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("curverotatedx-");
		}
	}

	[AttributeType]
	public class stonebrickscurverotatedXPlus : DecorativeTypeXPlus
	{
		public stonebrickscurverotatedXPlus() : base("stonebricks", "curverotated", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("curverotatedx+");
		}
	}

	[AttributeType]
	public class stonebrickscurverotatedZMinus : DecorativeTypeZMinus
	{
		public stonebrickscurverotatedZMinus() : base("stonebricks", "curverotated", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("curverotatedz-");
		}
	}

	[AttributeType]
	public class stonebrickscurverotatedZPlus : DecorativeTypeZPlus
	{
		public stonebrickscurverotatedZPlus() : base("stonebricks", "curverotated", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("curverotatedz+");
		}
	}
}