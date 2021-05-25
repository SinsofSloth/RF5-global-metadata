private class SimpleAnimationPlayable.StateEnumerable.StateEnumerator : IEnumerator<SimpleAnimationPlayable.IState>, IEnumerator, IDisposable // TypeDefIndex: 5931
{
	// Fields
	private int m_Index; // 0x10
	private int m_Version; // 0x14
	private SimpleAnimationPlayable m_Owner; // 0x18

	// Properties
	private object System.Collections.IEnumerator.Current { get; }
	private SimpleAnimationPlayable.IState System.Collections.Generic.IEnumerator<SimpleAnimationPlayable.IState>.Current { get; }

	// Methods

	// RVA: 0x1B8D7B0 Offset: 0x1B8D8B1 VA: 0x1B8D7B0
	public void .ctor(SimpleAnimationPlayable owner) { }

	// RVA: 0x1B8D9A0 Offset: 0x1B8DAA1 VA: 0x1B8D9A0
	private bool IsValid() { }

	// RVA: 0x1B8D9D0 Offset: 0x1B8DAD1 VA: 0x1B8D9D0
	private SimpleAnimationPlayable.IState GetCurrentHandle(int index) { }

	// RVA: 0x1B8DB50 Offset: 0x1B8DC51 VA: 0x1B8DB50 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x1B8DB60 Offset: 0x1B8DC61 VA: 0x1B8DB60 Slot: 4
	private SimpleAnimationPlayable.IState System.Collections.Generic.IEnumerator<SimpleAnimationPlayable.IState>.get_Current() { }

	// RVA: 0x1B8DB70 Offset: 0x1B8DC71 VA: 0x1B8DB70 Slot: 5
	public void Dispose() { }

	// RVA: 0x1B8DB80 Offset: 0x1B8DC81 VA: 0x1B8DB80 Slot: 6
	public bool MoveNext() { }

	// RVA: 0x1B8D900 Offset: 0x1B8DA01 VA: 0x1B8D900 Slot: 8
	public void Reset() { }
}

