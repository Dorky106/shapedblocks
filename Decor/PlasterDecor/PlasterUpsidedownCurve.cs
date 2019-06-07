using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.ShapedBlocks.Decor
{
	[AttributePlayerRecipe]
	public class plasterblockupsidedowncurveRecipe : BaseRecipe
	{
		public plasterblockupsidedowncurveRecipe() : base("plasterblockupsidedowncurverecipe")
		{
			Requirements.Add(new InventoryItem("stonebricks", 1));
			Result.Add(new InventoryItem("plasterblockupsidedowncurve", 1));
		}
	}
	
	[AttributeType]
	public class plasterblockupsidedowncurve : DecorativeType
	{
		public plasterblockupsidedowncurve() : base("plasterblock", "upsidedowncurve",
			Utilities.MultiCombine(ShapedBlocks.ModIconDirectory, "plasterblockupsidedowncurve.png"))
		{
			this.SideAll = "plasterblock";
		}
	}

	[AttributeType]
	public class plasterblockupsidedowncurveXMinus : DecorativeTypeXMinus
	{
		public plasterblockupsidedowncurveXMinus() : base("plasterblock", "upsidedowncurve", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedowncurvex-");
		}
	}

	[AttributeType]
	public class plasterblockupsidedowncurveXPlus : DecorativeTypeXPlus
	{
		public plasterblockupsidedowncurveXPlus() : base("plasterblock", "upsidedowncurve", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedowncurvex+");
		}
	}

	[AttributeType]
	public class plasterblockupsidedowncurveZMinus : DecorativeTypeZMinus
	{
		public plasterblockupsidedowncurveZMinus() : base("plasterblock", "upsidedowncurve", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedowncurvez-");
		}
	}

	[AttributeType]
	public class plasterblockupsidedowncurveZPlus : DecorativeTypeZPlus
	{
		public plasterblockupsidedowncurveZPlus() : base("plasterblock", "upsidedowncurve", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedowncurvez+");
		}
	}
}