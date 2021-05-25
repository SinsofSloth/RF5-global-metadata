[ExecuteInEditMode] // RVA: 0x143020 Offset: 0x143121 VA: 0x143020
[AddComponentMenu] // RVA: 0x143020 Offset: 0x143121 VA: 0x143020
public class ContrastStretch : MonoBehaviour // TypeDefIndex: 6017
{
	// Fields
	[RangeAttribute] // RVA: 0x143F50 Offset: 0x144051 VA: 0x143F50
	public float adaptationSpeed; // 0x18
	[RangeAttribute] // RVA: 0x143F70 Offset: 0x144071 VA: 0x143F70
	public float limitMinimum; // 0x1C
	[RangeAttribute] // RVA: 0x143F90 Offset: 0x144091 VA: 0x143F90
	public float limitMaximum; // 0x20
	private RenderTexture[] adaptRenderTex; // 0x28
	private int curAdaptIndex; // 0x30
	public Shader shaderLum; // 0x38
	private Material m_materialLum; // 0x40
	public Shader shaderReduce; // 0x48
	private Material m_materialReduce; // 0x50
	public Shader shaderAdapt; // 0x58
	private Material m_materialAdapt; // 0x60
	public Shader shaderApply; // 0x68
	private Material m_materialApply; // 0x70

	// Properties
	protected Material materialLum { get; }
	protected Material materialReduce { get; }
	protected Material materialAdapt { get; }
	protected Material materialApply { get; }

	// Methods

	// RVA: 0x1A548C0 Offset: 0x1A549C1 VA: 0x1A548C0
	protected Material get_materialLum() { }

	// RVA: 0x1A549A0 Offset: 0x1A54AA1 VA: 0x1A549A0
	protected Material get_materialReduce() { }

	// RVA: 0x1A54A80 Offset: 0x1A54B81 VA: 0x1A54A80
	protected Material get_materialAdapt() { }

	// RVA: 0x1A54B60 Offset: 0x1A54C61 VA: 0x1A54B60
	protected Material get_materialApply() { }

	// RVA: 0x1A54C40 Offset: 0x1A54D41 VA: 0x1A54C40
	private void Start() { }

	// RVA: 0x1A54CE0 Offset: 0x1A54DE1 VA: 0x1A54CE0
	private void OnEnable() { }

	// RVA: 0x1A54F10 Offset: 0x1A55011 VA: 0x1A54F10
	private void OnDisable() { }

	// RVA: 0x1A551D0 Offset: 0x1A552D1 VA: 0x1A551D0
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x1A55430 Offset: 0x1A55531 VA: 0x1A55430
	private void CalculateAdaptation(Texture curTexture) { }

	// RVA: 0x1A55640 Offset: 0x1A55741 VA: 0x1A55640
	public void .ctor() { }
}

