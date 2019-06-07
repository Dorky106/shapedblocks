using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Classes;
using System.IO;

namespace PhentrixGames.ShapedBlocks.Textures
{
	[AttributeTexture]
	public class OrangeWoolText : BaseTexture
	{
		public OrangeWoolText() : base("OrangeWoolText",
			Path.Combine(ShapedBlocks.ModMaterialsDirectory, Path.Combine("Wool", "wool_colored_orange.png")).Replace("\\", "/")
		)
		{ }
	}
}