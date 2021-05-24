public static class TMP_MaterialManager // TypeDefIndex: 5821
{
	// Fields
	private static List<TMP_MaterialManager.MaskingMaterial> m_materialList; // 0x0
	private static Dictionary<long, TMP_MaterialManager.FallbackMaterial> m_fallbackMaterials; // 0x8
	private static Dictionary<int, long> m_fallbackMaterialLookup; // 0x10
	private static List<TMP_MaterialManager.FallbackMaterial> m_fallbackCleanupList; // 0x18
	private static bool isFallbackListDirty; // 0x20

	// Methods

	// RVA: 0x156F9D0 Offset: 0x156FAD1 VA: 0x156F9D0
	private static void .cctor() { }

	// RVA: 0x156FBC0 Offset: 0x156FCC1 VA: 0x156FBC0
	private static void OnPreRender(Camera cam) { }

	// RVA: 0x156FE70 Offset: 0x156FF71 VA: 0x156FE70
	private static void OnPreRenderCanvas() { }

	// RVA: 0x156FF00 Offset: 0x1570001 VA: 0x156FF00
	public static Material GetStencilMaterial(Material baseMaterial, int stencilID) { }

	// RVA: 0x15702E0 Offset: 0x15703E1 VA: 0x15702E0
	public static void ReleaseStencilMaterial(Material stencilMaterial) { }

	// RVA: 0x1570550 Offset: 0x1570651 VA: 0x1570550
	public static Material GetBaseMaterial(Material stencilMaterial) { }

	// RVA: 0x15706D0 Offset: 0x15707D1 VA: 0x15706D0
	public static Material SetStencil(Material material, int stencilID) { }

	// RVA: 0x15707C0 Offset: 0x15708C1 VA: 0x15707C0
	public static void AddMaskingMaterial(Material baseMaterial, Material stencilMaterial, int stencilID) { }

	// RVA: 0x1570A30 Offset: 0x1570B31 VA: 0x1570A30
	public static void RemoveStencilMaterial(Material stencilMaterial) { }

	// RVA: 0x1570B90 Offset: 0x1570C91 VA: 0x1570B90
	public static void ReleaseBaseMaterial(Material baseMaterial) { }

	// RVA: 0x15712D0 Offset: 0x15713D1 VA: 0x15712D0
	public static void ClearMaterials() { }

	// RVA: 0x1571480 Offset: 0x1571581 VA: 0x1571480
	public static int GetStencilID(GameObject obj) { }

	// RVA: 0x1571910 Offset: 0x1571A11 VA: 0x1571910
	public static Material GetMaterialForRendering(MaskableGraphic graphic, Material baseMaterial) { }

	// RVA: 0x1571780 Offset: 0x1571881 VA: 0x1571780
	private static Transform FindRootSortOverrideCanvas(Transform start) { }

	// RVA: 0x1571AF0 Offset: 0x1571BF1 VA: 0x1571AF0
	internal static Material GetFallbackMaterial(TMP_FontAsset fontAsset, Material sourceMaterial, int atlasIndex) { }

	// RVA: 0x1571D70 Offset: 0x1571E71 VA: 0x1571D70
	public static Material GetFallbackMaterial(Material sourceMaterial, Material targetMaterial) { }

	// RVA: 0x1572150 Offset: 0x1572251 VA: 0x1572150
	public static void AddFallbackMaterialReference(Material targetMaterial) { }

	// RVA: 0x1572290 Offset: 0x1572391 VA: 0x1572290
	public static void RemoveFallbackMaterialReference(Material targetMaterial) { }

	// RVA: 0x156FC50 Offset: 0x156FD51 VA: 0x156FC50
	public static void CleanupFallbackMaterials() { }

	// RVA: 0x1572430 Offset: 0x1572531 VA: 0x1572430
	public static void ReleaseFallbackMaterial(Material fallackMaterial) { }

	// RVA: 0x15725E0 Offset: 0x15726E1 VA: 0x15725E0
	public static void CopyMaterialPresetProperties(Material source, Material destination) { }
}

