using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.ShapedBlocks.Decor
{
	[AttributePlayerRecipe]
	public class plasterblockcurveRecipe : BaseRecipe
	{
		public plasterblockcurveRecipe() : base("plasterblockcurverecipe")
		{
			Requirements.Add(new InventoryItem("stonebricks", 1));
			Result.Add(new InventoryItem("plasterblockcurve", 1));
		}
	}
	
	[AttributeType]
	public class plasterblockcurve : DecorativeType
	{
		public plasterblockcurve() : base("plasterblock", "curve",
			Utilities.MultiCombine(ShapedBlocks.ModIconDirectory, "plasterblockcurve.png"))
		{
			this.SideAll = "plasterblock";
		}
	}

	[AttributeType]
	public class plasterblockcurveXMinus : DecorativeTypeXMinus
	{
		public plasterblockcurveXMinus() : base("plasterblock", "curve", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("curvex-");
		}
	}

	[AttributeType]
	public class plasterblockcurveXPlus : DecorativeTypeXPlus
	{
		public plasterblockcurveXPlus() : base("plasterblock", "curve", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("curvex+");
		}
	}

	[AttributeType]
	public class plasterblockcurveZMinus : DecorativeTypeZMinus
	{
		public plasterblockcurveZMinus() : base("plasterblock", "curve", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("curvez-");
		}
	}

	[AttributeType]
	public class plasterblockcurveZPlus : DecorativeTypeZPlus
	{
		public plasterblockcurveZPlus() : base("plasterblock", "curve", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("curvez+");
		}
	}
}