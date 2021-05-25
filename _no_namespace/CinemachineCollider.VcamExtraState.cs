private class CinemachineCollider.VcamExtraState // TypeDefIndex: 4745
{
	// Fields
	public Vector3 m_previousDisplacement; // 0x10
	public Vector3 m_previousDisplacementCorrection; // 0x1C
	public float colliderDisplacement; // 0x28
	public bool targetObscured; // 0x2C
	public float occlusionStartTime; // 0x30
	public List<Vector3> debugResolutionPath; // 0x38
	private float m_SmoothedDistance; // 0x40
	private float m_SmoothedTime; // 0x44

	// Methods

	// RVA: 0x1894980 Offset: 0x1894A81 VA: 0x1894980
	public void AddPointToDebugPath(Vector3 p) { }

	// RVA: 0x1892FE0 Offset: 0x18930E1 VA: 0x1892FE0
	public float ApplyDistanceSmoothing(float distance, float smoothingTime) { }

	// RVA: 0x1892E90 Offset: 0x1892F91 VA: 0x1892E90
	public void UpdateDistanceSmoothing(float distance, float smoothingTime) { }

	// RVA: 0x1893180 Offset: 0x1893281 VA: 0x1893180
	public void ResetDistanceSmoothing(float smoothingTime) { }

	// RVA: 0x1896130 Offset: 0x1896231 VA: 0x1896130
	public void .ctor() { }
}

