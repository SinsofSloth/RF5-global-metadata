internal sealed class EnterFinallyInstruction : IndexedBranchInstruction // TypeDefIndex: 2376
{
	// Fields
	private static readonly EnterFinallyInstruction[] s_cache; // 0x0

	// Properties
	public override string InstructionName { get; }
	public override int ProducedStack { get; }
	public override int ConsumedContinuations { get; }

	// Methods

	// RVA: 0x197C680 Offset: 0x197C781 VA: 0x197C680
	private void .ctor(int labelIndex) { }

	// RVA: 0x197C6B0 Offset: 0x197C7B1 VA: 0x197C6B0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x197C700 Offset: 0x197C801 VA: 0x197C700 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x197C710 Offset: 0x197C811 VA: 0x197C710 Slot: 6
	public override int get_ConsumedContinuations() { }

	// RVA: 0x197C720 Offset: 0x197C821 VA: 0x197C720
	internal static EnterFinallyInstruction Create(int labelIndex) { }

	// RVA: 0x197C870 Offset: 0x197C971 VA: 0x197C870 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x197C910 Offset: 0x197CA11 VA: 0x197C910
	private static void .cctor() { }
}

