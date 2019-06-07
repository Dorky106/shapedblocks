using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.ShapedBlocks.Decor
{
	[AttributePlayerRecipe]
	public class brickscurvecornerRecipe : BaseRecipe
	{
		public brickscurvecornerRecipe() : base("brickscurvecornerrecipe")
		{
			Requirements.Add(new InventoryItem("stonebricks", 1));
			Result.Add(new InventoryItem("brickscurvecorner", 1));
		}
	}
	
	[AttributeType]
	public class brickscurvecorner : DecorativeType
	{
		public brickscurvecorner() : base("bricks", "curvecorner",
			Utilities.MultiCombine(ShapedBlocks.ModIconDirectory, "brickscurvecorner.png"))
		{
			this.SideAll = "bricks";
		}
	}

	[AttributeType]
	public class brickscurvecornerXMinus : DecorativeTypeXMinus
	{
		public brickscurvecornerXMinus() : base("bricks", "curvecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("curvecornerx-");
		}
	}

	[AttributeType]
	public class brickscurvecornerXPlus : DecorativeTypeXPlus
	{
		public brickscurvecornerXPlus() : base("bricks", "curvecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("curvecornerx+");
		}
	}

	[AttributeType]
	public class brickscurvecornerZMinus : DecorativeTypeZMinus
	{
		public brickscurvecornerZMinus() : base("bricks", "curvecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("curvecornerz-");
		}
	}

	[AttributeType]
	public class brickscurvecornerZPlus : DecorativeTypeZPlus
	{
		public brickscurvecornerZPlus() : base("bricks", "curvecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("curvecornerz+");
		}
	}
}