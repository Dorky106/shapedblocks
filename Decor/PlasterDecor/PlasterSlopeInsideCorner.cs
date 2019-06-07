using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.ShapedBlocks.Decor
{
	[AttributePlayerRecipe]
	public class plasterblockslopeinsidecornerRecipe : BaseRecipe
	{
		public plasterblockslopeinsidecornerRecipe() : base("plasterblockslopeinsidecornerrecipe")
		{
			Requirements.Add(new InventoryItem("stonebricks", 1));
			Result.Add(new InventoryItem("plasterblockslopeinsidecorner", 1));
		}
	}
	
	[AttributeType]
	public class plasterblockslopeinsidecorner : DecorativeType
	{
		public plasterblockslopeinsidecorner() : base("plasterblock", "slopeinsidecorner",
			Utilities.MultiCombine(ShapedBlocks.ModIconDirectory, "plasterblockslopeinsidecorner.png"))
		{
			this.SideAll = "plasterblock";
		}
	}

	[AttributeType]
	public class plasterblockslopeinsidecornerXMinus : DecorativeTypeXMinus
	{
		public plasterblockslopeinsidecornerXMinus() : base("plasterblock", "slopeinsidecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("slopeinsidecornerx-");
		}
	}

	[AttributeType]
	public class plasterblockslopeinsidecornerXPlus : DecorativeTypeXPlus
	{
		public plasterblockslopeinsidecornerXPlus() : base("plasterblock", "slopeinsidecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("slopeinsidecornerx+");
		}
	}

	[AttributeType]
	public class plasterblockslopeinsidecornerZMinus : DecorativeTypeZMinus
	{
		public plasterblockslopeinsidecornerZMinus() : base("plasterblock", "slopeinsidecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("slopeinsidecornerz-");
		}
	}

	[AttributeType]
	public class plasterblockslopeinsidecornerZPlus : DecorativeTypeZPlus
	{
		public plasterblockslopeinsidecornerZPlus() : base("plasterblock", "slopeinsidecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("slopeinsidecornerz+");
		}
	}
}