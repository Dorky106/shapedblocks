using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.ShapedBlocks.Decor
{
	[AttributePlayerRecipe]
	public class plasterblockupsidedownslopecornerRecipe : BaseRecipe
	{
		public plasterblockupsidedownslopecornerRecipe() : base("plasterblockupsidedownslopecornerrecipe")
		{
			Requirements.Add(new InventoryItem("stonebricks", 1));
			Result.Add(new InventoryItem("plasterblockupsidedownslopecorner", 1));
		}
	}
	
	[AttributeType]
	public class plasterblockupsidedownslopecorner : DecorativeType
	{
		public plasterblockupsidedownslopecorner() : base("plasterblock", "upsidedownslopecorner",
			Utilities.MultiCombine(ShapedBlocks.ModIconDirectory, "plasterblockupsidedownslopecorner.png"))
		{
			this.SideAll = "plasterblock";
		}
	}

	[AttributeType]
	public class plasterblockupsidedownslopecornerXMinus : DecorativeTypeXMinus
	{
		public plasterblockupsidedownslopecornerXMinus() : base("plasterblock", "upsidedownslopecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedownslopecornerx-");
		}
	}

	[AttributeType]
	public class plasterblockupsidedownslopecornerXPlus : DecorativeTypeXPlus
	{
		public plasterblockupsidedownslopecornerXPlus() : base("plasterblock", "upsidedownslopecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedownslopecornerx+");
		}
	}

	[AttributeType]
	public class plasterblockupsidedownslopecornerZMinus : DecorativeTypeZMinus
	{
		public plasterblockupsidedownslopecornerZMinus() : base("plasterblock", "upsidedownslopecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedownslopecornerz-");
		}
	}

	[AttributeType]
	public class plasterblockupsidedownslopecornerZPlus : DecorativeTypeZPlus
	{
		public plasterblockupsidedownslopecornerZPlus() : base("plasterblock", "upsidedownslopecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedownslopecornerz+");
		}
	}
}