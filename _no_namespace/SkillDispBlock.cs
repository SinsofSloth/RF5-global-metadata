public class SkillDispBlock : UIButtonLinkerInScrollBox // TypeDefIndex: 8718
{
	// Fields
	[SerializeField] // RVA: 0x172B60 Offset: 0x172C61 VA: 0x172B60
	private Image NoSelectBorder; // 0x70
	[SerializeField] // RVA: 0x172B70 Offset: 0x172C71 VA: 0x172B70
	private Image SelectedBorder; // 0x78
	[SerializeField] // RVA: 0x172B80 Offset: 0x172C81 VA: 0x172B80
	private Text SkillNameText; // 0x80
	[SerializeField] // RVA: 0x172B90 Offset: 0x172C91 VA: 0x172B90
	private Text SkillLvText; // 0x88
	[SerializeField] // RVA: 0x172BA0 Offset: 0x172CA1 VA: 0x172BA0
	private Image SkillGauge; // 0x90
	[SerializeField] // RVA: 0x172BB0 Offset: 0x172CB1 VA: 0x172BB0
	private Text SkillExpPercent; // 0x98

	// Methods

	// RVA: 0x1C53A20 Offset: 0x1C53B21 VA: 0x1C53A20 Slot: 16
	public override void Init() { }

	// RVA: 0x1C53A30 Offset: 0x1C53B31 VA: 0x1C53A30 Slot: 10
	public override void OnFocus() { }

	// RVA: 0x1C53AF0 Offset: 0x1C53BF1 VA: 0x1C53AF0 Slot: 11
	public override void EndFocus() { }

	// RVA: 0x1C53BB0 Offset: 0x1C53CB1 VA: 0x1C53BB0
	public void Disp(PlayerSkillBase _skill) { }

	// RVA: 0x1C53DC0 Offset: 0x1C53EC1 VA: 0x1C53DC0
	public void .ctor() { }
}

