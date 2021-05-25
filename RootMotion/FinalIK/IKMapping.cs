[Serializable]
public class IKMapping // TypeDefIndex: 9465
{
	// Methods

	// RVA: 0x2B40800 Offset: 0x2B40901 VA: 0x2B40800 Slot: 4
	public virtual bool IsValid(IKSolver solver, ref string message) { }

	// RVA: 0x2B40810 Offset: 0x2B40911 VA: 0x2B40810 Slot: 5
	public virtual void Initiate(IKSolverFullBody solver) { }

	// RVA: 0x2B40820 Offset: 0x2B40921 VA: 0x2B40820
	protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, Warning.Logger logger) { }

	// RVA: 0x2B40960 Offset: 0x2B40A61 VA: 0x2B40960
	protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length) { }

	// RVA: 0x2B40A70 Offset: 0x2B40B71 VA: 0x2B40A70
	public void .ctor() { }
}

