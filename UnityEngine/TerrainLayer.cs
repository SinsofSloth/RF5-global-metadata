[NativeHeaderAttribute] // RVA: 0xFD7E0 Offset: 0xFD8E1 VA: 0xFD7E0
[UsedByNativeCodeAttribute] // RVA: 0xFD7E0 Offset: 0xFD8E1 VA: 0xFD7E0
[NativeHeaderAttribute] // RVA: 0xFD7E0 Offset: 0xFD8E1 VA: 0xFD7E0
public sealed class TerrainLayer : Object // TypeDefIndex: 3663
{
	// Properties
	public Texture2D diffuseTexture { get; set; }
	public Texture2D normalMapTexture { get; set; }
	public Texture2D maskMapTexture { get; set; }
	public Vector2 tileSize { get; set; }
	public Vector2 tileOffset { get; set; }
	[NativePropertyAttribute] // RVA: 0xFF960 Offset: 0xFFA61 VA: 0xFF960
	public Color specular { get; set; }
	public float metallic { get; set; }
	public float smoothness { get; set; }
	public float normalScale { get; set; }
	public Vector4 diffuseRemapMin { get; set; }
	public Vector4 diffuseRemapMax { get; set; }
	public Vector4 maskMapRemapMin { get; set; }
	public Vector4 maskMapRemapMax { get; set; }

	// Methods

	// RVA: 0x1B52420 Offset: 0x1B52521 VA: 0x1B52420
	public void .ctor() { }

	[FreeFunctionAttribute] // RVA: 0xFF3E0 Offset: 0xFF4E1 VA: 0xFF3E0
	// RVA: 0x1B524C0 Offset: 0x1B525C1 VA: 0x1B524C0
	private static void Internal_Create(TerrainLayer layer) { }

	// RVA: 0x1B52510 Offset: 0x1B52611 VA: 0x1B52510
	public Texture2D get_diffuseTexture() { }

	// RVA: 0x1B52560 Offset: 0x1B52661 VA: 0x1B52560
	public void set_diffuseTexture(Texture2D value) { }

	// RVA: 0x1B525B0 Offset: 0x1B526B1 VA: 0x1B525B0
	public Texture2D get_normalMapTexture() { }

	// RVA: 0x1B52600 Offset: 0x1B52701 VA: 0x1B52600
	public void set_normalMapTexture(Texture2D value) { }

	// RVA: 0x1B52650 Offset: 0x1B52751 VA: 0x1B52650
	public Texture2D get_maskMapTexture() { }

	// RVA: 0x1B526A0 Offset: 0x1B527A1 VA: 0x1B526A0
	public void set_maskMapTexture(Texture2D value) { }

	// RVA: 0x1B526F0 Offset: 0x1B527F1 VA: 0x1B526F0
	public Vector2 get_tileSize() { }

	// RVA: 0x1B527A0 Offset: 0x1B528A1 VA: 0x1B527A0
	public void set_tileSize(Vector2 value) { }

	// RVA: 0x1B52850 Offset: 0x1B52951 VA: 0x1B52850
	public Vector2 get_tileOffset() { }

	// RVA: 0x1B52900 Offset: 0x1B52A01 VA: 0x1B52900
	public void set_tileOffset(Vector2 value) { }

	// RVA: 0x1B529B0 Offset: 0x1B52AB1 VA: 0x1B529B0
	public Color get_specular() { }

	// RVA: 0x1B52A60 Offset: 0x1B52B61 VA: 0x1B52A60
	public void set_specular(Color value) { }

	// RVA: 0x1B52B10 Offset: 0x1B52C11 VA: 0x1B52B10
	public float get_metallic() { }

	// RVA: 0x1B52B60 Offset: 0x1B52C61 VA: 0x1B52B60
	public void set_metallic(float value) { }

	// RVA: 0x1B52BB0 Offset: 0x1B52CB1 VA: 0x1B52BB0
	public float get_smoothness() { }

	// RVA: 0x1B52C00 Offset: 0x1B52D01 VA: 0x1B52C00
	public void set_smoothness(float value) { }

