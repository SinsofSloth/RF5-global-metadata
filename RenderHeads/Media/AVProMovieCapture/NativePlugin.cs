public class NativePlugin // TypeDefIndex: 9620
{
	// Fields
	public const int PluginID = 262340608;
	public const string ScriptVersion = "3.7.2";
	public const string ExpectedPluginVersion = "3.7.2";
	public const int MaxRenderWidth = 16384;
	public const int MaxRenderHeight = 16384;

	// Methods

	// RVA: 0x23277A0 Offset: 0x23278A1 VA: 0x23277A0
	public static extern IntPtr GetRenderEventFunc() { }

	// RVA: 0x2327810 Offset: 0x2327911 VA: 0x2327810
	public static extern IntPtr GetFreeResourcesEventFunc() { }

	// RVA: 0x2327880 Offset: 0x2327981 VA: 0x2327880
	public static extern bool Init() { }

	// RVA: 0x2327900 Offset: 0x2327A01 VA: 0x2327900
	public static extern void Deinit() { }

	// RVA: 0x2327970 Offset: 0x2327A71 VA: 0x2327970
	public static string GetPluginVersionString() { }

	// RVA: 0x2327AB0 Offset: 0x2327BB1 VA: 0x2327AB0
	public static extern bool IsTrialVersion() { }

	// RVA: 0x231F4E0 Offset: 0x231F5E1 VA: 0x231F4E0
	public static extern int GetNumAVIVideoCodecs() { }

	// RVA: 0x231F690 Offset: 0x231F791 VA: 0x231F690
	public static extern bool IsConfigureVideoCodecSupported(int index) { }

	// RVA: 0x2323D70 Offset: 0x2323E71 VA: 0x2323D70
	public static extern void ConfigureVideoCodec(int index) { }

	// RVA: 0x231F550 Offset: 0x231F651 VA: 0x231F550
	public static string GetAVIVideoCodecName(int index) { }

	// RVA: 0x231F8D0 Offset: 0x231F9D1 VA: 0x231F8D0
	public static extern int GetNumAVIAudioCodecs() { }

	// RVA: 0x231FA80 Offset: 0x231FB81 VA: 0x231FA80
	public static extern bool IsConfigureAudioCodecSupported(int index) { }

	// RVA: 0x2323DF0 Offset: 0x2323EF1 VA: 0x2323DF0
	public static extern void ConfigureAudioCodec(int index) { }

	// RVA: 0x231F940 Offset: 0x231FA41 VA: 0x231F940
	public static string GetAVIAudioCodecName(int index) { }

	// RVA: 0x231F720 Offset: 0x231F821 VA: 0x231F720
	public static extern int GetNumAVIAudioInputDevices() { }

	// RVA: 0x231F790 Offset: 0x231F891 VA: 0x231F790
	public static string GetAVIAudioInputDeviceName(int index) { }

	// RVA: 0x2327DA0 Offset: 0x2327EA1 VA: 0x2327DA0
	public static extern int CreateRecorderVideo(string filename, uint width, uint height, int frameRate, int format, bool isTopDown, int videoCodecIndex, bool hasAudio, int audioSampleRate, int audioChannelCount, int audioInputDeviceIndex, int audioCodecIndex, bool isRealTime, bool useMediaFoundation, bool supportAlpha, bool forceGpuFlush) { }

	// RVA: 0x2327EE0 Offset: 0x2327FE1 VA: 0x2327EE0
	public static extern int CreateRecorderImages(string filename, uint width, uint height, int frameRate, int format, bool isTopDown, bool isRealTime, int imageFormatType, bool supportAlpha, bool forceGpuFlush, int startFrame) { }

	// RVA: 0x2327FF0 Offset: 0x23280F1 VA: 0x2327FF0
	public static extern int CreateRecorderPipe(string filename, uint width, uint height, int frameRate, int format, bool isTopDown, bool supportAlpha, bool forceGpuFlush) { }

	// RVA: 0x23280D0 Offset: 0x23281D1 VA: 0x23280D0
	public static extern bool Start(int handle) { }

	// RVA: 0x2328160 Offset: 0x2328261 VA: 0x2328160
	public static extern bool IsNewFrameDue(int handle) { }

	// RVA: 0x23281F0 Offset: 0x23282F1 VA: 0x23281F0
	public static extern void EncodeFrame(int handle, IntPtr data) { }

	// RVA: 0x23181A0 Offset: 0x23182A1 VA: 0x23181A0
	public static extern void EncodeAudio(int handle, IntPtr data, uint length) { }

	// RVA: 0x2328280 Offset: 0x2328381 VA: 0x2328280
	public static extern void EncodeFrameWithAudio(int handle, IntPtr videoData, IntPtr audioData, uint audioLength) { }

	// RVA: 0x2328330 Offset: 0x2328431 VA: 0x2328330
	public static extern void Pause(int handle) { }

	// RVA: 0x23283B0 Offset: 0x23284B1 VA: 0x23283B0
	public static extern void Stop(int handle, bool skipPendingFrames) { }

	// RVA: 0x2318040 Offset: 0x2318141 VA: 0x2318040
	public static extern void SetTexturePointer(int handle, IntPtr texture) { }

	// RVA: 0x2328440 Offset: 0x2328541 VA: 0x2328440
	public static extern void FreeRecorder(int handle) { }

	// RVA: 0x23284C0 Offset: 0x23285C1 VA: 0x23284C0
	public static extern uint GetNumDroppedFrames(int handle) { }

	// RVA: 0x2328540 Offset: 0x2328641 VA: 0x2328540
	public static extern uint GetNumDroppedEncoderFrames(int handle) { }

	// RVA: 0x23285C0 Offset: 0x23286C1 VA: 0x23285C0
	public static extern uint GetNumEncodedFrames(int handle) { }

	// RVA: 0x2328640 Offset: 0x2328741 VA: 0x2328640
	public static extern uint GetEncodedSeconds(int handle) { }

	// RVA: 0x2327A40 Offset: 0x2327B41 VA: 0x2327A40
	private static extern IntPtr GetPluginVersion() { }

	// RVA: 0x2327B30 Offset: 0x2327C31 VA: 0x2327B30
	private static extern bool GetAVIVideoCodecName(int index, StringBuilder name, int nameBufferLength) { }

	// RVA: 0x2327C00 Offset: 0x2327D01 VA: 0x2327C00
	private static extern bool GetAVIAudioCodecName(int index, StringBuilder name, int nameBufferLength) { }

	// RVA: 0x2327CD0 Offset: 0x2327DD1 VA: 0x2327CD0
	private static extern bool GetAVIAudioInputDeviceName(int index, StringBuilder name, int nameBufferLength) { }

	// RVA: 0x23286C0 Offset: 0x23287C1 VA: 0x23286C0
	public void .ctor() { }
}

