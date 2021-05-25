public struct ClusteringData : IEquatable<ClusteringData> // TypeDefIndex: 11488
{
	// Fields
	public float averageIntensity; // 0x0
	public Float2 centroid; // 0x4
	public int pixelCount; // 0xC
	public Rect bound; // 0x10

	// Methods

	// RVA: 0x38AC50 Offset: 0x38AD51 VA: 0x38AC50 Slot: 3
	public override string ToString() { }

	// RVA: 0x2C7BE30 Offset: 0x2C7BF31 VA: 0x2C7BE30
	public static bool op_Equality(ClusteringData lhs, ClusteringData rhs) { }

	// RVA: 0x2C7BEA0 Offset: 0x2C7BFA1 VA: 0x2C7BEA0
	public static bool op_Inequality(ClusteringData lhs, ClusteringData rhs) { }

	// RVA: 0x38AC60 Offset: 0x38AD61 VA: 0x38AC60 Slot: 0
	public override bool Equals(object right) { }

	// RVA: 0x38AC70 Offset: 0x38AD71 VA: 0x38AC70 Slot: 4
	public bool Equals(ClusteringData other) { }

	// RVA: 0x38ACF0 Offset: 0x38ADF1 VA: 0x38ACF0 Slot: 2
	public override int GetHashCode() { }
}

