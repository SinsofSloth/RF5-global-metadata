public static class ClusteringProcessor // TypeDefIndex: 11486
{
	// Fields
	public const int StateCountMax = 5;
	public const int ObjectCountMax = 16;
	public const int ObjectPixelCountMax = 76800;
	public const int OutObjectPixelCountMax = 65535;
	public const long ExposureTimeMinNanoSeconds = 7000;
	public const long ExposureTimeMaxNanoSeconds = 600000;

	// Methods

	// RVA: 0x2C7C100 Offset: 0x2C7C201 VA: 0x2C7C100
	public static extern void GetDefaultConfig(ref ClusteringProcessorConfig pOutValue) { }

	// RVA: 0x2C7C110 Offset: 0x2C7C211 VA: 0x2C7C110
	public static extern void Run(IrCameraHandle handle, ClusteringProcessorConfig config) { }

	// RVA: 0x2C7C150 Offset: 0x2C7C251 VA: 0x2C7C150
	public static extern Result GetState(ref ClusteringProcessorState pOutValue, IrCameraHandle handle) { }

	// RVA: 0x2C7C170 Offset: 0x2C7C271 VA: 0x2C7C170
	public static extern Result GetStates([Out] ClusteringProcessorState[] pOutStates, ref int pOutCount, int countMax, IrCameraHandle handle) { }
}

