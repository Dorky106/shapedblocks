using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.ShapedBlocks.Decor
{
	[AttributePlayerRecipe]
	public class planksfourstepstairscornerRecipe : BaseRecipe
	{
		public planksfourstepstairscornerRecipe() : base("planksfourstepstairscornerrecipe")
		{
			Requirements.Add(new InventoryItem("stonebricks", 1));
			Result.Add(new InventoryItem("planksfourstepstairscorner", 1));
		}
	}
	
	[AttributeType]
	public class planksfourstepstairscorner : DecorativeType
	{
		public planksfourstepstairscorner() : base("planks", "fourstepstairscorner",
			Utilities.MultiCombine(ShapedBlocks.ModIconDirectory, "planksfourstepstairscorner.png"))
		{
			this.SideAll = "planks";
		}
	}

	[AttributeType]
	public class planksfourstepstairscornerXMinus : DecorativeTypeXMinus
	{
		public planksfourstepstairscornerXMinus() : base("planks", "fourstepstairscorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("fourstepstairscornerx-");
		}
	}

	[AttributeType]
	public class planksfourstepstairscornerXPlus : DecorativeTypeXPlus
	{
		public planksfourstepstairscornerXPlus() : base("planks", "fourstepstairscorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("fourstepstairscornerx+");
		}
	}

	[AttributeType]
	public class planksfourstepstairscornerZMinus : DecorativeTypeZMinus
	{
		public planksfourstepstairscornerZMinus() : base("planks", "fourstepstairscorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("fourstepstairscornerz-");
		}
	}

	[AttributeType]
	public class planksfourstepstairscornerZPlus : DecorativeTypeZPlus
	{
		public planksfourstepstairscornerZPlus() : base("planks", "fourstepstairscorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("fourstepstairscornerz+");
		}
	}
}