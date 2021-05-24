[Serializable]
private sealed class ArrayList.ArrayListEnumeratorSimple : IEnumerator, ICloneable // TypeDefIndex: 1346
{
	// Fields
	private ArrayList list; // 0x10
	private int index; // 0x18
	private int version; // 0x1C
	private object currentElement; // 0x20
	private bool isArrayList; // 0x28
	private static object dummyObject; // 0x0

	// Properties
	public object Current { get; }

	// Methods

	// RVA: 0x185A1E0 Offset: 0x185A2E1 VA: 0x185A1E0
	internal void .ctor(ArrayList list) { }

	// RVA: 0x185AF20 Offset: 0x185B021 VA: 0x185AF20 Slot: 7
	public object Clone() { }

	// RVA: 0x185AF30 Offset: 0x185B031 VA: 0x185AF30 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x185B140 Offset: 0x185B241 VA: 0x185B140 Slot: 5
	public object get_Current() { }

	// RVA: 0x185B230 Offset: 0x185B331 VA: 0x185B230 Slot: 6
	public void Reset() { }

	// RVA: 0x185B320 Offset: 0x185B421 VA: 0x185B320
	private static void .cctor() { }
}

