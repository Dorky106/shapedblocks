using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using System.IO;

namespace PhentrixGames.ShapedBlocks.Textures
{
	[AttributeTexture]
	public class LightBlueWoolText : BaseTexture
	{
		public LightBlueWoolText() : base("LightBlueWoolText",
			Path.Combine(ShapedBlocks.ModMaterialsDirectory, Path.Combine("Wool", "wool_colored_light_blue.png")).Replace("\\", "/")
		)
		{ }
	}
}