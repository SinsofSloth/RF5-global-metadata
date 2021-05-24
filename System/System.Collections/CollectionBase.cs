[ComVisibleAttribute] // RVA: 0xB2B50 Offset: 0xB2C51 VA: 0xB2B50
[Serializable]
public abstract class CollectionBase : IList, ICollection, IEnumerable // TypeDefIndex: 1352
{
	// Fields
	private ArrayList list; // 0x10

	// Properties
	protected ArrayList InnerList { get; }
	public int Count { get; }
	private bool System.Collections.IList.IsReadOnly { get; }
	private object System.Collections.IList.Item { get; set; }

	// Methods

	// RVA: 0x185D840 Offset: 0x185D941 VA: 0x185D840
	protected void .ctor() { }

	// RVA: 0x185D920 Offset: 0x185DA21 VA: 0x185D920
	protected ArrayList get_InnerList() { }

	// RVA: 0x185DA10 Offset: 0x185DB11 VA: 0x185DA10 Slot: 15
	public int get_Count() { }

	// RVA: 0x185DA30 Offset: 0x185DB31 VA: 0x185DA30 Slot: 8
	public void Clear() { }

	// RVA: 0x185DA90 Offset: 0x185DB91 VA: 0x185DA90 Slot: 13
	public void RemoveAt(int index) { }

	// RVA: 0x185DCA0 Offset: 0x185DDA1 VA: 0x185DCA0 Slot: 9
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0x185DCD0 Offset: 0x185DDD1 VA: 0x185DCD0 Slot: 14
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x185DD10 Offset: 0x185DE11 VA: 0x185DD10 Slot: 4
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x185DE00 Offset: 0x185DF01 VA: 0x185DE00 Slot: 5
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x185E020 Offset: 0x185E121 VA: 0x185E020 Slot: 7
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x185E060 Offset: 0x185E161 VA: 0x185E060 Slot: 6
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x185E1F0 Offset: 0x185E2F1 VA: 0x185E1F0 Slot: 12
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x185E3E0 Offset: 0x185E4E1 VA: 0x185E3E0 Slot: 10
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x185E420 Offset: 0x185E521 VA: 0x185E420 Slot: 11
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x185E610 Offset: 0x185E711 VA: 0x185E610 Slot: 16
	public IEnumerator GetEnumerator() { }

	// RVA: 0x185E640 Offset: 0x185E741 VA: 0x185E640 Slot: 17
	protected virtual void OnSet(int index, object oldValue, object newValue) { }

	// RVA: 0x185E650 Offset: 0x185E751 VA: 0x185E650 Slot: 18
	protected virtual void OnInsert(int index, object value) { }

	// RVA: 0x185E660 Offset: 0x185E761 VA: 0x185E660 Slot: 19
	protected virtual void OnClear() { }

	// RVA: 0x185E670 Offset: 0x185E771 VA: 0x185E670 Slot: 20
	protected virtual void OnRemove(int index, object value) { }

	// RVA: 0x185E680 Offset: 0x185E781 VA: 0x185E680 Slot: 21
	protected virtual void OnValidate(object value) { }

	// RVA: 0x185E700 Offset: 0x185E801 VA: 0x185E700 Slot: 22
	protected virtual void OnSetComplete(int index, object oldValue, object newValue) { }

	// RVA: 0x185E710 Offset: 0x185E811 VA: 0x185E710 Slot: 23
	protected virtual void OnInsertComplete(int index, object value) { }

	// RVA: 0x185E720 Offset: 0x185E821 VA: 0x185E720 Slot: 24
	protected virtual void OnClearComplete() { }

	// RVA: 0x185E730 Offset: 0x185E831 VA: 0x185E730 Slot: 25
	protected virtual void OnRemoveComplete(int index, object value) { }
}