public class NativePlugin // TypeDefIndex: 9620
{
	// Fields
	public const int PluginID = 262340608;
	public const string ScriptVersion = "3.7.2";
	public const string ExpectedPluginVersion = "3.7.2";
	public const int MaxRenderWidth = 16384;
	public const int MaxRenderHeight = 16384;

	// Methods

	// RVA: 0x23277A0 Offset: 0x23278A1 VA: 0x23277A0
	public static extern IntPtr GetRenderEventFunc() { }

	// RVA: 0x2327810 Offset: 0x2327911 VA: 0x2327810
	public static extern IntPtr GetFreeResourcesEventFunc() { }

	// RVA: 0x2327880 Offset: 0x2327981 VA: 0x2327880
	public static extern bool Init() { }

	// RVA: 0x2327900 Offset: 0x2327A01 VA: 0x2327900
	public static extern void Deinit() { }

	// RVA: 0x2327970 Offset: 0x2327A71 VA: 0x2327970
	public static string GetPluginVersionString() { }

	// RVA: 0x2327AB0 Offset: 0x2327BB1 VA: 0x2327AB0
	public static extern bool IsTrialVersion() { }

	// RVA: 0x231F4E0 Offset: 0x231F5E1 VA: 0x231F4E0
	public static extern int GetNumAVIVideoCodecs() { }

	// RVA: 0x231F690 Offset: 0x231F791 VA: 0x231F690
	public static extern bool IsConfigureVideoCodecSupported(int index) { }

	// RVA: 0x2323D70 Offset: 0x2323E71 VA: 0x2323D70
	public static extern void ConfigureVideoCodec(int index) { }

