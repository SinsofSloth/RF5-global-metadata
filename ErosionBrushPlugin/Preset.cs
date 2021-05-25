[Serializable]
public class Preset // TypeDefIndex: 9705
{
	// Fields
	public float brushSize; // 0x10
	public float brushFallof; // 0x14
	public float brushSpacing; // 0x18
	public int downscale; // 0x1C
	public float blur; // 0x20
	public bool preserveDetail; // 0x24
	public bool isErosion; // 0x25
	public bool isNoise; // 0x26
	public int noise_seed; // 0x28
	public float noise_amount; // 0x2C
	public float noise_size; // 0x30
	public float noise_detail; // 0x34
	public float noise_uplift; // 0x38
	public float noise_ruffle; // 0x3C
	public int erosion_iterations; // 0x40
	public float erosion_durability; // 0x44
	public int erosion_fluidityIterations; // 0x48
	public float erosion_amount; // 0x4C
	public float sediment_amount; // 0x50
	public float wind_amount; // 0x54
	public float erosion_smooth; // 0x58
	public float ruffle; // 0x5C
	public Preset.SplatPreset foreground; // 0x60
	public Preset.SplatPreset background; // 0x6C
	public string name; // 0x78
	public bool saveBrushSize; // 0x80
	public bool saveBrushParams; // 0x81
	public bool saveErosionNoiseParams; // 0x82
	public bool saveSplatParams; // 0x83

	// Properties
	public bool paintSplat { get; }

	// Methods

	// RVA: 0x1C17D40 Offset: 0x1C17E41 VA: 0x1C17D40
	public bool get_paintSplat() { }

	// RVA: 0x1C17D90 Offset: 0x1C17E91 VA: 0x1C17D90
	public Preset Copy() { }

	// RVA: 0x1C17E20 Offset: 0x1C17F21 VA: 0x1C17E20
	public void .ctor() { }
}

