using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.ShapedBlocks.Decor
{
	[AttributePlayerRecipe]
	public class plasterblockcurvecornerRecipe : BaseRecipe
	{
		public plasterblockcurvecornerRecipe() : base("plasterblockcurvecornerrecipe")
		{
			Requirements.Add(new InventoryItem("stonebricks", 1));
			Result.Add(new InventoryItem("plasterblockcurvecorner", 1));
		}
	}
	
	[AttributeType]
	public class plasterblockcurvecorner : DecorativeType
	{
		public plasterblockcurvecorner() : base("plasterblock", "curvecorner",
			Utilities.MultiCombine(ShapedBlocks.ModIconDirectory, "plasterblockcurvecorner.png"))
		{
			this.SideAll = "plasterblock";
		}
	}

	[AttributeType]
	public class plasterblockcurvecornerXMinus : DecorativeTypeXMinus
	{
		public plasterblockcurvecornerXMinus() : base("plasterblock", "curvecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("curvecornerx-");
		}
	}

	[AttributeType]
	public class plasterblockcurvecornerXPlus : DecorativeTypeXPlus
	{
		public plasterblockcurvecornerXPlus() : base("plasterblock", "curvecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("curvecornerx+");
		}
	}

	[AttributeType]
	public class plasterblockcurvecornerZMinus : DecorativeTypeZMinus
	{
		public plasterblockcurvecornerZMinus() : base("plasterblock", "curvecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("curvecornerz-");
		}
	}

	[AttributeType]
	public class plasterblockcurvecornerZPlus : DecorativeTypeZPlus
	{
		public plasterblockcurvecornerZPlus() : base("plasterblock", "curvecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("curvecornerz+");
		}
	}
}