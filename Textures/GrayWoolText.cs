using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using System.IO;

namespace PhentrixGames.ShapedBlocks.Textures
{
	[AttributeTexture]
	public class GrayWoolText : BaseTexture
	{
		public GrayWoolText() : base("GrayWoolText",
			Path.Combine(ShapedBlocks.ModMaterialsDirectory, Path.Combine("Wool", "wool_colored_gray.png")).Replace("\\", "/")
		)
		{ }
	}
}