private struct Array.SorterObjectArray // TypeDefIndex: 124
{
	// Fields
	private object[] keys; // 0x0
	private object[] items; // 0x8
	private IComparer comparer; // 0x10

	// Methods

	// RVA: 0xBB50 Offset: 0xBC51 VA: 0xBB50
	internal void .ctor(object[] keys, object[] items, IComparer comparer) { }

	// RVA: 0xBC10 Offset: 0xBD11 VA: 0xBC10
	internal void SwapIfGreaterWithItems(int a, int b) { }

	// RVA: 0xBC20 Offset: 0xBD21 VA: 0xBC20
	private void Swap(int i, int j) { }

	// RVA: 0xBC30 Offset: 0xBD31 VA: 0xBC30
	internal void Sort(int left, int length) { }

	// RVA: 0xBC40 Offset: 0xBD41 VA: 0xBC40
	private void IntrospectiveSort(int left, int length) { }

	// RVA: 0xBC50 Offset: 0xBD51 VA: 0xBC50
	private void IntroSort(int lo, int hi, int depthLimit) { }

	// RVA: 0xBC60 Offset: 0xBD61 VA: 0xBC60
	private int PickPivotAndPartition(int lo, int hi) { }

	// RVA: 0xBC70 Offset: 0xBD71 VA: 0xBC70
	private void Heapsort(int lo, int hi) { }

	// RVA: 0xBD20 Offset: 0xBE21 VA: 0xBD20
	private void DownHeap(int i, int n, int lo) { }

	// RVA: 0xBD30 Offset: 0xBE31 VA: 0xBD30
	private void InsertionSort(int lo, int hi) { }
}

