public class CaptureBase : MonoBehaviour // TypeDefIndex: 9603
{
	// Fields
	[SerializeField] // RVA: 0x17D3B0 Offset: 0x17D4B1 VA: 0x17D3B0
	private CaptureBase.PostCaptureSettings _postCaptureSettings; // 0x18
	public KeyCode _captureKey; // 0x20
	public bool _captureOnStart; // 0x24
	public bool _startPaused; // 0x25
	public bool _listVideoCodecsOnStart; // 0x26
	public bool _isRealTime; // 0x27
	[SerializeField] // RVA: 0x17D3C0 Offset: 0x17D4C1 VA: 0x17D3C0
	private bool _persistAcrossSceneLoads; // 0x28
	public StopMode _stopMode; // 0x2C
	public int _stopFrames; // 0x30
	public float _stopSeconds; // 0x34
	public bool _useMediaFoundationH264; // 0x38
	[SerializeField] // RVA: 0x17D3D0 Offset: 0x17D4D1 VA: 0x17D3D0
	private string[] _videoCodecPriority; // 0x40
	public CaptureBase.FrameRate _frameRate; // 0x48
	[SerializeField] // RVA: 0x17D3E0 Offset: 0x17D4E1 VA: 0x17D3E0
	[TooltipAttribute] // RVA: 0x17D3E0 Offset: 0x17D4E1 VA: 0x17D3E0
	private int _timelapseScale; // 0x4C
	public CaptureBase.DownScale _downScale; // 0x50
	public Vector2 _maxVideoSize; // 0x54
	public int _forceVideoCodecIndex; // 0x5C
	public bool _flipVertically; // 0x60
	public bool _supportAlpha; // 0x61
	[TooltipAttribute] // RVA: 0x17D430 Offset: 0x17D531 VA: 0x17D430
	[SerializeField] // RVA: 0x17D430 Offset: 0x17D531 VA: 0x17D430
	private bool _forceGpuFlush; // 0x62
	[TooltipAttribute] // RVA: 0x17D480 Offset: 0x17D581 VA: 0x17D480
	[SerializeField] // RVA: 0x17D480 Offset: 0x17D581 VA: 0x17D480
	protected bool _useWaitForEndOfFrame; // 0x63
	public bool _noAudio; // 0x64
	public string[] _audioCodecPriority; // 0x68
	public int _forceAudioCodecIndex; // 0x70
	public int _forceAudioDeviceIndex; // 0x74
	public UnityAudioCapture _audioCapture; // 0x78
	public bool _autoGenerateFilename; // 0x80
	public CaptureBase.OutputPath _outputFolderType; // 0x84
	public string _outputFolderPath; // 0x88
	public string _autoFilenamePrefix; // 0x90
	public string _autoFilenameExtension; // 0x98
	public string _forceFilename; // 0xA0
	public int _imageSequenceStartFrame; // 0xA8
	[RangeAttribute] // RVA: 0x17D4D0 Offset: 0x17D5D1 VA: 0x17D4D0
	public int _imageSequenceZeroDigits; // 0xAC
	public CaptureBase.OutputType _outputType; // 0xB0
	public ImageSequenceFormat _imageSequenceFormat; // 0xB4
	public CaptureBase.Resolution _renderResolution; // 0xB8
	public Vector2 _renderSize; // 0xBC
	public int _renderAntiAliasing; // 0xC4
	public bool _useMotionBlur; // 0xC8
	[RangeAttribute] // RVA: 0x17D4F0 Offset: 0x17D5F1 VA: 0x17D4F0
	public int _motionBlurSamples; // 0xCC
	public Camera[] _motionBlurCameras; // 0xD0
	protected MotionBlur _motionBlur; // 0xD8
	public bool _allowVSyncDisable; // 0xE0
	[SerializeField] // RVA: 0x17D510 Offset: 0x17D611 VA: 0x17D510
	protected bool _supportTextureRecreate; // 0xE1
	public bool _captureMouseCursor; // 0xE2
	public MouseCursor _mouseCursor; // 0xE8
	public string _codecName; // 0xF0
	public int _codecIndex; // 0xF8
	public string _audioCodecName; // 0x100
	public int _audioCodecIndex; // 0x108
	public string _audioDeviceName; // 0x110
	public int _audioDeviceIndex; // 0x118
	public int _unityAudioSampleRate; // 0x11C
	public int _unityAudioChannelCount; // 0x120
	protected Texture2D _texture; // 0x128
	protected int _handle; // 0x130
	protected int _targetWidth; // 0x134
	protected int _targetHeight; // 0x138
	protected bool _capturing; // 0x13C
	protected bool _paused; // 0x13D
	protected string _filePath; // 0x140
	protected FileInfo _fileInfo; // 0x148
	protected NativePlugin.PixelFormat _pixelFormat; // 0x150
	private int _oldVSyncCount; // 0x154
	private float _oldFixedDeltaTime; // 0x158
	protected bool _isTopDown; // 0x15C
	protected bool _isDirectX11; // 0x15D
	private bool _queuedStartCapture; // 0x15E
	private bool _queuedStopCapture; // 0x15F
	private float _captureStartTime; // 0x160
	private float _timeSinceLastFrame; // 0x164
	protected YieldInstruction _waitForEndOfFrame; // 0x168
	public int _minimumDiskSpaceMB; // 0x170
	private long _freeDiskSpaceMB; // 0x178
	private uint _numDroppedFrames; // 0x180
	private uint _numDroppedEncoderFrames; // 0x184
	private uint _numEncodedFrames; // 0x188
	private uint _totalEncodedSeconds; // 0x18C
	private static bool _isInitialised; // 0x0
	protected IntPtr _renderEventFunction; // 0x190
	protected IntPtr _freeEventFunction; // 0x198
	private float _fps; // 0x1A0
	private int _frameTotal; // 0x1A4
	private int _frameCount; // 0x1A8
	private float _startFrameTime; // 0x1AC

	// Properties
	public string LastFilePath { get; }
	public uint NumDroppedFrames { get; }
	public uint NumDroppedEncoderFrames { get; }
	public uint NumEncodedFrames { get; }
	public uint TotalEncodedSeconds { get; }
	public string[] VideoCodecPriority { get; set; }
	public int TimelapseScale { get; set; }
	public bool UseWaitForEndOfFrame { get; set; }
	public CaptureBase.PostCaptureSettings PostCapture { get; }
	public static string LastFileSaved { get; set; }
	public float FPS { get; }
	public float FramesTotal { get; }

	// Methods

	// RVA: 0x1DB0E10 Offset: 0x1DB0F11 VA: 0x1DB0E10
	public string get_LastFilePath() { }

	// RVA: 0x1DB0E20 Offset: 0x1DB0F21 VA: 0x1DB0E20
	public uint get_NumDroppedFrames() { }

	// RVA: 0x1DB0E30 Offset: 0x1DB0F31 VA: 0x1DB0E30
	public uint get_NumDroppedEncoderFrames() { }

	// RVA: 0x1DB0E40 Offset: 0x1DB0F41 VA: 0x1DB0E40
	public uint get_NumEncodedFrames() { }

	// RVA: 0x1DB0E50 Offset: 0x1DB0F51 VA: 0x1DB0E50
	public uint get_TotalEncodedSeconds() { }

	// RVA: 0x1DB0E60 Offset: 0x1DB0F61 VA: 0x1DB0E60
	public string[] get_VideoCodecPriority() { }

	// RVA: 0x1DB0E70 Offset: 0x1DB0F71 VA: 0x1DB0E70
	public void set_VideoCodecPriority(string[] value) { }

	// RVA: 0x1DB12B0 Offset: 0x1DB13B1 VA: 0x1DB12B0
	public int get_TimelapseScale() { }

	// RVA: 0x1DB12C0 Offset: 0x1DB13C1 VA: 0x1DB12C0
	public void set_TimelapseScale(int value) { }

	// RVA: 0x1DB12D0 Offset: 0x1DB13D1 VA: 0x1DB12D0
	public bool get_UseWaitForEndOfFrame() { }

	// RVA: 0x1DB12E0 Offset: 0x1DB13E1 VA: 0x1DB12E0
	public void set_UseWaitForEndOfFrame(bool value) { }

	// RVA: 0x1DB12F0 Offset: 0x1DB13F1 VA: 0x1DB12F0
	public CaptureBase.PostCaptureSettings get_PostCapture() { }

	// RVA: 0x1DB1300 Offset: 0x1DB1401 VA: 0x1DB1300 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0x1DB1C30 Offset: 0x1DB1D31 VA: 0x1DB1C30
	protected void SetupRenderFunctions() { }

	// RVA: 0x1DB2310 Offset: 0x1DB2411 VA: 0x1DB2310 Slot: 5
	public virtual void Start() { }

	// RVA: 0x1DB0EA0 Offset: 0x1DB0FA1 VA: 0x1DB0EA0
	public void SelectCodec(bool listCodecs) { }

	// RVA: 0x1DB1C70 Offset: 0x1DB1D71 VA: 0x1DB1C70
	public void SelectAudioCodec(bool listCodecs) { }

	// RVA: 0x1DB2080 Offset: 0x1DB2181 VA: 0x1DB2080
	public void SelectAudioDevice(bool display) { }

	// RVA: 0x1DB2580 Offset: 0x1DB2681 VA: 0x1DB2580
	public static Vector2 GetRecordingResolution(int width, int height, CaptureBase.DownScale downscale, Vector2 maxVideoSize) { }

	// RVA: 0x1DB26B0 Offset: 0x1DB27B1 VA: 0x1DB26B0
	public void SelectRecordingResolution(int width, int height) { }

	// RVA: 0x1DB27D0 Offset: 0x1DB28D1 VA: 0x1DB27D0 Slot: 6
	public virtual void OnDestroy() { }

	// RVA: 0x1DB2810 Offset: 0x1DB2911 VA: 0x1DB2810
	private void OnApplicationQuit() { }

	// RVA: 0x1DB28C0 Offset: 0x1DB29C1 VA: 0x1DB28C0
	protected void EncodeTexture(Texture2D texture) { }

	// RVA: 0x1DB2940 Offset: 0x1DB2A41 VA: 0x1DB2940
	protected bool IsUsingUnityAudio() { }

	// RVA: 0x1DB29E0 Offset: 0x1DB2AE1 VA: 0x1DB29E0
	protected bool IsRecordingUnityAudio() { }

	// RVA: 0x1DB2A90 Offset: 0x1DB2B91 VA: 0x1DB2A90
	protected bool IsUsingMotionBlur() { }

	// RVA: 0x1DB2B20 Offset: 0x1DB2C21 VA: 0x1DB2B20 Slot: 7
	public virtual void EncodePointer(IntPtr ptr) { }

	// RVA: 0x1DB2BB0 Offset: 0x1DB2CB1 VA: 0x1DB2BB0
	public bool IsCapturing() { }

	// RVA: 0x1DB2BC0 Offset: 0x1DB2CC1 VA: 0x1DB2BC0
	public bool IsPaused() { }

