public struct LODParameters : IEquatable<LODParameters> // TypeDefIndex: 3324
{
	// Fields
	private int m_IsOrthographic; // 0x0
	private Vector3 m_CameraPosition; // 0x4
	private float m_FieldOfView; // 0x10
	private float m_OrthoSize; // 0x14
	private int m_CameraPixelHeight; // 0x18

	// Methods

	// RVA: 0x374290 Offset: 0x374391 VA: 0x374290 Slot: 4
	public bool Equals(LODParameters other) { }

	// RVA: 0x374330 Offset: 0x374431 VA: 0x374330 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x374340 Offset: 0x374441 VA: 0x374340 Slot: 2
	public override int GetHashCode() { }
}

