using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.ShapedBlocks.Decor
{
	[AttributePlayerRecipe]
	public class planksupsidedownslopeinsidecornerRecipe : BaseRecipe
	{
		public planksupsidedownslopeinsidecornerRecipe() : base("planksupsidedownslopeinsidecornerrecipe")
		{
			Requirements.Add(new InventoryItem("stonebricks", 1));
			Result.Add(new InventoryItem("planksupsidedownslopeinsidecorner", 1));
		}
	}
	
	[AttributeType]
	public class planksupsidedownslopeinsidecorner : DecorativeType
	{
		public planksupsidedownslopeinsidecorner() : base("planks", "upsidedownslopeinsidecorner",
			Utilities.MultiCombine(ShapedBlocks.ModIconDirectory, "planksupsidedownslopeinsidecorner.png"))
		{
			this.SideAll = "planks";
		}
	}

	[AttributeType]
	public class planksupsidedownslopeinsidecornerXMinus : DecorativeTypeXMinus
	{
		public planksupsidedownslopeinsidecornerXMinus() : base("planks", "upsidedownslopeinsidecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedownslopeinsidecornerx-");
		}
	}

	[AttributeType]
	public class planksupsidedownslopeinsidecornerXPlus : DecorativeTypeXPlus
	{
		public planksupsidedownslopeinsidecornerXPlus() : base("planks", "upsidedownslopeinsidecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedownslopeinsidecornerx+");
		}
	}

	[AttributeType]
	public class planksupsidedownslopeinsidecornerZMinus : DecorativeTypeZMinus
	{
		public planksupsidedownslopeinsidecornerZMinus() : base("planks", "upsidedownslopeinsidecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedownslopeinsidecornerz-");
		}
	}

	[AttributeType]
	public class planksupsidedownslopeinsidecornerZPlus : DecorativeTypeZPlus
	{
		public planksupsidedownslopeinsidecornerZPlus() : base("planks", "upsidedownslopeinsidecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedownslopeinsidecornerz+");
		}
	}
}