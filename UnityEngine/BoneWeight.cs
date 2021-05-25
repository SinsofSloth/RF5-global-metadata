[UsedByNativeCodeAttribute] // RVA: 0xC5850 Offset: 0xC5951 VA: 0xC5850
[Serializable]
public struct BoneWeight : IEquatable<BoneWeight> // TypeDefIndex: 2939
{
	// Fields
	[SerializeField] // RVA: 0xC9F10 Offset: 0xCA011 VA: 0xC9F10
	private float m_Weight0; // 0x0
	[SerializeField] // RVA: 0xC9F20 Offset: 0xCA021 VA: 0xC9F20
	private float m_Weight1; // 0x4
	[SerializeField] // RVA: 0xC9F30 Offset: 0xCA031 VA: 0xC9F30
	private float m_Weight2; // 0x8
	[SerializeField] // RVA: 0xC9F40 Offset: 0xCA041 VA: 0xC9F40
	private float m_Weight3; // 0xC
	[SerializeField] // RVA: 0xC9F50 Offset: 0xCA051 VA: 0xC9F50
	private int m_BoneIndex0; // 0x10
	[SerializeField] // RVA: 0xC9F60 Offset: 0xCA061 VA: 0xC9F60
	private int m_BoneIndex1; // 0x14
	[SerializeField] // RVA: 0xC9F70 Offset: 0xCA071 VA: 0xC9F70
	private int m_BoneIndex2; // 0x18
	[SerializeField] // RVA: 0xC9F80 Offset: 0xCA081 VA: 0xC9F80
	private int m_BoneIndex3; // 0x1C

	// Properties
	public float weight0 { get; set; }
	public float weight1 { get; set; }
	public float weight2 { get; set; }
	public float weight3 { get; set; }
	public int boneIndex0 { get; set; }
	public int boneIndex1 { get; set; }
	public int boneIndex2 { get; set; }
	public int boneIndex3 { get; set; }

	// Methods

	// RVA: 0x37B600 Offset: 0x37B701 VA: 0x37B600
	public float get_weight0() { }

	// RVA: 0x37B610 Offset: 0x37B711 VA: 0x37B610
	public void set_weight0(float value) { }

	// RVA: 0x37B620 Offset: 0x37B721 VA: 0x37B620
	public float get_weight1() { }

	// RVA: 0x37B630 Offset: 0x37B731 VA: 0x37B630
	public void set_weight1(float value) { }

	// RVA: 0x37B640 Offset: 0x37B741 VA: 0x37B640
	public float get_weight2() { }

	// RVA: 0x37B650 Offset: 0x37B751 VA: 0x37B650
	public void set_weight2(float value) { }

	// RVA: 0x37B660 Offset: 0x37B761 VA: 0x37B660
	public float get_weight3() { }

	// RVA: 0x37B670 Offset: 0x37B771 VA: 0x37B670
	public void set_weight3(float value) { }

	// RVA: 0x37B680 Offset: 0x37B781 VA: 0x37B680
	public int get_boneIndex0() { }

	// RVA: 0x37B690 Offset: 0x37B791 VA: 0x37B690
	public void set_boneIndex0(int value) { }

	// RVA: 0x37B6A0 Offset: 0x37B7A1 VA: 0x37B6A0
	public int get_boneIndex1() { }

	// RVA: 0x37B6B0 Offset: 0x37B7B1 VA: 0x37B6B0
	public void set_boneIndex1(int value) { }

	// RVA: 0x37B6C0 Offset: 0x37B7C1 VA: 0x37B6C0
	public int get_boneIndex2() { }

	// RVA: 0x37B6D0 Offset: 0x37B7D1 VA: 0x37B6D0
	public void set_boneIndex2(int value) { }

	// RVA: 0x37B6E0 Offset: 0x37B7E1 VA: 0x37B6E0
	public int get_boneIndex3() { }

	// RVA: 0x37B6F0 Offset: 0x37B7F1 VA: 0x37B6F0
	public void set_boneIndex3(int value) { }

	// RVA: 0x37B700 Offset: 0x37B801 VA: 0x37B700 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x37B710 Offset: 0x37B811 VA: 0x37B710 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x37B7C0 Offset: 0x37B8C1 VA: 0x37B7C0 Slot: 4
	public bool Equals(BoneWeight other) { }
}

