using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.ShapedBlocks.Decor
{
	[AttributeType]
	public class stonebricksspike : BaseType
	{
		public stonebricksspike() : base("stonebricksspike", true)
		{
			this.SideAll = "stonebricks";
			this.IsPlaceable = true;
			this.Icon = Utilities.MultiCombine(ShapedBlocks.ModIconDirectory, "stonebricksspike.png");
			if (NewColonyAPI.Managers.MeshManager.GetMesh(ShapedBlocks.ModName, "spike", out string mesh))
			{
				this.Mesh = mesh;
			}
		}
	}
}