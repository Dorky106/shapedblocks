using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.ShapedBlocks.Decor
{
	[AttributePlayerRecipe]
	public class stonebrickstwostepstairscornerRecipe : BaseRecipe
	{
		public stonebrickstwostepstairscornerRecipe() : base("stonebrickstwostepstairscornerrecipe")
		{
			Requirements.Add(new InventoryItem("stonebricks", 1));
			Result.Add(new InventoryItem("stonebrickstwostepstairscorner", 1));
		}
	}
	
	[AttributeType]
	public class stonebrickstwostepstairscorner : DecorativeType
	{
		public stonebrickstwostepstairscorner() : base("stonebricks", "twostepstairscorner",
			Utilities.MultiCombine(ShapedBlocks.ModIconDirectory, "stonebrickstwostepstairscorner.png"))
		{
			this.SideAll = "stonebricks";
		}
	}

	[AttributeType]
	public class stonebrickstwostepstairscornerXMinus : DecorativeTypeXMinus
	{
		public stonebrickstwostepstairscornerXMinus() : base("stonebricks", "twostepstairscorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("twostepstairscornerx-");
		}
	}

	[AttributeType]
	public class stonebrickstwostepstairscornerXPlus : DecorativeTypeXPlus
	{
		public stonebrickstwostepstairscornerXPlus() : base("stonebricks", "twostepstairscorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("twostepstairscornerx+");
		}
	}

	[AttributeType]
	public class stonebrickstwostepstairscornerZMinus : DecorativeTypeZMinus
	{
		public stonebrickstwostepstairscornerZMinus() : base("stonebricks", "twostepstairscorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("twostepstairscornerz-");
		}
	}

	[AttributeType]
	public class stonebrickstwostepstairscornerZPlus : DecorativeTypeZPlus
	{
		public stonebrickstwostepstairscornerZPlus() : base("stonebricks", "twostepstairscorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("twostepstairscornerz+");
		}
	}
}