public static class TMP_MaterialManager // TypeDefIndex: 5821
{
	// Fields
	private static List<TMP_MaterialManager.MaskingMaterial> m_materialList; // 0x0
	private static Dictionary<long, TMP_MaterialManager.FallbackMaterial> m_fallbackMaterials; // 0x8
	private static Dictionary<int, long> m_fallbackMaterialLookup; // 0x10
	private static List<TMP_MaterialManager.FallbackMaterial> m_fallbackCleanupList; // 0x18
	private static bool isFallbackListDirty; // 0x20

	// Methods

	// RVA: 0x156F9D0 Offset: 0x156FAD1 VA: 0x156F9D0
	private static void .cctor() { }

	// RVA: 0x156FBC0 Offset: 0x156FCC1 VA: 0x156FBC0
	private static void OnPreRender(Camera cam) { }

	// RVA: 0x156FE70 Offset: 0x156FF71 VA: 0x156FE70
	private static void OnPreRenderCanvas() { }

	// RVA: 0x156FF00 Offset: 0x1570001 VA: 0x156FF00
	public static Material GetStencilMaterial(Material baseMaterial, int stencilID) { }

	// RVA: 0x15702E0 Offset: 0x15703E1 VA: 0x15702E0
	public static void ReleaseStencilMaterial(Material stencilMaterial) { }

	// RVA: 0x1570550 Offset: 0x1570651 VA: 0x1570550
	public static Material GetBaseMaterial(Material stencilMaterial) { }

	// RVA: 0x15706D0 Offset: 0x15707D1 VA: 0x15706D0
	public static Material SetStencil(Material material, int stencilID) { }

	// RVA: 0x15707C0 Offset: 0x15708C1 VA: 0x15707C0
	public static void AddMaskingMaterial(Material baseMaterial, Material stencilMaterial, int stencilID) { }

	// RVA: 0x1570A30 Offset: 0x1570B31 VA: 0x1570A30
	public static void RemoveStencilMaterial(Material stencilMaterial) { }

	// RVA: 0x1570B90 Offset: 0x1570C91 VA: 0x1570B90
	public static void ReleaseBaseMaterial(Material baseMaterial) { }

	// RVA: 0x15712D0 Offset: 0x15713D1 VA: 0x15712D0
	public static void ClearMaterials() { }

	// RVA: 0x1571480 Offset: 0x1571581 VA: 0x1571480
	public static int GetStencilID(GameObject obj) { }

	// RVA: 0x1571910 Offset: 0x1571A11 VA: 0x1571910
	public static Material GetMaterialForRendering(MaskableGraphic graphic, Material baseMaterial) { }

	// RVA: 0x1571780 Offset: 0x1571881 VA: 0x1571780
	private static Transform FindRootSortOverrideCanvas(Transform start) { }

	// RVA: 0x1571AF0 Offset: 0x1571BF1 VA: 0x1571AF0
	internal static Material GetFallbackMaterial(TMP_FontAsset fontAsset, Material sourceMaterial, int atlasIndex) { }

	// RVA: 0x1571D70 Offset: 0x1571E71 VA: 0x1571D70
	public static Material GetFallbackMaterial(Material sourceMaterial, Material targetMaterial) { }

	// RVA: 0x1572150 Offset: 0x1572251 VA: 0x1572150
	public static void AddFallbackMaterialReference(Material targetMaterial) { }

	// RVA: 0x1572290 Offset: 0x1572391 VA: 0x1572290
	public static void RemoveFallbackMaterialReference(Material targetMaterial) { }

	// RVA: 0x156FC50 Offset: 0x156FD51 VA: 0x156FC50
	public static void CleanupFallbackMaterials() { }

	// RVA: 0x1572430 Offset: 0x1572531 VA: 0x1572430
	public static void ReleaseFallbackMaterial(Material fallackMaterial) { }

	// RVA: 0x15725E0 Offset: 0x15726E1 VA: 0x15725E0
	public static void CopyMaterialPresetProperties(Material source, Material destination) { }
}

