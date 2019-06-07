using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.ShapedBlocks.Decor
{
	[AttributePlayerRecipe]
	public class bricksupsidedowncurveRecipe : BaseRecipe
	{
		public bricksupsidedowncurveRecipe() : base("bricksupsidedowncurverecipe")
		{
			Requirements.Add(new InventoryItem("stonebricks", 1));
			Result.Add(new InventoryItem("bricksupsidedowncurve", 1));
		}
	}
	
	[AttributeType]
	public class bricksupsidedowncurve : DecorativeType
	{
		public bricksupsidedowncurve() : base("bricks", "upsidedowncurve",
			Utilities.MultiCombine(ShapedBlocks.ModIconDirectory, "bricksupsidedowncurve.png"))
		{
			this.SideAll = "bricks";
		}
	}

	[AttributeType]
	public class bricksupsidedowncurveXMinus : DecorativeTypeXMinus
	{
		public bricksupsidedowncurveXMinus() : base("bricks", "upsidedowncurve", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedowncurvex-");
		}
	}

	[AttributeType]
	public class bricksupsidedowncurveXPlus : DecorativeTypeXPlus
	{
		public bricksupsidedowncurveXPlus() : base("bricks", "upsidedowncurve", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedowncurvex+");
		}
	}

	[AttributeType]
	public class bricksupsidedowncurveZMinus : DecorativeTypeZMinus
	{
		public bricksupsidedowncurveZMinus() : base("bricks", "upsidedowncurve", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedowncurvez-");
		}
	}

	[AttributeType]
	public class bricksupsidedowncurveZPlus : DecorativeTypeZPlus
	{
		public bricksupsidedowncurveZPlus() : base("bricks", "upsidedowncurve", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedowncurvez+");
		}
	}
}