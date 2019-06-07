using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.ShapedBlocks.Decor
{
	[AttributePlayerRecipe]
	public class ironblockslopecornerRecipe : BaseRecipe
	{
		public ironblockslopecornerRecipe() : base("ironblockslopecornerrecipe")
		{
			Requirements.Add(new InventoryItem("stonebricks", 1));
			Result.Add(new InventoryItem("ironblockslopecorner", 1));
		}
	}
	
	[AttributeType]
	public class ironblockslopecorner : DecorativeType
	{
		public ironblockslopecorner() : base("ironblock", "slopecorner",
			Utilities.MultiCombine(ShapedBlocks.ModIconDirectory, "ironblockslopecorner.png"))
		{
			this.SideAll = "ironblock";
		}
	}

	[AttributeType]
	public class ironblockslopecornerXMinus : DecorativeTypeXMinus
	{
		public ironblockslopecornerXMinus() : base("ironblock", "slopecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("slopecornerx-");
		}
	}

	[AttributeType]
	public class ironblockslopecornerXPlus : DecorativeTypeXPlus
	{
		public ironblockslopecornerXPlus() : base("ironblock", "slopecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("slopecornerx+");
		}
	}

	[AttributeType]
	public class ironblockslopecornerZMinus : DecorativeTypeZMinus
	{
		public ironblockslopecornerZMinus() : base("ironblock", "slopecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("slopecornerz-");
		}
	}

	[AttributeType]
	public class ironblockslopecornerZPlus : DecorativeTypeZPlus
	{
		public ironblockslopecornerZPlus() : base("ironblock", "slopecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("slopecornerz+");
		}
	}
}