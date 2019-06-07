using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.ShapedBlocks.Decor
{
	[AttributePlayerRecipe]
	public class stonebricksupsidedowncurvecornerRecipe : BaseRecipe
	{
		public stonebricksupsidedowncurvecornerRecipe() : base("stonebricksupsidedowncurvecornerrecipe")
		{
			Requirements.Add(new InventoryItem("stonebricks", 1));
			Result.Add(new InventoryItem("stonebricksupsidedowncurvecorner", 1));
		}
	}
	
	[AttributeType]
	public class stonebricksupsidedowncurvecorner : DecorativeType
	{
		public stonebricksupsidedowncurvecorner() : base("stonebricks", "upsidedowncurvecorner",
			Utilities.MultiCombine(ShapedBlocks.ModIconDirectory, "stonebricksupsidedowncurvecorner.png"))
		{
			this.SideAll = "stonebricks";
		}
	}

	[AttributeType]
	public class stonebricksupsidedowncurvecornerXMinus : DecorativeTypeXMinus
	{
		public stonebricksupsidedowncurvecornerXMinus() : base("stonebricks", "upsidedowncurvecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedowncurvecornerx-");
		}
	}

	[AttributeType]
	public class stonebricksupsidedowncurvecornerXPlus : DecorativeTypeXPlus
	{
		public stonebricksupsidedowncurvecornerXPlus() : base("stonebricks", "upsidedowncurvecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedowncurvecornerx+");
		}
	}

	[AttributeType]
	public class stonebricksupsidedowncurvecornerZMinus : DecorativeTypeZMinus
	{
		public stonebricksupsidedowncurvecornerZMinus() : base("stonebricks", "upsidedowncurvecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedowncurvecornerz-");
		}
	}

	[AttributeType]
	public class stonebricksupsidedowncurvecornerZPlus : DecorativeTypeZPlus
	{
		public stonebricksupsidedowncurvecornerZPlus() : base("stonebricks", "upsidedowncurvecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("upsidedowncurvecornerz+");
		}
	}
}