	// RVA: 0x231F550 Offset: 0x231F651 VA: 0x231F550
	public static string GetAVIVideoCodecName(int index) { }

	// RVA: 0x231F8D0 Offset: 0x231F9D1 VA: 0x231F8D0
	public static extern int GetNumAVIAudioCodecs() { }

	// RVA: 0x231FA80 Offset: 0x231FB81 VA: 0x231FA80
	public static extern bool IsConfigureAudioCodecSupported(int index) { }

	// RVA: 0x2323DF0 Offset: 0x2323EF1 VA: 0x2323DF0
	public static extern void ConfigureAudioCodec(int index) { }

	// RVA: 0x231F940 Offset: 0x231FA41 VA: 0x231F940
	public static string GetAVIAudioCodecName(int index) { }

	// RVA: 0x231F720 Offset: 0x231F821 VA: 0x231F720
	public static extern int GetNumAVIAudioInputDevices() { }

	// RVA: 0x231F790 Offset: 0x231F891 VA: 0x231F790
	public static string GetAVIAudioInputDeviceName(int index) { }

	// RVA: 0x2327DA0 Offset: 0x2327EA1 VA: 0x2327DA0
	public static extern int CreateRecorderVideo(string filename, uint width, uint height, int frameRate, int format, bool isTopDown, int videoCodecIndex, bool hasAudio, int audioSampleRate, int audioChannelCount, int audioInputDeviceIndex, int audioCodecIndex, bool isRealTime, bool useMediaFoundation, bool supportAlpha, bool forceGpuFlush) { }

	// RVA: 0x2327EE0 Offset: 0x2327FE1 VA: 0x2327EE0
	public static extern int CreateRecorderImages(string filename, uint width, uint height, int frameRate, int format, bool isTopDown, bool isRealTime, int imageFormatType, bool supportAlpha, bool forceGpuFlush, int startFrame) { }

	// RVA: 0x2327FF0 Offset: 0x23280F1 VA: 0x2327FF0
	public static extern int CreateRecorderPipe(string filename, uint width, uint height, int frameRate, int format, bool isTopDown, bool supportAlpha, bool forceGpuFlush) { }

	// RVA: 0x23280D0 Offset: 0x23281D1 VA: 0x23280D0
	public static extern bool Start(int handle) { }

	// RVA: 0x2328160 Offset: 0x2328261 VA: 0x2328160
	public static extern bool IsNewFrameDue(int handle) { }

	// RVA: 0x23281F0 Offset: 0x23282F1 VA: 0x23281F0
	public static extern void EncodeFrame(int handle, IntPtr data) { }

	// RVA: 0x23181A0 Offset: 0x23182A1 VA: 0x23181A0
	public static extern void EncodeAudio(int handle, IntPtr data, uint length) { }

	// RVA: 0x2328280 Offset: 0x2328381 VA: 0x2328280
	public static extern void EncodeFrameWithAudio(int handle, IntPtr videoData, IntPtr audioData, uint audioLength) { }

	// RVA: 0x2328330 Offset: 0x2328431 VA: 0x2328330
	public static extern void Pause(int handle) { }

	// RVA: 0x23283B0 Offset: 0x23284B1 VA: 0x23283B0
	public static extern void Stop(int handle, bool skipPendingFrames) { }

	// RVA: 0x2318040 Offset: 0x2318141 VA: 0x2318040
	public static extern void SetTexturePointer(int handle, IntPtr texture) { }

	// RVA: 0x2328440 Offset: 0x2328541 VA: 0x2328440
	public static extern void FreeRecorder(int handle) { }

	// RVA: 0x23284C0 Offset: 0x23285C1 VA: 0x23284C0
	public static extern uint GetNumDroppedFrames(int handle) { }

	// RVA: 0x2328540 Offset: 0x2328641 VA: 0x2328540
	public static extern uint GetNumDroppedEncoderFrames(int handle) { }

	// RVA: 0x23285C0 Offset: 0x23286C1 VA: 0x23285C0
	public static extern uint GetNumEncodedFrames(int handle) { }

	// RVA: 0x2328640 Offset: 0x2328741 VA: 0x2328640
	public static extern uint GetEncodedSeconds(int handle) { }

