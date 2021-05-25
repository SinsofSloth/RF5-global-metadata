[ExcludeFromPresetAttribute] // RVA: 0x13EC80 Offset: 0x13ED81 VA: 0x13EC80
[Serializable]
public class TMP_ColorGradient : ScriptableObject // TypeDefIndex: 5758
{
	// Fields
	public ColorMode colorMode; // 0x18
	public Color topLeft; // 0x1C
	public Color topRight; // 0x2C
	public Color bottomLeft; // 0x3C
	public Color bottomRight; // 0x4C
	private const ColorMode k_DefaultColorMode = 3;
	private static readonly Color k_DefaultColor; // 0x0

	// Methods

	// RVA: 0x154FE70 Offset: 0x154FF71 VA: 0x154FE70
	public void .ctor() { }

	// RVA: 0x154FF50 Offset: 0x1550051 VA: 0x154FF50
	public void .ctor(Color color) { }

	// RVA: 0x154FFE0 Offset: 0x15500E1 VA: 0x154FFE0
	public void .ctor(Color color0, Color color1, Color color2, Color color3) { }

	// RVA: 0x15500C0 Offset: 0x15501C1 VA: 0x15500C0
	private static void .cctor() { }
}

