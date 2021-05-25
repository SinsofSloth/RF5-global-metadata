private struct Array.SorterGenericArray // TypeDefIndex: 125
{
	// Fields
	private Array keys; // 0x0
	private Array items; // 0x8
	private IComparer comparer; // 0x10

	// Methods

	// RVA: 0xB910 Offset: 0xBA11 VA: 0xB910
	internal void .ctor(Array keys, Array items, IComparer comparer) { }

	// RVA: 0xB9D0 Offset: 0xBAD1 VA: 0xB9D0
	internal void SwapIfGreaterWithItems(int a, int b) { }

	// RVA: 0xB9E0 Offset: 0xBAE1 VA: 0xB9E0
	private void Swap(int i, int j) { }

	// RVA: 0xB9F0 Offset: 0xBAF1 VA: 0xB9F0
	internal void Sort(int left, int length) { }

	// RVA: 0xBA00 Offset: 0xBB01 VA: 0xBA00
	private void IntrospectiveSort(int left, int length) { }

	// RVA: 0xBA10 Offset: 0xBB11 VA: 0xBA10
	private void IntroSort(int lo, int hi, int depthLimit) { }

	// RVA: 0xBA20 Offset: 0xBB21 VA: 0xBA20
	private int PickPivotAndPartition(int lo, int hi) { }

	// RVA: 0xBA30 Offset: 0xBB31 VA: 0xBA30
	private void Heapsort(int lo, int hi) { }

	// RVA: 0xBAE0 Offset: 0xBBE1 VA: 0xBAE0
	private void DownHeap(int i, int n, int lo) { }

	// RVA: 0xBAF0 Offset: 0xBBF1 VA: 0xBAF0
	private void InsertionSort(int lo, int hi) { }
}

