public static class Vibration // TypeDefIndex: 11644
{
	// Methods

	// RVA: 0x2C79A90 Offset: 0x2C79B91 VA: 0x2C79A90
	public static extern int GetDeviceHandles(VibrationDeviceHandle[] pOutValues, int count, NpadId npadId, NpadStyle npadStyle) { }

	// RVA: 0x2C79AA0 Offset: 0x2C79BA1 VA: 0x2C79AA0
	public static extern void GetDeviceInfo(ref VibrationDeviceInfo pOutValue, VibrationDeviceHandle handle) { }

	// RVA: 0x2C79AB0 Offset: 0x2C79BB1 VA: 0x2C79AB0
	public static extern void InitializeDevice(VibrationDeviceHandle handle) { }

	// RVA: 0x2C79AC0 Offset: 0x2C79BC1 VA: 0x2C79AC0
	public static extern void SendValue(VibrationDeviceHandle handle, VibrationValue value) { }

	// RVA: 0x2C79AD0 Offset: 0x2C79BD1 VA: 0x2C79AD0
	public static extern void GetActualValue(ref VibrationValue pOutValue, VibrationDeviceHandle handle) { }

	// RVA: 0x2C79AE0 Offset: 0x2C79BE1 VA: 0x2C79AE0
	public static extern bool IsPermitted() { }
}

