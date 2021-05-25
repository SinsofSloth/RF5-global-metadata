public sealed class ShaderVariantCollection : Object // TypeDefIndex: 3051
{
	// Properties
	public int shaderCount { get; }
	public int variantCount { get; }
	public bool isWarmedUp { get; }

	// Methods

	// RVA: 0x2A2AF10 Offset: 0x2A2B011 VA: 0x2A2AF10
	public int get_shaderCount() { }

	// RVA: 0x2A2AF60 Offset: 0x2A2B061 VA: 0x2A2AF60
	public int get_variantCount() { }

	[NativeNameAttribute] // RVA: 0xD7780 Offset: 0xD7881 VA: 0xD7780
	// RVA: 0x2A2AFB0 Offset: 0x2A2B0B1 VA: 0x2A2AFB0
	public bool get_isWarmedUp() { }

	// RVA: 0x2A2B000 Offset: 0x2A2B101 VA: 0x2A2B000
	private bool AddVariant(Shader shader, PassType passType, string[] keywords) { }

	// RVA: 0x2A2B070 Offset: 0x2A2B171 VA: 0x2A2B070
	private bool RemoveVariant(Shader shader, PassType passType, string[] keywords) { }

	// RVA: 0x2A2B0E0 Offset: 0x2A2B1E1 VA: 0x2A2B0E0
	private bool ContainsVariant(Shader shader, PassType passType, string[] keywords) { }

	[NativeNameAttribute] // RVA: 0xD77C0 Offset: 0xD78C1 VA: 0xD77C0
	// RVA: 0x2A2B150 Offset: 0x2A2B251 VA: 0x2A2B150
	public void Clear() { }

	[NativeNameAttribute] // RVA: 0xD7800 Offset: 0xD7901 VA: 0xD7800
	// RVA: 0x2A2B1A0 Offset: 0x2A2B2A1 VA: 0x2A2B1A0
	public void WarmUp() { }

	[NativeNameAttribute] // RVA: 0xD7840 Offset: 0xD7941 VA: 0xD7840
	// RVA: 0x2A2B1F0 Offset: 0x2A2B2F1 VA: 0x2A2B1F0
	private static void Internal_Create(ShaderVariantCollection svc) { }

	// RVA: 0x2A2B240 Offset: 0x2A2B341 VA: 0x2A2B240
	public void .ctor() { }

	// RVA: 0x2A2B2E0 Offset: 0x2A2B3E1 VA: 0x2A2B2E0
	public bool Add(ShaderVariantCollection.ShaderVariant variant) { }

	// RVA: 0x2A2B350 Offset: 0x2A2B451 VA: 0x2A2B350
	public bool Remove(ShaderVariantCollection.ShaderVariant variant) { }

	// RVA: 0x2A2B3C0 Offset: 0x2A2B4C1 VA: 0x2A2B3C0
	public bool Contains(ShaderVariantCollection.ShaderVariant variant) { }
}

