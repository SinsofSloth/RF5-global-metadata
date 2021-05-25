[NativeHeaderAttribute] // RVA: 0xC7200 Offset: 0xC7301 VA: 0xC7200
[StaticAccessorAttribute] // RVA: 0xC7200 Offset: 0xC7301 VA: 0xC7200
public class Time // TypeDefIndex: 3060
{
	// Properties
	[NativePropertyAttribute] // RVA: 0xDF180 Offset: 0xDF281 VA: 0xDF180
	public static float time { get; }
	[NativePropertyAttribute] // RVA: 0xDF1C0 Offset: 0xDF2C1 VA: 0xDF1C0
	public static float timeSinceLevelLoad { get; }
	public static float deltaTime { get; }
	public static float fixedTime { get; }
	public static float unscaledTime { get; }
	public static float unscaledDeltaTime { get; }
	public static float fixedDeltaTime { get; set; }
	public static float maximumDeltaTime { get; }
	public static float smoothDeltaTime { get; }
	public static float timeScale { get; set; }
	public static int frameCount { get; }
	[NativePropertyAttribute] // RVA: 0xDF200 Offset: 0xDF301 VA: 0xDF200
	public static float realtimeSinceStartup { get; }
	public static float captureDeltaTime { get; set; }
	public static int captureFramerate { get; set; }

	// Methods

	// RVA: 0x2A35B70 Offset: 0x2A35C71 VA: 0x2A35B70
	public static float get_time() { }

	// RVA: 0x2A35BB0 Offset: 0x2A35CB1 VA: 0x2A35BB0
	public static float get_timeSinceLevelLoad() { }

	// RVA: 0x2A35BF0 Offset: 0x2A35CF1 VA: 0x2A35BF0
	public static float get_deltaTime() { }

	// RVA: 0x2A35C30 Offset: 0x2A35D31 VA: 0x2A35C30
	public static float get_fixedTime() { }

	// RVA: 0x2A35C70 Offset: 0x2A35D71 VA: 0x2A35C70
	public static float get_unscaledTime() { }

	// RVA: 0x2A35CB0 Offset: 0x2A35DB1 VA: 0x2A35CB0
	public static float get_unscaledDeltaTime() { }

	// RVA: 0x2A35CF0 Offset: 0x2A35DF1 VA: 0x2A35CF0
	public static float get_fixedDeltaTime() { }

	// RVA: 0x2A35D30 Offset: 0x2A35E31 VA: 0x2A35D30
	public static void set_fixedDeltaTime(float value) { }

	// RVA: 0x2A35D80 Offset: 0x2A35E81 VA: 0x2A35D80
	public static float get_maximumDeltaTime() { }

	// RVA: 0x2A35DC0 Offset: 0x2A35EC1 VA: 0x2A35DC0
	public static float get_smoothDeltaTime() { }

	// RVA: 0x2A35E00 Offset: 0x2A35F01 VA: 0x2A35E00
	public static float get_timeScale() { }

	// RVA: 0x2A35E40 Offset: 0x2A35F41 VA: 0x2A35E40
	public static void set_timeScale(float value) { }

	// RVA: 0x2A35E90 Offset: 0x2A35F91 VA: 0x2A35E90
	public static int get_frameCount() { }

	// RVA: 0x2A35ED0 Offset: 0x2A35FD1 VA: 0x2A35ED0
	public static float get_realtimeSinceStartup() { }

	// RVA: 0x2A35F10 Offset: 0x2A36011 VA: 0x2A35F10
	public static float get_captureDeltaTime() { }

	// RVA: 0x2A35F50 Offset: 0x2A36051 VA: 0x2A35F50
	public static void set_captureDeltaTime(float value) { }

	// RVA: 0x2A35FA0 Offset: 0x2A360A1 VA: 0x2A35FA0
	public static int get_captureFramerate() { }

	// RVA: 0x2A36100 Offset: 0x2A36201 VA: 0x2A36100
	public static void set_captureFramerate(int value) { }
}

