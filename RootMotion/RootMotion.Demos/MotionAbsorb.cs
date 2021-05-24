public class MotionAbsorb : OffsetModifier // TypeDefIndex: 9364
{
	// Fields
	[TooltipAttribute] // RVA: 0x178370 Offset: 0x178471 VA: 0x178370
	public MotionAbsorb.Mode mode; // 0x2C
	[TooltipAttribute] // RVA: 0x1783B0 Offset: 0x1784B1 VA: 0x1783B0
	public MotionAbsorb.Absorber[] absorbers; // 0x30
	[TooltipAttribute] // RVA: 0x1783F0 Offset: 0x1784F1 VA: 0x1783F0
	public AnimationCurve falloff; // 0x38
	[TooltipAttribute] // RVA: 0x178430 Offset: 0x178531 VA: 0x178430
	public float falloffSpeed; // 0x40
	private float timer; // 0x44
	private float w; // 0x48
	private MotionAbsorb.Mode initialMode; // 0x4C

	// Methods

	// RVA: 0x26CE220 Offset: 0x26CE321 VA: 0x26CE220 Slot: 5
	protected override void Start() { }

	// RVA: 0x26CE310 Offset: 0x26CE411 VA: 0x26CE310
	private void OnCollisionEnter(Collision c) { }

	// RVA: 0x26CE3A0 Offset: 0x26CE4A1 VA: 0x26CE3A0 Slot: 4
	protected override void OnModifyOffset() { }

	// RVA: 0x26CE4C0 Offset: 0x26CE5C1 VA: 0x26CE4C0
	private void AfterIK() { }

	// RVA: 0x26CE550 Offset: 0x26CE651 VA: 0x26CE550 Slot: 6
	protected override void OnDestroy() { }

	// RVA: 0x26CE680 Offset: 0x26CE781 VA: 0x26CE680
	public void .ctor() { }
}

