[StaticAccessorAttribute] // RVA: 0xC7970 Offset: 0xC7A71 VA: 0xC7970
[NativeHeaderAttribute] // RVA: 0xC7970 Offset: 0xC7A71 VA: 0xC7970
internal static class SceneManagerAPIInternal // TypeDefIndex: 3121
{
	// Methods

	[NativeThrowsAttribute] // RVA: 0xD9590 Offset: 0xD9691 VA: 0xD9590
	// RVA: 0x2A252A0 Offset: 0x2A253A1 VA: 0x2A252A0
	public static AsyncOperation LoadSceneAsyncNameIndexInternal(string sceneName, int sceneBuildIndex, LoadSceneParameters parameters, bool mustCompleteNextFrame) { }

	[NativeThrowsAttribute] // RVA: 0xD95A0 Offset: 0xD96A1 VA: 0xD95A0
	// RVA: 0x2A25400 Offset: 0x2A25501 VA: 0x2A25400
	public static AsyncOperation UnloadSceneNameIndexInternal(string sceneName, int sceneBuildIndex, bool immediately, UnloadSceneOptions options, out bool outSuccess) { }

	// RVA: 0x2A26650 Offset: 0x2A26751 VA: 0x2A26650
	private static AsyncOperation LoadSceneAsyncNameIndexInternal_Injected(string sceneName, int sceneBuildIndex, ref LoadSceneParameters parameters, bool mustCompleteNextFrame) { }
}

