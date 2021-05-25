internal abstract class SearchResultHandler<TSource> // TypeDefIndex: 647
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	internal abstract bool IsResultIncluded(SearchResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-SearchResultHandler<object>.IsResultIncluded
	*/

	// RVA: -1 Offset: -1 Slot: 5
	internal abstract TSource CreateObject(SearchResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-SearchResultHandler<object>.CreateObject
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B14450 Offset: 0x2B14551 VA: 0x2B14450
	|-SearchResultHandler<object>..ctor
	|-SearchResultHandler<string>..ctor
	*/
}

