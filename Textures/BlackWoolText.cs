using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using System.IO;

namespace PhentrixGames.ShapedBlocks.Textures
{
	[AttributeTexture]
	public class BlackWoolText : BaseTexture
	{
		public BlackWoolText() : base("BlackWoolText",
			Path.Combine(ShapedBlocks.ModMaterialsDirectory, Path.Combine("Wool", "wool_colored_black.png")).Replace("\\", "/")
		)
		{ }
	}
}