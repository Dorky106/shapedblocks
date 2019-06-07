using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.ShapedBlocks.Decor
{
	[AttributePlayerRecipe]
	public class stonebricksfourstepstairscornerRecipe : BaseRecipe
	{
		public stonebricksfourstepstairscornerRecipe() : base("stonebricksfourstepstairscornerrecipe")
		{
			Requirements.Add(new InventoryItem("stonebricks", 1));
			Result.Add(new InventoryItem("stonebricksfourstepstairscorner", 1));
		}
	}
	
	[AttributeType]
	public class stonebricksfourstepstairscorner : DecorativeType
	{
		public stonebricksfourstepstairscorner() : base("stonebricks", "fourstepstairscorner",
			Utilities.MultiCombine(ShapedBlocks.ModIconDirectory, "stonebricksfourstepstairscorner.png"))
		{
			this.SideAll = "stonebricks";
		}
	}

	[AttributeType]
	public class stonebricksfourstepstairscornerXMinus : DecorativeTypeXMinus
	{
		public stonebricksfourstepstairscornerXMinus() : base("stonebricks", "fourstepstairscorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("fourstepstairscornerx-");
		}
	}

	[AttributeType]
	public class stonebricksfourstepstairscornerXPlus : DecorativeTypeXPlus
	{
		public stonebricksfourstepstairscornerXPlus() : base("stonebricks", "fourstepstairscorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("fourstepstairscornerx+");
		}
	}

	[AttributeType]
	public class stonebricksfourstepstairscornerZMinus : DecorativeTypeZMinus
	{
		public stonebricksfourstepstairscornerZMinus() : base("stonebricks", "fourstepstairscorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("fourstepstairscornerz-");
		}
	}

	[AttributeType]
	public class stonebricksfourstepstairscornerZPlus : DecorativeTypeZPlus
	{
		public stonebricksfourstepstairscornerZPlus() : base("stonebricks", "fourstepstairscorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("fourstepstairscornerz+");
		}
	}
}