	// RVA: 0x1DB2BD0 Offset: 0x1DB2CD1 VA: 0x1DB2BD0
	public int GetRecordingWidth() { }

	// RVA: 0x1DB2BE0 Offset: 0x1DB2CE1 VA: 0x1DB2BE0
	public int GetRecordingHeight() { }

	// RVA: 0x1DB2BF0 Offset: 0x1DB2CF1 VA: 0x1DB2BF0 Slot: 8
	protected virtual string GenerateTimestampedFilename(string filenamePrefix, string filenameExtension) { }

	// RVA: 0x1DB2F90 Offset: 0x1DB3091 VA: 0x1DB2F90
	private static string GetFolder(CaptureBase.OutputPath outputPathType, string path) { }

	// RVA: 0x1DB30A0 Offset: 0x1DB31A1 VA: 0x1DB30A0
	private static string AutoGenerateFilename(CaptureBase.OutputPath outputPathType, string path, string filename) { }

	// RVA: 0x1DB3150 Offset: 0x1DB3251 VA: 0x1DB3150
	private static string ManualGenerateFilename(CaptureBase.OutputPath outputPathType, string path, string filename) { }

	// RVA: 0x1DB3250 Offset: 0x1DB3351 VA: 0x1DB3250
	protected static bool HasExtension(string path, string extension) { }

	// RVA: 0x1DB3290 Offset: 0x1DB3391 VA: 0x1DB3290
	protected void GenerateFilename() { }

	// RVA: 0x1DB37D0 Offset: 0x1DB38D1 VA: 0x1DB37D0 Slot: 9
	public virtual bool PrepareCapture() { }

	// RVA: 0x1DB46C0 Offset: 0x1DB47C1 VA: 0x1DB46C0
	public void QueueStartCapture() { }

	// RVA: 0x1DB23A0 Offset: 0x1DB24A1 VA: 0x1DB23A0
	public bool StartCapture() { }

	// RVA: 0x1DB4710 Offset: 0x1DB4811 VA: 0x1DB4710
	public void PauseCapture() { }

	// RVA: 0x1DB4800 Offset: 0x1DB4901 VA: 0x1DB4800
	public void ResumeCapture() { }

	// RVA: 0x1DB4910 Offset: 0x1DB4A11 VA: 0x1DB4910
	public void CancelCapture() { }

	// RVA: 0x1DB4970 Offset: 0x1DB4A71 VA: 0x1DB4970 Slot: 10
	public virtual void UnprepareCapture() { }

	// RVA: 0x1DB4A10 Offset: 0x1DB4B11 VA: 0x1DB4A10
	public static string get_LastFileSaved() { }

	// RVA: 0x1DB4A70 Offset: 0x1DB4B71 VA: 0x1DB4A70
	public static void set_LastFileSaved(string value) { }

	// RVA: 0x1DB4AD0 Offset: 0x1DB4BD1 VA: 0x1DB4AD0
	protected void RenderThreadEvent(NativePlugin.PluginEvent renderEvent) { }

	// RVA: 0x1DB4B90 Offset: 0x1DB4C91 VA: 0x1DB4B90 Slot: 11
	public virtual void StopCapture(bool skipPendingFrames = False) { }

	// RVA: 0x1DB4FA0 Offset: 0x1DB50A1 VA: 0x1DB4FA0
	protected void ApplyPostOperations(string path) { }

	// RVA: 0x1DB5180 Offset: 0x1DB5281 VA: 0x1DB5180
	private void ToggleCapture() { }

	// RVA: 0x1DB51A0 Offset: 0x1DB52A1 VA: 0x1DB51A0
	private bool IsEnoughDiskSpace() { }

	// RVA: 0x1DB51B0 Offset: 0x1DB52B1 VA: 0x1DB51B0
	private void LateUpdate() { }

	// RVA: 0x1DB5210 Offset: 0x1DB5311 VA: 0x1DB5210
	private void CheckFreeDiskSpace() { }

	// RVA: 0x1DB5250 Offset: 0x1DB5351 VA: 0x1DB5250
	protected bool IsProgressComplete() { }

	// RVA: 0x1DB5330 Offset: 0x1DB5431 VA: 0x1DB5330
	public float GetProgress() { }

	// RVA: 0x1DB46E0 Offset: 0x1DB47E1 VA: 0x1DB46E0
	protected float GetSecondsPerCaptureFrame() { }

	// RVA: 0x1DB53F0 Offset: 0x1DB54F1 VA: 0x1DB53F0
	protected bool CanOutputFrame() { }

	// RVA: 0x1DB54D0 Offset: 0x1DB55D1 VA: 0x1DB54D0
	protected void TickFrameTimer() { }

	// RVA: 0x1DB5510 Offset: 0x1DB5611 VA: 0x1DB5510
	protected void RenormTimer() { }

	// RVA: 0x1DB5550 Offset: 0x1DB5651 VA: 0x1DB5550 Slot: 12
	public virtual Texture GetPreviewTexture() { }

	// RVA: 0x1DB5560 Offset: 0x1DB5661 VA: 0x1DB5560 Slot: 13
	public virtual void UpdateFrame() { }

	// RVA: 0x1DB56D0 Offset: 0x1DB57D1 VA: 0x1DB56D0
	public float get_FPS() { }

	// RVA: 0x1DB56E0 Offset: 0x1DB57E1 VA: 0x1DB56E0
	public float get_FramesTotal() { }

	// RVA: 0x1DB46D0 Offset: 0x1DB47D1 VA: 0x1DB46D0
	protected void ResetFPS() { }

	// RVA: 0x1DB56F0 Offset: 0x1DB57F1 VA: 0x1DB56F0
	public void UpdateFPS() { }

	// RVA: 0x1DB5760 Offset: 0x1DB5861 VA: 0x1DB5760
	protected int GetCameraAntiAliasingLevel(Camera camera) { }

	// RVA: 0x1DB5900 Offset: 0x1DB5A01 VA: 0x1DB5900
	private void ConfigureCodec() { }

	// RVA: 0x1DB5950 Offset: 0x1DB5A51 VA: 0x1DB5950
	public long GetCaptureFileSize() { }

	// RVA: 0x1DB5A30 Offset: 0x1DB5B31 VA: 0x1DB5A30
	public static void GetResolution(CaptureBase.Resolution res, ref int width, ref int height) { }

	// RVA: 0x1DB26A0 Offset: 0x1DB27A1 VA: 0x1DB26A0
	protected static int NextMultipleOf4(int value) { }

	// RVA: 0x1DB5A60 Offset: 0x1DB5B61 VA: 0x1DB5A60
	public void .ctor() { }

	// RVA: 0x1DB5DA0 Offset: 0x1DB5EA1 VA: 0x1DB5DA0
	private static void .cctor() { }
}

public class CaptureBase : MonoBehaviour // TypeDefIndex: 9603
{
	// Fields
	[SerializeField] // RVA: 0x17D3B0 Offset: 0x17D4B1 VA: 0x17D3B0
	private CaptureBase.PostCaptureSettings _postCaptureSettings; // 0x18
	public KeyCode _captureKey; // 0x20
	public bool _captureOnStart; // 0x24
	public bool _startPaused; // 0x25
	public bool _listVideoCodecsOnStart; // 0x26
	public bool _isRealTime; // 0x27
	[SerializeField] // RVA: 0x17D3C0 Offset: 0x17D4C1 VA: 0x17D3C0
	private bool _persistAcrossSceneLoads; // 0x28
	public StopMode _stopMode; // 0x2C
	public int _stopFrames; // 0x30
	public float _stopSeconds; // 0x34
	public bool _useMediaFoundationH264; // 0x38
	[SerializeField] // RVA: 0x17D3D0 Offset: 0x17D4D1 VA: 0x17D3D0
	private string[] _videoCodecPriority; // 0x40
	public CaptureBase.FrameRate _frameRate; // 0x48
	[SerializeField] // RVA: 0x17D3E0 Offset: 0x17D4E1 VA: 0x17D3E0
	[TooltipAttribute] // RVA: 0x17D3E0 Offset: 0x17D4E1 VA: 0x17D3E0
	private int _timelapseScale; // 0x4C
	public CaptureBase.DownScale _downScale; // 0x50
	public Vector2 _maxVideoSize; // 0x54
	public int _forceVideoCodecIndex; // 0x5C
	public bool _flipVertically; // 0x60
	public bool _supportAlpha; // 0x61
	[TooltipAttribute] // RVA: 0x17D430 Offset: 0x17D531 VA: 0x17D430
	[SerializeField] // RVA: 0x17D430 Offset: 0x17D531 VA: 0x17D430
	private bool _forceGpuFlush; // 0x62
	[TooltipAttribute] // RVA: 0x17D480 Offset: 0x17D581 VA: 0x17D480
	[SerializeField] // RVA: 0x17D480 Offset: 0x17D581 VA: 0x17D480
	protected bool _useWaitForEndOfFrame; // 0x63
	public bool _noAudio; // 0x64
	public string[] _audioCodecPriority; // 0x68
	public int _forceAudioCodecIndex; // 0x70
	public int _forceAudioDeviceIndex; // 0x74
	public UnityAudioCapture _audioCapture; // 0x78
	public bool _autoGenerateFilename; // 0x80
	public CaptureBase.OutputPath _outputFolderType; // 0x84
	public string _outputFolderPath; // 0x88
	public string _autoFilenamePrefix; // 0x90
	public string _autoFilenameExtension; // 0x98
	public string _forceFilename; // 0xA0
	public int _imageSequenceStartFrame; // 0xA8
	[RangeAttribute] // RVA: 0x17D4D0 Offset: 0x17D5D1 VA: 0x17D4D0
	public int _imageSequenceZeroDigits; // 0xAC
	public CaptureBase.OutputType _outputType; // 0xB0
	public ImageSequenceFormat _imageSequenceFormat; // 0xB4
	public CaptureBase.Resolution _renderResolution; // 0xB8
	public Vector2 _renderSize; // 0xBC
	public int _renderAntiAliasing; // 0xC4
	public bool _useMotionBlur; // 0xC8
	[RangeAttribute] // RVA: 0x17D4F0 Offset: 0x17D5F1 VA: 0x17D4F0
	public int _motionBlurSamples; // 0xCC
	public Camera[] _motionBlurCameras; // 0xD0
	protected MotionBlur _motionBlur; // 0xD8
	public bool _allowVSyncDisable; // 0xE0
	[SerializeField] // RVA: 0x17D510 Offset: 0x17D611 VA: 0x17D510
	protected bool _supportTextureRecreate; // 0xE1
	public bool _captureMouseCursor; // 0xE2
	public MouseCursor _mouseCursor; // 0xE8
	public string _codecName; // 0xF0
	public int _codecIndex; // 0xF8
	public string _audioCodecName; // 0x100
	public int _audioCodecIndex; // 0x108
	public string _audioDeviceName; // 0x110
	public int _audioDeviceIndex; // 0x118
	public int _unityAudioSampleRate; // 0x11C
	public int _unityAudioChannelCount; // 0x120
	protected Texture2D _texture; // 0x128
	protected int _handle; // 0x130
	protected int _targetWidth; // 0x134
	protected int _targetHeight; // 0x138
	protected bool _capturing; // 0x13C
	protected bool _paused; // 0x13D
	protected string _filePath; // 0x140
	protected FileInfo _fileInfo; // 0x148
	protected NativePlugin.PixelFormat _pixelFormat; // 0x150
	private int _oldVSyncCount; // 0x154
	private float _oldFixedDeltaTime; // 0x158
	protected bool _isTopDown; // 0x15C
	protected bool _isDirectX11; // 0x15D
	private bool _queuedStartCapture; // 0x15E
	private bool _queuedStopCapture; // 0x15F
	private float _captureStartTime; // 0x160
	private float _timeSinceLastFrame; // 0x164
	protected YieldInstruction _waitForEndOfFrame; // 0x168
	public int _minimumDiskSpaceMB; // 0x170
	private long _freeDiskSpaceMB; // 0x178
	private uint _numDroppedFrames; // 0x180
	private uint _numDroppedEncoderFrames; // 0x184
	private uint _numEncodedFrames; // 0x188
	private uint _totalEncodedSeconds; // 0x18C
	private static bool _isInitialised; // 0x0
	protected IntPtr _renderEventFunction; // 0x190
	protected IntPtr _freeEventFunction; // 0x198
	private float _fps; // 0x1A0
	private int _frameTotal; // 0x1A4
	private int _frameCount; // 0x1A8
	private float _startFrameTime; // 0x1AC

