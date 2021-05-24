public class RainSplashRenderer : BaseSpriteInstancedRenderer // TypeDefIndex: 9700
{
	// Fields
	private Camera m_DepthCamera; // 0x88
	private float[] m_StartSplashYPositions; // 0x90
	private float[] m_DepthUs; // 0x98
	private float[] m_DepthVs; // 0xA0
	private float m_SplashAreaStart; // 0xA8
	private float m_SplashAreaLength; // 0xAC
	private float m_SplashScale; // 0xB0
	private float m_SplashScaleVarience; // 0xB4
	private float m_SplashItensity; // 0xB8
	private float m_SplashSurfaceOffset; // 0xBC
	private SkyProfile m_SkyProfile; // 0xC0
	private float m_TimeOfDay; // 0xC8
	private RainSplashArtItem m_Style; // 0xD0
	private Bounds m_Bounds; // 0xD8

	// Methods

	// RVA: 0x22B79B0 Offset: 0x22B7AB1 VA: 0x22B79B0
	private void Start() { }

	// RVA: 0x22B7AE0 Offset: 0x22B7BE1 VA: 0x22B7AE0 Slot: 4
	protected override Bounds CalculateMeshBounds() { }

	// RVA: 0x22B7B00 Offset: 0x22B7C01 VA: 0x22B7B00 Slot: 5
	protected override BaseSpriteItemData CreateSpriteItemData() { }

	// RVA: 0x22B7B70 Offset: 0x22B7C71 VA: 0x22B7B70 Slot: 6
	protected override bool IsRenderingEnabled() { }

	// RVA: 0x22B7C90 Offset: 0x22B7D91 VA: 0x22B7C90 Slot: 7
	protected override int GetNextSpawnCount() { }

	// RVA: 0x22B7CF0 Offset: 0x22B7DF1 VA: 0x22B7CF0 Slot: 8
	protected override void CalculateSpriteTRS(BaseSpriteItemData data, out Vector3 spritePosition, out Quaternion spriteRotation, out Vector3 spriteScale) { }

	// RVA: 0x22B7E00 Offset: 0x22B7F01 VA: 0x22B7E00 Slot: 9
	protected override void ConfigureSpriteItemData(BaseSpriteItemData data) { }

	// RVA: 0x22B7FE0 Offset: 0x22B80E1 VA: 0x22B7FE0 Slot: 10
	protected override void PrepareDataArraysForRendering(int instanceId, BaseSpriteItemData data) { }

	// RVA: 0x22B8160 Offset: 0x22B8261 VA: 0x22B8160 Slot: 11
	protected override void PopulatePropertyBlockForRendering(ref MaterialPropertyBlock propertyBlock) { }

	// RVA: 0x22B7820 Offset: 0x22B7921 VA: 0x22B7820
	public void UpdateForTimeOfDay(SkyProfile skyProfile, float timeOfDay, RainSplashArtItem style) { }

	// RVA: 0x22B8250 Offset: 0x22B8351 VA: 0x22B8250
	private void SyncDataFromSkyProfile() { }

	// RVA: 0x22B7E50 Offset: 0x22B7F51 VA: 0x22B7E50
	private Vector3 CreateWorldSplashPoint() { }

	// RVA: 0x22B84B0 Offset: 0x22B85B1 VA: 0x22B84B0
	public void .ctor() { }
}

public class RainSplashRenderer : BaseSpriteInstancedRenderer // TypeDefIndex: 9700
{
	// Fields
	private Camera m_DepthCamera; // 0x88
	private float[] m_StartSplashYPositions; // 0x90
	private float[] m_DepthUs; // 0x98
	private float[] m_DepthVs; // 0xA0
	private float m_SplashAreaStart; // 0xA8
	private float m_SplashAreaLength; // 0xAC
	private float m_SplashScale; // 0xB0
	private float m_SplashScaleVarience; // 0xB4
	private float m_SplashItensity; // 0xB8
	private float m_SplashSurfaceOffset; // 0xBC
	private SkyProfile m_SkyProfile; // 0xC0
	private float m_TimeOfDay; // 0xC8
	private RainSplashArtItem m_Style; // 0xD0
	private Bounds m_Bounds; // 0xD8

