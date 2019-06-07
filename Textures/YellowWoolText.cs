using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using System.IO;

namespace PhentrixGames.ShapedBlocks.Textures
{
	[AttributeTexture]
	public class YellowWoolText : BaseTexture
	{
		public YellowWoolText() : base("YellowWoolText",
			Path.Combine(ShapedBlocks.ModMaterialsDirectory, Path.Combine("Wool", "wool_colored_yellow.png")).Replace("\\", "/")
		)
		{ }
	}
}