	// Properties
	public string LastFilePath { get; }
	public uint NumDroppedFrames { get; }
	public uint NumDroppedEncoderFrames { get; }
	public uint NumEncodedFrames { get; }
	public uint TotalEncodedSeconds { get; }
	public string[] VideoCodecPriority { get; set; }
	public int TimelapseScale { get; set; }
	public bool UseWaitForEndOfFrame { get; set; }
	public CaptureBase.PostCaptureSettings PostCapture { get; }
	public static string LastFileSaved { get; set; }
	public float FPS { get; }
	public float FramesTotal { get; }

	// Methods

	// RVA: 0x1DB0E10 Offset: 0x1DB0F11 VA: 0x1DB0E10
	public string get_LastFilePath() { }

	// RVA: 0x1DB0E20 Offset: 0x1DB0F21 VA: 0x1DB0E20
	public uint get_NumDroppedFrames() { }

	// RVA: 0x1DB0E30 Offset: 0x1DB0F31 VA: 0x1DB0E30
	public uint get_NumDroppedEncoderFrames() { }

	// RVA: 0x1DB0E40 Offset: 0x1DB0F41 VA: 0x1DB0E40
	public uint get_NumEncodedFrames() { }

	// RVA: 0x1DB0E50 Offset: 0x1DB0F51 VA: 0x1DB0E50
	public uint get_TotalEncodedSeconds() { }

	// RVA: 0x1DB0E60 Offset: 0x1DB0F61 VA: 0x1DB0E60
	public string[] get_VideoCodecPriority() { }

	// RVA: 0x1DB0E70 Offset: 0x1DB0F71 VA: 0x1DB0E70
	public void set_VideoCodecPriority(string[] value) { }

	// RVA: 0x1DB12B0 Offset: 0x1DB13B1 VA: 0x1DB12B0
	public int get_TimelapseScale() { }

	// RVA: 0x1DB12C0 Offset: 0x1DB13C1 VA: 0x1DB12C0
	public void set_TimelapseScale(int value) { }

	// RVA: 0x1DB12D0 Offset: 0x1DB13D1 VA: 0x1DB12D0
	public bool get_UseWaitForEndOfFrame() { }

	// RVA: 0x1DB12E0 Offset: 0x1DB13E1 VA: 0x1DB12E0
	public void set_UseWaitForEndOfFrame(bool value) { }

	// RVA: 0x1DB12F0 Offset: 0x1DB13F1 VA: 0x1DB12F0
	public CaptureBase.PostCaptureSettings get_PostCapture() { }

	// RVA: 0x1DB1300 Offset: 0x1DB1401 VA: 0x1DB1300 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0x1DB1C30 Offset: 0x1DB1D31 VA: 0x1DB1C30
	protected void SetupRenderFunctions() { }

	// RVA: 0x1DB2310 Offset: 0x1DB2411 VA: 0x1DB2310 Slot: 5
	public virtual void Start() { }

	// RVA: 0x1DB0EA0 Offset: 0x1DB0FA1 VA: 0x1DB0EA0
	public void SelectCodec(bool listCodecs) { }

	// RVA: 0x1DB1C70 Offset: 0x1DB1D71 VA: 0x1DB1C70
	public void SelectAudioCodec(bool listCodecs) { }

	// RVA: 0x1DB2080 Offset: 0x1DB2181 VA: 0x1DB2080
	public void SelectAudioDevice(bool display) { }

	// RVA: 0x1DB2580 Offset: 0x1DB2681 VA: 0x1DB2580
	public static Vector2 GetRecordingResolution(int width, int height, CaptureBase.DownScale downscale, Vector2 maxVideoSize) { }

	// RVA: 0x1DB26B0 Offset: 0x1DB27B1 VA: 0x1DB26B0
	public void SelectRecordingResolution(int width, int height) { }

	// RVA: 0x1DB27D0 Offset: 0x1DB28D1 VA: 0x1DB27D0 Slot: 6
	public virtual void OnDestroy() { }

	// RVA: 0x1DB2810 Offset: 0x1DB2911 VA: 0x1DB2810
	private void OnApplicationQuit() { }

	// RVA: 0x1DB28C0 Offset: 0x1DB29C1 VA: 0x1DB28C0
	protected void EncodeTexture(Texture2D texture) { }

	// RVA: 0x1DB2940 Offset: 0x1DB2A41 VA: 0x1DB2940
	protected bool IsUsingUnityAudio() { }

	// RVA: 0x1DB29E0 Offset: 0x1DB2AE1 VA: 0x1DB29E0
	protected bool IsRecordingUnityAudio() { }

	// RVA: 0x1DB2A90 Offset: 0x1DB2B91 VA: 0x1DB2A90
	protected bool IsUsingMotionBlur() { }

	// RVA: 0x1DB2B20 Offset: 0x1DB2C21 VA: 0x1DB2B20 Slot: 7
	public virtual void EncodePointer(IntPtr ptr) { }

	// RVA: 0x1DB2BB0 Offset: 0x1DB2CB1 VA: 0x1DB2BB0
	public bool IsCapturing() { }

	// RVA: 0x1DB2BC0 Offset: 0x1DB2CC1 VA: 0x1DB2BC0
	public bool IsPaused() { }

	// RVA: 0x1DB2BD0 Offset: 0x1DB2CD1 VA: 0x1DB2BD0
	public int GetRecordingWidth() { }

	// RVA: 0x1DB2BE0 Offset: 0x1DB2CE1 VA: 0x1DB2BE0
	public int GetRecordingHeight() { }

	// RVA: 0x1DB2BF0 Offset: 0x1DB2CF1 VA: 0x1DB2BF0 Slot: 8
	protected virtual string GenerateTimestampedFilename(string filenamePrefix, string filenameExtension) { }

	// RVA: 0x1DB2F90 Offset: 0x1DB3091 VA: 0x1DB2F90
	private static string GetFolder(CaptureBase.OutputPath outputPathType, string path) { }

	// RVA: 0x1DB30A0 Offset: 0x1DB31A1 VA: 0x1DB30A0
	private static string AutoGenerateFilename(CaptureBase.OutputPath outputPathType, string path, string filename) { }

	// RVA: 0x1DB3150 Offset: 0x1DB3251 VA: 0x1DB3150
	private static string ManualGenerateFilename(CaptureBase.OutputPath outputPathType, string path, string filename) { }

	// RVA: 0x1DB3250 Offset: 0x1DB3351 VA: 0x1DB3250
	protected static bool HasExtension(string path, string extension) { }

	// RVA: 0x1DB3290 Offset: 0x1DB3391 VA: 0x1DB3290
	protected void GenerateFilename() { }

	// RVA: 0x1DB37D0 Offset: 0x1DB38D1 VA: 0x1DB37D0 Slot: 9
	public virtual bool PrepareCapture() { }

	// RVA: 0x1DB46C0 Offset: 0x1DB47C1 VA: 0x1DB46C0
	public void QueueStartCapture() { }

	// RVA: 0x1DB23A0 Offset: 0x1DB24A1 VA: 0x1DB23A0
	public bool StartCapture() { }

	// RVA: 0x1DB4710 Offset: 0x1DB4811 VA: 0x1DB4710
	public void PauseCapture() { }

	// RVA: 0x1DB4800 Offset: 0x1DB4901 VA: 0x1DB4800
	public void ResumeCapture() { }

	// RVA: 0x1DB4910 Offset: 0x1DB4A11 VA: 0x1DB4910
	public void CancelCapture() { }

	// RVA: 0x1DB4970 Offset: 0x1DB4A71 VA: 0x1DB4970 Slot: 10
	public virtual void UnprepareCapture() { }

	// RVA: 0x1DB4A10 Offset: 0x1DB4B11 VA: 0x1DB4A10
	public static string get_LastFileSaved() { }

	// RVA: 0x1DB4A70 Offset: 0x1DB4B71 VA: 0x1DB4A70
	public static void set_LastFileSaved(string value) { }

	// RVA: 0x1DB4AD0 Offset: 0x1DB4BD1 VA: 0x1DB4AD0
	protected void RenderThreadEvent(NativePlugin.PluginEvent renderEvent) { }

	// RVA: 0x1DB4B90 Offset: 0x1DB4C91 VA: 0x1DB4B90 Slot: 11
	public virtual void StopCapture(bool skipPendingFrames = False) { }

	// RVA: 0x1DB4FA0 Offset: 0x1DB50A1 VA: 0x1DB4FA0
	protected void ApplyPostOperations(string path) { }

	// RVA: 0x1DB5180 Offset: 0x1DB5281 VA: 0x1DB5180
	private void ToggleCapture() { }

	// RVA: 0x1DB51A0 Offset: 0x1DB52A1 VA: 0x1DB51A0
	private bool IsEnoughDiskSpace() { }

	// RVA: 0x1DB51B0 Offset: 0x1DB52B1 VA: 0x1DB51B0
	private void LateUpdate() { }

	// RVA: 0x1DB5210 Offset: 0x1DB5311 VA: 0x1DB5210
	private void CheckFreeDiskSpace() { }

	// RVA: 0x1DB5250 Offset: 0x1DB5351 VA: 0x1DB5250
	protected bool IsProgressComplete() { }

	// RVA: 0x1DB5330 Offset: 0x1DB5431 VA: 0x1DB5330
	public float GetProgress() { }

	// RVA: 0x1DB46E0 Offset: 0x1DB47E1 VA: 0x1DB46E0
	protected float GetSecondsPerCaptureFrame() { }

	// RVA: 0x1DB53F0 Offset: 0x1DB54F1 VA: 0x1DB53F0
	protected bool CanOutputFrame() { }

