internal abstract class Instruction // TypeDefIndex: 2480
{
	// Properties
	public virtual int ConsumedStack { get; }
	public virtual int ProducedStack { get; }
	public virtual int ConsumedContinuations { get; }
	public virtual int ProducedContinuations { get; }
	public abstract string InstructionName { get; }

	// Methods

	// RVA: 0x17B5E90 Offset: 0x17B5F91 VA: 0x17B5E90 Slot: 4
	public virtual int get_ConsumedStack() { }

	// RVA: 0x17B5EA0 Offset: 0x17B5FA1 VA: 0x17B5EA0 Slot: 5
	public virtual int get_ProducedStack() { }

	// RVA: 0x17B5EB0 Offset: 0x17B5FB1 VA: 0x17B5EB0 Slot: 6
	public virtual int get_ConsumedContinuations() { }

	// RVA: 0x17B5EC0 Offset: 0x17B5FC1 VA: 0x17B5EC0 Slot: 7
	public virtual int get_ProducedContinuations() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract int Run(InterpretedFrame frame) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract string get_InstructionName() { }

	// RVA: 0x17B5ED0 Offset: 0x17B5FD1 VA: 0x17B5ED0 Slot: 3
	public override string ToString() { }

	// RVA: 0x17B5F30 Offset: 0x17B6031 VA: 0x17B5F30
	protected static void NullCheck(object o) { }

	// RVA: 0x17B5F50 Offset: 0x17B6051 VA: 0x17B5F50
	protected void .ctor() { }
}

