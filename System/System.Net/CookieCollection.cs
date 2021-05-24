[DefaultMemberAttribute] // RVA: 0xBC350 Offset: 0xBC451 VA: 0xBC350
[Serializable]
public class CookieCollection : ICollection, IEnumerable // TypeDefIndex: 1934
{
	// Fields
	internal int m_version; // 0x10
	private ArrayList m_list; // 0x18
	private DateTime m_TimeStamp; // 0x20
	private bool m_has_other_versions; // 0x28
	[OptionalFieldAttribute] // RVA: 0xBCF20 Offset: 0xBD021 VA: 0xBCF20
	private bool m_IsReadOnly; // 0x29

	// Properties
	public Cookie Item { get; }
	public int Count { get; }
	internal bool IsOtherVersionSeen { get; }

	// Methods

	// RVA: 0x28F7A20 Offset: 0x28F7B21 VA: 0x28F7A20
	public void .ctor() { }

	// RVA: 0x28F7AD0 Offset: 0x28F7BD1 VA: 0x28F7AD0
	public Cookie get_Item(int index) { }

	// RVA: 0x28F7BC0 Offset: 0x28F7CC1 VA: 0x28F7BC0
	public void Add(Cookie cookie) { }

	// RVA: 0x28F8190 Offset: 0x28F8291 VA: 0x28F8190
	public void Add(CookieCollection cookies) { }

	// RVA: 0x28F84D0 Offset: 0x28F85D1 VA: 0x28F84D0 Slot: 5
	public int get_Count() { }

	// RVA: 0x28F8500 Offset: 0x28F8601 VA: 0x28F8500 Slot: 4
	public void CopyTo(Array array, int index) { }

	// RVA: 0x28F8530 Offset: 0x28F8631 VA: 0x28F8530
	internal DateTime TimeStamp(CookieCollection.Stamp how) { }

	// RVA: 0x28F8640 Offset: 0x28F8741 VA: 0x28F8640
	internal bool get_IsOtherVersionSeen() { }

	// RVA: 0x28F8650 Offset: 0x28F8751 VA: 0x28F8650
	internal int InternalAdd(Cookie cookie, bool isStrict) { }

	// RVA: 0x28F7CB0 Offset: 0x28F7DB1 VA: 0x28F7CB0
	internal int IndexOf(Cookie cookie) { }

	// RVA: 0x28F8C30 Offset: 0x28F8D31 VA: 0x28F8C30
	internal void RemoveAt(int idx) { }

	// RVA: 0x28F8420 Offset: 0x28F8521 VA: 0x28F8420 Slot: 6
	public IEnumerator GetEnumerator() { }
}

