using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.ShapedBlocks.Decor
{
	[AttributePlayerRecipe]
	public class stonebricksslopeinsidecornerRecipe : BaseRecipe
	{
		public stonebricksslopeinsidecornerRecipe() : base("stonebricksslopeinsidecornerrecipe")
		{
			Requirements.Add(new InventoryItem("stonebricks", 1));
			Result.Add(new InventoryItem("stonebricksslopeinsidecorner", 1));
		}
	}
	
	[AttributeType]
	public class stonebricksslopeinsidecorner : DecorativeType
	{
		public stonebricksslopeinsidecorner() : base("stonebricks", "slopeinsidecorner",
			Utilities.MultiCombine(ShapedBlocks.ModIconDirectory, "stonebricksslopeinsidecorner.png"))
		{
			this.SideAll = "stonebricks";
		}
	}

	[AttributeType]
	public class stonebricksslopeinsidecornerXMinus : DecorativeTypeXMinus
	{
		public stonebricksslopeinsidecornerXMinus() : base("stonebricks", "slopeinsidecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("slopeinsidecornerx-");
		}
	}

	[AttributeType]
	public class stonebricksslopeinsidecornerXPlus : DecorativeTypeXPlus
	{
		public stonebricksslopeinsidecornerXPlus() : base("stonebricks", "slopeinsidecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("slopeinsidecornerx+");
		}
	}

	[AttributeType]
	public class stonebricksslopeinsidecornerZMinus : DecorativeTypeZMinus
	{
		public stonebricksslopeinsidecornerZMinus() : base("stonebricks", "slopeinsidecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("slopeinsidecornerz-");
		}
	}

	[AttributeType]
	public class stonebricksslopeinsidecornerZPlus : DecorativeTypeZPlus
	{
		public stonebricksslopeinsidecornerZPlus() : base("stonebricks", "slopeinsidecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("slopeinsidecornerz+");
		}
	}
}