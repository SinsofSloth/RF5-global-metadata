[ExtensionAttribute] // RVA: 0x1413C0 Offset: 0x1414C1 VA: 0x1413C0
internal static class ArrayUtility // TypeDefIndex: 5942
{
	// Methods

	[ExtensionAttribute] // RVA: 0x1424E0 Offset: 0x1425E1 VA: 0x1424E0
	// RVA: -1 Offset: -1
	public static T[] Add<T>(T[] arr, T val) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34F76B0 Offset: 0x34F77B1 VA: 0x34F76B0
	|-ArrayUtility.Add<int>
	|
	|-RVA: 0x34F7760 Offset: 0x34F7861 VA: 0x34F7760
	|-ArrayUtility.Add<object>
	|-ArrayUtility.Add<SharedVertex>
	*/

	[ExtensionAttribute] // RVA: 0x1424F0 Offset: 0x1425F1 VA: 0x1424F0
	// RVA: -1 Offset: -1
	public static T[] RemoveAt<T>(T[] arr, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34F7970 Offset: 0x34F7A71 VA: 0x34F7970
	|-ArrayUtility.RemoveAt<int>
	|
	|-RVA: 0x34F7A60 Offset: 0x34F7B61 VA: 0x34F7A60
	|-ArrayUtility.RemoveAt<object>
	*/

	// RVA: -1 Offset: -1
	public static T[] Fill<T>(T val, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34F7810 Offset: 0x34F7911 VA: 0x34F7810
	|-ArrayUtility.Fill<object>
	|
	|-RVA: 0x34F78C0 Offset: 0x34F79C1 VA: 0x34F78C0
	|-ArrayUtility.Fill<Color>
	*/

	[ExtensionAttribute] // RVA: 0x142500 Offset: 0x142601 VA: 0x142500
	// RVA: -1 Offset: -1
	public static string ToString<T>(IEnumerable<T> arr, string separator = ", ") { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2563920 Offset: 0x2563A21 VA: 0x2563920
	|-ArrayUtility.ToString<int>
	|
	|-RVA: 0x2563B40 Offset: 0x2563C41 VA: 0x2563B40
	|-ArrayUtility.ToString<object>
	*/
}

