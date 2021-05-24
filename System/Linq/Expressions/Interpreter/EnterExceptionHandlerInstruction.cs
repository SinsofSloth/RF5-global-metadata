internal sealed class EnterExceptionHandlerInstruction : Instruction // TypeDefIndex: 2382
{
	// Fields
	internal static readonly EnterExceptionHandlerInstruction Void; // 0x0
	internal static readonly EnterExceptionHandlerInstruction NonVoid; // 0x8
	private readonly bool _hasValue; // 0x10

	// Properties
	public override string InstructionName { get; }
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }

	// Methods

	// RVA: 0x197C1C0 Offset: 0x197C2C1 VA: 0x197C1C0
	private void .ctor(bool hasValue) { }

	// RVA: 0x197C1F0 Offset: 0x197C2F1 VA: 0x197C1F0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x197C240 Offset: 0x197C341 VA: 0x197C240 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x197C250 Offset: 0x197C351 VA: 0x197C250 Slot: 5
	public override int get_ProducedStack() { }

	[ExcludeFromCodeCoverageAttribute] // RVA: 0xC0D20 Offset: 0xC0E21 VA: 0xC0D20
	// RVA: 0x197C260 Offset: 0x197C361 VA: 0x197C260 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x197C270 Offset: 0x197C371 VA: 0x197C270
	private static void .cctor() { }
}

