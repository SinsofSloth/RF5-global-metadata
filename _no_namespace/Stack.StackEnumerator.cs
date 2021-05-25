[Serializable]
private class Stack.StackEnumerator : IEnumerator, ICloneable // TypeDefIndex: 1390
{
	// Fields
	private Stack _stack; // 0x10
	private int _index; // 0x18
	private int _version; // 0x1C
	private object currentElement; // 0x20

	// Properties
	public virtual object Current { get; }

	// Methods

	// RVA: 0x2976DB0 Offset: 0x2976EB1 VA: 0x2976DB0
	internal void .ctor(Stack stack) { }

	// RVA: 0x2977120 Offset: 0x2977221 VA: 0x2977120 Slot: 7
	public object Clone() { }

	// RVA: 0x2977130 Offset: 0x2977231 VA: 0x2977130 Slot: 8
	public virtual bool MoveNext() { }

	// RVA: 0x2977270 Offset: 0x2977371 VA: 0x2977270 Slot: 9
	public virtual object get_Current() { }

	// RVA: 0x2977320 Offset: 0x2977421 VA: 0x2977320 Slot: 10
	public virtual void Reset() { }
}

