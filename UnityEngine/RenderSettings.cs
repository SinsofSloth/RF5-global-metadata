[StaticAccessorAttribute] // RVA: 0xC5120 Offset: 0xC5221 VA: 0xC5120
[NativeHeaderAttribute] // RVA: 0xC5120 Offset: 0xC5221 VA: 0xC5120
[NativeHeaderAttribute] // RVA: 0xC5120 Offset: 0xC5221 VA: 0xC5120
[NativeHeaderAttribute] // RVA: 0xC5120 Offset: 0xC5221 VA: 0xC5120
public sealed class RenderSettings : Object // TypeDefIndex: 2889
{
	// Properties
	[ObsoleteAttribute] // RVA: 0xDE5F0 Offset: 0xDE6F1 VA: 0xDE5F0
	public static float ambientSkyboxAmount { get; set; }
	[NativePropertyAttribute] // RVA: 0xDE630 Offset: 0xDE731 VA: 0xDE630
	public static bool fog { get; set; }
	[NativePropertyAttribute] // RVA: 0xDE670 Offset: 0xDE771 VA: 0xDE670
	public static float fogStartDistance { get; set; }
	[NativePropertyAttribute] // RVA: 0xDE6B0 Offset: 0xDE7B1 VA: 0xDE6B0
	public static float fogEndDistance { get; set; }
	public static FogMode fogMode { get; set; }
	public static Color fogColor { get; set; }
	public static float fogDensity { get; set; }
	public static AmbientMode ambientMode { get; set; }
	public static Color ambientSkyColor { get; set; }
	public static Color ambientEquatorColor { get; set; }
	public static Color ambientGroundColor { get; set; }
	public static float ambientIntensity { get; set; }
	[NativePropertyAttribute] // RVA: 0xDE6F0 Offset: 0xDE7F1 VA: 0xDE6F0
	public static Color ambientLight { get; set; }
	public static Color subtractiveShadowColor { get; set; }
	[NativePropertyAttribute] // RVA: 0xDE730 Offset: 0xDE831 VA: 0xDE730
	public static Material skybox { get; set; }
	public static Light sun { get; set; }
	public static SphericalHarmonicsL2 ambientProbe { get; set; }
	public static Cubemap customReflection { get; set; }
	public static float reflectionIntensity { get; set; }
	public static int reflectionBounces { get; set; }
	public static DefaultReflectionMode defaultReflectionMode { get; set; }
	public static int defaultReflectionResolution { get; set; }
	public static float haloStrength { get; set; }
	public static float flareStrength { get; set; }
	public static float flareFadeSpeed { get; set; }

	// Methods

	// RVA: 0x2B7BF50 Offset: 0x2B7C051 VA: 0x2B7BF50
	public static float get_ambientSkyboxAmount() { }

	// RVA: 0x2B7BFD0 Offset: 0x2B7C0D1 VA: 0x2B7BFD0
	public static void set_ambientSkyboxAmount(float value) { }

	// RVA: 0x2B7C070 Offset: 0x2B7C171 VA: 0x2B7C070
	private void .ctor() { }

	// RVA: 0x2B7C0E0 Offset: 0x2B7C1E1 VA: 0x2B7C0E0
	public static bool get_fog() { }

	// RVA: 0x2B7C120 Offset: 0x2B7C221 VA: 0x2B7C120
	public static void set_fog(bool value) { }

	// RVA: 0x2B7C170 Offset: 0x2B7C271 VA: 0x2B7C170
	public static float get_fogStartDistance() { }

	// RVA: 0x2B7C1B0 Offset: 0x2B7C2B1 VA: 0x2B7C1B0
	public static void set_fogStartDistance(float value) { }

	// RVA: 0x2B7C200 Offset: 0x2B7C301 VA: 0x2B7C200
	public static float get_fogEndDistance() { }

	// RVA: 0x2B7C240 Offset: 0x2B7C341 VA: 0x2B7C240
	public static void set_fogEndDistance(float value) { }

	// RVA: 0x2B7C290 Offset: 0x2B7C391 VA: 0x2B7C290
	public static FogMode get_fogMode() { }

	// RVA: 0x2B7C2D0 Offset: 0x2B7C3D1 VA: 0x2B7C2D0
	public static void set_fogMode(FogMode value) { }

	// RVA: 0x2B7C320 Offset: 0x2B7C421 VA: 0x2B7C320
	public static Color get_fogColor() { }

	// RVA: 0x2B7C3D0 Offset: 0x2B7C4D1 VA: 0x2B7C3D0
	public static void set_fogColor(Color value) { }

