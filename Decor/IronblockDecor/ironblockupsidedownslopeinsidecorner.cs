using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.ShapedBlocks.Decor
{
	[AttributePlayerRecipe]
	public class ironblockupsidedownslopeinsidecornerRecipe : BaseRecipe
	{
		public ironblockupsidedownslopeinsidecornerRecipe() : base("ironblockupsidedownslopeinsidecornerrecipe")
		{
			Requirements.Add(new InventoryItem("stonebricks", 1));
			Result.Add(new InventoryItem("ironblockupsidedownslopeinsidecorner", 1));
		}
	}
	
	[AttributeType]
	public class ironblockupsidedownslopeinsidecorner : DecorativeType
	{
		public ironblockupsidedownslopeinsidecorner() : base("ironblock", "upsidedownslopeinsidecorner",
			Utilities.MultiCombine(ShapedBlocks.ModIconDirectory, "ironblockupsidedownslopeinsidecorner.png"))
		{
			this.SideAll = "ironblock";
		}
	}

	[AttributeType]
	public class ironblockupsidedownslopeinsidecornerXMinus : DecorativeTypeXMinus
	{
		public ironblockupsidedownslopeinsidecornerXMinus() : base("ironblock", "upsidedownslopeinsidecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedownslopeinsidecornerx-");
		}
	}

	[AttributeType]
	public class ironblockupsidedownslopeinsidecornerXPlus : DecorativeTypeXPlus
	{
		public ironblockupsidedownslopeinsidecornerXPlus() : base("ironblock", "upsidedownslopeinsidecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedownslopeinsidecornerx+");
		}
	}

	[AttributeType]
	public class ironblockupsidedownslopeinsidecornerZMinus : DecorativeTypeZMinus
	{
		public ironblockupsidedownslopeinsidecornerZMinus() : base("ironblock", "upsidedownslopeinsidecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedownslopeinsidecornerz-");
		}
	}

	[AttributeType]
	public class ironblockupsidedownslopeinsidecornerZPlus : DecorativeTypeZPlus
	{
		public ironblockupsidedownslopeinsidecornerZPlus() : base("ironblock", "upsidedownslopeinsidecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedownslopeinsidecornerz+");
		}
	}
}