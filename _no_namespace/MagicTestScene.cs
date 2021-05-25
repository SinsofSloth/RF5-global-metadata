public class MagicTestScene : MonoBehaviour // TypeDefIndex: 8203
{
	// Fields
	[SerializeField] // RVA: 0x16B7D0 Offset: 0x16B8D1 VA: 0x16B7D0
	private Camera m_camera; // 0x18
	[SerializeField] // RVA: 0x16B7E0 Offset: 0x16B8E1 VA: 0x16B7E0
	private Character m_chara; // 0x20
	[SerializeField] // RVA: 0x16B7F0 Offset: 0x16B8F1 VA: 0x16B7F0
	private Character m_target; // 0x28
	[SerializeField] // RVA: 0x16B800 Offset: 0x16B901 VA: 0x16B800
	private AnimationCurve m_curveTargetPosition; // 0x30
	[SerializeField] // RVA: 0x16B810 Offset: 0x16B911 VA: 0x16B810
	[RangeAttribute] // RVA: 0x16B810 Offset: 0x16B911 VA: 0x16B810
	private float m_targetPosition; // 0x38
	[SerializeField] // RVA: 0x16B850 Offset: 0x16B951 VA: 0x16B850
	private bool m_isMoveFrontBack; // 0x3C
	[SerializeField] // RVA: 0x16B860 Offset: 0x16B961 VA: 0x16B860
	private AnimationCurve m_curveMoveFrontBack; // 0x40
	[SerializeField] // RVA: 0x16B870 Offset: 0x16B971 VA: 0x16B870
	[RangeAttribute] // RVA: 0x16B870 Offset: 0x16B971 VA: 0x16B870
	private float m_speedMoveFrontBack; // 0x48
	[SerializeField] // RVA: 0x16B8B0 Offset: 0x16B9B1 VA: 0x16B8B0
	private bool m_isMoveLeftRight; // 0x4C
	[SerializeField] // RVA: 0x16B8C0 Offset: 0x16B9C1 VA: 0x16B8C0
	private AnimationCurve m_curveMoveLeftRight; // 0x50
	[SerializeField] // RVA: 0x16B8D0 Offset: 0x16B9D1 VA: 0x16B8D0
	[RangeAttribute] // RVA: 0x16B8D0 Offset: 0x16B9D1 VA: 0x16B8D0
	private float m_speedMoveLeftRight; // 0x58
	[SerializeField] // RVA: 0x16B910 Offset: 0x16BA11 VA: 0x16B910
	private GameObject m_panel; // 0x60
	[SerializeField] // RVA: 0x16B920 Offset: 0x16BA21 VA: 0x16B920
	private Dropdown m_magic; // 0x68
	[SerializeField] // RVA: 0x16B930 Offset: 0x16BA31 VA: 0x16B930
	private ScrollRect m_magicSelect; // 0x70
	[SerializeField] // RVA: 0x16B940 Offset: 0x16BA41 VA: 0x16B940
	private MagicTestButton m_magicButtonBase; // 0x78
	private MagicTestScene.Mode m_mode; // 0x80
	private float m_elapsedMoveFrontBack; // 0x84
	private float m_elapsedMovLeftRight; // 0x88
	private Quaternion m_cameraRotate; // 0x8C

	// Methods

	// RVA: 0x1E0FA10 Offset: 0x1E0FB11 VA: 0x1E0FA10
	private void Awake() { }

	// RVA: 0x1E0FEA0 Offset: 0x1E0FFA1 VA: 0x1E0FEA0
	private void Update() { }

	// RVA: 0x1E0FB90 Offset: 0x1E0FC91 VA: 0x1E0FB90
	private void InitCamera() { }

	// RVA: 0x1E102B0 Offset: 0x1E103B1 VA: 0x1E102B0
	private void UpdateCamera() { }

	// RVA: 0x1E10780 Offset: 0x1E10881 VA: 0x1E10780
	public void OnMagicPlay() { }

	// RVA: 0x1E108A0 Offset: 0x1E109A1 VA: 0x1E108A0
	public void OnChangePosition(float value) { }

	// RVA: 0x1E108B0 Offset: 0x1E109B1 VA: 0x1E108B0
	public void OnChangeMoveFrontBack(bool value) { }

	// RVA: 0x1E108C0 Offset: 0x1E109C1 VA: 0x1E108C0
	public void OnChangeMoveSpeedFrontBack(float value) { }

	// RVA: 0x1E108D0 Offset: 0x1E109D1 VA: 0x1E108D0
	public void OnChangeMoveSpeedLeftRight(float value) { }

	// RVA: 0x1E108E0 Offset: 0x1E109E1 VA: 0x1E108E0
	public void OnChangeMoveLeftRight(bool value) { }

	// RVA: 0x1E108F0 Offset: 0x1E109F1 VA: 0x1E108F0
	public void .ctor() { }
}

