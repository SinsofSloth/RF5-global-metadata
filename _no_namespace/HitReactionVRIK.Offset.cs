[Serializable]
public abstract class HitReactionVRIK.Offset // TypeDefIndex: 9557
{
	// Fields
	[TooltipAttribute] // RVA: 0x198AC0 Offset: 0x198BC1 VA: 0x198AC0
	public string name; // 0x10
	[TooltipAttribute] // RVA: 0x198B00 Offset: 0x198C01 VA: 0x198B00
	public Collider collider; // 0x18
	[TooltipAttribute] // RVA: 0x198B40 Offset: 0x198C41 VA: 0x198B40
	[SerializeField] // RVA: 0x198B40 Offset: 0x198C41 VA: 0x198B40
	private float crossFadeTime; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x198B90 Offset: 0x198C91 VA: 0x198B90
	private float <crossFader>k__BackingField; // 0x24
	[CompilerGeneratedAttribute] // RVA: 0x198BA0 Offset: 0x198CA1 VA: 0x198BA0
	private float <timer>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x198BB0 Offset: 0x198CB1 VA: 0x198BB0
	private Vector3 <force>k__BackingField; // 0x2C
	[CompilerGeneratedAttribute] // RVA: 0x198BC0 Offset: 0x198CC1 VA: 0x198BC0
	private Vector3 <point>k__BackingField; // 0x38
	private float length; // 0x44
	private float crossFadeSpeed; // 0x48
	private float lastTime; // 0x4C

	// Properties
	protected float crossFader { get; set; }
	protected float timer { get; set; }
	protected Vector3 force { get; set; }
	protected Vector3 point { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1B57C0 Offset: 0x1B58C1 VA: 0x1B57C0
	// RVA: 0x2B3CDF0 Offset: 0x2B3CEF1 VA: 0x2B3CDF0
	protected float get_crossFader() { }

	[CompilerGeneratedAttribute] // RVA: 0x1B57D0 Offset: 0x1B58D1 VA: 0x1B57D0
	// RVA: 0x2B3CE00 Offset: 0x2B3CF01 VA: 0x2B3CE00
	private void set_crossFader(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1B57E0 Offset: 0x1B58E1 VA: 0x1B57E0
	// RVA: 0x2B3CE10 Offset: 0x2B3CF11 VA: 0x2B3CE10
	protected float get_timer() { }

	[CompilerGeneratedAttribute] // RVA: 0x1B57F0 Offset: 0x1B58F1 VA: 0x1B57F0
	// RVA: 0x2B3CE20 Offset: 0x2B3CF21 VA: 0x2B3CE20
	private void set_timer(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1B5800 Offset: 0x1B5901 VA: 0x1B5800
	// RVA: 0x2B3CE30 Offset: 0x2B3CF31 VA: 0x2B3CE30
	protected Vector3 get_force() { }

	[CompilerGeneratedAttribute] // RVA: 0x1B5810 Offset: 0x1B5911 VA: 0x1B5810
	// RVA: 0x2B3CE40 Offset: 0x2B3CF41 VA: 0x2B3CE40
	private void set_force(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1B5820 Offset: 0x1B5921 VA: 0x1B5820
	// RVA: 0x2B3CE50 Offset: 0x2B3CF51 VA: 0x2B3CE50
	protected Vector3 get_point() { }

	[CompilerGeneratedAttribute] // RVA: 0x1B5830 Offset: 0x1B5931 VA: 0x1B5830
	// RVA: 0x2B3CE60 Offset: 0x2B3CF61 VA: 0x2B3CE60
	private void set_point(Vector3 value) { }

	// RVA: 0x2B3CC90 Offset: 0x2B3CD91 VA: 0x2B3CC90
	public void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point) { }

	// RVA: 0x2B3C8E0 Offset: 0x2B3C9E1 VA: 0x2B3C8E0
	public void Apply(VRIK ik, AnimationCurve[] curves, float weight) { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract float GetLength(AnimationCurve[] curves) { }

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract void CrossFadeStart() { }

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract void OnApply(VRIK ik, AnimationCurve[] curves, float weight) { }

	// RVA: 0x2B3CE70 Offset: 0x2B3CF71 VA: 0x2B3CE70
	protected void .ctor() { }
}

