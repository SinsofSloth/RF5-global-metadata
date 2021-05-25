[DefaultMemberAttribute] // RVA: 0xBBE30 Offset: 0xBBF31 VA: 0xBBE30
[Serializable]
public class GroupCollection : ICollection, IEnumerable // TypeDefIndex: 1781
{
	// Fields
	internal Match _match; // 0x10
	internal Hashtable _captureMap; // 0x18
	internal Group[] _groups; // 0x20

	// Properties
	public int Count { get; }
	public Group Item { get; }

	// Methods

	// RVA: 0x171BD00 Offset: 0x171BE01 VA: 0x171BD00
	internal void .ctor(Match match, Hashtable caps) { }

	// RVA: 0x171BD50 Offset: 0x171BE51 VA: 0x171BD50 Slot: 5
	public int get_Count() { }

	// RVA: 0x171BD80 Offset: 0x171BE81 VA: 0x171BD80
	public Group get_Item(int groupnum) { }

	// RVA: 0x171BD90 Offset: 0x171BE91 VA: 0x171BD90
	internal Group GetGroup(int groupnum) { }

	// RVA: 0x171BEC0 Offset: 0x171BFC1 VA: 0x171BEC0
	internal Group GetGroupImpl(int groupnum) { }

	// RVA: 0x171C250 Offset: 0x171C351 VA: 0x171C250 Slot: 4
	public void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x171C340 Offset: 0x171C441 VA: 0x171C340 Slot: 6
	public IEnumerator GetEnumerator() { }

	// RVA: 0x171C400 Offset: 0x171C501 VA: 0x171C400
	internal void .ctor() { }
}