	// RVA: 0x2327A40 Offset: 0x2327B41 VA: 0x2327A40
	private static extern IntPtr GetPluginVersion() { }

	// RVA: 0x2327B30 Offset: 0x2327C31 VA: 0x2327B30
	private static extern bool GetAVIVideoCodecName(int index, StringBuilder name, int nameBufferLength) { }

	// RVA: 0x2327C00 Offset: 0x2327D01 VA: 0x2327C00
	private static extern bool GetAVIAudioCodecName(int index, StringBuilder name, int nameBufferLength) { }

	// RVA: 0x2327CD0 Offset: 0x2327DD1 VA: 0x2327CD0
	private static extern bool GetAVIAudioInputDeviceName(int index, StringBuilder name, int nameBufferLength) { }

	// RVA: 0x23286C0 Offset: 0x23287C1 VA: 0x23286C0
	public void .ctor() { }
}

public class NativePlugin // TypeDefIndex: 9620
{
	// Fields
	public const int PluginID = 262340608;
	public const string ScriptVersion = "3.7.2";
	public const string ExpectedPluginVersion = "3.7.2";
	public const int MaxRenderWidth = 16384;
	public const int MaxRenderHeight = 16384;

	// Methods

	// RVA: 0x23277A0 Offset: 0x23278A1 VA: 0x23277A0
	public static extern IntPtr GetRenderEventFunc() { }

	// RVA: 0x2327810 Offset: 0x2327911 VA: 0x2327810
	public static extern IntPtr GetFreeResourcesEventFunc() { }

	// RVA: 0x2327880 Offset: 0x2327981 VA: 0x2327880
	public static extern bool Init() { }

	// RVA: 0x2327900 Offset: 0x2327A01 VA: 0x2327900
	public static extern void Deinit() { }

	// RVA: 0x2327970 Offset: 0x2327A71 VA: 0x2327970
	public static string GetPluginVersionString() { }

	// RVA: 0x2327AB0 Offset: 0x2327BB1 VA: 0x2327AB0
	public static extern bool IsTrialVersion() { }

	// RVA: 0x231F4E0 Offset: 0x231F5E1 VA: 0x231F4E0
	public static extern int GetNumAVIVideoCodecs() { }

	// RVA: 0x231F690 Offset: 0x231F791 VA: 0x231F690
	public static extern bool IsConfigureVideoCodecSupported(int index) { }

	// RVA: 0x2323D70 Offset: 0x2323E71 VA: 0x2323D70
	public static extern void ConfigureVideoCodec(int index) { }

	// RVA: 0x231F550 Offset: 0x231F651 VA: 0x231F550
	public static string GetAVIVideoCodecName(int index) { }

	// RVA: 0x231F8D0 Offset: 0x231F9D1 VA: 0x231F8D0
	public static extern int GetNumAVIAudioCodecs() { }

	// RVA: 0x231FA80 Offset: 0x231FB81 VA: 0x231FA80
	public static extern bool IsConfigureAudioCodecSupported(int index) { }

	// RVA: 0x2323DF0 Offset: 0x2323EF1 VA: 0x2323DF0
	public static extern void ConfigureAudioCodec(int index) { }

	// RVA: 0x231F940 Offset: 0x231FA41 VA: 0x231F940
	public static string GetAVIAudioCodecName(int index) { }

	// RVA: 0x231F720 Offset: 0x231F821 VA: 0x231F720
	public static extern int GetNumAVIAudioInputDevices() { }

	// RVA: 0x231F790 Offset: 0x231F891 VA: 0x231F790
	public static string GetAVIAudioInputDeviceName(int index) { }

	// RVA: 0x2327DA0 Offset: 0x2327EA1 VA: 0x2327DA0
	public static extern int CreateRecorderVideo(string filename, uint width, uint height, int frameRate, int format, bool isTopDown, int videoCodecIndex, bool hasAudio, int audioSampleRate, int audioChannelCount, int audioInputDeviceIndex, int audioCodecIndex, bool isRealTime, bool useMediaFoundation, bool supportAlpha, bool forceGpuFlush) { }

