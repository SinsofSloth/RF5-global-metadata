[ExtensionAttribute] // RVA: 0x1391F0 Offset: 0x1392F1 VA: 0x1391F0
public static class FormatterResolverExtensions // TypeDefIndex: 5123
{
	// Fields
	private static readonly ThreadsafeTypeKeyHashTable<Func<IFormatterResolver, IMessagePackFormatter>> FormatterGetters; // 0x0
	private static readonly MethodInfo GetFormatterRuntimeMethod; // 0x8

	// Methods

	[ExtensionAttribute] // RVA: 0x139EC0 Offset: 0x139FC1 VA: 0x139EC0
	// RVA: -1 Offset: -1
	public static IMessagePackFormatter<T> GetFormatterWithVerify<T>(IFormatterResolver resolver) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B0F6A0 Offset: 0x1B0F7A1 VA: 0x1B0F6A0
	|-FormatterResolverExtensions.GetFormatterWithVerify<AmountItemData>
	|-FormatterResolverExtensions.GetFormatterWithVerify<GameFlagData[]>
	|-FormatterResolverExtensions.GetFormatterWithVerify<EnemyStatusData>
	|-FormatterResolverExtensions.GetFormatterWithVerify<EquipItemData>
	|-FormatterResolverExtensions.GetFormatterWithVerify<EventData[]>
	|-FormatterResolverExtensions.GetFormatterWithVerify<EventScheduleData[]>
	|-FormatterResolverExtensions.GetFormatterWithVerify<EventTimer[]>
	|-FormatterResolverExtensions.GetFormatterWithVerify<FieldOnGroundItemInfo[]>
	|-FormatterResolverExtensions.GetFormatterWithVerify<FishItemData>
	|-FormatterResolverExtensions.GetFormatterWithVerify<FoodItemData>
	|-FormatterResolverExtensions.GetFormatterWithVerify<FriendMonsterStatusData>
	|-FormatterResolverExtensions.GetFormatterWithVerify<HumanEquip>
	|-FormatterResolverExtensions.GetFormatterWithVerify<HumanStatusData>
	|-FormatterResolverExtensions.GetFormatterWithVerify<IntArray[]>
	|-FormatterResolverExtensions.GetFormatterWithVerify<ItemData>
	|-FormatterResolverExtensions.GetFormatterWithVerify<ItemData[]>
	|-FormatterResolverExtensions.GetFormatterWithVerify<ItemID[]>
	|-FormatterResolverExtensions.GetFormatterWithVerify<FriendMonsterIDAndHouseID[]>
	|-FormatterResolverExtensions.GetFormatterWithVerify<MonsterLovePoint>
	|-FormatterResolverExtensions.GetFormatterWithVerify<PotToolItemData>
	|-FormatterResolverExtensions.GetFormatterWithVerify<RuneAbilityItemData>
	|-FormatterResolverExtensions.GetFormatterWithVerify<SeedItemData>
	|-FormatterResolverExtensions.GetFormatterWithVerify<bool[]>
	|-FormatterResolverExtensions.GetFormatterWithVerify<List<EventCheckId>>
	|-FormatterResolverExtensions.GetFormatterWithVerify<List<EventUnlockFlagData>>
	|-FormatterResolverExtensions.GetFormatterWithVerify<List<LovePointManager.FavoriteType>>
	|-FormatterResolverExtensions.GetFormatterWithVerify<List<OrderLotterySaveParameter>>
	|-FormatterResolverExtensions.GetFormatterWithVerify<List<OrderSaveParameter>>
	|-FormatterResolverExtensions.GetFormatterWithVerify<List<SubEventStep>>
	|-FormatterResolverExtensions.GetFormatterWithVerify<List<int>>
	|-FormatterResolverExtensions.GetFormatterWithVerify<int[]>
	|-FormatterResolverExtensions.GetFormatterWithVerify<long[]>
	|-FormatterResolverExtensions.GetFormatterWithVerify<IDictionary<string, object>>
	|-FormatterResolverExtensions.GetFormatterWithVerify<object>
	|-FormatterResolverExtensions.GetFormatterWithVerify<string>
	|-FormatterResolverExtensions.GetFormatterWithVerify<GradientAlphaKey[]>
	|-FormatterResolverExtensions.GetFormatterWithVerify<GradientColorKey[]>
	|-FormatterResolverExtensions.GetFormatterWithVerify<Keyframe[]>
	|
	|-RVA: 0x1B09F20 Offset: 0x1B0A021 VA: 0x1B09F20
	|-FormatterResolverExtensions.GetFormatterWithVerify<BitVector32Int>
	|
	|-RVA: 0x1B0C680 Offset: 0x1B0C781 VA: 0x1B0C680
	|-FormatterResolverExtensions.GetFormatterWithVerify<ActorID>
	|-FormatterResolverExtensions.GetFormatterWithVerify<BadStatus>
	|-FormatterResolverExtensions.GetFormatterWithVerify<DatProgressType>
	|-FormatterResolverExtensions.GetFormatterWithVerify<DateSpotID>
	|-FormatterResolverExtensions.GetFormatterWithVerify<DateType>
	|-FormatterResolverExtensions.GetFormatterWithVerify<EventPointID>
	|-FormatterResolverExtensions.GetFormatterWithVerify<EventScriptID>
	|-FormatterResolverExtensions.GetFormatterWithVerify<FarmFieldWorkArea>
	|-FormatterResolverExtensions.GetFormatterWithVerify<FarmMonsterOrder>
	|-FormatterResolverExtensions.GetFormatterWithVerify<FieldPlaceId>
	|-FormatterResolverExtensions.GetFormatterWithVerify<GameFlagData>
	|-FormatterResolverExtensions.GetFormatterWithVerify<HotSpringID>
	|-FormatterResolverExtensions.GetFormatterWithVerify<IconType>
	|-FormatterResolverExtensions.GetFormatterWithVerify<IconViewType>
	|-FormatterResolverExtensions.GetFormatterWithVerify<LifecycleState>
	|-FormatterResolverExtensions.GetFormatterWithVerify<NpcAnimState>
	|-FormatterResolverExtensions.GetFormatterWithVerify<NpcEventType>
	|-FormatterResolverExtensions.GetFormatterWithVerify<PartyType>
	|-FormatterResolverExtensions.GetFormatterWithVerify<Place>
	|-FormatterResolverExtensions.GetFormatterWithVerify<Season>
	|-FormatterResolverExtensions.GetFormatterWithVerify<TimeZone>
	|-FormatterResolverExtensions.GetFormatterWithVerify<VaccinationID>
	|-FormatterResolverExtensions.GetFormatterWithVerify<VariationNo>
	|-FormatterResolverExtensions.GetFormatterWithVerify<WantedID>
	|-FormatterResolverExtensions.GetFormatterWithVerify<Weather>
	|-FormatterResolverExtensions.GetFormatterWithVerify<DualSmithActorDataTable.LotteryType>
	|-FormatterResolverExtensions.GetFormatterWithVerify<EventCheckType>
	|-FormatterResolverExtensions.GetFormatterWithVerify<FarmManager.FARM_ID>
	|-FormatterResolverExtensions.GetFormatterWithVerify<FarmManager.RF4_CROP_GROW_STATE>
	|-FormatterResolverExtensions.GetFormatterWithVerify<FieldSceneId>
	|-FormatterResolverExtensions.GetFormatterWithVerify<ItemID>
	|-FormatterResolverExtensions.GetFormatterWithVerify<MonsterDataID>
	|-FormatterResolverExtensions.GetFormatterWithVerify<PartnerMovementOrderType>
	|-FormatterResolverExtensions.GetFormatterWithVerify<CROWNTYPE>
	|-FormatterResolverExtensions.GetFormatterWithVerify<Int32Enum>
	|-FormatterResolverExtensions.GetFormatterWithVerify<GradientMode>
	|-FormatterResolverExtensions.GetFormatterWithVerify<WrapMode>
	|
	|-RVA: 0x1B0A5B0 Offset: 0x1B0A6B1 VA: 0x1B0A5B0
	|-FormatterResolverExtensions.GetFormatterWithVerify<FarmManager.RF4_CROP_STATE_INFO>
	|
	|-RVA: 0x1B0A7E0 Offset: 0x1B0A8E1 VA: 0x1B0A7E0
	|-FormatterResolverExtensions.GetFormatterWithVerify<FarmManager.RF4_MCROP_INFO>
	|
	|-RVA: 0x1B0B500 Offset: 0x1B0B601 VA: 0x1B0B500
	|-FormatterResolverExtensions.GetFormatterWithVerify<Parameter>
	|
	|-RVA: 0x1B119A0 Offset: 0x1B11AA1 VA: 0x1B119A0
	|-FormatterResolverExtensions.GetFormatterWithVerify<Quaternion>
	|
	|-RVA: 0x1B0A150 Offset: 0x1B0A251 VA: 0x1B0A150
	|-FormatterResolverExtensions.GetFormatterWithVerify<EventCheckId>
	|
	|-RVA: 0x1B0A380 Offset: 0x1B0A481 VA: 0x1B0A380
	|-FormatterResolverExtensions.GetFormatterWithVerify<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x1B0AA10 Offset: 0x1B0AB11 VA: 0x1B0AA10
	|-FormatterResolverExtensions.GetFormatterWithVerify<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x1B0AC40 Offset: 0x1B0AD41 VA: 0x1B0AC40
	|-FormatterResolverExtensions.GetFormatterWithVerify<MonsterHutSaveData>
	|
	|-RVA: 0x1B0AE70 Offset: 0x1B0AF71 VA: 0x1B0AE70
	|-FormatterResolverExtensions.GetFormatterWithVerify<OrderLotterySaveParameter>
	|
	|-RVA: 0x1B0B0A0 Offset: 0x1B0B1A1 VA: 0x1B0B0A0
	|-FormatterResolverExtensions.GetFormatterWithVerify<OrderSaveData>
	|
	|-RVA: 0x1B0B2D0 Offset: 0x1B0B3D1 VA: 0x1B0B2D0
	|-FormatterResolverExtensions.GetFormatterWithVerify<OrderSaveParameter>
	|
	|-RVA: 0x1B0B730 Offset: 0x1B0B831 VA: 0x1B0B730
	|-FormatterResolverExtensions.GetFormatterWithVerify<bool>
	|
	|-RVA: 0x1B0B960 Offset: 0x1B0BA61 VA: 0x1B0B960
	|-FormatterResolverExtensions.GetFormatterWithVerify<byte>
	|
	|-RVA: 0x1B0BB90 Offset: 0x1B0BC91 VA: 0x1B0BB90
	|-FormatterResolverExtensions.GetFormatterWithVerify<char>
	|
	|-RVA: 0x1B0BDC0 Offset: 0x1B0BEC1 VA: 0x1B0BDC0
	|-FormatterResolverExtensions.GetFormatterWithVerify<DateTime>
	|
	|-RVA: 0x1B0BFF0 Offset: 0x1B0C0F1 VA: 0x1B0BFF0
	|-FormatterResolverExtensions.GetFormatterWithVerify<double>
	|
	|-RVA: 0x1B0C220 Offset: 0x1B0C321 VA: 0x1B0C220
	|-FormatterResolverExtensions.GetFormatterWithVerify<short>
	|
	|-RVA: 0x1B0C450 Offset: 0x1B0C551 VA: 0x1B0C450
	|-FormatterResolverExtensions.GetFormatterWithVerify<int>
	|
	|-RVA: 0x1B0C8B0 Offset: 0x1B0C9B1 VA: 0x1B0C8B0
	|-FormatterResolverExtensions.GetFormatterWithVerify<long>
	|
	|-RVA: 0x1B0CAE0 Offset: 0x1B0CBE1 VA: 0x1B0CAE0
	|-FormatterResolverExtensions.GetFormatterWithVerify<Memory<object>>
	|
	|-RVA: 0x1B0CD10 Offset: 0x1B0CE11 VA: 0x1B0CD10
	|-FormatterResolverExtensions.GetFormatterWithVerify<Nullable<Int32Enum>>
	|
	|-RVA: 0x1B0CF40 Offset: 0x1B0D041 VA: 0x1B0CF40
	|-FormatterResolverExtensions.GetFormatterWithVerify<Nullable<Bounds>>
	|
	|-RVA: 0x1B0D170 Offset: 0x1B0D271 VA: 0x1B0D170
	|-FormatterResolverExtensions.GetFormatterWithVerify<Nullable<BoundsInt>>
	|
	|-RVA: 0x1B0D3A0 Offset: 0x1B0D4A1 VA: 0x1B0D3A0
	|-FormatterResolverExtensions.GetFormatterWithVerify<Nullable<Color32>>
	|
	|-RVA: 0x1B0D5D0 Offset: 0x1B0D6D1 VA: 0x1B0D5D0
	|-FormatterResolverExtensions.GetFormatterWithVerify<Nullable<Color>>
	|
	|-RVA: 0x1B0D800 Offset: 0x1B0D901 VA: 0x1B0D800
	|-FormatterResolverExtensions.GetFormatterWithVerify<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x1B0DA30 Offset: 0x1B0DB31 VA: 0x1B0DA30
	|-FormatterResolverExtensions.GetFormatterWithVerify<Nullable<GradientColorKey>>
	|
	|-RVA: 0x1B0DC60 Offset: 0x1B0DD61 VA: 0x1B0DC60
	|-FormatterResolverExtensions.GetFormatterWithVerify<Nullable<Keyframe>>
	|
	|-RVA: 0x1B0DE90 Offset: 0x1B0DF91 VA: 0x1B0DE90
	|-FormatterResolverExtensions.GetFormatterWithVerify<Nullable<LayerMask>>
	|
	|-RVA: 0x1B0E0C0 Offset: 0x1B0E1C1 VA: 0x1B0E0C0
	|-FormatterResolverExtensions.GetFormatterWithVerify<Nullable<Matrix4x4>>
	|
	|-RVA: 0x1B0E2F0 Offset: 0x1B0E3F1 VA: 0x1B0E2F0
	|-FormatterResolverExtensions.GetFormatterWithVerify<Nullable<Quaternion>>
	|
	|-RVA: 0x1B0E520 Offset: 0x1B0E621 VA: 0x1B0E520
	|-FormatterResolverExtensions.GetFormatterWithVerify<Nullable<RangeInt>>
	|
	|-RVA: 0x1B0E750 Offset: 0x1B0E851 VA: 0x1B0E750
	|-FormatterResolverExtensions.GetFormatterWithVerify<Nullable<Rect>>
	|
	|-RVA: 0x1B0E980 Offset: 0x1B0EA81 VA: 0x1B0E980
	|-FormatterResolverExtensions.GetFormatterWithVerify<Nullable<RectInt>>
	|
	|-RVA: 0x1B0EBB0 Offset: 0x1B0ECB1 VA: 0x1B0EBB0
	|-FormatterResolverExtensions.GetFormatterWithVerify<Nullable<Vector2>>
	|
	|-RVA: 0x1B0EDE0 Offset: 0x1B0EEE1 VA: 0x1B0EDE0
	|-FormatterResolverExtensions.GetFormatterWithVerify<Nullable<Vector2Int>>
	|
	|-RVA: 0x1B0F010 Offset: 0x1B0F111 VA: 0x1B0F010
	|-FormatterResolverExtensions.GetFormatterWithVerify<Nullable<Vector3>>
	|
	|-RVA: 0x1B0F240 Offset: 0x1B0F341 VA: 0x1B0F240
	|-FormatterResolverExtensions.GetFormatterWithVerify<Nullable<Vector3Int>>
	|
	|-RVA: 0x1B0F470 Offset: 0x1B0F571 VA: 0x1B0F470
	|-FormatterResolverExtensions.GetFormatterWithVerify<Nullable<Vector4>>
	|
	|-RVA: 0x1B0F8D0 Offset: 0x1B0F9D1 VA: 0x1B0F8D0
	|-FormatterResolverExtensions.GetFormatterWithVerify<ReadOnlyMemory<object>>
	|
	|-RVA: 0x1B0FB00 Offset: 0x1B0FC01 VA: 0x1B0FB00
	|-FormatterResolverExtensions.GetFormatterWithVerify<sbyte>
	|
	|-RVA: 0x1B0FD30 Offset: 0x1B0FE31 VA: 0x1B0FD30
	|-FormatterResolverExtensions.GetFormatterWithVerify<float>
	|
	|-RVA: 0x1B0FF60 Offset: 0x1B10061 VA: 0x1B0FF60
	|-FormatterResolverExtensions.GetFormatterWithVerify<ushort>
	|
	|-RVA: 0x1B10190 Offset: 0x1B10291 VA: 0x1B10190
	|-FormatterResolverExtensions.GetFormatterWithVerify<uint>
	|
	|-RVA: 0x1B103C0 Offset: 0x1B104C1 VA: 0x1B103C0
	|-FormatterResolverExtensions.GetFormatterWithVerify<ulong>
	|
	|-RVA: 0x1B105F0 Offset: 0x1B106F1 VA: 0x1B105F0
	|-FormatterResolverExtensions.GetFormatterWithVerify<Bounds>
	|
	|-RVA: 0x1B10820 Offset: 0x1B10921 VA: 0x1B10820
	|-FormatterResolverExtensions.GetFormatterWithVerify<BoundsInt>
	|
	|-RVA: 0x1B10A50 Offset: 0x1B10B51 VA: 0x1B10A50
	|-FormatterResolverExtensions.GetFormatterWithVerify<Color32>
	|
	|-RVA: 0x1B10C80 Offset: 0x1B10D81 VA: 0x1B10C80
	|-FormatterResolverExtensions.GetFormatterWithVerify<Color>
	|
	|-RVA: 0x1B10EB0 Offset: 0x1B10FB1 VA: 0x1B10EB0
	|-FormatterResolverExtensions.GetFormatterWithVerify<GradientAlphaKey>
	|
	|-RVA: 0x1B110E0 Offset: 0x1B111E1 VA: 0x1B110E0
	|-FormatterResolverExtensions.GetFormatterWithVerify<GradientColorKey>
	|
	|-RVA: 0x1B11310 Offset: 0x1B11411 VA: 0x1B11310
	|-FormatterResolverExtensions.GetFormatterWithVerify<Keyframe>
	|
	|-RVA: 0x1B11540 Offset: 0x1B11641 VA: 0x1B11540
	|-FormatterResolverExtensions.GetFormatterWithVerify<LayerMask>
	|
	|-RVA: 0x1B11770 Offset: 0x1B11871 VA: 0x1B11770
	|-FormatterResolverExtensions.GetFormatterWithVerify<Matrix4x4>
	|
	|-RVA: 0x1B11BD0 Offset: 0x1B11CD1 VA: 0x1B11BD0
	|-FormatterResolverExtensions.GetFormatterWithVerify<RangeInt>
	|
	|-RVA: 0x1B11E00 Offset: 0x1B11F01 VA: 0x1B11E00
	|-FormatterResolverExtensions.GetFormatterWithVerify<Rect>
	|
	|-RVA: 0x1B12030 Offset: 0x1B12131 VA: 0x1B12030
	|-FormatterResolverExtensions.GetFormatterWithVerify<RectInt>
	|
	|-RVA: 0x1B12260 Offset: 0x1B12361 VA: 0x1B12260
	|-FormatterResolverExtensions.GetFormatterWithVerify<Vector2>
	|
	|-RVA: 0x1B12490 Offset: 0x1B12591 VA: 0x1B12490
	|-FormatterResolverExtensions.GetFormatterWithVerify<Vector2Int>
	|
	|-RVA: 0x1B126C0 Offset: 0x1B127C1 VA: 0x1B126C0
	|-FormatterResolverExtensions.GetFormatterWithVerify<Vector3>
	|
	|-RVA: 0x1B128F0 Offset: 0x1B129F1 VA: 0x1B128F0
	|-FormatterResolverExtensions.GetFormatterWithVerify<Vector3Int>
	|
	|-RVA: 0x1B12B20 Offset: 0x1B12C21 VA: 0x1B12B20
	|-FormatterResolverExtensions.GetFormatterWithVerify<Vector4>
	*/

	// RVA: 0x1652E60 Offset: 0x1652F61 VA: 0x1652E60
	private static void Throw(TypeInitializationException ex) { }

	// RVA: 0x1652EA0 Offset: 0x1652FA1 VA: 0x1652EA0
	private static void Throw(Type t, IFormatterResolver resolver) { }

	[ExtensionAttribute] // RVA: 0x139ED0 Offset: 0x139FD1 VA: 0x139ED0
	// RVA: 0x1652F60 Offset: 0x1653061 VA: 0x1652F60
	public static object GetFormatterDynamic(IFormatterResolver resolver, Type type) { }

	[ExtensionAttribute] // RVA: 0x139EE0 Offset: 0x139FE1 VA: 0x139EE0
	// RVA: 0x1653260 Offset: 0x1653361 VA: 0x1653260
	internal static object GetFormatterDynamicWithVerify(IFormatterResolver resolver, Type type) { }

	// RVA: 0x1653300 Offset: 0x1653401 VA: 0x1653300
	private static void .cctor() { }
}

