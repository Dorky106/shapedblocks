using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.ShapedBlocks.Decor
{
	[AttributePlayerRecipe]
	public class brickstwostepstairsRecipe : BaseRecipe
	{
		public brickstwostepstairsRecipe() : base("brickstwostepstairsrecipe")
		{
			Requirements.Add(new InventoryItem("stonebricks", 1));
			Result.Add(new InventoryItem("brickstwostepstairs", 1));
		}
	}
	
	[AttributeType]
	public class brickstwostepstairs : DecorativeType
	{
		public brickstwostepstairs() : base("bricks", "twostepstairs",
			Utilities.MultiCombine(ShapedBlocks.ModIconDirectory, "brickstwostepstairs.png"))
		{
			this.SideAll = "bricks";
		}
	}

	[AttributeType]
	public class brickstwostepstairsXMinus : DecorativeTypeXMinus
	{
		public brickstwostepstairsXMinus() : base("bricks", "twostepstairs", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("twostepstairsx-");
		}
	}

	[AttributeType]
	public class brickstwostepstairsXPlus : DecorativeTypeXPlus
	{
		public brickstwostepstairsXPlus() : base("bricks", "twostepstairs", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("twostepstairsx+");
		}
	}

	[AttributeType]
	public class brickstwostepstairsZMinus : DecorativeTypeZMinus
	{
		public brickstwostepstairsZMinus() : base("bricks", "twostepstairs", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("twostepstairsz-");
		}
	}

	[AttributeType]
	public class brickstwostepstairsZPlus : DecorativeTypeZPlus
	{
		public brickstwostepstairsZPlus() : base("bricks", "twostepstairs", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("twostepstairsz+");
		}
	}
}