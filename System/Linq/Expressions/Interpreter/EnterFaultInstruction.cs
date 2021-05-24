internal sealed class EnterFaultInstruction : IndexedBranchInstruction // TypeDefIndex: 2378
{
	// Fields
	private static readonly EnterFaultInstruction[] s_cache; // 0x0

	// Properties
	public override string InstructionName { get; }
	public override int ProducedStack { get; }

	// Methods

	// RVA: 0x197C310 Offset: 0x197C411 VA: 0x197C310
	private void .ctor(int labelIndex) { }

	// RVA: 0x197C370 Offset: 0x197C471 VA: 0x197C370 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x197C3C0 Offset: 0x197C4C1 VA: 0x197C3C0 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x197C3D0 Offset: 0x197C4D1 VA: 0x197C3D0
	internal static EnterFaultInstruction Create(int labelIndex) { }

	// RVA: 0x197C520 Offset: 0x197C621 VA: 0x197C520 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x197C610 Offset: 0x197C711 VA: 0x197C610
	private static void .cctor() { }
}

