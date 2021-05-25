internal abstract class OrderedEnumerable<TElement> : IOrderedEnumerable<TElement>, IEnumerable<TElement>, IEnumerable // TypeDefIndex: 2197
{
	// Fields
	internal IEnumerable<TElement> source; // 0x0

	// Methods

	[IteratorStateMachineAttribute] // RVA: 0xC05D0 Offset: 0xC06D1 VA: 0xC05D0
	// RVA: -1 Offset: -1 Slot: 5
	public IEnumerator<TElement> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A69700 Offset: 0x2A69801 VA: 0x2A69700
	|-OrderedEnumerable<Int32Enum>.GetEnumerator
	|
	|-RVA: 0x2A697E0 Offset: 0x2A698E1 VA: 0x2A697E0
	|-OrderedEnumerable<object>.GetEnumerator
	|
	|-RVA: 0x2A698C0 Offset: 0x2A699C1 VA: 0x2A698C0
	|-OrderedEnumerable<RaycastHit>.GetEnumerator
	|
	|-RVA: 0x2A699A0 Offset: 0x2A69AA1 VA: 0x2A699A0
	|-OrderedEnumerable<DiagnosticEvent>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 7
	internal abstract EnumerableSorter<TElement> GetEnumerableSorter(EnumerableSorter<TElement> next) { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-OrderedEnumerable<object>.GetEnumerableSorter
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A69790 Offset: 0x2A69891 VA: 0x2A69790
	|-OrderedEnumerable<Int32Enum>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A69870 Offset: 0x2A69971 VA: 0x2A69870
	|-OrderedEnumerable<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A69950 Offset: 0x2A69A51 VA: 0x2A69950
	|-OrderedEnumerable<RaycastHit>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A69A30 Offset: 0x2A69B31 VA: 0x2A69A30
	|-OrderedEnumerable<DiagnosticEvent>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private IOrderedEnumerable<TElement> System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable<TKey>(Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x255FB80 Offset: 0x255FC81 VA: 0x255FB80
	|-OrderedEnumerable<object>.System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable<object>
	|
	|-RVA: 0x255FC30 Offset: 0x255FD31 VA: 0x255FC30
	|-OrderedEnumerable<object>.System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable<uint>
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A697C0 Offset: 0x2A698C1 VA: 0x2A697C0
	|-OrderedEnumerable<Int32Enum>..ctor
	|
	|-RVA: 0x2A698A0 Offset: 0x2A699A1 VA: 0x2A698A0
	|-OrderedEnumerable<object>..ctor
	|
	|-RVA: 0x2A69980 Offset: 0x2A69A81 VA: 0x2A69980
	|-OrderedEnumerable<RaycastHit>..ctor
	|
	|-RVA: 0x2A69A60 Offset: 0x2A69B61 VA: 0x2A69A60
	|-OrderedEnumerable<DiagnosticEvent>..ctor
	*/
}

