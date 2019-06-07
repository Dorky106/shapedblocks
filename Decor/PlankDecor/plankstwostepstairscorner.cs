using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.ShapedBlocks.Decor
{
	[AttributePlayerRecipe]
	public class plankstwostepstairscornerRecipe : BaseRecipe
	{
		public plankstwostepstairscornerRecipe() : base("plankstwostepstairscornerrecipe")
		{
			Requirements.Add(new InventoryItem("stonebricks", 1));
			Result.Add(new InventoryItem("plankstwostepstairscorner", 1));
		}
	}
	
	[AttributeType]
	public class plankstwostepstairscorner : DecorativeType
	{
		public plankstwostepstairscorner() : base("planks", "twostepstairscorner",
			Utilities.MultiCombine(ShapedBlocks.ModIconDirectory, "plankstwostepstairscorner.png"))
		{
			this.SideAll = "planks";
		}
	}

	[AttributeType]
	public class plankstwostepstairscornerXMinus : DecorativeTypeXMinus
	{
		public plankstwostepstairscornerXMinus() : base("planks", "twostepstairscorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("twostepstairscornerx-");
		}
	}

	[AttributeType]
	public class plankstwostepstairscornerXPlus : DecorativeTypeXPlus
	{
		public plankstwostepstairscornerXPlus() : base("planks", "twostepstairscorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("twostepstairscornerx+");
		}
	}

	[AttributeType]
	public class plankstwostepstairscornerZMinus : DecorativeTypeZMinus
	{
		public plankstwostepstairscornerZMinus() : base("planks", "twostepstairscorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("twostepstairscornerz-");
		}
	}

	[AttributeType]
	public class plankstwostepstairscornerZPlus : DecorativeTypeZPlus
	{
		public plankstwostepstairscornerZPlus() : base("planks", "twostepstairscorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("twostepstairscornerz+");
		}
	}
}