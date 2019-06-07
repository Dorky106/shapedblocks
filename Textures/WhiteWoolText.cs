using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using System.IO;

namespace PhentrixGames.ShapedBlocks.Textures
{
	[AttributeTexture]
	public class WhiteWoolText : BaseTexture
	{
		public WhiteWoolText() : base("WhiteWoolText",
			Path.Combine(ShapedBlocks.ModMaterialsDirectory, Path.Combine("Wool", "wool_colored_white.png")).Replace("\\", "/")
		)
		{ }
	}
}