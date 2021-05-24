public class RenderTextureManager : IDisposable // TypeDefIndex: 11727
{
	// Fields
	private static RenderTextureManager instance; // 0x0
	private List<RenderTexture> allRenderTextures; // 0x10
	private List<RenderTexture> availableRenderTextures; // 0x18

	// Properties
	public static RenderTextureManager Instance { get; }

	// Methods

	// RVA: 0x229CDA0 Offset: 0x229CEA1 VA: 0x229CDA0
	public static RenderTextureManager get_Instance() { }

	// RVA: 0x229D440 Offset: 0x229D541 VA: 0x229D440
	public RenderTexture RequestRenderTexture(int _width, int _height, int _depth, RenderTextureFormat _format) { }

	// RVA: 0x229F4D0 Offset: 0x229F5D1 VA: 0x229F4D0
	public RenderTexture ReleaseRenderTexture(RenderTexture _tex) { }

	// RVA: 0x229EE00 Offset: 0x229EF01 VA: 0x229EE00
	public void SafeAssign(ref RenderTexture a, RenderTexture b) { }

	// RVA: 0x22A2060 Offset: 0x22A2161 VA: 0x22A2060
	public void MakeRenderTextureNonAvailable(RenderTexture _tex) { }

	// RVA: 0x22A2100 Offset: 0x22A2201 VA: 0x22A2100
	private RenderTexture CreateNewTexture(int _width, int _height, int _depth, RenderTextureFormat _format) { }

	// RVA: 0x22A21E0 Offset: 0x22A22E1 VA: 0x22A21E0
	public void PrintRenderTextureStats() { }

	// RVA: 0x22A24D0 Offset: 0x22A25D1 VA: 0x22A24D0
	private string RenderTexToString(RenderTexture _rt) { }

	// RVA: 0x22A2800 Offset: 0x22A2901 VA: 0x22A2800
	private void PrintRenderTexturesCount(string _prefix = "") { }

	// RVA: 0x229FF10 Offset: 0x22A0011 VA: 0x229FF10
	public void ReleaseAllRenderTextures() { }

	// RVA: 0x22A2A60 Offset: 0x22A2B61 VA: 0x22A2A60
	public void PrintBalance() { }

	// RVA: 0x229CE30 Offset: 0x229CF31 VA: 0x229CE30 Slot: 4
	public void Dispose() { }

	// RVA: 0x22A2050 Offset: 0x22A2151 VA: 0x22A2050
	public void .ctor() { }
}

