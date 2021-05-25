[DefaultMemberAttribute] // RVA: 0xAEFF0 Offset: 0xAF0F1 VA: 0xAEFF0
internal class SparselyPopulatedArrayFragment<T> // TypeDefIndex: 758
{
	// Fields
	internal readonly T[] m_elements; // 0x0
	internal int m_freeCount; // 0x0
	internal SparselyPopulatedArrayFragment<T> m_next; // 0x0
	internal SparselyPopulatedArrayFragment<T> m_prev; // 0x0

	// Properties
	internal T Item { get; }
	internal int Length { get; }
	internal SparselyPopulatedArrayFragment<T> Prev { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B83460 Offset: 0x2B83561 VA: 0x2B83460
	|-SparselyPopulatedArrayFragment<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(int size, SparselyPopulatedArrayFragment<T> prev) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B83490 Offset: 0x2B83591 VA: 0x2B83490
	|-SparselyPopulatedArrayFragment<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B83520 Offset: 0x2B83621 VA: 0x2B83520
	|-SparselyPopulatedArrayFragment<object>.get_Item
	|-SparselyPopulatedArrayFragment<CancellationCallbackInfo>.get_Item
	*/

	// RVA: -1 Offset: -1
	internal int get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B83570 Offset: 0x2B83671 VA: 0x2B83570
	|-SparselyPopulatedArrayFragment<object>.get_Length
	|-SparselyPopulatedArrayFragment<CancellationCallbackInfo>.get_Length
	*/

	// RVA: -1 Offset: -1
	internal SparselyPopulatedArrayFragment<T> get_Prev() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B83590 Offset: 0x2B83691 VA: 0x2B83590
	|-SparselyPopulatedArrayFragment<object>.get_Prev
	|-SparselyPopulatedArrayFragment<CancellationCallbackInfo>.get_Prev
	*/

	// RVA: -1 Offset: -1
	internal T SafeAtomicRemove(int index, T expectedElement) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B835C0 Offset: 0x2B836C1 VA: 0x2B835C0
	|-SparselyPopulatedArrayFragment<object>.SafeAtomicRemove
	|-SparselyPopulatedArrayFragment<CancellationCallbackInfo>.SafeAtomicRemove
	*/
}

