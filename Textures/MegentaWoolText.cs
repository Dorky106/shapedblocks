using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using System.IO;

namespace PhentrixGames.ShapedBlocks.Textures
{
	[AttributeTexture]
	public class MegentaWoolText : BaseTexture
	{
		public MegentaWoolText() : base("MegentaWoolText",
			Path.Combine(ShapedBlocks.ModMaterialsDirectory, Path.Combine("Wool", "wool_colored_magenta.png")).Replace("\\", "/")
		)
		{ }
	}
}