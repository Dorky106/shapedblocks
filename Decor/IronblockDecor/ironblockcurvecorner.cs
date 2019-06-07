using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.ShapedBlocks.Decor
{
	[AttributePlayerRecipe]
	public class ironblockcurvecornerRecipe : BaseRecipe
	{
		public ironblockcurvecornerRecipe() : base("ironblockcurvecornerrecipe")
		{
			Requirements.Add(new InventoryItem("stonebricks", 1));
			Result.Add(new InventoryItem("ironblockcurvecorner", 1));
		}
	}
	
	[AttributeType]
	public class ironblockcurvecorner : DecorativeType
	{
		public ironblockcurvecorner() : base("ironblock", "curvecorner",
			Utilities.MultiCombine(ShapedBlocks.ModIconDirectory, "ironblockcurvecorner.png"))
		{
			this.SideAll = "ironblock";
		}
	}

	[AttributeType]
	public class ironblockcurvecornerXMinus : DecorativeTypeXMinus
	{
		public ironblockcurvecornerXMinus() : base("ironblock", "curvecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("curvecornerx-");
		}
	}

	[AttributeType]
	public class ironblockcurvecornerXPlus : DecorativeTypeXPlus
	{
		public ironblockcurvecornerXPlus() : base("ironblock", "curvecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("curvecornerx+");
		}
	}

	[AttributeType]
	public class ironblockcurvecornerZMinus : DecorativeTypeZMinus
	{
		public ironblockcurvecornerZMinus() : base("ironblock", "curvecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("curvecornerz-");
		}
	}

	[AttributeType]
	public class ironblockcurvecornerZPlus : DecorativeTypeZPlus
	{
		public ironblockcurvecornerZPlus() : base("ironblock", "curvecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("curvecornerz+");
		}
	}
}