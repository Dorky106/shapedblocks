using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.ShapedBlocks.Decor
{
	[AttributePlayerRecipe]
	public class planksupsidedownslopecornerRecipe : BaseRecipe
	{
		public planksupsidedownslopecornerRecipe() : base("planksupsidedownslopecornerrecipe")
		{
			Requirements.Add(new InventoryItem("stonebricks", 1));
			Result.Add(new InventoryItem("planksupsidedownslopecorner", 1));
		}
	}
	
	[AttributeType]
	public class planksupsidedownslopecorner : DecorativeType
	{
		public planksupsidedownslopecorner() : base("planks", "upsidedownslopecorner",
			Utilities.MultiCombine(ShapedBlocks.ModIconDirectory, "planksupsidedownslopecorner.png"))
		{
			this.SideAll = "planks";
		}
	}

	[AttributeType]
	public class planksupsidedownslopecornerXMinus : DecorativeTypeXMinus
	{
		public planksupsidedownslopecornerXMinus() : base("planks", "upsidedownslopecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedownslopecornerx-");
		}
	}

	[AttributeType]
	public class planksupsidedownslopecornerXPlus : DecorativeTypeXPlus
	{
		public planksupsidedownslopecornerXPlus() : base("planks", "upsidedownslopecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedownslopecornerx+");
		}
	}

	[AttributeType]
	public class planksupsidedownslopecornerZMinus : DecorativeTypeZMinus
	{
		public planksupsidedownslopecornerZMinus() : base("planks", "upsidedownslopecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedownslopecornerz-");
		}
	}

	[AttributeType]
	public class planksupsidedownslopecornerZPlus : DecorativeTypeZPlus
	{
		public planksupsidedownslopecornerZPlus() : base("planks", "upsidedownslopecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedownslopecornerz+");
		}
	}
}