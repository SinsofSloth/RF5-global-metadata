internal struct SparselyPopulatedArrayAddInfo<T> // TypeDefIndex: 757
{
	// Fields
	private SparselyPopulatedArrayFragment<T> m_source; // 0x0
	private int m_index; // 0x0

	// Properties
	internal SparselyPopulatedArrayFragment<T> Source { get; }
	internal int Index { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(SparselyPopulatedArrayFragment<T> source, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3833D0 Offset: 0x3834D1 VA: 0x3833D0
	|-SparselyPopulatedArrayAddInfo<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal SparselyPopulatedArrayFragment<T> get_Source() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x383400 Offset: 0x383501 VA: 0x383400
	|-SparselyPopulatedArrayAddInfo<object>.get_Source
	|-SparselyPopulatedArrayAddInfo<CancellationCallbackInfo>.get_Source
	*/

	// RVA: -1 Offset: -1
	internal int get_Index() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x383410 Offset: 0x383511 VA: 0x383410
	|-SparselyPopulatedArrayAddInfo<object>.get_Index
	|-SparselyPopulatedArrayAddInfo<CancellationCallbackInfo>.get_Index
	*/
}

