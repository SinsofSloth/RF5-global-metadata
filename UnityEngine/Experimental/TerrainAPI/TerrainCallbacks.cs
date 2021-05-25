public static class TerrainCallbacks // TypeDefIndex: 3664
{
	// Fields
	[DebuggerBrowsableAttribute] // RVA: 0xFD980 Offset: 0xFDA81 VA: 0xFD980
	[CompilerGeneratedAttribute] // RVA: 0xFD980 Offset: 0xFDA81 VA: 0xFD980
	private static TerrainCallbacks.HeightmapChangedCallback heightmapChanged; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0xFD9C0 Offset: 0xFDAC1 VA: 0xFD9C0
	[DebuggerBrowsableAttribute] // RVA: 0xFD9C0 Offset: 0xFDAC1 VA: 0xFD9C0
	private static TerrainCallbacks.TextureChangedCallback textureChanged; // 0x8

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0xFF420 Offset: 0xFF521 VA: 0xFF420
	// RVA: 0x1B45FC0 Offset: 0x1B460C1 VA: 0x1B45FC0
	internal static void InvokeHeightmapChangedCallback(TerrainData terrainData, RectInt heightRegion, bool synched) { }

	[RequiredByNativeCodeAttribute] // RVA: 0xFF430 Offset: 0xFF531 VA: 0xFF430
	// RVA: 0x1B465D0 Offset: 0x1B466D1 VA: 0x1B465D0
	internal static void InvokeTextureChangedCallback(TerrainData terrainData, string textureName, RectInt texelRegion, bool synched) { }
}

