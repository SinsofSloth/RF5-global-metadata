public static class IrCamera // TypeDefIndex: 11515
{
	// Fields
	public const int IntensityMax = 255;
	public const int ImageWidth = 320;
	public const int ImageHeight = 240;
	public const int GainMin = 1;
	public const int GainMax = 16;

	// Methods

	// RVA: 0x34ECA30 Offset: 0x34ECB31 VA: 0x34ECA30
	public static extern IrCameraHandle GetHandle(NpadId npadId) { }

	// RVA: 0x34ECA50 Offset: 0x34ECB51 VA: 0x34ECA50
	public static extern void Initialize(IrCameraHandle handle) { }

	// RVA: 0x34ECA60 Offset: 0x34ECB61 VA: 0x34ECA60
	public static extern void Finalize(IrCameraHandle handle) { }

	// RVA: 0x34ECA70 Offset: 0x34ECB71 VA: 0x34ECA70
	public static extern IrCameraStatus GetStatus(IrCameraHandle handle) { }

	// RVA: 0x34ECA80 Offset: 0x34ECB81 VA: 0x34ECA80
	public static extern Result CheckFirmwareUpdateNecessity(ref bool pOutIsUpdateNeeded, IrCameraHandle handle) { }
}

