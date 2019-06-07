using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.ShapedBlocks.Decor
{
	[AttributePlayerRecipe]
	public class stonebrickscurveRecipe : BaseRecipe
	{
		public stonebrickscurveRecipe() : base("stonebrickscurverecipe")
		{
			Requirements.Add(new InventoryItem("stonebricks", 1));
			Result.Add(new InventoryItem("stonebrickscurve", 1));
		}
	}
	
	[AttributeType]
	public class stonebrickscurve : DecorativeType
	{
		public stonebrickscurve() : base("stonebricks", "curve",
			Utilities.MultiCombine(ShapedBlocks.ModIconDirectory, "stonebrickscurve.png"))
		{
			this.SideAll = "stonebricks";
		}
	}

	[AttributeType]
	public class stonebrickscurveXMinus : DecorativeTypeXMinus
	{
		public stonebrickscurveXMinus() : base("stonebricks", "curve", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("curvex-");
		}
	}

	[AttributeType]
	public class stonebrickscurveXPlus : DecorativeTypeXPlus
	{
		public stonebrickscurveXPlus() : base("stonebricks", "curve", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("curvex+");
		}
	}

	[AttributeType]
	public class stonebrickscurveZMinus : DecorativeTypeZMinus
	{
		public stonebrickscurveZMinus() : base("stonebricks", "curve", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("curvez-");
		}
	}

	[AttributeType]
	public class stonebrickscurveZPlus : DecorativeTypeZPlus
	{
		public stonebrickscurveZPlus() : base("stonebricks", "curve", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("curvez+");
		}
	}
}