internal class EnumerableSorter<TElement, TKey> : EnumerableSorter<TElement> // TypeDefIndex: 2201
{
	// Fields
	internal Func<TElement, TKey> keySelector; // 0x0
	internal IComparer<TKey> comparer; // 0x0
	internal bool descending; // 0x0
	internal EnumerableSorter<TElement> next; // 0x0
	internal TKey[] keys; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending, EnumerableSorter<TElement> next) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A61970 Offset: 0x2A61A71 VA: 0x2A61970
	|-EnumerableSorter<Int32Enum, Guid>..ctor
	|
	|-RVA: 0x2A61CB0 Offset: 0x2A61DB1 VA: 0x2A61CB0
	|-EnumerableSorter<object, int>..ctor
	|
	|-RVA: 0x2A61FC0 Offset: 0x2A620C1 VA: 0x2A61FC0
	|-EnumerableSorter<object, object>..ctor
	|
	|-RVA: 0x2A622D0 Offset: 0x2A623D1 VA: 0x2A622D0
	|-EnumerableSorter<object, float>..ctor
	|
	|-RVA: 0x2A625E0 Offset: 0x2A626E1 VA: 0x2A625E0
	|-EnumerableSorter<object, uint>..ctor
	|
	|-RVA: 0x2A628F0 Offset: 0x2A629F1 VA: 0x2A628F0
	|-EnumerableSorter<RaycastHit, float>..ctor
	|
	|-RVA: 0x2A62C30 Offset: 0x2A62D31 VA: 0x2A62C30
	|-EnumerableSorter<DiagnosticEvent, int>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	internal override void ComputeKeys(TElement[] elements, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A61A00 Offset: 0x2A61B01 VA: 0x2A61A00
	|-EnumerableSorter<Int32Enum, Guid>.ComputeKeys
	|
	|-RVA: 0x2A61D40 Offset: 0x2A61E41 VA: 0x2A61D40
	|-EnumerableSorter<object, int>.ComputeKeys
	|
	|-RVA: 0x2A62050 Offset: 0x2A62151 VA: 0x2A62050
	|-EnumerableSorter<object, object>.ComputeKeys
	|
	|-RVA: 0x2A62360 Offset: 0x2A62461 VA: 0x2A62360
	|-EnumerableSorter<object, float>.ComputeKeys
	|
	|-RVA: 0x2A62670 Offset: 0x2A62771 VA: 0x2A62670
	|-EnumerableSorter<object, uint>.ComputeKeys
	|
	|-RVA: 0x2A62980 Offset: 0x2A62A81 VA: 0x2A62980
	|-EnumerableSorter<RaycastHit, float>.ComputeKeys
	|
	|-RVA: 0x2A62CC0 Offset: 0x2A62DC1 VA: 0x2A62CC0
	|-EnumerableSorter<DiagnosticEvent, int>.ComputeKeys
	*/

	// RVA: -1 Offset: -1 Slot: 5
	internal override int CompareKeys(int index1, int index2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A61B40 Offset: 0x2A61C41 VA: 0x2A61B40
	|-EnumerableSorter<Int32Enum, Guid>.CompareKeys
	|
	|-RVA: 0x2A61E70 Offset: 0x2A61F71 VA: 0x2A61E70
	|-EnumerableSorter<object, int>.CompareKeys
	|
	|-RVA: 0x2A62180 Offset: 0x2A62281 VA: 0x2A62180
	|-EnumerableSorter<object, object>.CompareKeys
	|
	|-RVA: 0x2A62490 Offset: 0x2A62591 VA: 0x2A62490
	|-EnumerableSorter<object, float>.CompareKeys
	|
	|-RVA: 0x2A627A0 Offset: 0x2A628A1 VA: 0x2A627A0
	|-EnumerableSorter<object, uint>.CompareKeys
	|
	|-RVA: 0x2A62AE0 Offset: 0x2A62BE1 VA: 0x2A62AE0
	|-EnumerableSorter<RaycastHit, float>.CompareKeys
	|
	|-RVA: 0x2A62E10 Offset: 0x2A62F11 VA: 0x2A62E10
	|-EnumerableSorter<DiagnosticEvent, int>.CompareKeys
	*/
}

