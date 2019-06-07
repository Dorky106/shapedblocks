using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.ShapedBlocks.Decor
{
	[AttributePlayerRecipe]
	public class stonebricksupsidedownslopecornerRecipe : BaseRecipe
	{
		public stonebricksupsidedownslopecornerRecipe() : base("stonebricksupsidedownslopecornerrecipe")
		{
			Requirements.Add(new InventoryItem("stonebricks", 1));
			Result.Add(new InventoryItem("stonebricksupsidedownslopecorner", 1));
		}
	}
	
	[AttributeType]
	public class stonebricksupsidedownslopecorner : DecorativeType
	{
		public stonebricksupsidedownslopecorner() : base("stonebricks", "upsidedownslopecorner",
			Utilities.MultiCombine(ShapedBlocks.ModIconDirectory, "stonebricksupsidedownslopecorner.png"))
		{
			this.SideAll = "stonebricks";
		}
	}

	[AttributeType]
	public class stonebricksupsidedownslopecornerXMinus : DecorativeTypeXMinus
	{
		public stonebricksupsidedownslopecornerXMinus() : base("stonebricks", "upsidedownslopecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedownslopecornerx-");
		}
	}

	[AttributeType]
	public class stonebricksupsidedownslopecornerXPlus : DecorativeTypeXPlus
	{
		public stonebricksupsidedownslopecornerXPlus() : base("stonebricks", "upsidedownslopecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedownslopecornerx+");
		}
	}

	[AttributeType]
	public class stonebricksupsidedownslopecornerZMinus : DecorativeTypeZMinus
	{
		public stonebricksupsidedownslopecornerZMinus() : base("stonebricks", "upsidedownslopecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedownslopecornerz-");
		}
	}

	[AttributeType]
	public class stonebricksupsidedownslopecornerZPlus : DecorativeTypeZPlus
	{
		public stonebricksupsidedownslopecornerZPlus() : base("stonebricks", "upsidedownslopecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedownslopecornerz+");
		}
	}
}