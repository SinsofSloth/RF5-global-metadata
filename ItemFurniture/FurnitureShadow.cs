public class FurnitureShadow : MonoBehaviour // TypeDefIndex: 10274
{
	// Fields
	[SerializeField] // RVA: 0x180D00 Offset: 0x180E01 VA: 0x180D00
	private Shader shadowShader; // 0x18
	[SerializeField] // RVA: 0x180D10 Offset: 0x180E11 VA: 0x180D10
	[RangeAttribute] // RVA: 0x180D10 Offset: 0x180E11 VA: 0x180D10
	private float shadowAlpha; // 0x20
	private BoxCollider box; // 0x28
	private bool shadowDisp; // 0x30
	private GameObject copied; // 0x38
	private bool isActive; // 0x40
	private bool isHit; // 0x41
	private Vector3[] pos_tbl_; // 0x48
	private Renderer _renderer; // 0x50
	private Material[] _materials; // 0x58
	private bool isFarmHit; // 0x60

	// Properties
	public bool Hit { get; }

	// Methods

	// RVA: 0x1F39880 Offset: 0x1F39981 VA: 0x1F39880
	public bool get_Hit() { }

	// RVA: 0x1F39890 Offset: 0x1F39991 VA: 0x1F39890
	private void Start() { }

	// RVA: 0x1F39960 Offset: 0x1F39A61 VA: 0x1F39960
	private void LateUpdate() { }

	// RVA: 0x1F3A030 Offset: 0x1F3A131 VA: 0x1F3A030
	private void SetAlpha(float alpha, bool red = False) { }

	// RVA: 0x1F3A200 Offset: 0x1F3A301 VA: 0x1F3A200
	public void FarmHit(bool hit) { }

	// RVA: 0x1F399B0 Offset: 0x1F39AB1 VA: 0x1F399B0
	public bool CheckHit() { }

	// RVA: 0x1F3A010 Offset: 0x1F3A111 VA: 0x1F3A010
	private void updateDisp() { }

	// RVA: 0x1F3A210 Offset: 0x1F3A311 VA: 0x1F3A210
	public void SetCollider(BoxCollider collider, GameObject original) { }

	// RVA: 0x1F3A860 Offset: 0x1F3A961 VA: 0x1F3A860
	public void OnPut() { }

	// RVA: 0x1F3A9F0 Offset: 0x1F3AAF1 VA: 0x1F3A9F0
	public void .ctor() { }
}

