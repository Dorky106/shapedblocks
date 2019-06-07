using System;
using System.IO;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.ShapedBlocks
{
	public static class ShapedBlocks
	{
		public const string ModName = "Shaped Blocks";
		public const string Naming = "PhentrixGames.ShapedBlocks";
		public static Version Version = new Version(0, 0, 0, 0);
		public static string ModFolder;
		public static string ModGamedataDirectory;
		public static string ModIconDirectory;
		public static string ModMaterialsDirectory;
	}

	[ModLoader.ModManager]
	public static class CBOnAssemblyLoaded
	{
		[ModLoader.ModCallback(ModLoader.EModCallbackType.OnAssemblyLoaded, ShapedBlocks.Naming + "OnAssemblyLoaded")]
		[ModLoader.ModCallbackDependsOn(NewColonyAPI.NewColonyAPI.Naming + "OnAssemblyLoaded")]
		public static void OnAssemblyLoaded(string path)
		{
			ShapedBlocks.ModFolder = Path.GetDirectoryName(path);
			ShapedBlocks.ModGamedataDirectory = Utilities.MultiCombine(ShapedBlocks.ModFolder, "gamedata");
			ShapedBlocks.ModIconDirectory = Utilities.MultiCombine(ShapedBlocks.ModGamedataDirectory, "textures", "icons");
			ShapedBlocks.ModMaterialsDirectory = Utilities.MultiCombine(ShapedBlocks.ModGamedataDirectory, "textures", "blocks");

			NewColonyAPI.Managers.ModManager.RegisterMod(ShapedBlocks.ModName, ShapedBlocks.ModFolder, ShapedBlocks.Version, "http://phentrixgames.com/mods/shapedblocks");
		}
	}


	[ModLoader.ModManager]
	public static class CBAfterSelectedWorld
	{
		[ModLoader.ModCallback(ModLoader.EModCallbackType.AfterSelectedWorld, ShapedBlocks.Naming + "LoadTextures")]
		[ModLoader.ModCallbackProvidesFor(NewColonyAPI.NewColonyAPI.Naming + "LoadTextures")]
		public static void LoadTextures()
		{
			NewColonyAPI.Managers.MeshManager.RegisterMeshs(ShapedBlocks.ModName, Utilities.MultiCombine(ShapedBlocks.ModGamedataDirectory, "Meshes"));
		}
	}
}