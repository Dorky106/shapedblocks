using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.ShapedBlocks.Decor
{
	[AttributePlayerRecipe]
	public class plasterblockfourstepstairsinsidecornerRecipe : BaseRecipe
	{
		public plasterblockfourstepstairsinsidecornerRecipe() : base("plasterblockfourstepstairsinsidecornerrecipe")
		{
			Requirements.Add(new InventoryItem("stonebricks", 1));
			Result.Add(new InventoryItem("plasterblockfourstepstairsinsidecorner", 1));
		}
	}
	
	[AttributeType]
	public class plasterblockfourstepstairsinsidecorner : DecorativeType
	{
		public plasterblockfourstepstairsinsidecorner() : base("plasterblock", "fourstepstairsinsidecorner",
			Utilities.MultiCombine(ShapedBlocks.ModIconDirectory, "plasterblockfourstepstairsinsidecorner.png"))
		{
			this.SideAll = "plasterblock";
		}
	}

	[AttributeType]
	public class plasterblockfourstepstairsinsidecornerXMinus : DecorativeTypeXMinus
	{
		public plasterblockfourstepstairsinsidecornerXMinus() : base("plasterblock", "fourstepstairsinsidecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("fourstepstairsinsidecornerx-");
		}
	}

	[AttributeType]
	public class plasterblockfourstepstairsinsidecornerXPlus : DecorativeTypeXPlus
	{
		public plasterblockfourstepstairsinsidecornerXPlus() : base("plasterblock", "fourstepstairsinsidecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("fourstepstairsinsidecornerx+");
		}
	}

	[AttributeType]
	public class plasterblockfourstepstairsinsidecornerZMinus : DecorativeTypeZMinus
	{
		public plasterblockfourstepstairsinsidecornerZMinus() : base("plasterblock", "fourstepstairsinsidecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("fourstepstairsinsidecornerz-");
		}
	}

	[AttributeType]
	public class plasterblockfourstepstairsinsidecornerZPlus : DecorativeTypeZPlus
	{
		public plasterblockfourstepstairsinsidecornerZPlus() : base("plasterblock", "fourstepstairsinsidecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("fourstepstairsinsidecornerz+");
		}
	}
}