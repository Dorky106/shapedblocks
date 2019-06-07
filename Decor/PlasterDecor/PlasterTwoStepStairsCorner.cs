using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.ShapedBlocks.Decor
{
	[AttributePlayerRecipe]
	public class plasterblocktwostepstairscornerRecipe : BaseRecipe
	{
		public plasterblocktwostepstairscornerRecipe() : base("plasterblocktwostepstairscornerrecipe")
		{
			Requirements.Add(new InventoryItem("stonebricks", 1));
			Result.Add(new InventoryItem("plasterblocktwostepstairscorner", 1));
		}
	}
	
	[AttributeType]
	public class plasterblocktwostepstairscorner : DecorativeType
	{
		public plasterblocktwostepstairscorner() : base("plasterblock", "twostepstairscorner",
			Utilities.MultiCombine(ShapedBlocks.ModIconDirectory, "plasterblocktwostepstairscorner.png"))
		{
			this.SideAll = "plasterblock";
		}
	}

	[AttributeType]
	public class plasterblocktwostepstairscornerXMinus : DecorativeTypeXMinus
	{
		public plasterblocktwostepstairscornerXMinus() : base("plasterblock", "twostepstairscorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("twostepstairscornerx-");
		}
	}

	[AttributeType]
	public class plasterblocktwostepstairscornerXPlus : DecorativeTypeXPlus
	{
		public plasterblocktwostepstairscornerXPlus() : base("plasterblock", "twostepstairscorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("twostepstairscornerx+");
		}
	}

	[AttributeType]
	public class plasterblocktwostepstairscornerZMinus : DecorativeTypeZMinus
	{
		public plasterblocktwostepstairscornerZMinus() : base("plasterblock", "twostepstairscorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("twostepstairscornerz-");
		}
	}

	[AttributeType]
	public class plasterblocktwostepstairscornerZPlus : DecorativeTypeZPlus
	{
		public plasterblocktwostepstairscornerZPlus() : base("plasterblock", "twostepstairscorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("twostepstairscornerz+");
		}
	}
}