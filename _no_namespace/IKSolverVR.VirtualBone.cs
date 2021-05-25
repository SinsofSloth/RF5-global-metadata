[Serializable]
public class IKSolverVR.VirtualBone // TypeDefIndex: 9505
{
	// Fields
	public Vector3 readPosition; // 0x10
	public Quaternion readRotation; // 0x1C
	public Vector3 solverPosition; // 0x2C
	public Quaternion solverRotation; // 0x38
	public float length; // 0x48
	public float sqrMag; // 0x4C
	public Vector3 axis; // 0x50

	// Methods

	// RVA: 0x2BDC980 Offset: 0x2BDCA81 VA: 0x2BDC980
	public void .ctor(Vector3 position, Quaternion rotation) { }

	// RVA: 0x2BDCA20 Offset: 0x2BDCB21 VA: 0x2BDCA20
	public void Read(Vector3 position, Quaternion rotation) { }

	// RVA: 0x2BEB780 Offset: 0x2BEB881 VA: 0x2BEB780
	public static void SwingRotation(IKSolverVR.VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1) { }

	// RVA: 0x2BE4290 Offset: 0x2BE4391 VA: 0x2BE4290
	public static float PreSolve(ref IKSolverVR.VirtualBone[] bones) { }

	// RVA: 0x2BE47C0 Offset: 0x2BE48C1 VA: 0x2BE47C0
	public static void RotateAroundPoint(IKSolverVR.VirtualBone[] bones, int index, Vector3 point, Quaternion rotation) { }

	// RVA: 0x2BEBA10 Offset: 0x2BEBB11 VA: 0x2BEBA10
	public static void RotateBy(IKSolverVR.VirtualBone[] bones, int index, Quaternion rotation) { }

	// RVA: 0x2BE2DE0 Offset: 0x2BE2EE1 VA: 0x2BE2DE0
	public static void RotateBy(IKSolverVR.VirtualBone[] bones, Quaternion rotation) { }

	// RVA: 0x2BEBC50 Offset: 0x2BEBD51 VA: 0x2BEBC50
	public static void RotateTo(IKSolverVR.VirtualBone[] bones, int index, Quaternion rotation) { }

	// RVA: 0x2BE35A0 Offset: 0x2BE36A1 VA: 0x2BE35A0
	public static void SolveTrigonometric(IKSolverVR.VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight) { }

	// RVA: 0x2BEBD10 Offset: 0x2BEBE11 VA: 0x2BEBD10
	private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2) { }

	// RVA: 0x2BEACA0 Offset: 0x2BEADA1 VA: 0x2BEACA0
	public static void SolveFABRIK(IKSolverVR.VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset) { }

	// RVA: 0x2BEBF40 Offset: 0x2BEC041 VA: 0x2BEBF40
	private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length) { }

	// RVA: 0x2BEC050 Offset: 0x2BEC151 VA: 0x2BEC050
	public static void SolveCCD(IKSolverVR.VirtualBone[] bones, Vector3 targetPosition, float weight, int iterations) { }
}

