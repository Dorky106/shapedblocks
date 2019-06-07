using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.ShapedBlocks.Decor
{
	[AttributePlayerRecipe]
	public class planksslopecornerRecipe : BaseRecipe
	{
		public planksslopecornerRecipe() : base("planksslopecornerrecipe")
		{
			Requirements.Add(new InventoryItem("stonebricks", 1));
			Result.Add(new InventoryItem("planksslopecorner", 1));
		}
	}
	
	[AttributeType]
	public class planksslopecorner : DecorativeType
	{
		public planksslopecorner() : base("planks", "slopecorner",
			Utilities.MultiCombine(ShapedBlocks.ModIconDirectory, "planksslopecorner.png"))
		{
			this.SideAll = "planks";
		}
	}

	[AttributeType]
	public class planksslopecornerXMinus : DecorativeTypeXMinus
	{
		public planksslopecornerXMinus() : base("planks", "slopecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("slopecornerx-");
		}
	}

	[AttributeType]
	public class planksslopecornerXPlus : DecorativeTypeXPlus
	{
		public planksslopecornerXPlus() : base("planks", "slopecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("slopecornerx+");
		}
	}

	[AttributeType]
	public class planksslopecornerZMinus : DecorativeTypeZMinus
	{
		public planksslopecornerZMinus() : base("planks", "slopecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("slopecornerz-");
		}
	}

	[AttributeType]
	public class planksslopecornerZPlus : DecorativeTypeZPlus
	{
		public planksslopecornerZPlus() : base("planks", "slopecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("slopecornerz+");
		}
	}
}