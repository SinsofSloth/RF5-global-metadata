[RequireComponent] // RVA: 0x125100 Offset: 0x125201 VA: 0x125100
[RequiredByNativeCodeAttribute] // RVA: 0x125100 Offset: 0x125201 VA: 0x125100
[NativeHeaderAttribute] // RVA: 0x125100 Offset: 0x125201 VA: 0x125100
public sealed class VideoPlayer : Behaviour // TypeDefIndex: 4280
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x1251A0 Offset: 0x1252A1 VA: 0x1251A0
	[DebuggerBrowsableAttribute] // RVA: 0x1251A0 Offset: 0x1252A1 VA: 0x1251A0
	private VideoPlayer.EventHandler prepareCompleted; // 0x18
	[DebuggerBrowsableAttribute] // RVA: 0x1251E0 Offset: 0x1252E1 VA: 0x1251E0
	[CompilerGeneratedAttribute] // RVA: 0x1251E0 Offset: 0x1252E1 VA: 0x1251E0
	private VideoPlayer.EventHandler loopPointReached; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x125220 Offset: 0x125321 VA: 0x125220
	[DebuggerBrowsableAttribute] // RVA: 0x125220 Offset: 0x125321 VA: 0x125220
	private VideoPlayer.EventHandler started; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x125260 Offset: 0x125361 VA: 0x125260
	[DebuggerBrowsableAttribute] // RVA: 0x125260 Offset: 0x125361 VA: 0x125260
	private VideoPlayer.EventHandler frameDropped; // 0x30
	[DebuggerBrowsableAttribute] // RVA: 0x1252A0 Offset: 0x1253A1 VA: 0x1252A0
	[CompilerGeneratedAttribute] // RVA: 0x1252A0 Offset: 0x1253A1 VA: 0x1252A0
	private VideoPlayer.ErrorEventHandler errorReceived; // 0x38
	[DebuggerBrowsableAttribute] // RVA: 0x1252E0 Offset: 0x1253E1 VA: 0x1252E0
	[CompilerGeneratedAttribute] // RVA: 0x1252E0 Offset: 0x1253E1 VA: 0x1252E0
	private VideoPlayer.EventHandler seekCompleted; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x125320 Offset: 0x125421 VA: 0x125320
	[DebuggerBrowsableAttribute] // RVA: 0x125320 Offset: 0x125421 VA: 0x125320
	private VideoPlayer.TimeEventHandler clockResyncOccurred; // 0x48
	[DebuggerBrowsableAttribute] // RVA: 0x125360 Offset: 0x125461 VA: 0x125360
	[CompilerGeneratedAttribute] // RVA: 0x125360 Offset: 0x125461 VA: 0x125360
	private VideoPlayer.FrameReadyEventHandler frameReady; // 0x50

	// Properties
	public VideoSource source { get; set; }
	[NativeNameAttribute] // RVA: 0x125860 Offset: 0x125961 VA: 0x125860
	public string url { get; set; }
	[NativeNameAttribute] // RVA: 0x1258A0 Offset: 0x1259A1 VA: 0x1258A0
	public VideoClip clip { get; set; }
	public VideoRenderMode renderMode { get; set; }
	[NativeHeaderAttribute] // RVA: 0x1258E0 Offset: 0x1259E1 VA: 0x1258E0
	public Camera targetCamera { get; set; }
	[NativeHeaderAttribute] // RVA: 0x125920 Offset: 0x125A21 VA: 0x125920
	public RenderTexture targetTexture { get; set; }
	[NativeHeaderAttribute] // RVA: 0x125960 Offset: 0x125A61 VA: 0x125960
	public Renderer targetMaterialRenderer { get; set; }
	public string targetMaterialProperty { get; set; }
	public VideoAspectRatio aspectRatio { get; set; }
	public float targetCameraAlpha { get; set; }
	public Video3DLayout targetCamera3DLayout { get; set; }
	[NativeHeaderAttribute] // RVA: 0x1259A0 Offset: 0x125AA1 VA: 0x1259A0
	public Texture texture { get; }
	public bool isPrepared { get; }
	public bool waitForFirstFrame { get; set; }
	public bool playOnAwake { get; set; }
	public bool isPlaying { get; }
	public bool isPaused { get; }
	public bool canSetTime { get; }
	[NativeNameAttribute] // RVA: 0x1259E0 Offset: 0x125AE1 VA: 0x1259E0
	public double time { get; set; }
	[NativeNameAttribute] // RVA: 0x125A20 Offset: 0x125B21 VA: 0x125A20
	public long frame { get; set; }
	public double clockTime { get; }
	public bool canStep { get; }
	public bool canSetPlaybackSpeed { get; }
	public float playbackSpeed { get; set; }
	[NativeNameAttribute] // RVA: 0x125A60 Offset: 0x125B61 VA: 0x125A60
	public bool isLooping { get; set; }
	public bool canSetTimeSource { get; }
	public VideoTimeSource timeSource { get; set; }
	public VideoTimeReference timeReference { get; set; }
	public double externalReferenceTime { get; set; }
	public bool canSetSkipOnDrop { get; }
	public bool skipOnDrop { get; set; }
	public ulong frameCount { get; }
	public float frameRate { get; }
	[NativeNameAttribute] // RVA: 0x125AA0 Offset: 0x125BA1 VA: 0x125AA0
	public double length { get; }
	public uint width { get; }
	public uint height { get; }
	public uint pixelAspectRatioNumerator { get; }
	public uint pixelAspectRatioDenominator { get; }
	public ushort audioTrackCount { get; }
	public static ushort controlledAudioTrackMaxCount { get; }
	public ushort controlledAudioTrackCount { get; set; }
	public VideoAudioOutputMode audioOutputMode { get; set; }
	public bool canSetDirectAudioVolume { get; }
	public bool sendFrameReadyEvents { get; set; }

	// Methods

	// RVA: 0x1BD4CB0 Offset: 0x1BD4DB1 VA: 0x1BD4CB0
	public VideoSource get_source() { }

	// RVA: 0x1BD4D00 Offset: 0x1BD4E01 VA: 0x1BD4D00
	public void set_source(VideoSource value) { }

	// RVA: 0x1BD4D50 Offset: 0x1BD4E51 VA: 0x1BD4D50
	public string get_url() { }

	// RVA: 0x1BD4DA0 Offset: 0x1BD4EA1 VA: 0x1BD4DA0
	public void set_url(string value) { }

	// RVA: 0x1BD4DF0 Offset: 0x1BD4EF1 VA: 0x1BD4DF0
	public VideoClip get_clip() { }

	// RVA: 0x1BD4E40 Offset: 0x1BD4F41 VA: 0x1BD4E40
	public void set_clip(VideoClip value) { }

	// RVA: 0x1BD4E90 Offset: 0x1BD4F91 VA: 0x1BD4E90
	public VideoRenderMode get_renderMode() { }

	// RVA: 0x1BD4EE0 Offset: 0x1BD4FE1 VA: 0x1BD4EE0
	public void set_renderMode(VideoRenderMode value) { }

	// RVA: 0x1BD4F30 Offset: 0x1BD5031 VA: 0x1BD4F30
	public Camera get_targetCamera() { }

	// RVA: 0x1BD4F80 Offset: 0x1BD5081 VA: 0x1BD4F80
	public void set_targetCamera(Camera value) { }

	// RVA: 0x1BD4FD0 Offset: 0x1BD50D1 VA: 0x1BD4FD0
	public RenderTexture get_targetTexture() { }

	// RVA: 0x1BD5020 Offset: 0x1BD5121 VA: 0x1BD5020
	public void set_targetTexture(RenderTexture value) { }

	// RVA: 0x1BD5070 Offset: 0x1BD5171 VA: 0x1BD5070
	public Renderer get_targetMaterialRenderer() { }

	// RVA: 0x1BD50C0 Offset: 0x1BD51C1 VA: 0x1BD50C0
	public void set_targetMaterialRenderer(Renderer value) { }

	// RVA: 0x1BD5110 Offset: 0x1BD5211 VA: 0x1BD5110
	public string get_targetMaterialProperty() { }

	// RVA: 0x1BD5160 Offset: 0x1BD5261 VA: 0x1BD5160
	public void set_targetMaterialProperty(string value) { }

	// RVA: 0x1BD51B0 Offset: 0x1BD52B1 VA: 0x1BD51B0
	public VideoAspectRatio get_aspectRatio() { }

	// RVA: 0x1BD5200 Offset: 0x1BD5301 VA: 0x1BD5200
	public void set_aspectRatio(VideoAspectRatio value) { }

	// RVA: 0x1BD5250 Offset: 0x1BD5351 VA: 0x1BD5250
	public float get_targetCameraAlpha() { }

	// RVA: 0x1BD52A0 Offset: 0x1BD53A1 VA: 0x1BD52A0
	public void set_targetCameraAlpha(float value) { }

	// RVA: 0x1BD52F0 Offset: 0x1BD53F1 VA: 0x1BD52F0
	public Video3DLayout get_targetCamera3DLayout() { }

	// RVA: 0x1BD5340 Offset: 0x1BD5441 VA: 0x1BD5340
	public void set_targetCamera3DLayout(Video3DLayout value) { }

	// RVA: 0x1BD5390 Offset: 0x1BD5491 VA: 0x1BD5390
	public Texture get_texture() { }

	// RVA: 0x1BD53E0 Offset: 0x1BD54E1 VA: 0x1BD53E0
	public void Prepare() { }

	[NativeNameAttribute] // RVA: 0x1253A0 Offset: 0x1254A1 VA: 0x1253A0
	// RVA: 0x1BD5430 Offset: 0x1BD5531 VA: 0x1BD5430
	public bool get_isPrepared() { }

	// RVA: 0x1BD5480 Offset: 0x1BD5581 VA: 0x1BD5480
	public bool get_waitForFirstFrame() { }

	// RVA: 0x1BD54D0 Offset: 0x1BD55D1 VA: 0x1BD54D0
	public void set_waitForFirstFrame(bool value) { }

	// RVA: 0x1BD5520 Offset: 0x1BD5621 VA: 0x1BD5520
	public bool get_playOnAwake() { }

	// RVA: 0x1BD5570 Offset: 0x1BD5671 VA: 0x1BD5570
	public void set_playOnAwake(bool value) { }

	// RVA: 0x1BD55C0 Offset: 0x1BD56C1 VA: 0x1BD55C0
	public void Play() { }

	// RVA: 0x1BD5610 Offset: 0x1BD5711 VA: 0x1BD5610
	public void Pause() { }

	// RVA: 0x1BD5660 Offset: 0x1BD5761 VA: 0x1BD5660
	public void Stop() { }

	[NativeNameAttribute] // RVA: 0x1253E0 Offset: 0x1254E1 VA: 0x1253E0
	// RVA: 0x1BD56B0 Offset: 0x1BD57B1 VA: 0x1BD56B0
	public bool get_isPlaying() { }

	[NativeNameAttribute] // RVA: 0x125420 Offset: 0x125521 VA: 0x125420
	// RVA: 0x1BD5700 Offset: 0x1BD5801 VA: 0x1BD5700
	public bool get_isPaused() { }

	[NativeNameAttribute] // RVA: 0x125460 Offset: 0x125561 VA: 0x125460
	// RVA: 0x1BD5750 Offset: 0x1BD5851 VA: 0x1BD5750
	public bool get_canSetTime() { }

	// RVA: 0x1BD57A0 Offset: 0x1BD58A1 VA: 0x1BD57A0
	public double get_time() { }

	// RVA: 0x1BD57F0 Offset: 0x1BD58F1 VA: 0x1BD57F0
	public void set_time(double value) { }

	// RVA: 0x1BD5840 Offset: 0x1BD5941 VA: 0x1BD5840
	public long get_frame() { }

	// RVA: 0x1BD5890 Offset: 0x1BD5991 VA: 0x1BD5890
	public void set_frame(long value) { }

	// RVA: 0x1BD58E0 Offset: 0x1BD59E1 VA: 0x1BD58E0
	public double get_clockTime() { }

	[NativeNameAttribute] // RVA: 0x1254A0 Offset: 0x1255A1 VA: 0x1254A0
	// RVA: 0x1BD5930 Offset: 0x1BD5A31 VA: 0x1BD5930
	public bool get_canStep() { }

	// RVA: 0x1BD5980 Offset: 0x1BD5A81 VA: 0x1BD5980
	public void StepForward() { }

	[NativeNameAttribute] // RVA: 0x1254E0 Offset: 0x1255E1 VA: 0x1254E0
	// RVA: 0x1BD59D0 Offset: 0x1BD5AD1 VA: 0x1BD59D0
	public bool get_canSetPlaybackSpeed() { }

	// RVA: 0x1BD5A20 Offset: 0x1BD5B21 VA: 0x1BD5A20
	public float get_playbackSpeed() { }

	// RVA: 0x1BD5A70 Offset: 0x1BD5B71 VA: 0x1BD5A70
	public void set_playbackSpeed(float value) { }

	// RVA: 0x1BD5AC0 Offset: 0x1BD5BC1 VA: 0x1BD5AC0
	public bool get_isLooping() { }

	// RVA: 0x1BD5B10 Offset: 0x1BD5C11 VA: 0x1BD5B10
	public void set_isLooping(bool value) { }

	[NativeNameAttribute] // RVA: 0x125520 Offset: 0x125621 VA: 0x125520
	// RVA: 0x1BD5B60 Offset: 0x1BD5C61 VA: 0x1BD5B60
	public bool get_canSetTimeSource() { }

	// RVA: 0x1BD5BB0 Offset: 0x1BD5CB1 VA: 0x1BD5BB0
	public VideoTimeSource get_timeSource() { }

	// RVA: 0x1BD5C00 Offset: 0x1BD5D01 VA: 0x1BD5C00
	public void set_timeSource(VideoTimeSource value) { }

	// RVA: 0x1BD5C50 Offset: 0x1BD5D51 VA: 0x1BD5C50
	public VideoTimeReference get_timeReference() { }

	// RVA: 0x1BD5CA0 Offset: 0x1BD5DA1 VA: 0x1BD5CA0
	public void set_timeReference(VideoTimeReference value) { }

	// RVA: 0x1BD5CF0 Offset: 0x1BD5DF1 VA: 0x1BD5CF0
	public double get_externalReferenceTime() { }

	// RVA: 0x1BD5D40 Offset: 0x1BD5E41 VA: 0x1BD5D40
	public void set_externalReferenceTime(double value) { }

	[NativeNameAttribute] // RVA: 0x125560 Offset: 0x125661 VA: 0x125560
	// RVA: 0x1BD5D90 Offset: 0x1BD5E91 VA: 0x1BD5D90
	public bool get_canSetSkipOnDrop() { }

	// RVA: 0x1BD5DE0 Offset: 0x1BD5EE1 VA: 0x1BD5DE0
	public bool get_skipOnDrop() { }

	// RVA: 0x1BD5E30 Offset: 0x1BD5F31 VA: 0x1BD5E30
	public void set_skipOnDrop(bool value) { }

	// RVA: 0x1BD5E80 Offset: 0x1BD5F81 VA: 0x1BD5E80
	public ulong get_frameCount() { }

	// RVA: 0x1BD5ED0 Offset: 0x1BD5FD1 VA: 0x1BD5ED0
	public float get_frameRate() { }

	// RVA: 0x1BD5F20 Offset: 0x1BD6021 VA: 0x1BD5F20
	public double get_length() { }

	// RVA: 0x1BD5F70 Offset: 0x1BD6071 VA: 0x1BD5F70
	public uint get_width() { }

	// RVA: 0x1BD5FC0 Offset: 0x1BD60C1 VA: 0x1BD5FC0
	public uint get_height() { }

	// RVA: 0x1BD6010 Offset: 0x1BD6111 VA: 0x1BD6010
	public uint get_pixelAspectRatioNumerator() { }

	// RVA: 0x1BD6060 Offset: 0x1BD6161 VA: 0x1BD6060
	public uint get_pixelAspectRatioDenominator() { }

	// RVA: 0x1BD60B0 Offset: 0x1BD61B1 VA: 0x1BD60B0
	public ushort get_audioTrackCount() { }

	// RVA: 0x1BD6100 Offset: 0x1BD6201 VA: 0x1BD6100
	public string GetAudioLanguageCode(ushort trackIndex) { }

	// RVA: 0x1BD6150 Offset: 0x1BD6251 VA: 0x1BD6150
	public ushort GetAudioChannelCount(ushort trackIndex) { }

	// RVA: 0x1BD61A0 Offset: 0x1BD62A1 VA: 0x1BD61A0
	public uint GetAudioSampleRate(ushort trackIndex) { }

	// RVA: 0x1BD61F0 Offset: 0x1BD62F1 VA: 0x1BD61F0
	public static ushort get_controlledAudioTrackMaxCount() { }

	// RVA: 0x1BD6230 Offset: 0x1BD6331 VA: 0x1BD6230
	public ushort get_controlledAudioTrackCount() { }

	// RVA: 0x1BD62D0 Offset: 0x1BD63D1 VA: 0x1BD62D0
	public void set_controlledAudioTrackCount(ushort value) { }

	// RVA: 0x1BD6280 Offset: 0x1BD6381 VA: 0x1BD6280
	private ushort GetControlledAudioTrackCount() { }

	// RVA: 0x1BD6410 Offset: 0x1BD6511 VA: 0x1BD6410
	private void SetControlledAudioTrackCount(ushort value) { }

	// RVA: 0x1BD6460 Offset: 0x1BD6561 VA: 0x1BD6460
	public void EnableAudioTrack(ushort trackIndex, bool enabled) { }

	// RVA: 0x1BD64C0 Offset: 0x1BD65C1 VA: 0x1BD64C0
	public bool IsAudioTrackEnabled(ushort trackIndex) { }

	// RVA: 0x1BD6510 Offset: 0x1BD6611 VA: 0x1BD6510
	public VideoAudioOutputMode get_audioOutputMode() { }

	// RVA: 0x1BD6560 Offset: 0x1BD6661 VA: 0x1BD6560
	public void set_audioOutputMode(VideoAudioOutputMode value) { }

	[NativeNameAttribute] // RVA: 0x1255A0 Offset: 0x1256A1 VA: 0x1255A0
	// RVA: 0x1BD65B0 Offset: 0x1BD66B1 VA: 0x1BD65B0
	public bool get_canSetDirectAudioVolume() { }

	// RVA: 0x1BD6600 Offset: 0x1BD6701 VA: 0x1BD6600
	public float GetDirectAudioVolume(ushort trackIndex) { }

	// RVA: 0x1BD6650 Offset: 0x1BD6751 VA: 0x1BD6650
	public void SetDirectAudioVolume(ushort trackIndex, float volume) { }

	// RVA: 0x1BD66B0 Offset: 0x1BD67B1 VA: 0x1BD66B0
	public bool GetDirectAudioMute(ushort trackIndex) { }

	// RVA: 0x1BD6700 Offset: 0x1BD6801 VA: 0x1BD6700
	public void SetDirectAudioMute(ushort trackIndex, bool mute) { }

	[NativeHeaderAttribute] // RVA: 0x1255E0 Offset: 0x1256E1 VA: 0x1255E0
	// RVA: 0x1BD6760 Offset: 0x1BD6861 VA: 0x1BD6760
	public AudioSource GetTargetAudioSource(ushort trackIndex) { }

	// RVA: 0x1BD67B0 Offset: 0x1BD68B1 VA: 0x1BD67B0
	public void SetTargetAudioSource(ushort trackIndex, AudioSource source) { }

	[CompilerGeneratedAttribute] // RVA: 0x125620 Offset: 0x125721 VA: 0x125620
	// RVA: 0x1BD6810 Offset: 0x1BD6911 VA: 0x1BD6810
	public void add_prepareCompleted(VideoPlayer.EventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x125630 Offset: 0x125731 VA: 0x125630
	// RVA: 0x1BD68C0 Offset: 0x1BD69C1 VA: 0x1BD68C0
	public void remove_prepareCompleted(VideoPlayer.EventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x125640 Offset: 0x125741 VA: 0x125640
	// RVA: 0x1BD6970 Offset: 0x1BD6A71 VA: 0x1BD6970
	public void add_loopPointReached(VideoPlayer.EventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x125650 Offset: 0x125751 VA: 0x125650
	// RVA: 0x1BD6A20 Offset: 0x1BD6B21 VA: 0x1BD6A20
	public void remove_loopPointReached(VideoPlayer.EventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x125660 Offset: 0x125761 VA: 0x125660
	// RVA: 0x1BD6AD0 Offset: 0x1BD6BD1 VA: 0x1BD6AD0
	public void add_started(VideoPlayer.EventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x125670 Offset: 0x125771 VA: 0x125670
	// RVA: 0x1BD6B80 Offset: 0x1BD6C81 VA: 0x1BD6B80
	public void remove_started(VideoPlayer.EventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x125680 Offset: 0x125781 VA: 0x125680
	// RVA: 0x1BD6C30 Offset: 0x1BD6D31 VA: 0x1BD6C30
	public void add_frameDropped(VideoPlayer.EventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x125690 Offset: 0x125791 VA: 0x125690
	// RVA: 0x1BD6CE0 Offset: 0x1BD6DE1 VA: 0x1BD6CE0
	public void remove_frameDropped(VideoPlayer.EventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1256A0 Offset: 0x1257A1 VA: 0x1256A0
	// RVA: 0x1BD6D90 Offset: 0x1BD6E91 VA: 0x1BD6D90
	public void add_errorReceived(VideoPlayer.ErrorEventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1256B0 Offset: 0x1257B1 VA: 0x1256B0
	// RVA: 0x1BD6E40 Offset: 0x1BD6F41 VA: 0x1BD6E40
	public void remove_errorReceived(VideoPlayer.ErrorEventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1256C0 Offset: 0x1257C1 VA: 0x1256C0
	// RVA: 0x1BD6EF0 Offset: 0x1BD6FF1 VA: 0x1BD6EF0
	public void add_seekCompleted(VideoPlayer.EventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1256D0 Offset: 0x1257D1 VA: 0x1256D0
	// RVA: 0x1BD6FA0 Offset: 0x1BD70A1 VA: 0x1BD6FA0
	public void remove_seekCompleted(VideoPlayer.EventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1256E0 Offset: 0x1257E1 VA: 0x1256E0
	// RVA: 0x1BD7050 Offset: 0x1BD7151 VA: 0x1BD7050
	public void add_clockResyncOccurred(VideoPlayer.TimeEventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1256F0 Offset: 0x1257F1 VA: 0x1256F0
	// RVA: 0x1BD7100 Offset: 0x1BD7201 VA: 0x1BD7100
	public void remove_clockResyncOccurred(VideoPlayer.TimeEventHandler value) { }

	[NativeNameAttribute] // RVA: 0x125700 Offset: 0x125801 VA: 0x125700
	// RVA: 0x1BD71B0 Offset: 0x1BD72B1 VA: 0x1BD71B0
	public bool get_sendFrameReadyEvents() { }

	[NativeNameAttribute] // RVA: 0x125740 Offset: 0x125841 VA: 0x125740
	// RVA: 0x1BD7200 Offset: 0x1BD7301 VA: 0x1BD7200
	public void set_sendFrameReadyEvents(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x125780 Offset: 0x125881 VA: 0x125780
	// RVA: 0x1BD7250 Offset: 0x1BD7351 VA: 0x1BD7250
	public void add_frameReady(VideoPlayer.FrameReadyEventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x125790 Offset: 0x125891 VA: 0x125790
	// RVA: 0x1BD7300 Offset: 0x1BD7401 VA: 0x1BD7300
	public void remove_frameReady(VideoPlayer.FrameReadyEventHandler value) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x1257A0 Offset: 0x1258A1 VA: 0x1257A0
	// RVA: 0x1BD73B0 Offset: 0x1BD74B1 VA: 0x1BD73B0
	private static void InvokePrepareCompletedCallback_Internal(VideoPlayer source) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x1257B0 Offset: 0x1258B1 VA: 0x1257B0
	// RVA: 0x1BD77B0 Offset: 0x1BD78B1 VA: 0x1BD77B0
	private static void InvokeFrameReadyCallback_Internal(VideoPlayer source, long frameIdx) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x1257C0 Offset: 0x1258C1 VA: 0x1257C0
	// RVA: 0x1BD7C40 Offset: 0x1BD7D41 VA: 0x1BD7C40
	private static void InvokeLoopPointReachedCallback_Internal(VideoPlayer source) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x1257D0 Offset: 0x1258D1 VA: 0x1257D0
	// RVA: 0x1BD7C70 Offset: 0x1BD7D71 VA: 0x1BD7C70
	private static void InvokeStartedCallback_Internal(VideoPlayer source) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x1257E0 Offset: 0x1258E1 VA: 0x1257E0
	// RVA: 0x1BD7CA0 Offset: 0x1BD7DA1 VA: 0x1BD7CA0
	private static void InvokeFrameDroppedCallback_Internal(VideoPlayer source) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x1257F0 Offset: 0x1258F1 VA: 0x1257F0
	// RVA: 0x1BD7CD0 Offset: 0x1BD7DD1 VA: 0x1BD7CD0
	private static void InvokeErrorReceivedCallback_Internal(VideoPlayer source, string errorStr) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x125800 Offset: 0x125901 VA: 0x125800
	// RVA: 0x1BD8120 Offset: 0x1BD8221 VA: 0x1BD8120
	private static void InvokeSeekCompletedCallback_Internal(VideoPlayer source) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x125810 Offset: 0x125911 VA: 0x125810
	// RVA: 0x1BD8150 Offset: 0x1BD8251 VA: 0x1BD8150
	private static void InvokeClockResyncOccurredCallback_Internal(VideoPlayer source, double seconds) { }

	// RVA: 0x1BD85C0 Offset: 0x1BD86C1 VA: 0x1BD85C0
	public void .ctor() { }
}

