using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.ShapedBlocks.Decor
{
	[AttributePlayerRecipe]
	public class plasterblockfourstepstairscornerRecipe : BaseRecipe
	{
		public plasterblockfourstepstairscornerRecipe() : base("plasterblockfourstepstairscornerrecipe")
		{
			Requirements.Add(new InventoryItem("stonebricks", 1));
			Result.Add(new InventoryItem("plasterblockfourstepstairscorner", 1));
		}
	}
	
	[AttributeType]
	public class plasterblockfourstepstairscorner : DecorativeType
	{
		public plasterblockfourstepstairscorner() : base("plasterblock", "fourstepstairscorner",
			Utilities.MultiCombine(ShapedBlocks.ModIconDirectory, "plasterblockfourstepstairscorner.png"))
		{
			this.SideAll = "plasterblock";
		}
	}

	[AttributeType]
	public class plasterblockfourstepstairscornerXMinus : DecorativeTypeXMinus
	{
		public plasterblockfourstepstairscornerXMinus() : base("plasterblock", "fourstepstairscorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("fourstepstairscornerx-");
		}
	}

	[AttributeType]
	public class plasterblockfourstepstairscornerXPlus : DecorativeTypeXPlus
	{
		public plasterblockfourstepstairscornerXPlus() : base("plasterblock", "fourstepstairscorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("fourstepstairscornerx+");
		}
	}

	[AttributeType]
	public class plasterblockfourstepstairscornerZMinus : DecorativeTypeZMinus
	{
		public plasterblockfourstepstairscornerZMinus() : base("plasterblock", "fourstepstairscorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("fourstepstairscornerz-");
		}
	}

	[AttributeType]
	public class plasterblockfourstepstairscornerZPlus : DecorativeTypeZPlus
	{
		public plasterblockfourstepstairscornerZPlus() : base("plasterblock", "fourstepstairscorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("fourstepstairscornerz+");
		}
	}
}