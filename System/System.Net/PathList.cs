[DefaultMemberAttribute] // RVA: 0xBC390 Offset: 0xBC491 VA: 0xBC390
[Serializable]
internal class PathList // TypeDefIndex: 1939
{
	// Fields
	private SortedList m_list; // 0x10

	// Properties
	public int Count { get; }
	public ICollection Values { get; }
	public object Item { get; set; }
	public object SyncRoot { get; }

	// Methods

	// RVA: 0x16C9AD0 Offset: 0x16C9BD1 VA: 0x16C9AD0
	public void .ctor() { }

	// RVA: 0x16C9BA0 Offset: 0x16C9CA1 VA: 0x16C9BA0
	public int get_Count() { }

	// RVA: 0x16C9BD0 Offset: 0x16C9CD1 VA: 0x16C9BD0
	public int GetCookiesCount() { }

	// RVA: 0x16CA000 Offset: 0x16CA101 VA: 0x16CA000
	public ICollection get_Values() { }

	// RVA: 0x16CA030 Offset: 0x16CA131 VA: 0x16CA030
	public object get_Item(string s) { }

	// RVA: 0x16CA060 Offset: 0x16CA161 VA: 0x16CA060
	public void set_Item(string s, object value) { }

	// RVA: 0x16CA150 Offset: 0x16CA251 VA: 0x16CA150
	public IEnumerator GetEnumerator() { }

	// RVA: 0x16C9FD0 Offset: 0x16CA0D1 VA: 0x16C9FD0
	public object get_SyncRoot() { }
}

