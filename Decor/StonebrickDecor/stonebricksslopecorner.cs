using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.ShapedBlocks.Decor
{
	[AttributePlayerRecipe]
	public class stonebricksslopecornerRecipe : BaseRecipe
	{
		public stonebricksslopecornerRecipe() : base("stonebricksslopecornerrecipe")
		{
			Requirements.Add(new InventoryItem("stonebricks", 1));
			Result.Add(new InventoryItem("stonebricksslopecorner", 1));
		}
	}
	
	[AttributeType]
	public class stonebricksslopecorner : DecorativeType
	{
		public stonebricksslopecorner() : base("stonebricks", "slopecorner",
			Utilities.MultiCombine(ShapedBlocks.ModIconDirectory, "stonebricksslopecorner.png"))
		{
			this.SideAll = "stonebricks";
		}
	}

	[AttributeType]
	public class stonebricksslopecornerXMinus : DecorativeTypeXMinus
	{
		public stonebricksslopecornerXMinus() : base("stonebricks", "slopecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("slopecornerx-");
		}
	}

	[AttributeType]
	public class stonebricksslopecornerXPlus : DecorativeTypeXPlus
	{
		public stonebricksslopecornerXPlus() : base("stonebricks", "slopecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("slopecornerx+");
		}
	}

	[AttributeType]
	public class stonebricksslopecornerZMinus : DecorativeTypeZMinus
	{
		public stonebricksslopecornerZMinus() : base("stonebricks", "slopecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("slopecornerz-");
		}
	}

	[AttributeType]
	public class stonebricksslopecornerZPlus : DecorativeTypeZPlus
	{
		public stonebricksslopecornerZPlus() : base("stonebricks", "slopecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("slopecornerz+");
		}
	}
}