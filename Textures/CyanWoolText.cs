using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using System.IO;

namespace PhentrixGames.ShapedBlocks.Textures
{
	[AttributeTexture]
	public class CyanWoolText : BaseTexture
	{
		public CyanWoolText() : base("CyanWoolText",
			Path.Combine(ShapedBlocks.ModMaterialsDirectory, Path.Combine("Wool", "wool_colored_cyan.png")).Replace("\\", "/")
		)
		{ }
	}
}