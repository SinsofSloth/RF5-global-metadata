[Serializable]
public class HitReactionVRIK.RotationOffset : HitReactionVRIK.Offset // TypeDefIndex: 9560
{
	// Fields
	[TooltipAttribute] // RVA: 0x198C90 Offset: 0x198D91 VA: 0x198C90
	public int curveIndex; // 0x50
	[TooltipAttribute] // RVA: 0x198CD0 Offset: 0x198DD1 VA: 0x198CD0
	public HitReactionVRIK.RotationOffset.RotationOffsetLink[] offsetLinks; // 0x58
	private Rigidbody rigidbody; // 0x60

	// Methods

	// RVA: 0x2B3D490 Offset: 0x2B3D591 VA: 0x2B3D490 Slot: 4
	protected override float GetLength(AnimationCurve[] curves) { }

	// RVA: 0x2B3D580 Offset: 0x2B3D681 VA: 0x2B3D580 Slot: 5
	protected override void CrossFadeStart() { }

	// RVA: 0x2B3D610 Offset: 0x2B3D711 VA: 0x2B3D610 Slot: 6
	protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight) { }

	// RVA: 0x2B3DA60 Offset: 0x2B3DB61 VA: 0x2B3DA60
	public void .ctor() { }
}

