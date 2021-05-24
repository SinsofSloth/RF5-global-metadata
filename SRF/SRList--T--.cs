[DefaultMemberAttribute] // RVA: 0x126D20 Offset: 0x126E21 VA: 0x126D20
[Serializable]
public class SRList<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, ISerializationCallbackReceiver // TypeDefIndex: 4296
{
	// Fields
	[SerializeField] // RVA: 0x127860 Offset: 0x127961 VA: 0x127860
	private T[] _buffer; // 0x0
	[SerializeField] // RVA: 0x127870 Offset: 0x127971 VA: 0x127870
	private int _count; // 0x0
	private EqualityComparer<T> _equalityComparer; // 0x0
	private ReadOnlyCollection<T> _readOnlyWrapper; // 0x0

	// Properties
	public T[] Buffer { get; set; }
	private EqualityComparer<T> EqualityComparer { get; }
	public int Count { get; set; }
	public bool IsReadOnly { get; }
	public T Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAB1E0 Offset: 0x2CAB2E1 VA: 0x2CAB1E0
	|-SRList<SRTab>..ctor
	|-SRList<SRServiceManager.Service>..ctor
	|-SRList<VirtualVerticalLayoutGroup.Row>..ctor
	|-SRList<object>..ctor
	|
	|-RVA: 0x2CA9790 Offset: 0x2CA9891 VA: 0x2CA9790
	|-SRList<int>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA97B0 Offset: 0x2CA98B1 VA: 0x2CA97B0
	|-SRList<int>..ctor
	|
	|-RVA: 0x2CAB200 Offset: 0x2CAB301 VA: 0x2CAB200
	|-SRList<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IEnumerable<T> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA9830 Offset: 0x2CA9931 VA: 0x2CA9830
	|-SRList<int>..ctor
	|
	|-RVA: 0x2CAB280 Offset: 0x2CAB381 VA: 0x2CAB280
	|-SRList<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public T[] get_Buffer() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA9890 Offset: 0x2CA9991 VA: 0x2CA9890
	|-SRList<int>.get_Buffer
	|
	|-RVA: 0x2CAB2E0 Offset: 0x2CAB3E1 VA: 0x2CAB2E0
	|-SRList<object>.get_Buffer
	*/