	// RVA: 0x2327EE0 Offset: 0x2327FE1 VA: 0x2327EE0
	public static extern int CreateRecorderImages(string filename, uint width, uint height, int frameRate, int format, bool isTopDown, bool isRealTime, int imageFormatType, bool supportAlpha, bool forceGpuFlush, int startFrame) { }

	// RVA: 0x2327FF0 Offset: 0x23280F1 VA: 0x2327FF0
	public static extern int CreateRecorderPipe(string filename, uint width, uint height, int frameRate, int format, bool isTopDown, bool supportAlpha, bool forceGpuFlush) { }

	// RVA: 0x23280D0 Offset: 0x23281D1 VA: 0x23280D0
	public static extern bool Start(int handle) { }

	// RVA: 0x2328160 Offset: 0x2328261 VA: 0x2328160
	public static extern bool IsNewFrameDue(int handle) { }

	// RVA: 0x23281F0 Offset: 0x23282F1 VA: 0x23281F0
	public static extern void EncodeFrame(int handle, IntPtr data) { }

	// RVA: 0x23181A0 Offset: 0x23182A1 VA: 0x23181A0
	public static extern void EncodeAudio(int handle, IntPtr data, uint length) { }

	// RVA: 0x2328280 Offset: 0x2328381 VA: 0x2328280
	public static extern void EncodeFrameWithAudio(int handle, IntPtr videoData, IntPtr audioData, uint audioLength) { }

	// RVA: 0x2328330 Offset: 0x2328431 VA: 0x2328330
	public static extern void Pause(int handle) { }

	// RVA: 0x23283B0 Offset: 0x23284B1 VA: 0x23283B0
	public static extern void Stop(int handle, bool skipPendingFrames) { }

	// RVA: 0x2318040 Offset: 0x2318141 VA: 0x2318040
	public static extern void SetTexturePointer(int handle, IntPtr texture) { }

	// RVA: 0x2328440 Offset: 0x2328541 VA: 0x2328440
	public static extern void FreeRecorder(int handle) { }

	// RVA: 0x23284C0 Offset: 0x23285C1 VA: 0x23284C0
	public static extern uint GetNumDroppedFrames(int handle) { }

	// RVA: 0x2328540 Offset: 0x2328641 VA: 0x2328540
	public static extern uint GetNumDroppedEncoderFrames(int handle) { }

	// RVA: 0x23285C0 Offset: 0x23286C1 VA: 0x23285C0
	public static extern uint GetNumEncodedFrames(int handle) { }

	// RVA: 0x2328640 Offset: 0x2328741 VA: 0x2328640
	public static extern uint GetEncodedSeconds(int handle) { }

	// RVA: 0x2327A40 Offset: 0x2327B41 VA: 0x2327A40
	private static extern IntPtr GetPluginVersion() { }

	// RVA: 0x2327B30 Offset: 0x2327C31 VA: 0x2327B30
	private static extern bool GetAVIVideoCodecName(int index, StringBuilder name, int nameBufferLength) { }

	// RVA: 0x2327C00 Offset: 0x2327D01 VA: 0x2327C00
	private static extern bool GetAVIAudioCodecName(int index, StringBuilder name, int nameBufferLength) { }

	// RVA: 0x2327CD0 Offset: 0x2327DD1 VA: 0x2327CD0
	private static extern bool GetAVIAudioInputDeviceName(int index, StringBuilder name, int nameBufferLength) { }

	// RVA: 0x23286C0 Offset: 0x23287C1 VA: 0x23286C0
	public void .ctor() { }
}

public class NativePlugin // TypeDefIndex: 9620
{
	// Fields
	public const int PluginID = 262340608;
	public const string ScriptVersion = "3.7.2";
	public const string ExpectedPluginVersion = "3.7.2";
	public const int MaxRenderWidth = 16384;
	public const int MaxRenderHeight = 16384;

	// Methods

	// RVA: 0x23277A0 Offset: 0x23278A1 VA: 0x23277A0
	public static extern IntPtr GetRenderEventFunc() { }

	// RVA: 0x2327810 Offset: 0x2327911 VA: 0x2327810
	public static extern IntPtr GetFreeResourcesEventFunc() { }

	// RVA: 0x2327880 Offset: 0x2327981 VA: 0x2327880
	public static extern bool Init() { }