	// RVA: 0x2B7C470 Offset: 0x2B7C571 VA: 0x2B7C470
	public static float get_fogDensity() { }

	// RVA: 0x2B7C4B0 Offset: 0x2B7C5B1 VA: 0x2B7C4B0
	public static void set_fogDensity(float value) { }

	// RVA: 0x2B7C500 Offset: 0x2B7C601 VA: 0x2B7C500
	public static AmbientMode get_ambientMode() { }

	// RVA: 0x2B7C540 Offset: 0x2B7C641 VA: 0x2B7C540
	public static void set_ambientMode(AmbientMode value) { }

	// RVA: 0x2B7C590 Offset: 0x2B7C691 VA: 0x2B7C590
	public static Color get_ambientSkyColor() { }

	// RVA: 0x2B7C640 Offset: 0x2B7C741 VA: 0x2B7C640
	public static void set_ambientSkyColor(Color value) { }

	// RVA: 0x2B7C6E0 Offset: 0x2B7C7E1 VA: 0x2B7C6E0
	public static Color get_ambientEquatorColor() { }

	// RVA: 0x2B7C790 Offset: 0x2B7C891 VA: 0x2B7C790
	public static void set_ambientEquatorColor(Color value) { }

	// RVA: 0x2B7C830 Offset: 0x2B7C931 VA: 0x2B7C830
	public static Color get_ambientGroundColor() { }

	// RVA: 0x2B7C8E0 Offset: 0x2B7C9E1 VA: 0x2B7C8E0
	public static void set_ambientGroundColor(Color value) { }

	// RVA: 0x2B7BF90 Offset: 0x2B7C091 VA: 0x2B7BF90
	public static float get_ambientIntensity() { }

	// RVA: 0x2B7C020 Offset: 0x2B7C121 VA: 0x2B7C020
	public static void set_ambientIntensity(float value) { }

	// RVA: 0x2B7C980 Offset: 0x2B7CA81 VA: 0x2B7C980
	public static Color get_ambientLight() { }

	// RVA: 0x2B7CA30 Offset: 0x2B7CB31 VA: 0x2B7CA30
	public static void set_ambientLight(Color value) { }

	// RVA: 0x2B7CAD0 Offset: 0x2B7CBD1 VA: 0x2B7CAD0
	public static Color get_subtractiveShadowColor() { }

	// RVA: 0x2B7CB80 Offset: 0x2B7CC81 VA: 0x2B7CB80
	public static void set_subtractiveShadowColor(Color value) { }

	// RVA: 0x2B7CC20 Offset: 0x2B7CD21 VA: 0x2B7CC20
	public static Material get_skybox() { }

	// RVA: 0x2B7CC60 Offset: 0x2B7CD61 VA: 0x2B7CC60
	public static void set_skybox(Material value) { }

	// RVA: 0x2B7CCB0 Offset: 0x2B7CDB1 VA: 0x2B7CCB0
	public static Light get_sun() { }

	// RVA: 0x2B7CCF0 Offset: 0x2B7CDF1 VA: 0x2B7CCF0
	public static void set_sun(Light value) { }

	// RVA: 0x2B7CD40 Offset: 0x2B7CE41 VA: 0x2B7CD40
	public static SphericalHarmonicsL2 get_ambientProbe() { }

	// RVA: 0x2B7CE40 Offset: 0x2B7CF41 VA: 0x2B7CE40
	public static void set_ambientProbe(SphericalHarmonicsL2 value) { }

	// RVA: 0x2B7CEE0 Offset: 0x2B7CFE1 VA: 0x2B7CEE0
	public static Cubemap get_customReflection() { }

	// RVA: 0x2B7CF20 Offset: 0x2B7D021 VA: 0x2B7CF20
	public static void set_customReflection(Cubemap value) { }

	// RVA: 0x2B7CF70 Offset: 0x2B7D071 VA: 0x2B7CF70
	public static float get_reflectionIntensity() { }

	// RVA: 0x2B7CFB0 Offset: 0x2B7D0B1 VA: 0x2B7CFB0
	public static void set_reflectionIntensity(float value) { }

	// RVA: 0x2B7D000 Offset: 0x2B7D101 VA: 0x2B7D000
	public static int get_reflectionBounces() { }

	// RVA: 0x2B7D040 Offset: 0x2B7D141 VA: 0x2B7D040
	public static void set_reflectionBounces(int value) { }

	// RVA: 0x2B7D090 Offset: 0x2B7D191 VA: 0x2B7D090
	public static DefaultReflectionMode get_defaultReflectionMode() { }

