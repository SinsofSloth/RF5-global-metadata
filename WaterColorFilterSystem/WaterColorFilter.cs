[ExecuteInEditMode] // RVA: 0x14A860 Offset: 0x14A961 VA: 0x14A860
public class WaterColorFilter : MonoBehaviour // TypeDefIndex: 10662
{
	// Fields
	public const int PASS_WOBB = 0;
	public const int PASS_EDGE = 1;
	public const int PASS_PAPER = 2;
	public const string PROP_WOBB_TEX = "_WobbTex";
	public const string PROP_WOBB_TEX_SCALE = "_WobbScale";
	public const string PROP_WOBB_POWER = "_WobbPower";
	public const string PROP_EDGE_SIZE = "_EdgeSize";
	public const string PROP_EDGE_POWER = "_EdgePower";
	public const string PROP_PAPER_TEX = "_PaperTex";
	public const string PROP_PAPER_SCALE = "_PaperScale";
	public const string PROP_PAPER_POWER = "_PaperPower";
	public Shader filter; // 0x18
	public Texture wobbTex; // 0x20
	public float wobbScale; // 0x28
	public float wobbPower; // 0x2C
	public float edgeSize; // 0x30
	public float edgePower; // 0x34
	public WaterColorFilter.PaperData[] paperDataset; // 0x38
	private Material _filterMat; // 0x40

	// Methods

	// RVA: 0x1D06FA0 Offset: 0x1D070A1 VA: 0x1D06FA0
	private void OnEnable() { }

	// RVA: 0x1D07020 Offset: 0x1D07121 VA: 0x1D07020
	private void OnDisable() { }

	// RVA: 0x1D07090 Offset: 0x1D07191 VA: 0x1D07090
	private void OnRenderImage(RenderTexture src, RenderTexture dst) { }

	// RVA: 0x1D07490 Offset: 0x1D07591 VA: 0x1D07490
	private void Swap(ref RenderTexture src, ref RenderTexture dst) { }

	// RVA: 0x1D07580 Offset: 0x1D07681 VA: 0x1D07580
	public void .ctor() { }
}

