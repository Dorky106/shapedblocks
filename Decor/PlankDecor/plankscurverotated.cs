using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.ShapedBlocks.Decor
{
	[AttributePlayerRecipe]
	public class plankscurverotatedRecipe : BaseRecipe
	{
		public plankscurverotatedRecipe() : base("plankscurverotatedrecipe")
		{
			Requirements.Add(new InventoryItem("stonebricks", 1));
			Result.Add(new InventoryItem("plankscurverotated", 1));
		}
	}
	
	[AttributeType]
	public class plankscurverotated : DecorativeType
	{
		public plankscurverotated() : base("planks", "curverotated",
			Utilities.MultiCombine(ShapedBlocks.ModIconDirectory, "plankscurverotated.png"))
		{
			this.SideAll = "planks";
		}
	}

	[AttributeType]
	public class plankscurverotatedXMinus : DecorativeTypeXMinus
	{
		public plankscurverotatedXMinus() : base("planks", "curverotated", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("curverotatedx-");
		}
	}

	[AttributeType]
	public class plankscurverotatedXPlus : DecorativeTypeXPlus
	{
		public plankscurverotatedXPlus() : base("planks", "curverotated", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("curverotatedx+");
		}
	}

	[AttributeType]
	public class plankscurverotatedZMinus : DecorativeTypeZMinus
	{
		public plankscurverotatedZMinus() : base("planks", "curverotated", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("curverotatedz-");
		}
	}

	[AttributeType]
	public class plankscurverotatedZPlus : DecorativeTypeZPlus
	{
		public plankscurverotatedZPlus() : base("planks", "curverotated", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("curverotatedz+");
		}
	}
}