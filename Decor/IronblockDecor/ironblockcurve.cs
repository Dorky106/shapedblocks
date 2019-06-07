using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.ShapedBlocks.Decor
{
	[AttributePlayerRecipe]
	public class ironblockcurveRecipe : BaseRecipe
	{
		public ironblockcurveRecipe() : base("ironblockcurverecipe")
		{
			Requirements.Add(new InventoryItem("stonebricks", 1));
			Result.Add(new InventoryItem("ironblockcurve", 1));
		}
	}
	
	[AttributeType]
	public class ironblockcurve : DecorativeType
	{
		public ironblockcurve() : base("ironblock", "curve",
			Utilities.MultiCombine(ShapedBlocks.ModIconDirectory, "ironblockcurve.png"))
		{
			this.SideAll = "ironblock";
		}
	}

	[AttributeType]
	public class ironblockcurveXMinus : DecorativeTypeXMinus
	{
		public ironblockcurveXMinus() : base("ironblock", "curve", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("curvex-");
		}
	}

	[AttributeType]
	public class ironblockcurveXPlus : DecorativeTypeXPlus
	{
		public ironblockcurveXPlus() : base("ironblock", "curve", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("curvex+");
		}
	}

	[AttributeType]
	public class ironblockcurveZMinus : DecorativeTypeZMinus
	{
		public ironblockcurveZMinus() : base("ironblock", "curve", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("curvez-");
		}
	}

	[AttributeType]
	public class ironblockcurveZPlus : DecorativeTypeZPlus
	{
		public ironblockcurveZPlus() : base("ironblock", "curve", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("curvez+");
		}
	}
}