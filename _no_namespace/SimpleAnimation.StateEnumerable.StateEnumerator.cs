private class SimpleAnimation.StateEnumerable.StateEnumerator : IEnumerator<SimpleAnimation.State>, IEnumerator, IDisposable // TypeDefIndex: 5926
{
	// Fields
	private SimpleAnimation m_Owner; // 0x10
	private IEnumerator<SimpleAnimationPlayable.IState> m_Impl; // 0x18

	// Properties
	private object System.Collections.IEnumerator.Current { get; }
	private SimpleAnimation.State System.Collections.Generic.IEnumerator<SimpleAnimation.State>.Current { get; }

	// Methods

	// RVA: 0x1B88CA0 Offset: 0x1B88DA1 VA: 0x1B88CA0
	public void .ctor(SimpleAnimation owner) { }

	// RVA: 0x1B89020 Offset: 0x1B89121 VA: 0x1B89020
	private SimpleAnimation.State GetCurrent() { }

	// RVA: 0x1B89130 Offset: 0x1B89231 VA: 0x1B89130 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x1B89140 Offset: 0x1B89241 VA: 0x1B89140 Slot: 4
	private SimpleAnimation.State System.Collections.Generic.IEnumerator<SimpleAnimation.State>.get_Current() { }

	// RVA: 0x1B89150 Offset: 0x1B89251 VA: 0x1B89150 Slot: 5
	public void Dispose() { }

	// RVA: 0x1B89160 Offset: 0x1B89261 VA: 0x1B89160 Slot: 6
	public bool MoveNext() { }

	// RVA: 0x1B88F60 Offset: 0x1B89061 VA: 0x1B88F60 Slot: 8
	public void Reset() { }
}