	// Methods

	// RVA: 0x22B79B0 Offset: 0x22B7AB1 VA: 0x22B79B0
	private void Start() { }

	// RVA: 0x22B7AE0 Offset: 0x22B7BE1 VA: 0x22B7AE0 Slot: 4
	protected override Bounds CalculateMeshBounds() { }

	// RVA: 0x22B7B00 Offset: 0x22B7C01 VA: 0x22B7B00 Slot: 5
	protected override BaseSpriteItemData CreateSpriteItemData() { }

	// RVA: 0x22B7B70 Offset: 0x22B7C71 VA: 0x22B7B70 Slot: 6
	protected override bool IsRenderingEnabled() { }

	// RVA: 0x22B7C90 Offset: 0x22B7D91 VA: 0x22B7C90 Slot: 7
	protected override int GetNextSpawnCount() { }

	// RVA: 0x22B7CF0 Offset: 0x22B7DF1 VA: 0x22B7CF0 Slot: 8
	protected override void CalculateSpriteTRS(BaseSpriteItemData data, out Vector3 spritePosition, out Quaternion spriteRotation, out Vector3 spriteScale) { }

	// RVA: 0x22B7E00 Offset: 0x22B7F01 VA: 0x22B7E00 Slot: 9
	protected override void ConfigureSpriteItemData(BaseSpriteItemData data) { }

	// RVA: 0x22B7FE0 Offset: 0x22B80E1 VA: 0x22B7FE0 Slot: 10
	protected override void PrepareDataArraysForRendering(int instanceId, BaseSpriteItemData data) { }

	// RVA: 0x22B8160 Offset: 0x22B8261 VA: 0x22B8160 Slot: 11
	protected override void PopulatePropertyBlockForRendering(ref MaterialPropertyBlock propertyBlock) { }

	// RVA: 0x22B7820 Offset: 0x22B7921 VA: 0x22B7820
	public void UpdateForTimeOfDay(SkyProfile skyProfile, float timeOfDay, RainSplashArtItem style) { }

	// RVA: 0x22B8250 Offset: 0x22B8351 VA: 0x22B8250
	private void SyncDataFromSkyProfile() { }

	// RVA: 0x22B7E50 Offset: 0x22B7F51 VA: 0x22B7E50
	private Vector3 CreateWorldSplashPoint() { }

	// RVA: 0x22B84B0 Offset: 0x22B85B1 VA: 0x22B84B0
	public void .ctor() { }
}

public class RainSplashRenderer : BaseSpriteInstancedRenderer // TypeDefIndex: 9700
{
	// Fields
	private Camera m_DepthCamera; // 0x88
	private float[] m_StartSplashYPositions; // 0x90
	private float[] m_DepthUs; // 0x98
	private float[] m_DepthVs; // 0xA0
	private float m_SplashAreaStart; // 0xA8
	private float m_SplashAreaLength; // 0xAC
	private float m_SplashScale; // 0xB0
	private float m_SplashScaleVarience; // 0xB4
	private float m_SplashItensity; // 0xB8
	private float m_SplashSurfaceOffset; // 0xBC
	private SkyProfile m_SkyProfile; // 0xC0
	private float m_TimeOfDay; // 0xC8
	private RainSplashArtItem m_Style; // 0xD0
	private Bounds m_Bounds; // 0xD8

	// Methods

	// RVA: 0x22B79B0 Offset: 0x22B7AB1 VA: 0x22B79B0
	private void Start() { }

	// RVA: 0x22B7AE0 Offset: 0x22B7BE1 VA: 0x22B7AE0 Slot: 4
	protected override Bounds CalculateMeshBounds() { }

	// RVA: 0x22B7B00 Offset: 0x22B7C01 VA: 0x22B7B00 Slot: 5
	protected override BaseSpriteItemData CreateSpriteItemData() { }

	// RVA: 0x22B7B70 Offset: 0x22B7C71 VA: 0x22B7B70 Slot: 6
	protected override bool IsRenderingEnabled() { }

	// RVA: 0x22B7C90 Offset: 0x22B7D91 VA: 0x22B7C90 Slot: 7
	protected override int GetNextSpawnCount() { }

