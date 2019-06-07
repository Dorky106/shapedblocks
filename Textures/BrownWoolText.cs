using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using System.IO;

namespace PhentrixGames.ShapedBlocks.Textures
{
	[AttributeTexture]
	public class BrownWoolText : BaseTexture
	{
		public BrownWoolText() : base("BrownWoolText",
			Path.Combine(ShapedBlocks.ModMaterialsDirectory, Path.Combine("Wool", "wool_colored_brown.png")).Replace("\\", "/")
		)
		{ }
	}
}