	// RVA: 0x1DB54D0 Offset: 0x1DB55D1 VA: 0x1DB54D0
	protected void TickFrameTimer() { }

	// RVA: 0x1DB5510 Offset: 0x1DB5611 VA: 0x1DB5510
	protected void RenormTimer() { }

	// RVA: 0x1DB5550 Offset: 0x1DB5651 VA: 0x1DB5550 Slot: 12
	public virtual Texture GetPreviewTexture() { }

	// RVA: 0x1DB5560 Offset: 0x1DB5661 VA: 0x1DB5560 Slot: 13
	public virtual void UpdateFrame() { }

	// RVA: 0x1DB56D0 Offset: 0x1DB57D1 VA: 0x1DB56D0
	public float get_FPS() { }

	// RVA: 0x1DB56E0 Offset: 0x1DB57E1 VA: 0x1DB56E0
	public float get_FramesTotal() { }

	// RVA: 0x1DB46D0 Offset: 0x1DB47D1 VA: 0x1DB46D0
	protected void ResetFPS() { }

	// RVA: 0x1DB56F0 Offset: 0x1DB57F1 VA: 0x1DB56F0
	public void UpdateFPS() { }

	// RVA: 0x1DB5760 Offset: 0x1DB5861 VA: 0x1DB5760
	protected int GetCameraAntiAliasingLevel(Camera camera) { }

	// RVA: 0x1DB5900 Offset: 0x1DB5A01 VA: 0x1DB5900
	private void ConfigureCodec() { }

	// RVA: 0x1DB5950 Offset: 0x1DB5A51 VA: 0x1DB5950
	public long GetCaptureFileSize() { }

	// RVA: 0x1DB5A30 Offset: 0x1DB5B31 VA: 0x1DB5A30
	public static void GetResolution(CaptureBase.Resolution res, ref int width, ref int height) { }

	// RVA: 0x1DB26A0 Offset: 0x1DB27A1 VA: 0x1DB26A0
	protected static int NextMultipleOf4(int value) { }

	// RVA: 0x1DB5A60 Offset: 0x1DB5B61 VA: 0x1DB5A60
	public void .ctor() { }

	// RVA: 0x1DB5DA0 Offset: 0x1DB5EA1 VA: 0x1DB5DA0
	private static void .cctor() { }
}

public class CaptureBase : MonoBehaviour // TypeDefIndex: 9603
{
	// Fields
	[SerializeField] // RVA: 0x17D3B0 Offset: 0x17D4B1 VA: 0x17D3B0
	private CaptureBase.PostCaptureSettings _postCaptureSettings; // 0x18
	public KeyCode _captureKey; // 0x20
	public bool _captureOnStart; // 0x24
	public bool _startPaused; // 0x25
	public bool _listVideoCodecsOnStart; // 0x26
	public bool _isRealTime; // 0x27
	[SerializeField] // RVA: 0x17D3C0 Offset: 0x17D4C1 VA: 0x17D3C0
	private bool _persistAcrossSceneLoads; // 0x28
	public StopMode _stopMode; // 0x2C
	public int _stopFrames; // 0x30
	public float _stopSeconds; // 0x34
	public bool _useMediaFoundationH264; // 0x38
	[SerializeField] // RVA: 0x17D3D0 Offset: 0x17D4D1 VA: 0x17D3D0
	private string[] _videoCodecPriority; // 0x40
	public CaptureBase.FrameRate _frameRate; // 0x48
	[SerializeField] // RVA: 0x17D3E0 Offset: 0x17D4E1 VA: 0x17D3E0
	[TooltipAttribute] // RVA: 0x17D3E0 Offset: 0x17D4E1 VA: 0x17D3E0
	private int _timelapseScale; // 0x4C
	public CaptureBase.DownScale _downScale; // 0x50
	public Vector2 _maxVideoSize; // 0x54
	public int _forceVideoCodecIndex; // 0x5C
	public bool _flipVertically; // 0x60
	public bool _supportAlpha; // 0x61
	[TooltipAttribute] // RVA: 0x17D430 Offset: 0x17D531 VA: 0x17D430
	[SerializeField] // RVA: 0x17D430 Offset: 0x17D531 VA: 0x17D430
	private bool _forceGpuFlush; // 0x62
	[TooltipAttribute] // RVA: 0x17D480 Offset: 0x17D581 VA: 0x17D480
	[SerializeField] // RVA: 0x17D480 Offset: 0x17D581 VA: 0x17D480
	protected bool _useWaitForEndOfFrame; // 0x63
	public bool _noAudio; // 0x64
	public string[] _audioCodecPriority; // 0x68
	public int _forceAudioCodecIndex; // 0x70
	public int _forceAudioDeviceIndex; // 0x74
	public UnityAudioCapture _audioCapture; // 0x78
	public bool _autoGenerateFilename; // 0x80
	public CaptureBase.OutputPath _outputFolderType; // 0x84
	public string _outputFolderPath; // 0x88
	public string _autoFilenamePrefix; // 0x90
	public string _autoFilenameExtension; // 0x98
	public string _forceFilename; // 0xA0
	public int _imageSequenceStartFrame; // 0xA8
	[RangeAttribute] // RVA: 0x17D4D0 Offset: 0x17D5D1 VA: 0x17D4D0
	public int _imageSequenceZeroDigits; // 0xAC
	public CaptureBase.OutputType _outputType; // 0xB0
	public ImageSequenceFormat _imageSequenceFormat; // 0xB4
	public CaptureBase.Resolution _renderResolution; // 0xB8
	public Vector2 _renderSize; // 0xBC
	public int _renderAntiAliasing; // 0xC4
	public bool _useMotionBlur; // 0xC8
	[RangeAttribute] // RVA: 0x17D4F0 Offset: 0x17D5F1 VA: 0x17D4F0
	public int _motionBlurSamples; // 0xCC
	public Camera[] _motionBlurCameras; // 0xD0
	protected MotionBlur _motionBlur; // 0xD8
	public bool _allowVSyncDisable; // 0xE0
	[SerializeField] // RVA: 0x17D510 Offset: 0x17D611 VA: 0x17D510
	protected bool _supportTextureRecreate; // 0xE1
	public bool _captureMouseCursor; // 0xE2
	public MouseCursor _mouseCursor; // 0xE8
	public string _codecName; // 0xF0
	public int _codecIndex; // 0xF8
	public string _audioCodecName; // 0x100
	public int _audioCodecIndex; // 0x108
	public string _audioDeviceName; // 0x110
	public int _audioDeviceIndex; // 0x118
	public int _unityAudioSampleRate; // 0x11C
	public int _unityAudioChannelCount; // 0x120
	protected Texture2D _texture; // 0x128
	protected int _handle; // 0x130
	protected int _targetWidth; // 0x134
	protected int _targetHeight; // 0x138
	protected bool _capturing; // 0x13C
	protected bool _paused; // 0x13D
	protected string _filePath; // 0x140
	protected FileInfo _fileInfo; // 0x148
	protected NativePlugin.PixelFormat _pixelFormat; // 0x150
	private int _oldVSyncCount; // 0x154
	private float _oldFixedDeltaTime; // 0x158
	protected bool _isTopDown; // 0x15C
	protected bool _isDirectX11; // 0x15D
	private bool _queuedStartCapture; // 0x15E
	private bool _queuedStopCapture; // 0x15F
	private float _captureStartTime; // 0x160
	private float _timeSinceLastFrame; // 0x164
	protected YieldInstruction _waitForEndOfFrame; // 0x168
	public int _minimumDiskSpaceMB; // 0x170
	private long _freeDiskSpaceMB; // 0x178
	private uint _numDroppedFrames; // 0x180
	private uint _numDroppedEncoderFrames; // 0x184
	private uint _numEncodedFrames; // 0x188
	private uint _totalEncodedSeconds; // 0x18C
	private static bool _isInitialised; // 0x0
	protected IntPtr _renderEventFunction; // 0x190
	protected IntPtr _freeEventFunction; // 0x198
	private float _fps; // 0x1A0
	private int _frameTotal; // 0x1A4
	private int _frameCount; // 0x1A8
	private float _startFrameTime; // 0x1AC

	// Properties
	public string LastFilePath { get; }
	public uint NumDroppedFrames { get; }
	public uint NumDroppedEncoderFrames { get; }
	public uint NumEncodedFrames { get; }
	public uint TotalEncodedSeconds { get; }
	public string[] VideoCodecPriority { get; set; }
	public int TimelapseScale { get; set; }
	public bool UseWaitForEndOfFrame { get; set; }
	public CaptureBase.PostCaptureSettings PostCapture { get; }
	public static string LastFileSaved { get; set; }
	public float FPS { get; }
	public float FramesTotal { get; }

	// Methods

	// RVA: 0x1DB0E10 Offset: 0x1DB0F11 VA: 0x1DB0E10
	public string get_LastFilePath() { }

	// RVA: 0x1DB0E20 Offset: 0x1DB0F21 VA: 0x1DB0E20
	public uint get_NumDroppedFrames() { }

	// RVA: 0x1DB0E30 Offset: 0x1DB0F31 VA: 0x1DB0E30
	public uint get_NumDroppedEncoderFrames() { }

	// RVA: 0x1DB0E40 Offset: 0x1DB0F41 VA: 0x1DB0E40
	public uint get_NumEncodedFrames() { }

	// RVA: 0x1DB0E50 Offset: 0x1DB0F51 VA: 0x1DB0E50
	public uint get_TotalEncodedSeconds() { }

	// RVA: 0x1DB0E60 Offset: 0x1DB0F61 VA: 0x1DB0E60
	public string[] get_VideoCodecPriority() { }

	// RVA: 0x1DB0E70 Offset: 0x1DB0F71 VA: 0x1DB0E70
	public void set_VideoCodecPriority(string[] value) { }

	// RVA: 0x1DB12B0 Offset: 0x1DB13B1 VA: 0x1DB12B0
	public int get_TimelapseScale() { }

	// RVA: 0x1DB12C0 Offset: 0x1DB13C1 VA: 0x1DB12C0
	public void set_TimelapseScale(int value) { }

	// RVA: 0x1DB12D0 Offset: 0x1DB13D1 VA: 0x1DB12D0
	public bool get_UseWaitForEndOfFrame() { }

	// RVA: 0x1DB12E0 Offset: 0x1DB13E1 VA: 0x1DB12E0
	public void set_UseWaitForEndOfFrame(bool value) { }

	// RVA: 0x1DB12F0 Offset: 0x1DB13F1 VA: 0x1DB12F0
	public CaptureBase.PostCaptureSettings get_PostCapture() { }

	// RVA: 0x1DB1300 Offset: 0x1DB1401 VA: 0x1DB1300 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0x1DB1C30 Offset: 0x1DB1D31 VA: 0x1DB1C30
	protected void SetupRenderFunctions() { }

	// RVA: 0x1DB2310 Offset: 0x1DB2411 VA: 0x1DB2310 Slot: 5
	public virtual void Start() { }

	// RVA: 0x1DB0EA0 Offset: 0x1DB0FA1 VA: 0x1DB0EA0
	public void SelectCodec(bool listCodecs) { }

