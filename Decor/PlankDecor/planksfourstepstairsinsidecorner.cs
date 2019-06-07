using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.ShapedBlocks.Decor
{
	[AttributePlayerRecipe]
	public class planksfourstepstairsinsidecornerRecipe : BaseRecipe
	{
		public planksfourstepstairsinsidecornerRecipe() : base("planksfourstepstairsinsidecornerrecipe")
		{
			Requirements.Add(new InventoryItem("stonebricks", 1));
			Result.Add(new InventoryItem("planksfourstepstairsinsidecorner", 1));
		}
	}
	
	[AttributeType]
	public class planksfourstepstairsinsidecorner : DecorativeType
	{
		public planksfourstepstairsinsidecorner() : base("planks", "fourstepstairsinsidecorner",
			Utilities.MultiCombine(ShapedBlocks.ModIconDirectory, "planksfourstepstairsinsidecorner.png"))
		{
			this.SideAll = "planks";
		}
	}

	[AttributeType]
	public class planksfourstepstairsinsidecornerXMinus : DecorativeTypeXMinus
	{
		public planksfourstepstairsinsidecornerXMinus() : base("planks", "fourstepstairsinsidecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("fourstepstairsinsidecornerx-");
		}
	}

	[AttributeType]
	public class planksfourstepstairsinsidecornerXPlus : DecorativeTypeXPlus
	{
		public planksfourstepstairsinsidecornerXPlus() : base("planks", "fourstepstairsinsidecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("fourstepstairsinsidecornerx+");
		}
	}

	[AttributeType]
	public class planksfourstepstairsinsidecornerZMinus : DecorativeTypeZMinus
	{
		public planksfourstepstairsinsidecornerZMinus() : base("planks", "fourstepstairsinsidecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("fourstepstairsinsidecornerz-");
		}
	}

	[AttributeType]
	public class planksfourstepstairsinsidecornerZPlus : DecorativeTypeZPlus
	{
		public planksfourstepstairsinsidecornerZPlus() : base("planks", "fourstepstairsinsidecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("fourstepstairsinsidecornerz+");
		}
	}
}