	// RVA: 0x1B52C50 Offset: 0x1B52D51 VA: 0x1B52C50
	public float get_normalScale() { }

	// RVA: 0x1B52CA0 Offset: 0x1B52DA1 VA: 0x1B52CA0
	public void set_normalScale(float value) { }

	// RVA: 0x1B52CF0 Offset: 0x1B52DF1 VA: 0x1B52CF0
	public Vector4 get_diffuseRemapMin() { }

	// RVA: 0x1B52DA0 Offset: 0x1B52EA1 VA: 0x1B52DA0
	public void set_diffuseRemapMin(Vector4 value) { }

	// RVA: 0x1B52E50 Offset: 0x1B52F51 VA: 0x1B52E50
	public Vector4 get_diffuseRemapMax() { }

	// RVA: 0x1B52F00 Offset: 0x1B53001 VA: 0x1B52F00
	public void set_diffuseRemapMax(Vector4 value) { }

	// RVA: 0x1B52FB0 Offset: 0x1B530B1 VA: 0x1B52FB0
	public Vector4 get_maskMapRemapMin() { }

	// RVA: 0x1B53060 Offset: 0x1B53161 VA: 0x1B53060
	public void set_maskMapRemapMin(Vector4 value) { }

	// RVA: 0x1B53110 Offset: 0x1B53211 VA: 0x1B53110
	public Vector4 get_maskMapRemapMax() { }

	// RVA: 0x1B531C0 Offset: 0x1B532C1 VA: 0x1B531C0
	public void set_maskMapRemapMax(Vector4 value) { }

	// RVA: 0x1B52750 Offset: 0x1B52851 VA: 0x1B52750
	private void get_tileSize_Injected(out Vector2 ret) { }

	// RVA: 0x1B52800 Offset: 0x1B52901 VA: 0x1B52800
	private void set_tileSize_Injected(ref Vector2 value) { }

	// RVA: 0x1B528B0 Offset: 0x1B529B1 VA: 0x1B528B0
	private void get_tileOffset_Injected(out Vector2 ret) { }

	// RVA: 0x1B52960 Offset: 0x1B52A61 VA: 0x1B52960
	private void set_tileOffset_Injected(ref Vector2 value) { }

	// RVA: 0x1B52A10 Offset: 0x1B52B11 VA: 0x1B52A10
	private void get_specular_Injected(out Color ret) { }

	// RVA: 0x1B52AC0 Offset: 0x1B52BC1 VA: 0x1B52AC0
	private void set_specular_Injected(ref Color value) { }

	// RVA: 0x1B52D50 Offset: 0x1B52E51 VA: 0x1B52D50
	private void get_diffuseRemapMin_Injected(out Vector4 ret) { }

	// RVA: 0x1B52E00 Offset: 0x1B52F01 VA: 0x1B52E00
	private void set_diffuseRemapMin_Injected(ref Vector4 value) { }

	// RVA: 0x1B52EB0 Offset: 0x1B52FB1 VA: 0x1B52EB0
	private void get_diffuseRemapMax_Injected(out Vector4 ret) { }

	// RVA: 0x1B52F60 Offset: 0x1B53061 VA: 0x1B52F60
	private void set_diffuseRemapMax_Injected(ref Vector4 value) { }

	// RVA: 0x1B53010 Offset: 0x1B53111 VA: 0x1B53010
	private void get_maskMapRemapMin_Injected(out Vector4 ret) { }

	// RVA: 0x1B530C0 Offset: 0x1B531C1 VA: 0x1B530C0
	private void set_maskMapRemapMin_Injected(ref Vector4 value) { }

	// RVA: 0x1B53170 Offset: 0x1B53271 VA: 0x1B53170
	private void get_maskMapRemapMax_Injected(out Vector4 ret) { }

	// RVA: 0x1B53220 Offset: 0x1B53321 VA: 0x1B53220
	private void set_maskMapRemapMax_Injected(ref Vector4 value) { }
}