public static class TMP_MaterialManager // TypeDefIndex: 5821
{
	// Fields
	private static List<TMP_MaterialManager.MaskingMaterial> m_materialList; // 0x0
	private static Dictionary<long, TMP_MaterialManager.FallbackMaterial> m_fallbackMaterials; // 0x8
	private static Dictionary<int, long> m_fallbackMaterialLookup; // 0x10
	private static List<TMP_MaterialManager.FallbackMaterial> m_fallbackCleanupList; // 0x18
	private static bool isFallbackListDirty; // 0x20

	// Methods

	// RVA: 0x156F9D0 Offset: 0x156FAD1 VA: 0x156F9D0
	private static void .cctor() { }

	// RVA: 0x156FBC0 Offset: 0x156FCC1 VA: 0x156FBC0
	private static void OnPreRender(Camera cam) { }

	// RVA: 0x156FE70 Offset: 0x156FF71 VA: 0x156FE70
	private static void OnPreRenderCanvas() { }

	// RVA: 0x156FF00 Offset: 0x1570001 VA: 0x156FF00
	public static Material GetStencilMaterial(Material baseMaterial, int stencilID) { }

	// RVA: 0x15702E0 Offset: 0x15703E1 VA: 0x15702E0
	public static void ReleaseStencilMaterial(Material stencilMaterial) { }

	// RVA: 0x1570550 Offset: 0x1570651 VA: 0x1570550
	public static Material GetBaseMaterial(Material stencilMaterial) { }

	// RVA: 0x15706D0 Offset: 0x15707D1 VA: 0x15706D0
	public static Material SetStencil(Material material, int stencilID) { }

	// RVA: 0x15707C0 Offset: 0x15708C1 VA: 0x15707C0
	public static void AddMaskingMaterial(Material baseMaterial, Material stencilMaterial, int stencilID) { }

	// RVA: 0x1570A30 Offset: 0x1570B31 VA: 0x1570A30
	public static void RemoveStencilMaterial(Material stencilMaterial) { }

	// RVA: 0x1570B90 Offset: 0x1570C91 VA: 0x1570B90
	public static void ReleaseBaseMaterial(Material baseMaterial) { }

	// RVA: 0x15712D0 Offset: 0x15713D1 VA: 0x15712D0
	public static void ClearMaterials() { }

	// RVA: 0x1571480 Offset: 0x1571581 VA: 0x1571480
	public static int GetStencilID(GameObject obj) { }

	// RVA: 0x1571910 Offset: 0x1571A11 VA: 0x1571910
	public static Material GetMaterialForRendering(MaskableGraphic graphic, Material baseMaterial) { }

	// RVA: 0x1571780 Offset: 0x1571881 VA: 0x1571780
	private static Transform FindRootSortOverrideCanvas(Transform start) { }

	// RVA: 0x1571AF0 Offset: 0x1571BF1 VA: 0x1571AF0
	internal static Material GetFallbackMaterial(TMP_FontAsset fontAsset, Material sourceMaterial, int atlasIndex) { }

	// RVA: 0x1571D70 Offset: 0x1571E71 VA: 0x1571D70
	public static Material GetFallbackMaterial(Material sourceMaterial, Material targetMaterial) { }

	// RVA: 0x1572150 Offset: 0x1572251 VA: 0x1572150
	public static void AddFallbackMaterialReference(Material targetMaterial) { }

	// RVA: 0x1572290 Offset: 0x1572391 VA: 0x1572290
	public static void RemoveFallbackMaterialReference(Material targetMaterial) { }

	// RVA: 0x156FC50 Offset: 0x156FD51 VA: 0x156FC50
	public static void CleanupFallbackMaterials() { }

	// RVA: 0x1572430 Offset: 0x1572531 VA: 0x1572430
	public static void ReleaseFallbackMaterial(Material fallackMaterial) { }

	// RVA: 0x15725E0 Offset: 0x15726E1 VA: 0x15725E0
	public static void CopyMaterialPresetProperties(Material source, Material destination) { }
}

