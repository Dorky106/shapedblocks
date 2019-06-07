using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.ShapedBlocks.Decor
{
	[AttributePlayerRecipe]
	public class ironblockfourstepstairsRecipe : BaseRecipe
	{
		public ironblockfourstepstairsRecipe() : base("ironblockfourstepstairsrecipe")
		{
			Requirements.Add(new InventoryItem("stonebricks", 1));
			Result.Add(new InventoryItem("ironblockfourstepstairs", 1));
		}
	}
	
	[AttributeType]
	public class ironblockfourstepstairs : DecorativeType
	{
		public ironblockfourstepstairs() : base("ironblock", "fourstepstairs",
			Utilities.MultiCombine(ShapedBlocks.ModIconDirectory, "ironblockfourstepstairs.png"))
		{
			this.SideAll = "ironblock";
		}
	}

	[AttributeType]
	public class ironblockfourstepstairsXMinus : DecorativeTypeXMinus
	{
		public ironblockfourstepstairsXMinus() : base("ironblock", "fourstepstairs", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("fourstepstairsx-");
		}
	}

	[AttributeType]
	public class ironblockfourstepstairsXPlus : DecorativeTypeXPlus
	{
		public ironblockfourstepstairsXPlus() : base("ironblock", "fourstepstairs", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("fourstepstairsx+");
		}
	}

	[AttributeType]
	public class ironblockfourstepstairsZMinus : DecorativeTypeZMinus
	{
		public ironblockfourstepstairsZMinus() : base("ironblock", "fourstepstairs", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("fourstepstairsz-");
		}
	}

	[AttributeType]
	public class ironblockfourstepstairsZPlus : DecorativeTypeZPlus
	{
		public ironblockfourstepstairsZPlus() : base("ironblock", "fourstepstairs", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("fourstepstairsz+");
		}
	}
}