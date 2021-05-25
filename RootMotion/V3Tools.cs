public static class V3Tools // TypeDefIndex: 9327
{
	// Methods

	// RVA: 0x1D66E40 Offset: 0x1D66F41 VA: 0x1D66E40
	public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight) { }

	// RVA: 0x1D66F40 Offset: 0x1D67041 VA: 0x1D66F40
	public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight) { }

	// RVA: 0x1D67040 Offset: 0x1D67141 VA: 0x1D67040
	public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight) { }

	// RVA: 0x1D67140 Offset: 0x1D67241 VA: 0x1D67140
	public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight) { }

	// RVA: 0x1D67250 Offset: 0x1D67351 VA: 0x1D67250
	public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing) { }

	// RVA: 0x1D67480 Offset: 0x1D67581 VA: 0x1D67480
	public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed) { }

	// RVA: 0x1D676C0 Offset: 0x1D677C1 VA: 0x1D676C0
	public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue) { }

	// RVA: 0x1D67910 Offset: 0x1D67A11 VA: 0x1D67910
	public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint) { }

	// RVA: 0x1D67B10 Offset: 0x1D67C11 VA: 0x1D67B10
	public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal) { }

	// RVA: 0x1D67CF0 Offset: 0x1D67DF1 VA: 0x1D67CF0
	public static Vector3 TransformPointUnscaled(Transform t, Vector3 point) { }

	// RVA: 0x1D67E30 Offset: 0x1D67F31 VA: 0x1D67E30
	public static Vector3 InverseTransformPointUnscaled(Transform t, Vector3 point) { }
}