public static class TMP_MaterialManager // TypeDefIndex: 5821
{
	// Fields
	private static List<TMP_MaterialManager.MaskingMaterial> m_materialList; // 0x0
	private static Dictionary<long, TMP_MaterialManager.FallbackMaterial> m_fallbackMaterials; // 0x8
	private static Dictionary<int, long> m_fallbackMaterialLookup; // 0x10
	private static List<TMP_MaterialManager.FallbackMaterial> m_fallbackCleanupList; // 0x18
	private static bool isFallbackListDirty; // 0x20

	// Methods

	// RVA: 0x156F9D0 Offset: 0x156FAD1 VA: 0x156F9D0
	private static void .cctor() { }

	// RVA: 0x156FBC0 Offset: 0x156FCC1 VA: 0x156FBC0
	private static void OnPreRender(Camera cam) { }

	// RVA: 0x156FE70 Offset: 0x156FF71 VA: 0x156FE70
	private static void OnPreRenderCanvas() { }

	// RVA: 0x156FF00 Offset: 0x1570001 VA: 0x156FF00
	public static Material GetStencilMaterial(Material baseMaterial, int stencilID) { }

	// RVA: 0x15702E0 Offset: 0x15703E1 VA: 0x15702E0
	public static void ReleaseStencilMaterial(Material stencilMaterial) { }

	// RVA: 0x1570550 Offset: 0x1570651 VA: 0x1570550
	public static Material GetBaseMaterial(Material stencilMaterial) { }

	// RVA: 0x15706D0 Offset: 0x15707D1 VA: 0x15706D0
	public static Material SetStencil(Material material, int stencilID) { }

	// RVA: 0x15707C0 Offset: 0x15708C1 VA: 0x15707C0
	public static void AddMaskingMaterial(Material baseMaterial, Material stencilMaterial, int stencilID) { }

	// RVA: 0x1570A30 Offset: 0x1570B31 VA: 0x1570A30
	public static void RemoveStencilMaterial(Material stencilMaterial) { }

	// RVA: 0x1570B90 Offset: 0x1570C91 VA: 0x1570B90
	public static void ReleaseBaseMaterial(Material baseMaterial) { }

	// RVA: 0x15712D0 Offset: 0x15713D1 VA: 0x15712D0
	public static void ClearMaterials() { }

	// RVA: 0x1571480 Offset: 0x1571581 VA: 0x1571480
	public static int GetStencilID(GameObject obj) { }

	// RVA: 0x1571910 Offset: 0x1571A11 VA: 0x1571910
	public static Material GetMaterialForRendering(MaskableGraphic graphic, Material baseMaterial) { }

	// RVA: 0x1571780 Offset: 0x1571881 VA: 0x1571780
	private static Transform FindRootSortOverrideCanvas(Transform start) { }

	// RVA: 0x1571AF0 Offset: 0x1571BF1 VA: 0x1571AF0
	internal static Material GetFallbackMaterial(TMP_FontAsset fontAsset, Material sourceMaterial, int atlasIndex) { }

	// RVA: 0x1571D70 Offset: 0x1571E71 VA: 0x1571D70
	public static Material GetFallbackMaterial(Material sourceMaterial, Material targetMaterial) { }

	// RVA: 0x1572150 Offset: 0x1572251 VA: 0x1572150
	public static void AddFallbackMaterialReference(Material targetMaterial) { }

	// RVA: 0x1572290 Offset: 0x1572391 VA: 0x1572290
	public static void RemoveFallbackMaterialReference(Material targetMaterial) { }

	// RVA: 0x156FC50 Offset: 0x156FD51 VA: 0x156FC50
	public static void CleanupFallbackMaterials() { }

	// RVA: 0x1572430 Offset: 0x1572531 VA: 0x1572430
	public static void ReleaseFallbackMaterial(Material fallackMaterial) { }

	// RVA: 0x15725E0 Offset: 0x15726E1 VA: 0x15725E0
	public static void CopyMaterialPresetProperties(Material source, Material destination) { }
}

