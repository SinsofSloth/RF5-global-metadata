public static class LayoutUtility // TypeDefIndex: 3979
{
	// Methods

	// RVA: 0x18BE260 Offset: 0x18BE361 VA: 0x18BE260
	public static float GetMinSize(RectTransform rect, int axis) { }

	// RVA: 0x18BE490 Offset: 0x18BE591 VA: 0x18BE490
	public static float GetPreferredSize(RectTransform rect, int axis) { }

	// RVA: 0x18BE8C0 Offset: 0x18BE9C1 VA: 0x18BE8C0
	public static float GetFlexibleSize(RectTransform rect, int axis) { }

	// RVA: 0x18BE270 Offset: 0x18BE371 VA: 0x18BE270
	public static float GetMinWidth(RectTransform rect) { }

	// RVA: 0x18BE4A0 Offset: 0x18BE5A1 VA: 0x18BE4A0
	public static float GetPreferredWidth(RectTransform rect) { }

	// RVA: 0x18BE8D0 Offset: 0x18BE9D1 VA: 0x18BE8D0
	public static float GetFlexibleWidth(RectTransform rect) { }

	// RVA: 0x18BE380 Offset: 0x18BE481 VA: 0x18BE380
	public static float GetMinHeight(RectTransform rect) { }

	// RVA: 0x18BE6B0 Offset: 0x18BE7B1 VA: 0x18BE6B0
	public static float GetPreferredHeight(RectTransform rect) { }

	// RVA: 0x18BE9E0 Offset: 0x18BEAE1 VA: 0x18BE9E0
	public static float GetFlexibleHeight(RectTransform rect) { }

	// RVA: 0x18BEAF0 Offset: 0x18BEBF1 VA: 0x18BEAF0
	public static float GetLayoutProperty(RectTransform rect, Func<ILayoutElement, float> property, float defaultValue) { }

	// RVA: 0x18BEB20 Offset: 0x18BEC21 VA: 0x18BEB20
	public static float GetLayoutProperty(RectTransform rect, Func<ILayoutElement, float> property, float defaultValue, out ILayoutElement source) { }
}