	// RVA: 0x22B7CF0 Offset: 0x22B7DF1 VA: 0x22B7CF0 Slot: 8
	protected override void CalculateSpriteTRS(BaseSpriteItemData data, out Vector3 spritePosition, out Quaternion spriteRotation, out Vector3 spriteScale) { }

	// RVA: 0x22B7E00 Offset: 0x22B7F01 VA: 0x22B7E00 Slot: 9
	protected override void ConfigureSpriteItemData(BaseSpriteItemData data) { }

	// RVA: 0x22B7FE0 Offset: 0x22B80E1 VA: 0x22B7FE0 Slot: 10
	protected override void PrepareDataArraysForRendering(int instanceId, BaseSpriteItemData data) { }

	// RVA: 0x22B8160 Offset: 0x22B8261 VA: 0x22B8160 Slot: 11
	protected override void PopulatePropertyBlockForRendering(ref MaterialPropertyBlock propertyBlock) { }

	// RVA: 0x22B7820 Offset: 0x22B7921 VA: 0x22B7820
	public void UpdateForTimeOfDay(SkyProfile skyProfile, float timeOfDay, RainSplashArtItem style) { }

	// RVA: 0x22B8250 Offset: 0x22B8351 VA: 0x22B8250
	private void SyncDataFromSkyProfile() { }

	// RVA: 0x22B7E50 Offset: 0x22B7F51 VA: 0x22B7E50
	private Vector3 CreateWorldSplashPoint() { }

	// RVA: 0x22B84B0 Offset: 0x22B85B1 VA: 0x22B84B0
	public void .ctor() { }
}

public class RainSplashRenderer : BaseSpriteInstancedRenderer // TypeDefIndex: 9700
{
	// Fields
	private Camera m_DepthCamera; // 0x88
	private float[] m_StartSplashYPositions; // 0x90
	private float[] m_DepthUs; // 0x98
	private float[] m_DepthVs; // 0xA0
	private float m_SplashAreaStart; // 0xA8
	private float m_SplashAreaLength; // 0xAC
	private float m_SplashScale; // 0xB0
	private float m_SplashScaleVarience; // 0xB4
	private float m_SplashItensity; // 0xB8
	private float m_SplashSurfaceOffset; // 0xBC
	private SkyProfile m_SkyProfile; // 0xC0
	private float m_TimeOfDay; // 0xC8
	private RainSplashArtItem m_Style; // 0xD0
	private Bounds m_Bounds; // 0xD8

	// Methods

	// RVA: 0x22B79B0 Offset: 0x22B7AB1 VA: 0x22B79B0
	private void Start() { }

	// RVA: 0x22B7AE0 Offset: 0x22B7BE1 VA: 0x22B7AE0 Slot: 4
	protected override Bounds CalculateMeshBounds() { }

	// RVA: 0x22B7B00 Offset: 0x22B7C01 VA: 0x22B7B00 Slot: 5
	protected override BaseSpriteItemData CreateSpriteItemData() { }

	// RVA: 0x22B7B70 Offset: 0x22B7C71 VA: 0x22B7B70 Slot: 6
	protected override bool IsRenderingEnabled() { }

	// RVA: 0x22B7C90 Offset: 0x22B7D91 VA: 0x22B7C90 Slot: 7
	protected override int GetNextSpawnCount() { }

	// RVA: 0x22B7CF0 Offset: 0x22B7DF1 VA: 0x22B7CF0 Slot: 8
	protected override void CalculateSpriteTRS(BaseSpriteItemData data, out Vector3 spritePosition, out Quaternion spriteRotation, out Vector3 spriteScale) { }

	// RVA: 0x22B7E00 Offset: 0x22B7F01 VA: 0x22B7E00 Slot: 9
	protected override void ConfigureSpriteItemData(BaseSpriteItemData data) { }

	// RVA: 0x22B7FE0 Offset: 0x22B80E1 VA: 0x22B7FE0 Slot: 10
	protected override void PrepareDataArraysForRendering(int instanceId, BaseSpriteItemData data) { }

