using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using System.IO;

namespace PhentrixGames.ShapedBlocks.Textures
{
	[AttributeTexture]
	public class BlueWoolText : BaseTexture
	{
		public BlueWoolText() : base("BlueWoolText",
			Path.Combine(ShapedBlocks.ModMaterialsDirectory, Path.Combine("Wool", "wool_colored_blue.png")).Replace("\\", "/")
		)
		{ }
	}
}