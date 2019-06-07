using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.ShapedBlocks.Decor
{
	[AttributePlayerRecipe]
	public class ironblocktwostepstairsRecipe : BaseRecipe
	{
		public ironblocktwostepstairsRecipe() : base("ironblocktwostepstairsrecipe")
		{
			Requirements.Add(new InventoryItem("stonebricks", 1));
			Result.Add(new InventoryItem("ironblocktwostepstairs", 1));
		}
	}
	
	[AttributeType]
	public class ironblocktwostepstairs : DecorativeType
	{
		public ironblocktwostepstairs() : base("ironblock", "twostepstairs",
			Utilities.MultiCombine(ShapedBlocks.ModIconDirectory, "ironblocktwostepstairs.png"))
		{
			this.SideAll = "ironblock";
		}
	}

	[AttributeType]
	public class ironblocktwostepstairsXMinus : DecorativeTypeXMinus
	{
		public ironblocktwostepstairsXMinus() : base("ironblock", "twostepstairs", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("twostepstairsx-");
		}
	}

	[AttributeType]
	public class ironblocktwostepstairsXPlus : DecorativeTypeXPlus
	{
		public ironblocktwostepstairsXPlus() : base("ironblock", "twostepstairs", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("twostepstairsx+");
		}
	}

	[AttributeType]
	public class ironblocktwostepstairsZMinus : DecorativeTypeZMinus
	{
		public ironblocktwostepstairsZMinus() : base("ironblock", "twostepstairs", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("twostepstairsz-");
		}
	}

	[AttributeType]
	public class ironblocktwostepstairsZPlus : DecorativeTypeZPlus
	{
		public ironblocktwostepstairsZPlus() : base("ironblock", "twostepstairs", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("twostepstairsz+");
		}
	}
}