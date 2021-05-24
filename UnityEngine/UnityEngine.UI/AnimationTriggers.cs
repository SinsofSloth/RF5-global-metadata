[Serializable]
public class AnimationTriggers // TypeDefIndex: 3902
{
	// Fields
	private const string kDefaultNormalAnimName = "Normal";
	private const string kDefaultHighlightedAnimName = "Highlighted";
	private const string kDefaultPressedAnimName = "Pressed";
	private const string kDefaultSelectedAnimName = "Selected";
	private const string kDefaultDisabledAnimName = "Disabled";
	[FormerlySerializedAsAttribute] // RVA: 0x11ADE0 Offset: 0x11AEE1 VA: 0x11ADE0
	[SerializeField] // RVA: 0x11ADE0 Offset: 0x11AEE1 VA: 0x11ADE0
	private string m_NormalTrigger; // 0x10
	[FormerlySerializedAsAttribute] // RVA: 0x11AE30 Offset: 0x11AF31 VA: 0x11AE30
	[SerializeField] // RVA: 0x11AE30 Offset: 0x11AF31 VA: 0x11AE30
	private string m_HighlightedTrigger; // 0x18
	[FormerlySerializedAsAttribute] // RVA: 0x11AE80 Offset: 0x11AF81 VA: 0x11AE80
	[SerializeField] // RVA: 0x11AE80 Offset: 0x11AF81 VA: 0x11AE80
	private string m_PressedTrigger; // 0x20
	[FormerlySerializedAsAttribute] // RVA: 0x11AED0 Offset: 0x11AFD1 VA: 0x11AED0
	[SerializeField] // RVA: 0x11AED0 Offset: 0x11AFD1 VA: 0x11AED0
	private string m_SelectedTrigger; // 0x28
	[FormerlySerializedAsAttribute] // RVA: 0x11AF20 Offset: 0x11B021 VA: 0x11AF20
	[SerializeField] // RVA: 0x11AF20 Offset: 0x11B021 VA: 0x11AF20
	private string m_DisabledTrigger; // 0x30

	// Properties
	public string normalTrigger { get; set; }
	public string highlightedTrigger { get; set; }
	public string pressedTrigger { get; set; }
	public string selectedTrigger { get; set; }
	public string disabledTrigger { get; set; }

	// Methods

	// RVA: 0x1644840 Offset: 0x1644941 VA: 0x1644840
	public string get_normalTrigger() { }

	// RVA: 0x1644850 Offset: 0x1644951 VA: 0x1644850
	public void set_normalTrigger(string value) { }

	// RVA: 0x1644860 Offset: 0x1644961 VA: 0x1644860
	public string get_highlightedTrigger() { }

	// RVA: 0x1644870 Offset: 0x1644971 VA: 0x1644870
	public void set_highlightedTrigger(string value) { }

	// RVA: 0x1644880 Offset: 0x1644981 VA: 0x1644880
	public string get_pressedTrigger() { }

	// RVA: 0x1644890 Offset: 0x1644991 VA: 0x1644890
	public void set_pressedTrigger(string value) { }

	// RVA: 0x16448A0 Offset: 0x16449A1 VA: 0x16448A0
	public string get_selectedTrigger() { }

	// RVA: 0x16448B0 Offset: 0x16449B1 VA: 0x16448B0
	public void set_selectedTrigger(string value) { }

	// RVA: 0x16448C0 Offset: 0x16449C1 VA: 0x16448C0
	public string get_disabledTrigger() { }

	// RVA: 0x16448D0 Offset: 0x16449D1 VA: 0x16448D0
	public void set_disabledTrigger(string value) { }

	// RVA: 0x16448E0 Offset: 0x16449E1 VA: 0x16448E0
	public void .ctor() { }
}

