[Serializable]
public abstract class HitReaction.HitPoint // TypeDefIndex: 9551
{
	// Fields
	[TooltipAttribute] // RVA: 0x198870 Offset: 0x198971 VA: 0x198870
	public string name; // 0x10
	[TooltipAttribute] // RVA: 0x1988B0 Offset: 0x1989B1 VA: 0x1988B0
	public Collider collider; // 0x18
	[TooltipAttribute] // RVA: 0x1988F0 Offset: 0x1989F1 VA: 0x1988F0
	[SerializeField] // RVA: 0x1988F0 Offset: 0x1989F1 VA: 0x1988F0
	private float crossFadeTime; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x198940 Offset: 0x198A41 VA: 0x198940
	private float <crossFader>k__BackingField; // 0x24
	[CompilerGeneratedAttribute] // RVA: 0x198950 Offset: 0x198A51 VA: 0x198950
	private float <timer>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x198960 Offset: 0x198A61 VA: 0x198960
	private Vector3 <force>k__BackingField; // 0x2C
	[CompilerGeneratedAttribute] // RVA: 0x198970 Offset: 0x198A71 VA: 0x198970
	private Vector3 <point>k__BackingField; // 0x38
	private float length; // 0x44
	private float crossFadeSpeed; // 0x48
	private float lastTime; // 0x4C

	// Properties
	public bool inProgress { get; }
	protected float crossFader { get; set; }
	protected float timer { get; set; }
	protected Vector3 force { get; set; }
	protected Vector3 point { get; set; }

	// Methods

	// RVA: 0x2B3B660 Offset: 0x2B3B761 VA: 0x2B3B660
	public bool get_inProgress() { }

	[CompilerGeneratedAttribute] // RVA: 0x1B5740 Offset: 0x1B5841 VA: 0x1B5740
	// RVA: 0x2B3BC30 Offset: 0x2B3BD31 VA: 0x2B3BC30
	protected float get_crossFader() { }

	[CompilerGeneratedAttribute] // RVA: 0x1B5750 Offset: 0x1B5851 VA: 0x1B5750
	// RVA: 0x2B3BC40 Offset: 0x2B3BD41 VA: 0x2B3BC40
	private void set_crossFader(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1B5760 Offset: 0x1B5861 VA: 0x1B5760
	// RVA: 0x2B3BC50 Offset: 0x2B3BD51 VA: 0x2B3BC50
	protected float get_timer() { }

	[CompilerGeneratedAttribute] // RVA: 0x1B5770 Offset: 0x1B5871 VA: 0x1B5770
	// RVA: 0x2B3BC60 Offset: 0x2B3BD61 VA: 0x2B3BC60
	private void set_timer(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1B5780 Offset: 0x1B5881 VA: 0x1B5780
	// RVA: 0x2B3BC70 Offset: 0x2B3BD71 VA: 0x2B3BC70
	protected Vector3 get_force() { }

	[CompilerGeneratedAttribute] // RVA: 0x1B5790 Offset: 0x1B5891 VA: 0x1B5790
	// RVA: 0x2B3BC80 Offset: 0x2B3BD81 VA: 0x2B3BC80
	private void set_force(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1B57A0 Offset: 0x1B58A1 VA: 0x1B57A0
	// RVA: 0x2B3BC90 Offset: 0x2B3BD91 VA: 0x2B3BC90
	protected Vector3 get_point() { }

	[CompilerGeneratedAttribute] // RVA: 0x1B57B0 Offset: 0x1B58B1 VA: 0x1B57B0
	// RVA: 0x2B3BCA0 Offset: 0x2B3BDA1 VA: 0x2B3BCA0
	private void set_point(Vector3 value) { }

	// RVA: 0x2B3BAF0 Offset: 0x2B3BBF1 VA: 0x2B3BAF0
	public void Hit(Vector3 force, Vector3 point) { }

	// RVA: 0x2B3B760 Offset: 0x2B3B861 VA: 0x2B3B760
	public void Apply(IKSolverFullBodyBiped solver, float weight) { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract float GetLength() { }

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract void CrossFadeStart() { }

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract void OnApply(IKSolverFullBodyBiped solver, float weight) { }

	// RVA: 0x2B3BCB0 Offset: 0x2B3BDB1 VA: 0x2B3BCB0
	protected void .ctor() { }
}

