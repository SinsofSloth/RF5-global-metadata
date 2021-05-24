private abstract class CastInstruction.CastInstructionNoT : CastInstruction // TypeDefIndex: 2702
{
	// Fields
	private readonly Type _t; // 0x10

	// Methods

	// RVA: 0x1978BD0 Offset: 0x1978CD1 VA: 0x1978BD0
	protected void .ctor(Type t) { }

	// RVA: 0x1978B10 Offset: 0x1978C11 VA: 0x1978B10
	public static CastInstruction Create(Type t) { }

	// RVA: 0x1978C90 Offset: 0x1978D91 VA: 0x1978C90 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void ConvertNull(InterpretedFrame frame) { }
}

