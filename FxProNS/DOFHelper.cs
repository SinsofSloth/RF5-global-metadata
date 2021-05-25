public class DOFHelper : Singleton<DOFHelper>, IDisposable // TypeDefIndex: 11724
{
	// Fields
	private static Material _mat; // 0x0
	private DOFHelperParams _p; // 0x10
	private float _curAutoFocusDist; // 0x18

	// Properties
	public static Material Mat { get; }

	// Methods

	// RVA: 0x229F3D0 Offset: 0x229F4D1 VA: 0x229F3D0
	public static Material get_Mat() { }

	// RVA: 0x22A13C0 Offset: 0x22A14C1 VA: 0x22A13C0
	public void SetParams(DOFHelperParams p) { }

	// RVA: 0x229C2B0 Offset: 0x229C3B1 VA: 0x229C2B0
	public void Init(bool searchForNonDepthmapAlphaObjects) { }

	// RVA: 0x229C580 Offset: 0x229C681 VA: 0x229C580
	public void SetBlurRadius(int radius) { }

	// RVA: 0x22A13D0 Offset: 0x22A14D1 VA: 0x22A13D0
	private void CalculateAndUpdateFocalDist() { }

	// RVA: 0x22A1620 Offset: 0x22A1721 VA: 0x22A1620
	private float CalculateAutoFocusDist() { }

	// RVA: 0x229EEB0 Offset: 0x229EFB1 VA: 0x229EEB0
	public void RenderCOCTexture(RenderTexture src, RenderTexture dest, float blurScale) { }

	// RVA: 0x229F5A0 Offset: 0x229F6A1 VA: 0x229F5A0
	public void RenderDOFBlur(RenderTexture src, RenderTexture dest, RenderTexture cocTexture) { }

	// RVA: 0x22A17B0 Offset: 0x22A18B1 VA: 0x22A17B0
	public void RenderEffect(RenderTexture src, RenderTexture dest) { }

	// RVA: 0x22A17C0 Offset: 0x22A18C1 VA: 0x22A17C0
	public void RenderEffect(RenderTexture src, RenderTexture dest, bool visualizeCOC) { }

	// RVA: 0x22A1A90 Offset: 0x22A1B91 VA: 0x22A1A90
	public static GameObject[] GetNonDepthmapAlphaObjects() { }

	// RVA: 0x22A1E90 Offset: 0x22A1F91 VA: 0x22A1E90
	public static string GetFullPath(GameObject obj) { }

	// RVA: 0x229CF70 Offset: 0x229D071 VA: 0x229CF70 Slot: 4
	public void Dispose() { }

	// RVA: 0x22A1FE0 Offset: 0x22A20E1 VA: 0x22A1FE0
	public void .ctor() { }
}

