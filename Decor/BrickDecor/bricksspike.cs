using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.ShapedBlocks.Decor
{
	[AttributeType]
	public class bricksspike : BaseType
	{
		public bricksspike() : base("bricksspike", true)
		{
			this.SideAll = "bricks";
			this.IsPlaceable = true;
			this.Icon = Utilities.MultiCombine(ShapedBlocks.ModIconDirectory, "bricksspike.png");
			if (NewColonyAPI.Managers.MeshManager.GetMesh(ShapedBlocks.ModName, "spike", out string mesh))
			{
				this.Mesh = mesh;
			}
		}
	}
}