public static class ImageTransferProcessor // TypeDefIndex: 11518
{
	// Fields
	public const int QvgaImageSize = 76800;
	public const int QqvgaImageSize = 19200;
	public const int QqqvgaImageSize = 4800;
	public const int ImageSize320x240 = 76800;
	public const int ImageSize160x120 = 19200;
	public const int ImageSize80x60 = 4800;
	public const int ImageSize40x30 = 1200;
	public const int ImageSize20x15 = 300;
	public const int QvgaWorkBufferSize = 155648;
	public const int QqvgaWorkBufferSize = 40960;
	public const int QqqvgaWorkBufferSize = 12288;
	public const int WorkBufferSize320x240 = 155648;
	public const int WorkBufferSize160x120 = 40960;
	public const int WorkBufferSize80x60 = 12288;
	public const int WorkBufferSize40x30 = 4096;
	public const int WorkBufferSize20x15 = 4096;
	public const long ExposureTimeMinNanoSeconds = 7000;
	public const long ExposureTimeMaxNanoSeconds = 600000;

	// Methods

	// RVA: 0x34EC280 Offset: 0x34EC381 VA: 0x34EC280
	public static extern void GetDefaultConfig(ref ImageTransferProcessorConfig pOutValue) { }

	// RVA: 0x34EC290 Offset: 0x34EC391 VA: 0x34EC290
	public static extern void GetDefaultConfig(ref ImageTransferProcessorExConfig pOutValue) { }

	// RVA: 0x34EC2A0 Offset: 0x34EC3A1 VA: 0x34EC2A0
	public static extern void Run(IrCameraHandle handle, ImageTransferProcessorConfig config, IntPtr workBuffer, long workBufferSize) { }

	// RVA: 0x34EC2E0 Offset: 0x34EC3E1 VA: 0x34EC2E0
	public static extern void Run(IrCameraHandle handle, ImageTransferProcessorExConfig config, IntPtr workBuffer, long workBufferSize) { }

	// RVA: 0x34EC320 Offset: 0x34EC421 VA: 0x34EC320
	public static extern Result GetState(ref ImageTransferProcessorState pOutState, IntPtr pOutImage, long size, IrCameraHandle handle) { }

	// RVA: 0x34EC340 Offset: 0x34EC441 VA: 0x34EC340
	public static extern void InitializeWorkBuffer(ref IntPtr pOutWorkBuffer, ref long pOutWorkBufferSize, ImageTransferProcessorConfig config) { }

	// RVA: 0x34EC370 Offset: 0x34EC471 VA: 0x34EC370
	public static extern void InitializeWorkBuffer(ref IntPtr pOutWorkBuffer, ref long pOutWorkBufferSize, ImageTransferProcessorExConfig config) { }

	// RVA: 0x34EC3B0 Offset: 0x34EC4B1 VA: 0x34EC3B0
	public static extern void DestroyWorkBuffer(IntPtr workBuffer) { }

	// RVA: 0x34EC3C0 Offset: 0x34EC4C1 VA: 0x34EC3C0
	public static int GetWorkBufferSize(ImageTransferProcessorFormat format) { }

	// RVA: 0x34EC3F0 Offset: 0x34EC4F1 VA: 0x34EC3F0
	public static int GetImageSize(ImageTransferProcessorFormat format) { }

	// RVA: 0x34EC420 Offset: 0x34EC521 VA: 0x34EC420
	public static int GetImageWidth(ImageTransferProcessorFormat format) { }

	// RVA: 0x34EC450 Offset: 0x34EC551 VA: 0x34EC450
	public static int GetImageHeight(ImageTransferProcessorFormat format) { }
}

