using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.ShapedBlocks.Decor
{
	[AttributePlayerRecipe]
	public class ironblockupsidedowncurveRecipe : BaseRecipe
	{
		public ironblockupsidedowncurveRecipe() : base("ironblockupsidedowncurverecipe")
		{
			Requirements.Add(new InventoryItem("stonebricks", 1));
			Result.Add(new InventoryItem("ironblockupsidedowncurve", 1));
		}
	}
	
	[AttributeType]
	public class ironblockupsidedowncurve : DecorativeType
	{
		public ironblockupsidedowncurve() : base("ironblock", "upsidedowncurve",
			Utilities.MultiCombine(ShapedBlocks.ModIconDirectory, "ironblockupsidedowncurve.png"))
		{
			this.SideAll = "ironblock";
		}
	}

	[AttributeType]
	public class ironblockupsidedowncurveXMinus : DecorativeTypeXMinus
	{
		public ironblockupsidedowncurveXMinus() : base("ironblock", "upsidedowncurve", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedowncurvex-");
		}
	}

	[AttributeType]
	public class ironblockupsidedowncurveXPlus : DecorativeTypeXPlus
	{
		public ironblockupsidedowncurveXPlus() : base("ironblock", "upsidedowncurve", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedowncurvex+");
		}
	}

	[AttributeType]
	public class ironblockupsidedowncurveZMinus : DecorativeTypeZMinus
	{
		public ironblockupsidedowncurveZMinus() : base("ironblock", "upsidedowncurve", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedowncurvez-");
		}
	}

	[AttributeType]
	public class ironblockupsidedowncurveZPlus : DecorativeTypeZPlus
	{
		public ironblockupsidedowncurveZPlus() : base("ironblock", "upsidedowncurve", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedowncurvez+");
		}
	}
}