	// RVA: 0x2327900 Offset: 0x2327A01 VA: 0x2327900
	public static extern void Deinit() { }

	// RVA: 0x2327970 Offset: 0x2327A71 VA: 0x2327970
	public static string GetPluginVersionString() { }

	// RVA: 0x2327AB0 Offset: 0x2327BB1 VA: 0x2327AB0
	public static extern bool IsTrialVersion() { }

	// RVA: 0x231F4E0 Offset: 0x231F5E1 VA: 0x231F4E0
	public static extern int GetNumAVIVideoCodecs() { }

	// RVA: 0x231F690 Offset: 0x231F791 VA: 0x231F690
	public static extern bool IsConfigureVideoCodecSupported(int index) { }

	// RVA: 0x2323D70 Offset: 0x2323E71 VA: 0x2323D70
	public static extern void ConfigureVideoCodec(int index) { }

	// RVA: 0x231F550 Offset: 0x231F651 VA: 0x231F550
	public static string GetAVIVideoCodecName(int index) { }

	// RVA: 0x231F8D0 Offset: 0x231F9D1 VA: 0x231F8D0
	public static extern int GetNumAVIAudioCodecs() { }

	// RVA: 0x231FA80 Offset: 0x231FB81 VA: 0x231FA80
	public static extern bool IsConfigureAudioCodecSupported(int index) { }

	// RVA: 0x2323DF0 Offset: 0x2323EF1 VA: 0x2323DF0
	public static extern void ConfigureAudioCodec(int index) { }

	// RVA: 0x231F940 Offset: 0x231FA41 VA: 0x231F940
	public static string GetAVIAudioCodecName(int index) { }

	// RVA: 0x231F720 Offset: 0x231F821 VA: 0x231F720
	public static extern int GetNumAVIAudioInputDevices() { }

	// RVA: 0x231F790 Offset: 0x231F891 VA: 0x231F790
	public static string GetAVIAudioInputDeviceName(int index) { }

	// RVA: 0x2327DA0 Offset: 0x2327EA1 VA: 0x2327DA0
	public static extern int CreateRecorderVideo(string filename, uint width, uint height, int frameRate, int format, bool isTopDown, int videoCodecIndex, bool hasAudio, int audioSampleRate, int audioChannelCount, int audioInputDeviceIndex, int audioCodecIndex, bool isRealTime, bool useMediaFoundation, bool supportAlpha, bool forceGpuFlush) { }

	// RVA: 0x2327EE0 Offset: 0x2327FE1 VA: 0x2327EE0
	public static extern int CreateRecorderImages(string filename, uint width, uint height, int frameRate, int format, bool isTopDown, bool isRealTime, int imageFormatType, bool supportAlpha, bool forceGpuFlush, int startFrame) { }

	// RVA: 0x2327FF0 Offset: 0x23280F1 VA: 0x2327FF0
	public static extern int CreateRecorderPipe(string filename, uint width, uint height, int frameRate, int format, bool isTopDown, bool supportAlpha, bool forceGpuFlush) { }

	// RVA: 0x23280D0 Offset: 0x23281D1 VA: 0x23280D0
	public static extern bool Start(int handle) { }

	// RVA: 0x2328160 Offset: 0x2328261 VA: 0x2328160
	public static extern bool IsNewFrameDue(int handle) { }

	// RVA: 0x23281F0 Offset: 0x23282F1 VA: 0x23281F0
	public static extern void EncodeFrame(int handle, IntPtr data) { }

	// RVA: 0x23181A0 Offset: 0x23182A1 VA: 0x23181A0
	public static extern void EncodeAudio(int handle, IntPtr data, uint length) { }

	// RVA: 0x2328280 Offset: 0x2328381 VA: 0x2328280
	public static extern void EncodeFrameWithAudio(int handle, IntPtr videoData, IntPtr audioData, uint audioLength) { }

	// RVA: 0x2328330 Offset: 0x2328431 VA: 0x2328330
	public static extern void Pause(int handle) { }

	// RVA: 0x23283B0 Offset: 0x23284B1 VA: 0x23283B0
	public static extern void Stop(int handle, bool skipPendingFrames) { }

	// RVA: 0x2318040 Offset: 0x2318141 VA: 0x2318040
	public static extern void SetTexturePointer(int handle, IntPtr texture) { }

