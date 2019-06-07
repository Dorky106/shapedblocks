using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.ShapedBlocks.Decor
{
	[AttributePlayerRecipe]
	public class plasterblockupsidedownslopeinsidecornerRecipe : BaseRecipe
	{
		public plasterblockupsidedownslopeinsidecornerRecipe() : base("plasterblockupsidedownslopeinsidecornerrecipe")
		{
			Requirements.Add(new InventoryItem("stonebricks", 1));
			Result.Add(new InventoryItem("plasterblockupsidedownslopeinsidecorner", 1));
		}
	}
	
	[AttributeType]
	public class plasterblockupsidedownslopeinsidecorner : DecorativeType
	{
		public plasterblockupsidedownslopeinsidecorner() : base("plasterblock", "upsidedownslopeinsidecorner",
			Utilities.MultiCombine(ShapedBlocks.ModIconDirectory, "plasterblockupsidedownslopeinsidecorner.png"))
		{
			this.SideAll = "plasterblock";
		}
	}

	[AttributeType]
	public class plasterblockupsidedownslopeinsidecornerXMinus : DecorativeTypeXMinus
	{
		public plasterblockupsidedownslopeinsidecornerXMinus() : base("plasterblock", "upsidedownslopeinsidecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedownslopeinsidecornerx-");
		}
	}

	[AttributeType]
	public class plasterblockupsidedownslopeinsidecornerXPlus : DecorativeTypeXPlus
	{
		public plasterblockupsidedownslopeinsidecornerXPlus() : base("plasterblock", "upsidedownslopeinsidecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedownslopeinsidecornerx+");
		}
	}

	[AttributeType]
	public class plasterblockupsidedownslopeinsidecornerZMinus : DecorativeTypeZMinus
	{
		public plasterblockupsidedownslopeinsidecornerZMinus() : base("plasterblock", "upsidedownslopeinsidecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedownslopeinsidecornerz-");
		}
	}

	[AttributeType]
	public class plasterblockupsidedownslopeinsidecornerZPlus : DecorativeTypeZPlus
	{
		public plasterblockupsidedownslopeinsidecornerZPlus() : base("plasterblock", "upsidedownslopeinsidecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedownslopeinsidecornerz+");
		}
	}
}