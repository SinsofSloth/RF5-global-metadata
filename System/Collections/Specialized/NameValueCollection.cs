[DefaultMemberAttribute] // RVA: 0xBC520 Offset: 0xBC621 VA: 0xBC520
[Serializable]
public class NameValueCollection : NameObjectCollectionBase // TypeDefIndex: 2062
{
	// Fields
	private string[] _all; // 0x48
	private string[] _allKeys; // 0x50

	// Properties
	public string Item { get; set; }

	// Methods

	// RVA: 0x28E51B0 Offset: 0x28E52B1 VA: 0x28E51B0
	public void .ctor() { }

	// RVA: 0x28E5280 Offset: 0x28E5381 VA: 0x28E5280
	public void .ctor(int capacity, IEqualityComparer equalityComparer) { }

	// RVA: 0x28E5310 Offset: 0x28E5411 VA: 0x28E5310
	internal void .ctor(DBNull dummy) { }

	// RVA: 0x28E5380 Offset: 0x28E5481 VA: 0x28E5380
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x28E5410 Offset: 0x28E5511 VA: 0x28E5410
	protected void InvalidateCachedArrays() { }

	// RVA: 0x28E5450 Offset: 0x28E5551 VA: 0x28E5450
	private static string GetAsOneString(ArrayList list) { }

	// RVA: 0x28E5610 Offset: 0x28E5711 VA: 0x28E5610
	private static string[] GetAsStringArray(ArrayList list) { }

	// RVA: 0x28E56C0 Offset: 0x28E57C1 VA: 0x28E56C0 Slot: 13
	public virtual void Add(string name, string value) { }

	// RVA: 0x28E5850 Offset: 0x28E5951 VA: 0x28E5850 Slot: 14
	public virtual string Get(string name) { }

	// RVA: 0x28E58F0 Offset: 0x28E59F1 VA: 0x28E58F0 Slot: 15
	public virtual string[] GetValues(string name) { }

	// RVA: 0x28E5A30 Offset: 0x28E5B31 VA: 0x28E5A30 Slot: 16
	public virtual void Set(string name, string value) { }

	// RVA: 0x28E5B40 Offset: 0x28E5C41 VA: 0x28E5B40 Slot: 17
	public virtual void Remove(string name) { }

	// RVA: 0x28E5B90 Offset: 0x28E5C91 VA: 0x28E5B90
	public string get_Item(string name) { }

	// RVA: 0x28E5BA0 Offset: 0x28E5CA1 VA: 0x28E5BA0
	public void set_Item(string name, string value) { }

	// RVA: 0x28E5BB0 Offset: 0x28E5CB1 VA: 0x28E5BB0 Slot: 18
	public virtual string Get(int index) { }

	// RVA: 0x28E5CD0 Offset: 0x28E5DD1 VA: 0x28E5CD0 Slot: 19
	public virtual string GetKey(int index) { }
}

