[ExecuteInEditMode] // RVA: 0x143690 Offset: 0x143791 VA: 0x143690
[RequireComponent] // RVA: 0x143690 Offset: 0x143791 VA: 0x143690
[AddComponentMenu] // RVA: 0x143690 Offset: 0x143791 VA: 0x143690
public class NoiseAndScratches : MonoBehaviour // TypeDefIndex: 6036
{
	// Fields
	public bool monochrome; // 0x18
	private bool rgbFallback; // 0x19
	[RangeAttribute] // RVA: 0x1441D0 Offset: 0x1442D1 VA: 0x1441D0
	public float grainIntensityMin; // 0x1C
	[RangeAttribute] // RVA: 0x1441F0 Offset: 0x1442F1 VA: 0x1441F0
	public float grainIntensityMax; // 0x20
	[RangeAttribute] // RVA: 0x144210 Offset: 0x144311 VA: 0x144210
	public float grainSize; // 0x24
	[RangeAttribute] // RVA: 0x144230 Offset: 0x144331 VA: 0x144230
	public float scratchIntensityMin; // 0x28
	[RangeAttribute] // RVA: 0x144250 Offset: 0x144351 VA: 0x144250
	public float scratchIntensityMax; // 0x2C
	[RangeAttribute] // RVA: 0x144270 Offset: 0x144371 VA: 0x144270
	public float scratchFPS; // 0x30
	[RangeAttribute] // RVA: 0x144290 Offset: 0x144391 VA: 0x144290
	public float scratchJitter; // 0x34
	public Texture grainTexture; // 0x38
	public Texture scratchTexture; // 0x40
	public Shader shaderRGB; // 0x48
	public Shader shaderYUV; // 0x50
	private Material m_MaterialRGB; // 0x58
	private Material m_MaterialYUV; // 0x60
	private float scratchTimeLeft; // 0x68
	private float scratchX; // 0x6C
	private float scratchY; // 0x70

	// Properties
	protected Material material { get; }

	// Methods

	// RVA: 0x1A5D020 Offset: 0x1A5D121 VA: 0x1A5D020
	protected void Start() { }

	// RVA: 0x1A5D160 Offset: 0x1A5D261 VA: 0x1A5D160
	protected Material get_material() { }

	// RVA: 0x1A5D2E0 Offset: 0x1A5D3E1 VA: 0x1A5D2E0
	protected void OnDisable() { }

	// RVA: 0x1A5D410 Offset: 0x1A5D511 VA: 0x1A5D410
	private void SanitizeParameters() { }

	// RVA: 0x1A5D540 Offset: 0x1A5D641 VA: 0x1A5D540
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x1A5D880 Offset: 0x1A5D981 VA: 0x1A5D880
	public void .ctor() { }
}

