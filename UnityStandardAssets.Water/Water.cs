[ExecuteInEditMode] // RVA: 0x142A50 Offset: 0x142B51 VA: 0x142A50
public class Water : MonoBehaviour // TypeDefIndex: 5986
{
	// Fields
	public Water.WaterMode waterMode; // 0x18
	public bool disablePixelLights; // 0x1C
	public int textureSize; // 0x20
	public float clipPlaneOffset; // 0x24
	public LayerMask reflectLayers; // 0x28
	public LayerMask refractLayers; // 0x2C
	private Dictionary<Camera, Camera> m_ReflectionCameras; // 0x30
	private Dictionary<Camera, Camera> m_RefractionCameras; // 0x38
	private RenderTexture m_ReflectionTexture; // 0x40
	private RenderTexture m_RefractionTexture; // 0x48
	private Water.WaterMode m_HardwareWaterSupport; // 0x50
	private int m_OldReflectionTextureSize; // 0x54
	private int m_OldRefractionTextureSize; // 0x58
	private static bool s_InsideWater; // 0x0

	// Methods

	// RVA: 0x1B75B30 Offset: 0x1B75C31 VA: 0x1B75B30
	public void OnWillRenderObject() { }

	// RVA: 0x1B77830 Offset: 0x1B77931 VA: 0x1B77830
	private void OnDisable() { }

	// RVA: 0x1B77B90 Offset: 0x1B77C91 VA: 0x1B77B90
	private void Update() { }

	// RVA: 0x1B77110 Offset: 0x1B77211 VA: 0x1B77110
	private void UpdateCameraModes(Camera src, Camera dest) { }

	// RVA: 0x1B765B0 Offset: 0x1B766B1 VA: 0x1B765B0
	private void CreateWaterObjects(Camera currentCamera, out Camera reflectionCamera, out Camera refractionCamera) { }

	// RVA: 0x1B76590 Offset: 0x1B76691 VA: 0x1B76590
	private Water.WaterMode GetWaterMode() { }

	// RVA: 0x1B76400 Offset: 0x1B76501 VA: 0x1B76400
	private Water.WaterMode FindHardwareWaterSupport() { }

	// RVA: 0x1B77630 Offset: 0x1B77731 VA: 0x1B77630
	private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign) { }

	// RVA: 0x1B77380 Offset: 0x1B77481 VA: 0x1B77380
	private static void CalculateReflectionMatrix(ref Matrix4x4 reflectionMat, Vector4 plane) { }

	// RVA: 0x1B77E40 Offset: 0x1B77F41 VA: 0x1B77E40
	public void .ctor() { }
}

