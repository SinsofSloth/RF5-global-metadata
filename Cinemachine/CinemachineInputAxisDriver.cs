[Serializable]
public struct CinemachineInputAxisDriver // TypeDefIndex: 4832
{
	// Fields
	[TooltipAttribute] // RVA: 0x134710 Offset: 0x134811 VA: 0x134710
	public float multiplier; // 0x0
	[TooltipAttribute] // RVA: 0x134750 Offset: 0x134851 VA: 0x134750
	public float accelTime; // 0x4
	[TooltipAttribute] // RVA: 0x134790 Offset: 0x134891 VA: 0x134790
	public float decelTime; // 0x8
	[TooltipAttribute] // RVA: 0x1347D0 Offset: 0x1348D1 VA: 0x1347D0
	public string name; // 0x10
	[NoSaveDuringPlayAttribute] // RVA: 0x134810 Offset: 0x134911 VA: 0x134810
	[TooltipAttribute] // RVA: 0x134810 Offset: 0x134911 VA: 0x134810
	public float inputValue; // 0x18
	private float mCurrentSpeed; // 0x1C
	private const float Epsilon = 0.0001;

	// Methods

	// RVA: 0x8E00 Offset: 0x8F01 VA: 0x8E00
	public void Validate() { }

	// RVA: 0x8EA0 Offset: 0x8FA1 VA: 0x8EA0
	public bool Update(float deltaTime, ref AxisBase axis) { }

	// RVA: 0x8EB0 Offset: 0x8FB1 VA: 0x8EB0
	private float ClampValue(ref AxisBase axis, float v) { }

	// RVA: 0x8F80 Offset: 0x9081 VA: 0x8F80
	public bool Update(float deltaTime, ref AxisState axis) { }
}

