using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;

namespace PhentrixGames.ShapedBlocks.Decor.HalfSlabs
{
	[AttributePlayerRecipe]
	public class HalfSlabBottomRecipe : BaseRecipe
	{
		public HalfSlabBottomRecipe() : base("Test.HalfSlabBottom", "pipliz.crafter", true, 10, 1)
		{
			Requirements.Add(new InventoryItem("planks", 1));
			Result.Add(new InventoryItem("HalfSlabBottom", 1));
		}
	}

	[AttributeType]
	public class HalfSlabBottom : BaseType
	{
		public HalfSlabBottom() : base("HalfSlabBottom", true)
		{
			this.SideAll = "planks";
			this.IsPlaceable = true;
			this.Icon = "halfslab.png";
			if (NewColonyAPI.Managers.MeshManager.GetMesh(ShapedBlocks.ModName, "halfslabbottom", out string mesh))
			{
				this.Mesh = mesh;
			}
		}
	}
}