internal static class ListPool<T> // TypeDefIndex: 4019
{
	// Fields
	private static readonly ObjectPool<List<T>> s_ListPool; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void Clear(List<T> l) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAB040 Offset: 0x2AAB141 VA: 0x2AAB040
	|-ListPool<int>.Clear
	|
	|-RVA: 0x2AAB5E0 Offset: 0x2AAB6E1 VA: 0x2AAB5E0
	|-ListPool<object>.Clear
	|
	|-RVA: 0x2AABB80 Offset: 0x2AABC81 VA: 0x2AABB80
	|-ListPool<Color32>.Clear
	|
	|-RVA: 0x2AAC120 Offset: 0x2AAC221 VA: 0x2AAC120
	|-ListPool<UIVertex>.Clear
	|
	|-RVA: 0x2AAC6C0 Offset: 0x2AAC7C1 VA: 0x2AAC6C0
	|-ListPool<Vector2>.Clear
	|
	|-RVA: 0x2AACC60 Offset: 0x2AACD61 VA: 0x2AACC60
	|-ListPool<Vector3>.Clear
	|
	|-RVA: 0x2AAD200 Offset: 0x2AAD301 VA: 0x2AAD200
	|-ListPool<Vector4>.Clear
	*/

	// RVA: -1 Offset: -1
	public static List<T> Get() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAB0D0 Offset: 0x2AAB1D1 VA: 0x2AAB0D0
	|-ListPool<int>.Get
	|
	|-RVA: 0x2AAB670 Offset: 0x2AAB771 VA: 0x2AAB670
	|-ListPool<object>.Get
	|-ListPool<Canvas>.Get
	|-ListPool<Component>.Get
	|-ListPool<Mask>.Get
	|-ListPool<RectMask2D>.Get
	|
	|-RVA: 0x2AABC10 Offset: 0x2AABD11 VA: 0x2AABC10
	|-ListPool<Color32>.Get
	|
	|-RVA: 0x2AAC1B0 Offset: 0x2AAC2B1 VA: 0x2AAC1B0
	|-ListPool<UIVertex>.Get
	|
	|-RVA: 0x2AAC750 Offset: 0x2AAC851 VA: 0x2AAC750
	|-ListPool<Vector2>.Get
	|
	|-RVA: 0x2AACCF0 Offset: 0x2AACDF1 VA: 0x2AACCF0
	|-ListPool<Vector3>.Get
	|
	|-RVA: 0x2AAD290 Offset: 0x2AAD391 VA: 0x2AAD290
	|-ListPool<Vector4>.Get
	*/

	// RVA: -1 Offset: -1
	public static void Release(List<T> toRelease) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAB280 Offset: 0x2AAB381 VA: 0x2AAB280
	|-ListPool<int>.Release
	|
	|-RVA: 0x2AAB820 Offset: 0x2AAB921 VA: 0x2AAB820
	|-ListPool<object>.Release
	|-ListPool<Canvas>.Release
	|-ListPool<Component>.Release
	|-ListPool<Mask>.Release
	|-ListPool<RectMask2D>.Release
	|
	|-RVA: 0x2AABDC0 Offset: 0x2AABEC1 VA: 0x2AABDC0
	|-ListPool<Color32>.Release
	|
	|-RVA: 0x2AAC360 Offset: 0x2AAC461 VA: 0x2AAC360
	|-ListPool<UIVertex>.Release
	|
	|-RVA: 0x2AAC900 Offset: 0x2AACA01 VA: 0x2AAC900
	|-ListPool<Vector2>.Release
	|
	|-RVA: 0x2AACEA0 Offset: 0x2AACFA1 VA: 0x2AACEA0
	|-ListPool<Vector3>.Release
	|
	|-RVA: 0x2AAD440 Offset: 0x2AAD541 VA: 0x2AAD440
	|-ListPool<Vector4>.Release
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAB440 Offset: 0x2AAB541 VA: 0x2AAB440
	|-ListPool<int>..cctor
	|
	|-RVA: 0x2AAB9E0 Offset: 0x2AABAE1 VA: 0x2AAB9E0
	|-ListPool<object>..cctor
	|
	|-RVA: 0x2AABF80 Offset: 0x2AAC081 VA: 0x2AABF80
	|-ListPool<Color32>..cctor
	|
	|-RVA: 0x2AAC520 Offset: 0x2AAC621 VA: 0x2AAC520
	|-ListPool<UIVertex>..cctor
	|
	|-RVA: 0x2AACAC0 Offset: 0x2AACBC1 VA: 0x2AACAC0
	|-ListPool<Vector2>..cctor
	|
	|-RVA: 0x2AAD060 Offset: 0x2AAD161 VA: 0x2AAD060
	|-ListPool<Vector3>..cctor
	|
	|-RVA: 0x2AAD600 Offset: 0x2AAD701 VA: 0x2AAD600
	|-ListPool<Vector4>..cctor
	*/
}

