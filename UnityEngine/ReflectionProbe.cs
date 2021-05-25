[NativeHeaderAttribute] // RVA: 0xC4580 Offset: 0xC4681 VA: 0xC4580
public sealed class ReflectionProbe : Behaviour // TypeDefIndex: 2851
{
	// Fields
	[DebuggerBrowsableAttribute] // RVA: 0xC9A20 Offset: 0xC9B21 VA: 0xC9A20
	[CompilerGeneratedAttribute] // RVA: 0xC9A20 Offset: 0xC9B21 VA: 0xC9A20
	private static Action<ReflectionProbe, ReflectionProbe.ReflectionProbeEvent> reflectionProbeChanged; // 0x0
	[DebuggerBrowsableAttribute] // RVA: 0xC9A60 Offset: 0xC9B61 VA: 0xC9A60
	[CompilerGeneratedAttribute] // RVA: 0xC9A60 Offset: 0xC9B61 VA: 0xC9A60
	private static Action<Cubemap> defaultReflectionSet; // 0x8

	// Properties
	[NativeNameAttribute] // RVA: 0xDDE70 Offset: 0xDDF71 VA: 0xDDE70
	[EditorBrowsableAttribute] // RVA: 0xDDE70 Offset: 0xDDF71 VA: 0xDDE70
	[ObsoleteAttribute] // RVA: 0xDDE70 Offset: 0xDDF71 VA: 0xDDE70
	public ReflectionProbeType type { get; set; }
	[NativeNameAttribute] // RVA: 0xDDEF0 Offset: 0xDDFF1 VA: 0xDDEF0
	public Vector3 size { get; set; }
	[NativeNameAttribute] // RVA: 0xDDF30 Offset: 0xDE031 VA: 0xDDF30
	public Vector3 center { get; set; }
	[NativeNameAttribute] // RVA: 0xDDF70 Offset: 0xDE071 VA: 0xDDF70
	public float nearClipPlane { get; set; }
	[NativeNameAttribute] // RVA: 0xDDFB0 Offset: 0xDE0B1 VA: 0xDDFB0
	public float farClipPlane { get; set; }
	[NativeNameAttribute] // RVA: 0xDDFF0 Offset: 0xDE0F1 VA: 0xDDFF0
	public float intensity { get; set; }
	[NativeNameAttribute] // RVA: 0xDE030 Offset: 0xDE131 VA: 0xDE030
	public Bounds bounds { get; }
	[NativeNameAttribute] // RVA: 0xDE070 Offset: 0xDE171 VA: 0xDE070
	public bool hdr { get; set; }
	public float shadowDistance { get; set; }
	public int resolution { get; set; }
	public int cullingMask { get; set; }
	public ReflectionProbeClearFlags clearFlags { get; set; }
	public Color backgroundColor { get; set; }
	public float blendDistance { get; set; }
	public bool boxProjection { get; set; }
	public ReflectionProbeMode mode { get; set; }
	public int importance { get; set; }
	public ReflectionProbeRefreshMode refreshMode { get; set; }
	public ReflectionProbeTimeSlicingMode timeSlicingMode { get; set; }
	public Texture bakedTexture { get; set; }
	public Texture customBakedTexture { get; set; }
	public RenderTexture realtimeTexture { get; set; }
	public Texture texture { get; }
	public Vector4 textureHDRDecodeValues { get; }
	[StaticAccessorAttribute] // RVA: 0xDE0B0 Offset: 0xDE1B1 VA: 0xDE0B0
	public static int minBakedCubemapResolution { get; }
	[StaticAccessorAttribute] // RVA: 0xDE0F0 Offset: 0xDE1F1 VA: 0xDE0F0
	public static int maxBakedCubemapResolution { get; }
	[StaticAccessorAttribute] // RVA: 0xDE130 Offset: 0xDE231 VA: 0xDE130
	public static Vector4 defaultTextureHDRDecodeValues { get; }
	[StaticAccessorAttribute] // RVA: 0xDE170 Offset: 0xDE271 VA: 0xDE170
	public static Texture defaultTexture { get; }

	// Methods

	// RVA: 0x2B7A630 Offset: 0x2B7A731 VA: 0x2B7A630
	public ReflectionProbeType get_type() { }

