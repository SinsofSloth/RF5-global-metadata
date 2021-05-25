[DebuggerDisplayAttribute] // RVA: 0xB2F30 Offset: 0xB3031 VA: 0xB2F30
[ComVisibleAttribute] // RVA: 0xB2F30 Offset: 0xB3031 VA: 0xB2F30
[DebuggerTypeProxyAttribute] // RVA: 0xB2F30 Offset: 0xB3031 VA: 0xB2F30
[Serializable]
public class Queue : ICollection, IEnumerable, ICloneable // TypeDefIndex: 1380
{
	// Fields
	private object[] _array; // 0x10
	private int _head; // 0x18
	private int _tail; // 0x1C
	private int _size; // 0x20
	private int _growFactor; // 0x24
	private int _version; // 0x28

	// Properties
	public virtual int Count { get; }

	// Methods

	// RVA: 0x2971CA0 Offset: 0x2971DA1 VA: 0x2971CA0
	public void .ctor() { }

	// RVA: 0x2971F00 Offset: 0x2972001 VA: 0x2971F00
	public void .ctor(int capacity) { }

	// RVA: 0x2971D20 Offset: 0x2971E21 VA: 0x2971D20
	public void .ctor(int capacity, float growFactor) { }

	// RVA: 0x2971F10 Offset: 0x2972011 VA: 0x2971F10
	public void .ctor(ICollection col) { }

	// RVA: 0x29721E0 Offset: 0x29722E1 VA: 0x29721E0 Slot: 8
	public virtual int get_Count() { }

	// RVA: 0x29721F0 Offset: 0x29722F1 VA: 0x29721F0 Slot: 9
	public virtual object Clone() { }

	// RVA: 0x29722E0 Offset: 0x29723E1 VA: 0x29722E0 Slot: 10
	public virtual void Clear() { }

	// RVA: 0x2972360 Offset: 0x2972461 VA: 0x2972360 Slot: 11
	public virtual void CopyTo(Array array, int index) { }

	// RVA: 0x2972550 Offset: 0x2972651 VA: 0x2972550 Slot: 12
	public virtual void Enqueue(object obj) { }

	// RVA: 0x2972760 Offset: 0x2972861 VA: 0x2972760 Slot: 13
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x29728B0 Offset: 0x29729B1 VA: 0x29728B0 Slot: 14
	public virtual object Dequeue() { }

	// RVA: 0x29729D0 Offset: 0x2972AD1 VA: 0x29729D0 Slot: 15
	public virtual object Peek() { }

	// RVA: 0x2972AA0 Offset: 0x2972BA1 VA: 0x2972AA0
	internal object GetElement(int i) { }

	// RVA: 0x2972AF0 Offset: 0x2972BF1 VA: 0x2972AF0 Slot: 16
	public virtual object[] ToArray() { }

	// RVA: 0x2972660 Offset: 0x2972761 VA: 0x2972660
	private void SetCapacity(int capacity) { }
}

