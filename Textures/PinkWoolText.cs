using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using System.IO;

namespace PhentrixGames.ShapedBlocks.Textures
{
	[AttributeTexture]
	public class PinkWoolText : BaseTexture
	{
		public PinkWoolText() : base("PinkWoolText",
			Path.Combine(ShapedBlocks.ModMaterialsDirectory, Path.Combine("Wool", "wool_colored_pink.png")).Replace("\\", "/")
		)
		{ }
	}
}