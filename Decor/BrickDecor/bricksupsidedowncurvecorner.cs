using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.ShapedBlocks.Decor
{
	[AttributePlayerRecipe]
	public class bricksupsidedowncurvecornerRecipe : BaseRecipe
	{
		public bricksupsidedowncurvecornerRecipe() : base("bricksupsidedowncurvecornerrecipe")
		{
			Requirements.Add(new InventoryItem("stonebricks", 1));
			Result.Add(new InventoryItem("bricksupsidedowncurvecorner", 1));
		}
	}
	
	[AttributeType]
	public class bricksupsidedowncurvecorner : DecorativeType
	{
		public bricksupsidedowncurvecorner() : base("bricks", "upsidedowncurvecorner",
			Utilities.MultiCombine(ShapedBlocks.ModIconDirectory, "bricksupsidedowncurvecorner.png"))
		{
			this.SideAll = "bricks";
		}
	}

	[AttributeType]
	public class bricksupsidedowncurvecornerXMinus : DecorativeTypeXMinus
	{
		public bricksupsidedowncurvecornerXMinus() : base("bricks", "upsidedowncurvecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedowncurvecornerx-");
		}
	}

	[AttributeType]
	public class bricksupsidedowncurvecornerXPlus : DecorativeTypeXPlus
	{
		public bricksupsidedowncurvecornerXPlus() : base("bricks", "upsidedowncurvecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedowncurvecornerx+");
		}
	}

	[AttributeType]
	public class bricksupsidedowncurvecornerZMinus : DecorativeTypeZMinus
	{
		public bricksupsidedowncurvecornerZMinus() : base("bricks", "upsidedowncurvecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedowncurvecornerz-");
		}
	}

	[AttributeType]
	public class bricksupsidedowncurvecornerZPlus : DecorativeTypeZPlus
	{
		public bricksupsidedowncurvecornerZPlus() : base("bricks", "upsidedowncurvecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedowncurvecornerz+");
		}
	}
}