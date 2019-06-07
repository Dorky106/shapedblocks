using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.ShapedBlocks.Decor
{
	[AttributePlayerRecipe]
	public class bricksupsidedownslopecornerRecipe : BaseRecipe
	{
		public bricksupsidedownslopecornerRecipe() : base("bricksupsidedownslopecornerrecipe")
		{
			Requirements.Add(new InventoryItem("stonebricks", 1));
			Result.Add(new InventoryItem("bricksupsidedownslopecorner", 1));
		}
	}
	
	[AttributeType]
	public class bricksupsidedownslopecorner : DecorativeType
	{
		public bricksupsidedownslopecorner() : base("bricks", "upsidedownslopecorner",
			Utilities.MultiCombine(ShapedBlocks.ModIconDirectory, "bricksupsidedownslopecorner.png"))
		{
			this.SideAll = "bricks";
		}
	}

	[AttributeType]
	public class bricksupsidedownslopecornerXMinus : DecorativeTypeXMinus
	{
		public bricksupsidedownslopecornerXMinus() : base("bricks", "upsidedownslopecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedownslopecornerx-");
		}
	}

	[AttributeType]
	public class bricksupsidedownslopecornerXPlus : DecorativeTypeXPlus
	{
		public bricksupsidedownslopecornerXPlus() : base("bricks", "upsidedownslopecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedownslopecornerx+");
		}
	}

	[AttributeType]
	public class bricksupsidedownslopecornerZMinus : DecorativeTypeZMinus
	{
		public bricksupsidedownslopecornerZMinus() : base("bricks", "upsidedownslopecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedownslopecornerz-");
		}
	}

	[AttributeType]
	public class bricksupsidedownslopecornerZPlus : DecorativeTypeZPlus
	{
		public bricksupsidedownslopecornerZPlus() : base("bricks", "upsidedownslopecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedownslopecornerz+");
		}
	}
}