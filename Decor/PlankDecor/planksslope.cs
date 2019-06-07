using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.ShapedBlocks.Decor
{
	[AttributePlayerRecipe]
	public class planksslopeRecipe : BaseRecipe
	{
		public planksslopeRecipe() : base("plankssloperecipe")
		{
			Requirements.Add(new InventoryItem("stonebricks", 1));
			Result.Add(new InventoryItem("planksslope", 1));
		}
	}
	
	[AttributeType]
	public class planksslope : DecorativeType
	{
		public planksslope() : base("planks", "slope",
			Utilities.MultiCombine(ShapedBlocks.ModIconDirectory, "planksslope.png"))
		{
			this.SideAll = "planks";
		}
	}

	[AttributeType]
	public class planksslopeXMinus : DecorativeTypeXMinus
	{
		public planksslopeXMinus() : base("planks", "slope", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("slopex-");
		}
	}

	[AttributeType]
	public class planksslopeXPlus : DecorativeTypeXPlus
	{
		public planksslopeXPlus() : base("planks", "slope", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("slopex+");
		}
	}

	[AttributeType]
	public class planksslopeZMinus : DecorativeTypeZMinus
	{
		public planksslopeZMinus() : base("planks", "slope", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("slopez-");
		}
	}

	[AttributeType]
	public class planksslopeZPlus : DecorativeTypeZPlus
	{
		public planksslopeZPlus() : base("planks", "slope", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("slopez+");
		}
	}
}