	// RVA: 0x22B8160 Offset: 0x22B8261 VA: 0x22B8160 Slot: 11
	protected override void PopulatePropertyBlockForRendering(ref MaterialPropertyBlock propertyBlock) { }

	// RVA: 0x22B7820 Offset: 0x22B7921 VA: 0x22B7820
	public void UpdateForTimeOfDay(SkyProfile skyProfile, float timeOfDay, RainSplashArtItem style) { }

	// RVA: 0x22B8250 Offset: 0x22B8351 VA: 0x22B8250
	private void SyncDataFromSkyProfile() { }

	// RVA: 0x22B7E50 Offset: 0x22B7F51 VA: 0x22B7E50
	private Vector3 CreateWorldSplashPoint() { }

	// RVA: 0x22B84B0 Offset: 0x22B85B1 VA: 0x22B84B0
	public void .ctor() { }
}

public class RainSplashRenderer : BaseSpriteInstancedRenderer // TypeDefIndex: 9700
{
	// Fields
	private Camera m_DepthCamera; // 0x88
	private float[] m_StartSplashYPositions; // 0x90
	private float[] m_DepthUs; // 0x98
	private float[] m_DepthVs; // 0xA0
	private float m_SplashAreaStart; // 0xA8
	private float m_SplashAreaLength; // 0xAC
	private float m_SplashScale; // 0xB0
	private float m_SplashScaleVarience; // 0xB4
	private float m_SplashItensity; // 0xB8
	private float m_SplashSurfaceOffset; // 0xBC
	private SkyProfile m_SkyProfile; // 0xC0
	private float m_TimeOfDay; // 0xC8
	private RainSplashArtItem m_Style; // 0xD0
	private Bounds m_Bounds; // 0xD8

	// Methods

	// RVA: 0x22B79B0 Offset: 0x22B7AB1 VA: 0x22B79B0
	private void Start() { }

	// RVA: 0x22B7AE0 Offset: 0x22B7BE1 VA: 0x22B7AE0 Slot: 4
	protected override Bounds CalculateMeshBounds() { }

	// RVA: 0x22B7B00 Offset: 0x22B7C01 VA: 0x22B7B00 Slot: 5
	protected override BaseSpriteItemData CreateSpriteItemData() { }

	// RVA: 0x22B7B70 Offset: 0x22B7C71 VA: 0x22B7B70 Slot: 6
	protected override bool IsRenderingEnabled() { }

	// RVA: 0x22B7C90 Offset: 0x22B7D91 VA: 0x22B7C90 Slot: 7
	protected override int GetNextSpawnCount() { }

	// RVA: 0x22B7CF0 Offset: 0x22B7DF1 VA: 0x22B7CF0 Slot: 8
	protected override void CalculateSpriteTRS(BaseSpriteItemData data, out Vector3 spritePosition, out Quaternion spriteRotation, out Vector3 spriteScale) { }

	// RVA: 0x22B7E00 Offset: 0x22B7F01 VA: 0x22B7E00 Slot: 9
	protected override void ConfigureSpriteItemData(BaseSpriteItemData data) { }

	// RVA: 0x22B7FE0 Offset: 0x22B80E1 VA: 0x22B7FE0 Slot: 10
	protected override void PrepareDataArraysForRendering(int instanceId, BaseSpriteItemData data) { }

	// RVA: 0x22B8160 Offset: 0x22B8261 VA: 0x22B8160 Slot: 11
	protected override void PopulatePropertyBlockForRendering(ref MaterialPropertyBlock propertyBlock) { }

	// RVA: 0x22B7820 Offset: 0x22B7921 VA: 0x22B7820
	public void UpdateForTimeOfDay(SkyProfile skyProfile, float timeOfDay, RainSplashArtItem style) { }

	// RVA: 0x22B8250 Offset: 0x22B8351 VA: 0x22B8250
	private void SyncDataFromSkyProfile() { }

	// RVA: 0x22B7E50 Offset: 0x22B7F51 VA: 0x22B7E50
	private Vector3 CreateWorldSplashPoint() { }

	// RVA: 0x22B84B0 Offset: 0x22B85B1 VA: 0x22B84B0
	public void .ctor() { }
}

