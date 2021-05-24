[DocumentationSortingAttribute] // RVA: 0x12ED40 Offset: 0x12EE41 VA: 0x12ED40
[Serializable]
public struct AxisState // TypeDefIndex: 4808
{
	// Fields
	[NoSaveDuringPlayAttribute] // RVA: 0x134000 Offset: 0x134101 VA: 0x134000
	[TooltipAttribute] // RVA: 0x134000 Offset: 0x134101 VA: 0x134000
	public float Value; // 0x0
	[TooltipAttribute] // RVA: 0x134050 Offset: 0x134151 VA: 0x134050
	public AxisState.SpeedMode m_SpeedMode; // 0x4
	[TooltipAttribute] // RVA: 0x134090 Offset: 0x134191 VA: 0x134090
	public float m_MaxSpeed; // 0x8
	[TooltipAttribute] // RVA: 0x1340D0 Offset: 0x1341D1 VA: 0x1340D0
	public float m_AccelTime; // 0xC
	[TooltipAttribute] // RVA: 0x134110 Offset: 0x134211 VA: 0x134110
	public float m_DecelTime; // 0x10
	[FormerlySerializedAsAttribute] // RVA: 0x134150 Offset: 0x134251 VA: 0x134150
	[TooltipAttribute] // RVA: 0x134150 Offset: 0x134251 VA: 0x134150
	public string m_InputAxisName; // 0x18
	[NoSaveDuringPlayAttribute] // RVA: 0x1341B0 Offset: 0x1342B1 VA: 0x1341B0
	[TooltipAttribute] // RVA: 0x1341B0 Offset: 0x1342B1 VA: 0x1341B0
	public float m_InputAxisValue; // 0x20
	[FormerlySerializedAsAttribute] // RVA: 0x134200 Offset: 0x134301 VA: 0x134200
	[TooltipAttribute] // RVA: 0x134200 Offset: 0x134301 VA: 0x134200
	public bool m_InvertInput; // 0x24
	[TooltipAttribute] // RVA: 0x134260 Offset: 0x134361 VA: 0x134260
	public float m_MinValue; // 0x28
	[TooltipAttribute] // RVA: 0x1342A0 Offset: 0x1343A1 VA: 0x1342A0
	public float m_MaxValue; // 0x2C
	[TooltipAttribute] // RVA: 0x1342E0 Offset: 0x1343E1 VA: 0x1342E0
	public bool m_Wrap; // 0x30
	[TooltipAttribute] // RVA: 0x134320 Offset: 0x134421 VA: 0x134320
	public AxisState.Recentering m_Recentering; // 0x34
	private float mCurrentSpeed; // 0x50
	private const float Epsilon = 0.0001;
	private AxisState.IInputAxisProvider m_InputAxisProvider; // 0x58
	private int m_InputAxisIndex; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x134360 Offset: 0x134461 VA: 0x134360
	private bool <ValueRangeLocked>k__BackingField; // 0x64
	[CompilerGeneratedAttribute] // RVA: 0x134370 Offset: 0x134471 VA: 0x134370
	private bool <HasRecentering>k__BackingField; // 0x65

	// Properties
	public bool HasInputProvider { get; }
	public bool ValueRangeLocked { get; set; }
	public bool HasRecentering { get; set; }

	// Methods

	// RVA: 0xD7A0 Offset: 0xD8A1 VA: 0xD7A0
	public void .ctor(float minValue, float maxValue, bool wrap, bool rangeLocked, float maxSpeed, float accelTime, float decelTime, string name, bool invert) { }

	// RVA: 0xD850 Offset: 0xD951 VA: 0xD850
	public void Validate() { }

	// RVA: 0xD860 Offset: 0xD961 VA: 0xD860
	public void Reset() { }

	// RVA: 0xD870 Offset: 0xD971 VA: 0xD870
	public void SetInputAxisProvider(int axis, AxisState.IInputAxisProvider provider) { }

	// RVA: 0xD880 Offset: 0xD981 VA: 0xD880
	public bool get_HasInputProvider() { }

	// RVA: 0xD890 Offset: 0xD991 VA: 0xD890
	public bool Update(float deltaTime) { }

	// RVA: 0xD8A0 Offset: 0xD9A1 VA: 0xD8A0
	private float ClampValue(float v) { }

	// RVA: 0xD8B0 Offset: 0xD9B1 VA: 0xD8B0
	private bool MaxSpeedUpdate(float input, float deltaTime) { }

	// RVA: 0xD8C0 Offset: 0xD9C1 VA: 0xD8C0
	private float GetMaxSpeed() { }

	[CompilerGeneratedAttribute] // RVA: 0x136DC0 Offset: 0x136EC1 VA: 0x136DC0
	// RVA: 0xD8D0 Offset: 0xD9D1 VA: 0xD8D0
	public bool get_ValueRangeLocked() { }

	[CompilerGeneratedAttribute] // RVA: 0x136DD0 Offset: 0x136ED1 VA: 0x136DD0
	// RVA: 0xD8E0 Offset: 0xD9E1 VA: 0xD8E0
	public void set_ValueRangeLocked(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x136DE0 Offset: 0x136EE1 VA: 0x136DE0
	// RVA: 0xD8F0 Offset: 0xD9F1 VA: 0xD8F0
	public bool get_HasRecentering() { }

	[CompilerGeneratedAttribute] // RVA: 0x136DF0 Offset: 0x136EF1 VA: 0x136DF0
	// RVA: 0xD900 Offset: 0xDA01 VA: 0xD900
	public void set_HasRecentering(bool value) { }
}

