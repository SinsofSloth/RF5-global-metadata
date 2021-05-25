[DefaultMemberAttribute] // RVA: 0x15A990 Offset: 0x15AA91 VA: 0x15A990
public struct ClusteringProcessorState.ClusteringDataArray16 : IList<ClusteringData>, ICollection<ClusteringData>, IEnumerable<ClusteringData>, IEnumerable // TypeDefIndex: 11490
{
	// Fields
	private const int _Length = 16;
	private ClusteringData _value0; // 0x0
	private ClusteringData _value1; // 0x18
	private ClusteringData _value2; // 0x30
	private ClusteringData _value3; // 0x48
	private ClusteringData _value4; // 0x60
	private ClusteringData _value5; // 0x78
	private ClusteringData _value6; // 0x90
	private ClusteringData _value7; // 0xA8
	private ClusteringData _value8; // 0xC0
	private ClusteringData _value9; // 0xD8
	private ClusteringData _value10; // 0xF0
	private ClusteringData _value11; // 0x108
	private ClusteringData _value12; // 0x120
	private ClusteringData _value13; // 0x138
	private ClusteringData _value14; // 0x150
	private ClusteringData _value15; // 0x168

	// Properties
	public int Length { get; }
	public ClusteringData Item { get; set; }
	public int Count { get; }
	public bool IsReadOnly { get; }

	// Methods

	// RVA: 0x38ADA0 Offset: 0x38AEA1 VA: 0x38ADA0
	public int get_Length() { }

	// RVA: 0x38ADB0 Offset: 0x38AEB1 VA: 0x38ADB0 Slot: 4
	public ClusteringData get_Item(int index) { }

	// RVA: 0x38ADC0 Offset: 0x38AEC1 VA: 0x38ADC0 Slot: 5
	public void set_Item(int index, ClusteringData value) { }

	// RVA: 0x38AE00 Offset: 0x38AF01 VA: 0x38AE00 Slot: 9
	public int get_Count() { }

	// RVA: 0x38AE10 Offset: 0x38AF11 VA: 0x38AE10 Slot: 10
	public bool get_IsReadOnly() { }

	// RVA: 0x38AE20 Offset: 0x38AF21 VA: 0x38AE20 Slot: 13
	public bool Contains(ClusteringData item) { }

	// RVA: 0x38AEF0 Offset: 0x38AFF1 VA: 0x38AEF0 Slot: 6
	public int IndexOf(ClusteringData item) { }

	// RVA: 0x38AFC0 Offset: 0x38B0C1 VA: 0x38AFC0 Slot: 14
	public void CopyTo(ClusteringData[] array, int arrayIndex) { }

	// RVA: 0x38AFD0 Offset: 0x38B0D1 VA: 0x38AFD0 Slot: 3
	public override string ToString() { }

	[IteratorStateMachineAttribute] // RVA: 0x1B7110 Offset: 0x1B7211 VA: 0x1B7110
	// RVA: 0x38AFE0 Offset: 0x38B0E1 VA: 0x38AFE0 Slot: 16
	public IEnumerator<ClusteringData> GetEnumerator() { }

	// RVA: 0x38B080 Offset: 0x38B181 VA: 0x38B080 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x38B120 Offset: 0x38B221 VA: 0x38B120 Slot: 11
	public void Add(ClusteringData item) { }

	// RVA: 0x38B130 Offset: 0x38B231 VA: 0x38B130 Slot: 12
	public void Clear() { }

	// RVA: 0x38B140 Offset: 0x38B241 VA: 0x38B140 Slot: 7
	public void Insert(int index, ClusteringData item) { }

	// RVA: 0x38B150 Offset: 0x38B251 VA: 0x38B150 Slot: 15
	public bool Remove(ClusteringData item) { }

	// RVA: 0x38B160 Offset: 0x38B261 VA: 0x38B160 Slot: 8
	public void RemoveAt(int index) { }
}

