public abstract class Poser : SolverManager // TypeDefIndex: 9529
{
	// Fields
	public Transform poseRoot; // 0x38
	[RangeAttribute] // RVA: 0x17BE90 Offset: 0x17BF91 VA: 0x17BE90
	public float weight; // 0x40
	[RangeAttribute] // RVA: 0x17BEB0 Offset: 0x17BFB1 VA: 0x17BEB0
	public float localRotationWeight; // 0x44
	[RangeAttribute] // RVA: 0x17BED0 Offset: 0x17BFD1 VA: 0x17BED0
	public float localPositionWeight; // 0x48
	private bool initiated; // 0x4C

	// Methods

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void AutoMapping() { }

	// RVA: 0x291CC90 Offset: 0x291CD91 VA: 0x291CC90
	public void UpdateManual() { }

	// RVA: -1 Offset: -1 Slot: 8
	protected abstract void InitiatePoser() { }

	// RVA: -1 Offset: -1 Slot: 9
	protected abstract void UpdatePoser() { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void FixPoserTransforms() { }

	// RVA: 0x291CCA0 Offset: 0x291CDA1 VA: 0x291CCA0 Slot: 5
	protected override void UpdateSolver() { }

	// RVA: 0x291CD00 Offset: 0x291CE01 VA: 0x291CD00 Slot: 4
	protected override void InitiateSolver() { }

	// RVA: 0x291CD40 Offset: 0x291CE41 VA: 0x291CD40 Slot: 6
	protected override void FixTransforms() { }

	// RVA: 0x291CD60 Offset: 0x291CE61 VA: 0x291CD60
	protected void .ctor() { }
}

