[RequireComponent] // RVA: 0x149430 Offset: 0x149531 VA: 0x149430
public class LightningRenderer : BaseSpriteInstancedRenderer // TypeDefIndex: 9695
{
	// Fields
	private static List<LightningSpawnArea> m_SpawnAreas; // 0x0
	private float m_LightningProbability; // 0x88
	private float m_NextSpawnTime; // 0x8C
	private SkyProfile m_SkyProfile; // 0x90
	private LightningArtItem m_Style; // 0x98
	private float m_TimeOfDay; // 0xA0
	private AudioSource m_AudioSource; // 0xA8
	private float m_LightningIntensity; // 0xB0
	private float m_ThunderSoundDelay; // 0xB4
	private float m_SpawnCoolDown; // 0xB8
	private const float k_ProbabiltyCheckInterval = 0.5;

	// Methods

	// RVA: 0x22B3090 Offset: 0x22B3191 VA: 0x22B3090
	private void Start() { }

	// RVA: 0x22B3150 Offset: 0x22B3251 VA: 0x22B3150 Slot: 4
	protected override Bounds CalculateMeshBounds() { }

	// RVA: 0x22B3230 Offset: 0x22B3331 VA: 0x22B3230 Slot: 5
	protected override BaseSpriteItemData CreateSpriteItemData() { }

	// RVA: 0x22B32A0 Offset: 0x22B33A1 VA: 0x22B32A0 Slot: 6
	protected override bool IsRenderingEnabled() { }

	// RVA: 0x22B3390 Offset: 0x22B3491 VA: 0x22B3390 Slot: 8
	protected override void CalculateSpriteTRS(BaseSpriteItemData data, out Vector3 spritePosition, out Quaternion spriteRotation, out Vector3 spriteScale) { }

	// RVA: 0x22B3860 Offset: 0x22B3961 VA: 0x22B3860 Slot: 9
	protected override void ConfigureSpriteItemData(BaseSpriteItemData data) { }

	// RVA: 0x22B38F0 Offset: 0x22B39F1 VA: 0x22B38F0 Slot: 10
	protected override void PrepareDataArraysForRendering(int instanceId, BaseSpriteItemData data) { }

	// RVA: 0x22B3900 Offset: 0x22B3A01 VA: 0x22B3900 Slot: 11
	protected override void PopulatePropertyBlockForRendering(ref MaterialPropertyBlock propertyBlock) { }

	// RVA: 0x22B3970 Offset: 0x22B3A71 VA: 0x22B3970 Slot: 7
	protected override int GetNextSpawnCount() { }

	// RVA: 0x22B2EA0 Offset: 0x22B2FA1 VA: 0x22B2EA0
	public void UpdateForTimeOfDay(SkyProfile skyProfile, float timeOfDay, LightningArtItem artItem) { }

	// RVA: 0x22B3A10 Offset: 0x22B3B11 VA: 0x22B3A10
	private void SyncDataFromSkyProfile() { }

	// RVA: 0x22B3600 Offset: 0x22B3701 VA: 0x22B3600
	private LightningSpawnArea GetRandomLightningSpawnArea() { }

	// RVA: 0x22B3E60 Offset: 0x22B3F61 VA: 0x22B3E60
	private void PlayThunderBoltSound() { }

	// RVA: 0x22B3F90 Offset: 0x22B4091 VA: 0x22B3F90
	public static void AddSpawnArea(LightningSpawnArea area) { }

	// RVA: 0x22B4060 Offset: 0x22B4161 VA: 0x22B4060
	public static void RemoveSpawnArea(LightningSpawnArea area) { }

	// RVA: 0x22B3770 Offset: 0x22B3871 VA: 0x22B3770
	private Vector3 GetRandomWorldPositionInsideSpawnArea(LightningSpawnArea area) { }

	// RVA: 0x22B3730 Offset: 0x22B3831 VA: 0x22B3730
	private float CalculateLightningBoltScaleForArea(LightningSpawnArea area) { }

	// RVA: 0x22B4130 Offset: 0x22B4231 VA: 0x22B4130
	public void .ctor() { }

	// RVA: 0x22B4140 Offset: 0x22B4241 VA: 0x22B4140
	private static void .cctor() { }
}

