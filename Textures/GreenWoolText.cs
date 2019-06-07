using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using System.IO;

namespace PhentrixGames.ShapedBlocks.Textures
{
	[AttributeTexture]
	public class GreenWoolText : BaseTexture
	{
		public GreenWoolText() : base("GreenWoolText",
			Path.Combine(ShapedBlocks.ModMaterialsDirectory, Path.Combine("Wool", "wool_colored_green.png")).Replace("\\", "/")
		)
		{ }
	}
}