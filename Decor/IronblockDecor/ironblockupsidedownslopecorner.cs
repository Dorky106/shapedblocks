using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.ShapedBlocks.Decor
{
	[AttributePlayerRecipe]
	public class ironblockupsidedownslopecornerRecipe : BaseRecipe
	{
		public ironblockupsidedownslopecornerRecipe() : base("ironblockupsidedownslopecornerrecipe")
		{
			Requirements.Add(new InventoryItem("stonebricks", 1));
			Result.Add(new InventoryItem("ironblockupsidedownslopecorner", 1));
		}
	}
	
	[AttributeType]
	public class ironblockupsidedownslopecorner : DecorativeType
	{
		public ironblockupsidedownslopecorner() : base("ironblock", "upsidedownslopecorner",
			Utilities.MultiCombine(ShapedBlocks.ModIconDirectory, "ironblockupsidedownslopecorner.png"))
		{
			this.SideAll = "ironblock";
		}
	}

	[AttributeType]
	public class ironblockupsidedownslopecornerXMinus : DecorativeTypeXMinus
	{
		public ironblockupsidedownslopecornerXMinus() : base("ironblock", "upsidedownslopecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedownslopecornerx-");
		}
	}

	[AttributeType]
	public class ironblockupsidedownslopecornerXPlus : DecorativeTypeXPlus
	{
		public ironblockupsidedownslopecornerXPlus() : base("ironblock", "upsidedownslopecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedownslopecornerx+");
		}
	}

	[AttributeType]
	public class ironblockupsidedownslopecornerZMinus : DecorativeTypeZMinus
	{
		public ironblockupsidedownslopecornerZMinus() : base("ironblock", "upsidedownslopecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedownslopecornerz-");
		}
	}

	[AttributeType]
	public class ironblockupsidedownslopecornerZPlus : DecorativeTypeZPlus
	{
		public ironblockupsidedownslopecornerZPlus() : base("ironblock", "upsidedownslopecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedownslopecornerz+");
		}
	}
}