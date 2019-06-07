using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.ShapedBlocks.Decor
{
	[AttributePlayerRecipe]
	public class stonebricksfourstepstairsRecipe : BaseRecipe
	{
		public stonebricksfourstepstairsRecipe() : base("stonebricksfourstepstairsrecipe")
		{
			Requirements.Add(new InventoryItem("stonebricks", 1));
			Result.Add(new InventoryItem("stonebricksfourstepstairs", 1));
		}
	}
	
	[AttributeType]
	public class stonebricksfourstepstairs : DecorativeType
	{
		public stonebricksfourstepstairs() : base("stonebricks", "fourstepstairs",
			Utilities.MultiCombine(ShapedBlocks.ModIconDirectory, "stonebricksfourstepstairs.png"))
		{
			this.SideAll = "stonebricks";
		}
	}

	[AttributeType]
	public class stonebricksfourstepstairsXMinus : DecorativeTypeXMinus
	{
		public stonebricksfourstepstairsXMinus() : base("stonebricks", "fourstepstairs", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("fourstepstairsx-");
		}
	}

	[AttributeType]
	public class stonebricksfourstepstairsXPlus : DecorativeTypeXPlus
	{
		public stonebricksfourstepstairsXPlus() : base("stonebricks", "fourstepstairs", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("fourstepstairsx+");
		}
	}

	[AttributeType]
	public class stonebricksfourstepstairsZMinus : DecorativeTypeZMinus
	{
		public stonebricksfourstepstairsZMinus() : base("stonebricks", "fourstepstairs", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("fourstepstairsz-");
		}
	}

	[AttributeType]
	public class stonebricksfourstepstairsZPlus : DecorativeTypeZPlus
	{
		public stonebricksfourstepstairsZPlus() : base("stonebricks", "fourstepstairs", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("fourstepstairsz+");
		}
	}
}