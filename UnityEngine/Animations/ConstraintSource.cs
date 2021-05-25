[NativeTypeAttribute] // RVA: 0xEA0B0 Offset: 0xEA1B1 VA: 0xEA0B0
[NativeHeaderAttribute] // RVA: 0xEA0B0 Offset: 0xEA1B1 VA: 0xEA0B0
[UsedByNativeCodeAttribute] // RVA: 0xEA0B0 Offset: 0xEA1B1 VA: 0xEA0B0
[Serializable]
public struct ConstraintSource // TypeDefIndex: 3542
{
	// Fields
	[NativeNameAttribute] // RVA: 0xEA850 Offset: 0xEA951 VA: 0xEA850
	private Transform m_SourceTransform; // 0x0
	[NativeNameAttribute] // RVA: 0xEA890 Offset: 0xEA991 VA: 0xEA890
	private float m_Weight; // 0x8

	// Properties
	public Transform sourceTransform { set; }
	public float weight { set; }

	// Methods

	// RVA: 0x1CB00 Offset: 0x1CC01 VA: 0x1CB00
	public void set_sourceTransform(Transform value) { }

	// RVA: 0x1CB10 Offset: 0x1CC11 VA: 0x1CB10
	public void set_weight(float value) { }
}

