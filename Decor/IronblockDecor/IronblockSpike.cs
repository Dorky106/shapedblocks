using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.ShapedBlocks.Decor
{
	[AttributeType]
	public class ironblockspike : BaseType
	{
		public ironblockspike() : base("ironblockspike", true)
		{
			this.SideAll = "ironblock";
			this.IsPlaceable = true;
			this.Icon = Utilities.MultiCombine(ShapedBlocks.ModIconDirectory, "ironblockspike.png");
			if (NewColonyAPI.Managers.MeshManager.GetMesh(ShapedBlocks.ModName, "spike", out string mesh))
			{
				this.Mesh = mesh;
			}
		}
	}
}