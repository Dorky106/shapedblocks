using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.ShapedBlocks.Decor
{
	[AttributePlayerRecipe]
	public class plasterblockcurverotatedRecipe : BaseRecipe
	{
		public plasterblockcurverotatedRecipe() : base("plasterblockcurverotatedrecipe")
		{
			Requirements.Add(new InventoryItem("stonebricks", 1));
			Result.Add(new InventoryItem("plasterblockcurverotated", 1));
		}
	}
	
	[AttributeType]
	public class plasterblockcurverotated : DecorativeType
	{
		public plasterblockcurverotated() : base("plasterblock", "curverotated",
			Utilities.MultiCombine(ShapedBlocks.ModIconDirectory, "plasterblockcurverotated.png"))
		{
			this.SideAll = "plasterblock";
		}
	}

	[AttributeType]
	public class plasterblockcurverotatedXMinus : DecorativeTypeXMinus
	{
		public plasterblockcurverotatedXMinus() : base("plasterblock", "curverotated", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("curverotatedx-");
		}
	}

	[AttributeType]
	public class plasterblockcurverotatedXPlus : DecorativeTypeXPlus
	{
		public plasterblockcurverotatedXPlus() : base("plasterblock", "curverotated", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("curverotatedx+");
		}
	}

	[AttributeType]
	public class plasterblockcurverotatedZMinus : DecorativeTypeZMinus
	{
		public plasterblockcurverotatedZMinus() : base("plasterblock", "curverotated", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("curverotatedz-");
		}
	}

	[AttributeType]
	public class plasterblockcurverotatedZPlus : DecorativeTypeZPlus
	{
		public plasterblockcurverotatedZPlus() : base("plasterblock", "curverotated", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("curverotatedz+");
		}
	}
}