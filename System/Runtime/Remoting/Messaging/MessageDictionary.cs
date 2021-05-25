[DefaultMemberAttribute] // RVA: 0xB1330 Offset: 0xB1431 VA: 0xB1330
[Serializable]
internal class MessageDictionary : IDictionary, ICollection, IEnumerable // TypeDefIndex: 1221
{
	// Fields
	private IDictionary _internalProperties; // 0x10
	protected IMethodMessage _message; // 0x18
	private string[] _methodKeys; // 0x20
	private bool _ownProperties; // 0x28

	// Properties
	internal IDictionary InternalDictionary { get; }
	public string[] MethodKeys { set; }
	public object Item { get; set; }
	public ICollection Keys { get; }
	public ICollection Values { get; }
	public int Count { get; }

	// Methods

	// RVA: 0x1751F60 Offset: 0x1752061 VA: 0x1751F60
	public void .ctor(IMethodMessage message) { }

	// RVA: 0x174E450 Offset: 0x174E551 VA: 0x174E450
	internal bool HasUserData() { }

	// RVA: 0x174E570 Offset: 0x174E671 VA: 0x174E570
	internal IDictionary get_InternalDictionary() { }

	// RVA: 0x1755850 Offset: 0x1755951 VA: 0x1755850
	public void set_MethodKeys(string[] value) { }

	// RVA: 0x1755860 Offset: 0x1755961 VA: 0x1755860 Slot: 13
	protected virtual IDictionary AllocInternalProperties() { }

	// RVA: 0x1751150 Offset: 0x1751251 VA: 0x1751150
	public IDictionary GetInternalProperties() { }

	// RVA: 0x17558D0 Offset: 0x17559D1 VA: 0x17558D0
	private bool IsOverridenKey(string key) { }

	// RVA: 0x1755960 Offset: 0x1755A61 VA: 0x1755960 Slot: 4
	public object get_Item(object key) { }

	// RVA: 0x1755AC0 Offset: 0x1755BC1 VA: 0x1755AC0 Slot: 5
	public void set_Item(object key, object value) { }

	// RVA: 0x17523A0 Offset: 0x17524A1 VA: 0x17523A0 Slot: 14
	protected virtual object GetMethodProperty(string key) { }

	// RVA: 0x1752BE0 Offset: 0x1752CE1 VA: 0x1752BE0 Slot: 15
	protected virtual void SetMethodProperty(string key, object value) { }

	// RVA: 0x1755C60 Offset: 0x1755D61 VA: 0x1755C60 Slot: 6
	public ICollection get_Keys() { }

	// RVA: 0x1756200 Offset: 0x1756301 VA: 0x1756200 Slot: 16
	public ICollection get_Values() { }

	// RVA: 0x1755AD0 Offset: 0x1755BD1 VA: 0x1755AD0 Slot: 8
	public void Add(object key, object value) { }

	// RVA: 0x1756640 Offset: 0x1756741 VA: 0x1756640 Slot: 7
	public bool Contains(object key) { }

	// RVA: 0x17567A0 Offset: 0x17568A1 VA: 0x17567A0 Slot: 11
	public int get_Count() { }

	// RVA: 0x1756880 Offset: 0x1756981 VA: 0x1756880 Slot: 10
	public void CopyTo(Array array, int index) { }

	// RVA: 0x1756950 Offset: 0x1756A51 VA: 0x1756950 Slot: 12
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1756AE0 Offset: 0x1756BE1 VA: 0x1756AE0 Slot: 9
	public IDictionaryEnumerator GetEnumerator() { }
}

