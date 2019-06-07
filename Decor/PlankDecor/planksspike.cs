using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.ShapedBlocks.Decor
{
	[AttributeType]
	public class planksspike : BaseType
	{
		public planksspike() : base("planksspike", true)
		{
			this.SideAll = "planks";
			this.IsPlaceable = true;
			this.Icon = Utilities.MultiCombine(ShapedBlocks.ModIconDirectory, "planksspike.png");
			if (NewColonyAPI.Managers.MeshManager.GetMesh(ShapedBlocks.ModName, "spike", out string mesh))
			{
				this.Mesh = mesh;
			}
		}
	}
}