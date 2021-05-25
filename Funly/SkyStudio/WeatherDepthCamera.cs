[RequireComponent] // RVA: 0x1494A0 Offset: 0x1495A1 VA: 0x1494A0
public class WeatherDepthCamera : MonoBehaviour // TypeDefIndex: 9701
{
	// Fields
	private Camera m_DepthCamera; // 0x18
	[TooltipAttribute] // RVA: 0x17EC00 Offset: 0x17ED01 VA: 0x17EC00
	public Shader depthShader; // 0x20
	[HideInInspector] // RVA: 0x17EC40 Offset: 0x17ED41 VA: 0x17EC40
	public RenderTexture overheadDepthTexture; // 0x28
	[TooltipAttribute] // RVA: 0x17EC50 Offset: 0x17ED51 VA: 0x17EC50
	[RangeAttribute] // RVA: 0x17EC50 Offset: 0x17ED51 VA: 0x17EC50
	public int renderFrameInterval; // 0x30
	[TooltipAttribute] // RVA: 0x17ECB0 Offset: 0x17EDB1 VA: 0x17ECB0
	[RangeAttribute] // RVA: 0x17ECB0 Offset: 0x17EDB1 VA: 0x17ECB0
	public int textureResolution; // 0x34

	// Methods

	// RVA: 0x2299BB0 Offset: 0x2299CB1 VA: 0x2299BB0
	private void Start() { }

	// RVA: 0x2299C30 Offset: 0x2299D31 VA: 0x2299C30
	private void Update() { }

	// RVA: 0x2299CA0 Offset: 0x2299DA1 VA: 0x2299CA0
	private void RenderOverheadCamera() { }

	// RVA: 0x2299EA0 Offset: 0x2299FA1 VA: 0x2299EA0
	private void PrepareRenderTexture() { }

	// RVA: 0x229A090 Offset: 0x229A191 VA: 0x229A090
	public void .ctor() { }
}

