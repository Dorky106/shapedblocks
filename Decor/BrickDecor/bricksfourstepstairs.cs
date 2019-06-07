using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.ShapedBlocks.Decor
{
	[AttributePlayerRecipe]
	public class bricksfourstepstairsRecipe : BaseRecipe
	{
		public bricksfourstepstairsRecipe() : base("bricksfourstepstairsrecipe")
		{
			Requirements.Add(new InventoryItem("stonebricks", 1));
			Result.Add(new InventoryItem("bricksfourstepstairs", 1));
		}
	}
	
	[AttributeType]
	public class bricksfourstepstairs : DecorativeType
	{
		public bricksfourstepstairs() : base("bricks", "fourstepstairs",
			Utilities.MultiCombine(ShapedBlocks.ModIconDirectory, "bricksfourstepstairs.png"))
		{
			this.SideAll = "bricks";
		}
	}

	[AttributeType]
	public class bricksfourstepstairsXMinus : DecorativeTypeXMinus
	{
		public bricksfourstepstairsXMinus() : base("bricks", "fourstepstairs", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("fourstepstairsx-");
		}
	}

	[AttributeType]
	public class bricksfourstepstairsXPlus : DecorativeTypeXPlus
	{
		public bricksfourstepstairsXPlus() : base("bricks", "fourstepstairs", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("fourstepstairsx+");
		}
	}

	[AttributeType]
	public class bricksfourstepstairsZMinus : DecorativeTypeZMinus
	{
		public bricksfourstepstairsZMinus() : base("bricks", "fourstepstairs", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("fourstepstairsz-");
		}
	}

	[AttributeType]
	public class bricksfourstepstairsZPlus : DecorativeTypeZPlus
	{
		public bricksfourstepstairsZPlus() : base("bricks", "fourstepstairs", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("fourstepstairsz+");
		}
	}
}