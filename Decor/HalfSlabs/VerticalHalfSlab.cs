using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;

namespace PhentrixGames.ShapedBlocks.Decor.HalfSlabs
{
	[AttributePlayerRecipe]
	public class VerticalHalfSlabRecipe : BaseRecipe
	{
		public VerticalHalfSlabRecipe() : base("plankshalfslaberecipe")
		{
			Requirements.Add(new InventoryItem("planks", 1));
			Result.Add(new InventoryItem("plankshalfslab", 1));
		}
	}

	[AttributeType]
	public class VerticalHalfSlab : DecorativeType
	{
		public VerticalHalfSlab() : base("planks", "halfslab", "")
		{
			this.SideAll = "planks";
			this.Icon = "halfslab.png";
		}
	}

	[AttributeType]
	public class IronblockCurveXMinus : DecorativeTypeXMinus
	{
		public IronblockCurveXMinus() : base("planks", "halfslab", ShapedBlocks.ModName)
		{
		}
	}

	[AttributeType]
	public class IronblockCurveXPlus : DecorativeTypeXPlus
	{
		public IronblockCurveXPlus() : base("planks", "halfslab", ShapedBlocks.ModName)
		{
		}
	}

	[AttributeType]
	public class IronblockCurveZMinus : DecorativeTypeZMinus
	{
		public IronblockCurveZMinus() : base("planks", "halfslab", ShapedBlocks.ModName)
		{
		}
	}

	[AttributeType]
	public class IronblockCurveZPlus : DecorativeTypeZPlus
	{
		public IronblockCurveZPlus() : base("planks", "halfslab", ShapedBlocks.ModName)
		{
		}
	}
}