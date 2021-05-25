public class RecipeMenuRPBar : CursorEvent // TypeDefIndex: 8713
{
	// Fields
	[SerializeField] // RVA: 0x172A70 Offset: 0x172B71 VA: 0x172A70
	private Image HPGauge; // 0x18
	[SerializeField] // RVA: 0x172A80 Offset: 0x172B81 VA: 0x172A80
	private Text HPText; // 0x20
	[SerializeField] // RVA: 0x172A90 Offset: 0x172B91 VA: 0x172A90
	private Image RPGauge; // 0x28
	[SerializeField] // RVA: 0x172AA0 Offset: 0x172BA1 VA: 0x172AA0
	private Text RPText; // 0x30
	[SerializeField] // RVA: 0x172AB0 Offset: 0x172BB1 VA: 0x172AB0
	private Text SkillName; // 0x38
	[SerializeField] // RVA: 0x172AC0 Offset: 0x172BC1 VA: 0x172AC0
	private Text SkillLv; // 0x40
	[SerializeField] // RVA: 0x172AD0 Offset: 0x172BD1 VA: 0x172AD0
	private Text SkillPercent; // 0x48
	[SerializeField] // RVA: 0x172AE0 Offset: 0x172BE1 VA: 0x172AE0
	private Image SkillGauge; // 0x50
	private SkillID setSkillID; // 0x58
	private SkillID dispSkillID; // 0x5C

	// Methods

	// RVA: 0x1DAFA90 Offset: 0x1DAFB91 VA: 0x1DAFA90 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1DAFC30 Offset: 0x1DAFD31 VA: 0x1DAFC30 Slot: 7
	public override void OnFocusIn(CursorLinker focusObject) { }

	// RVA: 0x1DAFAC0 Offset: 0x1DAFBC1 VA: 0x1DAFAC0
	private void UpdateSkillParameter() { }

	// RVA: 0x1DAFDA0 Offset: 0x1DAFEA1 VA: 0x1DAFDA0
	private void LateUpdate() { }

	// RVA: 0x1DB0030 Offset: 0x1DB0131 VA: 0x1DB0030
	public void .ctor() { }
}

