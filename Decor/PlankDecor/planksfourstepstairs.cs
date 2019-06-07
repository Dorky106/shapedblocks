using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.ShapedBlocks.Decor
{
	[AttributePlayerRecipe]
	public class planksfourstepstairsRecipe : BaseRecipe
	{
		public planksfourstepstairsRecipe() : base("planksfourstepstairsrecipe")
		{
			Requirements.Add(new InventoryItem("stonebricks", 1));
			Result.Add(new InventoryItem("planksfourstepstairs", 1));
		}
	}
	
	[AttributeType]
	public class planksfourstepstairs : DecorativeType
	{
		public planksfourstepstairs() : base("planks", "fourstepstairs",
			Utilities.MultiCombine(ShapedBlocks.ModIconDirectory, "planksfourstepstairs.png"))
		{
			this.SideAll = "planks";
		}
	}

	[AttributeType]
	public class planksfourstepstairsXMinus : DecorativeTypeXMinus
	{
		public planksfourstepstairsXMinus() : base("planks", "fourstepstairs", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("fourstepstairsx-");
		}
	}

	[AttributeType]
	public class planksfourstepstairsXPlus : DecorativeTypeXPlus
	{
		public planksfourstepstairsXPlus() : base("planks", "fourstepstairs", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("fourstepstairsx+");
		}
	}

	[AttributeType]
	public class planksfourstepstairsZMinus : DecorativeTypeZMinus
	{
		public planksfourstepstairsZMinus() : base("planks", "fourstepstairs", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("fourstepstairsz-");
		}
	}

	[AttributeType]
	public class planksfourstepstairsZPlus : DecorativeTypeZPlus
	{
		public planksfourstepstairsZPlus() : base("planks", "fourstepstairs", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("fourstepstairsz+");
		}
	}
}