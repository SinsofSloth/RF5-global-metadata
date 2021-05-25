public sealed class WaitWhile : CustomYieldInstruction // TypeDefIndex: 3042
{
	// Fields
	private Func<bool> m_Predicate; // 0x10

	// Properties
	public override bool keepWaiting { get; }

	// Methods

	// RVA: 0x1B7F8F0 Offset: 0x1B7F9F1 VA: 0x1B7F8F0 Slot: 7
	public override bool get_keepWaiting() { }

	// RVA: 0x1B7F950 Offset: 0x1B7FA51 VA: 0x1B7F950
	public void .ctor(Func<bool> predicate) { }
}

