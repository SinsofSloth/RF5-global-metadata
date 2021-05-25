[RequiredByNativeCodeAttribute] // RVA: 0xC3FF0 Offset: 0xC40F1 VA: 0xC3FF0
public struct Keyframe // TypeDefIndex: 2830
{
	// Fields
	private float m_Time; // 0x0
	private float m_Value; // 0x4
	private float m_InTangent; // 0x8
	private float m_OutTangent; // 0xC
	private int m_WeightedMode; // 0x10
	private float m_InWeight; // 0x14
	private float m_OutWeight; // 0x18

	// Properties
	public float time { get; set; }
	public float value { get; set; }
	public float inTangent { get; set; }
	public float outTangent { get; set; }

	// Methods

	// RVA: 0x18380 Offset: 0x18481 VA: 0x18380
	public void .ctor(float time, float value) { }

	// RVA: 0x183A0 Offset: 0x184A1 VA: 0x183A0
	public void .ctor(float time, float value, float inTangent, float outTangent) { }

	// RVA: 0x183C0 Offset: 0x184C1 VA: 0x183C0
	public float get_time() { }

	// RVA: 0x183D0 Offset: 0x184D1 VA: 0x183D0
	public void set_time(float value) { }

	// RVA: 0x183E0 Offset: 0x184E1 VA: 0x183E0
	public float get_value() { }

	// RVA: 0x183F0 Offset: 0x184F1 VA: 0x183F0
	public void set_value(float value) { }

	// RVA: 0x18400 Offset: 0x18501 VA: 0x18400
	public float get_inTangent() { }

	// RVA: 0x18410 Offset: 0x18511 VA: 0x18410
	public void set_inTangent(float value) { }

	// RVA: 0x18420 Offset: 0x18521 VA: 0x18420
	public float get_outTangent() { }

	// RVA: 0x18430 Offset: 0x18531 VA: 0x18430
	public void set_outTangent(float value) { }
}