	// RVA: 0x2B7A680 Offset: 0x2B7A781 VA: 0x2B7A680
	public void set_type(ReflectionProbeType value) { }

	// RVA: 0x2B7A6D0 Offset: 0x2B7A7D1 VA: 0x2B7A6D0
	public Vector3 get_size() { }

	// RVA: 0x2B7A780 Offset: 0x2B7A881 VA: 0x2B7A780
	public void set_size(Vector3 value) { }

	// RVA: 0x2B7A830 Offset: 0x2B7A931 VA: 0x2B7A830
	public Vector3 get_center() { }

	// RVA: 0x2B7A8E0 Offset: 0x2B7A9E1 VA: 0x2B7A8E0
	public void set_center(Vector3 value) { }

	// RVA: 0x2B7A990 Offset: 0x2B7AA91 VA: 0x2B7A990
	public float get_nearClipPlane() { }

	// RVA: 0x2B7A9E0 Offset: 0x2B7AAE1 VA: 0x2B7A9E0
	public void set_nearClipPlane(float value) { }

	// RVA: 0x2B7AA30 Offset: 0x2B7AB31 VA: 0x2B7AA30
	public float get_farClipPlane() { }

	// RVA: 0x2B7AA80 Offset: 0x2B7AB81 VA: 0x2B7AA80
	public void set_farClipPlane(float value) { }

	// RVA: 0x2B7AAD0 Offset: 0x2B7ABD1 VA: 0x2B7AAD0
	public float get_intensity() { }

	// RVA: 0x2B7AB20 Offset: 0x2B7AC21 VA: 0x2B7AB20
	public void set_intensity(float value) { }

	// RVA: 0x2B7AB70 Offset: 0x2B7AC71 VA: 0x2B7AB70
	public Bounds get_bounds() { }

	// RVA: 0x2B7AC30 Offset: 0x2B7AD31 VA: 0x2B7AC30
	public bool get_hdr() { }

	// RVA: 0x2B7AC80 Offset: 0x2B7AD81 VA: 0x2B7AC80
	public void set_hdr(bool value) { }

	// RVA: 0x2B7ACD0 Offset: 0x2B7ADD1 VA: 0x2B7ACD0
	public float get_shadowDistance() { }

	// RVA: 0x2B7AD20 Offset: 0x2B7AE21 VA: 0x2B7AD20
	public void set_shadowDistance(float value) { }

	// RVA: 0x2B7AD70 Offset: 0x2B7AE71 VA: 0x2B7AD70
	public int get_resolution() { }

	// RVA: 0x2B7ADC0 Offset: 0x2B7AEC1 VA: 0x2B7ADC0
	public void set_resolution(int value) { }

	// RVA: 0x2B7AE10 Offset: 0x2B7AF11 VA: 0x2B7AE10
	public int get_cullingMask() { }

	// RVA: 0x2B7AE60 Offset: 0x2B7AF61 VA: 0x2B7AE60
	public void set_cullingMask(int value) { }

	// RVA: 0x2B7AEB0 Offset: 0x2B7AFB1 VA: 0x2B7AEB0
	public ReflectionProbeClearFlags get_clearFlags() { }

	// RVA: 0x2B7AF00 Offset: 0x2B7B001 VA: 0x2B7AF00
	public void set_clearFlags(ReflectionProbeClearFlags value) { }

	// RVA: 0x2B7AF50 Offset: 0x2B7B051 VA: 0x2B7AF50
	public Color get_backgroundColor() { }

	// RVA: 0x2B7B000 Offset: 0x2B7B101 VA: 0x2B7B000
	public void set_backgroundColor(Color value) { }

	// RVA: 0x2B7B0B0 Offset: 0x2B7B1B1 VA: 0x2B7B0B0
	public float get_blendDistance() { }

	// RVA: 0x2B7B100 Offset: 0x2B7B201 VA: 0x2B7B100
	public void set_blendDistance(float value) { }

	// RVA: 0x2B7B150 Offset: 0x2B7B251 VA: 0x2B7B150
	public bool get_boxProjection() { }

	// RVA: 0x2B7B1A0 Offset: 0x2B7B2A1 VA: 0x2B7B1A0
	public void set_boxProjection(bool value) { }

