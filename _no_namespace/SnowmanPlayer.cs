public class SnowmanPlayer : MonoBehaviour // TypeDefIndex: 7427
{
	// Fields
	private PlayerSnowball playerSnowball; // 0x18
	private const float INCREASE = 1.002;
	private float increasingDistance; // 0x20
	private float movement; // 0x24
	private Vector3 pastTrans; // 0x28

	// Properties
	public float Scale { get; }
	public bool EnableMove { get; }
	public bool IsSpeedUp { get; }
	public bool IsInvincible { get; set; }

	// Methods

	// RVA: 0x21116F0 Offset: 0x21117F1 VA: 0x21116F0
	public float get_Scale() { }

	// RVA: 0x2111710 Offset: 0x2111811 VA: 0x2111710
	public bool get_EnableMove() { }

	// RVA: 0x210E950 Offset: 0x210EA51 VA: 0x210E950
	public bool get_IsSpeedUp() { }

	// RVA: 0x2111730 Offset: 0x2111831 VA: 0x2111730
	public bool get_IsInvincible() { }

	// RVA: 0x21106E0 Offset: 0x21107E1 VA: 0x21106E0
	public void set_IsInvincible(bool value) { }

	// RVA: 0x2111750 Offset: 0x2111851 VA: 0x2111750
	private void Start() { }

	// RVA: 0x2111930 Offset: 0x2111A31 VA: 0x2111930
	private void Update() { }

	// RVA: 0x21117D0 Offset: 0x21118D1 VA: 0x21117D0
	private void CreatePlayerSnowball() { }

	// RVA: 0x2111AD0 Offset: 0x2111BD1 VA: 0x2111AD0
	public void .ctor() { }
}

