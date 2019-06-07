using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.ShapedBlocks.Decor
{
	[AttributePlayerRecipe]
	public class planksupsidedowncurvecornerRecipe : BaseRecipe
	{
		public planksupsidedowncurvecornerRecipe() : base("planksupsidedowncurvecornerrecipe")
		{
			Requirements.Add(new InventoryItem("stonebricks", 1));
			Result.Add(new InventoryItem("planksupsidedowncurvecorner", 1));
		}
	}
	
	[AttributeType]
	public class planksupsidedowncurvecorner : DecorativeType
	{
		public planksupsidedowncurvecorner() : base("planks", "upsidedowncurvecorner",
			Utilities.MultiCombine(ShapedBlocks.ModIconDirectory, "planksupsidedowncurvecorner.png"))
		{
			this.SideAll = "planks";
		}
	}

	[AttributeType]
	public class planksupsidedowncurvecornerXMinus : DecorativeTypeXMinus
	{
		public planksupsidedowncurvecornerXMinus() : base("planks", "upsidedowncurvecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedowncurvecornerx-");
		}
	}

	[AttributeType]
	public class planksupsidedowncurvecornerXPlus : DecorativeTypeXPlus
	{
		public planksupsidedowncurvecornerXPlus() : base("planks", "upsidedowncurvecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedowncurvecornerx+");
		}
	}

	[AttributeType]
	public class planksupsidedowncurvecornerZMinus : DecorativeTypeZMinus
	{
		public planksupsidedowncurvecornerZMinus() : base("planks", "upsidedowncurvecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedowncurvecornerz-");
		}
	}

	[AttributeType]
	public class planksupsidedowncurvecornerZPlus : DecorativeTypeZPlus
	{
		public planksupsidedowncurvecornerZPlus() : base("planks", "upsidedowncurvecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedowncurvecornerz+");
		}
	}
}