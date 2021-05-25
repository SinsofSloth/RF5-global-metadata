[RequireComponent] // RVA: 0xC5060 Offset: 0xC5161 VA: 0xC5060
[NativeHeaderAttribute] // RVA: 0xC5060 Offset: 0xC5161 VA: 0xC5060
[UsedByNativeCodeAttribute] // RVA: 0xC5060 Offset: 0xC5161 VA: 0xC5060
[NativeHeaderAttribute] // RVA: 0xC5060 Offset: 0xC5161 VA: 0xC5060
public class Renderer : Component // TypeDefIndex: 2888
{
	// Properties
	public Bounds bounds { get; }
	public bool enabled { get; set; }
	public bool isVisible { get; }
	public ShadowCastingMode shadowCastingMode { get; set; }
	public bool receiveShadows { get; set; }
	public LightProbeUsage lightProbeUsage { get; set; }
	public string sortingLayerName { set; }
	public int sortingLayerID { get; set; }
	public int sortingOrder { get; set; }
	public bool isPartOfStaticBatch { get; }
	public int lightmapIndex { get; set; }
	public Vector4 lightmapScaleOffset { get; set; }
	public Material[] materials { get; set; }
	public Material material { get; set; }
	public Material sharedMaterial { get; set; }
	public Material[] sharedMaterials { get; set; }

	// Methods

	[FreeFunctionAttribute] // RVA: 0xCF400 Offset: 0xCF501 VA: 0xCF400
	// RVA: 0x2B80970 Offset: 0x2B80A71 VA: 0x2B80970
	public Bounds get_bounds() { }

	[FreeFunctionAttribute] // RVA: 0xCF450 Offset: 0xCF551 VA: 0xCF450
	// RVA: 0x2B80A30 Offset: 0x2B80B31 VA: 0x2B80A30
	private void SetStaticLightmapST(Vector4 st) { }

	[FreeFunctionAttribute] // RVA: 0xCF4A0 Offset: 0xCF5A1 VA: 0xCF4A0
	// RVA: 0x2B80AE0 Offset: 0x2B80BE1 VA: 0x2B80AE0
	private Material GetMaterial() { }

	[FreeFunctionAttribute] // RVA: 0xCF4F0 Offset: 0xCF5F1 VA: 0xCF4F0
	// RVA: 0x2B80B30 Offset: 0x2B80C31 VA: 0x2B80B30
	private Material GetSharedMaterial() { }

	[FreeFunctionAttribute] // RVA: 0xCF540 Offset: 0xCF641 VA: 0xCF540
	// RVA: 0x2B80B80 Offset: 0x2B80C81 VA: 0x2B80B80
	private void SetMaterial(Material m) { }

	[FreeFunctionAttribute] // RVA: 0xCF590 Offset: 0xCF691 VA: 0xCF590
	// RVA: 0x2B80BD0 Offset: 0x2B80CD1 VA: 0x2B80BD0
	private Material[] GetMaterialArray() { }

	[FreeFunctionAttribute] // RVA: 0xCF5E0 Offset: 0xCF6E1 VA: 0xCF5E0
	// RVA: 0x2B80C20 Offset: 0x2B80D21 VA: 0x2B80C20
	private void CopySharedMaterialArray([Out] Material[] m) { }

	[FreeFunctionAttribute] // RVA: 0xCF630 Offset: 0xCF731 VA: 0xCF630
	// RVA: 0x2B80C70 Offset: 0x2B80D71 VA: 0x2B80C70
	private void SetMaterialArray(Material[] m) { }

	[FreeFunctionAttribute] // RVA: 0xCF680 Offset: 0xCF781 VA: 0xCF680
	// RVA: 0x2B80CC0 Offset: 0x2B80DC1 VA: 0x2B80CC0
	internal void Internal_SetPropertyBlock(MaterialPropertyBlock properties) { }

	[FreeFunctionAttribute] // RVA: 0xCF6D0 Offset: 0xCF7D1 VA: 0xCF6D0
	// RVA: 0x2B80D10 Offset: 0x2B80E11 VA: 0x2B80D10
	internal void Internal_GetPropertyBlock(MaterialPropertyBlock dest) { }

