public class MeshFadeController : MonoBehaviour // TypeDefIndex: 6823
{
	// Fields
	[SerializeField] // RVA: 0x15FBB0 Offset: 0x15FCB1 VA: 0x15FBB0
	[RangeAttribute] // RVA: 0x15FBB0 Offset: 0x15FCB1 VA: 0x15FBB0
	private float m_FadeAlpha; // 0x18
	[SerializeField] // RVA: 0x15FBF0 Offset: 0x15FCF1 VA: 0x15FBF0
	public Renderer[] Renderers; // 0x20
	protected MaterialPropertyBlock materialPropertyBlock; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x15FC00 Offset: 0x15FD01 VA: 0x15FC00
	private float <MeshAlpha>k__BackingField; // 0x30

	// Properties
	public float FadeAlpha { get; }
	public float MeshAlpha { get; set; }

	// Methods

	// RVA: 0x1E1E420 Offset: 0x1E1E521 VA: 0x1E1E420
	public float get_FadeAlpha() { }

	[CompilerGeneratedAttribute] // RVA: 0x19D2D0 Offset: 0x19D3D1 VA: 0x19D2D0
	// RVA: 0x1E1E430 Offset: 0x1E1E531 VA: 0x1E1E430
	public float get_MeshAlpha() { }

	[CompilerGeneratedAttribute] // RVA: 0x19D2E0 Offset: 0x19D3E1 VA: 0x19D2E0
	// RVA: 0x1E1E440 Offset: 0x1E1E541 VA: 0x1E1E440
	private void set_MeshAlpha(float value) { }

	// RVA: 0x1E1E450 Offset: 0x1E1E551 VA: 0x1E1E450
	private void Awake() { }

	// RVA: 0x1E1E550 Offset: 0x1E1E651 VA: 0x1E1E550
	private void OnEnable() { }

	// RVA: 0x1E1E4D0 Offset: 0x1E1E5D1 VA: 0x1E1E4D0
	private void Init() { }

	// RVA: 0x1E1E5D0 Offset: 0x1E1E6D1 VA: 0x1E1E5D0
	public void Reset() { }

	// RVA: 0x1E1E6C0 Offset: 0x1E1E7C1 VA: 0x1E1E6C0
	public void SetRenderer(Renderer[] renderers) { }

	// RVA: 0x1E1E6D0 Offset: 0x1E1E7D1 VA: 0x1E1E6D0
	public void OnUpdate() { }

	// RVA: 0x1E1E800 Offset: 0x1E1E901 VA: 0x1E1E800
	public void SetFadeAlpha(float alpha) { }

	// RVA: 0x1E1E8B0 Offset: 0x1E1E9B1 VA: 0x1E1E8B0
	public void .ctor() { }
}