	// RVA: 0x2B7B1F0 Offset: 0x2B7B2F1 VA: 0x2B7B1F0
	public ReflectionProbeMode get_mode() { }

	// RVA: 0x2B7B240 Offset: 0x2B7B341 VA: 0x2B7B240
	public void set_mode(ReflectionProbeMode value) { }

	// RVA: 0x2B7B290 Offset: 0x2B7B391 VA: 0x2B7B290
	public int get_importance() { }

	// RVA: 0x2B7B2E0 Offset: 0x2B7B3E1 VA: 0x2B7B2E0
	public void set_importance(int value) { }

	// RVA: 0x2B7B330 Offset: 0x2B7B431 VA: 0x2B7B330
	public ReflectionProbeRefreshMode get_refreshMode() { }

	// RVA: 0x2B7B380 Offset: 0x2B7B481 VA: 0x2B7B380
	public void set_refreshMode(ReflectionProbeRefreshMode value) { }

	// RVA: 0x2B7B3D0 Offset: 0x2B7B4D1 VA: 0x2B7B3D0
	public ReflectionProbeTimeSlicingMode get_timeSlicingMode() { }

	// RVA: 0x2B7B420 Offset: 0x2B7B521 VA: 0x2B7B420
	public void set_timeSlicingMode(ReflectionProbeTimeSlicingMode value) { }

	// RVA: 0x2B7B470 Offset: 0x2B7B571 VA: 0x2B7B470
	public Texture get_bakedTexture() { }

	// RVA: 0x2B7B4C0 Offset: 0x2B7B5C1 VA: 0x2B7B4C0
	public void set_bakedTexture(Texture value) { }

	// RVA: 0x2B7B510 Offset: 0x2B7B611 VA: 0x2B7B510
	public Texture get_customBakedTexture() { }

	// RVA: 0x2B7B560 Offset: 0x2B7B661 VA: 0x2B7B560
	public void set_customBakedTexture(Texture value) { }

	// RVA: 0x2B7B5B0 Offset: 0x2B7B6B1 VA: 0x2B7B5B0
	public RenderTexture get_realtimeTexture() { }

	// RVA: 0x2B7B600 Offset: 0x2B7B701 VA: 0x2B7B600
	public void set_realtimeTexture(RenderTexture value) { }

	// RVA: 0x2B7B650 Offset: 0x2B7B751 VA: 0x2B7B650
	public Texture get_texture() { }

	[NativeNameAttribute] // RVA: 0xCDB10 Offset: 0xCDC11 VA: 0xCDB10
	// RVA: 0x2B7B6A0 Offset: 0x2B7B7A1 VA: 0x2B7B6A0
	public Vector4 get_textureHDRDecodeValues() { }

	// RVA: 0x2B7B750 Offset: 0x2B7B851 VA: 0x2B7B750
	public void Reset() { }

	// RVA: 0x2B7B7A0 Offset: 0x2B7B8A1 VA: 0x2B7B7A0
	public int RenderProbe() { }

	// RVA: 0x2B7B820 Offset: 0x2B7B921 VA: 0x2B7B820
	public int RenderProbe(RenderTexture targetTexture) { }

	// RVA: 0x2B7B900 Offset: 0x2B7BA01 VA: 0x2B7B900
	public bool IsFinishedRendering(int renderId) { }

	// RVA: 0x2B7B8A0 Offset: 0x2B7B9A1 VA: 0x2B7B8A0
	private int ScheduleRender(ReflectionProbeTimeSlicingMode timeSlicingMode, RenderTexture targetTexture) { }

	[FreeFunctionAttribute] // RVA: 0xCDB50 Offset: 0xCDC51 VA: 0xCDB50
	[NativeHeaderAttribute] // RVA: 0xCDB50 Offset: 0xCDC51 VA: 0xCDB50
	// RVA: 0x2B7B950 Offset: 0x2B7BA51 VA: 0x2B7B950
	public static bool BlendCubemap(Texture src, Texture dst, float blend, RenderTexture target) { }

	// RVA: 0x2B7B9C0 Offset: 0x2B7BAC1 VA: 0x2B7B9C0
	public static int get_minBakedCubemapResolution() { }

	// RVA: 0x2B7BA00 Offset: 0x2B7BB01 VA: 0x2B7BA00
	public static int get_maxBakedCubemapResolution() { }

