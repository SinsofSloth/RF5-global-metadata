[ExecuteInEditMode] // RVA: 0x145120 Offset: 0x145221 VA: 0x145120
[RequireComponent] // RVA: 0x145120 Offset: 0x145221 VA: 0x145120
[AddComponentMenu] // RVA: 0x145120 Offset: 0x145221 VA: 0x145120
public class FxPro : MonoBehaviour // TypeDefIndex: 6101
{
	// Fields
	public EffectsQuality Quality; // 0x18
	private static Material _mat; // 0x0
	private static Material _tapMat; // 0x8
	private Camera _effectCamera; // 0x20
	public bool BloomEnabled; // 0x28
	public BloomHelperParams BloomParams; // 0x30
	public bool VisualizeBloom; // 0x38
	public Texture2D LensDirtTexture; // 0x40
	[RangeAttribute] // RVA: 0x15B690 Offset: 0x15B791 VA: 0x15B690
	public float LensDirtIntensity; // 0x48
	public bool ChromaticAberration; // 0x4C
	public bool ChromaticAberrationPrecise; // 0x4D
	[RangeAttribute] // RVA: 0x15B6B0 Offset: 0x15B7B1 VA: 0x15B6B0
	public float ChromaticAberrationOffset; // 0x50
	[RangeAttribute] // RVA: 0x15B6D0 Offset: 0x15B7D1 VA: 0x15B6D0
	public float SCurveIntensity; // 0x54
	public bool LensCurvatureEnabled; // 0x58
	[RangeAttribute] // RVA: 0x15B6F0 Offset: 0x15B7F1 VA: 0x15B6F0
	public float LensCurvaturePower; // 0x5C
	public bool LensCurvaturePrecise; // 0x60
	[RangeAttribute] // RVA: 0x15B710 Offset: 0x15B811 VA: 0x15B710
	public float FilmGrainIntensity; // 0x64
	[RangeAttribute] // RVA: 0x15B730 Offset: 0x15B831 VA: 0x15B730
	public float FilmGrainTiling; // 0x68
	[RangeAttribute] // RVA: 0x15B750 Offset: 0x15B851 VA: 0x15B750
	public float VignettingIntensity; // 0x6C
	public bool DOFEnabled; // 0x70
	public bool BlurCOCTexture; // 0x71
	public DOFHelperParams DOFParams; // 0x78
	public bool VisualizeCOC; // 0x80
	private List<Texture2D> _filmGrainTextures; // 0x88
	public bool ColorEffectsEnabled; // 0x90
	public Color CloseTint; // 0x94
	public Color FarTint; // 0xA4
	[RangeAttribute] // RVA: 0x15B770 Offset: 0x15B871 VA: 0x15B770
	public float CloseTintStrength; // 0xB4
	[RangeAttribute] // RVA: 0x15B790 Offset: 0x15B891 VA: 0x15B790
	public float FarTintStrength; // 0xB8
	[RangeAttribute] // RVA: 0x15B7B0 Offset: 0x15B8B1 VA: 0x15B7B0
	public float DesaturateDarksStrength; // 0xBC
	[RangeAttribute] // RVA: 0x15B7D0 Offset: 0x15B8D1 VA: 0x15B7D0
	public float DesaturateFarObjsStrength; // 0xC0
	public Color FogTint; // 0xC4
	[RangeAttribute] // RVA: 0x15B7F0 Offset: 0x15B8F1 VA: 0x15B7F0
	public float FogStrength; // 0xD4
	public bool HalfResolution; // 0xD8

	// Properties
	public static Material Mat { get; }
	private static Material TapMat { get; }
	private Camera EffectCamera { get; }

	// Methods

	// RVA: 0x229AFD0 Offset: 0x229B0D1 VA: 0x229AFD0
	public static Material get_Mat() { }

	// RVA: 0x229B0D0 Offset: 0x229B1D1 VA: 0x229B0D0
	private static Material get_TapMat() { }

	// RVA: 0x229B1D0 Offset: 0x229B2D1 VA: 0x229B1D0
	private Camera get_EffectCamera() { }

	// RVA: 0x229B280 Offset: 0x229B381 VA: 0x229B280
	public void Start() { }

	// RVA: 0x229B780 Offset: 0x229B881 VA: 0x229B780
	public void Init(bool searchForNonDepthmapAlphaObjects = False) { }

	// RVA: 0x229CC10 Offset: 0x229CD11 VA: 0x229CC10
	public void OnEnable() { }

	// RVA: 0x229CC20 Offset: 0x229CD21 VA: 0x229CC20
	public void OnDisable() { }

	// RVA: 0x229D190 Offset: 0x229D291 VA: 0x229D190
	public void OnValidate() { }

	// RVA: 0x229D1A0 Offset: 0x229D2A1 VA: 0x229D1A0
	public static RenderTexture DownsampleTex(RenderTexture input, float downsampleBy) { }

	// RVA: 0x229D810 Offset: 0x229D911 VA: 0x229D810
	private RenderTexture ApplyColorEffects(RenderTexture input) { }

	// RVA: 0x229D990 Offset: 0x229DA91 VA: 0x229D990
	private RenderTexture ApplyLensCurvature(RenderTexture input) { }

	// RVA: 0x229DB20 Offset: 0x229DC21 VA: 0x229DB20
	private RenderTexture ApplyChromaticAberration(RenderTexture input) { }

	// RVA: 0x229DCD0 Offset: 0x229DDD1 VA: 0x229DCD0
	private Vector2 ApplyLensCurvature(Vector2 uv, float barrelPower, bool precise) { }

	// RVA: 0x229CB60 Offset: 0x229CC61 VA: 0x229CB60
	private void UpdateLensCurvatureZoom() { }

	// RVA: 0x229E040 Offset: 0x229E141 VA: 0x229E040
	private void UpdateFilmGrain() { }

	// RVA: 0x229E220 Offset: 0x229E321 VA: 0x229E220
	private void RenderEffects(RenderTexture source, RenderTexture destination) { }

	[ImageEffectTransformsToLDR] // RVA: 0x19A320 Offset: 0x19A421 VA: 0x19A320
	// RVA: 0x229FE80 Offset: 0x229FF81 VA: 0x229FE80
	public void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x22A0050 Offset: 0x22A0151 VA: 0x22A0050
	public void .ctor() { }
}

