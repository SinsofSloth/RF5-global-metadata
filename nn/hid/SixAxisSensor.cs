public static class SixAxisSensor // TypeDefIndex: 11588
{
	// Fields
	public const int StateCountMax = 16;
	public const int HandleCountMax = 8;

	// Methods

	// RVA: 0x2C63BA0 Offset: 0x2C63CA1 VA: 0x2C63BA0
	public static extern int GetHandles(SixAxisSensorHandle[] pOutValues, int count, NpadId npadId, NpadStyle npadStyle) { }

	// RVA: 0x2C63BB0 Offset: 0x2C63CB1 VA: 0x2C63BB0
	public static extern void Start(SixAxisSensorHandle handle) { }

	// RVA: 0x2C63BC0 Offset: 0x2C63CC1 VA: 0x2C63BC0
	public static extern void Stop(SixAxisSensorHandle handle) { }

	// RVA: 0x2C63BD0 Offset: 0x2C63CD1 VA: 0x2C63BD0
	public static extern bool IsRest(SixAxisSensorHandle handle) { }

	// RVA: 0x2C63BF0 Offset: 0x2C63CF1 VA: 0x2C63BF0
	public static extern void GetState(ref SixAxisSensorState pOutValue, SixAxisSensorHandle handle) { }

	// RVA: 0x2C63C00 Offset: 0x2C63D01 VA: 0x2C63C00
	public static extern int GetStates([Out] SixAxisSensorState[] pOutValues, int count, SixAxisSensorHandle handle) { }

	// RVA: 0x2C63D30 Offset: 0x2C63E31 VA: 0x2C63D30
	public static extern bool IsFusionEnabled(SixAxisSensorHandle handle) { }

	// RVA: 0x2C63D50 Offset: 0x2C63E51 VA: 0x2C63D50
	public static extern void EnableFusion(SixAxisSensorHandle handle, bool enable) { }

	// RVA: 0x2C63D60 Offset: 0x2C63E61 VA: 0x2C63D60
	public static extern void SetFusionParameters(SixAxisSensorHandle handle, float revisePower, float reviseRange) { }

	// RVA: 0x2C63D70 Offset: 0x2C63E71 VA: 0x2C63D70
	public static extern void GetFusionParameters(ref float pOutRevisePower, ref float pOutReviseRange, SixAxisSensorHandle handle) { }

	// RVA: 0x2C63D80 Offset: 0x2C63E81 VA: 0x2C63D80
	public static extern void ResetFusionParameters(SixAxisSensorHandle handle) { }

	// RVA: 0x2C63D90 Offset: 0x2C63E91 VA: 0x2C63D90
	public static extern void SetGyroscopeZeroDriftMode(SixAxisSensorHandle handle, GyroscopeZeroDriftMode mode) { }

	// RVA: 0x2C63DA0 Offset: 0x2C63EA1 VA: 0x2C63DA0
	public static extern GyroscopeZeroDriftMode GetGyroscopeZeroDriftMode(SixAxisSensorHandle handle) { }

	// RVA: 0x2C63DB0 Offset: 0x2C63EB1 VA: 0x2C63DB0
	public static extern bool IsFirmwareUpdateAvailableForSixAxisSensor(SixAxisSensorHandle handle) { }
}

