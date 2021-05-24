[DefaultMemberAttribute] // RVA: 0xBC560 Offset: 0xBC661 VA: 0xBC560
[Serializable]
public class StringCollection : IList, ICollection, IEnumerable // TypeDefIndex: 2066
{
	// Fields
	private ArrayList data; // 0x10

	// Properties
	public string Item { get; set; }
	public int Count { get; }
	private bool System.Collections.IList.IsReadOnly { get; }
	private object System.Collections.IList.Item { get; set; }

	// Methods

	// RVA: 0x28E6B50 Offset: 0x28E6C51 VA: 0x28E6B50
	public string get_Item(int index) { }

	// RVA: 0x28E6BE0 Offset: 0x28E6CE1 VA: 0x28E6BE0
	public void set_Item(int index, string value) { }

	// RVA: 0x28E6C10 Offset: 0x28E6D11 VA: 0x28E6C10 Slot: 15
	public int get_Count() { }

	// RVA: 0x28E6C40 Offset: 0x28E6D41 VA: 0x28E6C40 Slot: 9
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0x28E6C50 Offset: 0x28E6D51 VA: 0x28E6C50
	public int Add(string value) { }

	// RVA: 0x28E6C80 Offset: 0x28E6D81 VA: 0x28E6C80 Slot: 8
	public void Clear() { }

	// RVA: 0x28E6CB0 Offset: 0x28E6DB1 VA: 0x28E6CB0
	public bool Contains(string value) { }

	// RVA: 0x28E6CE0 Offset: 0x28E6DE1 VA: 0x28E6CE0
	public void CopyTo(string[] array, int index) { }

	// RVA: 0x28E6D10 Offset: 0x28E6E11 VA: 0x28E6D10
	public int IndexOf(string value) { }

	// RVA: 0x28E6D40 Offset: 0x28E6E41 VA: 0x28E6D40
	public void Insert(int index, string value) { }

	// RVA: 0x28E6D70 Offset: 0x28E6E71 VA: 0x28E6D70
	public void Remove(string value) { }

	// RVA: 0x28E6DA0 Offset: 0x28E6EA1 VA: 0x28E6DA0 Slot: 13
	public void RemoveAt(int index) { }

	// RVA: 0x28E6DD0 Offset: 0x28E6ED1 VA: 0x28E6DD0 Slot: 4
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x28E6E60 Offset: 0x28E6F61 VA: 0x28E6E60 Slot: 5
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x28E6F00 Offset: 0x28E7001 VA: 0x28E6F00 Slot: 6
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x28E6F90 Offset: 0x28E7091 VA: 0x28E6F90 Slot: 7
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x28E7020 Offset: 0x28E7121 VA: 0x28E7020 Slot: 10
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x28E70B0 Offset: 0x28E71B1 VA: 0x28E70B0 Slot: 11
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x28E7150 Offset: 0x28E7251 VA: 0x28E7150 Slot: 12
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x28E71E0 Offset: 0x28E72E1 VA: 0x28E71E0 Slot: 14
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x28E7210 Offset: 0x28E7311 VA: 0x28E7210 Slot: 16
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x28E7240 Offset: 0x28E7341 VA: 0x28E7240
	public void .ctor() { }
}

