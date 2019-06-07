using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.ShapedBlocks.Decor
{
	[AttributePlayerRecipe]
	public class plasterblockupsidedowncurvecornerRecipe : BaseRecipe
	{
		public plasterblockupsidedowncurvecornerRecipe() : base("plasterblockupsidedowncurvecornerrecipe")
		{
			Requirements.Add(new InventoryItem("stonebricks", 1));
			Result.Add(new InventoryItem("plasterblockupsidedowncurvecorner", 1));
		}
	}
	
	[AttributeType]
	public class plasterblockupsidedowncurvecorner : DecorativeType
	{
		public plasterblockupsidedowncurvecorner() : base("plasterblock", "upsidedowncurvecorner",
			Utilities.MultiCombine(ShapedBlocks.ModIconDirectory, "plasterblockupsidedowncurvecorner.png"))
		{
			this.SideAll = "plasterblock";
		}
	}

	[AttributeType]
	public class plasterblockupsidedowncurvecornerXMinus : DecorativeTypeXMinus
	{
		public plasterblockupsidedowncurvecornerXMinus() : base("plasterblock", "upsidedowncurvecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedowncurvecornerx-");
		}
	}

	[AttributeType]
	public class plasterblockupsidedowncurvecornerXPlus : DecorativeTypeXPlus
	{
		public plasterblockupsidedowncurvecornerXPlus() : base("plasterblock", "upsidedowncurvecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedowncurvecornerx+");
		}
	}

	[AttributeType]
	public class plasterblockupsidedowncurvecornerZMinus : DecorativeTypeZMinus
	{
		public plasterblockupsidedowncurvecornerZMinus() : base("plasterblock", "upsidedowncurvecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedowncurvecornerz-");
		}
	}

	[AttributeType]
	public class plasterblockupsidedowncurvecornerZPlus : DecorativeTypeZPlus
	{
		public plasterblockupsidedowncurvecornerZPlus() : base("plasterblock", "upsidedowncurvecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedowncurvecornerz+");
		}
	}
}