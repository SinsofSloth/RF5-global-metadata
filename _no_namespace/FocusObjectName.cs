public class FocusObjectName : MonoBehaviour // TypeDefIndex: 8532
{
	// Fields
	private readonly Color orange; // 0x18
	[SerializeField] // RVA: 0x170380 Offset: 0x170481 VA: 0x170380
	private Text Text; // 0x28
	[SerializeField] // RVA: 0x170390 Offset: 0x170491 VA: 0x170390
	private Image BorderImage; // 0x30
	[SerializeField] // RVA: 0x1703A0 Offset: 0x1704A1 VA: 0x1703A0
	private List<FocusObjectName.BorderElement> BorderElementList; // 0x38
	private Dictionary<FocusObjectType, FocusObjectName.BorderElement> BorderElementDic; // 0x40
	private RectTransform MyRect; // 0x48
	private RectTransform TextRect; // 0x50
	private Vector2 StartSize; // 0x58
	private Vector2 StartTextSize; // 0x60
	private Vector2 OriginalTextSize; // 0x68
	private List<Func<FocusInterface>> FindFocusObectFucList; // 0x70
	private Dictionary<FocusObjectType, Func<FocusInterface, Color>> GetTextColorFuncDic; // 0x78
	private FocusInterface CurrentFocusObect; // 0x80
	private string CurrentFocusName; // 0x88
	[CompilerGeneratedAttribute] // RVA: 0x1703B0 Offset: 0x1704B1 VA: 0x1703B0
	private bool <IsFocusing>k__BackingField; // 0x90
	private CharacterBase LockedTarget; // 0x98
	private FocusInterface LockedTargetFocusInterface; // 0xA0
	private Character EnemyController; // 0xA8
	private FocusInterface EnemyFocusInterface; // 0xB0
	private readonly Color COLOR_WHITE; // 0xB8
	private readonly Color COLOR_RED; // 0xC8
	private readonly Color COLOR_ORENGE; // 0xD8

	// Properties
	public bool IsFocusing { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A7B70 Offset: 0x1A7C71 VA: 0x1A7B70
	// RVA: 0x1D53990 Offset: 0x1D53A91 VA: 0x1D53990
	public bool get_IsFocusing() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7B80 Offset: 0x1A7C81 VA: 0x1A7B80
	// RVA: 0x1D539A0 Offset: 0x1D53AA1 VA: 0x1D539A0
	private void set_IsFocusing(bool value) { }

	// RVA: 0x1D539B0 Offset: 0x1D53AB1 VA: 0x1D539B0
	private void Awake() { }

	// RVA: 0x1D53CC0 Offset: 0x1D53DC1 VA: 0x1D53CC0
	private FocusInterface GetLockOnTarget() { }

	// RVA: 0x1D53F10 Offset: 0x1D54011 VA: 0x1D53F10
	private FocusInterface GetInteractionTarget() { }

	// RVA: 0x1D53F80 Offset: 0x1D54081 VA: 0x1D53F80
	private Color DefaultColor(FocusInterface focusInterface) { }

	// RVA: 0x1D53F90 Offset: 0x1D54091 VA: 0x1D53F90
	private Color EnemyColor(FocusInterface focusInterface) { }

	// RVA: 0x1D541C0 Offset: 0x1D542C1 VA: 0x1D541C0
	private void SetText(string text, Color color) { }

	// RVA: 0x1D54380 Offset: 0x1D54481 VA: 0x1D54380
	private void Start() { }

	// RVA: 0x1D54540 Offset: 0x1D54641 VA: 0x1D54540
	private void UpdateFocus(FocusInterface focusObect) { }

	// RVA: 0x1D54830 Offset: 0x1D54931 VA: 0x1D54830
	private void FocusOn() { }

	// RVA: 0x1D54480 Offset: 0x1D54581 VA: 0x1D54480
	private void FocusOff() { }

	// RVA: 0x1D548A0 Offset: 0x1D549A1 VA: 0x1D548A0
	private void Update() { }

	// RVA: 0x1D54A30 Offset: 0x1D54B31 VA: 0x1D54A30
	public void .ctor() { }
}

