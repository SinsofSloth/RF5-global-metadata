internal sealed class PopInstruction : Instruction // TypeDefIndex: 2670
{
	// Fields
	internal static readonly PopInstruction Instance; // 0x0

	// Properties
	public override int ConsumedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x191B8B0 Offset: 0x191B9B1 VA: 0x191B8B0
	private void .ctor() { }

	// RVA: 0x191B8C0 Offset: 0x191B9C1 VA: 0x191B8C0 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x191B8D0 Offset: 0x191B9D1 VA: 0x191B8D0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x191B920 Offset: 0x191BA21 VA: 0x191B920 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x191B950 Offset: 0x191BA51 VA: 0x191B950
	private static void .cctor() { }
}

