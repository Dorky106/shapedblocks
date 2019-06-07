using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.ShapedBlocks.Decor
{
	[AttributePlayerRecipe]
	public class ironblockfourstepstairscornerRecipe : BaseRecipe
	{
		public ironblockfourstepstairscornerRecipe() : base("ironblockfourstepstairscornerrecipe")
		{
			Requirements.Add(new InventoryItem("stonebricks", 1));
			Result.Add(new InventoryItem("ironblockfourstepstairscorner", 1));
		}
	}
	
	[AttributeType]
	public class ironblockfourstepstairscorner : DecorativeType
	{
		public ironblockfourstepstairscorner() : base("ironblock", "fourstepstairscorner",
			Utilities.MultiCombine(ShapedBlocks.ModIconDirectory, "ironblockfourstepstairscorner.png"))
		{
			this.SideAll = "ironblock";
		}
	}

	[AttributeType]
	public class ironblockfourstepstairscornerXMinus : DecorativeTypeXMinus
	{
		public ironblockfourstepstairscornerXMinus() : base("ironblock", "fourstepstairscorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("fourstepstairscornerx-");
		}
	}

	[AttributeType]
	public class ironblockfourstepstairscornerXPlus : DecorativeTypeXPlus
	{
		public ironblockfourstepstairscornerXPlus() : base("ironblock", "fourstepstairscorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("fourstepstairscornerx+");
		}
	}

	[AttributeType]
	public class ironblockfourstepstairscornerZMinus : DecorativeTypeZMinus
	{
		public ironblockfourstepstairscornerZMinus() : base("ironblock", "fourstepstairscorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("fourstepstairscornerz-");
		}
	}

	[AttributeType]
	public class ironblockfourstepstairscornerZPlus : DecorativeTypeZPlus
	{
		public ironblockfourstepstairscornerZPlus() : base("ironblock", "fourstepstairscorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("fourstepstairscornerz+");
		}
	}
}