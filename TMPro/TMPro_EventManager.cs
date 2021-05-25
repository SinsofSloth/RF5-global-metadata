public static class TMPro_EventManager // TypeDefIndex: 5884
{
	// Fields
	public static readonly FastAction<object, Compute_DT_EventArgs> COMPUTE_DT_EVENT; // 0x0
	public static readonly FastAction<bool, Material> MATERIAL_PROPERTY_EVENT; // 0x8
	public static readonly FastAction<bool, Object> FONT_PROPERTY_EVENT; // 0x10
	public static readonly FastAction<bool, Object> SPRITE_ASSET_PROPERTY_EVENT; // 0x18
	public static readonly FastAction<bool, Object> TEXTMESHPRO_PROPERTY_EVENT; // 0x20
	public static readonly FastAction<GameObject, Material, Material> DRAG_AND_DROP_MATERIAL_EVENT; // 0x28
	public static readonly FastAction<bool> TEXT_STYLE_PROPERTY_EVENT; // 0x30
	public static readonly FastAction<Object> COLOR_GRADIENT_PROPERTY_EVENT; // 0x38
	public static readonly FastAction TMP_SETTINGS_PROPERTY_EVENT; // 0x40
	public static readonly FastAction RESOURCE_LOAD_EVENT; // 0x48
	public static readonly FastAction<bool, Object> TEXTMESHPRO_UGUI_PROPERTY_EVENT; // 0x50
	public static readonly FastAction<Object> TEXT_CHANGED_EVENT; // 0x58

	// Methods

	// RVA: 0x15A3790 Offset: 0x15A3891 VA: 0x15A3790
	public static void ON_MATERIAL_PROPERTY_CHANGED(bool isChanged, Material mat) { }

	// RVA: 0x15A3830 Offset: 0x15A3931 VA: 0x15A3830
	public static void ON_FONT_PROPERTY_CHANGED(bool isChanged, Object obj) { }

	// RVA: 0x15A38D0 Offset: 0x15A39D1 VA: 0x15A38D0
	public static void ON_SPRITE_ASSET_PROPERTY_CHANGED(bool isChanged, Object obj) { }

	// RVA: 0x15A3970 Offset: 0x15A3A71 VA: 0x15A3970
	public static void ON_TEXTMESHPRO_PROPERTY_CHANGED(bool isChanged, Object obj) { }

	// RVA: 0x15A3A10 Offset: 0x15A3B11 VA: 0x15A3A10
	public static void ON_DRAG_AND_DROP_MATERIAL_CHANGED(GameObject sender, Material currentMaterial, Material newMaterial) { }

	// RVA: 0x15A3AB0 Offset: 0x15A3BB1 VA: 0x15A3AB0
	public static void ON_TEXT_STYLE_PROPERTY_CHANGED(bool isChanged) { }

	// RVA: 0x15A3B40 Offset: 0x15A3C41 VA: 0x15A3B40
	public static void ON_COLOR_GRADIENT_PROPERTY_CHANGED(Object obj) { }

	// RVA: 0x15A3BD0 Offset: 0x15A3CD1 VA: 0x15A3BD0
	public static void ON_TEXT_CHANGED(Object obj) { }

	// RVA: 0x15A3C60 Offset: 0x15A3D61 VA: 0x15A3C60
	public static void ON_TMP_SETTINGS_CHANGED() { }

	// RVA: 0x15A3CE0 Offset: 0x15A3DE1 VA: 0x15A3CE0
	public static void ON_RESOURCES_LOADED() { }

	// RVA: 0x15A3D60 Offset: 0x15A3E61 VA: 0x15A3D60
	public static void ON_TEXTMESHPRO_UGUI_PROPERTY_CHANGED(bool isChanged, Object obj) { }

	// RVA: 0x15A3E00 Offset: 0x15A3F01 VA: 0x15A3E00
	public static void ON_COMPUTE_DT_EVENT(object Sender, Compute_DT_EventArgs e) { }

	// RVA: 0x15A3EA0 Offset: 0x15A3FA1 VA: 0x15A3EA0
	private static void .cctor() { }
}

