[Serializable]
public class IKSolver.Point // TypeDefIndex: 9472
{
	// Fields
	public Transform transform; // 0x10
	[RangeAttribute] // RVA: 0x1967B0 Offset: 0x1968B1 VA: 0x1967B0
	public float weight; // 0x18
	public Vector3 solverPosition; // 0x1C
	public Quaternion solverRotation; // 0x28
	public Vector3 defaultLocalPosition; // 0x38
	public Quaternion defaultLocalRotation; // 0x44

	// Methods

	// RVA: 0x25817A0 Offset: 0x25818A1 VA: 0x25817A0
	public void StoreDefaultLocalState() { }

	// RVA: 0x2581800 Offset: 0x2581901 VA: 0x2581800
	public void FixTransform() { }

	// RVA: 0x2581990 Offset: 0x2581A91 VA: 0x2581990
	public void UpdateSolverPosition() { }

	// RVA: 0x25819D0 Offset: 0x2581AD1 VA: 0x25819D0
	public void UpdateSolverLocalPosition() { }

	// RVA: 0x2581A10 Offset: 0x2581B11 VA: 0x2581A10
	public void UpdateSolverState() { }

	// RVA: 0x2581A70 Offset: 0x2581B71 VA: 0x2581A70
	public void UpdateSolverLocalState() { }

	// RVA: 0x2580FA0 Offset: 0x25810A1 VA: 0x2580FA0
	public void .ctor() { }
}

