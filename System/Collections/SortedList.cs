[DefaultMemberAttribute] // RVA: 0xB2FD0 Offset: 0xB30D1 VA: 0xB2FD0
[DebuggerTypeProxyAttribute] // RVA: 0xB2FD0 Offset: 0xB30D1 VA: 0xB2FD0
[ComVisibleAttribute] // RVA: 0xB2FD0 Offset: 0xB30D1 VA: 0xB2FD0
[DebuggerDisplayAttribute] // RVA: 0xB2FD0 Offset: 0xB30D1 VA: 0xB2FD0
[Serializable]
public class SortedList : IDictionary, ICollection, IEnumerable, ICloneable // TypeDefIndex: 1383
{
	// Fields
	private object[] keys; // 0x10
	private object[] values; // 0x18
	private int _size; // 0x20
	private int version; // 0x24
	private IComparer comparer; // 0x28
	private SortedList.KeyList keyList; // 0x30
	private SortedList.ValueList valueList; // 0x38
	private object _syncRoot; // 0x40
	private static object[] emptyArray; // 0x0

	// Properties
	public virtual int Capacity { get; set; }
	public virtual int Count { get; }
	public virtual ICollection Keys { get; }
	public virtual ICollection Values { get; }
	public virtual object SyncRoot { get; }
	public virtual object Item { get; set; }

	// Methods

	// RVA: 0x2972EA0 Offset: 0x2972FA1 VA: 0x2972EA0
	public void .ctor() { }

	// RVA: 0x2972ED0 Offset: 0x2972FD1 VA: 0x2972ED0
	private void Init() { }

	// RVA: 0x2972FD0 Offset: 0x29730D1 VA: 0x2972FD0
	public void .ctor(int initialCapacity) { }

	// RVA: 0x2973120 Offset: 0x2973221 VA: 0x2973120
	public void .ctor(IComparer comparer) { }

	// RVA: 0x2973170 Offset: 0x2973271 VA: 0x2973170
	public void .ctor(IComparer comparer, int capacity) { }

	// RVA: 0x29731E0 Offset: 0x29732E1 VA: 0x29731E0 Slot: 14
	public virtual void Add(object key, object value) { }

	// RVA: 0x2973510 Offset: 0x2973611 VA: 0x2973510 Slot: 15
	public virtual int get_Capacity() { }

	// RVA: 0x2973530 Offset: 0x2973631 VA: 0x2973530 Slot: 16
	public virtual void set_Capacity(int value) { }

	// RVA: 0x2973710 Offset: 0x2973811 VA: 0x2973710 Slot: 17
	public virtual int get_Count() { }

	// RVA: 0x2973720 Offset: 0x2973821 VA: 0x2973720 Slot: 18
	public virtual ICollection get_Keys() { }

	// RVA: 0x2973730 Offset: 0x2973831 VA: 0x2973730 Slot: 19
	public virtual ICollection get_Values() { }

	// RVA: 0x2973740 Offset: 0x2973841 VA: 0x2973740 Slot: 20
	public virtual object get_SyncRoot() { }

	// RVA: 0x29737D0 Offset: 0x29738D1 VA: 0x29737D0 Slot: 21
	public virtual object Clone() { }

	// RVA: 0x29738A0 Offset: 0x29739A1 VA: 0x29738A0 Slot: 22
	public virtual bool Contains(object key) { }

	// RVA: 0x29738D0 Offset: 0x29739D1 VA: 0x29738D0 Slot: 23
	public virtual bool ContainsValue(object value) { }

	// RVA: 0x2973900 Offset: 0x2973A01 VA: 0x2973900 Slot: 24
	public virtual void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x2973B70 Offset: 0x2973C71 VA: 0x2973B70
	private void EnsureCapacity(int min) { }

	// RVA: 0x2973BC0 Offset: 0x2973CC1 VA: 0x2973BC0 Slot: 25
	public virtual object GetByIndex(int index) { }

	// RVA: 0x2973CB0 Offset: 0x2973DB1 VA: 0x2973CB0 Slot: 12
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x2973DD0 Offset: 0x2973ED1 VA: 0x2973DD0 Slot: 26
	public virtual IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0x2973E70 Offset: 0x2973F71 VA: 0x2973E70 Slot: 27
	public virtual object GetKey(int index) { }

	// RVA: 0x2973F60 Offset: 0x2974061 VA: 0x2973F60 Slot: 28
	public virtual IList GetKeyList() { }

	// RVA: 0x2974050 Offset: 0x2974151 VA: 0x2974050 Slot: 29
	public virtual IList GetValueList() { }

	// RVA: 0x2974140 Offset: 0x2974241 VA: 0x2974140 Slot: 30
	public virtual object get_Item(object key) { }

	// RVA: 0x29741B0 Offset: 0x29742B1 VA: 0x29741B0 Slot: 31
	public virtual void set_Item(object key, object value) { }

	// RVA: 0x2974310 Offset: 0x2974411 VA: 0x2974310 Slot: 32
	public virtual int IndexOfKey(object key) { }

	// RVA: 0x29743E0 Offset: 0x29744E1 VA: 0x29743E0 Slot: 33
	public virtual int IndexOfValue(object value) { }

	// RVA: 0x2973380 Offset: 0x2973481 VA: 0x2973380
	private void Insert(int index, object key, object value) { }

	// RVA: 0x2974450 Offset: 0x2974551 VA: 0x2974450 Slot: 34
	public virtual void RemoveAt(int index) { }

	// RVA: 0x29745D0 Offset: 0x29746D1 VA: 0x29745D0
	public static SortedList Synchronized(SortedList list) { }

	// RVA: 0x2974730 Offset: 0x2974831 VA: 0x2974730
	private static void .cctor() { }
}

