using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.ShapedBlocks.Decor
{
	[AttributePlayerRecipe]
	public class plankscurveRecipe : BaseRecipe
	{
		public plankscurveRecipe() : base("plankscurverecipe")
		{
			Requirements.Add(new InventoryItem("stonebricks", 1));
			Result.Add(new InventoryItem("plankscurve", 1));
		}
	}
	
	[AttributeType]
	public class plankscurve : DecorativeType
	{
		public plankscurve() : base("planks", "curve",
			Utilities.MultiCombine(ShapedBlocks.ModIconDirectory, "plankscurve.png"))
		{
			this.SideAll = "planks";
		}
	}

	[AttributeType]
	public class plankscurveXMinus : DecorativeTypeXMinus
	{
		public plankscurveXMinus() : base("planks", "curve", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("curvex-");
		}
	}

	[AttributeType]
	public class plankscurveXPlus : DecorativeTypeXPlus
	{
		public plankscurveXPlus() : base("planks", "curve", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("curvex+");
		}
	}

	[AttributeType]
	public class plankscurveZMinus : DecorativeTypeZMinus
	{
		public plankscurveZMinus() : base("planks", "curve", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("curvez-");
		}
	}

	[AttributeType]
	public class plankscurveZPlus : DecorativeTypeZPlus
	{
		public plankscurveZPlus() : base("planks", "curve", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("curvez+");
		}
	}
}