	// RVA: 0x2B7BA40 Offset: 0x2B7BB41 VA: 0x2B7BA40
	public static Vector4 get_defaultTextureHDRDecodeValues() { }

	// RVA: 0x2B7BAF0 Offset: 0x2B7BBF1 VA: 0x2B7BAF0
	public static Texture get_defaultTexture() { }

	[CompilerGeneratedAttribute] // RVA: 0xCDBB0 Offset: 0xCDCB1 VA: 0xCDBB0
	// RVA: 0x2B7BB30 Offset: 0x2B7BC31 VA: 0x2B7BB30
	public static void add_reflectionProbeChanged(Action<ReflectionProbe, ReflectionProbe.ReflectionProbeEvent> value) { }

	[CompilerGeneratedAttribute] // RVA: 0xCDBC0 Offset: 0xCDCC1 VA: 0xCDBC0
	// RVA: 0x2B7BBF0 Offset: 0x2B7BCF1 VA: 0x2B7BBF0
	public static void remove_reflectionProbeChanged(Action<ReflectionProbe, ReflectionProbe.ReflectionProbeEvent> value) { }

	[CompilerGeneratedAttribute] // RVA: 0xCDBD0 Offset: 0xCDCD1 VA: 0xCDBD0
	// RVA: 0x2B7BCB0 Offset: 0x2B7BDB1 VA: 0x2B7BCB0
	public static void add_defaultReflectionSet(Action<Cubemap> value) { }

	[CompilerGeneratedAttribute] // RVA: 0xCDBE0 Offset: 0xCDCE1 VA: 0xCDBE0
	// RVA: 0x2B7BD70 Offset: 0x2B7BE71 VA: 0x2B7BD70
	public static void remove_defaultReflectionSet(Action<Cubemap> value) { }

	[RequiredByNativeCodeAttribute] // RVA: 0xCDBF0 Offset: 0xCDCF1 VA: 0xCDBF0
	// RVA: 0x2B7BE30 Offset: 0x2B7BF31 VA: 0x2B7BE30
	private static void CallReflectionProbeEvent(ReflectionProbe probe, ReflectionProbe.ReflectionProbeEvent probeEvent) { }

	[RequiredByNativeCodeAttribute] // RVA: 0xCDC00 Offset: 0xCDD01 VA: 0xCDC00
	// RVA: 0x2B7BEC0 Offset: 0x2B7BFC1 VA: 0x2B7BEC0
	private static void CallSetDefaultReflection(Cubemap defaultReflectionCubemap) { }

	// RVA: 0x2B7BF40 Offset: 0x2B7C041 VA: 0x2B7BF40
	public void .ctor() { }

	// RVA: 0x2B7A730 Offset: 0x2B7A831 VA: 0x2B7A730
	private void get_size_Injected(out Vector3 ret) { }

	// RVA: 0x2B7A7E0 Offset: 0x2B7A8E1 VA: 0x2B7A7E0
	private void set_size_Injected(ref Vector3 value) { }

	// RVA: 0x2B7A890 Offset: 0x2B7A991 VA: 0x2B7A890
	private void get_center_Injected(out Vector3 ret) { }

	// RVA: 0x2B7A940 Offset: 0x2B7AA41 VA: 0x2B7A940
	private void set_center_Injected(ref Vector3 value) { }

	// RVA: 0x2B7ABE0 Offset: 0x2B7ACE1 VA: 0x2B7ABE0
	private void get_bounds_Injected(out Bounds ret) { }

	// RVA: 0x2B7AFB0 Offset: 0x2B7B0B1 VA: 0x2B7AFB0
	private void get_backgroundColor_Injected(out Color ret) { }

	// RVA: 0x2B7B060 Offset: 0x2B7B161 VA: 0x2B7B060
	private void set_backgroundColor_Injected(ref Color value) { }

	// RVA: 0x2B7B700 Offset: 0x2B7B801 VA: 0x2B7B700
	private void get_textureHDRDecodeValues_Injected(out Vector4 ret) { }

	// RVA: 0x2B7BAA0 Offset: 0x2B7BBA1 VA: 0x2B7BAA0
	private static void get_defaultTextureHDRDecodeValues_Injected(out Vector4 ret) { }
}

