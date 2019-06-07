using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.ShapedBlocks.Decor
{
	[AttributePlayerRecipe]
	public class stonebrickstwostepstairsRecipe : BaseRecipe
	{
		public stonebrickstwostepstairsRecipe() : base("stonebrickstwostepstairsrecipe")
		{
			Requirements.Add(new InventoryItem("stonebricks", 1));
			Result.Add(new InventoryItem("stonebrickstwostepstairs", 1));
		}
	}
	
	[AttributeType]
	public class stonebrickstwostepstairs : DecorativeType
	{
		public stonebrickstwostepstairs() : base("stonebricks", "twostepstairs",
			Utilities.MultiCombine(ShapedBlocks.ModIconDirectory, "stonebrickstwostepstairs.png"))
		{
			this.SideAll = "stonebricks";
		}
	}

	[AttributeType]
	public class stonebrickstwostepstairsXMinus : DecorativeTypeXMinus
	{
		public stonebrickstwostepstairsXMinus() : base("stonebricks", "twostepstairs", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("twostepstairsx-");
		}
	}

	[AttributeType]
	public class stonebrickstwostepstairsXPlus : DecorativeTypeXPlus
	{
		public stonebrickstwostepstairsXPlus() : base("stonebricks", "twostepstairs", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("twostepstairsx+");
		}
	}

	[AttributeType]
	public class stonebrickstwostepstairsZMinus : DecorativeTypeZMinus
	{
		public stonebrickstwostepstairsZMinus() : base("stonebricks", "twostepstairs", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("twostepstairsz-");
		}
	}

	[AttributeType]
	public class stonebrickstwostepstairsZPlus : DecorativeTypeZPlus
	{
		public stonebrickstwostepstairsZPlus() : base("stonebricks", "twostepstairs", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("twostepstairsz+");
		}
	}
}