internal class ByRefNewInstruction : NewInstruction // TypeDefIndex: 2607
{
	// Fields
	private readonly ByRefUpdater[] _byrefArgs; // 0x20

	// Properties
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x1977A70 Offset: 0x1977B71 VA: 0x1977A70
	internal void .ctor(ConstructorInfo target, int argumentCount, ByRefUpdater[] byrefArgs) { }

	// RVA: 0x1977AB0 Offset: 0x1977BB1 VA: 0x1977AB0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1977B00 Offset: 0x1977C01 VA: 0x1977B00 Slot: 8
	public sealed override int Run(InterpretedFrame frame) { }
}