	[FreeFunctionAttribute] // RVA: 0xCF720 Offset: 0xCF821 VA: 0xCF720
	// RVA: 0x2B80D60 Offset: 0x2B80E61 VA: 0x2B80D60
	internal void Internal_SetPropertyBlockMaterialIndex(MaterialPropertyBlock properties, int materialIndex) { }

	[FreeFunctionAttribute] // RVA: 0xCF770 Offset: 0xCF871 VA: 0xCF770
	// RVA: 0x2B80DC0 Offset: 0x2B80EC1 VA: 0x2B80DC0
	internal void Internal_GetPropertyBlockMaterialIndex(MaterialPropertyBlock dest, int materialIndex) { }

	[FreeFunctionAttribute] // RVA: 0xCF7C0 Offset: 0xCF8C1 VA: 0xCF7C0
	// RVA: 0x2B80E20 Offset: 0x2B80F21 VA: 0x2B80E20
	public bool HasPropertyBlock() { }

	// RVA: 0x2B80E70 Offset: 0x2B80F71 VA: 0x2B80E70
	public void SetPropertyBlock(MaterialPropertyBlock properties) { }

	// RVA: 0x2B80EC0 Offset: 0x2B80FC1 VA: 0x2B80EC0
	public void SetPropertyBlock(MaterialPropertyBlock properties, int materialIndex) { }

	// RVA: 0x2B80F20 Offset: 0x2B81021 VA: 0x2B80F20
	public void GetPropertyBlock(MaterialPropertyBlock properties) { }

	// RVA: 0x2B80F70 Offset: 0x2B81071 VA: 0x2B80F70
	public void GetPropertyBlock(MaterialPropertyBlock properties, int materialIndex) { }

	// RVA: 0x2B80FD0 Offset: 0x2B810D1 VA: 0x2B80FD0
	public bool get_enabled() { }

	// RVA: 0x2B81020 Offset: 0x2B81121 VA: 0x2B81020
	public void set_enabled(bool value) { }

	[NativeNameAttribute] // RVA: 0xCF810 Offset: 0xCF911 VA: 0xCF810
	// RVA: 0x2B81070 Offset: 0x2B81171 VA: 0x2B81070
	public bool get_isVisible() { }

	// RVA: 0x2B810C0 Offset: 0x2B811C1 VA: 0x2B810C0
	public ShadowCastingMode get_shadowCastingMode() { }

	// RVA: 0x2B81110 Offset: 0x2B81211 VA: 0x2B81110
	public void set_shadowCastingMode(ShadowCastingMode value) { }

	// RVA: 0x2B81160 Offset: 0x2B81261 VA: 0x2B81160
	public bool get_receiveShadows() { }

	// RVA: 0x2B811B0 Offset: 0x2B812B1 VA: 0x2B811B0
	public void set_receiveShadows(bool value) { }

	// RVA: 0x2B81200 Offset: 0x2B81301 VA: 0x2B81200
	public LightProbeUsage get_lightProbeUsage() { }

	// RVA: 0x2B81250 Offset: 0x2B81351 VA: 0x2B81250
	public void set_lightProbeUsage(LightProbeUsage value) { }

	// RVA: 0x2B812A0 Offset: 0x2B813A1 VA: 0x2B812A0
	public void set_sortingLayerName(string value) { }

	// RVA: 0x2B812F0 Offset: 0x2B813F1 VA: 0x2B812F0
	public int get_sortingLayerID() { }

	// RVA: 0x2B81340 Offset: 0x2B81441 VA: 0x2B81340
	public void set_sortingLayerID(int value) { }

	// RVA: 0x2B81390 Offset: 0x2B81491 VA: 0x2B81390
	public int get_sortingOrder() { }

	// RVA: 0x2B813E0 Offset: 0x2B814E1 VA: 0x2B813E0
	public void set_sortingOrder(int value) { }

