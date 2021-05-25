public static class AddressableManager // TypeDefIndex: 6847
{
	// Fields
	private static bool addressableInit; // 0x0

	// Methods

	[IteratorStateMachineAttribute] // RVA: 0x19D530 Offset: 0x19D631 VA: 0x19D530
	// RVA: -1 Offset: -1
	public static IEnumerator LoadResourceAsset<T>(string assetName, Transform parent, UnityAction<T> callback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21AAF20 Offset: 0x21AB021 VA: 0x21AAF20
	|-AddressableManager.LoadResourceAsset<SpriteDataResource>
	|-AddressableManager.LoadResourceAsset<object>
	*/

	// RVA: -1 Offset: -1
	public static void ReleaseResourceAsset<T>(T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CDDF0 Offset: 0x21CDEF1 VA: 0x21CDDF0
	|-AddressableManager.ReleaseResourceAsset<object>
	*/

	// RVA: 0x1BF52F0 Offset: 0x1BF53F1 VA: 0x1BF52F0
	private static void .cctor() { }
}

