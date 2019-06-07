using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.ShapedBlocks.Decor
{
	[AttributePlayerRecipe]
	public class ironblockupsidedowncurvecornerRecipe : BaseRecipe
	{
		public ironblockupsidedowncurvecornerRecipe() : base("ironblockupsidedowncurvecornerrecipe")
		{
			Requirements.Add(new InventoryItem("stonebricks", 1));
			Result.Add(new InventoryItem("ironblockupsidedowncurvecorner", 1));
		}
	}
	
	[AttributeType]
	public class ironblockupsidedowncurvecorner : DecorativeType
	{
		public ironblockupsidedowncurvecorner() : base("ironblock", "upsidedowncurvecorner",
			Utilities.MultiCombine(ShapedBlocks.ModIconDirectory, "ironblockupsidedowncurvecorner.png"))
		{
			this.SideAll = "ironblock";
		}
	}

	[AttributeType]
	public class ironblockupsidedowncurvecornerXMinus : DecorativeTypeXMinus
	{
		public ironblockupsidedowncurvecornerXMinus() : base("ironblock", "upsidedowncurvecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedowncurvecornerx-");
		}
	}

	[AttributeType]
	public class ironblockupsidedowncurvecornerXPlus : DecorativeTypeXPlus
	{
		public ironblockupsidedowncurvecornerXPlus() : base("ironblock", "upsidedowncurvecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedowncurvecornerx+");
		}
	}

	[AttributeType]
	public class ironblockupsidedowncurvecornerZMinus : DecorativeTypeZMinus
	{
		public ironblockupsidedowncurvecornerZMinus() : base("ironblock", "upsidedowncurvecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedowncurvecornerz-");
		}
	}

	[AttributeType]
	public class ironblockupsidedowncurvecornerZPlus : DecorativeTypeZPlus
	{
		public ironblockupsidedowncurvecornerZPlus() : base("ironblock", "upsidedowncurvecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedowncurvecornerz+");
		}
	}
}