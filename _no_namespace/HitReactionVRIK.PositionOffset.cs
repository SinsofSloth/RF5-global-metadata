[Serializable]
public class HitReactionVRIK.PositionOffset : HitReactionVRIK.Offset // TypeDefIndex: 9558
{
	// Fields
	[TooltipAttribute] // RVA: 0x198BD0 Offset: 0x198CD1 VA: 0x198BD0
	public int forceDirCurveIndex; // 0x50
	[TooltipAttribute] // RVA: 0x198C10 Offset: 0x198D11 VA: 0x198C10
	public int upDirCurveIndex; // 0x54
	[TooltipAttribute] // RVA: 0x198C50 Offset: 0x198D51 VA: 0x198C50
	public HitReactionVRIK.PositionOffset.PositionOffsetLink[] offsetLinks; // 0x58

	// Methods

	// RVA: 0x2B3CE90 Offset: 0x2B3CF91 VA: 0x2B3CE90 Slot: 4
	protected override float GetLength(AnimationCurve[] curves) { }

	// RVA: 0x2B3D0A0 Offset: 0x2B3D1A1 VA: 0x2B3D0A0 Slot: 5
	protected override void CrossFadeStart() { }

	// RVA: 0x2B3D130 Offset: 0x2B3D231 VA: 0x2B3D130 Slot: 6
	protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight) { }

	// RVA: 0x2B3D460 Offset: 0x2B3D561 VA: 0x2B3D460
	public void .ctor() { }
}

