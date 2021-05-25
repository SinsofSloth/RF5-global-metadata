internal class TargetPositionCache // TypeDefIndex: 4860
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x134D30 Offset: 0x134E31 VA: 0x134D30
	private static bool <UseCache>k__BackingField; // 0x0
	public const float CacheStepSize = 0.016666668;
	private static TargetPositionCache.Mode m_CacheMode; // 0x4
	[CompilerGeneratedAttribute] // RVA: 0x134D40 Offset: 0x134E41 VA: 0x134D40
	private static float <CurrentTime>k__BackingField; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x134D50 Offset: 0x134E51 VA: 0x134D50
	private static int <CurrentFrame>k__BackingField; // 0xC
	[CompilerGeneratedAttribute] // RVA: 0x134D60 Offset: 0x134E61 VA: 0x134D60
	private static bool <IsCameraCut>k__BackingField; // 0x10
	private static Dictionary<Transform, TargetPositionCache.CacheEntry> m_Cache; // 0x18
	private static TargetPositionCache.TimeRange m_CacheTimeRange; // 0x20
	private const float kWraparoundSlush = 0.1;

	// Properties
	public static bool UseCache { get; set; }
	public static TargetPositionCache.Mode CacheMode { get; set; }
	public static bool IsRecording { get; }
	public static bool CurrentPlaybackTimeValid { get; }
	public static bool IsEmpty { get; }
	public static float CurrentTime { get; set; }
	public static int CurrentFrame { get; set; }
	public static bool IsCameraCut { get; set; }
	public static TargetPositionCache.TimeRange CacheTimeRange { get; }
	public static bool HasHurrentTime { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x137270 Offset: 0x137371 VA: 0x137270
	// RVA: 0x1A1F8E0 Offset: 0x1A1F9E1 VA: 0x1A1F8E0
	public static bool get_UseCache() { }

	[CompilerGeneratedAttribute] // RVA: 0x137280 Offset: 0x137381 VA: 0x137280
	// RVA: 0x1A1F950 Offset: 0x1A1FA51 VA: 0x1A1F950
	public static void set_UseCache(bool value) { }

	// RVA: 0x1A1F9C0 Offset: 0x1A1FAC1 VA: 0x1A1F9C0
	public static TargetPositionCache.Mode get_CacheMode() { }

	// RVA: 0x1A1FA30 Offset: 0x1A1FB31 VA: 0x1A1FA30
	public static void set_CacheMode(TargetPositionCache.Mode value) { }

	// RVA: 0x1A1FF20 Offset: 0x1A20021 VA: 0x1A1FF20
	public static bool get_IsRecording() { }

	// RVA: 0x1A20030 Offset: 0x1A20131 VA: 0x1A20030
	public static bool get_CurrentPlaybackTimeValid() { }

	// RVA: 0x1A20260 Offset: 0x1A20361 VA: 0x1A20260
	public static bool get_IsEmpty() { }

	[CompilerGeneratedAttribute] // RVA: 0x137290 Offset: 0x137391 VA: 0x137290
	// RVA: 0x1A20340 Offset: 0x1A20441 VA: 0x1A20340
	public static float get_CurrentTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x1372A0 Offset: 0x1373A1 VA: 0x1372A0
	// RVA: 0x1A203B0 Offset: 0x1A204B1 VA: 0x1A203B0
	public static void set_CurrentTime(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1372B0 Offset: 0x1373B1 VA: 0x1372B0
	// RVA: 0x1A20430 Offset: 0x1A20531 VA: 0x1A20430
	public static int get_CurrentFrame() { }

	[CompilerGeneratedAttribute] // RVA: 0x1372C0 Offset: 0x1373C1 VA: 0x1372C0
	// RVA: 0x1A204A0 Offset: 0x1A205A1 VA: 0x1A204A0
	public static void set_CurrentFrame(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1372D0 Offset: 0x1373D1 VA: 0x1372D0
	// RVA: 0x1A20510 Offset: 0x1A20611 VA: 0x1A20510
	public static bool get_IsCameraCut() { }

	[CompilerGeneratedAttribute] // RVA: 0x1372E0 Offset: 0x1373E1 VA: 0x1372E0
	// RVA: 0x1A20580 Offset: 0x1A20681 VA: 0x1A20580
	public static void set_IsCameraCut(bool value) { }

	// RVA: 0x1A205F0 Offset: 0x1A206F1 VA: 0x1A205F0
	public static TargetPositionCache.TimeRange get_CacheTimeRange() { }

	// RVA: 0x1A20170 Offset: 0x1A20271 VA: 0x1A20170
	public static bool get_HasHurrentTime() { }

	// RVA: 0x1A1FB50 Offset: 0x1A1FC51 VA: 0x1A1FB50
	public static void ClearCache() { }

	// RVA: 0x1A1FDB0 Offset: 0x1A1FEB1 VA: 0x1A1FDB0
	private static void CreatePlaybackCurves() { }

	// RVA: 0x1A1B030 Offset: 0x1A1B131 VA: 0x1A1B030
	public static Vector3 GetTargetPosition(Transform target) { }

	// RVA: 0x1A1D9E0 Offset: 0x1A1DAE1 VA: 0x1A1D9E0
	public static Quaternion GetTargetRotation(Transform target) { }

	// RVA: 0x1A20FF0 Offset: 0x1A210F1 VA: 0x1A20FF0
	public void .ctor() { }

	// RVA: 0x1A21000 Offset: 0x1A21101 VA: 0x1A21000
	private static void .cctor() { }
}