	// RVA: 0x1DB1C70 Offset: 0x1DB1D71 VA: 0x1DB1C70
	public void SelectAudioCodec(bool listCodecs) { }

	// RVA: 0x1DB2080 Offset: 0x1DB2181 VA: 0x1DB2080
	public void SelectAudioDevice(bool display) { }

	// RVA: 0x1DB2580 Offset: 0x1DB2681 VA: 0x1DB2580
	public static Vector2 GetRecordingResolution(int width, int height, CaptureBase.DownScale downscale, Vector2 maxVideoSize) { }

	// RVA: 0x1DB26B0 Offset: 0x1DB27B1 VA: 0x1DB26B0
	public void SelectRecordingResolution(int width, int height) { }

	// RVA: 0x1DB27D0 Offset: 0x1DB28D1 VA: 0x1DB27D0 Slot: 6
	public virtual void OnDestroy() { }

	// RVA: 0x1DB2810 Offset: 0x1DB2911 VA: 0x1DB2810
	private void OnApplicationQuit() { }

	// RVA: 0x1DB28C0 Offset: 0x1DB29C1 VA: 0x1DB28C0
	protected void EncodeTexture(Texture2D texture) { }

	// RVA: 0x1DB2940 Offset: 0x1DB2A41 VA: 0x1DB2940
	protected bool IsUsingUnityAudio() { }

	// RVA: 0x1DB29E0 Offset: 0x1DB2AE1 VA: 0x1DB29E0
	protected bool IsRecordingUnityAudio() { }

	// RVA: 0x1DB2A90 Offset: 0x1DB2B91 VA: 0x1DB2A90
	protected bool IsUsingMotionBlur() { }

	// RVA: 0x1DB2B20 Offset: 0x1DB2C21 VA: 0x1DB2B20 Slot: 7
	public virtual void EncodePointer(IntPtr ptr) { }

	// RVA: 0x1DB2BB0 Offset: 0x1DB2CB1 VA: 0x1DB2BB0
	public bool IsCapturing() { }

	// RVA: 0x1DB2BC0 Offset: 0x1DB2CC1 VA: 0x1DB2BC0
	public bool IsPaused() { }

	// RVA: 0x1DB2BD0 Offset: 0x1DB2CD1 VA: 0x1DB2BD0
	public int GetRecordingWidth() { }

	// RVA: 0x1DB2BE0 Offset: 0x1DB2CE1 VA: 0x1DB2BE0
	public int GetRecordingHeight() { }

	// RVA: 0x1DB2BF0 Offset: 0x1DB2CF1 VA: 0x1DB2BF0 Slot: 8
	protected virtual string GenerateTimestampedFilename(string filenamePrefix, string filenameExtension) { }

	// RVA: 0x1DB2F90 Offset: 0x1DB3091 VA: 0x1DB2F90
	private static string GetFolder(CaptureBase.OutputPath outputPathType, string path) { }

	// RVA: 0x1DB30A0 Offset: 0x1DB31A1 VA: 0x1DB30A0
	private static string AutoGenerateFilename(CaptureBase.OutputPath outputPathType, string path, string filename) { }

	// RVA: 0x1DB3150 Offset: 0x1DB3251 VA: 0x1DB3150
	private static string ManualGenerateFilename(CaptureBase.OutputPath outputPathType, string path, string filename) { }

	// RVA: 0x1DB3250 Offset: 0x1DB3351 VA: 0x1DB3250
	protected static bool HasExtension(string path, string extension) { }

	// RVA: 0x1DB3290 Offset: 0x1DB3391 VA: 0x1DB3290
	protected void GenerateFilename() { }

	// RVA: 0x1DB37D0 Offset: 0x1DB38D1 VA: 0x1DB37D0 Slot: 9
	public virtual bool PrepareCapture() { }

	// RVA: 0x1DB46C0 Offset: 0x1DB47C1 VA: 0x1DB46C0
	public void QueueStartCapture() { }

	// RVA: 0x1DB23A0 Offset: 0x1DB24A1 VA: 0x1DB23A0
	public bool StartCapture() { }

	// RVA: 0x1DB4710 Offset: 0x1DB4811 VA: 0x1DB4710
	public void PauseCapture() { }

	// RVA: 0x1DB4800 Offset: 0x1DB4901 VA: 0x1DB4800
	public void ResumeCapture() { }

	// RVA: 0x1DB4910 Offset: 0x1DB4A11 VA: 0x1DB4910
	public void CancelCapture() { }

	// RVA: 0x1DB4970 Offset: 0x1DB4A71 VA: 0x1DB4970 Slot: 10
	public virtual void UnprepareCapture() { }

	// RVA: 0x1DB4A10 Offset: 0x1DB4B11 VA: 0x1DB4A10
	public static string get_LastFileSaved() { }

	// RVA: 0x1DB4A70 Offset: 0x1DB4B71 VA: 0x1DB4A70
	public static void set_LastFileSaved(string value) { }

	// RVA: 0x1DB4AD0 Offset: 0x1DB4BD1 VA: 0x1DB4AD0
	protected void RenderThreadEvent(NativePlugin.PluginEvent renderEvent) { }

	// RVA: 0x1DB4B90 Offset: 0x1DB4C91 VA: 0x1DB4B90 Slot: 11
	public virtual void StopCapture(bool skipPendingFrames = False) { }

	// RVA: 0x1DB4FA0 Offset: 0x1DB50A1 VA: 0x1DB4FA0
	protected void ApplyPostOperations(string path) { }

	// RVA: 0x1DB5180 Offset: 0x1DB5281 VA: 0x1DB5180
	private void ToggleCapture() { }

	// RVA: 0x1DB51A0 Offset: 0x1DB52A1 VA: 0x1DB51A0
	private bool IsEnoughDiskSpace() { }

	// RVA: 0x1DB51B0 Offset: 0x1DB52B1 VA: 0x1DB51B0
	private void LateUpdate() { }

	// RVA: 0x1DB5210 Offset: 0x1DB5311 VA: 0x1DB5210
	private void CheckFreeDiskSpace() { }

	// RVA: 0x1DB5250 Offset: 0x1DB5351 VA: 0x1DB5250
	protected bool IsProgressComplete() { }

	// RVA: 0x1DB5330 Offset: 0x1DB5431 VA: 0x1DB5330
	public float GetProgress() { }

	// RVA: 0x1DB46E0 Offset: 0x1DB47E1 VA: 0x1DB46E0
	protected float GetSecondsPerCaptureFrame() { }

	// RVA: 0x1DB53F0 Offset: 0x1DB54F1 VA: 0x1DB53F0
	protected bool CanOutputFrame() { }

	// RVA: 0x1DB54D0 Offset: 0x1DB55D1 VA: 0x1DB54D0
	protected void TickFrameTimer() { }

	// RVA: 0x1DB5510 Offset: 0x1DB5611 VA: 0x1DB5510
	protected void RenormTimer() { }

	// RVA: 0x1DB5550 Offset: 0x1DB5651 VA: 0x1DB5550 Slot: 12
	public virtual Texture GetPreviewTexture() { }

	// RVA: 0x1DB5560 Offset: 0x1DB5661 VA: 0x1DB5560 Slot: 13
	public virtual void UpdateFrame() { }

	// RVA: 0x1DB56D0 Offset: 0x1DB57D1 VA: 0x1DB56D0
	public float get_FPS() { }

	// RVA: 0x1DB56E0 Offset: 0x1DB57E1 VA: 0x1DB56E0
	public float get_FramesTotal() { }

	// RVA: 0x1DB46D0 Offset: 0x1DB47D1 VA: 0x1DB46D0
	protected void ResetFPS() { }

	// RVA: 0x1DB56F0 Offset: 0x1DB57F1 VA: 0x1DB56F0
	public void UpdateFPS() { }

	// RVA: 0x1DB5760 Offset: 0x1DB5861 VA: 0x1DB5760
	protected int GetCameraAntiAliasingLevel(Camera camera) { }

	// RVA: 0x1DB5900 Offset: 0x1DB5A01 VA: 0x1DB5900
	private void ConfigureCodec() { }

	// RVA: 0x1DB5950 Offset: 0x1DB5A51 VA: 0x1DB5950
	public long GetCaptureFileSize() { }

	// RVA: 0x1DB5A30 Offset: 0x1DB5B31 VA: 0x1DB5A30
	public static void GetResolution(CaptureBase.Resolution res, ref int width, ref int height) { }

	// RVA: 0x1DB26A0 Offset: 0x1DB27A1 VA: 0x1DB26A0
	protected static int NextMultipleOf4(int value) { }

	// RVA: 0x1DB5A60 Offset: 0x1DB5B61 VA: 0x1DB5A60
	public void .ctor() { }

	// RVA: 0x1DB5DA0 Offset: 0x1DB5EA1 VA: 0x1DB5DA0
	private static void .cctor() { }
}

