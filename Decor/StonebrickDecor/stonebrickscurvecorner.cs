using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.ShapedBlocks.Decor
{
	[AttributePlayerRecipe]
	public class stonebrickscurvecornerRecipe : BaseRecipe
	{
		public stonebrickscurvecornerRecipe() : base("stonebrickscurvecornerrecipe")
		{
			Requirements.Add(new InventoryItem("stonebricks", 1));
			Result.Add(new InventoryItem("stonebrickscurvecorner", 1));
		}
	}
	
	[AttributeType]
	public class stonebrickscurvecorner : DecorativeType
	{
		public stonebrickscurvecorner() : base("stonebricks", "curvecorner",
			Utilities.MultiCombine(ShapedBlocks.ModIconDirectory, "stonebrickscurvecorner.png"))
		{
			this.SideAll = "stonebricks";
		}
	}

	[AttributeType]
	public class stonebrickscurvecornerXMinus : DecorativeTypeXMinus
	{
		public stonebrickscurvecornerXMinus() : base("stonebricks", "curvecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("curvecornerx-");
		}
	}

	[AttributeType]
	public class stonebrickscurvecornerXPlus : DecorativeTypeXPlus
	{
		public stonebrickscurvecornerXPlus() : base("stonebricks", "curvecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("curvecornerx+");
		}
	}

	[AttributeType]
	public class stonebrickscurvecornerZMinus : DecorativeTypeZMinus
	{
		public stonebrickscurvecornerZMinus() : base("stonebricks", "curvecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("curvecornerz-");
		}
	}

	[AttributeType]
	public class stonebrickscurvecornerZPlus : DecorativeTypeZPlus
	{
		public stonebrickscurvecornerZPlus() : base("stonebricks", "curvecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("curvecornerz+");
		}
	}
}