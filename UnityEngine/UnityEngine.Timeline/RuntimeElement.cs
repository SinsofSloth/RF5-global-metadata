internal abstract class RuntimeElement : IInterval // TypeDefIndex: 4584
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x12BB80 Offset: 0x12BC81 VA: 0x12BB80
	private int <intervalBit>k__BackingField; // 0x10

	// Properties
	public abstract long intervalStart { get; }
	public abstract long intervalEnd { get; }
	public int intervalBit { get; set; }
	public abstract bool enable { set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 6
	public abstract long get_intervalStart() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract long get_intervalEnd() { }

	[CompilerGeneratedAttribute] // RVA: 0x12C330 Offset: 0x12C431 VA: 0x12C330
	// RVA: 0x17E5010 Offset: 0x17E5111 VA: 0x17E5010
	public int get_intervalBit() { }

	[CompilerGeneratedAttribute] // RVA: 0x12C340 Offset: 0x12C441 VA: 0x12C340
	// RVA: 0x17E5020 Offset: 0x17E5121 VA: 0x17E5020
	public void set_intervalBit(int value) { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void set_enable(bool value) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void EvaluateAt(double localTime, FrameData frameData) { }

	// RVA: 0x17E5030 Offset: 0x17E5131 VA: 0x17E5030 Slot: 10
	public virtual void Reset() { }

	// RVA: 0x17E1920 Offset: 0x17E1A21 VA: 0x17E1920
	protected void .ctor() { }
}