public class CaptureBase : MonoBehaviour // TypeDefIndex: 9603
{
	// Fields
	[SerializeField] // RVA: 0x17D3B0 Offset: 0x17D4B1 VA: 0x17D3B0
	private CaptureBase.PostCaptureSettings _postCaptureSettings; // 0x18
	public KeyCode _captureKey; // 0x20
	public bool _captureOnStart; // 0x24
	public bool _startPaused; // 0x25
	public bool _listVideoCodecsOnStart; // 0x26
	public bool _isRealTime; // 0x27
	[SerializeField] // RVA: 0x17D3C0 Offset: 0x17D4C1 VA: 0x17D3C0
	private bool _persistAcrossSceneLoads; // 0x28
	public StopMode _stopMode; // 0x2C
	public int _stopFrames; // 0x30
	public float _stopSeconds; // 0x34
	public bool _useMediaFoundationH264; // 0x38
	[SerializeField] // RVA: 0x17D3D0 Offset: 0x17D4D1 VA: 0x17D3D0
	private string[] _videoCodecPriority; // 0x40
	public CaptureBase.FrameRate _frameRate; // 0x48
	[SerializeField] // RVA: 0x17D3E0 Offset: 0x17D4E1 VA: 0x17D3E0
	[TooltipAttribute] // RVA: 0x17D3E0 Offset: 0x17D4E1 VA: 0x17D3E0
	private int _timelapseScale; // 0x4C
	public CaptureBase.DownScale _downScale; // 0x50
	public Vector2 _maxVideoSize; // 0x54
	public int _forceVideoCodecIndex; // 0x5C
	public bool _flipVertically; // 0x60
	public bool _supportAlpha; // 0x61
	[TooltipAttribute] // RVA: 0x17D430 Offset: 0x17D531 VA: 0x17D430
	[SerializeField] // RVA: 0x17D430 Offset: 0x17D531 VA: 0x17D430
	private bool _forceGpuFlush; // 0x62
	[TooltipAttribute] // RVA: 0x17D480 Offset: 0x17D581 VA: 0x17D480
	[SerializeField] // RVA: 0x17D480 Offset: 0x17D581 VA: 0x17D480
	protected bool _useWaitForEndOfFrame; // 0x63
	public bool _noAudio; // 0x64
	public string[] _audioCodecPriority; // 0x68
	public int _forceAudioCodecIndex; // 0x70
	public int _forceAudioDeviceIndex; // 0x74
	public UnityAudioCapture _audioCapture; // 0x78
	public bool _autoGenerateFilename; // 0x80
	public CaptureBase.OutputPath _outputFolderType; // 0x84
	public string _outputFolderPath; // 0x88
	public string _autoFilenamePrefix; // 0x90
	public string _autoFilenameExtension; // 0x98
	public string _forceFilename; // 0xA0
	public int _imageSequenceStartFrame; // 0xA8
	[RangeAttribute] // RVA: 0x17D4D0 Offset: 0x17D5D1 VA: 0x17D4D0
	public int _imageSequenceZeroDigits; // 0xAC
	public CaptureBase.OutputType _outputType; // 0xB0
	public ImageSequenceFormat _imageSequenceFormat; // 0xB4
	public CaptureBase.Resolution _renderResolution; // 0xB8
	public Vector2 _renderSize; // 0xBC
	public int _renderAntiAliasing; // 0xC4
	public bool _useMotionBlur; // 0xC8
	[RangeAttribute] // RVA: 0x17D4F0 Offset: 0x17D5F1 VA: 0x17D4F0
	public int _motionBlurSamples; // 0xCC
	public Camera[] _motionBlurCameras; // 0xD0
	protected MotionBlur _motionBlur; // 0xD8
	public bool _allowVSyncDisable; // 0xE0
	[SerializeField] // RVA: 0x17D510 Offset: 0x17D611 VA: 0x17D510
	protected bool _supportTextureRecreate; // 0xE1
	public bool _captureMouseCursor; // 0xE2
	public MouseCursor _mouseCursor; // 0xE8
	public string _codecName; // 0xF0
	public int _codecIndex; // 0xF8
	public string _audioCodecName; // 0x100
	public int _audioCodecIndex; // 0x108
	public string _audioDeviceName; // 0x110
	public int _audioDeviceIndex; // 0x118
	public int _unityAudioSampleRate; // 0x11C
	public int _unityAudioChannelCount; // 0x120
	protected Texture2D _texture; // 0x128
	protected int _handle; // 0x130
	protected int _targetWidth; // 0x134
	protected int _targetHeight; // 0x138
	protected bool _capturing; // 0x13C
	protected bool _paused; // 0x13D
	protected string _filePath; // 0x140
	protected FileInfo _fileInfo; // 0x148
	protected NativePlugin.PixelFormat _pixelFormat; // 0x150
	private int _oldVSyncCount; // 0x154
	private float _oldFixedDeltaTime; // 0x158
	protected bool _isTopDown; // 0x15C
	protected bool _isDirectX11; // 0x15D
	private bool _queuedStartCapture; // 0x15E
	private bool _queuedStopCapture; // 0x15F
	private float _captureStartTime; // 0x160
	private float _timeSinceLastFrame; // 0x164
	protected YieldInstruction _waitForEndOfFrame; // 0x168
	public int _minimumDiskSpaceMB; // 0x170
	private long _freeDiskSpaceMB; // 0x178
	private uint _numDroppedFrames; // 0x180
	private uint _numDroppedEncoderFrames; // 0x184
	private uint _numEncodedFrames; // 0x188
	private uint _totalEncodedSeconds; // 0x18C
	private static bool _isInitialised; // 0x0
	protected IntPtr _renderEventFunction; // 0x190
	protected IntPtr _freeEventFunction; // 0x198
	private float _fps; // 0x1A0
	private int _frameTotal; // 0x1A4
	private int _frameCount; // 0x1A8
	private float _startFrameTime; // 0x1AC

	// Properties
	public string LastFilePath { get; }
	public uint NumDroppedFrames { get; }
	public uint NumDroppedEncoderFrames { get; }
	public uint NumEncodedFrames { get; }
	public uint TotalEncodedSeconds { get; }
	public string[] VideoCodecPriority { get; set; }
	public int TimelapseScale { get; set; }
	public bool UseWaitForEndOfFrame { get; set; }
	public CaptureBase.PostCaptureSettings PostCapture { get; }
	public static string LastFileSaved { get; set; }
	public float FPS { get; }
	public float FramesTotal { get; }

	// Methods

	// RVA: 0x1DB0E10 Offset: 0x1DB0F11 VA: 0x1DB0E10
	public string get_LastFilePath() { }

	// RVA: 0x1DB0E20 Offset: 0x1DB0F21 VA: 0x1DB0E20
	public uint get_NumDroppedFrames() { }

	// RVA: 0x1DB0E30 Offset: 0x1DB0F31 VA: 0x1DB0E30
	public uint get_NumDroppedEncoderFrames() { }

	// RVA: 0x1DB0E40 Offset: 0x1DB0F41 VA: 0x1DB0E40
	public uint get_NumEncodedFrames() { }

	// RVA: 0x1DB0E50 Offset: 0x1DB0F51 VA: 0x1DB0E50
	public uint get_TotalEncodedSeconds() { }

	// RVA: 0x1DB0E60 Offset: 0x1DB0F61 VA: 0x1DB0E60
	public string[] get_VideoCodecPriority() { }

	// RVA: 0x1DB0E70 Offset: 0x1DB0F71 VA: 0x1DB0E70
	public void set_VideoCodecPriority(string[] value) { }

	// RVA: 0x1DB12B0 Offset: 0x1DB13B1 VA: 0x1DB12B0
	public int get_TimelapseScale() { }

	// RVA: 0x1DB12C0 Offset: 0x1DB13C1 VA: 0x1DB12C0
	public void set_TimelapseScale(int value) { }

	// RVA: 0x1DB12D0 Offset: 0x1DB13D1 VA: 0x1DB12D0
	public bool get_UseWaitForEndOfFrame() { }

	// RVA: 0x1DB12E0 Offset: 0x1DB13E1 VA: 0x1DB12E0
	public void set_UseWaitForEndOfFrame(bool value) { }

	// RVA: 0x1DB12F0 Offset: 0x1DB13F1 VA: 0x1DB12F0
	public CaptureBase.PostCaptureSettings get_PostCapture() { }

	// RVA: 0x1DB1300 Offset: 0x1DB1401 VA: 0x1DB1300 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0x1DB1C30 Offset: 0x1DB1D31 VA: 0x1DB1C30
	protected void SetupRenderFunctions() { }

	// RVA: 0x1DB2310 Offset: 0x1DB2411 VA: 0x1DB2310 Slot: 5
	public virtual void Start() { }

	// RVA: 0x1DB0EA0 Offset: 0x1DB0FA1 VA: 0x1DB0EA0
	public void SelectCodec(bool listCodecs) { }

	// RVA: 0x1DB1C70 Offset: 0x1DB1D71 VA: 0x1DB1C70
	public void SelectAudioCodec(bool listCodecs) { }

	// RVA: 0x1DB2080 Offset: 0x1DB2181 VA: 0x1DB2080
	public void SelectAudioDevice(bool display) { }

	// RVA: 0x1DB2580 Offset: 0x1DB2681 VA: 0x1DB2580
	public static Vector2 GetRecordingResolution(int width, int height, CaptureBase.DownScale downscale, Vector2 maxVideoSize) { }

	// RVA: 0x1DB26B0 Offset: 0x1DB27B1 VA: 0x1DB26B0
	public void SelectRecordingResolution(int width, int height) { }

	// RVA: 0x1DB27D0 Offset: 0x1DB28D1 VA: 0x1DB27D0 Slot: 6
	public virtual void OnDestroy() { }

	// RVA: 0x1DB2810 Offset: 0x1DB2911 VA: 0x1DB2810
	private void OnApplicationQuit() { }

	// RVA: 0x1DB28C0 Offset: 0x1DB29C1 VA: 0x1DB28C0
	protected void EncodeTexture(Texture2D texture) { }

	// RVA: 0x1DB2940 Offset: 0x1DB2A41 VA: 0x1DB2940
	protected bool IsUsingUnityAudio() { }

	// RVA: 0x1DB29E0 Offset: 0x1DB2AE1 VA: 0x1DB29E0
	protected bool IsRecordingUnityAudio() { }

	// RVA: 0x1DB2A90 Offset: 0x1DB2B91 VA: 0x1DB2A90
	protected bool IsUsingMotionBlur() { }

	// RVA: 0x1DB2B20 Offset: 0x1DB2C21 VA: 0x1DB2B20 Slot: 7
	public virtual void EncodePointer(IntPtr ptr) { }

	// RVA: 0x1DB2BB0 Offset: 0x1DB2CB1 VA: 0x1DB2BB0
	public bool IsCapturing() { }

	// RVA: 0x1DB2BC0 Offset: 0x1DB2CC1 VA: 0x1DB2BC0
	public bool IsPaused() { }

	// RVA: 0x1DB2BD0 Offset: 0x1DB2CD1 VA: 0x1DB2BD0
	public int GetRecordingWidth() { }

	// RVA: 0x1DB2BE0 Offset: 0x1DB2CE1 VA: 0x1DB2BE0
	public int GetRecordingHeight() { }

	// RVA: 0x1DB2BF0 Offset: 0x1DB2CF1 VA: 0x1DB2BF0 Slot: 8
	protected virtual string GenerateTimestampedFilename(string filenamePrefix, string filenameExtension) { }

	// RVA: 0x1DB2F90 Offset: 0x1DB3091 VA: 0x1DB2F90
	private static string GetFolder(CaptureBase.OutputPath outputPathType, string path) { }

	// RVA: 0x1DB30A0 Offset: 0x1DB31A1 VA: 0x1DB30A0
	private static string AutoGenerateFilename(CaptureBase.OutputPath outputPathType, string path, string filename) { }

	// RVA: 0x1DB3150 Offset: 0x1DB3251 VA: 0x1DB3150
	private static string ManualGenerateFilename(CaptureBase.OutputPath outputPathType, string path, string filename) { }

	// RVA: 0x1DB3250 Offset: 0x1DB3351 VA: 0x1DB3250
	protected static bool HasExtension(string path, string extension) { }

	// RVA: 0x1DB3290 Offset: 0x1DB3391 VA: 0x1DB3290
	protected void GenerateFilename() { }

	// RVA: 0x1DB37D0 Offset: 0x1DB38D1 VA: 0x1DB37D0 Slot: 9
	public virtual bool PrepareCapture() { }

	// RVA: 0x1DB46C0 Offset: 0x1DB47C1 VA: 0x1DB46C0
	public void QueueStartCapture() { }

	// RVA: 0x1DB23A0 Offset: 0x1DB24A1 VA: 0x1DB23A0
	public bool StartCapture() { }

	// RVA: 0x1DB4710 Offset: 0x1DB4811 VA: 0x1DB4710
	public void PauseCapture() { }

	// RVA: 0x1DB4800 Offset: 0x1DB4901 VA: 0x1DB4800
	public void ResumeCapture() { }

	// RVA: 0x1DB4910 Offset: 0x1DB4A11 VA: 0x1DB4910
	public void CancelCapture() { }

