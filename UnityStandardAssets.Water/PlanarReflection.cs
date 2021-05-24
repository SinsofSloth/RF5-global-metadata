[ExecuteInEditMode] // RVA: 0x142950 Offset: 0x142A51 VA: 0x142950
[RequireComponent] // RVA: 0x142950 Offset: 0x142A51 VA: 0x142950
public class PlanarReflection : MonoBehaviour // TypeDefIndex: 5984
{
	// Fields
	public LayerMask reflectionMask; // 0x18
	public bool reflectSkybox; // 0x1C
	public Color clearColor; // 0x20
	public string reflectionSampler; // 0x30
	public float clipPlaneOffset; // 0x38
	private Vector3 m_Oldpos; // 0x3C
	private Camera m_ReflectionCamera; // 0x48
	private Material m_SharedMaterial; // 0x50
	private Dictionary<Camera, bool> m_HelperCameras; // 0x58

	// Methods

	// RVA: 0x1B73D50 Offset: 0x1B73E51 VA: 0x1B73D50
	public void Start() { }

	// RVA: 0x1B73E40 Offset: 0x1B73F41 VA: 0x1B73E40
	private Camera CreateReflectionCameraFor(Camera cam) { }

	// RVA: 0x1B74180 Offset: 0x1B74281 VA: 0x1B74180
	private void SetStandardCameraParameter(Camera cam, LayerMask mask) { }

	// RVA: 0x1B74230 Offset: 0x1B74331 VA: 0x1B74230
	private RenderTexture CreateTextureFor(Camera cam) { }

	// RVA: 0x1B74330 Offset: 0x1B74431 VA: 0x1B74330
	public void RenderHelpCameras(Camera currentCam) { }

	// RVA: 0x1B74D10 Offset: 0x1B74E11 VA: 0x1B74D10
	public void LateUpdate() { }

	// RVA: 0x1B74D70 Offset: 0x1B74E71 VA: 0x1B74D70
	public void WaterTileBeingRendered(Transform tr, Camera currentCam) { }

	// RVA: 0x1B74E90 Offset: 0x1B74F91 VA: 0x1B74E90
	public void OnEnable() { }

	// RVA: 0x1B74EF0 Offset: 0x1B74FF1 VA: 0x1B74EF0
	public void OnDisable() { }

	// RVA: 0x1B744B0 Offset: 0x1B745B1 VA: 0x1B744B0
	private void RenderReflectionFor(Camera cam, Camera reflectCamera) { }

	// RVA: 0x1B74F50 Offset: 0x1B75051 VA: 0x1B74F50
	private void SaneCameraSettings(Camera helperCam) { }

	// RVA: 0x1B75490 Offset: 0x1B75591 VA: 0x1B75490
	private static Matrix4x4 CalculateObliqueMatrix(Matrix4x4 projection, Vector4 clipPlane) { }

	// RVA: 0x1B74FC0 Offset: 0x1B750C1 VA: 0x1B74FC0
	private static Matrix4x4 CalculateReflectionMatrix(Matrix4x4 reflectionMat, Vector4 plane) { }

	// RVA: 0x1B756F0 Offset: 0x1B757F1 VA: 0x1B756F0
	private static float Sgn(float a) { }

	// RVA: 0x1B75290 Offset: 0x1B75391 VA: 0x1B75290
	private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign) { }

	// RVA: 0x1B75710 Offset: 0x1B75811 VA: 0x1B75710
	public void .ctor() { }
}

