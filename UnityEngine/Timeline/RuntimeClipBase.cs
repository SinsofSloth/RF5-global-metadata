internal abstract class RuntimeClipBase : RuntimeElement // TypeDefIndex: 4583
{
	// Properties
	public abstract double start { get; }
	public abstract double duration { get; }
	public override long intervalStart { get; }
	public override long intervalEnd { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 11
	public abstract double get_start() { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract double get_duration() { }

	// RVA: 0x17E4EF0 Offset: 0x17E4FF1 VA: 0x17E4EF0 Slot: 6
	public override long get_intervalStart() { }

	// RVA: 0x17E4F70 Offset: 0x17E5071 VA: 0x17E4F70 Slot: 7
	public override long get_intervalEnd() { }

	// RVA: 0x17E4950 Offset: 0x17E4A51 VA: 0x17E4950
	protected void .ctor() { }
}