	// RVA: 0x1DB4970 Offset: 0x1DB4A71 VA: 0x1DB4970 Slot: 10
	public virtual void UnprepareCapture() { }

	// RVA: 0x1DB4A10 Offset: 0x1DB4B11 VA: 0x1DB4A10
	public static string get_LastFileSaved() { }

	// RVA: 0x1DB4A70 Offset: 0x1DB4B71 VA: 0x1DB4A70
	public static void set_LastFileSaved(string value) { }

	// RVA: 0x1DB4AD0 Offset: 0x1DB4BD1 VA: 0x1DB4AD0
	protected void RenderThreadEvent(NativePlugin.PluginEvent renderEvent) { }

	// RVA: 0x1DB4B90 Offset: 0x1DB4C91 VA: 0x1DB4B90 Slot: 11
	public virtual void StopCapture(bool skipPendingFrames = False) { }

	// RVA: 0x1DB4FA0 Offset: 0x1DB50A1 VA: 0x1DB4FA0
	protected void ApplyPostOperations(string path) { }

	// RVA: 0x1DB5180 Offset: 0x1DB5281 VA: 0x1DB5180
	private void ToggleCapture() { }

	// RVA: 0x1DB51A0 Offset: 0x1DB52A1 VA: 0x1DB51A0
	private bool IsEnoughDiskSpace() { }

	// RVA: 0x1DB51B0 Offset: 0x1DB52B1 VA: 0x1DB51B0
	private void LateUpdate() { }

	// RVA: 0x1DB5210 Offset: 0x1DB5311 VA: 0x1DB5210
	private void CheckFreeDiskSpace() { }

	// RVA: 0x1DB5250 Offset: 0x1DB5351 VA: 0x1DB5250
	protected bool IsProgressComplete() { }

	// RVA: 0x1DB5330 Offset: 0x1DB5431 VA: 0x1DB5330
	public float GetProgress() { }

	// RVA: 0x1DB46E0 Offset: 0x1DB47E1 VA: 0x1DB46E0
	protected float GetSecondsPerCaptureFrame() { }

	// RVA: 0x1DB53F0 Offset: 0x1DB54F1 VA: 0x1DB53F0
	protected bool CanOutputFrame() { }

	// RVA: 0x1DB54D0 Offset: 0x1DB55D1 VA: 0x1DB54D0
	protected void TickFrameTimer() { }

	// RVA: 0x1DB5510 Offset: 0x1DB5611 VA: 0x1DB5510
	protected void RenormTimer() { }

	// RVA: 0x1DB5550 Offset: 0x1DB5651 VA: 0x1DB5550 Slot: 12
	public virtual Texture GetPreviewTexture() { }

	// RVA: 0x1DB5560 Offset: 0x1DB5661 VA: 0x1DB5560 Slot: 13
	public virtual void UpdateFrame() { }

	// RVA: 0x1DB56D0 Offset: 0x1DB57D1 VA: 0x1DB56D0
	public float get_FPS() { }

	// RVA: 0x1DB56E0 Offset: 0x1DB57E1 VA: 0x1DB56E0
	public float get_FramesTotal() { }

	// RVA: 0x1DB46D0 Offset: 0x1DB47D1 VA: 0x1DB46D0
	protected void ResetFPS() { }

	// RVA: 0x1DB56F0 Offset: 0x1DB57F1 VA: 0x1DB56F0
	public void UpdateFPS() { }

	// RVA: 0x1DB5760 Offset: 0x1DB5861 VA: 0x1DB5760
	protected int GetCameraAntiAliasingLevel(Camera camera) { }

	// RVA: 0x1DB5900 Offset: 0x1DB5A01 VA: 0x1DB5900
	private void ConfigureCodec() { }

	// RVA: 0x1DB5950 Offset: 0x1DB5A51 VA: 0x1DB5950
	public long GetCaptureFileSize() { }

	// RVA: 0x1DB5A30 Offset: 0x1DB5B31 VA: 0x1DB5A30
	public static void GetResolution(CaptureBase.Resolution res, ref int width, ref int height) { }

	// RVA: 0x1DB26A0 Offset: 0x1DB27A1 VA: 0x1DB26A0
	protected static int NextMultipleOf4(int value) { }

	// RVA: 0x1DB5A60 Offset: 0x1DB5B61 VA: 0x1DB5A60
	public void .ctor() { }

	// RVA: 0x1DB5DA0 Offset: 0x1DB5EA1 VA: 0x1DB5DA0
	private static void .cctor() { }
}

public class CaptureBase : MonoBehaviour // TypeDefIndex: 9603
{
	// Fields
	[SerializeField] // RVA: 0x17D3B0 Offset: 0x17D4B1 VA: 0x17D3B0
	private CaptureBase.PostCaptureSettings _postCaptureSettings; // 0x18
	public KeyCode _captureKey; // 0x20
	public bool _captureOnStart; // 0x24
	public bool _startPaused; // 0x25
	public bool _listVideoCodecsOnStart; // 0x26
	public bool _isRealTime; // 0x27
	[SerializeField] // RVA: 0x17D3C0 Offset: 0x17D4C1 VA: 0x17D3C0
	private bool _persistAcrossSceneLoads; // 0x28
	public StopMode _stopMode; // 0x2C
	public int _stopFrames; // 0x30
	public float _stopSeconds; // 0x34
	public bool _useMediaFoundationH264; // 0x38
	[SerializeField] // RVA: 0x17D3D0 Offset: 0x17D4D1 VA: 0x17D3D0
	private string[] _videoCodecPriority; // 0x40
	public CaptureBase.FrameRate _frameRate; // 0x48
	[SerializeField] // RVA: 0x17D3E0 Offset: 0x17D4E1 VA: 0x17D3E0
	[TooltipAttribute] // RVA: 0x17D3E0 Offset: 0x17D4E1 VA: 0x17D3E0
	private int _timelapseScale; // 0x4C
	public CaptureBase.DownScale _downScale; // 0x50
	public Vector2 _maxVideoSize; // 0x54
	public int _forceVideoCodecIndex; // 0x5C
	public bool _flipVertically; // 0x60
	public bool _supportAlpha; // 0x61
	[TooltipAttribute] // RVA: 0x17D430 Offset: 0x17D531 VA: 0x17D430
	[SerializeField] // RVA: 0x17D430 Offset: 0x17D531 VA: 0x17D430
	private bool _forceGpuFlush; // 0x62
	[TooltipAttribute] // RVA: 0x17D480 Offset: 0x17D581 VA: 0x17D480
	[SerializeField] // RVA: 0x17D480 Offset: 0x17D581 VA: 0x17D480
	protected bool _useWaitForEndOfFrame; // 0x63
	public bool _noAudio; // 0x64
	public string[] _audioCodecPriority; // 0x68
	public int _forceAudioCodecIndex; // 0x70
	public int _forceAudioDeviceIndex; // 0x74
	public UnityAudioCapture _audioCapture; // 0x78
	public bool _autoGenerateFilename; // 0x80
	public CaptureBase.OutputPath _outputFolderType; // 0x84
	public string _outputFolderPath; // 0x88
	public string _autoFilenamePrefix; // 0x90
	public string _autoFilenameExtension; // 0x98
	public string _forceFilename; // 0xA0
	public int _imageSequenceStartFrame; // 0xA8
	[RangeAttribute] // RVA: 0x17D4D0 Offset: 0x17D5D1 VA: 0x17D4D0
	public int _imageSequenceZeroDigits; // 0xAC
	public CaptureBase.OutputType _outputType; // 0xB0
	public ImageSequenceFormat _imageSequenceFormat; // 0xB4
	public CaptureBase.Resolution _renderResolution; // 0xB8
	public Vector2 _renderSize; // 0xBC
	public int _renderAntiAliasing; // 0xC4
	public bool _useMotionBlur; // 0xC8
	[RangeAttribute] // RVA: 0x17D4F0 Offset: 0x17D5F1 VA: 0x17D4F0
	public int _motionBlurSamples; // 0xCC
	public Camera[] _motionBlurCameras; // 0xD0
	protected MotionBlur _motionBlur; // 0xD8
	public bool _allowVSyncDisable; // 0xE0
	[SerializeField] // RVA: 0x17D510 Offset: 0x17D611 VA: 0x17D510
	protected bool _supportTextureRecreate; // 0xE1
	public bool _captureMouseCursor; // 0xE2
	public MouseCursor _mouseCursor; // 0xE8
	public string _codecName; // 0xF0
	public int _codecIndex; // 0xF8
	public string _audioCodecName; // 0x100
	public int _audioCodecIndex; // 0x108
	public string _audioDeviceName; // 0x110
	public int _audioDeviceIndex; // 0x118
	public int _unityAudioSampleRate; // 0x11C
	public int _unityAudioChannelCount; // 0x120
	protected Texture2D _texture; // 0x128
	protected int _handle; // 0x130
	protected int _targetWidth; // 0x134
	protected int _targetHeight; // 0x138
	protected bool _capturing; // 0x13C
	protected bool _paused; // 0x13D
	protected string _filePath; // 0x140
	protected FileInfo _fileInfo; // 0x148
	protected NativePlugin.PixelFormat _pixelFormat; // 0x150
	private int _oldVSyncCount; // 0x154
	private float _oldFixedDeltaTime; // 0x158
	protected bool _isTopDown; // 0x15C
	protected bool _isDirectX11; // 0x15D
	private bool _queuedStartCapture; // 0x15E
	private bool _queuedStopCapture; // 0x15F
	private float _captureStartTime; // 0x160
	private float _timeSinceLastFrame; // 0x164
	protected YieldInstruction _waitForEndOfFrame; // 0x168
	public int _minimumDiskSpaceMB; // 0x170
	private long _freeDiskSpaceMB; // 0x178
	private uint _numDroppedFrames; // 0x180
	private uint _numDroppedEncoderFrames; // 0x184
	private uint _numEncodedFrames; // 0x188
	private uint _totalEncodedSeconds; // 0x18C
	private static bool _isInitialised; // 0x0
	protected IntPtr _renderEventFunction; // 0x190
	protected IntPtr _freeEventFunction; // 0x198
	private float _fps; // 0x1A0
	private int _frameTotal; // 0x1A4
	private int _frameCount; // 0x1A8
	private float _startFrameTime; // 0x1AC

	// Properties
	public string LastFilePath { get; }
	public uint NumDroppedFrames { get; }
	public uint NumDroppedEncoderFrames { get; }
	public uint NumEncodedFrames { get; }
	public uint TotalEncodedSeconds { get; }
	public string[] VideoCodecPriority { get; set; }
	public int TimelapseScale { get; set; }
	public bool UseWaitForEndOfFrame { get; set; }
	public CaptureBase.PostCaptureSettings PostCapture { get; }
	public static string LastFileSaved { get; set; }
	public float FPS { get; }
	public float FramesTotal { get; }

	// Methods

	// RVA: 0x1DB0E10 Offset: 0x1DB0F11 VA: 0x1DB0E10
	public string get_LastFilePath() { }

