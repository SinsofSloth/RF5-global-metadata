[ExecuteInEditMode] // RVA: 0x147910 Offset: 0x147A11 VA: 0x147910
public class TCP2_PlanarReflection : MonoBehaviour // TypeDefIndex: 8998
{
	// Fields
	public bool m_DisablePixelLights; // 0x18
	public int m_TextureSize; // 0x1C
	public float m_ClipPlaneOffset; // 0x20
	public LayerMask m_ReflectLayers; // 0x24
	private Hashtable m_ReflectionCameras; // 0x28
	private RenderTexture m_ReflectionTexture; // 0x30
	private int m_OldReflectionTextureSize; // 0x38
	private static bool s_InsideRendering; // 0x0

	// Methods

	// RVA: 0x1C73310 Offset: 0x1C73411 VA: 0x1C73310
	public void OnWillRenderObject() { }

	// RVA: 0x1C74730 Offset: 0x1C74831 VA: 0x1C74730
	private void OnDisable() { }

	// RVA: 0x1C73F80 Offset: 0x1C74081 VA: 0x1C73F80
	private void UpdateCameraModes(Camera src, Camera dest) { }

	// RVA: 0x1C73950 Offset: 0x1C73A51 VA: 0x1C73950
	private void CreateMirrorObjects(Camera currentCamera, out Camera reflectionCamera) { }

	// RVA: 0x1C74A90 Offset: 0x1C74B91 VA: 0x1C74A90
	private static float sgn(float a) { }

	// RVA: 0x1C74530 Offset: 0x1C74631 VA: 0x1C74530
	private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign) { }

	// RVA: 0x1C74280 Offset: 0x1C74381 VA: 0x1C74280
	private static void CalculateReflectionMatrix(ref Matrix4x4 reflectionMat, Vector4 plane) { }

	// RVA: 0x1C74AB0 Offset: 0x1C74BB1 VA: 0x1C74AB0
	public void .ctor() { }
}

