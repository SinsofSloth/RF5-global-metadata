[ExtensionAttribute] // RVA: 0xB3800 Offset: 0xB3901 VA: 0xB3800
public static class CollectionExtensions // TypeDefIndex: 1415
{
	// Methods

	[ExtensionAttribute] // RVA: 0xB9D10 Offset: 0xB9E11 VA: 0xB9D10
	// RVA: -1 Offset: -1
	public static TValue GetValueOrDefault<TKey, TValue>(IReadOnlyDictionary<TKey, TValue> dictionary, TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x226CB50 Offset: 0x226CC51 VA: 0x226CB50
	|-CollectionExtensions.GetValueOrDefault<object, object>
	|-CollectionExtensions.GetValueOrDefault<string, LocalDataStoreSlot>
	*/

	[ExtensionAttribute] // RVA: 0xB9D20 Offset: 0xB9E21 VA: 0xB9D20
	// RVA: -1 Offset: -1
	public static TValue GetValueOrDefault<TKey, TValue>(IReadOnlyDictionary<TKey, TValue> dictionary, TKey key, TValue defaultValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x226CB70 Offset: 0x226CC71 VA: 0x226CB70
	|-CollectionExtensions.GetValueOrDefault<object, object>
	*/
}

