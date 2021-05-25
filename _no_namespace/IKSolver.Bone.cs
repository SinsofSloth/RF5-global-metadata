[Serializable]
public class IKSolver.Bone : IKSolver.Point // TypeDefIndex: 9473
{
	// Fields
	public float length; // 0x54
	public float sqrMag; // 0x58
	public Vector3 axis; // 0x5C
	private RotationLimit _rotationLimit; // 0x68
	private bool isLimited; // 0x70

	// Properties
	public RotationLimit rotationLimit { get; set; }

	// Methods

	// RVA: 0x25804C0 Offset: 0x25805C1 VA: 0x25804C0
	public RotationLimit get_rotationLimit() { }

	// RVA: 0x25805D0 Offset: 0x25806D1 VA: 0x25805D0
	public void set_rotationLimit(RotationLimit value) { }

	// RVA: 0x2580670 Offset: 0x2580771 VA: 0x2580670
	public void Swing(Vector3 swingTarget, float weight = 1) { }

	// RVA: 0x2580930 Offset: 0x2580A31 VA: 0x2580930
	public static void SolverSwing(IKSolver.Bone[] bones, int index, Vector3 swingTarget, float weight = 1) { }

	// RVA: 0x2580C10 Offset: 0x2580D11 VA: 0x2580C10
	public void Swing2D(Vector3 swingTarget, float weight = 1) { }

	// RVA: 0x2580E80 Offset: 0x2580F81 VA: 0x2580E80
	public void SetToSolverPosition() { }

	// RVA: 0x2580EB0 Offset: 0x2580FB1 VA: 0x2580EB0
	public void .ctor() { }

	// RVA: 0x2581030 Offset: 0x2581131 VA: 0x2581030
	public void .ctor(Transform transform) { }

	// RVA: 0x2581130 Offset: 0x2581231 VA: 0x2581130
	public void .ctor(Transform transform, float weight) { }
}

