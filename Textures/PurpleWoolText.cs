using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using System.IO;

namespace PhentrixGames.ShapedBlocks.Textures
{
	[AttributeTexture]
	public class PurpleWoolText : BaseTexture
	{
		public PurpleWoolText() : base("PurpleWoolText",
			Path.Combine(ShapedBlocks.ModMaterialsDirectory, Path.Combine("Wool", "wool_colored_purple.png")).Replace("\\", "/")
		)
		{ }
	}
}