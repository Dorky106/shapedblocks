using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.ShapedBlocks.Decor
{
	[AttributePlayerRecipe]
	public class planksslopeinsidecornerRecipe : BaseRecipe
	{
		public planksslopeinsidecornerRecipe() : base("planksslopeinsidecornerrecipe")
		{
			Requirements.Add(new InventoryItem("stonebricks", 1));
			Result.Add(new InventoryItem("planksslopeinsidecorner", 1));
		}
	}
	
	[AttributeType]
	public class planksslopeinsidecorner : DecorativeType
	{
		public planksslopeinsidecorner() : base("planks", "slopeinsidecorner",
			Utilities.MultiCombine(ShapedBlocks.ModIconDirectory, "planksslopeinsidecorner.png"))
		{
			this.SideAll = "planks";
		}
	}

	[AttributeType]
	public class planksslopeinsidecornerXMinus : DecorativeTypeXMinus
	{
		public planksslopeinsidecornerXMinus() : base("planks", "slopeinsidecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("slopeinsidecornerx-");
		}
	}

	[AttributeType]
	public class planksslopeinsidecornerXPlus : DecorativeTypeXPlus
	{
		public planksslopeinsidecornerXPlus() : base("planks", "slopeinsidecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("slopeinsidecornerx+");
		}
	}

	[AttributeType]
	public class planksslopeinsidecornerZMinus : DecorativeTypeZMinus
	{
		public planksslopeinsidecornerZMinus() : base("planks", "slopeinsidecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("slopeinsidecornerz-");
		}
	}

	[AttributeType]
	public class planksslopeinsidecornerZPlus : DecorativeTypeZPlus
	{
		public planksslopeinsidecornerZPlus() : base("planks", "slopeinsidecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("slopeinsidecornerz+");
		}
	}
}