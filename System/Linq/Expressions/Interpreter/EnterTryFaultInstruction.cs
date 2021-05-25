internal sealed class EnterTryFaultInstruction : IndexedBranchInstruction // TypeDefIndex: 2375
{
	// Fields
	private TryFaultHandler _tryHandler; // 0x18

	// Properties
	public override string InstructionName { get; }
	public override int ProducedContinuations { get; }

	// Methods

	// RVA: 0x197D260 Offset: 0x197D361 VA: 0x197D260
	internal void .ctor(int targetIndex) { }

	// RVA: 0x197D290 Offset: 0x197D391 VA: 0x197D290 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x197D2E0 Offset: 0x197D3E1 VA: 0x197D2E0 Slot: 7
	public override int get_ProducedContinuations() { }

	// RVA: 0x197D2F0 Offset: 0x197D3F1 VA: 0x197D2F0
	internal void SetTryHandler(TryFaultHandler tryHandler) { }

	// RVA: 0x197D300 Offset: 0x197D401 VA: 0x197D300 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

