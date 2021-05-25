[NativeHeaderAttribute] // RVA: 0xC4D50 Offset: 0xC4E51 VA: 0xC4D50
[NativeAsStructAttribute] // RVA: 0xC4D50 Offset: 0xC4E51 VA: 0xC4D50
public sealed class LightProbes : Object // TypeDefIndex: 2878
{
	// Properties
	public Vector3[] positions { get; }
	public SphericalHarmonicsL2[] bakedProbes { get; set; }
	public int count { get; }
	public int cellCount { get; }
	[ObsoleteAttribute] // RVA: 0xDE410 Offset: 0xDE511 VA: 0xDE410
	[EditorBrowsableAttribute] // RVA: 0xDE410 Offset: 0xDE511 VA: 0xDE410
	public float[] coefficients { get; set; }

	// Methods

	// RVA: 0x1A2ECB0 Offset: 0x1A2EDB1 VA: 0x1A2ECB0
	private void .ctor() { }

	[FreeFunctionAttribute] // RVA: 0xCEAC0 Offset: 0xCEBC1 VA: 0xCEAC0
	// RVA: 0x1A2ED20 Offset: 0x1A2EE21 VA: 0x1A2ED20
	public static void Tetrahedralize() { }

	[FreeFunctionAttribute] // RVA: 0xCEAD0 Offset: 0xCEBD1 VA: 0xCEAD0
	// RVA: 0x1A2ED60 Offset: 0x1A2EE61 VA: 0x1A2ED60
	public static void TetrahedralizeAsync() { }

	[FreeFunctionAttribute] // RVA: 0xCEAE0 Offset: 0xCEBE1 VA: 0xCEAE0
	// RVA: 0x1A2EDA0 Offset: 0x1A2EEA1 VA: 0x1A2EDA0
	public static void GetInterpolatedProbe(Vector3 position, Renderer renderer, out SphericalHarmonicsL2 probe) { }

	[FreeFunctionAttribute] // RVA: 0xCEAF0 Offset: 0xCEBF1 VA: 0xCEAF0
	// RVA: 0x1A2EE70 Offset: 0x1A2EF71 VA: 0x1A2EE70
	internal static bool AreLightProbesAllowed(Renderer renderer) { }

	// RVA: 0x1A2EEC0 Offset: 0x1A2EFC1 VA: 0x1A2EEC0
	public static void CalculateInterpolatedLightAndOcclusionProbes(Vector3[] positions, SphericalHarmonicsL2[] lightProbes, Vector4[] occlusionProbes) { }

	// RVA: 0x1A2F0D0 Offset: 0x1A2F1D1 VA: 0x1A2F0D0
	public static void CalculateInterpolatedLightAndOcclusionProbes(List<Vector3> positions, List<SphericalHarmonicsL2> lightProbes, List<Vector4> occlusionProbes) { }

	[FreeFunctionAttribute] // RVA: 0xCEB00 Offset: 0xCEC01 VA: 0xCEB00
	[NativeNameAttribute] // RVA: 0xCEB00 Offset: 0xCEC01 VA: 0xCEB00
	// RVA: 0x1A2F060 Offset: 0x1A2F161 VA: 0x1A2F060
	internal static void CalculateInterpolatedLightAndOcclusionProbes_Internal(Vector3[] positions, int positionsCount, SphericalHarmonicsL2[] lightProbes, Vector4[] occlusionProbes) { }

	[NativeNameAttribute] // RVA: 0xCEB50 Offset: 0xCEC51 VA: 0xCEB50
	[FreeFunctionAttribute] // RVA: 0xCEB50 Offset: 0xCEC51 VA: 0xCEB50
	// RVA: 0x1A2F2D0 Offset: 0x1A2F3D1 VA: 0x1A2F2D0
	public Vector3[] get_positions() { }

	[FreeFunctionAttribute] // RVA: 0xCEBB0 Offset: 0xCECB1 VA: 0xCEBB0
	[NativeNameAttribute] // RVA: 0xCEBB0 Offset: 0xCECB1 VA: 0xCEBB0
	// RVA: 0x1A2F320 Offset: 0x1A2F421 VA: 0x1A2F320
	public SphericalHarmonicsL2[] get_bakedProbes() { }

	[FreeFunctionAttribute] // RVA: 0xCEC10 Offset: 0xCED11 VA: 0xCEC10
	[NativeNameAttribute] // RVA: 0xCEC10 Offset: 0xCED11 VA: 0xCEC10
	// RVA: 0x1A2F370 Offset: 0x1A2F471 VA: 0x1A2F370
	public void set_bakedProbes(SphericalHarmonicsL2[] value) { }

	[FreeFunctionAttribute] // RVA: 0xCEC70 Offset: 0xCED71 VA: 0xCEC70
	[NativeNameAttribute] // RVA: 0xCEC70 Offset: 0xCED71 VA: 0xCEC70
	// RVA: 0x1A2F3C0 Offset: 0x1A2F4C1 VA: 0x1A2F3C0
	public int get_count() { }

	[FreeFunctionAttribute] // RVA: 0xCECD0 Offset: 0xCEDD1 VA: 0xCECD0
	[NativeNameAttribute] // RVA: 0xCECD0 Offset: 0xCEDD1 VA: 0xCECD0
	// RVA: 0x1A2F410 Offset: 0x1A2F511 VA: 0x1A2F410
	public int get_cellCount() { }

	[FreeFunctionAttribute] // RVA: 0xCED30 Offset: 0xCEE31 VA: 0xCED30
	[NativeNameAttribute] // RVA: 0xCED30 Offset: 0xCEE31 VA: 0xCED30
	// RVA: 0x1A2F460 Offset: 0x1A2F561 VA: 0x1A2F460
	internal static int GetCount() { }

	[ObsoleteAttribute] // RVA: 0xCED80 Offset: 0xCEE81 VA: 0xCED80
	[EditorBrowsableAttribute] // RVA: 0xCED80 Offset: 0xCEE81 VA: 0xCED80
	// RVA: 0x1A2F4A0 Offset: 0x1A2F5A1 VA: 0x1A2F4A0
	public void GetInterpolatedLightProbe(Vector3 position, Renderer renderer, float[] coefficients) { }

	// RVA: 0x1A2F4B0 Offset: 0x1A2F5B1 VA: 0x1A2F4B0
	public float[] get_coefficients() { }

	// RVA: 0x1A2F500 Offset: 0x1A2F601 VA: 0x1A2F500
	public void set_coefficients(float[] value) { }

	// RVA: 0x1A2EE10 Offset: 0x1A2EF11 VA: 0x1A2EE10
	private static void GetInterpolatedProbe_Injected(ref Vector3 position, Renderer renderer, out SphericalHarmonicsL2 probe) { }
}

