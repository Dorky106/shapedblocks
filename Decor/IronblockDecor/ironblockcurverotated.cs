using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.ShapedBlocks.Decor
{
	[AttributePlayerRecipe]
	public class ironblockcurverotatedRecipe : BaseRecipe
	{
		public ironblockcurverotatedRecipe() : base("ironblockcurverotatedrecipe")
		{
			Requirements.Add(new InventoryItem("stonebricks", 1));
			Result.Add(new InventoryItem("ironblockcurverotated", 1));
		}
	}
	
	[AttributeType]
	public class ironblockcurverotated : DecorativeType
	{
		public ironblockcurverotated() : base("ironblock", "curverotated",
			Utilities.MultiCombine(ShapedBlocks.ModIconDirectory, "ironblockcurverotated.png"))
		{
			this.SideAll = "ironblock";
		}
	}

	[AttributeType]
	public class ironblockcurverotatedXMinus : DecorativeTypeXMinus
	{
		public ironblockcurverotatedXMinus() : base("ironblock", "curverotated", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("curverotatedx-");
		}
	}

	[AttributeType]
	public class ironblockcurverotatedXPlus : DecorativeTypeXPlus
	{
		public ironblockcurverotatedXPlus() : base("ironblock", "curverotated", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("curverotatedx+");
		}
	}

	[AttributeType]
	public class ironblockcurverotatedZMinus : DecorativeTypeZMinus
	{
		public ironblockcurverotatedZMinus() : base("ironblock", "curverotated", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("curverotatedz-");
		}
	}

	[AttributeType]
	public class ironblockcurverotatedZPlus : DecorativeTypeZPlus
	{
		public ironblockcurverotatedZPlus() : base("ironblock", "curverotated", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("curverotatedz+");
		}
	}
}