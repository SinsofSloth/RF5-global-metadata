public class HumanThrottleController : CharaThrottleController<HumanController> // TypeDefIndex: 6671
{
	// Fields
	private int m_RepeatCount; // 0x28
	private bool m_isStopped; // 0x2C

	// Methods

	// RVA: 0x20C4EC0 Offset: 0x20C4FC1 VA: 0x20C4EC0 Slot: 8
	public override void OnUpdate() { }

	// RVA: 0x20C5010 Offset: 0x20C5111 VA: 0x20C5010 Slot: 9
	public override bool DoPlay(ThrottleID throttleID) { }

	// RVA: 0x20C59A0 Offset: 0x20C5AA1 VA: 0x20C59A0 Slot: 10
	public override bool DoStop() { }

	// RVA: 0x20C5B80 Offset: 0x20C5C81 VA: 0x20C5B80
	public void .ctor() { }
}

