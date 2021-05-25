[NativeHeaderAttribute] // RVA: 0xF0F60 Offset: 0xF1061 VA: 0xF0F60
[StaticAccessorAttribute] // RVA: 0xF0F60 Offset: 0xF1061 VA: 0xF0F60
public sealed class AudioClip : Object // TypeDefIndex: 3563
{
	// Fields
	[DebuggerBrowsableAttribute] // RVA: 0xF15B0 Offset: 0xF16B1 VA: 0xF15B0
	[CompilerGeneratedAttribute] // RVA: 0xF15B0 Offset: 0xF16B1 VA: 0xF15B0
	private AudioClip.PCMReaderCallback m_PCMReaderCallback; // 0x18
	[DebuggerBrowsableAttribute] // RVA: 0xF15F0 Offset: 0xF16F1 VA: 0xF15F0
	[CompilerGeneratedAttribute] // RVA: 0xF15F0 Offset: 0xF16F1 VA: 0xF15F0
	private AudioClip.PCMSetPositionCallback m_PCMSetPositionCallback; // 0x20

	// Properties
	[NativePropertyAttribute] // RVA: 0xF1F50 Offset: 0xF2051 VA: 0xF1F50
	public float length { get; }
	[NativePropertyAttribute] // RVA: 0xF1F90 Offset: 0xF2091 VA: 0xF1F90
	public int samples { get; }
	[NativePropertyAttribute] // RVA: 0xF1FD0 Offset: 0xF20D1 VA: 0xF1FD0
	public int channels { get; }
	public int frequency { get; }
	[ObsoleteAttribute] // RVA: 0xF2010 Offset: 0xF2111 VA: 0xF2010
	public bool isReadyToPlay { get; }
	public AudioClipLoadType loadType { get; }
	public bool preloadAudioData { get; }
	public bool ambisonic { get; }
	public bool loadInBackground { get; }
	public AudioDataLoadState loadState { get; }

	// Methods

	// RVA: 0x1BB2420 Offset: 0x1BB2521 VA: 0x1BB2420
	private void .ctor() { }

	// RVA: 0x1BB24B0 Offset: 0x1BB25B1 VA: 0x1BB24B0
	private static bool GetData(AudioClip clip, [Out] float[] data, int numSamples, int samplesOffset) { }

	// RVA: 0x1BB2520 Offset: 0x1BB2621 VA: 0x1BB2520
	private static bool SetData(AudioClip clip, float[] data, int numsamples, int samplesOffset) { }

	// RVA: 0x1BB2590 Offset: 0x1BB2691 VA: 0x1BB2590
	private static AudioClip Construct_Internal() { }

	// RVA: 0x1BB25D0 Offset: 0x1BB26D1 VA: 0x1BB25D0
	private string GetName() { }

	// RVA: 0x1BB2620 Offset: 0x1BB2721 VA: 0x1BB2620
	private void CreateUserSound(string name, int lengthSamples, int channels, int frequency, bool stream) { }

	// RVA: 0x1BB0AF0 Offset: 0x1BB0BF1 VA: 0x1BB0AF0
	public float get_length() { }

	// RVA: 0x1BB26A0 Offset: 0x1BB27A1 VA: 0x1BB26A0
	public int get_samples() { }

	// RVA: 0x1BB26F0 Offset: 0x1BB27F1 VA: 0x1BB26F0
	public int get_channels() { }

	// RVA: 0x1BB2740 Offset: 0x1BB2841 VA: 0x1BB2740
	public int get_frequency() { }

	[NativeNameAttribute] // RVA: 0xF17A0 Offset: 0xF18A1 VA: 0xF17A0
	// RVA: 0x1BB2790 Offset: 0x1BB2891 VA: 0x1BB2790
	public bool get_isReadyToPlay() { }

	// RVA: 0x1BB27E0 Offset: 0x1BB28E1 VA: 0x1BB27E0
	public AudioClipLoadType get_loadType() { }

	// RVA: 0x1BB2830 Offset: 0x1BB2931 VA: 0x1BB2830
	public bool LoadAudioData() { }

	// RVA: 0x1BB2880 Offset: 0x1BB2981 VA: 0x1BB2880
	public bool UnloadAudioData() { }

	// RVA: 0x1BB28D0 Offset: 0x1BB29D1 VA: 0x1BB28D0
	public bool get_preloadAudioData() { }

