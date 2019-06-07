using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.ShapedBlocks.Decor
{
	[AttributePlayerRecipe]
	public class plankscurvecornerRecipe : BaseRecipe
	{
		public plankscurvecornerRecipe() : base("plankscurvecornerrecipe")
		{
			Requirements.Add(new InventoryItem("stonebricks", 1));
			Result.Add(new InventoryItem("plankscurvecorner", 1));
		}
	}
	
	[AttributeType]
	public class plankscurvecorner : DecorativeType
	{
		public plankscurvecorner() : base("planks", "curvecorner",
			Utilities.MultiCombine(ShapedBlocks.ModIconDirectory, "plankscurvecorner.png"))
		{
			this.SideAll = "planks";
		}
	}

	[AttributeType]
	public class plankscurvecornerXMinus : DecorativeTypeXMinus
	{
		public plankscurvecornerXMinus() : base("planks", "curvecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("curvecornerx-");
		}
	}

	[AttributeType]
	public class plankscurvecornerXPlus : DecorativeTypeXPlus
	{
		public plankscurvecornerXPlus() : base("planks", "curvecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("curvecornerx+");
		}
	}

	[AttributeType]
	public class plankscurvecornerZMinus : DecorativeTypeZMinus
	{
		public plankscurvecornerZMinus() : base("planks", "curvecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("curvecornerz-");
		}
	}

	[AttributeType]
	public class plankscurvecornerZPlus : DecorativeTypeZPlus
	{
		public plankscurvecornerZPlus() : base("planks", "curvecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("curvecornerz+");
		}
	}
}