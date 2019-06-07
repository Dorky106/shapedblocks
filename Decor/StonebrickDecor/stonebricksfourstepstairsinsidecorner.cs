using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.ShapedBlocks.Decor
{
	[AttributePlayerRecipe]
	public class stonebricksfourstepstairsinsidecornerRecipe : BaseRecipe
	{
		public stonebricksfourstepstairsinsidecornerRecipe() : base("stonebricksfourstepstairsinsidecornerrecipe")
		{
			Requirements.Add(new InventoryItem("stonebricks", 1));
			Result.Add(new InventoryItem("stonebricksfourstepstairsinsidecorner", 1));
		}
	}
	
	[AttributeType]
	public class stonebricksfourstepstairsinsidecorner : DecorativeType
	{
		public stonebricksfourstepstairsinsidecorner() : base("stonebricks", "fourstepstairsinsidecorner",
			Utilities.MultiCombine(ShapedBlocks.ModIconDirectory, "stonebricksfourstepstairsinsidecorner.png"))
		{
			this.SideAll = "stonebricks";
		}
	}

	[AttributeType]
	public class stonebricksfourstepstairsinsidecornerXMinus : DecorativeTypeXMinus
	{
		public stonebricksfourstepstairsinsidecornerXMinus() : base("stonebricks", "fourstepstairsinsidecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("fourstepstairsinsidecornerx-");
		}
	}

	[AttributeType]
	public class stonebricksfourstepstairsinsidecornerXPlus : DecorativeTypeXPlus
	{
		public stonebricksfourstepstairsinsidecornerXPlus() : base("stonebricks", "fourstepstairsinsidecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("fourstepstairsinsidecornerx+");
		}
	}

	[AttributeType]
	public class stonebricksfourstepstairsinsidecornerZMinus : DecorativeTypeZMinus
	{
		public stonebricksfourstepstairsinsidecornerZMinus() : base("stonebricks", "fourstepstairsinsidecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("fourstepstairsinsidecornerz-");
		}
	}

	[AttributeType]
	public class stonebricksfourstepstairsinsidecornerZPlus : DecorativeTypeZPlus
	{
		public stonebricksfourstepstairsinsidecornerZPlus() : base("stonebricks", "fourstepstairsinsidecorner", ShapedBlocks.ModName)
		{
			this.Colliders = NewColonyAPI.Helpers.Colliders.GetColliders("fourstepstairsinsidecornerz+");
		}
	}
}