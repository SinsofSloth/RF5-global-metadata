[UsedByNativeCodeAttribute] // RVA: 0xC5860 Offset: 0xC5961 VA: 0xC5860
[Serializable]
public struct BoneWeight1 : IEquatable<BoneWeight1> // TypeDefIndex: 2940
{
	// Fields
	[SerializeField] // RVA: 0xC9F90 Offset: 0xCA091 VA: 0xC9F90
	private float m_Weight; // 0x0
	[SerializeField] // RVA: 0xC9FA0 Offset: 0xCA0A1 VA: 0xC9FA0
	private int m_BoneIndex; // 0x4

	// Properties
	public float weight { get; }
	public int boneIndex { get; }

	// Methods

	// RVA: 0x37B800 Offset: 0x37B901 VA: 0x37B800
	public float get_weight() { }

	// RVA: 0x37B810 Offset: 0x37B911 VA: 0x37B810
	public int get_boneIndex() { }

	// RVA: 0x37B820 Offset: 0x37B921 VA: 0x37B820 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x37B8E0 Offset: 0x37B9E1 VA: 0x37B8E0 Slot: 4
	public bool Equals(BoneWeight1 other) { }

	// RVA: 0x37B950 Offset: 0x37BA51 VA: 0x37B950 Slot: 2
	public override int GetHashCode() { }
}

