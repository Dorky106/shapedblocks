using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.ShapedBlocks.Decor
{
	[AttributePlayerRecipe]
	public class stonebricksupsidedowncurveRecipe : BaseRecipe
	{
		public stonebricksupsidedowncurveRecipe() : base("stonebricksupsidedowncurverecipe")
		{
			Requirements.Add(new InventoryItem("stonebricks", 1));
			Result.Add(new InventoryItem("stonebricksupsidedowncurve", 1));
		}
	}
	
	[AttributeType]
	public class stonebricksupsidedowncurve : DecorativeType
	{
		public stonebricksupsidedowncurve() : base("stonebricks", "upsidedowncurve",
			Utilities.MultiCombine(ShapedBlocks.ModIconDirectory, "stonebricksupsidedowncurve.png"))
		{
			this.SideAll = "stonebricks";
		}
	}

	[AttributeType]
	public class stonebricksupsidedowncurveXMinus : DecorativeTypeXMinus
	{
		public stonebricksupsidedowncurveXMinus() : base("stonebricks", "upsidedowncurve", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedowncurvex-");
		}
	}

	[AttributeType]
	public class stonebricksupsidedowncurveXPlus : DecorativeTypeXPlus
	{
		public stonebricksupsidedowncurveXPlus() : base("stonebricks", "upsidedowncurve", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedowncurvex+");
		}
	}

	[AttributeType]
	public class stonebricksupsidedowncurveZMinus : DecorativeTypeZMinus
	{
		public stonebricksupsidedowncurveZMinus() : base("stonebricks", "upsidedowncurve", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedowncurvez-");
		}
	}

	[AttributeType]
	public class stonebricksupsidedowncurveZPlus : DecorativeTypeZPlus
	{
		public stonebricksupsidedowncurveZPlus() : base("stonebricks", "upsidedowncurve", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedowncurvez+");
		}
	}
}