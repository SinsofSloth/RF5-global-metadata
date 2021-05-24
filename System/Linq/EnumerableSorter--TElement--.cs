internal abstract class EnumerableSorter<TElement> // TypeDefIndex: 2200
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	internal abstract void ComputeKeys(TElement[] elements, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-EnumerableSorter<object>.ComputeKeys
	*/

	// RVA: -1 Offset: -1 Slot: 5
	internal abstract int CompareKeys(int index1, int index2) { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-EnumerableSorter<object>.CompareKeys
	*/

	// RVA: -1 Offset: -1
	internal int[] Sort(TElement[] elements, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A60C70 Offset: 0x2A60D71 VA: 0x2A60C70
	|-EnumerableSorter<Int32Enum>.Sort
	|
	|-RVA: 0x2A60FB0 Offset: 0x2A610B1 VA: 0x2A60FB0
	|-EnumerableSorter<object>.Sort
	|
	|-RVA: 0x2A612F0 Offset: 0x2A613F1 VA: 0x2A612F0
	|-EnumerableSorter<RaycastHit>.Sort
	|
	|-RVA: 0x2A61630 Offset: 0x2A61731 VA: 0x2A61630
	|-EnumerableSorter<DiagnosticEvent>.Sort
	*/

	// RVA: -1 Offset: -1
	private void QuickSort(int[] map, int left, int right) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A60D70 Offset: 0x2A60E71 VA: 0x2A60D70
	|-EnumerableSorter<Int32Enum>.QuickSort
	|
	|-RVA: 0x2A610B0 Offset: 0x2A611B1 VA: 0x2A610B0
	|-EnumerableSorter<object>.QuickSort
	|
	|-RVA: 0x2A613F0 Offset: 0x2A614F1 VA: 0x2A613F0
	|-EnumerableSorter<RaycastHit>.QuickSort
	|
	|-RVA: 0x2A61730 Offset: 0x2A61831 VA: 0x2A61730
	|-EnumerableSorter<DiagnosticEvent>.QuickSort
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A60F90 Offset: 0x2A61091 VA: 0x2A60F90
	|-EnumerableSorter<Int32Enum>..ctor
	|
	|-RVA: 0x2A612D0 Offset: 0x2A613D1 VA: 0x2A612D0
	|-EnumerableSorter<object>..ctor
	|
	|-RVA: 0x2A61610 Offset: 0x2A61711 VA: 0x2A61610
	|-EnumerableSorter<RaycastHit>..ctor
	|
	|-RVA: 0x2A61950 Offset: 0x2A61A51 VA: 0x2A61950
	|-EnumerableSorter<DiagnosticEvent>..ctor
	*/
}

