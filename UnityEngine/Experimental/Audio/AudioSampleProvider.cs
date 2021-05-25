[NativeTypeAttribute] // RVA: 0xF14C0 Offset: 0xF15C1 VA: 0xF14C0
[StaticAccessorAttribute] // RVA: 0xF14C0 Offset: 0xF15C1 VA: 0xF14C0
public class AudioSampleProvider // TypeDefIndex: 3578
{
	// Fields
	[DebuggerBrowsableAttribute] // RVA: 0xF1630 Offset: 0xF1731 VA: 0xF1630
	[CompilerGeneratedAttribute] // RVA: 0xF1630 Offset: 0xF1731 VA: 0xF1630
	private AudioSampleProvider.SampleFramesHandler sampleFramesAvailable; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0xF1670 Offset: 0xF1771 VA: 0xF1670
	[DebuggerBrowsableAttribute] // RVA: 0xF1670 Offset: 0xF1771 VA: 0xF1670
	private AudioSampleProvider.SampleFramesHandler sampleFramesOverflow; // 0x18

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0xF1DB0 Offset: 0xF1EB1 VA: 0xF1DB0
	// RVA: 0x1BB6750 Offset: 0x1BB6851 VA: 0x1BB6750
	private void InvokeSampleFramesAvailable(int sampleFrameCount) { }

	[RequiredByNativeCodeAttribute] // RVA: 0xF1DC0 Offset: 0xF1EC1 VA: 0xF1DC0
	// RVA: 0x1BB6BE0 Offset: 0x1BB6CE1 VA: 0x1BB6BE0
	private void InvokeSampleFramesOverflow(int droppedSampleFrameCount) { }
}

