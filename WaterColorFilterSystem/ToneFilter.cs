[ExecuteInEditMode] // RVA: 0x14A7E0 Offset: 0x14A8E1 VA: 0x14A7E0
[RequireComponent] // RVA: 0x14A7E0 Offset: 0x14A8E1 VA: 0x14A7E0
public class ToneFilter : MonoBehaviour // TypeDefIndex: 10661
{
	// Fields
	public const string PROP_COLOR_WARM = "_ColorWarm";
	public const string PROP_COLOR_COOL = "_ColorCool";
	public const string PROP_TONE_POWER = "_TonePower";
	public const string PROP_LIGHT_DIR = "_LightDir";
	public Shader filter; // 0x18
	public Color warm; // 0x20
	public Color cool; // 0x30
	public float tonePower; // 0x40
	public Transform dirLight; // 0x48
	private Material _filterMat; // 0x50
	private Camera _cam; // 0x58

	// Methods

	// RVA: 0x1D06C50 Offset: 0x1D06D51 VA: 0x1D06C50
	private void OnEnable() { }

	// RVA: 0x1D06D10 Offset: 0x1D06E11 VA: 0x1D06D10
	private void OnDisable() { }

	// RVA: 0x1D06D80 Offset: 0x1D06E81 VA: 0x1D06D80
	private void OnRenderImage(RenderTexture src, RenderTexture dst) { }

	// RVA: 0x1D06F90 Offset: 0x1D07091 VA: 0x1D06F90
	public void .ctor() { }
}

