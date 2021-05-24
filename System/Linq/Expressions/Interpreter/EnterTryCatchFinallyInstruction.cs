internal sealed class EnterTryCatchFinallyInstruction : IndexedBranchInstruction // TypeDefIndex: 2374
{
	// Fields
	private readonly bool _hasFinally; // 0x14
	private TryCatchFinallyHandler _tryHandler; // 0x18

	// Properties
	public override int ProducedContinuations { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x197C980 Offset: 0x197CA81 VA: 0x197C980
	internal void SetTryHandler(TryCatchFinallyHandler tryHandler) { }

	// RVA: 0x197C990 Offset: 0x197CA91 VA: 0x197C990 Slot: 7
	public override int get_ProducedContinuations() { }

	// RVA: 0x197C9A0 Offset: 0x197CAA1 VA: 0x197C9A0
	private void .ctor(int targetIndex, bool hasFinally) { }

	// RVA: 0x197C9E0 Offset: 0x197CAE1 VA: 0x197C9E0
	internal static EnterTryCatchFinallyInstruction CreateTryFinally(int labelIndex) { }

	// RVA: 0x197CA50 Offset: 0x197CB51 VA: 0x197CA50
	internal static EnterTryCatchFinallyInstruction CreateTryCatch() { }

	// RVA: 0x197CAC0 Offset: 0x197CBC1 VA: 0x197CAC0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x197D150 Offset: 0x197D251 VA: 0x197D150 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x197D1B0 Offset: 0x197D2B1 VA: 0x197D1B0 Slot: 3
	public override string ToString() { }
}