	[NativeNameAttribute] // RVA: 0xCF850 Offset: 0xCF951 VA: 0xCF850
	// RVA: 0x2B81430 Offset: 0x2B81531 VA: 0x2B81430
	public bool get_isPartOfStaticBatch() { }

	[NativeNameAttribute] // RVA: 0xCF890 Offset: 0xCF991 VA: 0xCF890
	// RVA: 0x2B81480 Offset: 0x2B81581 VA: 0x2B81480
	private int GetLightmapIndex(LightmapType lt) { }

	[NativeNameAttribute] // RVA: 0xCF8D0 Offset: 0xCF9D1 VA: 0xCF8D0
	// RVA: 0x2B814D0 Offset: 0x2B815D1 VA: 0x2B814D0
	private void SetLightmapIndex(int index, LightmapType lt) { }

	[NativeNameAttribute] // RVA: 0xCF910 Offset: 0xCFA11 VA: 0xCF910
	// RVA: 0x2B81530 Offset: 0x2B81631 VA: 0x2B81530
	private Vector4 GetLightmapST(LightmapType lt) { }

	// RVA: 0x2B81600 Offset: 0x2B81701 VA: 0x2B81600
	public int get_lightmapIndex() { }

	// RVA: 0x2B81650 Offset: 0x2B81751 VA: 0x2B81650
	public void set_lightmapIndex(int value) { }

	// RVA: 0x2B816B0 Offset: 0x2B817B1 VA: 0x2B816B0
	public Vector4 get_lightmapScaleOffset() { }

	// RVA: 0x2B81710 Offset: 0x2B81811 VA: 0x2B81710
	public void set_lightmapScaleOffset(Vector4 value) { }

	// RVA: 0x2B81770 Offset: 0x2B81871 VA: 0x2B81770
	private int GetMaterialCount() { }

	[NativeNameAttribute] // RVA: 0xCF950 Offset: 0xCFA51 VA: 0xCF950
	// RVA: 0x2B817C0 Offset: 0x2B818C1 VA: 0x2B817C0
	private Material[] GetSharedMaterialArray() { }

	// RVA: 0x2B81810 Offset: 0x2B81911 VA: 0x2B81810
	public Material[] get_materials() { }

	// RVA: 0x2B81860 Offset: 0x2B81961 VA: 0x2B81860
	public void set_materials(Material[] value) { }

	// RVA: 0x2B818B0 Offset: 0x2B819B1 VA: 0x2B818B0
	public Material get_material() { }

	// RVA: 0x2B81900 Offset: 0x2B81A01 VA: 0x2B81900
	public void set_material(Material value) { }

	// RVA: 0x2B81950 Offset: 0x2B81A51 VA: 0x2B81950
	public Material get_sharedMaterial() { }

	// RVA: 0x2B819A0 Offset: 0x2B81AA1 VA: 0x2B819A0
	public void set_sharedMaterial(Material value) { }

	// RVA: 0x2B819F0 Offset: 0x2B81AF1 VA: 0x2B819F0
	public Material[] get_sharedMaterials() { }

	// RVA: 0x2B81A40 Offset: 0x2B81B41 VA: 0x2B81A40
	public void set_sharedMaterials(Material[] value) { }

	// RVA: 0x2B81A90 Offset: 0x2B81B91 VA: 0x2B81A90
	public void GetSharedMaterials(List<Material> m) { }

	// RVA: 0x2B81BB0 Offset: 0x2B81CB1 VA: 0x2B81BB0
	public void .ctor() { }

	// RVA: 0x2B809E0 Offset: 0x2B80AE1 VA: 0x2B809E0
	private void get_bounds_Injected(out Bounds ret) { }

	// RVA: 0x2B80A90 Offset: 0x2B80B91 VA: 0x2B80A90
	private void SetStaticLightmapST_Injected(ref Vector4 st) { }

	// RVA: 0x2B815A0 Offset: 0x2B816A1 VA: 0x2B815A0
	private void GetLightmapST_Injected(LightmapType lt, out Vector4 ret) { }
}