	// RVA: 0x1BB2920 Offset: 0x1BB2A21 VA: 0x1BB2920
	public bool get_ambisonic() { }

	// RVA: 0x1BB2970 Offset: 0x1BB2A71 VA: 0x1BB2970
	public bool get_loadInBackground() { }

	[NativeMethodAttribute] // RVA: 0xF17E0 Offset: 0xF18E1 VA: 0xF17E0
	// RVA: 0x1BB29C0 Offset: 0x1BB2AC1 VA: 0x1BB29C0
	public AudioDataLoadState get_loadState() { }

	// RVA: 0x1BB2A10 Offset: 0x1BB2B11 VA: 0x1BB2A10
	public bool GetData(float[] data, int offsetSamples) { }

	// RVA: 0x1BB2BC0 Offset: 0x1BB2CC1 VA: 0x1BB2BC0
	public bool SetData(float[] data, int offsetSamples) { }

	[ObsoleteAttribute] // RVA: 0xF1830 Offset: 0xF1931 VA: 0xF1830
	// RVA: 0x1BB2DF0 Offset: 0x1BB2EF1 VA: 0x1BB2DF0
	public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool _3D, bool stream) { }

	[ObsoleteAttribute] // RVA: 0xF1870 Offset: 0xF1971 VA: 0xF1870
	// RVA: 0x1BB2E10 Offset: 0x1BB2F11 VA: 0x1BB2E10
	public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool _3D, bool stream, AudioClip.PCMReaderCallback pcmreadercallback) { }

	[ObsoleteAttribute] // RVA: 0xF18B0 Offset: 0xF19B1 VA: 0xF18B0
	// RVA: 0x1BB30E0 Offset: 0x1BB31E1 VA: 0x1BB30E0
	public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool _3D, bool stream, AudioClip.PCMReaderCallback pcmreadercallback, AudioClip.PCMSetPositionCallback pcmsetpositioncallback) { }

	// RVA: 0x1BB2E00 Offset: 0x1BB2F01 VA: 0x1BB2E00
	public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool stream) { }

	// RVA: 0x1BB30F0 Offset: 0x1BB31F1 VA: 0x1BB30F0
	public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool stream, AudioClip.PCMReaderCallback pcmreadercallback) { }

	// RVA: 0x1BB2E20 Offset: 0x1BB2F21 VA: 0x1BB2E20
	public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool stream, AudioClip.PCMReaderCallback pcmreadercallback, AudioClip.PCMSetPositionCallback pcmsetpositioncallback) { }

	[CompilerGeneratedAttribute] // RVA: 0xF18F0 Offset: 0xF19F1 VA: 0xF18F0
	// RVA: 0x1BB3100 Offset: 0x1BB3201 VA: 0x1BB3100
	private void add_m_PCMReaderCallback(AudioClip.PCMReaderCallback value) { }

	[CompilerGeneratedAttribute] // RVA: 0xF1900 Offset: 0xF1A01 VA: 0xF1900
	// RVA: 0x1BB3260 Offset: 0x1BB3361 VA: 0x1BB3260
	private void remove_m_PCMReaderCallback(AudioClip.PCMReaderCallback value) { }

	[CompilerGeneratedAttribute] // RVA: 0xF1910 Offset: 0xF1A11 VA: 0xF1910
	// RVA: 0x1BB31B0 Offset: 0x1BB32B1 VA: 0x1BB31B0
	private void add_m_PCMSetPositionCallback(AudioClip.PCMSetPositionCallback value) { }

	[CompilerGeneratedAttribute] // RVA: 0xF1920 Offset: 0xF1A21 VA: 0xF1920
	// RVA: 0x1BB3310 Offset: 0x1BB3411 VA: 0x1BB3310
	private void remove_m_PCMSetPositionCallback(AudioClip.PCMSetPositionCallback value) { }

	[RequiredByNativeCodeAttribute] // RVA: 0xF1930 Offset: 0xF1A31 VA: 0xF1930
	// RVA: 0x1BB33C0 Offset: 0x1BB34C1 VA: 0x1BB33C0
	private void InvokePCMReaderCallback_Internal(float[] data) { }

	[RequiredByNativeCodeAttribute] // RVA: 0xF1940 Offset: 0xF1A41 VA: 0xF1940
	// RVA: 0x1BB37A0 Offset: 0x1BB38A1 VA: 0x1BB37A0
	private void InvokePCMSetPositionCallback_Internal(int position) { }
}

