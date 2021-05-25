[Serializable]
public class BaseKeyframe : IComparable, IBaseKeyframe // TypeDefIndex: 9645
{
	// Fields
	[SerializeField] // RVA: 0x17D7B0 Offset: 0x17D8B1 VA: 0x17D7B0
	public string m_Id; // 0x10
	[SerializeField] // RVA: 0x17D7C0 Offset: 0x17D8C1 VA: 0x17D7C0
	private float m_Time; // 0x18
	[SerializeField] // RVA: 0x17D7D0 Offset: 0x17D8D1 VA: 0x17D7D0
	private InterpolationCurve m_InterpolationCurve; // 0x1C
	[SerializeField] // RVA: 0x17D7E0 Offset: 0x17D8E1 VA: 0x17D7E0
	private InterpolationDirection m_InterpolationDirection; // 0x20

	// Properties
	public string id { get; set; }
	public float time { get; set; }
	public InterpolationCurve interpolationCurve { get; set; }
	public InterpolationDirection interpolationDirection { get; set; }

	// Methods

	// RVA: 0x22AEF00 Offset: 0x22AF001 VA: 0x22AEF00 Slot: 5
	public string get_id() { }

	// RVA: 0x22AEF10 Offset: 0x22AF011 VA: 0x22AEF10
	public void set_id(string value) { }

	// RVA: 0x22AEF20 Offset: 0x22AF021 VA: 0x22AEF20 Slot: 6
	public float get_time() { }

	// RVA: 0x22AEF30 Offset: 0x22AF031 VA: 0x22AEF30 Slot: 7
	public void set_time(float value) { }

	// RVA: 0x22AEF40 Offset: 0x22AF041 VA: 0x22AEF40 Slot: 8
	public InterpolationCurve get_interpolationCurve() { }

	// RVA: 0x22AEF50 Offset: 0x22AF051 VA: 0x22AEF50 Slot: 9
	public void set_interpolationCurve(InterpolationCurve value) { }

	// RVA: 0x22AEF60 Offset: 0x22AF061 VA: 0x22AEF60 Slot: 10
	public InterpolationDirection get_interpolationDirection() { }

	// RVA: 0x22AEF70 Offset: 0x22AF071 VA: 0x22AEF70 Slot: 11
	public void set_interpolationDirection(InterpolationDirection value) { }

	// RVA: 0x22AEF80 Offset: 0x22AF081 VA: 0x22AEF80
	public void .ctor(float time) { }

	// RVA: 0x22AF030 Offset: 0x22AF131 VA: 0x22AF030 Slot: 4
	public int CompareTo(object other) { }
}

