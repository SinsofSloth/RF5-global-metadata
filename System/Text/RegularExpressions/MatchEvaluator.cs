[Serializable]
public sealed class MatchEvaluator : MulticastDelegate // TypeDefIndex: 1766
{
	// Methods

	// RVA: 0x171D5C0 Offset: 0x171D6C1 VA: 0x171D5C0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x171D5E0 Offset: 0x171D6E1 VA: 0x171D5E0 Slot: 13
	public virtual string Invoke(Match match) { }

	// RVA: 0x171D9C0 Offset: 0x171DAC1 VA: 0x171D9C0 Slot: 14
	public virtual IAsyncResult BeginInvoke(Match match, AsyncCallback callback, object object) { }

	// RVA: 0x171D9F0 Offset: 0x171DAF1 VA: 0x171D9F0 Slot: 15
	public virtual string EndInvoke(IAsyncResult result) { }
}

