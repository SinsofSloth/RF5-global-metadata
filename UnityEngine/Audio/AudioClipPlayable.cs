[StaticAccessorAttribute] // RVA: 0xF10F0 Offset: 0xF11F1 VA: 0xF10F0
[NativeHeaderAttribute] // RVA: 0xF10F0 Offset: 0xF11F1 VA: 0xF10F0
[RequiredByNativeCodeAttribute] // RVA: 0xF10F0 Offset: 0xF11F1 VA: 0xF10F0
[NativeHeaderAttribute] // RVA: 0xF10F0 Offset: 0xF11F1 VA: 0xF10F0
[NativeHeaderAttribute] // RVA: 0xF10F0 Offset: 0xF11F1 VA: 0xF10F0
public struct AudioClipPlayable : IPlayable, IEquatable<AudioClipPlayable> // TypeDefIndex: 3569
{
	// Fields
	private PlayableHandle m_Handle; // 0x0

	// Methods

	// RVA: 0x1BB0810 Offset: 0x1BB0911 VA: 0x1BB0810
	public static AudioClipPlayable Create(PlayableGraph graph, AudioClip clip, bool looping) { }

	// RVA: 0x1BB0940 Offset: 0x1BB0A41 VA: 0x1BB0940
	private static PlayableHandle CreateHandle(PlayableGraph graph, AudioClip clip, bool looping) { }

	// RVA: 0x234A0 Offset: 0x235A1 VA: 0x234A0
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x234B0 Offset: 0x235B1 VA: 0x234B0 Slot: 4
	public PlayableHandle GetHandle() { }

	// RVA: 0x1BB0BC0 Offset: 0x1BB0CC1 VA: 0x1BB0BC0
	public static Playable op_Implicit(AudioClipPlayable playable) { }

	// RVA: 0x1BB0C00 Offset: 0x1BB0D01 VA: 0x1BB0C00
	public static AudioClipPlayable op_Explicit(Playable playable) { }

	// RVA: 0x234C0 Offset: 0x235C1 VA: 0x234C0 Slot: 5
	public bool Equals(AudioClipPlayable other) { }

	// RVA: 0x23550 Offset: 0x23651 VA: 0x23550
	internal void SetVolume(float value) { }

	// RVA: 0x23560 Offset: 0x23661 VA: 0x23560
	internal void SetStereoPan(float value) { }

	// RVA: 0x23570 Offset: 0x23671 VA: 0x23570
	internal void SetSpatialBlend(float value) { }

	// RVA: 0x23580 Offset: 0x23681 VA: 0x23580
	public void Seek(double startTime, double startDelay, double duration) { }

	[NativeThrowsAttribute] // RVA: 0xF1BC0 Offset: 0xF1CC1 VA: 0xF1BC0
	// RVA: 0x1BB0DD0 Offset: 0x1BB0ED1 VA: 0x1BB0DD0
	private static void SetVolumeInternal(ref PlayableHandle hdl, float volume) { }

	[NativeThrowsAttribute] // RVA: 0xF1BD0 Offset: 0xF1CD1 VA: 0xF1BD0
	// RVA: 0x1BB0F10 Offset: 0x1BB1011 VA: 0x1BB0F10
	private static void SetStereoPanInternal(ref PlayableHandle hdl, float stereoPan) { }

	[NativeThrowsAttribute] // RVA: 0xF1BE0 Offset: 0xF1CE1 VA: 0xF1BE0
	// RVA: 0x1BB1050 Offset: 0x1BB1151 VA: 0x1BB1050
	private static void SetSpatialBlendInternal(ref PlayableHandle hdl, float spatialBlend) { }

	[NativeThrowsAttribute] // RVA: 0xF1BF0 Offset: 0xF1CF1 VA: 0xF1BF0
	// RVA: 0x1BB11B0 Offset: 0x1BB12B1 VA: 0x1BB11B0
	private static void SetStartDelayInternal(ref PlayableHandle hdl, double delay) { }

	[NativeThrowsAttribute] // RVA: 0xF1C00 Offset: 0xF1D01 VA: 0xF1C00
	// RVA: 0x1BB1200 Offset: 0x1BB1301 VA: 0x1BB1200
	private static void SetPauseDelayInternal(ref PlayableHandle hdl, double delay) { }

	[NativeThrowsAttribute] // RVA: 0xF1C10 Offset: 0xF1D11 VA: 0xF1C10
	// RVA: 0x1BB0B40 Offset: 0x1BB0C41 VA: 0x1BB0B40
	private static bool InternalCreateAudioClipPlayable(ref PlayableGraph graph, AudioClip clip, bool looping, ref PlayableHandle handle) { }
}

