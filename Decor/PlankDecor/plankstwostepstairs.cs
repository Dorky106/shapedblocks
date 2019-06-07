using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.ShapedBlocks.Decor
{
	[AttributePlayerRecipe]
	public class plankstwostepstairsRecipe : BaseRecipe
	{
		public plankstwostepstairsRecipe() : base("plankstwostepstairsrecipe")
		{
			Requirements.Add(new InventoryItem("stonebricks", 1));
			Result.Add(new InventoryItem("plankstwostepstairs", 1));
		}
	}
	
	[AttributeType]
	public class plankstwostepstairs : DecorativeType
	{
		public plankstwostepstairs() : base("planks", "twostepstairs",
			Utilities.MultiCombine(ShapedBlocks.ModIconDirectory, "plankstwostepstairs.png"))
		{
			this.SideAll = "planks";
		}
	}

	[AttributeType]
	public class plankstwostepstairsXMinus : DecorativeTypeXMinus
	{
		public plankstwostepstairsXMinus() : base("planks", "twostepstairs", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("twostepstairsx-");
		}
	}

	[AttributeType]
	public class plankstwostepstairsXPlus : DecorativeTypeXPlus
	{
		public plankstwostepstairsXPlus() : base("planks", "twostepstairs", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("twostepstairsx+");
		}
	}

	[AttributeType]
	public class plankstwostepstairsZMinus : DecorativeTypeZMinus
	{
		public plankstwostepstairsZMinus() : base("planks", "twostepstairs", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("twostepstairsz-");
		}
	}

	[AttributeType]
	public class plankstwostepstairsZPlus : DecorativeTypeZPlus
	{
		public plankstwostepstairsZPlus() : base("planks", "twostepstairs", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("twostepstairsz+");
		}
	}
}