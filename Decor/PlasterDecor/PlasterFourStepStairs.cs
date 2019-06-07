using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.ShapedBlocks.Decor
{
	[AttributePlayerRecipe]
	public class plasterblockfourstepstairsRecipe : BaseRecipe
	{
		public plasterblockfourstepstairsRecipe() : base("plasterblockfourstepstairsrecipe")
		{
			Requirements.Add(new InventoryItem("stonebricks", 1));
			Result.Add(new InventoryItem("plasterblockfourstepstairs", 1));
		}
	}
	
	[AttributeType]
	public class plasterblockfourstepstairs : DecorativeType
	{
		public plasterblockfourstepstairs() : base("plasterblock", "fourstepstairs",
			Utilities.MultiCombine(ShapedBlocks.ModIconDirectory, "plasterblockfourstepstairs.png"))
		{
			this.SideAll = "plasterblock";
		}
	}

	[AttributeType]
	public class plasterblockfourstepstairsXMinus : DecorativeTypeXMinus
	{
		public plasterblockfourstepstairsXMinus() : base("plasterblock", "fourstepstairs", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("fourstepstairsx-");
		}
	}

	[AttributeType]
	public class plasterblockfourstepstairsXPlus : DecorativeTypeXPlus
	{
		public plasterblockfourstepstairsXPlus() : base("plasterblock", "fourstepstairs", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("fourstepstairsx+");
		}
	}

	[AttributeType]
	public class plasterblockfourstepstairsZMinus : DecorativeTypeZMinus
	{
		public plasterblockfourstepstairsZMinus() : base("plasterblock", "fourstepstairs", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("fourstepstairsz-");
		}
	}

	[AttributeType]
	public class plasterblockfourstepstairsZPlus : DecorativeTypeZPlus
	{
		public plasterblockfourstepstairsZPlus() : base("plasterblock", "fourstepstairs", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("fourstepstairsz+");
		}
	}
}