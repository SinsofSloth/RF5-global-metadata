[RequiredByNativeCodeAttribute] // RVA: 0xF1270 Offset: 0xF1371 VA: 0xF1270
[StaticAccessorAttribute] // RVA: 0xF1270 Offset: 0xF1371 VA: 0xF1270
[NativeHeaderAttribute] // RVA: 0xF1270 Offset: 0xF1371 VA: 0xF1270
[NativeHeaderAttribute] // RVA: 0xF1270 Offset: 0xF1371 VA: 0xF1270
[NativeHeaderAttribute] // RVA: 0xF1270 Offset: 0xF1371 VA: 0xF1270
public struct AudioMixerPlayable : IPlayable, IEquatable<AudioMixerPlayable> // TypeDefIndex: 3573
{
	// Fields
	private PlayableHandle m_Handle; // 0x0

	// Methods

	// RVA: 0x1BB1A30 Offset: 0x1BB1B31 VA: 0x1BB1A30
	public static AudioMixerPlayable Create(PlayableGraph graph, int inputCount = 0, bool normalizeInputVolumes = False) { }

	// RVA: 0x1BB1A70 Offset: 0x1BB1B71 VA: 0x1BB1A70
	private static PlayableHandle CreateHandle(PlayableGraph graph, int inputCount, bool normalizeInputVolumes) { }

	// RVA: 0x23590 Offset: 0x23691 VA: 0x23590
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x235A0 Offset: 0x236A1 VA: 0x235A0 Slot: 4
	public PlayableHandle GetHandle() { }

	// RVA: 0x1BB1CA0 Offset: 0x1BB1DA1 VA: 0x1BB1CA0
	public static Playable op_Implicit(AudioMixerPlayable playable) { }

	// RVA: 0x235B0 Offset: 0x236B1 VA: 0x235B0 Slot: 5
	public bool Equals(AudioMixerPlayable other) { }

	[NativeThrowsAttribute] // RVA: 0xF1D70 Offset: 0xF1E71 VA: 0xF1D70
	// RVA: 0x1BB1C30 Offset: 0x1BB1D31 VA: 0x1BB1C30
	private static bool CreateAudioMixerPlayableInternal(ref PlayableGraph graph, bool normalizeInputVolumes, ref PlayableHandle handle) { }
}

