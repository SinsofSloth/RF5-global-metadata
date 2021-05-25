[NativeHeaderAttribute] // RVA: 0xC6530 Offset: 0xC6631 VA: 0xC6530
public sealed class Random // TypeDefIndex: 2986
{
	// Properties
	[StaticAccessorAttribute] // RVA: 0xDEFB0 Offset: 0xDF0B1 VA: 0xDEFB0
	public static Random.State state { get; set; }
	public static float value { get; }
	public static Vector3 insideUnitSphere { get; }
	public static Vector3 onUnitSphere { get; }

	// Methods

	[StaticAccessorAttribute] // RVA: 0xD5870 Offset: 0xD5971 VA: 0xD5870
	[NativeMethodAttribute] // RVA: 0xD5870 Offset: 0xD5971 VA: 0xD5870
	// RVA: 0x2B76130 Offset: 0x2B76231 VA: 0x2B76130
	public static void InitState(int seed) { }

	// RVA: 0x2B76180 Offset: 0x2B76281 VA: 0x2B76180
	public static Random.State get_state() { }

	// RVA: 0x2B76220 Offset: 0x2B76321 VA: 0x2B76220
	public static void set_state(Random.State value) { }

	[FreeFunctionAttribute] // RVA: 0xD58E0 Offset: 0xD59E1 VA: 0xD58E0
	// RVA: 0x2B762C0 Offset: 0x2B763C1 VA: 0x2B762C0
	public static float Range(float min, float max) { }

	// RVA: 0x2B76310 Offset: 0x2B76411 VA: 0x2B76310
	public static int Range(int min, int max) { }

	[FreeFunctionAttribute] // RVA: 0xD58F0 Offset: 0xD59F1 VA: 0xD58F0
	// RVA: 0x2B76360 Offset: 0x2B76461 VA: 0x2B76360
	private static int RandomRangeInt(int min, int max) { }

	[FreeFunctionAttribute] // RVA: 0xD5900 Offset: 0xD5A01 VA: 0xD5900
	// RVA: 0x2B763B0 Offset: 0x2B764B1 VA: 0x2B763B0
	public static float get_value() { }

	[FreeFunctionAttribute] // RVA: 0xD5910 Offset: 0xD5A11 VA: 0xD5910
	// RVA: 0x2B763F0 Offset: 0x2B764F1 VA: 0x2B763F0
	public static Vector3 get_insideUnitSphere() { }

	[FreeFunctionAttribute] // RVA: 0xD5920 Offset: 0xD5A21 VA: 0xD5920
	// RVA: 0x2B764A0 Offset: 0x2B765A1 VA: 0x2B764A0
	public static Vector3 get_onUnitSphere() { }

	// RVA: 0x2B761D0 Offset: 0x2B762D1 VA: 0x2B761D0
	private static void get_state_Injected(out Random.State ret) { }

	// RVA: 0x2B76270 Offset: 0x2B76371 VA: 0x2B76270
	private static void set_state_Injected(ref Random.State value) { }

	// RVA: 0x2B76450 Offset: 0x2B76551 VA: 0x2B76450
	private static void get_insideUnitSphere_Injected(out Vector3 ret) { }

	// RVA: 0x2B76500 Offset: 0x2B76601 VA: 0x2B76500
	private static void get_onUnitSphere_Injected(out Vector3 ret) { }
}

