using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.ShapedBlocks.Decor
{
	[AttributePlayerRecipe]
	public class bricksfourstepstairsinsidecornerRecipe : BaseRecipe
	{
		public bricksfourstepstairsinsidecornerRecipe() : base("bricksfourstepstairsinsidecornerrecipe")
		{
			Requirements.Add(new InventoryItem("stonebricks", 1));
			Result.Add(new InventoryItem("bricksfourstepstairsinsidecorner", 1));
		}
	}
	
	[AttributeType]
	public class bricksfourstepstairsinsidecorner : DecorativeType
	{
		public bricksfourstepstairsinsidecorner() : base("bricks", "fourstepstairsinsidecorner",
			Utilities.MultiCombine(ShapedBlocks.ModIconDirectory, "bricksfourstepstairsinsidecorner.png"))
		{
			this.SideAll = "bricks";
		}
	}

	[AttributeType]
	public class bricksfourstepstairsinsidecornerXMinus : DecorativeTypeXMinus
	{
		public bricksfourstepstairsinsidecornerXMinus() : base("bricks", "fourstepstairsinsidecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("fourstepstairsinsidecornerx-");
		}
	}

	[AttributeType]
	public class bricksfourstepstairsinsidecornerXPlus : DecorativeTypeXPlus
	{
		public bricksfourstepstairsinsidecornerXPlus() : base("bricks", "fourstepstairsinsidecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("fourstepstairsinsidecornerx+");
		}
	}

	[AttributeType]
	public class bricksfourstepstairsinsidecornerZMinus : DecorativeTypeZMinus
	{
		public bricksfourstepstairsinsidecornerZMinus() : base("bricks", "fourstepstairsinsidecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("fourstepstairsinsidecornerz-");
		}
	}

	[AttributeType]
	public class bricksfourstepstairsinsidecornerZPlus : DecorativeTypeZPlus
	{
		public bricksfourstepstairsinsidecornerZPlus() : base("bricks", "fourstepstairsinsidecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("fourstepstairsinsidecornerz+");
		}
	}
}