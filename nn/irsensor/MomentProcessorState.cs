public struct MomentProcessorState // TypeDefIndex: 11533
{
	// Fields
	public long samplingNumber; // 0x0
	public long deltaTimeNanoSeconds; // 0x8
	public IrCameraAmbientNoiseLevel ambientNoiseLevel; // 0x10
	private byte _reserved0; // 0x14
	private byte _reserved1; // 0x15
	private byte _reserved2; // 0x16
	private byte _reserved3; // 0x17
	public MomentProcessorState.MomentStatisticArray48 blocks; // 0x18
}

