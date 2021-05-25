[NativeHeaderAttribute] // RVA: 0xF0EF0 Offset: 0xF0FF1 VA: 0xF0EF0
[StaticAccessorAttribute] // RVA: 0xF0EF0 Offset: 0xF0FF1 VA: 0xF0EF0
public sealed class AudioSettings // TypeDefIndex: 3561
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0xF1570 Offset: 0xF1671 VA: 0xF1570
	[DebuggerBrowsableAttribute] // RVA: 0xF1570 Offset: 0xF1671 VA: 0xF1570
	private static AudioSettings.AudioConfigurationChangeHandler OnAudioConfigurationChanged; // 0x0

	// Properties
	public static AudioSpeakerMode driverCapabilities { get; }
	public static AudioSpeakerMode speakerMode { get; }
	public static int outputSampleRate { get; }

	// Methods

	// RVA: 0x1BB3FE0 Offset: 0x1BB40E1 VA: 0x1BB3FE0
	private static AudioSpeakerMode GetSpeakerMode() { }

	[NativeMethodAttribute] // RVA: 0xF16B0 Offset: 0xF17B1 VA: 0xF16B0
	// RVA: 0x1BB4020 Offset: 0x1BB4121 VA: 0x1BB4020
	private static int GetSampleRate() { }

	[NativeNameAttribute] // RVA: 0xF1700 Offset: 0xF1801 VA: 0xF1700
	// RVA: 0x1BB4060 Offset: 0x1BB4161 VA: 0x1BB4060
	public static AudioSpeakerMode get_driverCapabilities() { }

	// RVA: 0x1BB40A0 Offset: 0x1BB41A1 VA: 0x1BB40A0
	public static AudioSpeakerMode get_speakerMode() { }

	// RVA: 0x1BB40E0 Offset: 0x1BB41E1 VA: 0x1BB40E0
	public static int get_outputSampleRate() { }

	[NativeMethodAttribute] // RVA: 0xF1740 Offset: 0xF1841 VA: 0xF1740
	// RVA: 0x1BB4120 Offset: 0x1BB4221 VA: 0x1BB4120
	public static void GetDSPBufferSize(out int bufferLength, out int numBuffers) { }

	[RequiredByNativeCodeAttribute] // RVA: 0xF1790 Offset: 0xF1891 VA: 0xF1790
	// RVA: 0x1BB4170 Offset: 0x1BB4271 VA: 0x1BB4170
	internal static void InvokeOnAudioConfigurationChanged(bool deviceWasChanged) { }
}

