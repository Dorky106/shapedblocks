using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.ShapedBlocks.Decor
{
	[AttributePlayerRecipe]
	public class plasterblocktwostepstairsRecipe : BaseRecipe
	{
		public plasterblocktwostepstairsRecipe() : base("plasterblocktwostepstairsrecipe")
		{
			Requirements.Add(new InventoryItem("stonebricks", 1));
			Result.Add(new InventoryItem("plasterblocktwostepstairs", 1));
		}
	}
	
	[AttributeType]
	public class plasterblocktwostepstairs : DecorativeType
	{
		public plasterblocktwostepstairs() : base("plasterblock", "twostepstairs",
			Utilities.MultiCombine(ShapedBlocks.ModIconDirectory, "plasterblocktwostepstairs.png"))
		{
			this.SideAll = "plasterblock";
		}
	}

	[AttributeType]
	public class plasterblocktwostepstairsXMinus : DecorativeTypeXMinus
	{
		public plasterblocktwostepstairsXMinus() : base("plasterblock", "twostepstairs", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("twostepstairsx-");
		}
	}

	[AttributeType]
	public class plasterblocktwostepstairsXPlus : DecorativeTypeXPlus
	{
		public plasterblocktwostepstairsXPlus() : base("plasterblock", "twostepstairs", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("twostepstairsx+");
		}
	}

	[AttributeType]
	public class plasterblocktwostepstairsZMinus : DecorativeTypeZMinus
	{
		public plasterblocktwostepstairsZMinus() : base("plasterblock", "twostepstairs", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("twostepstairsz-");
		}
	}

	[AttributeType]
	public class plasterblocktwostepstairsZPlus : DecorativeTypeZPlus
	{
		public plasterblocktwostepstairsZPlus() : base("plasterblock", "twostepstairs", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("twostepstairsz+");
		}
	}
}