internal class ArraySortHelper<TKey, TValue> // TypeDefIndex: 1420
{
	// Fields
	private static ArraySortHelper<TKey, TValue> s_defaultArraySortHelper; // 0x0

	// Properties
	public static ArraySortHelper<TKey, TValue> Default { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static ArraySortHelper<TKey, TValue> get_Default() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC7690 Offset: 0x2FC7791 VA: 0x2FC7690
	|-ArraySortHelper<object, object>.get_Default
	|
	|-RVA: 0x2FC8EC0 Offset: 0x2FC8FC1 VA: 0x2FC8EC0
	|-ArraySortHelper<ulong, object>.get_Default
	*/

	// RVA: -1 Offset: -1
	private static ArraySortHelper<TKey, TValue> CreateArraySortHelper() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC7770 Offset: 0x2FC7871 VA: 0x2FC7770
	|-ArraySortHelper<object, object>.CreateArraySortHelper
	|
	|-RVA: 0x2FC8FA0 Offset: 0x2FC90A1 VA: 0x2FC8FA0
	|-ArraySortHelper<ulong, object>.CreateArraySortHelper
	*/

	// RVA: -1 Offset: -1
	public void Sort(TKey[] keys, TValue[] values, int index, int length, IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC7890 Offset: 0x2FC7991 VA: 0x2FC7890
	|-ArraySortHelper<object, object>.Sort
	|
	|-RVA: 0x2FC90C0 Offset: 0x2FC91C1 VA: 0x2FC90C0
	|-ArraySortHelper<ulong, object>.Sort
	*/

	// RVA: -1 Offset: -1
	private static void SwapIfGreaterWithItems(TKey[] keys, TValue[] values, IComparer<TKey> comparer, int a, int b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC7A70 Offset: 0x2FC7B71 VA: 0x2FC7A70
	|-ArraySortHelper<object, object>.SwapIfGreaterWithItems
	|
	|-RVA: 0x2FC92A0 Offset: 0x2FC93A1 VA: 0x2FC92A0
	|-ArraySortHelper<ulong, object>.SwapIfGreaterWithItems
	*/

	// RVA: -1 Offset: -1
	private static void Swap(TKey[] keys, TValue[] values, int i, int j) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC7C90 Offset: 0x2FC7D91 VA: 0x2FC7C90
	|-ArraySortHelper<object, object>.Swap
	|
	|-RVA: 0x2FC94B0 Offset: 0x2FC95B1 VA: 0x2FC94B0
	|-ArraySortHelper<ulong, object>.Swap
	*/

	// RVA: -1 Offset: -1
	internal static void IntrospectiveSort(TKey[] keys, TValue[] values, int left, int length, IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC7DA0 Offset: 0x2FC7EA1 VA: 0x2FC7DA0
	|-ArraySortHelper<object, object>.IntrospectiveSort
	|
	|-RVA: 0x2FC9590 Offset: 0x2FC9691 VA: 0x2FC9590
	|-ArraySortHelper<ulong, object>.IntrospectiveSort
	*/

	// RVA: -1 Offset: -1
	private static void IntroSort(TKey[] keys, TValue[] values, int lo, int hi, int depthLimit, IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC7EA0 Offset: 0x2FC7FA1 VA: 0x2FC7EA0
	|-ArraySortHelper<object, object>.IntroSort
	|
	|-RVA: 0x2FC9690 Offset: 0x2FC9791 VA: 0x2FC9690
	|-ArraySortHelper<ulong, object>.IntroSort
	*/

	// RVA: -1 Offset: -1
	private static int PickPivotAndPartition(TKey[] keys, TValue[] values, int lo, int hi, IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC8260 Offset: 0x2FC8361 VA: 0x2FC8260
	|-ArraySortHelper<object, object>.PickPivotAndPartition
	|
	|-RVA: 0x2FC9A50 Offset: 0x2FC9B51 VA: 0x2FC9A50
	|-ArraySortHelper<ulong, object>.PickPivotAndPartition
	*/

	// RVA: -1 Offset: -1
	private static void Heapsort(TKey[] keys, TValue[] values, int lo, int hi, IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC86E0 Offset: 0x2FC87E1 VA: 0x2FC86E0
	|-ArraySortHelper<object, object>.Heapsort
	|
	|-RVA: 0x2FC9ED0 Offset: 0x2FC9FD1 VA: 0x2FC9ED0
	|-ArraySortHelper<ulong, object>.Heapsort
	*/

	// RVA: -1 Offset: -1
	private static void DownHeap(TKey[] keys, TValue[] values, int i, int n, int lo, IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC8890 Offset: 0x2FC8991 VA: 0x2FC8890
	|-ArraySortHelper<object, object>.DownHeap
	|
	|-RVA: 0x2FCA080 Offset: 0x2FCA181 VA: 0x2FCA080
	|-ArraySortHelper<ulong, object>.DownHeap
	*/

	// RVA: -1 Offset: -1
	private static void InsertionSort(TKey[] keys, TValue[] values, int lo, int hi, IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC8C20 Offset: 0x2FC8D21 VA: 0x2FC8C20
	|-ArraySortHelper<object, object>.InsertionSort
	|
	|-RVA: 0x2FCA410 Offset: 0x2FCA511 VA: 0x2FCA410
	|-ArraySortHelper<ulong, object>.InsertionSort
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC8EA0 Offset: 0x2FC8FA1 VA: 0x2FC8EA0
	|-ArraySortHelper<object, object>..ctor
	|
	|-RVA: 0x2FCA690 Offset: 0x2FCA791 VA: 0x2FCA690
	|-ArraySortHelper<ulong, object>..ctor
	*/
}

internal class ArraySortHelper<TKey, TValue> // TypeDefIndex: 1420
{
	// Fields
	private static ArraySortHelper<TKey, TValue> s_defaultArraySortHelper; // 0x0

	// Properties
	public static ArraySortHelper<TKey, TValue> Default { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static ArraySortHelper<TKey, TValue> get_Default() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC7690 Offset: 0x2FC7791 VA: 0x2FC7690
	|-ArraySortHelper<object, object>.get_Default
	|
	|-RVA: 0x2FC8EC0 Offset: 0x2FC8FC1 VA: 0x2FC8EC0
	|-ArraySortHelper<ulong, object>.get_Default
	*/

	// RVA: -1 Offset: -1
	private static ArraySortHelper<TKey, TValue> CreateArraySortHelper() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC7770 Offset: 0x2FC7871 VA: 0x2FC7770
	|-ArraySortHelper<object, object>.CreateArraySortHelper
	|
	|-RVA: 0x2FC8FA0 Offset: 0x2FC90A1 VA: 0x2FC8FA0
	|-ArraySortHelper<ulong, object>.CreateArraySortHelper
	*/

	// RVA: -1 Offset: -1
	public void Sort(TKey[] keys, TValue[] values, int index, int length, IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC7890 Offset: 0x2FC7991 VA: 0x2FC7890
	|-ArraySortHelper<object, object>.Sort
	|
	|-RVA: 0x2FC90C0 Offset: 0x2FC91C1 VA: 0x2FC90C0
	|-ArraySortHelper<ulong, object>.Sort
	*/

	// RVA: -1 Offset: -1
	private static void SwapIfGreaterWithItems(TKey[] keys, TValue[] values, IComparer<TKey> comparer, int a, int b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC7A70 Offset: 0x2FC7B71 VA: 0x2FC7A70
	|-ArraySortHelper<object, object>.SwapIfGreaterWithItems
	|
	|-RVA: 0x2FC92A0 Offset: 0x2FC93A1 VA: 0x2FC92A0
	|-ArraySortHelper<ulong, object>.SwapIfGreaterWithItems
	*/

	// RVA: -1 Offset: -1
	private static void Swap(TKey[] keys, TValue[] values, int i, int j) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC7C90 Offset: 0x2FC7D91 VA: 0x2FC7C90
	|-ArraySortHelper<object, object>.Swap
	|
	|-RVA: 0x2FC94B0 Offset: 0x2FC95B1 VA: 0x2FC94B0
	|-ArraySortHelper<ulong, object>.Swap
	*/

	// RVA: -1 Offset: -1
	internal static void IntrospectiveSort(TKey[] keys, TValue[] values, int left, int length, IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC7DA0 Offset: 0x2FC7EA1 VA: 0x2FC7DA0
	|-ArraySortHelper<object, object>.IntrospectiveSort
	|
	|-RVA: 0x2FC9590 Offset: 0x2FC9691 VA: 0x2FC9590
	|-ArraySortHelper<ulong, object>.IntrospectiveSort
	*/

	// RVA: -1 Offset: -1
	private static void IntroSort(TKey[] keys, TValue[] values, int lo, int hi, int depthLimit, IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC7EA0 Offset: 0x2FC7FA1 VA: 0x2FC7EA0
	|-ArraySortHelper<object, object>.IntroSort
	|
	|-RVA: 0x2FC9690 Offset: 0x2FC9791 VA: 0x2FC9690
	|-ArraySortHelper<ulong, object>.IntroSort
	*/

	// RVA: -1 Offset: -1
	private static int PickPivotAndPartition(TKey[] keys, TValue[] values, int lo, int hi, IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC8260 Offset: 0x2FC8361 VA: 0x2FC8260
	|-ArraySortHelper<object, object>.PickPivotAndPartition
	|
	|-RVA: 0x2FC9A50 Offset: 0x2FC9B51 VA: 0x2FC9A50
	|-ArraySortHelper<ulong, object>.PickPivotAndPartition
	*/

	// RVA: -1 Offset: -1
	private static void Heapsort(TKey[] keys, TValue[] values, int lo, int hi, IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC86E0 Offset: 0x2FC87E1 VA: 0x2FC86E0
	|-ArraySortHelper<object, object>.Heapsort
	|
	|-RVA: 0x2FC9ED0 Offset: 0x2FC9FD1 VA: 0x2FC9ED0
	|-ArraySortHelper<ulong, object>.Heapsort
	*/

	// RVA: -1 Offset: -1
	private static void DownHeap(TKey[] keys, TValue[] values, int i, int n, int lo, IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC8890 Offset: 0x2FC8991 VA: 0x2FC8890
	|-ArraySortHelper<object, object>.DownHeap
	|
	|-RVA: 0x2FCA080 Offset: 0x2FCA181 VA: 0x2FCA080
	|-ArraySortHelper<ulong, object>.DownHeap
	*/

	// RVA: -1 Offset: -1
	private static void InsertionSort(TKey[] keys, TValue[] values, int lo, int hi, IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC8C20 Offset: 0x2FC8D21 VA: 0x2FC8C20
	|-ArraySortHelper<object, object>.InsertionSort
	|
	|-RVA: 0x2FCA410 Offset: 0x2FCA511 VA: 0x2FCA410
	|-ArraySortHelper<ulong, object>.InsertionSort
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC8EA0 Offset: 0x2FC8FA1 VA: 0x2FC8EA0
	|-ArraySortHelper<object, object>..ctor
	|
	|-RVA: 0x2FCA690 Offset: 0x2FCA791 VA: 0x2FCA690
	|-ArraySortHelper<ulong, object>..ctor
	*/
}

internal class ArraySortHelper<TKey, TValue> // TypeDefIndex: 1420
{
	// Fields
	private static ArraySortHelper<TKey, TValue> s_defaultArraySortHelper; // 0x0

	// Properties
	public static ArraySortHelper<TKey, TValue> Default { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static ArraySortHelper<TKey, TValue> get_Default() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC7690 Offset: 0x2FC7791 VA: 0x2FC7690
	|-ArraySortHelper<object, object>.get_Default
	|
	|-RVA: 0x2FC8EC0 Offset: 0x2FC8FC1 VA: 0x2FC8EC0
	|-ArraySortHelper<ulong, object>.get_Default
	*/

	// RVA: -1 Offset: -1
	private static ArraySortHelper<TKey, TValue> CreateArraySortHelper() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC7770 Offset: 0x2FC7871 VA: 0x2FC7770
	|-ArraySortHelper<object, object>.CreateArraySortHelper
	|
	|-RVA: 0x2FC8FA0 Offset: 0x2FC90A1 VA: 0x2FC8FA0
	|-ArraySortHelper<ulong, object>.CreateArraySortHelper
	*/

	// RVA: -1 Offset: -1
	public void Sort(TKey[] keys, TValue[] values, int index, int length, IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC7890 Offset: 0x2FC7991 VA: 0x2FC7890
	|-ArraySortHelper<object, object>.Sort
	|
	|-RVA: 0x2FC90C0 Offset: 0x2FC91C1 VA: 0x2FC90C0
	|-ArraySortHelper<ulong, object>.Sort
	*/

	// RVA: -1 Offset: -1
	private static void SwapIfGreaterWithItems(TKey[] keys, TValue[] values, IComparer<TKey> comparer, int a, int b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC7A70 Offset: 0x2FC7B71 VA: 0x2FC7A70
	|-ArraySortHelper<object, object>.SwapIfGreaterWithItems
	|
	|-RVA: 0x2FC92A0 Offset: 0x2FC93A1 VA: 0x2FC92A0
	|-ArraySortHelper<ulong, object>.SwapIfGreaterWithItems
	*/

	// RVA: -1 Offset: -1
	private static void Swap(TKey[] keys, TValue[] values, int i, int j) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC7C90 Offset: 0x2FC7D91 VA: 0x2FC7C90
	|-ArraySortHelper<object, object>.Swap
	|
	|-RVA: 0x2FC94B0 Offset: 0x2FC95B1 VA: 0x2FC94B0
	|-ArraySortHelper<ulong, object>.Swap
	*/

	// RVA: -1 Offset: -1
	internal static void IntrospectiveSort(TKey[] keys, TValue[] values, int left, int length, IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC7DA0 Offset: 0x2FC7EA1 VA: 0x2FC7DA0
	|-ArraySortHelper<object, object>.IntrospectiveSort
	|
	|-RVA: 0x2FC9590 Offset: 0x2FC9691 VA: 0x2FC9590
	|-ArraySortHelper<ulong, object>.IntrospectiveSort
	*/

	// RVA: -1 Offset: -1
	private static void IntroSort(TKey[] keys, TValue[] values, int lo, int hi, int depthLimit, IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC7EA0 Offset: 0x2FC7FA1 VA: 0x2FC7EA0
	|-ArraySortHelper<object, object>.IntroSort
	|
	|-RVA: 0x2FC9690 Offset: 0x2FC9791 VA: 0x2FC9690
	|-ArraySortHelper<ulong, object>.IntroSort
	*/

	// RVA: -1 Offset: -1
	private static int PickPivotAndPartition(TKey[] keys, TValue[] values, int lo, int hi, IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC8260 Offset: 0x2FC8361 VA: 0x2FC8260
	|-ArraySortHelper<object, object>.PickPivotAndPartition
	|
	|-RVA: 0x2FC9A50 Offset: 0x2FC9B51 VA: 0x2FC9A50
	|-ArraySortHelper<ulong, object>.PickPivotAndPartition
	*/

	// RVA: -1 Offset: -1
	private static void Heapsort(TKey[] keys, TValue[] values, int lo, int hi, IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC86E0 Offset: 0x2FC87E1 VA: 0x2FC86E0
	|-ArraySortHelper<object, object>.Heapsort
	|
	|-RVA: 0x2FC9ED0 Offset: 0x2FC9FD1 VA: 0x2FC9ED0
	|-ArraySortHelper<ulong, object>.Heapsort
	*/

	// RVA: -1 Offset: -1
	private static void DownHeap(TKey[] keys, TValue[] values, int i, int n, int lo, IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC8890 Offset: 0x2FC8991 VA: 0x2FC8890
	|-ArraySortHelper<object, object>.DownHeap
	|
	|-RVA: 0x2FCA080 Offset: 0x2FCA181 VA: 0x2FCA080
	|-ArraySortHelper<ulong, object>.DownHeap
	*/

	// RVA: -1 Offset: -1
	private static void InsertionSort(TKey[] keys, TValue[] values, int lo, int hi, IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC8C20 Offset: 0x2FC8D21 VA: 0x2FC8C20
	|-ArraySortHelper<object, object>.InsertionSort
	|
	|-RVA: 0x2FCA410 Offset: 0x2FCA511 VA: 0x2FCA410
	|-ArraySortHelper<ulong, object>.InsertionSort
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC8EA0 Offset: 0x2FC8FA1 VA: 0x2FC8EA0
	|-ArraySortHelper<object, object>..ctor
	|
	|-RVA: 0x2FCA690 Offset: 0x2FCA791 VA: 0x2FCA690
	|-ArraySortHelper<ulong, object>..ctor
	*/
}

internal class ArraySortHelper<TKey, TValue> // TypeDefIndex: 1420
{
	// Fields
	private static ArraySortHelper<TKey, TValue> s_defaultArraySortHelper; // 0x0

	// Properties
	public static ArraySortHelper<TKey, TValue> Default { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static ArraySortHelper<TKey, TValue> get_Default() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC7690 Offset: 0x2FC7791 VA: 0x2FC7690
	|-ArraySortHelper<object, object>.get_Default
	|
	|-RVA: 0x2FC8EC0 Offset: 0x2FC8FC1 VA: 0x2FC8EC0
	|-ArraySortHelper<ulong, object>.get_Default
	*/

	// RVA: -1 Offset: -1
	private static ArraySortHelper<TKey, TValue> CreateArraySortHelper() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC7770 Offset: 0x2FC7871 VA: 0x2FC7770
	|-ArraySortHelper<object, object>.CreateArraySortHelper
	|
	|-RVA: 0x2FC8FA0 Offset: 0x2FC90A1 VA: 0x2FC8FA0
	|-ArraySortHelper<ulong, object>.CreateArraySortHelper
	*/

	// RVA: -1 Offset: -1
	public void Sort(TKey[] keys, TValue[] values, int index, int length, IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC7890 Offset: 0x2FC7991 VA: 0x2FC7890
	|-ArraySortHelper<object, object>.Sort
	|
	|-RVA: 0x2FC90C0 Offset: 0x2FC91C1 VA: 0x2FC90C0
	|-ArraySortHelper<ulong, object>.Sort
	*/

	// RVA: -1 Offset: -1
	private static void SwapIfGreaterWithItems(TKey[] keys, TValue[] values, IComparer<TKey> comparer, int a, int b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC7A70 Offset: 0x2FC7B71 VA: 0x2FC7A70
	|-ArraySortHelper<object, object>.SwapIfGreaterWithItems
	|
	|-RVA: 0x2FC92A0 Offset: 0x2FC93A1 VA: 0x2FC92A0
	|-ArraySortHelper<ulong, object>.SwapIfGreaterWithItems
	*/

	// RVA: -1 Offset: -1
	private static void Swap(TKey[] keys, TValue[] values, int i, int j) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC7C90 Offset: 0x2FC7D91 VA: 0x2FC7C90
	|-ArraySortHelper<object, object>.Swap
	|
	|-RVA: 0x2FC94B0 Offset: 0x2FC95B1 VA: 0x2FC94B0
	|-ArraySortHelper<ulong, object>.Swap
	*/

	// RVA: -1 Offset: -1
	internal static void IntrospectiveSort(TKey[] keys, TValue[] values, int left, int length, IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC7DA0 Offset: 0x2FC7EA1 VA: 0x2FC7DA0
	|-ArraySortHelper<object, object>.IntrospectiveSort
	|
	|-RVA: 0x2FC9590 Offset: 0x2FC9691 VA: 0x2FC9590
	|-ArraySortHelper<ulong, object>.IntrospectiveSort
	*/

	// RVA: -1 Offset: -1
	private static void IntroSort(TKey[] keys, TValue[] values, int lo, int hi, int depthLimit, IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC7EA0 Offset: 0x2FC7FA1 VA: 0x2FC7EA0
	|-ArraySortHelper<object, object>.IntroSort
	|
	|-RVA: 0x2FC9690 Offset: 0x2FC9791 VA: 0x2FC9690
	|-ArraySortHelper<ulong, object>.IntroSort
	*/

	// RVA: -1 Offset: -1
	private static int PickPivotAndPartition(TKey[] keys, TValue[] values, int lo, int hi, IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC8260 Offset: 0x2FC8361 VA: 0x2FC8260
	|-ArraySortHelper<object, object>.PickPivotAndPartition
	|
	|-RVA: 0x2FC9A50 Offset: 0x2FC9B51 VA: 0x2FC9A50
	|-ArraySortHelper<ulong, object>.PickPivotAndPartition
	*/

	// RVA: -1 Offset: -1
	private static void Heapsort(TKey[] keys, TValue[] values, int lo, int hi, IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC86E0 Offset: 0x2FC87E1 VA: 0x2FC86E0
	|-ArraySortHelper<object, object>.Heapsort
	|
	|-RVA: 0x2FC9ED0 Offset: 0x2FC9FD1 VA: 0x2FC9ED0
	|-ArraySortHelper<ulong, object>.Heapsort
	*/

	// RVA: -1 Offset: -1
	private static void DownHeap(TKey[] keys, TValue[] values, int i, int n, int lo, IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC8890 Offset: 0x2FC8991 VA: 0x2FC8890
	|-ArraySortHelper<object, object>.DownHeap
	|
	|-RVA: 0x2FCA080 Offset: 0x2FCA181 VA: 0x2FCA080
	|-ArraySortHelper<ulong, object>.DownHeap
	*/

	// RVA: -1 Offset: -1
	private static void InsertionSort(TKey[] keys, TValue[] values, int lo, int hi, IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC8C20 Offset: 0x2FC8D21 VA: 0x2FC8C20
	|-ArraySortHelper<object, object>.InsertionSort
	|
	|-RVA: 0x2FCA410 Offset: 0x2FCA511 VA: 0x2FCA410
	|-ArraySortHelper<ulong, object>.InsertionSort
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC8EA0 Offset: 0x2FC8FA1 VA: 0x2FC8EA0
	|-ArraySortHelper<object, object>..ctor
	|
	|-RVA: 0x2FCA690 Offset: 0x2FCA791 VA: 0x2FCA690
	|-ArraySortHelper<ulong, object>..ctor
	*/
}

internal class ArraySortHelper<TKey, TValue> // TypeDefIndex: 1420
{
	// Fields
	private static ArraySortHelper<TKey, TValue> s_defaultArraySortHelper; // 0x0

	// Properties
	public static ArraySortHelper<TKey, TValue> Default { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static ArraySortHelper<TKey, TValue> get_Default() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC7690 Offset: 0x2FC7791 VA: 0x2FC7690
	|-ArraySortHelper<object, object>.get_Default
	|
	|-RVA: 0x2FC8EC0 Offset: 0x2FC8FC1 VA: 0x2FC8EC0
	|-ArraySortHelper<ulong, object>.get_Default
	*/

	// RVA: -1 Offset: -1
	private static ArraySortHelper<TKey, TValue> CreateArraySortHelper() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC7770 Offset: 0x2FC7871 VA: 0x2FC7770
	|-ArraySortHelper<object, object>.CreateArraySortHelper
	|
	|-RVA: 0x2FC8FA0 Offset: 0x2FC90A1 VA: 0x2FC8FA0
	|-ArraySortHelper<ulong, object>.CreateArraySortHelper
	*/

	// RVA: -1 Offset: -1
	public void Sort(TKey[] keys, TValue[] values, int index, int length, IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC7890 Offset: 0x2FC7991 VA: 0x2FC7890
	|-ArraySortHelper<object, object>.Sort
	|
	|-RVA: 0x2FC90C0 Offset: 0x2FC91C1 VA: 0x2FC90C0
	|-ArraySortHelper<ulong, object>.Sort
	*/

	// RVA: -1 Offset: -1
	private static void SwapIfGreaterWithItems(TKey[] keys, TValue[] values, IComparer<TKey> comparer, int a, int b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC7A70 Offset: 0x2FC7B71 VA: 0x2FC7A70
	|-ArraySortHelper<object, object>.SwapIfGreaterWithItems
	|
	|-RVA: 0x2FC92A0 Offset: 0x2FC93A1 VA: 0x2FC92A0
	|-ArraySortHelper<ulong, object>.SwapIfGreaterWithItems
	*/

	// RVA: -1 Offset: -1
	private static void Swap(TKey[] keys, TValue[] values, int i, int j) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC7C90 Offset: 0x2FC7D91 VA: 0x2FC7C90
	|-ArraySortHelper<object, object>.Swap
	|
	|-RVA: 0x2FC94B0 Offset: 0x2FC95B1 VA: 0x2FC94B0
	|-ArraySortHelper<ulong, object>.Swap
	*/

	// RVA: -1 Offset: -1
	internal static void IntrospectiveSort(TKey[] keys, TValue[] values, int left, int length, IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC7DA0 Offset: 0x2FC7EA1 VA: 0x2FC7DA0
	|-ArraySortHelper<object, object>.IntrospectiveSort
	|
	|-RVA: 0x2FC9590 Offset: 0x2FC9691 VA: 0x2FC9590
	|-ArraySortHelper<ulong, object>.IntrospectiveSort
	*/

	// RVA: -1 Offset: -1
	private static void IntroSort(TKey[] keys, TValue[] values, int lo, int hi, int depthLimit, IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC7EA0 Offset: 0x2FC7FA1 VA: 0x2FC7EA0
	|-ArraySortHelper<object, object>.IntroSort
	|
	|-RVA: 0x2FC9690 Offset: 0x2FC9791 VA: 0x2FC9690
	|-ArraySortHelper<ulong, object>.IntroSort
	*/

	// RVA: -1 Offset: -1
	private static int PickPivotAndPartition(TKey[] keys, TValue[] values, int lo, int hi, IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC8260 Offset: 0x2FC8361 VA: 0x2FC8260
	|-ArraySortHelper<object, object>.PickPivotAndPartition
	|
	|-RVA: 0x2FC9A50 Offset: 0x2FC9B51 VA: 0x2FC9A50
	|-ArraySortHelper<ulong, object>.PickPivotAndPartition
	*/

	// RVA: -1 Offset: -1
	private static void Heapsort(TKey[] keys, TValue[] values, int lo, int hi, IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC86E0 Offset: 0x2FC87E1 VA: 0x2FC86E0
	|-ArraySortHelper<object, object>.Heapsort
	|
	|-RVA: 0x2FC9ED0 Offset: 0x2FC9FD1 VA: 0x2FC9ED0
	|-ArraySortHelper<ulong, object>.Heapsort
	*/

	// RVA: -1 Offset: -1
	private static void DownHeap(TKey[] keys, TValue[] values, int i, int n, int lo, IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC8890 Offset: 0x2FC8991 VA: 0x2FC8890
	|-ArraySortHelper<object, object>.DownHeap
	|
	|-RVA: 0x2FCA080 Offset: 0x2FCA181 VA: 0x2FCA080
	|-ArraySortHelper<ulong, object>.DownHeap
	*/

	// RVA: -1 Offset: -1
	private static void InsertionSort(TKey[] keys, TValue[] values, int lo, int hi, IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC8C20 Offset: 0x2FC8D21 VA: 0x2FC8C20
	|-ArraySortHelper<object, object>.InsertionSort
	|
	|-RVA: 0x2FCA410 Offset: 0x2FCA511 VA: 0x2FCA410
	|-ArraySortHelper<ulong, object>.InsertionSort
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC8EA0 Offset: 0x2FC8FA1 VA: 0x2FC8EA0
	|-ArraySortHelper<object, object>..ctor
	|
	|-RVA: 0x2FCA690 Offset: 0x2FCA791 VA: 0x2FCA690
	|-ArraySortHelper<ulong, object>..ctor
	*/
}

internal class ArraySortHelper<TKey, TValue> // TypeDefIndex: 1420
{
	// Fields
	private static ArraySortHelper<TKey, TValue> s_defaultArraySortHelper; // 0x0

	// Properties
	public static ArraySortHelper<TKey, TValue> Default { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static ArraySortHelper<TKey, TValue> get_Default() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC7690 Offset: 0x2FC7791 VA: 0x2FC7690
	|-ArraySortHelper<object, object>.get_Default
	|
	|-RVA: 0x2FC8EC0 Offset: 0x2FC8FC1 VA: 0x2FC8EC0
	|-ArraySortHelper<ulong, object>.get_Default
	*/

	// RVA: -1 Offset: -1
	private static ArraySortHelper<TKey, TValue> CreateArraySortHelper() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC7770 Offset: 0x2FC7871 VA: 0x2FC7770
	|-ArraySortHelper<object, object>.CreateArraySortHelper
	|
	|-RVA: 0x2FC8FA0 Offset: 0x2FC90A1 VA: 0x2FC8FA0
	|-ArraySortHelper<ulong, object>.CreateArraySortHelper
	*/

	// RVA: -1 Offset: -1
	public void Sort(TKey[] keys, TValue[] values, int index, int length, IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC7890 Offset: 0x2FC7991 VA: 0x2FC7890
	|-ArraySortHelper<object, object>.Sort
	|
	|-RVA: 0x2FC90C0 Offset: 0x2FC91C1 VA: 0x2FC90C0
	|-ArraySortHelper<ulong, object>.Sort
	*/

	// RVA: -1 Offset: -1
	private static void SwapIfGreaterWithItems(TKey[] keys, TValue[] values, IComparer<TKey> comparer, int a, int b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC7A70 Offset: 0x2FC7B71 VA: 0x2FC7A70
	|-ArraySortHelper<object, object>.SwapIfGreaterWithItems
	|
	|-RVA: 0x2FC92A0 Offset: 0x2FC93A1 VA: 0x2FC92A0
	|-ArraySortHelper<ulong, object>.SwapIfGreaterWithItems
	*/

	// RVA: -1 Offset: -1
	private static void Swap(TKey[] keys, TValue[] values, int i, int j) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC7C90 Offset: 0x2FC7D91 VA: 0x2FC7C90
	|-ArraySortHelper<object, object>.Swap
	|
	|-RVA: 0x2FC94B0 Offset: 0x2FC95B1 VA: 0x2FC94B0
	|-ArraySortHelper<ulong, object>.Swap
	*/

	// RVA: -1 Offset: -1
	internal static void IntrospectiveSort(TKey[] keys, TValue[] values, int left, int length, IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC7DA0 Offset: 0x2FC7EA1 VA: 0x2FC7DA0
	|-ArraySortHelper<object, object>.IntrospectiveSort
	|
	|-RVA: 0x2FC9590 Offset: 0x2FC9691 VA: 0x2FC9590
	|-ArraySortHelper<ulong, object>.IntrospectiveSort
	*/

	// RVA: -1 Offset: -1
	private static void IntroSort(TKey[] keys, TValue[] values, int lo, int hi, int depthLimit, IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC7EA0 Offset: 0x2FC7FA1 VA: 0x2FC7EA0
	|-ArraySortHelper<object, object>.IntroSort
	|
	|-RVA: 0x2FC9690 Offset: 0x2FC9791 VA: 0x2FC9690
	|-ArraySortHelper<ulong, object>.IntroSort
	*/

	// RVA: -1 Offset: -1
	private static int PickPivotAndPartition(TKey[] keys, TValue[] values, int lo, int hi, IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC8260 Offset: 0x2FC8361 VA: 0x2FC8260
	|-ArraySortHelper<object, object>.PickPivotAndPartition
	|
	|-RVA: 0x2FC9A50 Offset: 0x2FC9B51 VA: 0x2FC9A50
	|-ArraySortHelper<ulong, object>.PickPivotAndPartition
	*/

	// RVA: -1 Offset: -1
	private static void Heapsort(TKey[] keys, TValue[] values, int lo, int hi, IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC86E0 Offset: 0x2FC87E1 VA: 0x2FC86E0
	|-ArraySortHelper<object, object>.Heapsort
	|
	|-RVA: 0x2FC9ED0 Offset: 0x2FC9FD1 VA: 0x2FC9ED0
	|-ArraySortHelper<ulong, object>.Heapsort
	*/

	// RVA: -1 Offset: -1
	private static void DownHeap(TKey[] keys, TValue[] values, int i, int n, int lo, IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC8890 Offset: 0x2FC8991 VA: 0x2FC8890
	|-ArraySortHelper<object, object>.DownHeap
	|
	|-RVA: 0x2FCA080 Offset: 0x2FCA181 VA: 0x2FCA080
	|-ArraySortHelper<ulong, object>.DownHeap
	*/

	// RVA: -1 Offset: -1
	private static void InsertionSort(TKey[] keys, TValue[] values, int lo, int hi, IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC8C20 Offset: 0x2FC8D21 VA: 0x2FC8C20
	|-ArraySortHelper<object, object>.InsertionSort
	|
	|-RVA: 0x2FCA410 Offset: 0x2FCA511 VA: 0x2FCA410
	|-ArraySortHelper<ulong, object>.InsertionSort
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC8EA0 Offset: 0x2FC8FA1 VA: 0x2FC8EA0
	|-ArraySortHelper<object, object>..ctor
	|
	|-RVA: 0x2FCA690 Offset: 0x2FCA791 VA: 0x2FCA690
	|-ArraySortHelper<ulong, object>..ctor
	*/
}

internal class ArraySortHelper<TKey, TValue> // TypeDefIndex: 1420
{
	// Fields
	private static ArraySortHelper<TKey, TValue> s_defaultArraySortHelper; // 0x0

	// Properties
	public static ArraySortHelper<TKey, TValue> Default { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static ArraySortHelper<TKey, TValue> get_Default() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC7690 Offset: 0x2FC7791 VA: 0x2FC7690
	|-ArraySortHelper<object, object>.get_Default
	|
	|-RVA: 0x2FC8EC0 Offset: 0x2FC8FC1 VA: 0x2FC8EC0
	|-ArraySortHelper<ulong, object>.get_Default
	*/

	// RVA: -1 Offset: -1
	private static ArraySortHelper<TKey, TValue> CreateArraySortHelper() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC7770 Offset: 0x2FC7871 VA: 0x2FC7770
	|-ArraySortHelper<object, object>.CreateArraySortHelper
	|
	|-RVA: 0x2FC8FA0 Offset: 0x2FC90A1 VA: 0x2FC8FA0
	|-ArraySortHelper<ulong, object>.CreateArraySortHelper
	*/

	// RVA: -1 Offset: -1
	public void Sort(TKey[] keys, TValue[] values, int index, int length, IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC7890 Offset: 0x2FC7991 VA: 0x2FC7890
	|-ArraySortHelper<object, object>.Sort
	|
	|-RVA: 0x2FC90C0 Offset: 0x2FC91C1 VA: 0x2FC90C0
	|-ArraySortHelper<ulong, object>.Sort
	*/

	// RVA: -1 Offset: -1
	private static void SwapIfGreaterWithItems(TKey[] keys, TValue[] values, IComparer<TKey> comparer, int a, int b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC7A70 Offset: 0x2FC7B71 VA: 0x2FC7A70
	|-ArraySortHelper<object, object>.SwapIfGreaterWithItems
	|
	|-RVA: 0x2FC92A0 Offset: 0x2FC93A1 VA: 0x2FC92A0
	|-ArraySortHelper<ulong, object>.SwapIfGreaterWithItems
	*/

	// RVA: -1 Offset: -1
	private static void Swap(TKey[] keys, TValue[] values, int i, int j) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC7C90 Offset: 0x2FC7D91 VA: 0x2FC7C90
	|-ArraySortHelper<object, object>.Swap
	|
	|-RVA: 0x2FC94B0 Offset: 0x2FC95B1 VA: 0x2FC94B0
	|-ArraySortHelper<ulong, object>.Swap
	*/

	// RVA: -1 Offset: -1
	internal static void IntrospectiveSort(TKey[] keys, TValue[] values, int left, int length, IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC7DA0 Offset: 0x2FC7EA1 VA: 0x2FC7DA0
	|-ArraySortHelper<object, object>.IntrospectiveSort
	|
	|-RVA: 0x2FC9590 Offset: 0x2FC9691 VA: 0x2FC9590
	|-ArraySortHelper<ulong, object>.IntrospectiveSort
	*/

	// RVA: -1 Offset: -1
	private static void IntroSort(TKey[] keys, TValue[] values, int lo, int hi, int depthLimit, IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC7EA0 Offset: 0x2FC7FA1 VA: 0x2FC7EA0
	|-ArraySortHelper<object, object>.IntroSort
	|
	|-RVA: 0x2FC9690 Offset: 0x2FC9791 VA: 0x2FC9690
	|-ArraySortHelper<ulong, object>.IntroSort
	*/

	// RVA: -1 Offset: -1
	private static int PickPivotAndPartition(TKey[] keys, TValue[] values, int lo, int hi, IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC8260 Offset: 0x2FC8361 VA: 0x2FC8260
	|-ArraySortHelper<object, object>.PickPivotAndPartition
	|
	|-RVA: 0x2FC9A50 Offset: 0x2FC9B51 VA: 0x2FC9A50
	|-ArraySortHelper<ulong, object>.PickPivotAndPartition
	*/

	// RVA: -1 Offset: -1
	private static void Heapsort(TKey[] keys, TValue[] values, int lo, int hi, IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC86E0 Offset: 0x2FC87E1 VA: 0x2FC86E0
	|-ArraySortHelper<object, object>.Heapsort
	|
	|-RVA: 0x2FC9ED0 Offset: 0x2FC9FD1 VA: 0x2FC9ED0
	|-ArraySortHelper<ulong, object>.Heapsort
	*/

	// RVA: -1 Offset: -1
	private static void DownHeap(TKey[] keys, TValue[] values, int i, int n, int lo, IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC8890 Offset: 0x2FC8991 VA: 0x2FC8890
	|-ArraySortHelper<object, object>.DownHeap
	|
	|-RVA: 0x2FCA080 Offset: 0x2FCA181 VA: 0x2FCA080
	|-ArraySortHelper<ulong, object>.DownHeap
	*/

	// RVA: -1 Offset: -1
	private static void InsertionSort(TKey[] keys, TValue[] values, int lo, int hi, IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC8C20 Offset: 0x2FC8D21 VA: 0x2FC8C20
	|-ArraySortHelper<object, object>.InsertionSort
	|
	|-RVA: 0x2FCA410 Offset: 0x2FCA511 VA: 0x2FCA410
	|-ArraySortHelper<ulong, object>.InsertionSort
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC8EA0 Offset: 0x2FC8FA1 VA: 0x2FC8EA0
	|-ArraySortHelper<object, object>..ctor
	|
	|-RVA: 0x2FCA690 Offset: 0x2FCA791 VA: 0x2FCA690
	|-ArraySortHelper<ulong, object>..ctor
	*/
}

