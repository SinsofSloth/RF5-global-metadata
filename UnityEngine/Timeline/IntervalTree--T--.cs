internal class IntervalTree<T> // TypeDefIndex: 4580
{
	// Fields
	private const int kMinNodeSize = 10;
	private const int kInvalidNode = -1;
	private const long kCenterUnknown = 9223372036854775807;
	private readonly List<IntervalTree.Entry<T>> m_Entries; // 0x0
	private readonly List<IntervalTreeNode> m_Nodes; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x12BB70 Offset: 0x12BC71 VA: 0x12BB70
	private bool <dirty>k__BackingField; // 0x0

	// Properties
	public bool dirty { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x12C310 Offset: 0x12C411 VA: 0x12C310
	// RVA: -1 Offset: -1
	public bool get_dirty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA88D0 Offset: 0x2AA89D1 VA: 0x2AA88D0
	|-IntervalTree<object>.get_dirty
	*/

	[CompilerGeneratedAttribute] // RVA: 0x12C320 Offset: 0x12C421 VA: 0x12C320
	// RVA: -1 Offset: -1
	internal void set_dirty(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA88E0 Offset: 0x2AA89E1 VA: 0x2AA88E0
	|-IntervalTree<object>.set_dirty
	*/

	// RVA: -1 Offset: -1
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA88F0 Offset: 0x2AA89F1 VA: 0x2AA88F0
	|-IntervalTree<object>.Add
	|-IntervalTree<RuntimeElement>.Add
	*/

	// RVA: -1 Offset: -1
	public void IntersectsWith(long value, List<T> results) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA8AC0 Offset: 0x2AA8BC1 VA: 0x2AA8AC0
	|-IntervalTree<object>.IntersectsWith
	|-IntervalTree<RuntimeElement>.IntersectsWith
	*/

	// RVA: -1 Offset: -1
	public void IntersectsWithRange(long start, long end, List<T> results) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA8C00 Offset: 0x2AA8D01 VA: 0x2AA8C00
	|-IntervalTree<object>.IntersectsWithRange
	*/

	// RVA: -1 Offset: -1
	public void UpdateIntervals() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA8D50 Offset: 0x2AA8E51 VA: 0x2AA8D50
	|-IntervalTree<object>.UpdateIntervals
	*/

	// RVA: -1 Offset: -1
	private void Query(IntervalTreeNode intervalTreeNode, long value, List<T> results) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA8FD0 Offset: 0x2AA90D1 VA: 0x2AA8FD0
	|-IntervalTree<object>.Query
	*/

	// RVA: -1 Offset: -1
	private void QueryRange(IntervalTreeNode intervalTreeNode, long start, long end, List<T> results) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA9220 Offset: 0x2AA9321 VA: 0x2AA9220
	|-IntervalTree<object>.QueryRange
	*/

	// RVA: -1 Offset: -1
	private void Rebuild() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA9480 Offset: 0x2AA9581 VA: 0x2AA9480
	|-IntervalTree<object>.Rebuild
	*/

	// RVA: -1 Offset: -1
	private int Rebuild(int start, int end) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA9560 Offset: 0x2AA9661 VA: 0x2AA9560
	|-IntervalTree<object>.Rebuild
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA9B10 Offset: 0x2AA9C11 VA: 0x2AA9B10
	|-IntervalTree<object>.Clear
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA9B90 Offset: 0x2AA9C91 VA: 0x2AA9B90
	|-IntervalTree<object>..ctor
	|-IntervalTree<RuntimeElement>..ctor
	*/
}

