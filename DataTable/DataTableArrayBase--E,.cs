public abstract class DataTableArrayBase<E, T, S> : ScriptableObject // TypeDefIndex: 10545
{
	// Fields
	[SerializeField] // RVA: 0x181DF0 Offset: 0x181EF1 VA: 0x181DF0
	public S[] DataTables; // 0x0
	private ReadOnlyDictionary<int, T> DataTableDic; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private void Awake() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C88C80 Offset: 0x2C88D81 VA: 0x2C88C80
	|-DataTableArrayBase<int, object, object>.Awake
	|
	|-RVA: 0x2C894D0 Offset: 0x2C895D1 VA: 0x2C894D0
	|-DataTableArrayBase<Int32Enum, CropDataTable, object>.Awake
	|
	|-RVA: 0x2C89DA0 Offset: 0x2C89EA1 VA: 0x2C89DA0
	|-DataTableArrayBase<Int32Enum, EffectDataTable, object>.Awake
	|
	|-RVA: 0x2C8A630 Offset: 0x2C8A731 VA: 0x2C8A630
	|-DataTableArrayBase<Int32Enum, GimmickLayoutDataTable, object>.Awake
	|
	|-RVA: 0x2C8AE80 Offset: 0x2C8AF81 VA: 0x2C8AE80
	|-DataTableArrayBase<Int32Enum, MineTypeDataTable, object>.Awake
	|
	|-RVA: 0x2C8B750 Offset: 0x2C8B851 VA: 0x2C8B750
	|-DataTableArrayBase<Int32Enum, MiningDataTable, object>.Awake
	|
	|-RVA: 0x2C8BFA0 Offset: 0x2C8C0A1 VA: 0x2C8BFA0
	|-DataTableArrayBase<Int32Enum, object, object>.Awake
	|
	|-RVA: 0x2C8C7F0 Offset: 0x2C8C8F1 VA: 0x2C8C7F0
	|-DataTableArrayBase<object, object, object>.Awake
	*/

	// RVA: -1 Offset: -1
	public T GetDataTableByDictionary(E id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C89520 Offset: 0x2C89621 VA: 0x2C89520
	|-DataTableArrayBase<CropID, CropDataTable, SerializeCropDataTable>.GetDataTableByDictionary
	|-DataTableArrayBase<Int32Enum, CropDataTable, object>.GetDataTableByDictionary
	|
	|-RVA: 0x2C8BFF0 Offset: 0x2C8C0F1 VA: 0x2C8BFF0
	|-DataTableArrayBase<ActorID, DualSkillDataTable, SerializeDualSkillDataTable>.GetDataTableByDictionary
	|-DataTableArrayBase<ActorID, DualSmithActorDataTable, SerializeDualSmithActorDataTable>.GetDataTableByDictionary
	|-DataTableArrayBase<ActorID, HumanParamDataTable, SerializedHumanParamDataTable>.GetDataTableByDictionary
	|-DataTableArrayBase<ActorID, NPCSkillLevelDataTable, SerializedNPCSkillLevelDataTable>.GetDataTableByDictionary
	|-DataTableArrayBase<BitID, BitDataTable, SerializeBitDataTable>.GetDataTableByDictionary
	|-DataTableArrayBase<BulletID, BulletDataTable, SerializeBulletDataTable>.GetDataTableByDictionary
	|-DataTableArrayBase<CharID, CharaVoiceDataTable, SerializeCharaVoiceDataTable>.GetDataTableByDictionary
	|-DataTableArrayBase<CharID, PersonalMotionDataTable, SerializePersonalMotionDataTable>.GetDataTableByDictionary
	|-DataTableArrayBase<ClothShopID, ClothShopDataTable, SerializeClothShopDataTable>.GetDataTableByDictionary
	|-DataTableArrayBase<DLCID, DLCClothDataTable, SerializeDLCClothDataTable>.GetDataTableByDictionary
	|-DataTableArrayBase<FootStepType, FootStepDataTable, SerializeFootStepDataTable>.GetDataTableByDictionary
	|-DataTableArrayBase<HitSoundID, HitSoundDataTable, SerializeHitSoundDataTable>.GetDataTableByDictionary
	|-DataTableArrayBase<HotSpringID, HotSpringDataTable, SerializeHotSpringDataTable>.GetDataTableByDictionary
	|-DataTableArrayBase<HumanActionID, HumanActionDataTable, SerializeHumanActionDataTable>.GetDataTableByDictionary
	|-DataTableArrayBase<ItemLotteryID, ItemLotteryDataTable, SerializeItemLotteryDataTable>.GetDataTableByDictionary
	|-DataTableArrayBase<ItemLotteryWeightID, ItemLotteryWeightDataTable, SerializeItemLotteryWeightDataTable>.GetDataTableByDictionary
	|-DataTableArrayBase<MagicID, MagicDataTable, SerializeMagicDataTable>.GetDataTableByDictionary
	|-DataTableArrayBase<MagicParamID, MagicParamDataTable, SerializeMagicParamDataTable>.GetDataTableByDictionary
	|-DataTableArrayBase<Place, DoorDataTable, SerializedDoorDataTable>.GetDataTableByDictionary
	|-DataTableArrayBase<RecipePanShopID, RecipePanShopDataTable, SerializeRecipePanShopDataTable>.GetDataTableByDictionary
	|-DataTableArrayBase<SeedSupportID, SeedSupportDataTable, SerializeSeedSupportDataTable>.GetDataTableByDictionary
	|-DataTableArrayBase<SkillActionID, SkillActionDataTable, SerializedSkillActionDataTable>.GetDataTableByDictionary
	|-DataTableArrayBase<SkillID, SkillDataTable, SerializedSkillDataTable>.GetDataTableByDictionary
	|-DataTableArrayBase<SkillLevelupType, SkillLevelupTypeDataTable, SerializedSkillLevelupTypeDataTable>.GetDataTableByDictionary
	|-DataTableArrayBase<StrengtheningEtcID, StrengtheningEtcDataTable, SerializeStrengtheningEtcDataTable>.GetDataTableByDictionary
	|-DataTableArrayBase<TimeScaleID, TimeScaleDataTable, SerializeTimeScaleDataTable>.GetDataTableByDictionary
	|-DataTableArrayBase<VaccinationID, VaccinationDataTable, SerializeVaccinationDataTable>.GetDataTableByDictionary
	|-DataTableArrayBase<VoiceGroup, VoiceGroupDataTable, SerializeVoiceGroupDataTable>.GetDataTableByDictionary
	|-DataTableArrayBase<WeatherDay, MobDeployWeatherDataTable, SerializeMobDeployWeatherDataTable>.GetDataTableByDictionary
	|-DataTableArrayBase<FieldTeleportID, FieldTeleportDataTable, SerializedFieldTeleportDataTable>.GetDataTableByDictionary
	|-DataTableArrayBase<ItemCategory, PresentItemCategoryLotteryDataTable, SerializedPresentItemCategoryLotteryDataTable>.GetDataTableByDictionary
	|-DataTableArrayBase<ItemID, CrystalDataTable, SerializeCrystalDataTable>.GetDataTableByDictionary
	|-DataTableArrayBase<ItemID, DropSeedDataTable, SerializedDropSeedDataTable>.GetDataTableByDictionary
	|-DataTableArrayBase<ItemID, EquipItemDataTable, SerializeEquipItemDataTable>.GetDataTableByDictionary
	|-DataTableArrayBase<ItemID, ItemDataTable, SerializedItemDataTable>.GetDataTableByDictionary
	|-DataTableArrayBase<ItemID, ItemStrengtheningDataTable, SerializedStrengtheningDataTable>.GetDataTableByDictionary
	|-DataTableArrayBase<ItemID, PresentItemParamDataTable, SerializedPresentItemParamDataTable>.GetDataTableByDictionary
	|-DataTableArrayBase<ItemID, UseParamDataTable, SerializeUseParamDataTable>.GetDataTableByDictionary
	|-DataTableArrayBase<ItemLevelWeightID, ItemLevelWeightDataTable, SerializedItemLevelWeightDataTable>.GetDataTableByDictionary
	|-DataTableArrayBase<SoundID, SoundDataTable, SerializeSoundDataTable>.GetDataTableByDictionary
	|-DataTableArrayBase<Int32Enum, object, object>.GetDataTableByDictionary
	|
	|-RVA: 0x2C89DF0 Offset: 0x2C89EF1 VA: 0x2C89DF0
	|-DataTableArrayBase<EffectID, EffectDataTable, SerializeEffectDataTable>.GetDataTableByDictionary
	|-DataTableArrayBase<Int32Enum, EffectDataTable, object>.GetDataTableByDictionary
	|
	|-RVA: 0x2C8A680 Offset: 0x2C8A781 VA: 0x2C8A680
	|-DataTableArrayBase<GimmickLayoutID, GimmickLayoutDataTable, SerializedGimmickLayoutDataTable>.GetDataTableByDictionary
	|-DataTableArrayBase<Int32Enum, GimmickLayoutDataTable, object>.GetDataTableByDictionary
	|
	|-RVA: 0x2C8AED0 Offset: 0x2C8AFD1 VA: 0x2C8AED0
	|-DataTableArrayBase<MineTypeID, MineTypeDataTable, SerializeMineTypeDataTable>.GetDataTableByDictionary
	|-DataTableArrayBase<Int32Enum, MineTypeDataTable, object>.GetDataTableByDictionary
	|
	|-RVA: 0x2C8B7A0 Offset: 0x2C8B8A1 VA: 0x2C8B7A0
	|-DataTableArrayBase<MiningID, MiningDataTable, SerializeMiningDataTable>.GetDataTableByDictionary
	|-DataTableArrayBase<Int32Enum, MiningDataTable, object>.GetDataTableByDictionary
	|
	|-RVA: 0x2C88CD0 Offset: 0x2C88DD1 VA: 0x2C88CD0
	|-DataTableArrayBase<int, DualWorkDataTable, SerializeDualWorkDataTable>.GetDataTableByDictionary
	|-DataTableArrayBase<int, DualWorkSmithDataTable, SerializeDualWorkSmithDataTable>.GetDataTableByDictionary
	|-DataTableArrayBase<int, object, object>.GetDataTableByDictionary
	|
	|-RVA: 0x2C8C840 Offset: 0x2C8C941 VA: 0x2C8C840
	|-DataTableArrayBase<object, object, object>.GetDataTableByDictionary
	*/

	// RVA: -1 Offset: -1
	public bool HasDataTableByDictionary(E id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C8C120 Offset: 0x2C8C221 VA: 0x2C8C120
	|-DataTableArrayBase<ActorID, DualSkillDataTable, SerializeDualSkillDataTable>.HasDataTableByDictionary
	|-DataTableArrayBase<ActorID, HumanParamDataTable, SerializedHumanParamDataTable>.HasDataTableByDictionary
	|-DataTableArrayBase<BitID, BitDataTable, SerializeBitDataTable>.HasDataTableByDictionary
	|-DataTableArrayBase<BulletID, BulletDataTable, SerializeBulletDataTable>.HasDataTableByDictionary
	|-DataTableArrayBase<CharID, CharaVoiceDataTable, SerializeCharaVoiceDataTable>.HasDataTableByDictionary
	|-DataTableArrayBase<CharID, PersonalMotionDataTable, SerializePersonalMotionDataTable>.HasDataTableByDictionary
	|-DataTableArrayBase<DLCID, DLCClothDataTable, SerializeDLCClothDataTable>.HasDataTableByDictionary
	|-DataTableArrayBase<FootStepType, FootStepDataTable, SerializeFootStepDataTable>.HasDataTableByDictionary
	|-DataTableArrayBase<HitSoundID, HitSoundDataTable, SerializeHitSoundDataTable>.HasDataTableByDictionary
	|-DataTableArrayBase<HumanActionID, HumanActionDataTable, SerializeHumanActionDataTable>.HasDataTableByDictionary
	|-DataTableArrayBase<MagicID, MagicDataTable, SerializeMagicDataTable>.HasDataTableByDictionary
	|-DataTableArrayBase<MagicParamID, MagicParamDataTable, SerializeMagicParamDataTable>.HasDataTableByDictionary
	|-DataTableArrayBase<Place, DoorDataTable, SerializedDoorDataTable>.HasDataTableByDictionary
	|-DataTableArrayBase<SeedSupportID, SeedSupportDataTable, SerializeSeedSupportDataTable>.HasDataTableByDictionary
	|-DataTableArrayBase<SkillActionID, SkillActionDataTable, SerializedSkillActionDataTable>.HasDataTableByDictionary
	|-DataTableArrayBase<TimeScaleID, TimeScaleDataTable, SerializeTimeScaleDataTable>.HasDataTableByDictionary
	|-DataTableArrayBase<VoiceGroup, VoiceGroupDataTable, SerializeVoiceGroupDataTable>.HasDataTableByDictionary
	|-DataTableArrayBase<WeatherDay, MobDeployWeatherDataTable, SerializeMobDeployWeatherDataTable>.HasDataTableByDictionary
	|-DataTableArrayBase<FieldTeleportID, FieldTeleportDataTable, SerializedFieldTeleportDataTable>.HasDataTableByDictionary
	|-DataTableArrayBase<ItemCategory, PresentItemCategoryLotteryDataTable, SerializedPresentItemCategoryLotteryDataTable>.HasDataTableByDictionary
	|-DataTableArrayBase<ItemID, CrystalDataTable, SerializeCrystalDataTable>.HasDataTableByDictionary
	|-DataTableArrayBase<ItemID, DropSeedDataTable, SerializedDropSeedDataTable>.HasDataTableByDictionary
	|-DataTableArrayBase<ItemID, EquipItemDataTable, SerializeEquipItemDataTable>.HasDataTableByDictionary
	|-DataTableArrayBase<ItemID, ItemStrengtheningDataTable, SerializedStrengtheningDataTable>.HasDataTableByDictionary
	|-DataTableArrayBase<ItemID, PresentItemParamDataTable, SerializedPresentItemParamDataTable>.HasDataTableByDictionary
	|-DataTableArrayBase<ItemID, UseParamDataTable, SerializeUseParamDataTable>.HasDataTableByDictionary
	|-DataTableArrayBase<Int32Enum, object, object>.HasDataTableByDictionary
	|
	|-RVA: 0x2C89F40 Offset: 0x2C8A041 VA: 0x2C89F40
	|-DataTableArrayBase<EffectID, EffectDataTable, SerializeEffectDataTable>.HasDataTableByDictionary
	|-DataTableArrayBase<Int32Enum, EffectDataTable, object>.HasDataTableByDictionary
	|
	|-RVA: 0x2C88E00 Offset: 0x2C88F01 VA: 0x2C88E00
	|-DataTableArrayBase<int, object, object>.HasDataTableByDictionary
	|
	|-RVA: 0x2C896A0 Offset: 0x2C897A1 VA: 0x2C896A0
	|-DataTableArrayBase<Int32Enum, CropDataTable, object>.HasDataTableByDictionary
	|
	|-RVA: 0x2C8A7B0 Offset: 0x2C8A8B1 VA: 0x2C8A7B0
	|-DataTableArrayBase<Int32Enum, GimmickLayoutDataTable, object>.HasDataTableByDictionary
	|
	|-RVA: 0x2C8B050 Offset: 0x2C8B151 VA: 0x2C8B050
	|-DataTableArrayBase<Int32Enum, MineTypeDataTable, object>.HasDataTableByDictionary
	|
	|-RVA: 0x2C8B8D0 Offset: 0x2C8B9D1 VA: 0x2C8B8D0
	|-DataTableArrayBase<Int32Enum, MiningDataTable, object>.HasDataTableByDictionary
	|
	|-RVA: 0x2C8C940 Offset: 0x2C8CA41 VA: 0x2C8C940
	|-DataTableArrayBase<object, object, object>.HasDataTableByDictionary
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public virtual void Init() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C897A0 Offset: 0x2C898A1 VA: 0x2C897A0
	|-DataTableArrayBase<CropID, CropDataTable, SerializeCropDataTable>.Init
	|-DataTableArrayBase<Int32Enum, CropDataTable, object>.Init
	|
	|-RVA: 0x2C8C220 Offset: 0x2C8C321 VA: 0x2C8C220
	|-DataTableArrayBase<ActorID, DualSkillDataTable, SerializeDualSkillDataTable>.Init
	|-DataTableArrayBase<ActorID, DualSmithActorDataTable, SerializeDualSmithActorDataTable>.Init
	|-DataTableArrayBase<ActorID, HumanParamDataTable, SerializedHumanParamDataTable>.Init
	|-DataTableArrayBase<ActorID, NPCSkillLevelDataTable, SerializedNPCSkillLevelDataTable>.Init
	|-DataTableArrayBase<BitID, BitDataTable, SerializeBitDataTable>.Init
	|-DataTableArrayBase<BulletID, BulletDataTable, SerializeBulletDataTable>.Init
	|-DataTableArrayBase<CharID, CharaVoiceDataTable, SerializeCharaVoiceDataTable>.Init
	|-DataTableArrayBase<CharID, PersonalMotionDataTable, SerializePersonalMotionDataTable>.Init
	|-DataTableArrayBase<ClothShopID, ClothShopDataTable, SerializeClothShopDataTable>.Init
	|-DataTableArrayBase<DLCID, DLCClothDataTable, SerializeDLCClothDataTable>.Init
	|-DataTableArrayBase<FootStepType, FootStepDataTable, SerializeFootStepDataTable>.Init
	|-DataTableArrayBase<HitSoundID, HitSoundDataTable, SerializeHitSoundDataTable>.Init
	|-DataTableArrayBase<HotSpringID, HotSpringDataTable, SerializeHotSpringDataTable>.Init
	|-DataTableArrayBase<HumanActionID, HumanActionDataTable, SerializeHumanActionDataTable>.Init
	|-DataTableArrayBase<ItemLotteryID, ItemLotteryDataTable, SerializeItemLotteryDataTable>.Init
	|-DataTableArrayBase<ItemLotteryWeightID, ItemLotteryWeightDataTable, SerializeItemLotteryWeightDataTable>.Init
	|-DataTableArrayBase<MagicID, MagicDataTable, SerializeMagicDataTable>.Init
	|-DataTableArrayBase<MagicParamID, MagicParamDataTable, SerializeMagicParamDataTable>.Init
	|-DataTableArrayBase<Place, DoorDataTable, SerializedDoorDataTable>.Init
	|-DataTableArrayBase<RecipePanShopID, RecipePanShopDataTable, SerializeRecipePanShopDataTable>.Init
	|-DataTableArrayBase<SeedSupportID, SeedSupportDataTable, SerializeSeedSupportDataTable>.Init
	|-DataTableArrayBase<SkillActionID, SkillActionDataTable, SerializedSkillActionDataTable>.Init
	|-DataTableArrayBase<SkillID, SkillDataTable, SerializedSkillDataTable>.Init
	|-DataTableArrayBase<SkillLevelupType, SkillLevelupTypeDataTable, SerializedSkillLevelupTypeDataTable>.Init
	|-DataTableArrayBase<StrengtheningEtcID, StrengtheningEtcDataTable, SerializeStrengtheningEtcDataTable>.Init
	|-DataTableArrayBase<TimeScaleID, TimeScaleDataTable, SerializeTimeScaleDataTable>.Init
	|-DataTableArrayBase<VaccinationID, VaccinationDataTable, SerializeVaccinationDataTable>.Init
	|-DataTableArrayBase<VoiceGroup, VoiceGroupDataTable, SerializeVoiceGroupDataTable>.Init
	|-DataTableArrayBase<WeatherDay, MobDeployWeatherDataTable, SerializeMobDeployWeatherDataTable>.Init
	|-DataTableArrayBase<FieldTeleportID, FieldTeleportDataTable, SerializedFieldTeleportDataTable>.Init
	|-DataTableArrayBase<ItemCategory, PresentItemCategoryLotteryDataTable, SerializedPresentItemCategoryLotteryDataTable>.Init
	|-DataTableArrayBase<ItemID, CrystalDataTable, SerializeCrystalDataTable>.Init
	|-DataTableArrayBase<ItemID, DropSeedDataTable, SerializedDropSeedDataTable>.Init
	|-DataTableArrayBase<ItemID, EquipItemDataTable, SerializeEquipItemDataTable>.Init
	|-DataTableArrayBase<ItemID, ItemDataTable, SerializedItemDataTable>.Init
	|-DataTableArrayBase<ItemID, ItemStrengtheningDataTable, SerializedStrengtheningDataTable>.Init
	|-DataTableArrayBase<ItemID, PresentItemParamDataTable, SerializedPresentItemParamDataTable>.Init
	|-DataTableArrayBase<ItemID, UseParamDataTable, SerializeUseParamDataTable>.Init
	|-DataTableArrayBase<ItemLevelWeightID, ItemLevelWeightDataTable, SerializedItemLevelWeightDataTable>.Init
	|-DataTableArrayBase<SoundID, SoundDataTable, SerializeSoundDataTable>.Init
	|-DataTableArrayBase<Int32Enum, object, object>.Init
	|
	|-RVA: 0x2C8A040 Offset: 0x2C8A141 VA: 0x2C8A040
	|-DataTableArrayBase<EffectID, EffectDataTable, SerializeEffectDataTable>.Init
	|-DataTableArrayBase<Int32Enum, EffectDataTable, object>.Init
	|
	|-RVA: 0x2C8A8B0 Offset: 0x2C8A9B1 VA: 0x2C8A8B0
	|-DataTableArrayBase<GimmickLayoutID, GimmickLayoutDataTable, SerializedGimmickLayoutDataTable>.Init
	|-DataTableArrayBase<Int32Enum, GimmickLayoutDataTable, object>.Init
	|
	|-RVA: 0x2C8B150 Offset: 0x2C8B251 VA: 0x2C8B150
	|-DataTableArrayBase<MineTypeID, MineTypeDataTable, SerializeMineTypeDataTable>.Init
	|-DataTableArrayBase<Int32Enum, MineTypeDataTable, object>.Init
	|
	|-RVA: 0x2C8B9D0 Offset: 0x2C8BAD1 VA: 0x2C8B9D0
	|-DataTableArrayBase<MiningID, MiningDataTable, SerializeMiningDataTable>.Init
	|-DataTableArrayBase<Int32Enum, MiningDataTable, object>.Init
	|
	|-RVA: 0x2C88F00 Offset: 0x2C89001 VA: 0x2C88F00
	|-DataTableArrayBase<int, DualWorkDataTable, SerializeDualWorkDataTable>.Init
	|-DataTableArrayBase<int, DualWorkSmithDataTable, SerializeDualWorkSmithDataTable>.Init
	|-DataTableArrayBase<int, object, object>.Init
	|
	|-RVA: 0x2C8CA20 Offset: 0x2C8CB21 VA: 0x2C8CA20
	|-DataTableArrayBase<object, object, object>.Init
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C89D80 Offset: 0x2C89E81 VA: 0x2C89D80
	|-DataTableArrayBase<CropID, CropDataTable, SerializeCropDataTable>..ctor
	|-DataTableArrayBase<Int32Enum, CropDataTable, object>..ctor
	|
	|-RVA: 0x2C8C7D0 Offset: 0x2C8C8D1 VA: 0x2C8C7D0
	|-DataTableArrayBase<ActorID, DualSkillDataTable, SerializeDualSkillDataTable>..ctor
	|-DataTableArrayBase<ActorID, DualSmithActorDataTable, SerializeDualSmithActorDataTable>..ctor
	|-DataTableArrayBase<ActorID, HumanParamDataTable, SerializedHumanParamDataTable>..ctor
	|-DataTableArrayBase<ActorID, NPCSkillLevelDataTable, SerializedNPCSkillLevelDataTable>..ctor
	|-DataTableArrayBase<BitID, BitDataTable, SerializeBitDataTable>..ctor
	|-DataTableArrayBase<BulletID, BulletDataTable, SerializeBulletDataTable>..ctor
	|-DataTableArrayBase<CharID, CharaVoiceDataTable, SerializeCharaVoiceDataTable>..ctor
	|-DataTableArrayBase<CharID, PersonalMotionDataTable, SerializePersonalMotionDataTable>..ctor
	|-DataTableArrayBase<ClothShopID, ClothShopDataTable, SerializeClothShopDataTable>..ctor
	|-DataTableArrayBase<DLCID, DLCClothDataTable, SerializeDLCClothDataTable>..ctor
	|-DataTableArrayBase<FootStepType, FootStepDataTable, SerializeFootStepDataTable>..ctor
	|-DataTableArrayBase<HitSoundID, HitSoundDataTable, SerializeHitSoundDataTable>..ctor
	|-DataTableArrayBase<HotSpringID, HotSpringDataTable, SerializeHotSpringDataTable>..ctor
	|-DataTableArrayBase<HumanActionID, HumanActionDataTable, SerializeHumanActionDataTable>..ctor
	|-DataTableArrayBase<ItemLotteryID, ItemLotteryDataTable, SerializeItemLotteryDataTable>..ctor
	|-DataTableArrayBase<ItemLotteryWeightID, ItemLotteryWeightDataTable, SerializeItemLotteryWeightDataTable>..ctor
	|-DataTableArrayBase<MagicID, MagicDataTable, SerializeMagicDataTable>..ctor
	|-DataTableArrayBase<MagicParamID, MagicParamDataTable, SerializeMagicParamDataTable>..ctor
	|-DataTableArrayBase<Place, DoorDataTable, SerializedDoorDataTable>..ctor
	|-DataTableArrayBase<RecipePanShopID, RecipePanShopDataTable, SerializeRecipePanShopDataTable>..ctor
	|-DataTableArrayBase<SeedSupportID, SeedSupportDataTable, SerializeSeedSupportDataTable>..ctor
	|-DataTableArrayBase<SkillActionID, SkillActionDataTable, SerializedSkillActionDataTable>..ctor
	|-DataTableArrayBase<SkillID, SkillDataTable, SerializedSkillDataTable>..ctor
	|-DataTableArrayBase<SkillLevelupType, SkillLevelupTypeDataTable, SerializedSkillLevelupTypeDataTable>..ctor
	|-DataTableArrayBase<StrengtheningEtcID, StrengtheningEtcDataTable, SerializeStrengtheningEtcDataTable>..ctor
	|-DataTableArrayBase<TimeScaleID, TimeScaleDataTable, SerializeTimeScaleDataTable>..ctor
	|-DataTableArrayBase<VaccinationID, VaccinationDataTable, SerializeVaccinationDataTable>..ctor
	|-DataTableArrayBase<VoiceGroup, VoiceGroupDataTable, SerializeVoiceGroupDataTable>..ctor
	|-DataTableArrayBase<WeatherDay, MobDeployWeatherDataTable, SerializeMobDeployWeatherDataTable>..ctor
	|-DataTableArrayBase<FieldTeleportID, FieldTeleportDataTable, SerializedFieldTeleportDataTable>..ctor
	|-DataTableArrayBase<ItemCategory, PresentItemCategoryLotteryDataTable, SerializedPresentItemCategoryLotteryDataTable>..ctor
	|-DataTableArrayBase<ItemID, CrystalDataTable, SerializeCrystalDataTable>..ctor
	|-DataTableArrayBase<ItemID, DropSeedDataTable, SerializedDropSeedDataTable>..ctor
	|-DataTableArrayBase<ItemID, EquipItemDataTable, SerializeEquipItemDataTable>..ctor
	|-DataTableArrayBase<ItemID, ItemDataTable, SerializedItemDataTable>..ctor
	|-DataTableArrayBase<ItemID, ItemStrengtheningDataTable, SerializedStrengtheningDataTable>..ctor
	|-DataTableArrayBase<ItemID, PresentItemParamDataTable, SerializedPresentItemParamDataTable>..ctor
	|-DataTableArrayBase<ItemID, UseParamDataTable, SerializeUseParamDataTable>..ctor
	|-DataTableArrayBase<ItemLevelWeightID, ItemLevelWeightDataTable, SerializedItemLevelWeightDataTable>..ctor
	|-DataTableArrayBase<SoundID, SoundDataTable, SerializeSoundDataTable>..ctor
	|-DataTableArrayBase<Int32Enum, object, object>..ctor
	|
	|-RVA: 0x2C8A610 Offset: 0x2C8A711 VA: 0x2C8A610
	|-DataTableArrayBase<EffectID, EffectDataTable, SerializeEffectDataTable>..ctor
	|-DataTableArrayBase<Int32Enum, EffectDataTable, object>..ctor
	|
	|-RVA: 0x2C8AE60 Offset: 0x2C8AF61 VA: 0x2C8AE60
	|-DataTableArrayBase<GimmickLayoutID, GimmickLayoutDataTable, SerializedGimmickLayoutDataTable>..ctor
	|-DataTableArrayBase<Int32Enum, GimmickLayoutDataTable, object>..ctor
	|
	|-RVA: 0x2C8B730 Offset: 0x2C8B831 VA: 0x2C8B730
	|-DataTableArrayBase<MineTypeID, MineTypeDataTable, SerializeMineTypeDataTable>..ctor
	|-DataTableArrayBase<Int32Enum, MineTypeDataTable, object>..ctor
	|
	|-RVA: 0x2C8BF80 Offset: 0x2C8C081 VA: 0x2C8BF80
	|-DataTableArrayBase<MiningID, MiningDataTable, SerializeMiningDataTable>..ctor
	|-DataTableArrayBase<Int32Enum, MiningDataTable, object>..ctor
	|
	|-RVA: 0x2C894B0 Offset: 0x2C895B1 VA: 0x2C894B0
	|-DataTableArrayBase<int, DualWorkDataTable, SerializeDualWorkDataTable>..ctor
	|-DataTableArrayBase<int, DualWorkSmithDataTable, SerializeDualWorkSmithDataTable>..ctor
	|-DataTableArrayBase<int, object, object>..ctor
	|
	|-RVA: 0x2C8CF40 Offset: 0x2C8D041 VA: 0x2C8CF40
	|-DataTableArrayBase<object, object, object>..ctor
	*/
}

