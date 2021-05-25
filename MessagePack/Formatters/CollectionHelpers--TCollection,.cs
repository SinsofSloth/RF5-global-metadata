internal static class CollectionHelpers<TCollection, TEqualityComparer> // TypeDefIndex: 5388
{
	// Fields
	private static Func<int, TEqualityComparer, TCollection> collectionCreator; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D386D0 Offset: 0x2D387D1 VA: 0x2D386D0
	|-CollectionHelpers<object, object>..cctor
	*/

	// RVA: -1 Offset: -1
	internal static TCollection CreateHashCollection(int count, TEqualityComparer equalityComparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D38B40 Offset: 0x2D38C41 VA: 0x2D38B40
	|-CollectionHelpers<object, object>.CreateHashCollection
	*/
}

