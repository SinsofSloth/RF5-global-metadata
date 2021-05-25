[ExecuteInEditMode] // RVA: 0x143970 Offset: 0x143A71 VA: 0x143970
[RequireComponent] // RVA: 0x143970 Offset: 0x143A71 VA: 0x143970
[AddComponentMenu] // RVA: 0x143970 Offset: 0x143A71 VA: 0x143970
public class ScreenSpaceAmbientOcclusion : MonoBehaviour // TypeDefIndex: 6043
{
	// Fields
	[RangeAttribute] // RVA: 0x144350 Offset: 0x144451 VA: 0x144350
	public float m_Radius; // 0x18
	public ScreenSpaceAmbientOcclusion.SSAOSamples m_SampleCount; // 0x1C
	[RangeAttribute] // RVA: 0x144370 Offset: 0x144471 VA: 0x144370
	public float m_OcclusionIntensity; // 0x20
	[RangeAttribute] // RVA: 0x144390 Offset: 0x144491 VA: 0x144390
	public int m_Blur; // 0x24
	[RangeAttribute] // RVA: 0x1443B0 Offset: 0x1444B1 VA: 0x1443B0
	public int m_Downsampling; // 0x28
	[RangeAttribute] // RVA: 0x1443D0 Offset: 0x1444D1 VA: 0x1443D0
	public float m_OcclusionAttenuation; // 0x2C
	[RangeAttribute] // RVA: 0x1443F0 Offset: 0x1444F1 VA: 0x1443F0
	public float m_MinZ; // 0x30
	public Shader m_SSAOShader; // 0x38
	private Material m_SSAOMaterial; // 0x40
	public Texture2D m_RandomTexture; // 0x48
	private bool m_Supported; // 0x50

	// Methods

	// RVA: 0x1B6FDC0 Offset: 0x1B6FEC1 VA: 0x1B6FDC0
	private static Material CreateMaterial(Shader shader) { }

	// RVA: 0x1B6FE70 Offset: 0x1B6FF71 VA: 0x1B6FE70
	private static void DestroyMaterial(Material mat) { }

	// RVA: 0x1B6FF20 Offset: 0x1B70021 VA: 0x1B6FF20
	private void OnDisable() { }

	// RVA: 0x1B6FF30 Offset: 0x1B70031 VA: 0x1B6FF30
	private void Start() { }

	// RVA: 0x1B70110 Offset: 0x1B70211 VA: 0x1B70110
	private void OnEnable() { }

	// RVA: 0x1B70020 Offset: 0x1B70121 VA: 0x1B70020
	private void CreateMaterials() { }

	[ImageEffectOpaque] // RVA: 0x144AF0 Offset: 0x144BF1 VA: 0x144AF0
	// RVA: 0x1B70190 Offset: 0x1B70291 VA: 0x1B70190
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x1B70840 Offset: 0x1B70941 VA: 0x1B70840
	public void .ctor() { }
}

