using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.ShapedBlocks.Decor
{
	[AttributeType]
	public class plasterblockspike : BaseType
	{
		public plasterblockspike() : base("plasterblockspike", true)
		{
			this.SideAll = "plasterblock";
			this.IsPlaceable = true;
			this.Icon = Utilities.MultiCombine(ShapedBlocks.ModIconDirectory, "plasterblockspike.png");
			if (NewColonyAPI.Managers.MeshManager.GetMesh(ShapedBlocks.ModName, "spike", out string mesh))
			{
				this.Mesh = mesh;
			}
		}
	}
}