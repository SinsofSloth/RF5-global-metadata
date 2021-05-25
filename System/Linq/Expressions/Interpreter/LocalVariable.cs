internal sealed class LocalVariable // TypeDefIndex: 2567
{
	// Fields
	public readonly int Index; // 0x10
	private int _flags; // 0x14

	// Properties
	public bool IsBoxed { get; set; }
	public bool InClosure { get; }

	// Methods

	// RVA: 0x190F940 Offset: 0x190FA41 VA: 0x190F940
	public bool get_IsBoxed() { }

	// RVA: 0x190F950 Offset: 0x190FA51 VA: 0x190F950
	public void set_IsBoxed(bool value) { }

	// RVA: 0x190F970 Offset: 0x190FA71 VA: 0x190F970
	public bool get_InClosure() { }

	// RVA: 0x190F980 Offset: 0x190FA81 VA: 0x190F980
	internal void .ctor(int index, bool closure) { }

	// RVA: 0x190F9D0 Offset: 0x190FAD1 VA: 0x190F9D0 Slot: 3
	public override string ToString() { }
}

