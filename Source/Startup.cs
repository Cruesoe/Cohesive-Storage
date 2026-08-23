using HarmonyLib;
using Verse;

namespace CohesiveStorage;

public class CohesiveStorageMod : Mod
{
	public CohesiveStorageMod(ModContentPack content) : base(content)
	{
		new Harmony("koberiddle.cohesivestorage").PatchAll();
	}
}

[HarmonyPatch(typeof(ModMetaData), nameof(ModMetaData.VersionCompatible), MethodType.Getter)]
internal static class Patch_AdaptiveNeolithicVersionCompatible
{
	private const string PackageId = "adaptive.storage.neolithic";

	static void Postfix(ModMetaData __instance, ref bool __result)
	{
		if (__result)
		{
			return;
		}

		if (__instance.PackageIdNonUnique == PackageId)
		{
			__result = true;
		}
	}
}
