public class HUDBadStatusIconDisp : MonoBehaviour // TypeDefIndex: 8537
{
	// Fields
	private static readonly BadStatus[] BadStatusConvertTable; // 0x0
	private List<BadStatus> badStatuses; // 0x18
	public Image[] BadStatusIconImage; // 0x20
	[SerializeField] // RVA: 0x1704A0 Offset: 0x1705A1 VA: 0x1704A0
	private Sprite[] BadStatusIconSprites; // 0x28
	private List<HUDBadStatusIconDisp.BadStatusIconList> badStatusIconLists; // 0x30
	private List<Image> BadStatusIcons; // 0x38
	private uint NowFlagStatus; // 0x40

	// Methods

	// RVA: 0x1EB66A0 Offset: 0x1EB67A1 VA: 0x1EB66A0
	private void Redraw(uint flagStat) { }

	// RVA: 0x1EB69F0 Offset: 0x1EB6AF1 VA: 0x1EB69F0
	public void UpdateBadStatus(CharacterStatusBase statusController) { }

	// RVA: 0x1EB6AE0 Offset: 0x1EB6BE1 VA: 0x1EB6AE0
	public void SetCharacter(CharacterStatusBase statusController) { }

	// RVA: 0x1EB6BB0 Offset: 0x1EB6CB1 VA: 0x1EB6BB0
	public void .ctor() { }

	// RVA: 0x1EB6C20 Offset: 0x1EB6D21 VA: 0x1EB6C20
	private static void .cctor() { }
}

