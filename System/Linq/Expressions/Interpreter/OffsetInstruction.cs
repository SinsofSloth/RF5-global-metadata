internal abstract class OffsetInstruction : Instruction // TypeDefIndex: 2367
{
	// Fields
	protected int _offset; // 0x10

	// Properties
	public abstract Instruction[] Cache { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 10
	public abstract Instruction[] get_Cache() { }

	// RVA: 0x191A6D0 Offset: 0x191A7D1 VA: 0x191A6D0
	public Instruction Fixup(int offset) { }

	// RVA: 0x191A790 Offset: 0x191A891 VA: 0x191A790 Slot: 3
	public override string ToString() { }

	// RVA: 0x191A860 Offset: 0x191A961 VA: 0x191A860
	protected void .ctor() { }
}

