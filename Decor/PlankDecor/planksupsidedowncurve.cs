using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.ShapedBlocks.Decor
{
	[AttributePlayerRecipe]
	public class planksupsidedowncurveRecipe : BaseRecipe
	{
		public planksupsidedowncurveRecipe() : base("planksupsidedowncurverecipe")
		{
			Requirements.Add(new InventoryItem("stonebricks", 1));
			Result.Add(new InventoryItem("planksupsidedowncurve", 1));
		}
	}
	
	[AttributeType]
	public class planksupsidedowncurve : DecorativeType
	{
		public planksupsidedowncurve() : base("planks", "upsidedowncurve",
			Utilities.MultiCombine(ShapedBlocks.ModIconDirectory, "planksupsidedowncurve.png"))
		{
			this.SideAll = "planks";
		}
	}

	[AttributeType]
	public class planksupsidedowncurveXMinus : DecorativeTypeXMinus
	{
		public planksupsidedowncurveXMinus() : base("planks", "upsidedowncurve", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedowncurvex-");
		}
	}

	[AttributeType]
	public class planksupsidedowncurveXPlus : DecorativeTypeXPlus
	{
		public planksupsidedowncurveXPlus() : base("planks", "upsidedowncurve", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedowncurvex+");
		}
	}

	[AttributeType]
	public class planksupsidedowncurveZMinus : DecorativeTypeZMinus
	{
		public planksupsidedowncurveZMinus() : base("planks", "upsidedowncurve", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedowncurvez-");
		}
	}

	[AttributeType]
	public class planksupsidedowncurveZPlus : DecorativeTypeZPlus
	{
		public planksupsidedowncurveZPlus() : base("planks", "upsidedowncurve", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedowncurvez+");
		}
	}
}