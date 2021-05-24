internal abstract class IndexedBranchInstruction : Instruction // TypeDefIndex: 2372
{
	// Fields
	internal readonly int _labelIndex; // 0x10

	// Methods

	// RVA: 0x197C340 Offset: 0x197C441 VA: 0x197C340
	public void .ctor(int labelIndex) { }

	// RVA: 0x197C5B0 Offset: 0x197C6B1 VA: 0x197C5B0
	public RuntimeLabel GetLabel(InterpretedFrame frame) { }

	// RVA: 0x19850B0 Offset: 0x19851B1 VA: 0x19850B0 Slot: 3
	public override string ToString() { }
}

