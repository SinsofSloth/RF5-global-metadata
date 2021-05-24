[ExecuteInEditMode] // RVA: 0x1435F0 Offset: 0x1436F1 VA: 0x1435F0
[RequireComponent] // RVA: 0x1435F0 Offset: 0x1436F1 VA: 0x1435F0
[AddComponentMenu] // RVA: 0x1435F0 Offset: 0x1436F1 VA: 0x1435F0
public class NoiseAndGrain : PostEffectsBase // TypeDefIndex: 6035
{
	// Fields
	public float intensityMultiplier; // 0x28
	public float generalIntensity; // 0x2C
	public float blackIntensity; // 0x30
	public float whiteIntensity; // 0x34
	public float midGrey; // 0x38
	public bool dx11Grain; // 0x3C
	public float softness; // 0x40
	public bool monochrome; // 0x44
	public Vector3 intensities; // 0x48
	public Vector3 tiling; // 0x54
	public float monochromeTiling; // 0x60
	public FilterMode filterMode; // 0x64
	public Texture2D noiseTexture; // 0x68
	public Shader noiseShader; // 0x70
	private Material noiseMaterial; // 0x78
	public Shader dx11NoiseShader; // 0x80
	private Material dx11NoiseMaterial; // 0x88
	private static float TILE_AMOUNT; // 0x0

	// Methods

	// RVA: 0x1A5C020 Offset: 0x1A5C121 VA: 0x1A5C020 Slot: 4
	public override bool CheckResources() { }

	// RVA: 0x1A5C1E0 Offset: 0x1A5C2E1 VA: 0x1A5C1E0
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x1A5CB10 Offset: 0x1A5CC11 VA: 0x1A5CB10
	private static void DrawNoiseQuadGrid(RenderTexture source, RenderTexture dest, Material fxMaterial, Texture2D noise, int passNr) { }

	// RVA: 0x1A5CEA0 Offset: 0x1A5CFA1 VA: 0x1A5CEA0
	public void .ctor() { }

	// RVA: 0x1A5CFC0 Offset: 0x1A5D0C1 VA: 0x1A5CFC0
	private static void .cctor() { }
}

