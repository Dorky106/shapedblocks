using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.ShapedBlocks.Decor
{
	[AttributePlayerRecipe]
	public class ironblocktwostepstairscornerRecipe : BaseRecipe
	{
		public ironblocktwostepstairscornerRecipe() : base("ironblocktwostepstairscornerrecipe")
		{
			Requirements.Add(new InventoryItem("stonebricks", 1));
			Result.Add(new InventoryItem("ironblocktwostepstairscorner", 1));
		}
	}
	
	[AttributeType]
	public class ironblocktwostepstairscorner : DecorativeType
	{
		public ironblocktwostepstairscorner() : base("ironblock", "twostepstairscorner",
			Utilities.MultiCombine(ShapedBlocks.ModIconDirectory, "ironblocktwostepstairscorner.png"))
		{
			this.SideAll = "ironblock";
		}
	}

	[AttributeType]
	public class ironblocktwostepstairscornerXMinus : DecorativeTypeXMinus
	{
		public ironblocktwostepstairscornerXMinus() : base("ironblock", "twostepstairscorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("twostepstairscornerx-");
		}
	}

	[AttributeType]
	public class ironblocktwostepstairscornerXPlus : DecorativeTypeXPlus
	{
		public ironblocktwostepstairscornerXPlus() : base("ironblock", "twostepstairscorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("twostepstairscornerx+");
		}
	}

	[AttributeType]
	public class ironblocktwostepstairscornerZMinus : DecorativeTypeZMinus
	{
		public ironblocktwostepstairscornerZMinus() : base("ironblock", "twostepstairscorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("twostepstairscornerz-");
		}
	}

	[AttributeType]
	public class ironblocktwostepstairscornerZPlus : DecorativeTypeZPlus
	{
		public ironblocktwostepstairscornerZPlus() : base("ironblock", "twostepstairscorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("twostepstairscornerz+");
		}
	}
}