	// RVA: 0x2328440 Offset: 0x2328541 VA: 0x2328440
	public static extern void FreeRecorder(int handle) { }

	// RVA: 0x23284C0 Offset: 0x23285C1 VA: 0x23284C0
	public static extern uint GetNumDroppedFrames(int handle) { }

	// RVA: 0x2328540 Offset: 0x2328641 VA: 0x2328540
	public static extern uint GetNumDroppedEncoderFrames(int handle) { }

	// RVA: 0x23285C0 Offset: 0x23286C1 VA: 0x23285C0
	public static extern uint GetNumEncodedFrames(int handle) { }

	// RVA: 0x2328640 Offset: 0x2328741 VA: 0x2328640
	public static extern uint GetEncodedSeconds(int handle) { }

	// RVA: 0x2327A40 Offset: 0x2327B41 VA: 0x2327A40
	private static extern IntPtr GetPluginVersion() { }

	// RVA: 0x2327B30 Offset: 0x2327C31 VA: 0x2327B30
	private static extern bool GetAVIVideoCodecName(int index, StringBuilder name, int nameBufferLength) { }

	// RVA: 0x2327C00 Offset: 0x2327D01 VA: 0x2327C00
	private static extern bool GetAVIAudioCodecName(int index, StringBuilder name, int nameBufferLength) { }

	// RVA: 0x2327CD0 Offset: 0x2327DD1 VA: 0x2327CD0
	private static extern bool GetAVIAudioInputDeviceName(int index, StringBuilder name, int nameBufferLength) { }

	// RVA: 0x23286C0 Offset: 0x23287C1 VA: 0x23286C0
	public void .ctor() { }
}

public class NativePlugin // TypeDefIndex: 9620
{
	// Fields
	public const int PluginID = 262340608;
	public const string ScriptVersion = "3.7.2";
	public const string ExpectedPluginVersion = "3.7.2";
	public const int MaxRenderWidth = 16384;
	public const int MaxRenderHeight = 16384;

	// Methods

	// RVA: 0x23277A0 Offset: 0x23278A1 VA: 0x23277A0
	public static extern IntPtr GetRenderEventFunc() { }

	// RVA: 0x2327810 Offset: 0x2327911 VA: 0x2327810
	public static extern IntPtr GetFreeResourcesEventFunc() { }

	// RVA: 0x2327880 Offset: 0x2327981 VA: 0x2327880
	public static extern bool Init() { }

	// RVA: 0x2327900 Offset: 0x2327A01 VA: 0x2327900
	public static extern void Deinit() { }

	// RVA: 0x2327970 Offset: 0x2327A71 VA: 0x2327970
	public static string GetPluginVersionString() { }

	// RVA: 0x2327AB0 Offset: 0x2327BB1 VA: 0x2327AB0
	public static extern bool IsTrialVersion() { }

	// RVA: 0x231F4E0 Offset: 0x231F5E1 VA: 0x231F4E0
	public static extern int GetNumAVIVideoCodecs() { }

	// RVA: 0x231F690 Offset: 0x231F791 VA: 0x231F690
	public static extern bool IsConfigureVideoCodecSupported(int index) { }

	// RVA: 0x2323D70 Offset: 0x2323E71 VA: 0x2323D70
	public static extern void ConfigureVideoCodec(int index) { }

	// RVA: 0x231F550 Offset: 0x231F651 VA: 0x231F550
	public static string GetAVIVideoCodecName(int index) { }

	// RVA: 0x231F8D0 Offset: 0x231F9D1 VA: 0x231F8D0
	public static extern int GetNumAVIAudioCodecs() { }

	// RVA: 0x231FA80 Offset: 0x231FB81 VA: 0x231FA80
	public static extern bool IsConfigureAudioCodecSupported(int index) { }

	// RVA: 0x2323DF0 Offset: 0x2323EF1 VA: 0x2323DF0
	public static extern void ConfigureAudioCodec(int index) { }

	// RVA: 0x231F940 Offset: 0x231FA41 VA: 0x231F940
	public static string GetAVIAudioCodecName(int index) { }

	// RVA: 0x231F720 Offset: 0x231F821 VA: 0x231F720
	public static extern int GetNumAVIAudioInputDevices() { }

