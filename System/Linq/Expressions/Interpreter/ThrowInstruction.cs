internal sealed class ThrowInstruction : Instruction // TypeDefIndex: 2384
{
	// Fields
	internal static readonly ThrowInstruction Throw; // 0x0
	internal static readonly ThrowInstruction VoidThrow; // 0x8
	internal static readonly ThrowInstruction Rethrow; // 0x10
	internal static readonly ThrowInstruction VoidRethrow; // 0x18
	private static ConstructorInfo _runtimeWrappedExceptionCtor; // 0x20
	private readonly bool _hasResult; // 0x10
	private readonly bool _rethrow; // 0x11

	// Properties
	public override string InstructionName { get; }
	public override int ProducedStack { get; }
	public override int ConsumedStack { get; }

	// Methods

	// RVA: 0x19201B0 Offset: 0x19202B1 VA: 0x19201B0
	private void .ctor(bool hasResult, bool isRethrow) { }

	// RVA: 0x1920200 Offset: 0x1920301 VA: 0x1920200 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1920250 Offset: 0x1920351 VA: 0x1920250 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1920260 Offset: 0x1920361 VA: 0x1920260 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x1920270 Offset: 0x1920371 VA: 0x1920270 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19203B0 Offset: 0x19204B1 VA: 0x19203B0
	private static Exception WrapThrownObject(object thrown) { }

	// RVA: 0x1920460 Offset: 0x1920561 VA: 0x1920460
	private static RuntimeWrappedException RuntimeWrap(object thrown) { }

	// RVA: 0x1920680 Offset: 0x1920781 VA: 0x1920680
	private static void .cctor() { }
}

