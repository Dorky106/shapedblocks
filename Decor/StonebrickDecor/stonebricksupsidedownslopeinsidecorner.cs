using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.ShapedBlocks.Decor
{
	[AttributePlayerRecipe]
	public class stonebricksupsidedownslopeinsidecornerRecipe : BaseRecipe
	{
		public stonebricksupsidedownslopeinsidecornerRecipe() : base("stonebricksupsidedownslopeinsidecornerrecipe")
		{
			Requirements.Add(new InventoryItem("stonebricks", 1));
			Result.Add(new InventoryItem("stonebricksupsidedownslopeinsidecorner", 1));
		}
	}
	
	[AttributeType]
	public class stonebricksupsidedownslopeinsidecorner : DecorativeType
	{
		public stonebricksupsidedownslopeinsidecorner() : base("stonebricks", "upsidedownslopeinsidecorner",
			Utilities.MultiCombine(ShapedBlocks.ModIconDirectory, "stonebricksupsidedownslopeinsidecorner.png"))
		{
			this.SideAll = "stonebricks";
		}
	}

	[AttributeType]
	public class stonebricksupsidedownslopeinsidecornerXMinus : DecorativeTypeXMinus
	{
		public stonebricksupsidedownslopeinsidecornerXMinus() : base("stonebricks", "upsidedownslopeinsidecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedownslopeinsidecornerx-");
		}
	}

	[AttributeType]
	public class stonebricksupsidedownslopeinsidecornerXPlus : DecorativeTypeXPlus
	{
		public stonebricksupsidedownslopeinsidecornerXPlus() : base("stonebricks", "upsidedownslopeinsidecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedownslopeinsidecornerx+");
		}
	}

	[AttributeType]
	public class stonebricksupsidedownslopeinsidecornerZMinus : DecorativeTypeZMinus
	{
		public stonebricksupsidedownslopeinsidecornerZMinus() : base("stonebricks", "upsidedownslopeinsidecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedownslopeinsidecornerz-");
		}
	}

	[AttributeType]
	public class stonebricksupsidedownslopeinsidecornerZPlus : DecorativeTypeZPlus
	{
		public stonebricksupsidedownslopeinsidecornerZPlus() : base("stonebricks", "upsidedownslopeinsidecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedownslopeinsidecornerz+");
		}
	}
}