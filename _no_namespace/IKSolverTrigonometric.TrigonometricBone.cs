[Serializable]
public class IKSolverTrigonometric.TrigonometricBone : IKSolver.Bone // TypeDefIndex: 9494
{
	// Fields
	private Quaternion targetToLocalSpace; // 0x74
	private Vector3 defaultLocalBendNormal; // 0x84

	// Methods

	// RVA: 0x2BD78B0 Offset: 0x2BD79B1 VA: 0x2BD78B0
	public void Initiate(Vector3 childPosition, Vector3 bendNormal) { }

	// RVA: 0x2BD7A50 Offset: 0x2BD7B51 VA: 0x2BD7A50
	public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal) { }

	// RVA: 0x2BD7B10 Offset: 0x2BD7C11 VA: 0x2BD7B10
	public Vector3 GetBendNormalFromCurrentRotation() { }

	// RVA: 0x2BD7BE0 Offset: 0x2BD7CE1 VA: 0x2BD7BE0
	public void .ctor() { }
}

