using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using System.IO;

namespace PhentrixGames.ShapedBlocks.Textures
{
	[AttributeTexture]
	public class LimeWoolText : BaseTexture
	{
		public LimeWoolText() : base("LimeWoolText",
			Path.Combine(ShapedBlocks.ModMaterialsDirectory, Path.Combine("Wool", "wool_colored_lime.png")).Replace("\\", "/")
		)
		{ }
	}
}