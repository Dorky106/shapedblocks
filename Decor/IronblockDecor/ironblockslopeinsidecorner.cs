using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.ShapedBlocks.Decor
{
	[AttributePlayerRecipe]
	public class ironblockslopeinsidecornerRecipe : BaseRecipe
	{
		public ironblockslopeinsidecornerRecipe() : base("ironblockslopeinsidecornerrecipe")
		{
			Requirements.Add(new InventoryItem("stonebricks", 1));
			Result.Add(new InventoryItem("ironblockslopeinsidecorner", 1));
		}
	}
	
	[AttributeType]
	public class ironblockslopeinsidecorner : DecorativeType
	{
		public ironblockslopeinsidecorner() : base("ironblock", "slopeinsidecorner",
			Utilities.MultiCombine(ShapedBlocks.ModIconDirectory, "ironblockslopeinsidecorner.png"))
		{
			this.SideAll = "ironblock";
		}
	}

	[AttributeType]
	public class ironblockslopeinsidecornerXMinus : DecorativeTypeXMinus
	{
		public ironblockslopeinsidecornerXMinus() : base("ironblock", "slopeinsidecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("slopeinsidecornerx-");
		}
	}

	[AttributeType]
	public class ironblockslopeinsidecornerXPlus : DecorativeTypeXPlus
	{
		public ironblockslopeinsidecornerXPlus() : base("ironblock", "slopeinsidecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("slopeinsidecornerx+");
		}
	}

	[AttributeType]
	public class ironblockslopeinsidecornerZMinus : DecorativeTypeZMinus
	{
		public ironblockslopeinsidecornerZMinus() : base("ironblock", "slopeinsidecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("slopeinsidecornerz-");
		}
	}

	[AttributeType]
	public class ironblockslopeinsidecornerZPlus : DecorativeTypeZPlus
	{
		public ironblockslopeinsidecornerZPlus() : base("ironblock", "slopeinsidecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("slopeinsidecornerz+");
		}
	}
}