	// RVA: 0x231F790 Offset: 0x231F891 VA: 0x231F790
	public static string GetAVIAudioInputDeviceName(int index) { }

	// RVA: 0x2327DA0 Offset: 0x2327EA1 VA: 0x2327DA0
	public static extern int CreateRecorderVideo(string filename, uint width, uint height, int frameRate, int format, bool isTopDown, int videoCodecIndex, bool hasAudio, int audioSampleRate, int audioChannelCount, int audioInputDeviceIndex, int audioCodecIndex, bool isRealTime, bool useMediaFoundation, bool supportAlpha, bool forceGpuFlush) { }

	// RVA: 0x2327EE0 Offset: 0x2327FE1 VA: 0x2327EE0
	public static extern int CreateRecorderImages(string filename, uint width, uint height, int frameRate, int format, bool isTopDown, bool isRealTime, int imageFormatType, bool supportAlpha, bool forceGpuFlush, int startFrame) { }

	// RVA: 0x2327FF0 Offset: 0x23280F1 VA: 0x2327FF0
	public static extern int CreateRecorderPipe(string filename, uint width, uint height, int frameRate, int format, bool isTopDown, bool supportAlpha, bool forceGpuFlush) { }

	// RVA: 0x23280D0 Offset: 0x23281D1 VA: 0x23280D0
	public static extern bool Start(int handle) { }

	// RVA: 0x2328160 Offset: 0x2328261 VA: 0x2328160
	public static extern bool IsNewFrameDue(int handle) { }

	// RVA: 0x23281F0 Offset: 0x23282F1 VA: 0x23281F0
	public static extern void EncodeFrame(int handle, IntPtr data) { }

	// RVA: 0x23181A0 Offset: 0x23182A1 VA: 0x23181A0
	public static extern void EncodeAudio(int handle, IntPtr data, uint length) { }

	// RVA: 0x2328280 Offset: 0x2328381 VA: 0x2328280
	public static extern void EncodeFrameWithAudio(int handle, IntPtr videoData, IntPtr audioData, uint audioLength) { }

	// RVA: 0x2328330 Offset: 0x2328431 VA: 0x2328330
	public static extern void Pause(int handle) { }

	// RVA: 0x23283B0 Offset: 0x23284B1 VA: 0x23283B0
	public static extern void Stop(int handle, bool skipPendingFrames) { }

	// RVA: 0x2318040 Offset: 0x2318141 VA: 0x2318040
	public static extern void SetTexturePointer(int handle, IntPtr texture) { }

	// RVA: 0x2328440 Offset: 0x2328541 VA: 0x2328440
	public static extern void FreeRecorder(int handle) { }

	// RVA: 0x23284C0 Offset: 0x23285C1 VA: 0x23284C0
	public static extern uint GetNumDroppedFrames(int handle) { }

	// RVA: 0x2328540 Offset: 0x2328641 VA: 0x2328540
	public static extern uint GetNumDroppedEncoderFrames(int handle) { }

	// RVA: 0x23285C0 Offset: 0x23286C1 VA: 0x23285C0
	public static extern uint GetNumEncodedFrames(int handle) { }

	// RVA: 0x2328640 Offset: 0x2328741 VA: 0x2328640
	public static extern uint GetEncodedSeconds(int handle) { }

	// RVA: 0x2327A40 Offset: 0x2327B41 VA: 0x2327A40
	private static extern IntPtr GetPluginVersion() { }

	// RVA: 0x2327B30 Offset: 0x2327C31 VA: 0x2327B30
	private static extern bool GetAVIVideoCodecName(int index, StringBuilder name, int nameBufferLength) { }

	// RVA: 0x2327C00 Offset: 0x2327D01 VA: 0x2327C00
	private static extern bool GetAVIAudioCodecName(int index, StringBuilder name, int nameBufferLength) { }

	// RVA: 0x2327CD0 Offset: 0x2327DD1 VA: 0x2327CD0
	private static extern bool GetAVIAudioInputDeviceName(int index, StringBuilder name, int nameBufferLength) { }

	// RVA: 0x23286C0 Offset: 0x23287C1 VA: 0x23286C0
	public void .ctor() { }
}

