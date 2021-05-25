public static class DefaultControls // TypeDefIndex: 3915
{
	// Fields
	private static DefaultControls.IFactoryControls m_CurrentFactory; // 0x0
	private const float kWidth = 160;
	private const float kThickHeight = 30;
	private const float kThinHeight = 20;
	private static Vector2 s_ThickElementSize; // 0x8
	private static Vector2 s_ThinElementSize; // 0x10
	private static Vector2 s_ImageElementSize; // 0x18
	private static Color s_DefaultSelectableColor; // 0x20
	private static Color s_PanelColor; // 0x30
	private static Color s_TextColor; // 0x40

	// Properties
	public static DefaultControls.IFactoryControls factory { get; }

	// Methods

	// RVA: 0x164A3D0 Offset: 0x164A4D1 VA: 0x164A3D0
	public static DefaultControls.IFactoryControls get_factory() { }

	// RVA: 0x164A440 Offset: 0x164A541 VA: 0x164A440
	private static GameObject CreateUIElementRoot(string name, Vector2 size, Type[] components) { }

	// RVA: 0x164A5E0 Offset: 0x164A6E1 VA: 0x164A5E0
	private static GameObject CreateUIObject(string name, GameObject parent, Type[] components) { }

	// RVA: 0x164A870 Offset: 0x164A971 VA: 0x164A870
	private static void SetDefaultTextValues(Text lbl) { }

	// RVA: 0x164A910 Offset: 0x164AA11 VA: 0x164A910
	private static void SetDefaultColorTransitionValues(Selectable slider) { }

	// RVA: 0x164A760 Offset: 0x164A861 VA: 0x164A760
	private static void SetParentAndAlign(GameObject child, GameObject parent) { }

	// RVA: 0x164A990 Offset: 0x164AA91 VA: 0x164A990
	private static void SetLayerRecursively(GameObject go, int layer) { }

	// RVA: 0x164AA90 Offset: 0x164AB91 VA: 0x164AA90
	public static GameObject CreatePanel(DefaultControls.Resources resources) { }

	// RVA: 0x164ACC0 Offset: 0x164ADC1 VA: 0x164ACC0
	public static GameObject CreateButton(DefaultControls.Resources resources) { }

	// RVA: 0x164B080 Offset: 0x164B181 VA: 0x164B080
	public static GameObject CreateText(DefaultControls.Resources resources) { }

	// RVA: 0x164B200 Offset: 0x164B301 VA: 0x164B200
	public static GameObject CreateImage(DefaultControls.Resources resources) { }

	// RVA: 0x164B330 Offset: 0x164B431 VA: 0x164B330
	public static GameObject CreateRawImage(DefaultControls.Resources resources) { }

	// RVA: 0x164B460 Offset: 0x164B561 VA: 0x164B460
	public static GameObject CreateSlider(DefaultControls.Resources resources) { }

	// RVA: 0x164BC40 Offset: 0x164BD41 VA: 0x164BC40
	public static GameObject CreateScrollbar(DefaultControls.Resources resources) { }

	// RVA: 0x164C0F0 Offset: 0x164C1F1 VA: 0x164C0F0
	public static GameObject CreateToggle(DefaultControls.Resources resources) { }

	// RVA: 0x164C760 Offset: 0x164C861 VA: 0x164C760
	public static GameObject CreateInputField(DefaultControls.Resources resources) { }

	// RVA: 0x164CD20 Offset: 0x164CE21 VA: 0x164CD20
	public static GameObject CreateDropdown(DefaultControls.Resources resources) { }

	// RVA: 0x164E290 Offset: 0x164E391 VA: 0x164E290
	public static GameObject CreateScrollView(DefaultControls.Resources resources) { }

	// RVA: 0x164E9C0 Offset: 0x164EAC1 VA: 0x164E9C0
	private static void .cctor() { }
}

