using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using System.IO;

namespace PhentrixGames.ShapedBlocks.Textures
{
	[AttributeTexture]
	public class SilverWoolText : BaseTexture
	{
		public SilverWoolText() : base("SilverWoolText",
			Path.Combine(ShapedBlocks.ModMaterialsDirectory, Path.Combine("Wool", "wool_colored_silver.png")).Replace("\\", "/")
		)
		{ }
	}
}