	// RVA: 0x2B7D0D0 Offset: 0x2B7D1D1 VA: 0x2B7D0D0
	public static void set_defaultReflectionMode(DefaultReflectionMode value) { }

	// RVA: 0x2B7D120 Offset: 0x2B7D221 VA: 0x2B7D120
	public static int get_defaultReflectionResolution() { }

	// RVA: 0x2B7D160 Offset: 0x2B7D261 VA: 0x2B7D160
	public static void set_defaultReflectionResolution(int value) { }

	// RVA: 0x2B7D1B0 Offset: 0x2B7D2B1 VA: 0x2B7D1B0
	public static float get_haloStrength() { }

	// RVA: 0x2B7D1F0 Offset: 0x2B7D2F1 VA: 0x2B7D1F0
	public static void set_haloStrength(float value) { }

	// RVA: 0x2B7D240 Offset: 0x2B7D341 VA: 0x2B7D240
	public static float get_flareStrength() { }

	// RVA: 0x2B7D280 Offset: 0x2B7D381 VA: 0x2B7D280
	public static void set_flareStrength(float value) { }

	// RVA: 0x2B7D2D0 Offset: 0x2B7D3D1 VA: 0x2B7D2D0
	public static float get_flareFadeSpeed() { }

	// RVA: 0x2B7D310 Offset: 0x2B7D411 VA: 0x2B7D310
	public static void set_flareFadeSpeed(float value) { }

	[FreeFunctionAttribute] // RVA: 0xCF990 Offset: 0xCFA91 VA: 0xCF990
	// RVA: 0x2B7D360 Offset: 0x2B7D461 VA: 0x2B7D360
	internal static Object GetRenderSettings() { }

	[StaticAccessorAttribute] // RVA: 0xCF9D0 Offset: 0xCFAD1 VA: 0xCF9D0
	// RVA: 0x2B7D3A0 Offset: 0x2B7D4A1 VA: 0x2B7D3A0
	internal static void Reset() { }

	// RVA: 0x2B7C380 Offset: 0x2B7C481 VA: 0x2B7C380
	private static void get_fogColor_Injected(out Color ret) { }

	// RVA: 0x2B7C420 Offset: 0x2B7C521 VA: 0x2B7C420
	private static void set_fogColor_Injected(ref Color value) { }

	// RVA: 0x2B7C5F0 Offset: 0x2B7C6F1 VA: 0x2B7C5F0
	private static void get_ambientSkyColor_Injected(out Color ret) { }

	// RVA: 0x2B7C690 Offset: 0x2B7C791 VA: 0x2B7C690
	private static void set_ambientSkyColor_Injected(ref Color value) { }

	// RVA: 0x2B7C740 Offset: 0x2B7C841 VA: 0x2B7C740
	private static void get_ambientEquatorColor_Injected(out Color ret) { }

	// RVA: 0x2B7C7E0 Offset: 0x2B7C8E1 VA: 0x2B7C7E0
	private static void set_ambientEquatorColor_Injected(ref Color value) { }

	// RVA: 0x2B7C890 Offset: 0x2B7C991 VA: 0x2B7C890
	private static void get_ambientGroundColor_Injected(out Color ret) { }

	// RVA: 0x2B7C930 Offset: 0x2B7CA31 VA: 0x2B7C930
	private static void set_ambientGroundColor_Injected(ref Color value) { }

	// RVA: 0x2B7C9E0 Offset: 0x2B7CAE1 VA: 0x2B7C9E0
	private static void get_ambientLight_Injected(out Color ret) { }

	// RVA: 0x2B7CA80 Offset: 0x2B7CB81 VA: 0x2B7CA80
	private static void set_ambientLight_Injected(ref Color value) { }

	// RVA: 0x2B7CB30 Offset: 0x2B7CC31 VA: 0x2B7CB30
	private static void get_subtractiveShadowColor_Injected(out Color ret) { }

	// RVA: 0x2B7CBD0 Offset: 0x2B7CCD1 VA: 0x2B7CBD0
	private static void set_subtractiveShadowColor_Injected(ref Color value) { }

	// RVA: 0x2B7CDF0 Offset: 0x2B7CEF1 VA: 0x2B7CDF0
	private static void get_ambientProbe_Injected(out SphericalHarmonicsL2 ret) { }

	// RVA: 0x2B7CE90 Offset: 0x2B7CF91 VA: 0x2B7CE90
	private static void set_ambientProbe_Injected(ref SphericalHarmonicsL2 value) { }
}

