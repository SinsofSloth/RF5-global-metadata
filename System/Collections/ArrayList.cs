[ComVisibleAttribute] // RVA: 0xB2950 Offset: 0xB2A51 VA: 0xB2950
[DebuggerTypeProxyAttribute] // RVA: 0xB2950 Offset: 0xB2A51 VA: 0xB2950
[DebuggerDisplayAttribute] // RVA: 0xB2950 Offset: 0xB2A51 VA: 0xB2950
[DefaultMemberAttribute] // RVA: 0xB2950 Offset: 0xB2A51 VA: 0xB2950
[Serializable]
public class ArrayList : IList, ICollection, IEnumerable, ICloneable // TypeDefIndex: 1343
{
	// Fields
	private object[] _items; // 0x10
	private int _size; // 0x18
	private int _version; // 0x1C
	private object _syncRoot; // 0x20
	private static readonly object[] emptyArray; // 0x0

	// Properties
	public virtual int Capacity { set; }
	public virtual int Count { get; }
	public virtual bool IsReadOnly { get; }
	public virtual object SyncRoot { get; }
	public virtual object Item { get; set; }

	// Methods

	// RVA: 0x18594B0 Offset: 0x18595B1 VA: 0x18594B0
	public void .ctor() { }

	// RVA: 0x1859530 Offset: 0x1859631 VA: 0x1859530
	public void .ctor(int capacity) { }

	// RVA: 0x1859680 Offset: 0x1859781 VA: 0x1859680
	public void .ctor(ICollection c) { }

	// RVA: 0x1859830 Offset: 0x1859931 VA: 0x1859830 Slot: 18
	public virtual void set_Capacity(int value) { }

	// RVA: 0x1859980 Offset: 0x1859A81 VA: 0x1859980 Slot: 19
	public virtual int get_Count() { }

	// RVA: 0x1859990 Offset: 0x1859A91 VA: 0x1859990 Slot: 20
	public virtual bool get_IsReadOnly() { }

	// RVA: 0x18599A0 Offset: 0x1859AA1 VA: 0x18599A0 Slot: 21
	public virtual object get_SyncRoot() { }

	// RVA: 0x1859A30 Offset: 0x1859B31 VA: 0x1859A30 Slot: 22
	public virtual object get_Item(int index) { }

	// RVA: 0x1859B10 Offset: 0x1859C11 VA: 0x1859B10 Slot: 23
	public virtual void set_Item(int index, object value) { }

	// RVA: 0x1859C30 Offset: 0x1859D31 VA: 0x1859C30 Slot: 24
	public virtual int Add(object value) { }

	// RVA: 0x1859DA0 Offset: 0x1859EA1 VA: 0x1859DA0 Slot: 25
	public virtual void AddRange(ICollection c) { }

	// RVA: 0x1859DC0 Offset: 0x1859EC1 VA: 0x1859DC0 Slot: 26
	public virtual void Clear() { }

	// RVA: 0x1859E10 Offset: 0x1859F11 VA: 0x1859E10 Slot: 27
	public virtual object Clone() { }

	// RVA: 0x1859EB0 Offset: 0x1859FB1 VA: 0x1859EB0 Slot: 28
	public virtual bool Contains(object item) { }

	// RVA: 0x1859FB0 Offset: 0x185A0B1 VA: 0x1859FB0 Slot: 29
	public virtual void CopyTo(Array array) { }

	// RVA: 0x1859FD0 Offset: 0x185A0D1 VA: 0x1859FD0 Slot: 30
	public virtual void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x185A090 Offset: 0x185A191 VA: 0x185A090 Slot: 31
	public virtual void CopyTo(int index, Array array, int arrayIndex, int count) { }

	// RVA: 0x1859D40 Offset: 0x1859E41 VA: 0x1859D40
	private void EnsureCapacity(int min) { }

	// RVA: 0x185A180 Offset: 0x185A281 VA: 0x185A180 Slot: 32
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x185A300 Offset: 0x185A401 VA: 0x185A300 Slot: 33
	public virtual int IndexOf(object value) { }

	// RVA: 0x185A320 Offset: 0x185A421 VA: 0x185A320 Slot: 34
	public virtual void Insert(int index, object value) { }

	// RVA: 0x185A4C0 Offset: 0x185A5C1 VA: 0x185A4C0 Slot: 35
	public virtual void InsertRange(int index, ICollection c) { }

	// RVA: 0x185A760 Offset: 0x185A861 VA: 0x185A760
	public static IList ReadOnly(IList list) { }

	// RVA: 0x185A850 Offset: 0x185A951 VA: 0x185A850
	public static ArrayList ReadOnly(ArrayList list) { }

	// RVA: 0x185A9E0 Offset: 0x185AAE1 VA: 0x185A9E0 Slot: 36
	public virtual void Remove(object obj) { }

	// RVA: 0x185AA30 Offset: 0x185AB31 VA: 0x185AA30 Slot: 37
	public virtual void RemoveAt(int index) { }

	// RVA: 0x185AB50 Offset: 0x185AC51 VA: 0x185AB50 Slot: 38
	public virtual void RemoveRange(int index, int count) { }

	// RVA: 0x185AD00 Offset: 0x185AE01 VA: 0x185AD00 Slot: 39
	public virtual object[] ToArray() { }

	// RVA: 0x185AD80 Offset: 0x185AE81 VA: 0x185AD80 Slot: 40
	public virtual Array ToArray(Type type) { }

	// RVA: 0x185AEA0 Offset: 0x185AFA1 VA: 0x185AEA0
	private static void .cctor() { }
}

