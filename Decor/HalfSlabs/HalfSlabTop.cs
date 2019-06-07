using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;

namespace PhentrixGames.ShapedBlocks.Decor.HalfSlabs
{
	[AttributePlayerRecipe]
	public class HalfSlabTopRecipe : BaseRecipe
	{
		public HalfSlabTopRecipe() : base("Test.HalfSlabTop", "pipliz.crafter", true, 10, 1)
		{
			Requirements.Add(new InventoryItem("planks", 1));
			Result.Add(new InventoryItem("HalfSlabTop", 1));
		}
	}

	[AttributeType]
	public class HalfSlabTop : BaseType
	{
		public HalfSlabTop() : base("HalfSlabTop", true)
		{
			this.SideAll = "planks";
			this.IsPlaceable = true;
			this.Icon = "halfslab.png";
			if (NewColonyAPI.Managers.MeshManager.GetMesh(ShapedBlocks.ModName, "halfslabtop", out string mesh))
			{
				this.Mesh = mesh;
			}
		}
	}
}