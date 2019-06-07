using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.ShapedBlocks.Decor
{
	[AttributePlayerRecipe]
	public class ironblockfourstepstairsinsidecornerRecipe : BaseRecipe
	{
		public ironblockfourstepstairsinsidecornerRecipe() : base("ironblockfourstepstairsinsidecornerrecipe")
		{
			Requirements.Add(new InventoryItem("stonebricks", 1));
			Result.Add(new InventoryItem("ironblockfourstepstairsinsidecorner", 1));
		}
	}
	
	[AttributeType]
	public class ironblockfourstepstairsinsidecorner : DecorativeType
	{
		public ironblockfourstepstairsinsidecorner() : base("ironblock", "fourstepstairsinsidecorner",
			Utilities.MultiCombine(ShapedBlocks.ModIconDirectory, "ironblockfourstepstairsinsidecorner.png"))
		{
			this.SideAll = "ironblock";
		}
	}

	[AttributeType]
	public class ironblockfourstepstairsinsidecornerXMinus : DecorativeTypeXMinus
	{
		public ironblockfourstepstairsinsidecornerXMinus() : base("ironblock", "fourstepstairsinsidecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("fourstepstairsinsidecornerx-");
		}
	}

	[AttributeType]
	public class ironblockfourstepstairsinsidecornerXPlus : DecorativeTypeXPlus
	{
		public ironblockfourstepstairsinsidecornerXPlus() : base("ironblock", "fourstepstairsinsidecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("fourstepstairsinsidecornerx+");
		}
	}

	[AttributeType]
	public class ironblockfourstepstairsinsidecornerZMinus : DecorativeTypeZMinus
	{
		public ironblockfourstepstairsinsidecornerZMinus() : base("ironblock", "fourstepstairsinsidecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("fourstepstairsinsidecornerz-");
		}
	}

	[AttributeType]
	public class ironblockfourstepstairsinsidecornerZPlus : DecorativeTypeZPlus
	{
		public ironblockfourstepstairsinsidecornerZPlus() : base("ironblock", "fourstepstairsinsidecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("fourstepstairsinsidecornerz+");
		}
	}
}