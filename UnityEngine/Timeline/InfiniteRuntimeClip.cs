internal class InfiniteRuntimeClip : RuntimeElement // TypeDefIndex: 4577
{
	// Fields
	private Playable m_Playable; // 0x18
	private static readonly long kIntervalEnd; // 0x0

	// Properties
	public override long intervalStart { get; }
	public override long intervalEnd { get; }
	public override bool enable { set; }

	// Methods

	// RVA: 0x17D7E20 Offset: 0x17D7F21 VA: 0x17D7E20
	public void .ctor(Playable playable) { }

	// RVA: 0x17E1930 Offset: 0x17E1A31 VA: 0x17E1930 Slot: 6
	public override long get_intervalStart() { }

	// RVA: 0x17E1940 Offset: 0x17E1A41 VA: 0x17E1940 Slot: 7
	public override long get_intervalEnd() { }

	// RVA: 0x17E19B0 Offset: 0x17E1AB1 VA: 0x17E19B0 Slot: 8
	public override void set_enable(bool value) { }

	// RVA: 0x17E1A30 Offset: 0x17E1B31 VA: 0x17E1A30 Slot: 9
	public override void EvaluateAt(double localTime, FrameData frameData) { }

	// RVA: 0x17E1A90 Offset: 0x17E1B91 VA: 0x17E1A90
	private static void .cctor() { }
}

