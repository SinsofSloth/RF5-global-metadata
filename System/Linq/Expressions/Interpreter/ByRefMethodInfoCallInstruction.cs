internal class ByRefMethodInfoCallInstruction : MethodInfoCallInstruction // TypeDefIndex: 2366
{
	// Fields
	private readonly ByRefUpdater[] _byrefArgs; // 0x20

	// Properties
	public override int ProducedStack { get; }

	// Methods

	// RVA: 0x1977210 Offset: 0x1977311 VA: 0x1977210
	internal void .ctor(MethodInfo target, int argumentCount, ByRefUpdater[] byrefArgs) { }

	// RVA: 0x1977250 Offset: 0x1977351 VA: 0x1977250 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1977300 Offset: 0x1977401 VA: 0x1977300 Slot: 8
	public sealed override int Run(InterpretedFrame frame) { }
}