	// RVA: -1 Offset: -1
	private void set_Buffer(T[] value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA98A0 Offset: 0x2CA99A1 VA: 0x2CA98A0
	|-SRList<int>.set_Buffer
	|
	|-RVA: 0x2CAB2F0 Offset: 0x2CAB3F1 VA: 0x2CAB2F0
	|-SRList<object>.set_Buffer
	*/

	// RVA: -1 Offset: -1
	private EqualityComparer<T> get_EqualityComparer() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA98B0 Offset: 0x2CA99B1 VA: 0x2CA98B0
	|-SRList<int>.get_EqualityComparer
	|
	|-RVA: 0x2CAB300 Offset: 0x2CAB401 VA: 0x2CAB300
	|-SRList<object>.get_EqualityComparer
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAB360 Offset: 0x2CAB461 VA: 0x2CAB360
	|-SRList<SRTab>.get_Count
	|-SRList<SRServiceManager.Service>.get_Count
	|-SRList<VirtualVerticalLayoutGroup.Row>.get_Count
	|-SRList<object>.get_Count
	|
	|-RVA: 0x2CA9910 Offset: 0x2CA9A11 VA: 0x2CA9910
	|-SRList<int>.get_Count
	*/

	// RVA: -1 Offset: -1
	private void set_Count(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA9920 Offset: 0x2CA9A21 VA: 0x2CA9920
	|-SRList<int>.set_Count
	|
	|-RVA: 0x2CAB370 Offset: 0x2CAB471 VA: 0x2CAB370
	|-SRList<object>.set_Count
	*/

	[IteratorStateMachineAttribute] // RVA: 0x127BC0 Offset: 0x127CC1 VA: 0x127BC0
	// RVA: -1 Offset: -1 Slot: 16
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA9930 Offset: 0x2CA9A31 VA: 0x2CA9930
	|-SRList<int>.GetEnumerator
	|
	|-RVA: 0x2CAB380 Offset: 0x2CAB481 VA: 0x2CAB380
	|-SRList<object>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA99C0 Offset: 0x2CA9AC1 VA: 0x2CA99C0
	|-SRList<int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2CAB410 Offset: 0x2CAB511 VA: 0x2CAB410
	|-SRList<object>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAB440 Offset: 0x2CAB541 VA: 0x2CAB440
	|-SRList<SRTab>.Add
	|-SRList<SRServiceManager.Service>.Add
	|-SRList<VirtualVerticalLayoutGroup.Row>.Add
	|-SRList<object>.Add
	|
	|-RVA: 0x2CA99F0 Offset: 0x2CA9AF1 VA: 0x2CA99F0
	|-SRList<int>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA9B20 Offset: 0x2CA9C21 VA: 0x2CA9B20
	|-SRList<int>.Clear
	|
	|-RVA: 0x2CAB570 Offset: 0x2CAB671 VA: 0x2CAB570
	|-SRList<object>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAB5A0 Offset: 0x2CAB6A1 VA: 0x2CAB5A0
	|-SRList<SRTab>.Contains
	|-SRList<object>.Contains
	|
	|-RVA: 0x2CA9B50 Offset: 0x2CA9C51 VA: 0x2CA9B50
	|-SRList<int>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public void CopyTo(T[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA9C70 Offset: 0x2CA9D71 VA: 0x2CA9C70
	|-SRList<int>.CopyTo
	|
	|-RVA: 0x2CAB6C0 Offset: 0x2CAB7C1 VA: 0x2CAB6C0
	|-SRList<object>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public bool Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAB740 Offset: 0x2CAB841 VA: 0x2CAB740
	|-SRList<VirtualVerticalLayoutGroup.Row>.Remove
	|-SRList<object>.Remove
	|
	|-RVA: 0x2CA9CF0 Offset: 0x2CA9DF1 VA: 0x2CA9CF0
	|-SRList<int>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public bool get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA9D90 Offset: 0x2CA9E91 VA: 0x2CA9D90
	|-SRList<int>.get_IsReadOnly
	|
	|-RVA: 0x2CAB7E0 Offset: 0x2CAB8E1 VA: 0x2CAB7E0
	|-SRList<object>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public int IndexOf(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA9DA0 Offset: 0x2CA9EA1 VA: 0x2CA9DA0
	|-SRList<int>.IndexOf
	|
	|-RVA: 0x2CAB7F0 Offset: 0x2CAB8F1 VA: 0x2CAB7F0
	|-SRList<object>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void Insert(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA9ED0 Offset: 0x2CA9FD1 VA: 0x2CA9ED0
	|-SRList<int>.Insert
	|
	|-RVA: 0x2CAB920 Offset: 0x2CABA21 VA: 0x2CAB920
	|-SRList<object>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CABB60 Offset: 0x2CABC61 VA: 0x2CABB60
	|-SRList<SRServiceManager.Service>.RemoveAt
	|-SRList<VirtualVerticalLayoutGroup.Row>.RemoveAt
	|-SRList<object>.RemoveAt
	|
	|-RVA: 0x2CAA0E0 Offset: 0x2CAA1E1 VA: 0x2CAA0E0
	|-SRList<int>.RemoveAt
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CABD40 Offset: 0x2CABE41 VA: 0x2CABD40
	|-SRList<SRTab>.get_Item
	|-SRList<SRServiceManager.Service>.get_Item
	|-SRList<VirtualVerticalLayoutGroup.Row>.get_Item
	|-SRList<object>.get_Item
	|
	|-RVA: 0x2CAA280 Offset: 0x2CAA381 VA: 0x2CAA280
	|-SRList<int>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAA360 Offset: 0x2CAA461 VA: 0x2CAA360
	|-SRList<int>.set_Item
	|
	|-RVA: 0x2CABE20 Offset: 0x2CABF21 VA: 0x2CABE20
	|-SRList<object>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 18
	public void OnBeforeSerialize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAA450 Offset: 0x2CAA551 VA: 0x2CAA450
	|-SRList<int>.OnBeforeSerialize
	|
	|-RVA: 0x2CABF10 Offset: 0x2CAC011 VA: 0x2CABF10
	|-SRList<object>.OnBeforeSerialize
	*/

	// RVA: -1 Offset: -1 Slot: 19
	public void OnAfterDeserialize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAA590 Offset: 0x2CAA691 VA: 0x2CAA590
	|-SRList<int>.OnAfterDeserialize
	|
	|-RVA: 0x2CAC050 Offset: 0x2CAC151 VA: 0x2CAC050
	|-SRList<object>.OnAfterDeserialize
	*/

	// RVA: -1 Offset: -1
	public void AddRange(IEnumerable<T> range) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAA6B0 Offset: 0x2CAA7B1 VA: 0x2CAA6B0
	|-SRList<int>.AddRange
	|
	|-RVA: 0x2CAC170 Offset: 0x2CAC271 VA: 0x2CAC170
	|-SRList<object>.AddRange
	*/

	// RVA: -1 Offset: -1
	public void Clear(bool clean) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAAA80 Offset: 0x2CAAB81 VA: 0x2CAAA80
	|-SRList<int>.Clear
	|
	|-RVA: 0x2CAC540 Offset: 0x2CAC641 VA: 0x2CAC540
	|-SRList<object>.Clear
	*/

	// RVA: -1 Offset: -1
	public void Clean() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAAAF0 Offset: 0x2CAABF1 VA: 0x2CAAAF0
	|-SRList<int>.Clean
	|
	|-RVA: 0x2CAC5B0 Offset: 0x2CAC6B1 VA: 0x2CAC5B0
	|-SRList<object>.Clean
	*/

	// RVA: -1 Offset: -1
	public ReadOnlyCollection<T> AsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAC670 Offset: 0x2CAC771 VA: 0x2CAC670
	|-SRList<SRTab>.AsReadOnly
	|-SRList<object>.AsReadOnly
	|
	|-RVA: 0x2CAAB90 Offset: 0x2CAAC91 VA: 0x2CAAB90
	|-SRList<int>.AsReadOnly
	*/

	// RVA: -1 Offset: -1
	private void Expand() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAAC30 Offset: 0x2CAAD31 VA: 0x2CAAC30
	|-SRList<int>.Expand
	|
	|-RVA: 0x2CAC710 Offset: 0x2CAC811 VA: 0x2CAC710
	|-SRList<object>.Expand
	*/

	// RVA: -1 Offset: -1
	public void Trim() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAADD0 Offset: 0x2CAAED1 VA: 0x2CAADD0
	|-SRList<int>.Trim
	|
	|-RVA: 0x2CAC8B0 Offset: 0x2CAC9B1 VA: 0x2CAC8B0
	|-SRList<object>.Trim
	*/

	// RVA: -1 Offset: -1
	public void Sort(Comparison<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CACAD0 Offset: 0x2CACBD1 VA: 0x2CACAD0
	|-SRList<SRTab>.Sort
	|-SRList<object>.Sort
	|
	|-RVA: 0x2CAAFE0 Offset: 0x2CAB0E1 VA: 0x2CAAFE0
	|-SRList<int>.Sort
	*/
}

[DefaultMemberAttribute] // RVA: 0x126D20 Offset: 0x126E21 VA: 0x126D20
[Serializable]
public class SRList<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, ISerializationCallbackReceiver // TypeDefIndex: 4296
{
	// Fields
	[SerializeField] // RVA: 0x127860 Offset: 0x127961 VA: 0x127860
	private T[] _buffer; // 0x0
	[SerializeField] // RVA: 0x127870 Offset: 0x127971 VA: 0x127870
	private int _count; // 0x0
	private EqualityComparer<T> _equalityComparer; // 0x0
	private ReadOnlyCollection<T> _readOnlyWrapper; // 0x0

	// Properties
	public T[] Buffer { get; set; }
	private EqualityComparer<T> EqualityComparer { get; }
	public int Count { get; set; }
	public bool IsReadOnly { get; }
	public T Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAB1E0 Offset: 0x2CAB2E1 VA: 0x2CAB1E0
	|-SRList<SRTab>..ctor
	|-SRList<SRServiceManager.Service>..ctor
	|-SRList<VirtualVerticalLayoutGroup.Row>..ctor
	|-SRList<object>..ctor
	|
	|-RVA: 0x2CA9790 Offset: 0x2CA9891 VA: 0x2CA9790
	|-SRList<int>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA97B0 Offset: 0x2CA98B1 VA: 0x2CA97B0
	|-SRList<int>..ctor
	|
	|-RVA: 0x2CAB200 Offset: 0x2CAB301 VA: 0x2CAB200
	|-SRList<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IEnumerable<T> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA9830 Offset: 0x2CA9931 VA: 0x2CA9830
	|-SRList<int>..ctor
	|
	|-RVA: 0x2CAB280 Offset: 0x2CAB381 VA: 0x2CAB280
	|-SRList<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public T[] get_Buffer() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA9890 Offset: 0x2CA9991 VA: 0x2CA9890
	|-SRList<int>.get_Buffer
	|
	|-RVA: 0x2CAB2E0 Offset: 0x2CAB3E1 VA: 0x2CAB2E0
	|-SRList<object>.get_Buffer
	*/

	// RVA: -1 Offset: -1
	private void set_Buffer(T[] value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA98A0 Offset: 0x2CA99A1 VA: 0x2CA98A0
	|-SRList<int>.set_Buffer
	|
	|-RVA: 0x2CAB2F0 Offset: 0x2CAB3F1 VA: 0x2CAB2F0
	|-SRList<object>.set_Buffer
	*/

	// RVA: -1 Offset: -1
	private EqualityComparer<T> get_EqualityComparer() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA98B0 Offset: 0x2CA99B1 VA: 0x2CA98B0
	|-SRList<int>.get_EqualityComparer
	|
	|-RVA: 0x2CAB300 Offset: 0x2CAB401 VA: 0x2CAB300
	|-SRList<object>.get_EqualityComparer
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAB360 Offset: 0x2CAB461 VA: 0x2CAB360
	|-SRList<SRTab>.get_Count
	|-SRList<SRServiceManager.Service>.get_Count
	|-SRList<VirtualVerticalLayoutGroup.Row>.get_Count
	|-SRList<object>.get_Count
	|
	|-RVA: 0x2CA9910 Offset: 0x2CA9A11 VA: 0x2CA9910
	|-SRList<int>.get_Count
	*/

	// RVA: -1 Offset: -1
	private void set_Count(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA9920 Offset: 0x2CA9A21 VA: 0x2CA9920
	|-SRList<int>.set_Count
	|
	|-RVA: 0x2CAB370 Offset: 0x2CAB471 VA: 0x2CAB370
	|-SRList<object>.set_Count
	*/

	[IteratorStateMachineAttribute] // RVA: 0x127BC0 Offset: 0x127CC1 VA: 0x127BC0
	// RVA: -1 Offset: -1 Slot: 16
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA9930 Offset: 0x2CA9A31 VA: 0x2CA9930
	|-SRList<int>.GetEnumerator
	|
	|-RVA: 0x2CAB380 Offset: 0x2CAB481 VA: 0x2CAB380
	|-SRList<object>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA99C0 Offset: 0x2CA9AC1 VA: 0x2CA99C0
	|-SRList<int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2CAB410 Offset: 0x2CAB511 VA: 0x2CAB410
	|-SRList<object>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAB440 Offset: 0x2CAB541 VA: 0x2CAB440
	|-SRList<SRTab>.Add
	|-SRList<SRServiceManager.Service>.Add
	|-SRList<VirtualVerticalLayoutGroup.Row>.Add
	|-SRList<object>.Add
	|
	|-RVA: 0x2CA99F0 Offset: 0x2CA9AF1 VA: 0x2CA99F0
	|-SRList<int>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA9B20 Offset: 0x2CA9C21 VA: 0x2CA9B20
	|-SRList<int>.Clear
	|
	|-RVA: 0x2CAB570 Offset: 0x2CAB671 VA: 0x2CAB570
	|-SRList<object>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAB5A0 Offset: 0x2CAB6A1 VA: 0x2CAB5A0
	|-SRList<SRTab>.Contains
	|-SRList<object>.Contains
	|
	|-RVA: 0x2CA9B50 Offset: 0x2CA9C51 VA: 0x2CA9B50
	|-SRList<int>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public void CopyTo(T[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA9C70 Offset: 0x2CA9D71 VA: 0x2CA9C70
	|-SRList<int>.CopyTo
	|
	|-RVA: 0x2CAB6C0 Offset: 0x2CAB7C1 VA: 0x2CAB6C0
	|-SRList<object>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public bool Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAB740 Offset: 0x2CAB841 VA: 0x2CAB740
	|-SRList<VirtualVerticalLayoutGroup.Row>.Remove
	|-SRList<object>.Remove
	|
	|-RVA: 0x2CA9CF0 Offset: 0x2CA9DF1 VA: 0x2CA9CF0
	|-SRList<int>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public bool get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA9D90 Offset: 0x2CA9E91 VA: 0x2CA9D90
	|-SRList<int>.get_IsReadOnly
	|
	|-RVA: 0x2CAB7E0 Offset: 0x2CAB8E1 VA: 0x2CAB7E0
	|-SRList<object>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public int IndexOf(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA9DA0 Offset: 0x2CA9EA1 VA: 0x2CA9DA0
	|-SRList<int>.IndexOf
	|
	|-RVA: 0x2CAB7F0 Offset: 0x2CAB8F1 VA: 0x2CAB7F0
	|-SRList<object>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void Insert(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA9ED0 Offset: 0x2CA9FD1 VA: 0x2CA9ED0
	|-SRList<int>.Insert
	|
	|-RVA: 0x2CAB920 Offset: 0x2CABA21 VA: 0x2CAB920
	|-SRList<object>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CABB60 Offset: 0x2CABC61 VA: 0x2CABB60
	|-SRList<SRServiceManager.Service>.RemoveAt
	|-SRList<VirtualVerticalLayoutGroup.Row>.RemoveAt
	|-SRList<object>.RemoveAt
	|
	|-RVA: 0x2CAA0E0 Offset: 0x2CAA1E1 VA: 0x2CAA0E0
	|-SRList<int>.RemoveAt
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CABD40 Offset: 0x2CABE41 VA: 0x2CABD40
	|-SRList<SRTab>.get_Item
	|-SRList<SRServiceManager.Service>.get_Item
	|-SRList<VirtualVerticalLayoutGroup.Row>.get_Item
	|-SRList<object>.get_Item
	|
	|-RVA: 0x2CAA280 Offset: 0x2CAA381 VA: 0x2CAA280
	|-SRList<int>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAA360 Offset: 0x2CAA461 VA: 0x2CAA360
	|-SRList<int>.set_Item
	|
	|-RVA: 0x2CABE20 Offset: 0x2CABF21 VA: 0x2CABE20
	|-SRList<object>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 18
	public void OnBeforeSerialize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAA450 Offset: 0x2CAA551 VA: 0x2CAA450
	|-SRList<int>.OnBeforeSerialize
	|
	|-RVA: 0x2CABF10 Offset: 0x2CAC011 VA: 0x2CABF10
	|-SRList<object>.OnBeforeSerialize
	*/

	// RVA: -1 Offset: -1 Slot: 19
	public void OnAfterDeserialize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAA590 Offset: 0x2CAA691 VA: 0x2CAA590
	|-SRList<int>.OnAfterDeserialize
	|
	|-RVA: 0x2CAC050 Offset: 0x2CAC151 VA: 0x2CAC050
	|-SRList<object>.OnAfterDeserialize
	*/

	// RVA: -1 Offset: -1
	public void AddRange(IEnumerable<T> range) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAA6B0 Offset: 0x2CAA7B1 VA: 0x2CAA6B0
	|-SRList<int>.AddRange
	|
	|-RVA: 0x2CAC170 Offset: 0x2CAC271 VA: 0x2CAC170
	|-SRList<object>.AddRange
	*/

	// RVA: -1 Offset: -1
	public void Clear(bool clean) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAAA80 Offset: 0x2CAAB81 VA: 0x2CAAA80
	|-SRList<int>.Clear
	|
	|-RVA: 0x2CAC540 Offset: 0x2CAC641 VA: 0x2CAC540
	|-SRList<object>.Clear
	*/

	// RVA: -1 Offset: -1
	public void Clean() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAAAF0 Offset: 0x2CAABF1 VA: 0x2CAAAF0
	|-SRList<int>.Clean
	|
	|-RVA: 0x2CAC5B0 Offset: 0x2CAC6B1 VA: 0x2CAC5B0
	|-SRList<object>.Clean
	*/

	// RVA: -1 Offset: -1
	public ReadOnlyCollection<T> AsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAC670 Offset: 0x2CAC771 VA: 0x2CAC670
	|-SRList<SRTab>.AsReadOnly
	|-SRList<object>.AsReadOnly
	|
	|-RVA: 0x2CAAB90 Offset: 0x2CAAC91 VA: 0x2CAAB90
	|-SRList<int>.AsReadOnly
	*/

	// RVA: -1 Offset: -1
	private void Expand() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAAC30 Offset: 0x2CAAD31 VA: 0x2CAAC30
	|-SRList<int>.Expand
	|
	|-RVA: 0x2CAC710 Offset: 0x2CAC811 VA: 0x2CAC710
	|-SRList<object>.Expand
	*/

	// RVA: -1 Offset: -1
	public void Trim() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAADD0 Offset: 0x2CAAED1 VA: 0x2CAADD0
	|-SRList<int>.Trim
	|
	|-RVA: 0x2CAC8B0 Offset: 0x2CAC9B1 VA: 0x2CAC8B0
	|-SRList<object>.Trim
	*/

	// RVA: -1 Offset: -1
	public void Sort(Comparison<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CACAD0 Offset: 0x2CACBD1 VA: 0x2CACAD0
	|-SRList<SRTab>.Sort
	|-SRList<object>.Sort
	|
	|-RVA: 0x2CAAFE0 Offset: 0x2CAB0E1 VA: 0x2CAAFE0
	|-SRList<int>.Sort
	*/
}

[DefaultMemberAttribute] // RVA: 0x126D20 Offset: 0x126E21 VA: 0x126D20
[Serializable]
public class SRList<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, ISerializationCallbackReceiver // TypeDefIndex: 4296
{
	// Fields
	[SerializeField] // RVA: 0x127860 Offset: 0x127961 VA: 0x127860
	private T[] _buffer; // 0x0
	[SerializeField] // RVA: 0x127870 Offset: 0x127971 VA: 0x127870
	private int _count; // 0x0
	private EqualityComparer<T> _equalityComparer; // 0x0
	private ReadOnlyCollection<T> _readOnlyWrapper; // 0x0

	// Properties
	public T[] Buffer { get; set; }
	private EqualityComparer<T> EqualityComparer { get; }
	public int Count { get; set; }
	public bool IsReadOnly { get; }
	public T Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAB1E0 Offset: 0x2CAB2E1 VA: 0x2CAB1E0
	|-SRList<SRTab>..ctor
	|-SRList<SRServiceManager.Service>..ctor
	|-SRList<VirtualVerticalLayoutGroup.Row>..ctor
	|-SRList<object>..ctor
	|
	|-RVA: 0x2CA9790 Offset: 0x2CA9891 VA: 0x2CA9790
	|-SRList<int>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA97B0 Offset: 0x2CA98B1 VA: 0x2CA97B0
	|-SRList<int>..ctor
	|
	|-RVA: 0x2CAB200 Offset: 0x2CAB301 VA: 0x2CAB200
	|-SRList<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IEnumerable<T> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA9830 Offset: 0x2CA9931 VA: 0x2CA9830
	|-SRList<int>..ctor
	|
	|-RVA: 0x2CAB280 Offset: 0x2CAB381 VA: 0x2CAB280
	|-SRList<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public T[] get_Buffer() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA9890 Offset: 0x2CA9991 VA: 0x2CA9890
	|-SRList<int>.get_Buffer
	|
	|-RVA: 0x2CAB2E0 Offset: 0x2CAB3E1 VA: 0x2CAB2E0
	|-SRList<object>.get_Buffer
	*/

	// RVA: -1 Offset: -1
	private void set_Buffer(T[] value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA98A0 Offset: 0x2CA99A1 VA: 0x2CA98A0
	|-SRList<int>.set_Buffer
	|
	|-RVA: 0x2CAB2F0 Offset: 0x2CAB3F1 VA: 0x2CAB2F0
	|-SRList<object>.set_Buffer
	*/

	// RVA: -1 Offset: -1
	private EqualityComparer<T> get_EqualityComparer() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA98B0 Offset: 0x2CA99B1 VA: 0x2CA98B0
	|-SRList<int>.get_EqualityComparer
	|
	|-RVA: 0x2CAB300 Offset: 0x2CAB401 VA: 0x2CAB300
	|-SRList<object>.get_EqualityComparer
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAB360 Offset: 0x2CAB461 VA: 0x2CAB360
	|-SRList<SRTab>.get_Count
	|-SRList<SRServiceManager.Service>.get_Count
	|-SRList<VirtualVerticalLayoutGroup.Row>.get_Count
	|-SRList<object>.get_Count
	|
	|-RVA: 0x2CA9910 Offset: 0x2CA9A11 VA: 0x2CA9910
	|-SRList<int>.get_Count
	*/

	// RVA: -1 Offset: -1
	private void set_Count(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA9920 Offset: 0x2CA9A21 VA: 0x2CA9920
	|-SRList<int>.set_Count
	|
	|-RVA: 0x2CAB370 Offset: 0x2CAB471 VA: 0x2CAB370
	|-SRList<object>.set_Count
	*/

	[IteratorStateMachineAttribute] // RVA: 0x127BC0 Offset: 0x127CC1 VA: 0x127BC0
	// RVA: -1 Offset: -1 Slot: 16
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA9930 Offset: 0x2CA9A31 VA: 0x2CA9930
	|-SRList<int>.GetEnumerator
	|
	|-RVA: 0x2CAB380 Offset: 0x2CAB481 VA: 0x2CAB380
	|-SRList<object>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA99C0 Offset: 0x2CA9AC1 VA: 0x2CA99C0
	|-SRList<int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2CAB410 Offset: 0x2CAB511 VA: 0x2CAB410
	|-SRList<object>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAB440 Offset: 0x2CAB541 VA: 0x2CAB440
	|-SRList<SRTab>.Add
	|-SRList<SRServiceManager.Service>.Add
	|-SRList<VirtualVerticalLayoutGroup.Row>.Add
	|-SRList<object>.Add
	|
	|-RVA: 0x2CA99F0 Offset: 0x2CA9AF1 VA: 0x2CA99F0
	|-SRList<int>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA9B20 Offset: 0x2CA9C21 VA: 0x2CA9B20
	|-SRList<int>.Clear
	|
	|-RVA: 0x2CAB570 Offset: 0x2CAB671 VA: 0x2CAB570
	|-SRList<object>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAB5A0 Offset: 0x2CAB6A1 VA: 0x2CAB5A0
	|-SRList<SRTab>.Contains
	|-SRList<object>.Contains
	|
	|-RVA: 0x2CA9B50 Offset: 0x2CA9C51 VA: 0x2CA9B50
	|-SRList<int>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public void CopyTo(T[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA9C70 Offset: 0x2CA9D71 VA: 0x2CA9C70
	|-SRList<int>.CopyTo
	|
	|-RVA: 0x2CAB6C0 Offset: 0x2CAB7C1 VA: 0x2CAB6C0
	|-SRList<object>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public bool Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAB740 Offset: 0x2CAB841 VA: 0x2CAB740
	|-SRList<VirtualVerticalLayoutGroup.Row>.Remove
	|-SRList<object>.Remove
	|
	|-RVA: 0x2CA9CF0 Offset: 0x2CA9DF1 VA: 0x2CA9CF0
	|-SRList<int>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public bool get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA9D90 Offset: 0x2CA9E91 VA: 0x2CA9D90
	|-SRList<int>.get_IsReadOnly
	|
	|-RVA: 0x2CAB7E0 Offset: 0x2CAB8E1 VA: 0x2CAB7E0
	|-SRList<object>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public int IndexOf(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA9DA0 Offset: 0x2CA9EA1 VA: 0x2CA9DA0
	|-SRList<int>.IndexOf
	|
	|-RVA: 0x2CAB7F0 Offset: 0x2CAB8F1 VA: 0x2CAB7F0
	|-SRList<object>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void Insert(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA9ED0 Offset: 0x2CA9FD1 VA: 0x2CA9ED0
	|-SRList<int>.Insert
	|
	|-RVA: 0x2CAB920 Offset: 0x2CABA21 VA: 0x2CAB920
	|-SRList<object>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CABB60 Offset: 0x2CABC61 VA: 0x2CABB60
	|-SRList<SRServiceManager.Service>.RemoveAt
	|-SRList<VirtualVerticalLayoutGroup.Row>.RemoveAt
	|-SRList<object>.RemoveAt
	|
	|-RVA: 0x2CAA0E0 Offset: 0x2CAA1E1 VA: 0x2CAA0E0
	|-SRList<int>.RemoveAt
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CABD40 Offset: 0x2CABE41 VA: 0x2CABD40
	|-SRList<SRTab>.get_Item
	|-SRList<SRServiceManager.Service>.get_Item
	|-SRList<VirtualVerticalLayoutGroup.Row>.get_Item
	|-SRList<object>.get_Item
	|
	|-RVA: 0x2CAA280 Offset: 0x2CAA381 VA: 0x2CAA280
	|-SRList<int>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAA360 Offset: 0x2CAA461 VA: 0x2CAA360
	|-SRList<int>.set_Item
	|
	|-RVA: 0x2CABE20 Offset: 0x2CABF21 VA: 0x2CABE20
	|-SRList<object>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 18
	public void OnBeforeSerialize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAA450 Offset: 0x2CAA551 VA: 0x2CAA450
	|-SRList<int>.OnBeforeSerialize
	|
	|-RVA: 0x2CABF10 Offset: 0x2CAC011 VA: 0x2CABF10
	|-SRList<object>.OnBeforeSerialize
	*/

	// RVA: -1 Offset: -1 Slot: 19
	public void OnAfterDeserialize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAA590 Offset: 0x2CAA691 VA: 0x2CAA590
	|-SRList<int>.OnAfterDeserialize
	|
	|-RVA: 0x2CAC050 Offset: 0x2CAC151 VA: 0x2CAC050
	|-SRList<object>.OnAfterDeserialize
	*/

	// RVA: -1 Offset: -1
	public void AddRange(IEnumerable<T> range) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAA6B0 Offset: 0x2CAA7B1 VA: 0x2CAA6B0
	|-SRList<int>.AddRange
	|
	|-RVA: 0x2CAC170 Offset: 0x2CAC271 VA: 0x2CAC170
	|-SRList<object>.AddRange
	*/

	// RVA: -1 Offset: -1
	public void Clear(bool clean) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAAA80 Offset: 0x2CAAB81 VA: 0x2CAAA80
	|-SRList<int>.Clear
	|
	|-RVA: 0x2CAC540 Offset: 0x2CAC641 VA: 0x2CAC540
	|-SRList<object>.Clear
	*/

	// RVA: -1 Offset: -1
	public void Clean() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAAAF0 Offset: 0x2CAABF1 VA: 0x2CAAAF0
	|-SRList<int>.Clean
	|
	|-RVA: 0x2CAC5B0 Offset: 0x2CAC6B1 VA: 0x2CAC5B0
	|-SRList<object>.Clean
	*/

	// RVA: -1 Offset: -1
	public ReadOnlyCollection<T> AsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAC670 Offset: 0x2CAC771 VA: 0x2CAC670
	|-SRList<SRTab>.AsReadOnly
	|-SRList<object>.AsReadOnly
	|
	|-RVA: 0x2CAAB90 Offset: 0x2CAAC91 VA: 0x2CAAB90
	|-SRList<int>.AsReadOnly
	*/

	// RVA: -1 Offset: -1
	private void Expand() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAAC30 Offset: 0x2CAAD31 VA: 0x2CAAC30
	|-SRList<int>.Expand
	|
	|-RVA: 0x2CAC710 Offset: 0x2CAC811 VA: 0x2CAC710
	|-SRList<object>.Expand
	*/

	// RVA: -1 Offset: -1
	public void Trim() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAADD0 Offset: 0x2CAAED1 VA: 0x2CAADD0
	|-SRList<int>.Trim
	|
	|-RVA: 0x2CAC8B0 Offset: 0x2CAC9B1 VA: 0x2CAC8B0
	|-SRList<object>.Trim
	*/

	// RVA: -1 Offset: -1
	public void Sort(Comparison<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CACAD0 Offset: 0x2CACBD1 VA: 0x2CACAD0
	|-SRList<SRTab>.Sort
	|-SRList<object>.Sort
	|
	|-RVA: 0x2CAAFE0 Offset: 0x2CAB0E1 VA: 0x2CAAFE0
	|-SRList<int>.Sort
	*/
}

[DefaultMemberAttribute] // RVA: 0x126D20 Offset: 0x126E21 VA: 0x126D20
[Serializable]
public class SRList<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, ISerializationCallbackReceiver // TypeDefIndex: 4296
{
	// Fields
	[SerializeField] // RVA: 0x127860 Offset: 0x127961 VA: 0x127860
	private T[] _buffer; // 0x0
	[SerializeField] // RVA: 0x127870 Offset: 0x127971 VA: 0x127870
	private int _count; // 0x0
	private EqualityComparer<T> _equalityComparer; // 0x0
	private ReadOnlyCollection<T> _readOnlyWrapper; // 0x0

	// Properties
	public T[] Buffer { get; set; }
	private EqualityComparer<T> EqualityComparer { get; }
	public int Count { get; set; }
	public bool IsReadOnly { get; }
	public T Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAB1E0 Offset: 0x2CAB2E1 VA: 0x2CAB1E0
	|-SRList<SRTab>..ctor
	|-SRList<SRServiceManager.Service>..ctor
	|-SRList<VirtualVerticalLayoutGroup.Row>..ctor
	|-SRList<object>..ctor
	|
	|-RVA: 0x2CA9790 Offset: 0x2CA9891 VA: 0x2CA9790
	|-SRList<int>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA97B0 Offset: 0x2CA98B1 VA: 0x2CA97B0
	|-SRList<int>..ctor
	|
	|-RVA: 0x2CAB200 Offset: 0x2CAB301 VA: 0x2CAB200
	|-SRList<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IEnumerable<T> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA9830 Offset: 0x2CA9931 VA: 0x2CA9830
	|-SRList<int>..ctor
	|
	|-RVA: 0x2CAB280 Offset: 0x2CAB381 VA: 0x2CAB280
	|-SRList<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public T[] get_Buffer() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA9890 Offset: 0x2CA9991 VA: 0x2CA9890
	|-SRList<int>.get_Buffer
	|
	|-RVA: 0x2CAB2E0 Offset: 0x2CAB3E1 VA: 0x2CAB2E0
	|-SRList<object>.get_Buffer
	*/

	// RVA: -1 Offset: -1
	private void set_Buffer(T[] value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA98A0 Offset: 0x2CA99A1 VA: 0x2CA98A0
	|-SRList<int>.set_Buffer
	|
	|-RVA: 0x2CAB2F0 Offset: 0x2CAB3F1 VA: 0x2CAB2F0
	|-SRList<object>.set_Buffer
	*/

	// RVA: -1 Offset: -1
	private EqualityComparer<T> get_EqualityComparer() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA98B0 Offset: 0x2CA99B1 VA: 0x2CA98B0
	|-SRList<int>.get_EqualityComparer
	|
	|-RVA: 0x2CAB300 Offset: 0x2CAB401 VA: 0x2CAB300
	|-SRList<object>.get_EqualityComparer
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAB360 Offset: 0x2CAB461 VA: 0x2CAB360
	|-SRList<SRTab>.get_Count
	|-SRList<SRServiceManager.Service>.get_Count
	|-SRList<VirtualVerticalLayoutGroup.Row>.get_Count
	|-SRList<object>.get_Count
	|
	|-RVA: 0x2CA9910 Offset: 0x2CA9A11 VA: 0x2CA9910
	|-SRList<int>.get_Count
	*/

	// RVA: -1 Offset: -1
	private void set_Count(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA9920 Offset: 0x2CA9A21 VA: 0x2CA9920
	|-SRList<int>.set_Count
	|
	|-RVA: 0x2CAB370 Offset: 0x2CAB471 VA: 0x2CAB370
	|-SRList<object>.set_Count
	*/

	[IteratorStateMachineAttribute] // RVA: 0x127BC0 Offset: 0x127CC1 VA: 0x127BC0
	// RVA: -1 Offset: -1 Slot: 16
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA9930 Offset: 0x2CA9A31 VA: 0x2CA9930
	|-SRList<int>.GetEnumerator
	|
	|-RVA: 0x2CAB380 Offset: 0x2CAB481 VA: 0x2CAB380
	|-SRList<object>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA99C0 Offset: 0x2CA9AC1 VA: 0x2CA99C0
	|-SRList<int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2CAB410 Offset: 0x2CAB511 VA: 0x2CAB410
	|-SRList<object>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAB440 Offset: 0x2CAB541 VA: 0x2CAB440
	|-SRList<SRTab>.Add
	|-SRList<SRServiceManager.Service>.Add
	|-SRList<VirtualVerticalLayoutGroup.Row>.Add
	|-SRList<object>.Add
	|
	|-RVA: 0x2CA99F0 Offset: 0x2CA9AF1 VA: 0x2CA99F0
	|-SRList<int>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA9B20 Offset: 0x2CA9C21 VA: 0x2CA9B20
	|-SRList<int>.Clear
	|
	|-RVA: 0x2CAB570 Offset: 0x2CAB671 VA: 0x2CAB570
	|-SRList<object>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAB5A0 Offset: 0x2CAB6A1 VA: 0x2CAB5A0
	|-SRList<SRTab>.Contains
	|-SRList<object>.Contains
	|
	|-RVA: 0x2CA9B50 Offset: 0x2CA9C51 VA: 0x2CA9B50
	|-SRList<int>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public void CopyTo(T[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA9C70 Offset: 0x2CA9D71 VA: 0x2CA9C70
	|-SRList<int>.CopyTo
	|
	|-RVA: 0x2CAB6C0 Offset: 0x2CAB7C1 VA: 0x2CAB6C0
	|-SRList<object>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public bool Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAB740 Offset: 0x2CAB841 VA: 0x2CAB740
	|-SRList<VirtualVerticalLayoutGroup.Row>.Remove
	|-SRList<object>.Remove
	|
	|-RVA: 0x2CA9CF0 Offset: 0x2CA9DF1 VA: 0x2CA9CF0
	|-SRList<int>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public bool get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA9D90 Offset: 0x2CA9E91 VA: 0x2CA9D90
	|-SRList<int>.get_IsReadOnly
	|
	|-RVA: 0x2CAB7E0 Offset: 0x2CAB8E1 VA: 0x2CAB7E0
	|-SRList<object>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public int IndexOf(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA9DA0 Offset: 0x2CA9EA1 VA: 0x2CA9DA0
	|-SRList<int>.IndexOf
	|
	|-RVA: 0x2CAB7F0 Offset: 0x2CAB8F1 VA: 0x2CAB7F0
	|-SRList<object>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void Insert(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA9ED0 Offset: 0x2CA9FD1 VA: 0x2CA9ED0
	|-SRList<int>.Insert
	|
	|-RVA: 0x2CAB920 Offset: 0x2CABA21 VA: 0x2CAB920
	|-SRList<object>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CABB60 Offset: 0x2CABC61 VA: 0x2CABB60
	|-SRList<SRServiceManager.Service>.RemoveAt
	|-SRList<VirtualVerticalLayoutGroup.Row>.RemoveAt
	|-SRList<object>.RemoveAt
	|
	|-RVA: 0x2CAA0E0 Offset: 0x2CAA1E1 VA: 0x2CAA0E0
	|-SRList<int>.RemoveAt
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CABD40 Offset: 0x2CABE41 VA: 0x2CABD40
	|-SRList<SRTab>.get_Item
	|-SRList<SRServiceManager.Service>.get_Item
	|-SRList<VirtualVerticalLayoutGroup.Row>.get_Item
	|-SRList<object>.get_Item
	|
	|-RVA: 0x2CAA280 Offset: 0x2CAA381 VA: 0x2CAA280
	|-SRList<int>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAA360 Offset: 0x2CAA461 VA: 0x2CAA360
	|-SRList<int>.set_Item
	|
	|-RVA: 0x2CABE20 Offset: 0x2CABF21 VA: 0x2CABE20
	|-SRList<object>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 18
	public void OnBeforeSerialize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAA450 Offset: 0x2CAA551 VA: 0x2CAA450
	|-SRList<int>.OnBeforeSerialize
	|
	|-RVA: 0x2CABF10 Offset: 0x2CAC011 VA: 0x2CABF10
	|-SRList<object>.OnBeforeSerialize
	*/

	// RVA: -1 Offset: -1 Slot: 19
	public void OnAfterDeserialize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAA590 Offset: 0x2CAA691 VA: 0x2CAA590
	|-SRList<int>.OnAfterDeserialize
	|
	|-RVA: 0x2CAC050 Offset: 0x2CAC151 VA: 0x2CAC050
	|-SRList<object>.OnAfterDeserialize
	*/

	// RVA: -1 Offset: -1
	public void AddRange(IEnumerable<T> range) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAA6B0 Offset: 0x2CAA7B1 VA: 0x2CAA6B0
	|-SRList<int>.AddRange
	|
	|-RVA: 0x2CAC170 Offset: 0x2CAC271 VA: 0x2CAC170
	|-SRList<object>.AddRange
	*/

	// RVA: -1 Offset: -1
	public void Clear(bool clean) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAAA80 Offset: 0x2CAAB81 VA: 0x2CAAA80
	|-SRList<int>.Clear
	|
	|-RVA: 0x2CAC540 Offset: 0x2CAC641 VA: 0x2CAC540
	|-SRList<object>.Clear
	*/

	// RVA: -1 Offset: -1
	public void Clean() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAAAF0 Offset: 0x2CAABF1 VA: 0x2CAAAF0
	|-SRList<int>.Clean
	|
	|-RVA: 0x2CAC5B0 Offset: 0x2CAC6B1 VA: 0x2CAC5B0
	|-SRList<object>.Clean
	*/

	// RVA: -1 Offset: -1
	public ReadOnlyCollection<T> AsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAC670 Offset: 0x2CAC771 VA: 0x2CAC670
	|-SRList<SRTab>.AsReadOnly
	|-SRList<object>.AsReadOnly
	|
	|-RVA: 0x2CAAB90 Offset: 0x2CAAC91 VA: 0x2CAAB90
	|-SRList<int>.AsReadOnly
	*/

	// RVA: -1 Offset: -1
	private void Expand() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAAC30 Offset: 0x2CAAD31 VA: 0x2CAAC30
	|-SRList<int>.Expand
	|
	|-RVA: 0x2CAC710 Offset: 0x2CAC811 VA: 0x2CAC710
	|-SRList<object>.Expand
	*/

	// RVA: -1 Offset: -1
	public void Trim() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAADD0 Offset: 0x2CAAED1 VA: 0x2CAADD0
	|-SRList<int>.Trim
	|
	|-RVA: 0x2CAC8B0 Offset: 0x2CAC9B1 VA: 0x2CAC8B0
	|-SRList<object>.Trim
	*/

	// RVA: -1 Offset: -1
	public void Sort(Comparison<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CACAD0 Offset: 0x2CACBD1 VA: 0x2CACAD0
	|-SRList<SRTab>.Sort
	|-SRList<object>.Sort
	|
	|-RVA: 0x2CAAFE0 Offset: 0x2CAB0E1 VA: 0x2CAAFE0
	|-SRList<int>.Sort
	*/
}

[DefaultMemberAttribute] // RVA: 0x126D20 Offset: 0x126E21 VA: 0x126D20
[Serializable]
public class SRList<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, ISerializationCallbackReceiver // TypeDefIndex: 4296
{
	// Fields
	[SerializeField] // RVA: 0x127860 Offset: 0x127961 VA: 0x127860
	private T[] _buffer; // 0x0
	[SerializeField] // RVA: 0x127870 Offset: 0x127971 VA: 0x127870
	private int _count; // 0x0
	private EqualityComparer<T> _equalityComparer; // 0x0
	private ReadOnlyCollection<T> _readOnlyWrapper; // 0x0

	// Properties
	public T[] Buffer { get; set; }
	private EqualityComparer<T> EqualityComparer { get; }
	public int Count { get; set; }
	public bool IsReadOnly { get; }
	public T Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAB1E0 Offset: 0x2CAB2E1 VA: 0x2CAB1E0
	|-SRList<SRTab>..ctor
	|-SRList<SRServiceManager.Service>..ctor
	|-SRList<VirtualVerticalLayoutGroup.Row>..ctor
	|-SRList<object>..ctor
	|
	|-RVA: 0x2CA9790 Offset: 0x2CA9891 VA: 0x2CA9790
	|-SRList<int>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA97B0 Offset: 0x2CA98B1 VA: 0x2CA97B0
	|-SRList<int>..ctor
	|
	|-RVA: 0x2CAB200 Offset: 0x2CAB301 VA: 0x2CAB200
	|-SRList<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IEnumerable<T> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA9830 Offset: 0x2CA9931 VA: 0x2CA9830
	|-SRList<int>..ctor
	|
	|-RVA: 0x2CAB280 Offset: 0x2CAB381 VA: 0x2CAB280
	|-SRList<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public T[] get_Buffer() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA9890 Offset: 0x2CA9991 VA: 0x2CA9890
	|-SRList<int>.get_Buffer
	|
	|-RVA: 0x2CAB2E0 Offset: 0x2CAB3E1 VA: 0x2CAB2E0
	|-SRList<object>.get_Buffer
	*/

	// RVA: -1 Offset: -1
	private void set_Buffer(T[] value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA98A0 Offset: 0x2CA99A1 VA: 0x2CA98A0
	|-SRList<int>.set_Buffer
	|
	|-RVA: 0x2CAB2F0 Offset: 0x2CAB3F1 VA: 0x2CAB2F0
	|-SRList<object>.set_Buffer
	*/

	// RVA: -1 Offset: -1
	private EqualityComparer<T> get_EqualityComparer() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA98B0 Offset: 0x2CA99B1 VA: 0x2CA98B0
	|-SRList<int>.get_EqualityComparer
	|
	|-RVA: 0x2CAB300 Offset: 0x2CAB401 VA: 0x2CAB300
	|-SRList<object>.get_EqualityComparer
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAB360 Offset: 0x2CAB461 VA: 0x2CAB360
	|-SRList<SRTab>.get_Count
	|-SRList<SRServiceManager.Service>.get_Count
	|-SRList<VirtualVerticalLayoutGroup.Row>.get_Count
	|-SRList<object>.get_Count
	|
	|-RVA: 0x2CA9910 Offset: 0x2CA9A11 VA: 0x2CA9910
	|-SRList<int>.get_Count
	*/

	// RVA: -1 Offset: -1
	private void set_Count(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA9920 Offset: 0x2CA9A21 VA: 0x2CA9920
	|-SRList<int>.set_Count
	|
	|-RVA: 0x2CAB370 Offset: 0x2CAB471 VA: 0x2CAB370
	|-SRList<object>.set_Count
	*/

	[IteratorStateMachineAttribute] // RVA: 0x127BC0 Offset: 0x127CC1 VA: 0x127BC0
	// RVA: -1 Offset: -1 Slot: 16
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA9930 Offset: 0x2CA9A31 VA: 0x2CA9930
	|-SRList<int>.GetEnumerator
	|
	|-RVA: 0x2CAB380 Offset: 0x2CAB481 VA: 0x2CAB380
	|-SRList<object>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA99C0 Offset: 0x2CA9AC1 VA: 0x2CA99C0
	|-SRList<int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2CAB410 Offset: 0x2CAB511 VA: 0x2CAB410
	|-SRList<object>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAB440 Offset: 0x2CAB541 VA: 0x2CAB440
	|-SRList<SRTab>.Add
	|-SRList<SRServiceManager.Service>.Add
	|-SRList<VirtualVerticalLayoutGroup.Row>.Add
	|-SRList<object>.Add
	|
	|-RVA: 0x2CA99F0 Offset: 0x2CA9AF1 VA: 0x2CA99F0
	|-SRList<int>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA9B20 Offset: 0x2CA9C21 VA: 0x2CA9B20
	|-SRList<int>.Clear
	|
	|-RVA: 0x2CAB570 Offset: 0x2CAB671 VA: 0x2CAB570
	|-SRList<object>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAB5A0 Offset: 0x2CAB6A1 VA: 0x2CAB5A0
	|-SRList<SRTab>.Contains
	|-SRList<object>.Contains
	|
	|-RVA: 0x2CA9B50 Offset: 0x2CA9C51 VA: 0x2CA9B50
	|-SRList<int>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public void CopyTo(T[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA9C70 Offset: 0x2CA9D71 VA: 0x2CA9C70
	|-SRList<int>.CopyTo
	|
	|-RVA: 0x2CAB6C0 Offset: 0x2CAB7C1 VA: 0x2CAB6C0
	|-SRList<object>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public bool Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAB740 Offset: 0x2CAB841 VA: 0x2CAB740
	|-SRList<VirtualVerticalLayoutGroup.Row>.Remove
	|-SRList<object>.Remove
	|
	|-RVA: 0x2CA9CF0 Offset: 0x2CA9DF1 VA: 0x2CA9CF0
	|-SRList<int>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public bool get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA9D90 Offset: 0x2CA9E91 VA: 0x2CA9D90
	|-SRList<int>.get_IsReadOnly
	|
	|-RVA: 0x2CAB7E0 Offset: 0x2CAB8E1 VA: 0x2CAB7E0
	|-SRList<object>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public int IndexOf(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA9DA0 Offset: 0x2CA9EA1 VA: 0x2CA9DA0
	|-SRList<int>.IndexOf
	|
	|-RVA: 0x2CAB7F0 Offset: 0x2CAB8F1 VA: 0x2CAB7F0
	|-SRList<object>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void Insert(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA9ED0 Offset: 0x2CA9FD1 VA: 0x2CA9ED0
	|-SRList<int>.Insert
	|
	|-RVA: 0x2CAB920 Offset: 0x2CABA21 VA: 0x2CAB920
	|-SRList<object>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CABB60 Offset: 0x2CABC61 VA: 0x2CABB60
	|-SRList<SRServiceManager.Service>.RemoveAt
	|-SRList<VirtualVerticalLayoutGroup.Row>.RemoveAt
	|-SRList<object>.RemoveAt
	|
	|-RVA: 0x2CAA0E0 Offset: 0x2CAA1E1 VA: 0x2CAA0E0
	|-SRList<int>.RemoveAt
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CABD40 Offset: 0x2CABE41 VA: 0x2CABD40
	|-SRList<SRTab>.get_Item
	|-SRList<SRServiceManager.Service>.get_Item
	|-SRList<VirtualVerticalLayoutGroup.Row>.get_Item
	|-SRList<object>.get_Item
	|
	|-RVA: 0x2CAA280 Offset: 0x2CAA381 VA: 0x2CAA280
	|-SRList<int>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAA360 Offset: 0x2CAA461 VA: 0x2CAA360
	|-SRList<int>.set_Item
	|
	|-RVA: 0x2CABE20 Offset: 0x2CABF21 VA: 0x2CABE20
	|-SRList<object>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 18
	public void OnBeforeSerialize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAA450 Offset: 0x2CAA551 VA: 0x2CAA450
	|-SRList<int>.OnBeforeSerialize
	|
	|-RVA: 0x2CABF10 Offset: 0x2CAC011 VA: 0x2CABF10
	|-SRList<object>.OnBeforeSerialize
	*/

	// RVA: -1 Offset: -1 Slot: 19
	public void OnAfterDeserialize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAA590 Offset: 0x2CAA691 VA: 0x2CAA590
	|-SRList<int>.OnAfterDeserialize
	|
	|-RVA: 0x2CAC050 Offset: 0x2CAC151 VA: 0x2CAC050
	|-SRList<object>.OnAfterDeserialize
	*/

	// RVA: -1 Offset: -1
	public void AddRange(IEnumerable<T> range) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAA6B0 Offset: 0x2CAA7B1 VA: 0x2CAA6B0
	|-SRList<int>.AddRange
	|
	|-RVA: 0x2CAC170 Offset: 0x2CAC271 VA: 0x2CAC170
	|-SRList<object>.AddRange
	*/

	// RVA: -1 Offset: -1
	public void Clear(bool clean) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAAA80 Offset: 0x2CAAB81 VA: 0x2CAAA80
	|-SRList<int>.Clear
	|
	|-RVA: 0x2CAC540 Offset: 0x2CAC641 VA: 0x2CAC540
	|-SRList<object>.Clear
	*/

	// RVA: -1 Offset: -1
	public void Clean() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAAAF0 Offset: 0x2CAABF1 VA: 0x2CAAAF0
	|-SRList<int>.Clean
	|
	|-RVA: 0x2CAC5B0 Offset: 0x2CAC6B1 VA: 0x2CAC5B0
	|-SRList<object>.Clean
	*/

	// RVA: -1 Offset: -1
	public ReadOnlyCollection<T> AsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAC670 Offset: 0x2CAC771 VA: 0x2CAC670
	|-SRList<SRTab>.AsReadOnly
	|-SRList<object>.AsReadOnly
	|
	|-RVA: 0x2CAAB90 Offset: 0x2CAAC91 VA: 0x2CAAB90
	|-SRList<int>.AsReadOnly
	*/

	// RVA: -1 Offset: -1
	private void Expand() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAAC30 Offset: 0x2CAAD31 VA: 0x2CAAC30
	|-SRList<int>.Expand
	|
	|-RVA: 0x2CAC710 Offset: 0x2CAC811 VA: 0x2CAC710
	|-SRList<object>.Expand
	*/

	// RVA: -1 Offset: -1
	public void Trim() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAADD0 Offset: 0x2CAAED1 VA: 0x2CAADD0
	|-SRList<int>.Trim
	|
	|-RVA: 0x2CAC8B0 Offset: 0x2CAC9B1 VA: 0x2CAC8B0
	|-SRList<object>.Trim
	*/

	// RVA: -1 Offset: -1
	public void Sort(Comparison<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CACAD0 Offset: 0x2CACBD1 VA: 0x2CACAD0
	|-SRList<SRTab>.Sort
	|-SRList<object>.Sort
	|
	|-RVA: 0x2CAAFE0 Offset: 0x2CAB0E1 VA: 0x2CAAFE0
	|-SRList<int>.Sort
	*/
}

[DefaultMemberAttribute] // RVA: 0x126D20 Offset: 0x126E21 VA: 0x126D20
[Serializable]
public class SRList<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, ISerializationCallbackReceiver // TypeDefIndex: 4296
{
	// Fields
	[SerializeField] // RVA: 0x127860 Offset: 0x127961 VA: 0x127860
	private T[] _buffer; // 0x0
	[SerializeField] // RVA: 0x127870 Offset: 0x127971 VA: 0x127870
	private int _count; // 0x0
	private EqualityComparer<T> _equalityComparer; // 0x0
	private ReadOnlyCollection<T> _readOnlyWrapper; // 0x0

	// Properties
	public T[] Buffer { get; set; }
	private EqualityComparer<T> EqualityComparer { get; }
	public int Count { get; set; }
	public bool IsReadOnly { get; }
	public T Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAB1E0 Offset: 0x2CAB2E1 VA: 0x2CAB1E0
	|-SRList<SRTab>..ctor
	|-SRList<SRServiceManager.Service>..ctor
	|-SRList<VirtualVerticalLayoutGroup.Row>..ctor
	|-SRList<object>..ctor
	|
	|-RVA: 0x2CA9790 Offset: 0x2CA9891 VA: 0x2CA9790
	|-SRList<int>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA97B0 Offset: 0x2CA98B1 VA: 0x2CA97B0
	|-SRList<int>..ctor
	|
	|-RVA: 0x2CAB200 Offset: 0x2CAB301 VA: 0x2CAB200
	|-SRList<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IEnumerable<T> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA9830 Offset: 0x2CA9931 VA: 0x2CA9830
	|-SRList<int>..ctor
	|
	|-RVA: 0x2CAB280 Offset: 0x2CAB381 VA: 0x2CAB280
	|-SRList<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public T[] get_Buffer() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA9890 Offset: 0x2CA9991 VA: 0x2CA9890
	|-SRList<int>.get_Buffer
	|
	|-RVA: 0x2CAB2E0 Offset: 0x2CAB3E1 VA: 0x2CAB2E0
	|-SRList<object>.get_Buffer
	*/

	// RVA: -1 Offset: -1
	private void set_Buffer(T[] value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA98A0 Offset: 0x2CA99A1 VA: 0x2CA98A0
	|-SRList<int>.set_Buffer
	|
	|-RVA: 0x2CAB2F0 Offset: 0x2CAB3F1 VA: 0x2CAB2F0
	|-SRList<object>.set_Buffer
	*/

	// RVA: -1 Offset: -1
	private EqualityComparer<T> get_EqualityComparer() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA98B0 Offset: 0x2CA99B1 VA: 0x2CA98B0
	|-SRList<int>.get_EqualityComparer
	|
	|-RVA: 0x2CAB300 Offset: 0x2CAB401 VA: 0x2CAB300
	|-SRList<object>.get_EqualityComparer
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAB360 Offset: 0x2CAB461 VA: 0x2CAB360
	|-SRList<SRTab>.get_Count
	|-SRList<SRServiceManager.Service>.get_Count
	|-SRList<VirtualVerticalLayoutGroup.Row>.get_Count
	|-SRList<object>.get_Count
	|
	|-RVA: 0x2CA9910 Offset: 0x2CA9A11 VA: 0x2CA9910
	|-SRList<int>.get_Count
	*/

	// RVA: -1 Offset: -1
	private void set_Count(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA9920 Offset: 0x2CA9A21 VA: 0x2CA9920
	|-SRList<int>.set_Count
	|
	|-RVA: 0x2CAB370 Offset: 0x2CAB471 VA: 0x2CAB370
	|-SRList<object>.set_Count
	*/

	[IteratorStateMachineAttribute] // RVA: 0x127BC0 Offset: 0x127CC1 VA: 0x127BC0
	// RVA: -1 Offset: -1 Slot: 16
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA9930 Offset: 0x2CA9A31 VA: 0x2CA9930
	|-SRList<int>.GetEnumerator
	|
	|-RVA: 0x2CAB380 Offset: 0x2CAB481 VA: 0x2CAB380
	|-SRList<object>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA99C0 Offset: 0x2CA9AC1 VA: 0x2CA99C0
	|-SRList<int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2CAB410 Offset: 0x2CAB511 VA: 0x2CAB410
	|-SRList<object>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAB440 Offset: 0x2CAB541 VA: 0x2CAB440
	|-SRList<SRTab>.Add
	|-SRList<SRServiceManager.Service>.Add
	|-SRList<VirtualVerticalLayoutGroup.Row>.Add
	|-SRList<object>.Add
	|
	|-RVA: 0x2CA99F0 Offset: 0x2CA9AF1 VA: 0x2CA99F0
	|-SRList<int>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA9B20 Offset: 0x2CA9C21 VA: 0x2CA9B20
	|-SRList<int>.Clear
	|
	|-RVA: 0x2CAB570 Offset: 0x2CAB671 VA: 0x2CAB570
	|-SRList<object>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAB5A0 Offset: 0x2CAB6A1 VA: 0x2CAB5A0
	|-SRList<SRTab>.Contains
	|-SRList<object>.Contains
	|
	|-RVA: 0x2CA9B50 Offset: 0x2CA9C51 VA: 0x2CA9B50
	|-SRList<int>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public void CopyTo(T[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA9C70 Offset: 0x2CA9D71 VA: 0x2CA9C70
	|-SRList<int>.CopyTo
	|
	|-RVA: 0x2CAB6C0 Offset: 0x2CAB7C1 VA: 0x2CAB6C0
	|-SRList<object>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public bool Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAB740 Offset: 0x2CAB841 VA: 0x2CAB740
	|-SRList<VirtualVerticalLayoutGroup.Row>.Remove
	|-SRList<object>.Remove
	|
	|-RVA: 0x2CA9CF0 Offset: 0x2CA9DF1 VA: 0x2CA9CF0
	|-SRList<int>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public bool get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA9D90 Offset: 0x2CA9E91 VA: 0x2CA9D90
	|-SRList<int>.get_IsReadOnly
	|
	|-RVA: 0x2CAB7E0 Offset: 0x2CAB8E1 VA: 0x2CAB7E0
	|-SRList<object>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public int IndexOf(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA9DA0 Offset: 0x2CA9EA1 VA: 0x2CA9DA0
	|-SRList<int>.IndexOf
	|
	|-RVA: 0x2CAB7F0 Offset: 0x2CAB8F1 VA: 0x2CAB7F0
	|-SRList<object>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void Insert(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA9ED0 Offset: 0x2CA9FD1 VA: 0x2CA9ED0
	|-SRList<int>.Insert
	|
	|-RVA: 0x2CAB920 Offset: 0x2CABA21 VA: 0x2CAB920
	|-SRList<object>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CABB60 Offset: 0x2CABC61 VA: 0x2CABB60
	|-SRList<SRServiceManager.Service>.RemoveAt
	|-SRList<VirtualVerticalLayoutGroup.Row>.RemoveAt
	|-SRList<object>.RemoveAt
	|
	|-RVA: 0x2CAA0E0 Offset: 0x2CAA1E1 VA: 0x2CAA0E0
	|-SRList<int>.RemoveAt
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CABD40 Offset: 0x2CABE41 VA: 0x2CABD40
	|-SRList<SRTab>.get_Item
	|-SRList<SRServiceManager.Service>.get_Item
	|-SRList<VirtualVerticalLayoutGroup.Row>.get_Item
	|-SRList<object>.get_Item
	|
	|-RVA: 0x2CAA280 Offset: 0x2CAA381 VA: 0x2CAA280
	|-SRList<int>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAA360 Offset: 0x2CAA461 VA: 0x2CAA360
	|-SRList<int>.set_Item
	|
	|-RVA: 0x2CABE20 Offset: 0x2CABF21 VA: 0x2CABE20
	|-SRList<object>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 18
	public void OnBeforeSerialize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAA450 Offset: 0x2CAA551 VA: 0x2CAA450
	|-SRList<int>.OnBeforeSerialize
	|
	|-RVA: 0x2CABF10 Offset: 0x2CAC011 VA: 0x2CABF10
	|-SRList<object>.OnBeforeSerialize
	*/

	// RVA: -1 Offset: -1 Slot: 19
	public void OnAfterDeserialize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAA590 Offset: 0x2CAA691 VA: 0x2CAA590
	|-SRList<int>.OnAfterDeserialize
	|
	|-RVA: 0x2CAC050 Offset: 0x2CAC151 VA: 0x2CAC050
	|-SRList<object>.OnAfterDeserialize
	*/

	// RVA: -1 Offset: -1
	public void AddRange(IEnumerable<T> range) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAA6B0 Offset: 0x2CAA7B1 VA: 0x2CAA6B0
	|-SRList<int>.AddRange
	|
	|-RVA: 0x2CAC170 Offset: 0x2CAC271 VA: 0x2CAC170
	|-SRList<object>.AddRange
	*/

	// RVA: -1 Offset: -1
	public void Clear(bool clean) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAAA80 Offset: 0x2CAAB81 VA: 0x2CAAA80
	|-SRList<int>.Clear
	|
	|-RVA: 0x2CAC540 Offset: 0x2CAC641 VA: 0x2CAC540
	|-SRList<object>.Clear
	*/

	// RVA: -1 Offset: -1
	public void Clean() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAAAF0 Offset: 0x2CAABF1 VA: 0x2CAAAF0
	|-SRList<int>.Clean
	|
	|-RVA: 0x2CAC5B0 Offset: 0x2CAC6B1 VA: 0x2CAC5B0
	|-SRList<object>.Clean
	*/

	// RVA: -1 Offset: -1
	public ReadOnlyCollection<T> AsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAC670 Offset: 0x2CAC771 VA: 0x2CAC670
	|-SRList<SRTab>.AsReadOnly
	|-SRList<object>.AsReadOnly
	|
	|-RVA: 0x2CAAB90 Offset: 0x2CAAC91 VA: 0x2CAAB90
	|-SRList<int>.AsReadOnly
	*/

	// RVA: -1 Offset: -1
	private void Expand() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAAC30 Offset: 0x2CAAD31 VA: 0x2CAAC30
	|-SRList<int>.Expand
	|
	|-RVA: 0x2CAC710 Offset: 0x2CAC811 VA: 0x2CAC710
	|-SRList<object>.Expand
	*/

	// RVA: -1 Offset: -1
	public void Trim() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAADD0 Offset: 0x2CAAED1 VA: 0x2CAADD0
	|-SRList<int>.Trim
	|
	|-RVA: 0x2CAC8B0 Offset: 0x2CAC9B1 VA: 0x2CAC8B0
	|-SRList<object>.Trim
	*/

	// RVA: -1 Offset: -1
	public void Sort(Comparison<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CACAD0 Offset: 0x2CACBD1 VA: 0x2CACAD0
	|-SRList<SRTab>.Sort
	|-SRList<object>.Sort
	|
	|-RVA: 0x2CAAFE0 Offset: 0x2CAB0E1 VA: 0x2CAAFE0
	|-SRList<int>.Sort
	*/
}

