using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.ShapedBlocks.Decor
{
	[AttributePlayerRecipe]
	public class plasterblockslopecornerRecipe : BaseRecipe
	{
		public plasterblockslopecornerRecipe() : base("plasterblockslopecornerrecipe")
		{
			Requirements.Add(new InventoryItem("stonebricks", 1));
			Result.Add(new InventoryItem("plasterblockslopecorner", 1));
		}
	}
	
	[AttributeType]
	public class plasterblockslopecorner : DecorativeType
	{
		public plasterblockslopecorner() : base("plasterblock", "slopecorner",
			Utilities.MultiCombine(ShapedBlocks.ModIconDirectory, "plasterblockslopecorner.png"))
		{
			this.SideAll = "plasterblock";
		}
	}

	[AttributeType]
	public class plasterblockslopecornerXMinus : DecorativeTypeXMinus
	{
		public plasterblockslopecornerXMinus() : base("plasterblock", "slopecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("slopecornerx-");
		}
	}

	[AttributeType]
	public class plasterblockslopecornerXPlus : DecorativeTypeXPlus
	{
		public plasterblockslopecornerXPlus() : base("plasterblock", "slopecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("slopecornerx+");
		}
	}

	[AttributeType]
	public class plasterblockslopecornerZMinus : DecorativeTypeZMinus
	{
		public plasterblockslopecornerZMinus() : base("plasterblock", "slopecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("slopecornerz-");
		}
	}

	[AttributeType]
	public class plasterblockslopecornerZPlus : DecorativeTypeZPlus
	{
		public plasterblockslopecornerZPlus() : base("plasterblock", "slopecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("slopecornerz+");
		}
	}
}