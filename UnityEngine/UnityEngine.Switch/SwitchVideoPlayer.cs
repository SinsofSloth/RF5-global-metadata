public sealed class SwitchVideoPlayer // TypeDefIndex: 3885
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	private SwitchVideoPlayer.MovieEventDelegate m_MovieEvent; // 0x18
	[DebuggerBrowsableAttribute] // RVA: 0x115060 Offset: 0x115161 VA: 0x115060
	[CompilerGeneratedAttribute] // RVA: 0x115060 Offset: 0x115161 VA: 0x115060
	private static SwitchVideoPlayer.MovieEventDelegate OnMovieEvent; // 0x0

	// Properties
	public bool isLooping { set; }

	// Methods

	// RVA: 0x35177F0 Offset: 0x35178F1 VA: 0x35177F0
	public void .ctor(SwitchVideoPlayer.MovieEventDelegate on_movie_event) { }

	// RVA: 0x3517800 Offset: 0x3517901 VA: 0x3517800
	public void .ctor(SwitchVideoPlayer.MovieEventDelegate on_movie_event, bool fire_created_event) { }

	// RVA: 0x3517BA0 Offset: 0x3517CA1 VA: 0x3517BA0 Slot: 1
	protected override void Finalize() { }

	[NativeConditionalAttribute] // RVA: 0x115C30 Offset: 0x115D31 VA: 0x115C30
	// RVA: 0x3517E00 Offset: 0x3517F01 VA: 0x3517E00
	public void Dispose() { }

	[NativeConditionalAttribute] // RVA: 0x115C70 Offset: 0x115D71 VA: 0x115C70
	// RVA: 0x3517E50 Offset: 0x3517F51 VA: 0x3517E50
	public void Init(SwitchFMVTexture lumaTexture, SwitchFMVTexture chromaTexture) { }

	[NativeConditionalAttribute] // RVA: 0x115CB0 Offset: 0x115DB1 VA: 0x115CB0
	// RVA: 0x3517EB0 Offset: 0x3517FB1 VA: 0x3517EB0
	public void Terminate() { }

	[NativeConditionalAttribute] // RVA: 0x115CF0 Offset: 0x115DF1 VA: 0x115CF0
	// RVA: 0x3517F00 Offset: 0x3518001 VA: 0x3517F00
	public bool Play(string path) { }

	[NativeConditionalAttribute] // RVA: 0x115D30 Offset: 0x115E31 VA: 0x115D30
	// RVA: 0x3517F50 Offset: 0x3518051 VA: 0x3517F50
	public void Stop() { }

	[NativeConditionalAttribute] // RVA: 0x115D70 Offset: 0x115E71 VA: 0x115D70
	// RVA: 0x3517FA0 Offset: 0x35180A1 VA: 0x3517FA0
	public bool IsPlaying() { }

	[NativeConditionalAttribute] // RVA: 0x115DB0 Offset: 0x115EB1 VA: 0x115DB0
	// RVA: 0x3517FF0 Offset: 0x35180F1 VA: 0x3517FF0
	public void Pause(bool flg) { }

	[NativeConditionalAttribute] // RVA: 0x115DF0 Offset: 0x115EF1 VA: 0x115DF0
	// RVA: 0x3518040 Offset: 0x3518141 VA: 0x3518040
	public bool IsPaused() { }

	[NativeConditionalAttribute] // RVA: 0x115E30 Offset: 0x115F31 VA: 0x115E30
	// RVA: 0x3518090 Offset: 0x3518191 VA: 0x3518090
	public void SetVolume(float volume) { }

	[NativeConditionalAttribute] // RVA: 0x115E70 Offset: 0x115F71 VA: 0x115E70
	// RVA: 0x35180E0 Offset: 0x35181E1 VA: 0x35180E0
	public bool JumpTo(float sec) { }

	[NativeConditionalAttribute] // RVA: 0x115EB0 Offset: 0x115FB1 VA: 0x115EB0
	// RVA: 0x3518130 Offset: 0x3518231 VA: 0x3518130
	public float GetCurrentTime() { }

	[NativeConditionalAttribute] // RVA: 0x115EF0 Offset: 0x115FF1 VA: 0x115EF0
	// RVA: 0x3518180 Offset: 0x3518281 VA: 0x3518180
	public float GetVideoLength() { }

	[NativeConditionalAttribute] // RVA: 0x115F30 Offset: 0x116031 VA: 0x115F30
	// RVA: 0x35181D0 Offset: 0x35182D1 VA: 0x35181D0
	public void Update() { }

	[NativeConditionalAttribute] // RVA: 0x115F70 Offset: 0x116071 VA: 0x115F70
	// RVA: 0x3518220 Offset: 0x3518321 VA: 0x3518220
	public void SetContainerType(SwitchVideoPlayer.ContainerType type) { }

	// RVA: 0x3518270 Offset: 0x3518371 VA: 0x3518270
	public void GetTrackInfo(string path, out int width, out int height) { }

	[NativeConditionalAttribute] // RVA: 0x115FB0 Offset: 0x1160B1 VA: 0x115FB0
	[NativeMethodAttribute] // RVA: 0x115FB0 Offset: 0x1160B1 VA: 0x115FB0
	// RVA: 0x3518300 Offset: 0x3518401 VA: 0x3518300
	private void GetTrackInfo_Internal(string path, out int width, out int height, out int crop_left, out int crop_right, out int crop_top, out int crop_bottom) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x116010 Offset: 0x116111 VA: 0x116010
	// RVA: 0x3517AE0 Offset: 0x3517BE1 VA: 0x3517AE0
	private static void FireMovieEvent(SwitchVideoPlayer.Event eventValue) { }

	[CompilerGeneratedAttribute] // RVA: 0x116020 Offset: 0x116121 VA: 0x116020
	// RVA: 0x35179A0 Offset: 0x3517AA1 VA: 0x35179A0
	public static void add_OnMovieEvent(SwitchVideoPlayer.MovieEventDelegate value) { }

	[CompilerGeneratedAttribute] // RVA: 0x116030 Offset: 0x116131 VA: 0x116030
	// RVA: 0x3517CC0 Offset: 0x3517DC1 VA: 0x3517CC0
	public static void remove_OnMovieEvent(SwitchVideoPlayer.MovieEventDelegate value) { }

	[NativeConditionalAttribute] // RVA: 0x116040 Offset: 0x116141 VA: 0x116040
	[NativeMethodAttribute] // RVA: 0x116040 Offset: 0x116141 VA: 0x116040
	// RVA: 0x3518660 Offset: 0x3518761 VA: 0x3518660
	public void set_isLooping(bool value) { }

	[NativeMethodAttribute] // RVA: 0x1160A0 Offset: 0x1161A1 VA: 0x1160A0
	[NativeConditionalAttribute] // RVA: 0x1160A0 Offset: 0x1161A1 VA: 0x1160A0
	// RVA: 0x3517A90 Offset: 0x3517B91 VA: 0x3517A90
	private void Create_Internal() { }

	[FreeFunctionAttribute] // RVA: 0x116100 Offset: 0x116201 VA: 0x116100
	[NativeConditionalAttribute] // RVA: 0x116100 Offset: 0x116201 VA: 0x116100
	// RVA: 0x3517960 Offset: 0x3517A61 VA: 0x3517960
	private static IntPtr CreateInstance() { }

	[NativeConditionalAttribute] // RVA: 0x116160 Offset: 0x116261 VA: 0x116160
	[FreeFunctionAttribute] // RVA: 0x116160 Offset: 0x116261 VA: 0x116160
	// RVA: 0x3517DB0 Offset: 0x3517EB1 VA: 0x3517DB0
	private static void DestroyInstance(IntPtr ptr) { }

	// RVA: 0x35186B0 Offset: 0x35187B1 VA: 0x35186B0
	private static void .cctor() { }
}