	// RVA: 0x1DB0E20 Offset: 0x1DB0F21 VA: 0x1DB0E20
	public uint get_NumDroppedFrames() { }

	// RVA: 0x1DB0E30 Offset: 0x1DB0F31 VA: 0x1DB0E30
	public uint get_NumDroppedEncoderFrames() { }

	// RVA: 0x1DB0E40 Offset: 0x1DB0F41 VA: 0x1DB0E40
	public uint get_NumEncodedFrames() { }

	// RVA: 0x1DB0E50 Offset: 0x1DB0F51 VA: 0x1DB0E50
	public uint get_TotalEncodedSeconds() { }

	// RVA: 0x1DB0E60 Offset: 0x1DB0F61 VA: 0x1DB0E60
	public string[] get_VideoCodecPriority() { }

	// RVA: 0x1DB0E70 Offset: 0x1DB0F71 VA: 0x1DB0E70
	public void set_VideoCodecPriority(string[] value) { }

	// RVA: 0x1DB12B0 Offset: 0x1DB13B1 VA: 0x1DB12B0
	public int get_TimelapseScale() { }

	// RVA: 0x1DB12C0 Offset: 0x1DB13C1 VA: 0x1DB12C0
	public void set_TimelapseScale(int value) { }

	// RVA: 0x1DB12D0 Offset: 0x1DB13D1 VA: 0x1DB12D0
	public bool get_UseWaitForEndOfFrame() { }

	// RVA: 0x1DB12E0 Offset: 0x1DB13E1 VA: 0x1DB12E0
	public void set_UseWaitForEndOfFrame(bool value) { }

	// RVA: 0x1DB12F0 Offset: 0x1DB13F1 VA: 0x1DB12F0
	public CaptureBase.PostCaptureSettings get_PostCapture() { }

	// RVA: 0x1DB1300 Offset: 0x1DB1401 VA: 0x1DB1300 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0x1DB1C30 Offset: 0x1DB1D31 VA: 0x1DB1C30
	protected void SetupRenderFunctions() { }

	// RVA: 0x1DB2310 Offset: 0x1DB2411 VA: 0x1DB2310 Slot: 5
	public virtual void Start() { }

	// RVA: 0x1DB0EA0 Offset: 0x1DB0FA1 VA: 0x1DB0EA0
	public void SelectCodec(bool listCodecs) { }

	// RVA: 0x1DB1C70 Offset: 0x1DB1D71 VA: 0x1DB1C70
	public void SelectAudioCodec(bool listCodecs) { }

	// RVA: 0x1DB2080 Offset: 0x1DB2181 VA: 0x1DB2080
	public void SelectAudioDevice(bool display) { }

	// RVA: 0x1DB2580 Offset: 0x1DB2681 VA: 0x1DB2580
	public static Vector2 GetRecordingResolution(int width, int height, CaptureBase.DownScale downscale, Vector2 maxVideoSize) { }

	// RVA: 0x1DB26B0 Offset: 0x1DB27B1 VA: 0x1DB26B0
	public void SelectRecordingResolution(int width, int height) { }

	// RVA: 0x1DB27D0 Offset: 0x1DB28D1 VA: 0x1DB27D0 Slot: 6
	public virtual void OnDestroy() { }

	// RVA: 0x1DB2810 Offset: 0x1DB2911 VA: 0x1DB2810
	private void OnApplicationQuit() { }

	// RVA: 0x1DB28C0 Offset: 0x1DB29C1 VA: 0x1DB28C0
	protected void EncodeTexture(Texture2D texture) { }

	// RVA: 0x1DB2940 Offset: 0x1DB2A41 VA: 0x1DB2940
	protected bool IsUsingUnityAudio() { }

	// RVA: 0x1DB29E0 Offset: 0x1DB2AE1 VA: 0x1DB29E0
	protected bool IsRecordingUnityAudio() { }

	// RVA: 0x1DB2A90 Offset: 0x1DB2B91 VA: 0x1DB2A90
	protected bool IsUsingMotionBlur() { }

	// RVA: 0x1DB2B20 Offset: 0x1DB2C21 VA: 0x1DB2B20 Slot: 7
	public virtual void EncodePointer(IntPtr ptr) { }

	// RVA: 0x1DB2BB0 Offset: 0x1DB2CB1 VA: 0x1DB2BB0
	public bool IsCapturing() { }

	// RVA: 0x1DB2BC0 Offset: 0x1DB2CC1 VA: 0x1DB2BC0
	public bool IsPaused() { }

	// RVA: 0x1DB2BD0 Offset: 0x1DB2CD1 VA: 0x1DB2BD0
	public int GetRecordingWidth() { }

	// RVA: 0x1DB2BE0 Offset: 0x1DB2CE1 VA: 0x1DB2BE0
	public int GetRecordingHeight() { }

	// RVA: 0x1DB2BF0 Offset: 0x1DB2CF1 VA: 0x1DB2BF0 Slot: 8
	protected virtual string GenerateTimestampedFilename(string filenamePrefix, string filenameExtension) { }

	// RVA: 0x1DB2F90 Offset: 0x1DB3091 VA: 0x1DB2F90
	private static string GetFolder(CaptureBase.OutputPath outputPathType, string path) { }

	// RVA: 0x1DB30A0 Offset: 0x1DB31A1 VA: 0x1DB30A0
	private static string AutoGenerateFilename(CaptureBase.OutputPath outputPathType, string path, string filename) { }

	// RVA: 0x1DB3150 Offset: 0x1DB3251 VA: 0x1DB3150
	private static string ManualGenerateFilename(CaptureBase.OutputPath outputPathType, string path, string filename) { }

	// RVA: 0x1DB3250 Offset: 0x1DB3351 VA: 0x1DB3250
	protected static bool HasExtension(string path, string extension) { }

	// RVA: 0x1DB3290 Offset: 0x1DB3391 VA: 0x1DB3290
	protected void GenerateFilename() { }

	// RVA: 0x1DB37D0 Offset: 0x1DB38D1 VA: 0x1DB37D0 Slot: 9
	public virtual bool PrepareCapture() { }

	// RVA: 0x1DB46C0 Offset: 0x1DB47C1 VA: 0x1DB46C0
	public void QueueStartCapture() { }

	// RVA: 0x1DB23A0 Offset: 0x1DB24A1 VA: 0x1DB23A0
	public bool StartCapture() { }

	// RVA: 0x1DB4710 Offset: 0x1DB4811 VA: 0x1DB4710
	public void PauseCapture() { }

	// RVA: 0x1DB4800 Offset: 0x1DB4901 VA: 0x1DB4800
	public void ResumeCapture() { }

	// RVA: 0x1DB4910 Offset: 0x1DB4A11 VA: 0x1DB4910
	public void CancelCapture() { }

	// RVA: 0x1DB4970 Offset: 0x1DB4A71 VA: 0x1DB4970 Slot: 10
	public virtual void UnprepareCapture() { }

	// RVA: 0x1DB4A10 Offset: 0x1DB4B11 VA: 0x1DB4A10
	public static string get_LastFileSaved() { }

	// RVA: 0x1DB4A70 Offset: 0x1DB4B71 VA: 0x1DB4A70
	public static void set_LastFileSaved(string value) { }

	// RVA: 0x1DB4AD0 Offset: 0x1DB4BD1 VA: 0x1DB4AD0
	protected void RenderThreadEvent(NativePlugin.PluginEvent renderEvent) { }

	// RVA: 0x1DB4B90 Offset: 0x1DB4C91 VA: 0x1DB4B90 Slot: 11
	public virtual void StopCapture(bool skipPendingFrames = False) { }

	// RVA: 0x1DB4FA0 Offset: 0x1DB50A1 VA: 0x1DB4FA0
	protected void ApplyPostOperations(string path) { }

	// RVA: 0x1DB5180 Offset: 0x1DB5281 VA: 0x1DB5180
	private void ToggleCapture() { }

	// RVA: 0x1DB51A0 Offset: 0x1DB52A1 VA: 0x1DB51A0
	private bool IsEnoughDiskSpace() { }

	// RVA: 0x1DB51B0 Offset: 0x1DB52B1 VA: 0x1DB51B0
	private void LateUpdate() { }

	// RVA: 0x1DB5210 Offset: 0x1DB5311 VA: 0x1DB5210
	private void CheckFreeDiskSpace() { }

	// RVA: 0x1DB5250 Offset: 0x1DB5351 VA: 0x1DB5250
	protected bool IsProgressComplete() { }

	// RVA: 0x1DB5330 Offset: 0x1DB5431 VA: 0x1DB5330
	public float GetProgress() { }

	// RVA: 0x1DB46E0 Offset: 0x1DB47E1 VA: 0x1DB46E0
	protected float GetSecondsPerCaptureFrame() { }

	// RVA: 0x1DB53F0 Offset: 0x1DB54F1 VA: 0x1DB53F0
	protected bool CanOutputFrame() { }

	// RVA: 0x1DB54D0 Offset: 0x1DB55D1 VA: 0x1DB54D0
	protected void TickFrameTimer() { }

	// RVA: 0x1DB5510 Offset: 0x1DB5611 VA: 0x1DB5510
	protected void RenormTimer() { }

	// RVA: 0x1DB5550 Offset: 0x1DB5651 VA: 0x1DB5550 Slot: 12
	public virtual Texture GetPreviewTexture() { }

	// RVA: 0x1DB5560 Offset: 0x1DB5661 VA: 0x1DB5560 Slot: 13
	public virtual void UpdateFrame() { }

	// RVA: 0x1DB56D0 Offset: 0x1DB57D1 VA: 0x1DB56D0
	public float get_FPS() { }

	// RVA: 0x1DB56E0 Offset: 0x1DB57E1 VA: 0x1DB56E0
	public float get_FramesTotal() { }

	// RVA: 0x1DB46D0 Offset: 0x1DB47D1 VA: 0x1DB46D0
	protected void ResetFPS() { }

	// RVA: 0x1DB56F0 Offset: 0x1DB57F1 VA: 0x1DB56F0
	public void UpdateFPS() { }

	// RVA: 0x1DB5760 Offset: 0x1DB5861 VA: 0x1DB5760
	protected int GetCameraAntiAliasingLevel(Camera camera) { }

	// RVA: 0x1DB5900 Offset: 0x1DB5A01 VA: 0x1DB5900
	private void ConfigureCodec() { }

	// RVA: 0x1DB5950 Offset: 0x1DB5A51 VA: 0x1DB5950
	public long GetCaptureFileSize() { }

	// RVA: 0x1DB5A30 Offset: 0x1DB5B31 VA: 0x1DB5A30
	public static void GetResolution(CaptureBase.Resolution res, ref int width, ref int height) { }

	// RVA: 0x1DB26A0 Offset: 0x1DB27A1 VA: 0x1DB26A0
	protected static int NextMultipleOf4(int value) { }

	// RVA: 0x1DB5A60 Offset: 0x1DB5B61 VA: 0x1DB5A60
	public void .ctor() { }

	// RVA: 0x1DB5DA0 Offset: 0x1DB5EA1 VA: 0x1DB5DA0
	private static void .cctor() { }
}

