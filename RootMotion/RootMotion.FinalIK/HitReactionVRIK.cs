public class HitReactionVRIK : OffsetModifierVRIK // TypeDefIndex: 9556
{
	// Fields
	public AnimationCurve[] offsetCurves; // 0x30
	[TooltipAttribute] // RVA: 0x17C8C0 Offset: 0x17C9C1 VA: 0x17C8C0
	public HitReactionVRIK.PositionOffset[] positionOffsets; // 0x38
	[TooltipAttribute] // RVA: 0x17C900 Offset: 0x17CA01 VA: 0x17C900
	public HitReactionVRIK.RotationOffset[] rotationOffsets; // 0x40

	// Methods

	// RVA: 0x2B3C810 Offset: 0x2B3C911 VA: 0x2B3C810 Slot: 4
	protected override void OnModifyOffset() { }

	// RVA: 0x2B3CA40 Offset: 0x2B3CB41 VA: 0x2B3CA40
	public void Hit(Collider collider, Vector3 force, Vector3 point) { }

	// RVA: 0x2B3CDE0 Offset: 0x2B3CEE1 VA: 0x2B3CDE0
	public void .ctor() { }
}

