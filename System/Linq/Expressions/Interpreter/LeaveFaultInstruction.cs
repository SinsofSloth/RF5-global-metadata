internal sealed class LeaveFaultInstruction : Instruction // TypeDefIndex: 2379
{
	// Fields
	internal static readonly Instruction Instance; // 0x0

	// Properties
	public override int ConsumedStack { get; }
	public override int ConsumedContinuations { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x17BF240 Offset: 0x17BF341 VA: 0x17BF240
	private void .ctor() { }

	// RVA: 0x17BF250 Offset: 0x17BF351 VA: 0x17BF250 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x17BF260 Offset: 0x17BF361 VA: 0x17BF260 Slot: 6
	public override int get_ConsumedContinuations() { }

	// RVA: 0x17BF270 Offset: 0x17BF371 VA: 0x17BF270 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x17BF2C0 Offset: 0x17BF3C1 VA: 0x17BF2C0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x17BF2F0 Offset: 0x17BF3F1 VA: 0x17BF2F0
	private static void .cctor() { }
}