public static class TMP_MaterialManager // TypeDefIndex: 5821
{
	// Fields
	private static List<TMP_MaterialManager.MaskingMaterial> m_materialList; // 0x0
	private static Dictionary<long, TMP_MaterialManager.FallbackMaterial> m_fallbackMaterials; // 0x8
	private static Dictionary<int, long> m_fallbackMaterialLookup; // 0x10
	private static List<TMP_MaterialManager.FallbackMaterial> m_fallbackCleanupList; // 0x18
	private static bool isFallbackListDirty; // 0x20

	// Methods

	// RVA: 0x156F9D0 Offset: 0x156FAD1 VA: 0x156F9D0
	private static void .cctor() { }

	// RVA: 0x156FBC0 Offset: 0x156FCC1 VA: 0x156FBC0
	private static void OnPreRender(Camera cam) { }

	// RVA: 0x156FE70 Offset: 0x156FF71 VA: 0x156FE70
	private static void OnPreRenderCanvas() { }

	// RVA: 0x156FF00 Offset: 0x1570001 VA: 0x156FF00
	public static Material GetStencilMaterial(Material baseMaterial, int stencilID) { }

	// RVA: 0x15702E0 Offset: 0x15703E1 VA: 0x15702E0
	public static void ReleaseStencilMaterial(Material stencilMaterial) { }

	// RVA: 0x1570550 Offset: 0x1570651 VA: 0x1570550
	public static Material GetBaseMaterial(Material stencilMaterial) { }

	// RVA: 0x15706D0 Offset: 0x15707D1 VA: 0x15706D0
	public static Material SetStencil(Material material, int stencilID) { }

	// RVA: 0x15707C0 Offset: 0x15708C1 VA: 0x15707C0
	public static void AddMaskingMaterial(Material baseMaterial, Material stencilMaterial, int stencilID) { }

	// RVA: 0x1570A30 Offset: 0x1570B31 VA: 0x1570A30
	public static void RemoveStencilMaterial(Material stencilMaterial) { }

	// RVA: 0x1570B90 Offset: 0x1570C91 VA: 0x1570B90
	public static void ReleaseBaseMaterial(Material baseMaterial) { }

	// RVA: 0x15712D0 Offset: 0x15713D1 VA: 0x15712D0
	public static void ClearMaterials() { }

	// RVA: 0x1571480 Offset: 0x1571581 VA: 0x1571480
	public static int GetStencilID(GameObject obj) { }

	// RVA: 0x1571910 Offset: 0x1571A11 VA: 0x1571910
	public static Material GetMaterialForRendering(MaskableGraphic graphic, Material baseMaterial) { }

	// RVA: 0x1571780 Offset: 0x1571881 VA: 0x1571780
	private static Transform FindRootSortOverrideCanvas(Transform start) { }

	// RVA: 0x1571AF0 Offset: 0x1571BF1 VA: 0x1571AF0
	internal static Material GetFallbackMaterial(TMP_FontAsset fontAsset, Material sourceMaterial, int atlasIndex) { }

	// RVA: 0x1571D70 Offset: 0x1571E71 VA: 0x1571D70
	public static Material GetFallbackMaterial(Material sourceMaterial, Material targetMaterial) { }

	// RVA: 0x1572150 Offset: 0x1572251 VA: 0x1572150
	public static void AddFallbackMaterialReference(Material targetMaterial) { }

	// RVA: 0x1572290 Offset: 0x1572391 VA: 0x1572290
	public static void RemoveFallbackMaterialReference(Material targetMaterial) { }

	// RVA: 0x156FC50 Offset: 0x156FD51 VA: 0x156FC50
	public static void CleanupFallbackMaterials() { }

	// RVA: 0x1572430 Offset: 0x1572531 VA: 0x1572430
	public static void ReleaseFallbackMaterial(Material fallackMaterial) { }

	// RVA: 0x15725E0 Offset: 0x15726E1 VA: 0x15725E0
	public static void CopyMaterialPresetProperties(Material source, Material destination) { }
}

