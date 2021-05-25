public class UILogoControl : MonoBehaviour // TypeDefIndex: 8887
{
	// Fields
	private const float LOGO_TIME = 2;
	private const float LOGOBTN_TIME = 0.5;
	private const float FADE_TIME_S = 0.5;
	private const float STAY_TIME_S = 1;
	[SerializeField] // RVA: 0x1748C0 Offset: 0x1749C1 VA: 0x1748C0
	private Image LogoBg; // 0x18
	[SerializeField] // RVA: 0x1748D0 Offset: 0x1749D1 VA: 0x1748D0
	private Sprite[] m_CompanyImg; // 0x20
	[SerializeField] // RVA: 0x1748E0 Offset: 0x1749E1 VA: 0x1748E0
	private GameObject touchScreen; // 0x28
	private UILogoControl.MODE m_mode; // 0x30
	private float m_stayTime; // 0x34
	private bool m_touchBtn; // 0x38
	private int m_logoCnt; // 0x3C
	[CompilerGeneratedAttribute] // RVA: 0x1748F0 Offset: 0x1749F1 VA: 0x1748F0
	private static bool <IsEnd>k__BackingField; // 0x0

	// Properties
	public static bool IsEnd { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A8D10 Offset: 0x1A8E11 VA: 0x1A8D10
	// RVA: 0x1EDA060 Offset: 0x1EDA161 VA: 0x1EDA060
	public static bool get_IsEnd() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A8D20 Offset: 0x1A8E21 VA: 0x1A8D20
	// RVA: 0x1EDA0B0 Offset: 0x1EDA1B1 VA: 0x1EDA0B0
	private static void set_IsEnd(bool value) { }

	// RVA: 0x1EDA110 Offset: 0x1EDA211 VA: 0x1EDA110
	private void Start() { }

	// RVA: 0x1EDA260 Offset: 0x1EDA361 VA: 0x1EDA260
	private void Update() { }

	// RVA: 0x1EDA240 Offset: 0x1EDA341 VA: 0x1EDA240
	private void SetLogoImg(Sprite spr) { }

	// RVA: 0x1EDA780 Offset: 0x1EDA881 VA: 0x1EDA780
	private void OnLogoImg(bool flg) { }

	// RVA: 0x1EDA220 Offset: 0x1EDA321 VA: 0x1EDA220
	public void OnTouchScreen(bool flg) { }

	// RVA: 0x1EDA790 Offset: 0x1EDA891 VA: 0x1EDA790
	public void touchStartUpButton() { }

	// RVA: 0x1EDA7A0 Offset: 0x1EDA8A1 VA: 0x1EDA7A0
	public void .ctor() { }
}

