[ExtensionAttribute] // RVA: 0xBE0B0 Offset: 0xBE1B1 VA: 0xBE0B0
public static class Enumerable // TypeDefIndex: 2163
{
	// Methods

	[ExtensionAttribute] // RVA: 0xBF790 Offset: 0xBF891 VA: 0xBF790
	// RVA: -1 Offset: -1
	public static IEnumerable<TSource> Where<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x212EB10 Offset: 0x212EC11 VA: 0x212EB10
	|-Enumerable.Where<CerberusBossDataAsset.LotteryParam>
	|-Enumerable.Where<DeadtreeBossDataAsset.LotteryParam>
	|-Enumerable.Where<SkullDragonBossDataAsset.LotteryParam>
	|-Enumerable.Where<ButtonLinker>
	|-Enumerable.Where<SerializeClothShopDataTable>
	|-Enumerable.Where<SerializeHotSpringDataTable>
	|-Enumerable.Where<SerializeRecipePanShopDataTable>
	|-Enumerable.Where<SerializeVaccinationDataTable>
	|-Enumerable.Where<AutomataDictionary.AutomataNode>
	|-Enumerable.Where<DynamicObjectTypeBuilder.DeserializeInfo>
	|-Enumerable.Where<ObjectSerializationInfo.EmittableMember>
	|-Enumerable.Where<PartyBase>
	|-Enumerable.Where<PlayerTeleport>
	|-Enumerable.Where<SEController>
	|-Enumerable.Where<ConstructorInfo>
	|-Enumerable.Where<MethodInfo>
	|-Enumerable.Where<string>
	|-Enumerable.Where<SpringBone>
	|-Enumerable.Where<SpringBoneSerialization.LengthLimitSerializer>
	|-Enumerable.Where<SpringBoneSerialization.SpringBoneSerializer>
	|-Enumerable.Where<SpringCapsuleCollider>
	|-Enumerable.Where<SpringPanelCollider>
	|-Enumerable.Where<SpringSphereCollider>
	|-Enumerable.Where<TextRecordParsing.Record>
	|-Enumerable.Where<TypedStringToValueMap>
	|-Enumerable.Where<AddressablesImpl.ResourceLocatorInfo>
	|-Enumerable.Where<Component>
	|-Enumerable.Where<Mesh>
	|-Enumerable.Where<PlayerEditorConnectionEvents.MessageTypeSubscribers>
	|-Enumerable.Where<Transform>
	|-Enumerable.Where<Toggle>
	|-Enumerable.Where<object>
	|
	|-RVA: 0x212E050 Offset: 0x212E151 VA: 0x212E050
	|-Enumerable.Where<CropDataTable>
	|
	|-RVA: 0x212E860 Offset: 0x212E961 VA: 0x212E860
	|-Enumerable.Where<ItemID>
	|-Enumerable.Where<Int32Enum>
	|
	|-RVA: 0x212E300 Offset: 0x212E401 VA: 0x212E300
	|-Enumerable.Where<KeyValuePair<int, FishSwim>>
	|-Enumerable.Where<KeyValuePair<int, object>>
	|
	|-RVA: 0x212E5B0 Offset: 0x212E6B1 VA: 0x212E5B0
	|-Enumerable.Where<KeyValuePair<string, object>>
	|-Enumerable.Where<KeyValuePair<object, object>>
	|
	|-RVA: 0x212EDC0 Offset: 0x212EEC1 VA: 0x212EDC0
	|-Enumerable.Where<ValueTuple<ActorID, int>>
	|-Enumerable.Where<ValueTuple<Int32Enum, int>>
	|
	|-RVA: 0x212F070 Offset: 0x212F171 VA: 0x212F070
	|-Enumerable.Where<ValueTuple<ItemData, StorageType>>
	|-Enumerable.Where<ValueTuple<object, Int32Enum>>
	*/

	[ExtensionAttribute] // RVA: 0xBF7A0 Offset: 0xBF8A1 VA: 0xBF7A0
	// RVA: -1 Offset: -1
	public static IEnumerable<TResult> Select<TSource, TResult>(IEnumerable<TSource> source, Func<TSource, TResult> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x212BA40 Offset: 0x212BB41 VA: 0x212BA40
	|-Enumerable.Select<<>f__AnonymousType0<Label, UnionAttribute>, Label>
	|-Enumerable.Select<DynamicObjectTypeBuilder.DeserializeInfo, Label>
	|-Enumerable.Select<object, Label>
	|
	|-RVA: 0x212B780 Offset: 0x212B881 VA: 0x212B780
	|-Enumerable.Select<<>f__AnonymousType0<SpringBone, int>, SpringBone>
	|-Enumerable.Select<ButtonLinker, ItemData>
	|-Enumerable.Select<SerializeClothShopDataTable, string>
	|-Enumerable.Select<SerializeCrystalDataTable, ItemDataTable>
	|-Enumerable.Select<SerializeHotSpringDataTable, string>
	|-Enumerable.Select<SerializeRecipePanShopDataTable, ItemDataTable>
	|-Enumerable.Select<SerializeVaccinationDataTable, string>
	|-Enumerable.Select<ItemDataTable, string>
	|-Enumerable.Select<ObjectSerializationInfo.EmittableMember, DynamicObjectTypeBuilder.DeserializeInfo>
	|-Enumerable.Select<UnionAttribute, <>f__AnonymousType0<Label, UnionAttribute>>
	|-Enumerable.Select<string, string>
	|-Enumerable.Select<string, SpringCapsuleCollider>
	|-Enumerable.Select<string, SpringPanelCollider>
	|-Enumerable.Select<string, SpringSphereCollider>
	|-Enumerable.Select<string, Transform>
	|-Enumerable.Select<DynamicsNull, SpringColliderSerialization.TransformSerializer>
	|-Enumerable.Select<SpringBone, <>f__AnonymousType0<SpringBone, int>>
	|-Enumerable.Select<SpringBone, Transform>
	|-Enumerable.Select<SpringBoneSerialization.LengthLimitSerializer, Transform>
	|-Enumerable.Select<SpringBoneSerialization.PivotSerializer, string>
	|-Enumerable.Select<SpringBoneSerialization.SpringBoneSerializer, string>
	|-Enumerable.Select<SpringCapsuleCollider, string>
	|-Enumerable.Select<SpringCapsuleCollider, SpringColliderSerialization.CapsuleColliderSerializer>
	|-Enumerable.Select<SpringColliderSerialization.IColliderSerializer, string>
	|-Enumerable.Select<SpringColliderSerialization.TransformSerializer, string>
	|-Enumerable.Select<SpringPanelCollider, string>
	|-Enumerable.Select<SpringPanelCollider, SpringColliderSerialization.PanelColliderSerializer>
	|-Enumerable.Select<SpringSphereCollider, string>
	|-Enumerable.Select<SpringSphereCollider, SpringColliderSerialization.SphereColliderSerializer>
	|-Enumerable.Select<AddressablesImpl.ResourceLocatorInfo, string>
	|-Enumerable.Select<AddressablesImpl.ResourceLocatorInfo, IResourceLocator>
	|-Enumerable.Select<Component, string>
	|-Enumerable.Select<Object, Component>
	|-Enumerable.Select<Face, Face>
	|-Enumerable.Select<SkinnedMeshRenderer, Mesh>
	|-Enumerable.Select<Transform, string>
	|-Enumerable.Select<Transform, SpringBoneSerialization.LengthLimitSerializer>
	|-Enumerable.Select<Transform, SpringBoneSerialization.PivotSerializer>
	|-Enumerable.Select<Transform, GameObject>
	|-Enumerable.Select<object, object>
	|
	|-RVA: 0x212B4C0 Offset: 0x212B5C1 VA: 0x212B4C0
	|-Enumerable.Select<ButtonLinker, ItemID>
	|-Enumerable.Select<SerializeClothShopDataTable, ClothShopID>
	|-Enumerable.Select<SerializeCrystalDataTable, ItemID>
	|-Enumerable.Select<SerializeHotSpringDataTable, HotSpringID>
	|-Enumerable.Select<SerializeRecipePanShopDataTable, RecipePanShopID>
	|-Enumerable.Select<SerializeVaccinationDataTable, VaccinationID>
	|-Enumerable.Select<ItemData, ItemID>
	|-Enumerable.Select<object, Int32Enum>
	|
	|-RVA: 0x212AF40 Offset: 0x212B041 VA: 0x212AF40
	|-Enumerable.Select<SerializeCropDataTable, CropDataTable>
	|-Enumerable.Select<object, CropDataTable>
	|
	|-RVA: 0x212A9C0 Offset: 0x212AAC1 VA: 0x212A9C0
	|-Enumerable.Select<StorageType, ItemStorage>
	|-Enumerable.Select<Int32Enum, object>
	|
	|-RVA: 0x212B200 Offset: 0x212B301 VA: 0x212B200
	|-Enumerable.Select<GluttonItem, int>
	|-Enumerable.Select<ItemLotteryWeight.ItemLotteryWeightParam, int>
	|-Enumerable.Select<ItemLotty.ItemLotteryWeightParam, int>
	|-Enumerable.Select<ItemWeightData, int>
	|-Enumerable.Select<ObjectSerializationInfo.EmittableMember, int>
	|-Enumerable.Select<SnowballObject, int>
	|-Enumerable.Select<Face, int>
	|-Enumerable.Select<object, int>
	|
	|-RVA: 0x212AC80 Offset: 0x212AD81 VA: 0x212AC80
	|-Enumerable.Select<ItemID, ValueTuple<bool, ItemID>>
	|-Enumerable.Select<Int32Enum, ValueTuple<bool, Int32Enum>>
	|
	|-RVA: 0x212BFC0 Offset: 0x212C0C1 VA: 0x212BFC0
	|-Enumerable.Select<MeshVertex, Vector2>
	|-Enumerable.Select<object, Vector2>
	|
	|-RVA: 0x212C280 Offset: 0x212C381 VA: 0x212C280
	|-Enumerable.Select<MeshVertex, Vector3>
	|-Enumerable.Select<object, Vector3>
	|
	|-RVA: 0x212A180 Offset: 0x212A281 VA: 0x212A180
	|-Enumerable.Select<KeyValuePair<string, object>, string>
	|-Enumerable.Select<KeyValuePair<object, object>, object>
	|
	|-RVA: 0x212A440 Offset: 0x212A541 VA: 0x212A440
	|-Enumerable.Select<int, DynamicObjectTypeBuilder.DeserializeInfo>
	|-Enumerable.Select<int, Transform>
	|-Enumerable.Select<int, object>
	|
	|-RVA: 0x212A700 Offset: 0x212A801 VA: 0x212A700
	|-Enumerable.Select<int, Label>
	|
	|-RVA: 0x212C800 Offset: 0x212C901 VA: 0x212C800
	|-Enumerable.Select<ValueTuple<ItemData, StorageType>, ItemData>
	|-Enumerable.Select<ValueTuple<object, Int32Enum>, object>
	|
	|-RVA: 0x212C540 Offset: 0x212C641 VA: 0x212C540
	|-Enumerable.Select<ValueTuple<ItemData, StorageType>, ItemID>
	|-Enumerable.Select<ValueTuple<object, Int32Enum>, Int32Enum>
	|
	|-RVA: 0x212CAC0 Offset: 0x212CBC1 VA: 0x212CAC0
	|-Enumerable.Select<Vector4, Vector2>
	|
	|-RVA: 0x2129EC0 Offset: 0x2129FC1 VA: 0x2129EC0
	|-Enumerable.Select<CropDataTable, int>
	|
	|-RVA: 0x212BD00 Offset: 0x212BE01 VA: 0x212BD00
	|-Enumerable.Select<object, float>
	*/

	// RVA: -1 Offset: -1
	private static Func<TSource, bool> CombinePredicates<TSource>(Func<TSource, bool> predicate1, Func<TSource, bool> predicate2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21AC270 Offset: 0x21AC371 VA: 0x21AC270
	|-Enumerable.CombinePredicates<CropDataTable>
	|
	|-RVA: 0x21AC340 Offset: 0x21AC441 VA: 0x21AC340
	|-Enumerable.CombinePredicates<KeyValuePair<int, object>>
	|
	|-RVA: 0x21AC410 Offset: 0x21AC511 VA: 0x21AC410
	|-Enumerable.CombinePredicates<KeyValuePair<object, object>>
	|
	|-RVA: 0x21AC4E0 Offset: 0x21AC5E1 VA: 0x21AC4E0
	|-Enumerable.CombinePredicates<int>
	|
	|-RVA: 0x21AC5B0 Offset: 0x21AC6B1 VA: 0x21AC5B0
	|-Enumerable.CombinePredicates<Int32Enum>
	|
	|-RVA: 0x21AC680 Offset: 0x21AC781 VA: 0x21AC680
	|-Enumerable.CombinePredicates<object>
	|
	|-RVA: 0x21AC750 Offset: 0x21AC851 VA: 0x21AC750
	|-Enumerable.CombinePredicates<Label>
	|
	|-RVA: 0x21AC820 Offset: 0x21AC921 VA: 0x21AC820
	|-Enumerable.CombinePredicates<float>
	|
	|-RVA: 0x21AC8F0 Offset: 0x21AC9F1 VA: 0x21AC8F0
	|-Enumerable.CombinePredicates<ValueTuple<bool, Int32Enum>>
	|
	|-RVA: 0x21AC9C0 Offset: 0x21ACAC1 VA: 0x21AC9C0
	|-Enumerable.CombinePredicates<ValueTuple<Int32Enum, int>>
	|
	|-RVA: 0x21ACA90 Offset: 0x21ACB91 VA: 0x21ACA90
	|-Enumerable.CombinePredicates<ValueTuple<object, Int32Enum>>
	|
	|-RVA: 0x21ACB60 Offset: 0x21ACC61 VA: 0x21ACB60
	|-Enumerable.CombinePredicates<Vector2>
	|
	|-RVA: 0x21ACC30 Offset: 0x21ACD31 VA: 0x21ACC30
	|-Enumerable.CombinePredicates<Vector3>
	*/

	// RVA: -1 Offset: -1
	private static Func<TSource, TResult> CombineSelectors<TSource, TMiddle, TResult>(Func<TSource, TMiddle> selector1, Func<TMiddle, TResult> selector2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21ACD00 Offset: 0x21ACE01 VA: 0x21ACD00
	|-Enumerable.CombineSelectors<CropDataTable, int, object>
	|
	|-RVA: 0x21ACDD0 Offset: 0x21ACED1 VA: 0x21ACDD0
	|-Enumerable.CombineSelectors<CropDataTable, int, Label>
	|
	|-RVA: 0x21ACEA0 Offset: 0x21ACFA1 VA: 0x21ACEA0
	|-Enumerable.CombineSelectors<CropDataTable, object, object>
	|
	|-RVA: 0x21ACF70 Offset: 0x21AD071 VA: 0x21ACF70
	|-Enumerable.CombineSelectors<CropDataTable, Label, Label>
	|
	|-RVA: 0x21AD040 Offset: 0x21AD141 VA: 0x21AD040
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, CropDataTable, CropDataTable>
	|
	|-RVA: 0x21AD110 Offset: 0x21AD211 VA: 0x21AD110
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, int, int>
	|
	|-RVA: 0x21AD1E0 Offset: 0x21AD2E1 VA: 0x21AD1E0
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, Int32Enum, Int32Enum>
	|
	|-RVA: 0x21AD2B0 Offset: 0x21AD3B1 VA: 0x21AD2B0
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, object, CropDataTable>
	|
	|-RVA: 0x21AD380 Offset: 0x21AD481 VA: 0x21AD380
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, object, int>
	|
	|-RVA: 0x21AD450 Offset: 0x21AD551 VA: 0x21AD450
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, object, Int32Enum>
	|
	|-RVA: 0x21AD520 Offset: 0x21AD621 VA: 0x21AD520
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, object, object>
	|
	|-RVA: 0x21AD5F0 Offset: 0x21AD6F1 VA: 0x21AD5F0
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, object, Label>
	|
	|-RVA: 0x21AD6C0 Offset: 0x21AD7C1 VA: 0x21AD6C0
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, object, float>
	|
	|-RVA: 0x21AD790 Offset: 0x21AD891 VA: 0x21AD790
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, object, Vector2>
	|
	|-RVA: 0x21AD860 Offset: 0x21AD961 VA: 0x21AD860
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, object, Vector3>
	|
	|-RVA: 0x21AD930 Offset: 0x21ADA31 VA: 0x21AD930
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, Label, Label>
	|
	|-RVA: 0x21ADA00 Offset: 0x21ADB01 VA: 0x21ADA00
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, float, float>
	|
	|-RVA: 0x21ADAD0 Offset: 0x21ADBD1 VA: 0x21ADAD0
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, Vector2, Vector2>
	|
	|-RVA: 0x21ADBA0 Offset: 0x21ADCA1 VA: 0x21ADBA0
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, Vector3, Vector3>
	|
	|-RVA: 0x21ADC70 Offset: 0x21ADD71 VA: 0x21ADC70
	|-Enumerable.CombineSelectors<int, CropDataTable, CropDataTable>
	|
	|-RVA: 0x21ADD40 Offset: 0x21ADE41 VA: 0x21ADD40
	|-Enumerable.CombineSelectors<int, int, int>
	|
	|-RVA: 0x21ADE10 Offset: 0x21ADF11 VA: 0x21ADE10
	|-Enumerable.CombineSelectors<int, Int32Enum, Int32Enum>
	|
	|-RVA: 0x21ADEE0 Offset: 0x21ADFE1 VA: 0x21ADEE0
	|-Enumerable.CombineSelectors<int, object, CropDataTable>
	|
	|-RVA: 0x21ADFB0 Offset: 0x21AE0B1 VA: 0x21ADFB0
	|-Enumerable.CombineSelectors<int, object, int>
	|
	|-RVA: 0x21AE080 Offset: 0x21AE181 VA: 0x21AE080
	|-Enumerable.CombineSelectors<int, object, Int32Enum>
	|
	|-RVA: 0x21AE150 Offset: 0x21AE251 VA: 0x21AE150
	|-Enumerable.CombineSelectors<int, object, object>
	|
	|-RVA: 0x21AE220 Offset: 0x21AE321 VA: 0x21AE220
	|-Enumerable.CombineSelectors<int, object, Label>
	|
	|-RVA: 0x21AE2F0 Offset: 0x21AE3F1 VA: 0x21AE2F0
	|-Enumerable.CombineSelectors<int, object, float>
	|
	|-RVA: 0x21AE3C0 Offset: 0x21AE4C1 VA: 0x21AE3C0
	|-Enumerable.CombineSelectors<int, object, Vector2>
	|
	|-RVA: 0x21AE490 Offset: 0x21AE591 VA: 0x21AE490
	|-Enumerable.CombineSelectors<int, object, Vector3>
	|
	|-RVA: 0x21AE560 Offset: 0x21AE661 VA: 0x21AE560
	|-Enumerable.CombineSelectors<int, float, float>
	|
	|-RVA: 0x21AE630 Offset: 0x21AE731 VA: 0x21AE630
	|-Enumerable.CombineSelectors<int, Vector2, Vector2>
	|
	|-RVA: 0x21AE700 Offset: 0x21AE801 VA: 0x21AE700
	|-Enumerable.CombineSelectors<int, Vector3, Vector3>
	|
	|-RVA: 0x21AE7D0 Offset: 0x21AE8D1 VA: 0x21AE7D0
	|-Enumerable.CombineSelectors<Int32Enum, CropDataTable, CropDataTable>
	|
	|-RVA: 0x21AE8A0 Offset: 0x21AE9A1 VA: 0x21AE8A0
	|-Enumerable.CombineSelectors<Int32Enum, int, int>
	|
	|-RVA: 0x21AE970 Offset: 0x21AEA71 VA: 0x21AE970
	|-Enumerable.CombineSelectors<Int32Enum, Int32Enum, Int32Enum>
	|
	|-RVA: 0x21AEA40 Offset: 0x21AEB41 VA: 0x21AEA40
	|-Enumerable.CombineSelectors<Int32Enum, object, CropDataTable>
	|
	|-RVA: 0x21AEB10 Offset: 0x21AEC11 VA: 0x21AEB10
	|-Enumerable.CombineSelectors<Int32Enum, object, int>
	|
	|-RVA: 0x21AEBE0 Offset: 0x21AECE1 VA: 0x21AEBE0
	|-Enumerable.CombineSelectors<Int32Enum, object, Int32Enum>
	|
	|-RVA: 0x21AECB0 Offset: 0x21AEDB1 VA: 0x21AECB0
	|-Enumerable.CombineSelectors<Int32Enum, object, object>
	|
	|-RVA: 0x21AED80 Offset: 0x21AEE81 VA: 0x21AED80
	|-Enumerable.CombineSelectors<Int32Enum, object, Label>
	|
	|-RVA: 0x21AEE50 Offset: 0x21AEF51 VA: 0x21AEE50
	|-Enumerable.CombineSelectors<Int32Enum, object, float>
	|
	|-RVA: 0x21AEF20 Offset: 0x21AF021 VA: 0x21AEF20
	|-Enumerable.CombineSelectors<Int32Enum, object, Vector2>
	|
	|-RVA: 0x21AEFF0 Offset: 0x21AF0F1 VA: 0x21AEFF0
	|-Enumerable.CombineSelectors<Int32Enum, object, Vector3>
	|
	|-RVA: 0x21AF0C0 Offset: 0x21AF1C1 VA: 0x21AF0C0
	|-Enumerable.CombineSelectors<Int32Enum, Label, Label>
	|
	|-RVA: 0x21AF190 Offset: 0x21AF291 VA: 0x21AF190
	|-Enumerable.CombineSelectors<Int32Enum, float, float>
	|
	|-RVA: 0x21AF260 Offset: 0x21AF361 VA: 0x21AF260
	|-Enumerable.CombineSelectors<Int32Enum, Vector2, Vector2>
	|
	|-RVA: 0x21AF330 Offset: 0x21AF431 VA: 0x21AF330
	|-Enumerable.CombineSelectors<Int32Enum, Vector3, Vector3>
	|
	|-RVA: 0x21AF400 Offset: 0x21AF501 VA: 0x21AF400
	|-Enumerable.CombineSelectors<object, CropDataTable, int>
	|
	|-RVA: 0x21AF4D0 Offset: 0x21AF5D1 VA: 0x21AF4D0
	|-Enumerable.CombineSelectors<object, int, object>
	|
	|-RVA: 0x21AF5A0 Offset: 0x21AF6A1 VA: 0x21AF5A0
	|-Enumerable.CombineSelectors<object, int, Label>
	|
	|-RVA: 0x21AF670 Offset: 0x21AF771 VA: 0x21AF670
	|-Enumerable.CombineSelectors<object, Int32Enum, object>
	|
	|-RVA: 0x21AF740 Offset: 0x21AF841 VA: 0x21AF740
	|-Enumerable.CombineSelectors<object, Int32Enum, ValueTuple<bool, Int32Enum>>
	|
	|-RVA: 0x21AF810 Offset: 0x21AF911 VA: 0x21AF810
	|-Enumerable.CombineSelectors<object, object, CropDataTable>
	|
	|-RVA: 0x21AF8E0 Offset: 0x21AF9E1 VA: 0x21AF8E0
	|-Enumerable.CombineSelectors<object, object, int>
	|
	|-RVA: 0x21AF9B0 Offset: 0x21AFAB1 VA: 0x21AF9B0
	|-Enumerable.CombineSelectors<object, object, Int32Enum>
	|
	|-RVA: 0x21AFA80 Offset: 0x21AFB81 VA: 0x21AFA80
	|-Enumerable.CombineSelectors<object, object, object>
	|
	|-RVA: 0x21AFB50 Offset: 0x21AFC51 VA: 0x21AFB50
	|-Enumerable.CombineSelectors<object, object, Label>
	|
	|-RVA: 0x21AFC20 Offset: 0x21AFD21 VA: 0x21AFC20
	|-Enumerable.CombineSelectors<object, object, float>
	|
	|-RVA: 0x21AFCF0 Offset: 0x21AFDF1 VA: 0x21AFCF0
	|-Enumerable.CombineSelectors<object, object, Vector2>
	|
	|-RVA: 0x21AFDC0 Offset: 0x21AFEC1 VA: 0x21AFDC0
	|-Enumerable.CombineSelectors<object, object, Vector3>
	|
	|-RVA: 0x21AFE90 Offset: 0x21AFF91 VA: 0x21AFE90
	|-Enumerable.CombineSelectors<object, ValueTuple<bool, Int32Enum>, ValueTuple<bool, Int32Enum>>
	|
	|-RVA: 0x21AFF60 Offset: 0x21B0061 VA: 0x21AFF60
	|-Enumerable.CombineSelectors<ValueTuple<object, Int32Enum>, CropDataTable, CropDataTable>
	|
	|-RVA: 0x21B0030 Offset: 0x21B0131 VA: 0x21B0030
	|-Enumerable.CombineSelectors<ValueTuple<object, Int32Enum>, int, int>
	|
	|-RVA: 0x21B0100 Offset: 0x21B0201 VA: 0x21B0100
	|-Enumerable.CombineSelectors<ValueTuple<object, Int32Enum>, Int32Enum, object>
	|
	|-RVA: 0x21B01D0 Offset: 0x21B02D1 VA: 0x21B01D0
	|-Enumerable.CombineSelectors<ValueTuple<object, Int32Enum>, Int32Enum, ValueTuple<bool, Int32Enum>>
	|
	|-RVA: 0x21B02A0 Offset: 0x21B03A1 VA: 0x21B02A0
	|-Enumerable.CombineSelectors<ValueTuple<object, Int32Enum>, object, CropDataTable>
	|
	|-RVA: 0x21B0370 Offset: 0x21B0471 VA: 0x21B0370
	|-Enumerable.CombineSelectors<ValueTuple<object, Int32Enum>, object, int>
	|
	|-RVA: 0x21B0440 Offset: 0x21B0541 VA: 0x21B0440
	|-Enumerable.CombineSelectors<ValueTuple<object, Int32Enum>, object, Int32Enum>
	|
	|-RVA: 0x21B0510 Offset: 0x21B0611 VA: 0x21B0510
	|-Enumerable.CombineSelectors<ValueTuple<object, Int32Enum>, object, object>
	|
	|-RVA: 0x21B05E0 Offset: 0x21B06E1 VA: 0x21B05E0
	|-Enumerable.CombineSelectors<ValueTuple<object, Int32Enum>, object, Label>
	|
	|-RVA: 0x21B06B0 Offset: 0x21B07B1 VA: 0x21B06B0
	|-Enumerable.CombineSelectors<ValueTuple<object, Int32Enum>, object, float>
	|
	|-RVA: 0x21B0780 Offset: 0x21B0881 VA: 0x21B0780
	|-Enumerable.CombineSelectors<ValueTuple<object, Int32Enum>, object, Vector2>
	|
	|-RVA: 0x21B0850 Offset: 0x21B0951 VA: 0x21B0850
	|-Enumerable.CombineSelectors<ValueTuple<object, Int32Enum>, object, Vector3>
	|
	|-RVA: 0x21B0920 Offset: 0x21B0A21 VA: 0x21B0920
	|-Enumerable.CombineSelectors<ValueTuple<object, Int32Enum>, Label, Label>
	|
	|-RVA: 0x21B09F0 Offset: 0x21B0AF1 VA: 0x21B09F0
	|-Enumerable.CombineSelectors<ValueTuple<object, Int32Enum>, float, float>
	|
	|-RVA: 0x21B0AC0 Offset: 0x21B0BC1 VA: 0x21B0AC0
	|-Enumerable.CombineSelectors<ValueTuple<object, Int32Enum>, ValueTuple<bool, Int32Enum>, ValueTuple<bool, Int32Enum>>
	|
	|-RVA: 0x21B0B90 Offset: 0x21B0C91 VA: 0x21B0B90
	|-Enumerable.CombineSelectors<ValueTuple<object, Int32Enum>, Vector2, Vector2>
	|
	|-RVA: 0x21B0C60 Offset: 0x21B0D61 VA: 0x21B0C60
	|-Enumerable.CombineSelectors<ValueTuple<object, Int32Enum>, Vector3, Vector3>
	*/

	[ExtensionAttribute] // RVA: 0xBF7B0 Offset: 0xBF8B1 VA: 0xBF7B0
	// RVA: -1 Offset: -1
	public static IEnumerable<TResult> SelectMany<TSource, TResult>(IEnumerable<TSource> source, Func<TSource, IEnumerable<TResult>> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x212CEC0 Offset: 0x212CFC1 VA: 0x212CEC0
	|-Enumerable.SelectMany<FarmManager.RF4_CROP_STATE[], FarmManager.RF4_CROP_STATE>
	|-Enumerable.SelectMany<object, FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x212CF60 Offset: 0x212D061 VA: 0x212CF60
	|-Enumerable.SelectMany<FarmManager.RF4_SOIL_INFO[], FarmManager.RF4_SOIL_INFO>
	|-Enumerable.SelectMany<object, FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x212CD80 Offset: 0x212CE81 VA: 0x212CD80
	|-Enumerable.SelectMany<int, int>
	|
	|-RVA: 0x212CE20 Offset: 0x212CF21 VA: 0x212CE20
	|-Enumerable.SelectMany<int, Edge>
	|
	|-RVA: 0x212D000 Offset: 0x212D101 VA: 0x212D000
	|-Enumerable.SelectMany<int[], int>
	|-Enumerable.SelectMany<object, int>
	|
	|-RVA: 0x212D0A0 Offset: 0x212D1A1 VA: 0x212D0A0
	|-Enumerable.SelectMany<Type, Component>
	|-Enumerable.SelectMany<object, object>
	*/

	[IteratorStateMachineAttribute] // RVA: 0xBF7C0 Offset: 0xBF8C1 VA: 0xBF7C0
	// RVA: -1 Offset: -1
	private static IEnumerable<TResult> SelectManyIterator<TSource, TResult>(IEnumerable<TSource> source, Func<TSource, IEnumerable<TResult>> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x212D140 Offset: 0x212D241 VA: 0x212D140
	|-Enumerable.SelectManyIterator<int, int>
	|
	|-RVA: 0x212D1D0 Offset: 0x212D2D1 VA: 0x212D1D0
	|-Enumerable.SelectManyIterator<int, Edge>
	|
	|-RVA: 0x212D260 Offset: 0x212D361 VA: 0x212D260
	|-Enumerable.SelectManyIterator<object, FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x212D2F0 Offset: 0x212D3F1 VA: 0x212D2F0
	|-Enumerable.SelectManyIterator<object, FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x212D380 Offset: 0x212D481 VA: 0x212D380
	|-Enumerable.SelectManyIterator<object, int>
	|
	|-RVA: 0x212D410 Offset: 0x212D511 VA: 0x212D410
	|-Enumerable.SelectManyIterator<object, object>
	*/

	[ExtensionAttribute] // RVA: 0xBF830 Offset: 0xBF931 VA: 0xBF830
	// RVA: -1 Offset: -1
	public static IEnumerable<TSource> Take<TSource>(IEnumerable<TSource> source, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x212DE00 Offset: 0x212DF01 VA: 0x212DE00
	|-Enumerable.Take<AutomataDictionary.AutomataNode>
	|-Enumerable.Take<object>
	*/

	[IteratorStateMachineAttribute] // RVA: 0xBF840 Offset: 0xBF941 VA: 0xBF840
	// RVA: -1 Offset: -1
	private static IEnumerable<TSource> TakeIterator<TSource>(IEnumerable<TSource> source, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x212DE90 Offset: 0x212DF91 VA: 0x212DE90
	|-Enumerable.TakeIterator<object>
	*/

	[ExtensionAttribute] // RVA: 0xBF8B0 Offset: 0xBF9B1 VA: 0xBF8B0
	// RVA: -1 Offset: -1
	public static IEnumerable<TSource> TakeWhile<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x212DF20 Offset: 0x212E021 VA: 0x212DF20
	|-Enumerable.TakeWhile<TextRecordParsing.Record>
	|-Enumerable.TakeWhile<object>
	*/

	[IteratorStateMachineAttribute] // RVA: 0xBF8C0 Offset: 0xBF9C1 VA: 0xBF8C0
	// RVA: -1 Offset: -1
	private static IEnumerable<TSource> TakeWhileIterator<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x212DFC0 Offset: 0x212E0C1 VA: 0x212DFC0
	|-Enumerable.TakeWhileIterator<object>
	*/

	[ExtensionAttribute] // RVA: 0xBF930 Offset: 0xBFA31 VA: 0xBF930
	// RVA: -1 Offset: -1
	public static IEnumerable<TSource> Skip<TSource>(IEnumerable<TSource> source, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x212DCE0 Offset: 0x212DDE1 VA: 0x212DCE0
	|-Enumerable.Skip<AutomataDictionary.AutomataNode>
	|-Enumerable.Skip<NpcLifeCycleTimeData>
	|-Enumerable.Skip<string>
	|-Enumerable.Skip<TextRecordParsing.Record>
	|-Enumerable.Skip<object>
	*/

	[IteratorStateMachineAttribute] // RVA: 0xBF940 Offset: 0xBFA41 VA: 0xBF940
	// RVA: -1 Offset: -1
	private static IEnumerable<TSource> SkipIterator<TSource>(IEnumerable<TSource> source, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x212DD70 Offset: 0x212DE71 VA: 0x212DD70
	|-Enumerable.SkipIterator<object>
	*/

	[ExtensionAttribute] // RVA: 0xBF9B0 Offset: 0xBFAB1 VA: 0xBF9B0
	// RVA: -1 Offset: -1
	public static IOrderedEnumerable<TSource> OrderBy<TSource, TKey>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x255FCE0 Offset: 0x255FDE1 VA: 0x255FCE0
	|-Enumerable.OrderBy<BeanID, Guid>
	|-Enumerable.OrderBy<Int32Enum, Guid>
	|
	|-RVA: 0x255FD60 Offset: 0x255FE61 VA: 0x255FD60
	|-Enumerable.OrderBy<ObjectSerializationInfo.EmittableMember, int>
	|-Enumerable.OrderBy<UnionAttribute, int>
	|-Enumerable.OrderBy<object, int>
	|
	|-RVA: 0x255FEE0 Offset: 0x255FFE1 VA: 0x255FEE0
	|-Enumerable.OrderBy<KerningPair, uint>
	|-Enumerable.OrderBy<TMP_Character, uint>
	|-Enumerable.OrderBy<TMP_GlyphPairAdjustmentRecord, uint>
	|-Enumerable.OrderBy<TMP_SpriteCharacter, uint>
	|-Enumerable.OrderBy<TMP_SpriteGlyph, uint>
	|-Enumerable.OrderBy<Glyph, uint>
	|-Enumerable.OrderBy<object, uint>
	|
	|-RVA: 0x255FF60 Offset: 0x2560061 VA: 0x255FF60
	|-Enumerable.OrderBy<RaycastHit, float>
	|
	|-RVA: 0x255FFE0 Offset: 0x25600E1 VA: 0x255FFE0
	|-Enumerable.OrderBy<DiagnosticEvent, int>
	|
	|-RVA: 0x255FDE0 Offset: 0x255FEE1 VA: 0x255FDE0
	|-Enumerable.OrderBy<object, object>
	*/

	[ExtensionAttribute] // RVA: 0xBF9C0 Offset: 0xBFAC1 VA: 0xBF9C0
	// RVA: -1 Offset: -1
	public static IOrderedEnumerable<TSource> OrderBy<TSource, TKey>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x255FE60 Offset: 0x255FF61 VA: 0x255FE60
	|-Enumerable.OrderBy<MemberInfo, Type>
	|-Enumerable.OrderBy<object, object>
	*/

	[ExtensionAttribute] // RVA: 0xBF9D0 Offset: 0xBFAD1 VA: 0xBF9D0
	// RVA: -1 Offset: -1
	public static IOrderedEnumerable<TSource> OrderByDescending<TSource, TKey>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2560160 Offset: 0x2560261 VA: 0x2560160
	|-Enumerable.OrderByDescending<CerberusBossDataAsset.LotteryParam, float>
	|-Enumerable.OrderByDescending<DeadtreeBossDataAsset.LotteryParam, float>
	|-Enumerable.OrderByDescending<SkullDragonBossDataAsset.LotteryParam, float>
	|-Enumerable.OrderByDescending<object, float>
	|
	|-RVA: 0x2560060 Offset: 0x2560161 VA: 0x2560060
	|-Enumerable.OrderByDescending<GluttonItem, int>
	|-Enumerable.OrderByDescending<SnowballObject, int>
	|-Enumerable.OrderByDescending<ConstructorInfo, int>
	|-Enumerable.OrderByDescending<object, int>
	|
	|-RVA: 0x25600E0 Offset: 0x25601E1 VA: 0x25600E0
	|-Enumerable.OrderByDescending<object, object>
	*/

	[ExtensionAttribute] // RVA: 0xBF9E0 Offset: 0xBFAE1 VA: 0xBF9E0
	// RVA: -1 Offset: -1
	public static IOrderedEnumerable<TSource> ThenBy<TSource, TKey>(IOrderedEnumerable<TSource> source, Func<TSource, TKey> keySelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25602E0 Offset: 0x25603E1 VA: 0x25602E0
	|-Enumerable.ThenBy<KerningPair, uint>
	|-Enumerable.ThenBy<TMP_GlyphPairAdjustmentRecord, uint>
	|-Enumerable.ThenBy<object, uint>
	|
	|-RVA: 0x25601E0 Offset: 0x25602E1 VA: 0x25601E0
	|-Enumerable.ThenBy<object, object>
	*/

	[ExtensionAttribute] // RVA: 0xBF9F0 Offset: 0xBFAF1 VA: 0xBF9F0
	// RVA: -1 Offset: -1
	public static IEnumerable<IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22D4D20 Offset: 0x22D4E21 VA: 0x22D4D20
	|-Enumerable.GroupBy<MemberInfo, string>
	|-Enumerable.GroupBy<object, object>
	*/

	[ExtensionAttribute] // RVA: 0xBFA00 Offset: 0xBFB01 VA: 0xBFA00
	// RVA: -1 Offset: -1
	public static IEnumerable<TSource> Concat<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x212D4B0 Offset: 0x212D5B1 VA: 0x212D4B0
	|-Enumerable.Concat<EnvironmentSoundDataTable>
	|-Enumerable.Concat<IFormatterResolver>
	|-Enumerable.Concat<MemberInfo>
	|-Enumerable.Concat<object>
	|
	|-RVA: 0x212D550 Offset: 0x212D651 VA: 0x212D550
	|-Enumerable.Concat<DiagnosticEvent>
	*/

	[IteratorStateMachineAttribute] // RVA: 0xBFA10 Offset: 0xBFB11 VA: 0xBFA10
	// RVA: -1 Offset: -1
	private static IEnumerable<TSource> ConcatIterator<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x212D5F0 Offset: 0x212D6F1 VA: 0x212D5F0
	|-Enumerable.ConcatIterator<object>
	|
	|-RVA: 0x212D680 Offset: 0x212D781 VA: 0x212D680
	|-Enumerable.ConcatIterator<DiagnosticEvent>
	*/

	[ExtensionAttribute] // RVA: 0xBFA80 Offset: 0xBFB81 VA: 0xBFA80
	// RVA: -1 Offset: -1
	public static IEnumerable<TSource> Distinct<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x212D950 Offset: 0x212DA51 VA: 0x212D950
	|-Enumerable.Distinct<int>
	|
	|-RVA: 0x212D9E0 Offset: 0x212DAE1 VA: 0x212D9E0
	|-Enumerable.Distinct<string>
	|-Enumerable.Distinct<IResourceLocation>
	|-Enumerable.Distinct<Transform>
	|-Enumerable.Distinct<object>
	*/

	[IteratorStateMachineAttribute] // RVA: 0xBFA90 Offset: 0xBFB91 VA: 0xBFA90
	// RVA: -1 Offset: -1
	private static IEnumerable<TSource> DistinctIterator<TSource>(IEnumerable<TSource> source, IEqualityComparer<TSource> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x212DA70 Offset: 0x212DB71 VA: 0x212DA70
	|-Enumerable.DistinctIterator<int>
	|
	|-RVA: 0x212DB00 Offset: 0x212DC01 VA: 0x212DB00
	|-Enumerable.DistinctIterator<object>
	*/

	[ExtensionAttribute] // RVA: 0xBFB00 Offset: 0xBFC01 VA: 0xBFB00
	// RVA: -1 Offset: -1
	public static IEnumerable<TSource> Except<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x212DB90 Offset: 0x212DC91 VA: 0x212DB90
	|-Enumerable.Except<string>
	|-Enumerable.Except<SpringBoneSerialization.SpringBoneSerializer>
	|-Enumerable.Except<GameObject>
	|-Enumerable.Except<object>
	*/

	[IteratorStateMachineAttribute] // RVA: 0xBFB10 Offset: 0xBFC11 VA: 0xBFB10
	// RVA: -1 Offset: -1
	private static IEnumerable<TSource> ExceptIterator<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x212DC30 Offset: 0x212DD31 VA: 0x212DC30
	|-Enumerable.ExceptIterator<object>
	*/

	[ExtensionAttribute] // RVA: 0xBFB80 Offset: 0xBFC81 VA: 0xBFB80
	// RVA: -1 Offset: -1
	public static bool SequenceEqual<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22CB830 Offset: 0x22CB931 VA: 0x22CB830
	|-Enumerable.SequenceEqual<int>
	|
	|-RVA: 0x22CBF20 Offset: 0x22CC021 VA: 0x22CBF20
	|-Enumerable.SequenceEqual<object>
	*/

	[ExtensionAttribute] // RVA: 0xBFB90 Offset: 0xBFC91 VA: 0xBFB90
	// RVA: -1 Offset: -1
	public static bool SequenceEqual<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22CB850 Offset: 0x22CB951 VA: 0x22CB850
	|-Enumerable.SequenceEqual<int>
	|
	|-RVA: 0x22CBF40 Offset: 0x22CC041 VA: 0x22CBF40
	|-Enumerable.SequenceEqual<object>
	*/

	[ExtensionAttribute] // RVA: 0xBFBA0 Offset: 0xBFCA1 VA: 0xBFBA0
	// RVA: -1 Offset: -1
	public static IEnumerable<TSource> AsEnumerable<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x212D4A0 Offset: 0x212D5A1 VA: 0x212D4A0
	|-Enumerable.AsEnumerable<DeadtreeBossDataAsset.LotteryParam>
	|-Enumerable.AsEnumerable<SkullDragonBossDataAsset.LotteryParam>
	|-Enumerable.AsEnumerable<object>
	*/

	[ExtensionAttribute] // RVA: 0xBFBB0 Offset: 0xBFCB1 VA: 0xBFBB0
	// RVA: -1 Offset: -1
	public static TSource[] ToArray<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x226BFE0 Offset: 0x226C0E1 VA: 0x226BFE0
	|-Enumerable.ToArray<<>f__AnonymousType0<Label, UnionAttribute>>
	|-Enumerable.ToArray<CerberusBossDataAsset.LotteryParam>
	|-Enumerable.ToArray<DeadtreeBossDataAsset.LotteryParam>
	|-Enumerable.ToArray<SkullDragonBossDataAsset.LotteryParam>
	|-Enumerable.ToArray<GluttonItem>
	|-Enumerable.ToArray<ItemData>
	|-Enumerable.ToArray<ItemStorage>
	|-Enumerable.ToArray<IMessagePackFormatter>
	|-Enumerable.ToArray<IFormatterResolver>
	|-Enumerable.ToArray<AutomataDictionary.AutomataNode>
	|-Enumerable.ToArray<DynamicObjectTypeBuilder.DeserializeInfo>
	|-Enumerable.ToArray<ObjectSerializationInfo.EmittableMember>
	|-Enumerable.ToArray<UnionAttribute>
	|-Enumerable.ToArray<FriendMonsterIDAndHouseID>
	|-Enumerable.ToArray<NpcLifeCycleTimeData>
	|-Enumerable.ToArray<PolygonPoint>
	|-Enumerable.ToArray<SnowballObject>
	|-Enumerable.ToArray<MethodInfo>
	|-Enumerable.ToArray<string>
	|-Enumerable.ToArray<ForceProvider>
	|-Enumerable.ToArray<SpringBone>
	|-Enumerable.ToArray<SpringBoneSerialization.LengthLimitSerializer>
	|-Enumerable.ToArray<SpringCapsuleCollider>
	|-Enumerable.ToArray<SpringPanelCollider>
	|-Enumerable.ToArray<SpringSphereCollider>
	|-Enumerable.ToArray<GameObject>
	|-Enumerable.ToArray<Material>
	|-Enumerable.ToArray<Face>
	|-Enumerable.ToArray<SharedVertex>
	|-Enumerable.ToArray<IResourceLocation>
	|-Enumerable.ToArray<TimelineClip>
	|-Enumerable.ToArray<Transform>
	|-Enumerable.ToArray<Expression>
	|-Enumerable.ToArray<object>
	|
	|-RVA: 0x226BBC0 Offset: 0x226BCC1 VA: 0x226BBC0
	|-Enumerable.ToArray<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x226BC70 Offset: 0x226BD71 VA: 0x226BC70
	|-Enumerable.ToArray<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x226BF30 Offset: 0x226C031 VA: 0x226BF30
	|-Enumerable.ToArray<ItemID>
	|-Enumerable.ToArray<Int32Enum>
	|
	|-RVA: 0x226BD20 Offset: 0x226BE21 VA: 0x226BD20
	|-Enumerable.ToArray<MiningPointSaveData>
	|
	|-RVA: 0x226BDD0 Offset: 0x226BED1 VA: 0x226BDD0
	|-Enumerable.ToArray<bool>
	|
	|-RVA: 0x226BE80 Offset: 0x226BF81 VA: 0x226BE80
	|-Enumerable.ToArray<int>
	|
	|-RVA: 0x226C090 Offset: 0x226C191 VA: 0x226C090
	|-Enumerable.ToArray<Label>
	|
	|-RVA: 0x226C140 Offset: 0x226C241 VA: 0x226C140
	|-Enumerable.ToArray<float>
	|
	|-RVA: 0x226C1F0 Offset: 0x226C2F1 VA: 0x226C1F0
	|-Enumerable.ToArray<uint>
	|
	|-RVA: 0x226C2A0 Offset: 0x226C3A1 VA: 0x226C2A0
	|-Enumerable.ToArray<Color>
	|
	|-RVA: 0x226C350 Offset: 0x226C451 VA: 0x226C350
	|-Enumerable.ToArray<Edge>
	|
	|-RVA: 0x226C400 Offset: 0x226C501 VA: 0x226C400
	|-Enumerable.ToArray<Vector2>
	|
	|-RVA: 0x226C4B0 Offset: 0x226C5B1 VA: 0x226C4B0
	|-Enumerable.ToArray<Vector3>
	|
	|-RVA: 0x226C560 Offset: 0x226C661 VA: 0x226C560
	|-Enumerable.ToArray<Vector4>
	*/

	[ExtensionAttribute] // RVA: 0xBFBC0 Offset: 0xBFCC1 VA: 0xBFBC0
	// RVA: -1 Offset: -1
	public static List<TSource> ToList<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21AAC60 Offset: 0x21AAD61 VA: 0x21AAC60
	|-Enumerable.ToList<<>f__AnonymousType0<SpringBone, int>>
	|-Enumerable.ToList<OnGroundItem>
	|-Enumerable.ToList<PartyBase>
	|-Enumerable.ToList<OptionDefinition>
	|-Enumerable.ToList<ConsoleEntry>
	|-Enumerable.ToList<string>
	|-Enumerable.ToList<KerningPair>
	|-Enumerable.ToList<TMP_Character>
	|-Enumerable.ToList<TMP_GlyphPairAdjustmentRecord>
	|-Enumerable.ToList<TMP_SpriteCharacter>
	|-Enumerable.ToList<TMP_SpriteGlyph>
	|-Enumerable.ToList<DynamicsSetup.ParseMessage>
	|-Enumerable.ToList<SpringBone>
	|-Enumerable.ToList<TextRecordParsing.Record>
	|-Enumerable.ToList<GameObject>
	|-Enumerable.ToList<GameObject[]>
	|-Enumerable.ToList<SkinnedMeshRenderer>
	|-Enumerable.ToList<Glyph>
	|-Enumerable.ToList<Transform>
	|-Enumerable.ToList<object>
	|
	|-RVA: 0x21AABB0 Offset: 0x21AACB1 VA: 0x21AABB0
	|-Enumerable.ToList<BeanID>
	|-Enumerable.ToList<ActorID>
	|-Enumerable.ToList<ItemID>
	|-Enumerable.ToList<Int32Enum>
	|
	|-RVA: 0x21AA9A0 Offset: 0x21AAAA1 VA: 0x21AA9A0
	|-Enumerable.ToList<CropDataTable>
	|
	|-RVA: 0x21AAA50 Offset: 0x21AAB51 VA: 0x21AAA50
	|-Enumerable.ToList<MiningPointSaveData>
	|
	|-RVA: 0x21AAB00 Offset: 0x21AAC01 VA: 0x21AAB00
	|-Enumerable.ToList<KeyValuePair<int, FishSwim>>
	|-Enumerable.ToList<KeyValuePair<int, object>>
	|
	|-RVA: 0x21AAD10 Offset: 0x21AAE11 VA: 0x21AAD10
	|-Enumerable.ToList<RaycastHit>
	|
	|-RVA: 0x21AADC0 Offset: 0x21AAEC1 VA: 0x21AADC0
	|-Enumerable.ToList<Vector2>
	|
	|-RVA: 0x21AAE70 Offset: 0x21AAF71 VA: 0x21AAE70
	|-Enumerable.ToList<Vector3>
	*/

	[ExtensionAttribute] // RVA: 0xBFBD0 Offset: 0xBFCD1 VA: 0xBFBD0
	// RVA: -1 Offset: -1
	public static Dictionary<TKey, TSource> ToDictionary<TSource, TKey>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22D4C60 Offset: 0x22D4D61 VA: 0x22D4C60
	|-Enumerable.ToDictionary<ObjectSerializationInfo.EmittableMember, int>
	|-Enumerable.ToDictionary<object, int>
	|
	|-RVA: 0x22D4CC0 Offset: 0x22D4DC1 VA: 0x22D4CC0
	|-Enumerable.ToDictionary<object, object>
	*/

	[ExtensionAttribute] // RVA: 0xBFBE0 Offset: 0xBFCE1 VA: 0xBFBE0
	// RVA: -1 Offset: -1
	public static Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22D3D60 Offset: 0x22D3E61 VA: 0x22D3D60
	|-Enumerable.ToDictionary<KeyValuePair<object, object>, object, object>
	|
	|-RVA: 0x22D4760 Offset: 0x22D4861 VA: 0x22D4760
	|-Enumerable.ToDictionary<object, object, object>
	*/

	[ExtensionAttribute] // RVA: 0xBFBF0 Offset: 0xBFCF1 VA: 0xBFBF0
	// RVA: -1 Offset: -1
	public static Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22D3D80 Offset: 0x22D3E81 VA: 0x22D3D80
	|-Enumerable.ToDictionary<KeyValuePair<object, object>, object, object>
	|
	|-RVA: 0x22D4280 Offset: 0x22D4381 VA: 0x22D4280
	|-Enumerable.ToDictionary<object, int, object>
	|
	|-RVA: 0x22D4780 Offset: 0x22D4881 VA: 0x22D4780
	|-Enumerable.ToDictionary<object, object, object>
	*/

	[ExtensionAttribute] // RVA: 0xBFC00 Offset: 0xBFD01 VA: 0xBFC00
	// RVA: -1 Offset: -1
	public static ILookup<TKey, TElement> ToLookup<TSource, TKey, TElement>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x255FB60 Offset: 0x255FC61 VA: 0x255FB60
	|-Enumerable.ToLookup<KeyValuePair<string, ObjectSerializationInfo.EmittableMember>, string, KeyValuePair<string, ObjectSerializationInfo.EmittableMember>>
	|-Enumerable.ToLookup<KeyValuePair<object, object>, object, KeyValuePair<object, object>>
	|
	|-RVA: 0x255FB70 Offset: 0x255FC71 VA: 0x255FB70
	|-Enumerable.ToLookup<object, object, object>
	*/

	[ExtensionAttribute] // RVA: 0xBFC10 Offset: 0xBFD11 VA: 0xBFC10
	// RVA: -1 Offset: -1
	public static IEnumerable<TSource> DefaultIfEmpty<TSource>(IEnumerable<TSource> source, TSource defaultValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x212D710 Offset: 0x212D811 VA: 0x212D710
	|-Enumerable.DefaultIfEmpty<int>
	|
	|-RVA: 0x212D7A0 Offset: 0x212D8A1 VA: 0x212D7A0
	|-Enumerable.DefaultIfEmpty<object>
	*/

	[IteratorStateMachineAttribute] // RVA: 0xBFC20 Offset: 0xBFD21 VA: 0xBFC20
	// RVA: -1 Offset: -1
	private static IEnumerable<TSource> DefaultIfEmptyIterator<TSource>(IEnumerable<TSource> source, TSource defaultValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x212D830 Offset: 0x212D931 VA: 0x212D830
	|-Enumerable.DefaultIfEmptyIterator<int>
	|
	|-RVA: 0x212D8C0 Offset: 0x212D9C1 VA: 0x212D8C0
	|-Enumerable.DefaultIfEmptyIterator<object>
	*/

	[ExtensionAttribute] // RVA: 0xBFC90 Offset: 0xBFD91 VA: 0xBFC90
	// RVA: -1 Offset: -1
	public static IEnumerable<TResult> Cast<TResult>(IEnumerable source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21294B0 Offset: 0x21295B1 VA: 0x21294B0
	|-Enumerable.Cast<MemberInfo>
	|-Enumerable.Cast<Transform>
	|-Enumerable.Cast<object>
	|
	|-RVA: 0x2129590 Offset: 0x2129691 VA: 0x2129590
	|-Enumerable.Cast<float>
	|
	|-RVA: 0x2129670 Offset: 0x2129771 VA: 0x2129670
	|-Enumerable.Cast<Vector2>
	*/

	[IteratorStateMachineAttribute] // RVA: 0xBFCA0 Offset: 0xBFDA1 VA: 0xBFCA0
	// RVA: -1 Offset: -1
	private static IEnumerable<TResult> CastIterator<TResult>(IEnumerable source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2129750 Offset: 0x2129851 VA: 0x2129750
	|-Enumerable.CastIterator<object>
	|
	|-RVA: 0x21297D0 Offset: 0x21298D1 VA: 0x21297D0
	|-Enumerable.CastIterator<float>
	|
	|-RVA: 0x2129850 Offset: 0x2129951 VA: 0x2129850
	|-Enumerable.CastIterator<Vector2>
	*/

	[ExtensionAttribute] // RVA: 0xBFD10 Offset: 0xBFE11 VA: 0xBFD10
	// RVA: -1 Offset: -1
	public static TSource First<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2269560 Offset: 0x2269661 VA: 0x2269560
	|-Enumerable.First<PlayerTeleport>
	|-Enumerable.First<SEController>
	|-Enumerable.First<MethodInfo>
	|-Enumerable.First<string>
	|-Enumerable.First<object>
	|
	|-RVA: 0x2269110 Offset: 0x2269211 VA: 0x2269110
	|-Enumerable.First<KeyValuePair<string, ObjectSerializationInfo.EmittableMember>>
	|-Enumerable.First<KeyValuePair<object, object>>
	|
	|-RVA: 0x226A0B0 Offset: 0x226A1B1 VA: 0x226A0B0
	|-Enumerable.First<RaycastHit>
	*/

	[ExtensionAttribute] // RVA: 0xBFD20 Offset: 0xBFE21 VA: 0xBFD20
	// RVA: -1 Offset: -1
	public static TSource First<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22699B0 Offset: 0x2269AB1 VA: 0x22699B0
	|-Enumerable.First<SerializeCropDataTable>
	|-Enumerable.First<DynamicObjectTypeBuilder.DeserializeInfo>
	|-Enumerable.First<ConstructorInfo>
	|-Enumerable.First<MethodInfo>
	|-Enumerable.First<object>
	|
	|-RVA: 0x2269D00 Offset: 0x2269E01 VA: 0x2269D00
	|-Enumerable.First<PlayableBinding>
	*/

	[ExtensionAttribute] // RVA: 0xBFD30 Offset: 0xBFE31 VA: 0xBFD30
	// RVA: -1 Offset: -1
	public static TSource FirstOrDefault<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x226A8B0 Offset: 0x226A9B1 VA: 0x226A8B0
	|-Enumerable.FirstOrDefault<MessagePackObjectAttribute>
	|-Enumerable.FirstOrDefault<ActionControl>
	|-Enumerable.FirstOrDefault<SRTab>
	|-Enumerable.FirstOrDefault<MethodInfo>
	|-Enumerable.FirstOrDefault<string>
	|-Enumerable.FirstOrDefault<TypedStringToValueMap>
	|-Enumerable.FirstOrDefault<Vertex>
	|-Enumerable.FirstOrDefault<TimelineClip>
	|-Enumerable.FirstOrDefault<Transform>
	|-Enumerable.FirstOrDefault<object>
	*/

	[ExtensionAttribute] // RVA: 0xBFD40 Offset: 0xBFE41 VA: 0xBFD40
	// RVA: -1 Offset: -1
	public static TSource FirstOrDefault<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x226ACF0 Offset: 0x226ADF1 VA: 0x226ACF0
	|-Enumerable.FirstOrDefault<MiningPoint>
	|-Enumerable.FirstOrDefault<DataBoundControl>
	|-Enumerable.FirstOrDefault<SRServiceManager.ServiceStub>
	|-Enumerable.FirstOrDefault<SceneSplit>
	|-Enumerable.FirstOrDefault<MethodInfo>
	|-Enumerable.FirstOrDefault<Type>
	|-Enumerable.FirstOrDefault<TextRecordParsing.Record>
	|-Enumerable.FirstOrDefault<AnimatorControllerParameter>
	|-Enumerable.FirstOrDefault<Component>
	|-Enumerable.FirstOrDefault<IResourceProvider>
	|-Enumerable.FirstOrDefault<object>
	|
	|-RVA: 0x226A550 Offset: 0x226A651 VA: 0x226A550
	|-Enumerable.FirstOrDefault<KeyValuePair<int, OnGroundItem>>
	|-Enumerable.FirstOrDefault<KeyValuePair<int, object>>
	*/

	[ExtensionAttribute] // RVA: 0xBFD50 Offset: 0xBFE51 VA: 0xBFD50
	// RVA: -1 Offset: -1
	public static TSource Last<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x226B030 Offset: 0x226B131 VA: 0x226B030
	|-Enumerable.Last<SplineNode>
	|-Enumerable.Last<string>
	|-Enumerable.Last<string[]>
	|-Enumerable.Last<KerningPair>
	|-Enumerable.Last<AsyncOperationHandle<SceneInstance>[]>
	|-Enumerable.Last<Expression>
	|-Enumerable.Last<object>
	*/

	[ExtensionAttribute] // RVA: 0xBFD60 Offset: 0xBFE61 VA: 0xBFD60
	// RVA: -1 Offset: -1
	public static TSource Single<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x226B4F0 Offset: 0x226B5F1 VA: 0x226B4F0
	|-Enumerable.Single<MethodInfo>
	|-Enumerable.Single<object>
	*/

	[ExtensionAttribute] // RVA: 0xBFD70 Offset: 0xBFE71 VA: 0xBFD70
	// RVA: -1 Offset: -1
	public static TSource SingleOrDefault<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x226B860 Offset: 0x226B961 VA: 0x226B860
	|-Enumerable.SingleOrDefault<ConstructorInfo>
	|-Enumerable.SingleOrDefault<PlayerEditorConnectionEvents.MessageTypeSubscribers>
	|-Enumerable.SingleOrDefault<object>
	*/

	[ExtensionAttribute] // RVA: 0xBFD80 Offset: 0xBFE81 VA: 0xBFD80
	// RVA: -1 Offset: -1
	public static TSource ElementAt<TSource>(IEnumerable<TSource> source, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22685A0 Offset: 0x22686A1 VA: 0x22685A0
	|-Enumerable.ElementAt<ItemID>
	|-Enumerable.ElementAt<Int32Enum>
	|
	|-RVA: 0x2268D40 Offset: 0x2268E41 VA: 0x2268D40
	|-Enumerable.ElementAt<ValueTuple<ActorID, int>>
	|-Enumerable.ElementAt<ValueTuple<Int32Enum, int>>
	|
	|-RVA: 0x2268970 Offset: 0x2268A71 VA: 0x2268970
	|-Enumerable.ElementAt<object>
	*/

	// RVA: 0x16A5910 Offset: 0x16A5A11 VA: 0x16A5910
	public static IEnumerable<int> Range(int start, int count) { }

	[IteratorStateMachineAttribute] // RVA: 0xBFD90 Offset: 0xBFE91 VA: 0xBFD90
	// RVA: 0x16A5A70 Offset: 0x16A5B71 VA: 0x16A5A70
	private static IEnumerable<int> RangeIterator(int start, int count) { }

	// RVA: -1 Offset: -1
	public static IEnumerable<TResult> Repeat<TResult>(TResult element, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2129AD0 Offset: 0x2129BD1 VA: 0x2129AD0
	|-Enumerable.Repeat<ItemID>
	|-Enumerable.Repeat<Int32Enum>
	|
	|-RVA: 0x21298D0 Offset: 0x21299D1 VA: 0x21298D0
	|-Enumerable.Repeat<MiningPointSaveData>
	|
	|-RVA: 0x2129B60 Offset: 0x2129C61 VA: 0x2129B60
	|-Enumerable.Repeat<FriendMonsterIDAndHouseID>
	|-Enumerable.Repeat<object>
	|
	|-RVA: 0x21299B0 Offset: 0x2129AB1 VA: 0x21299B0
	|-Enumerable.Repeat<bool>
	|
	|-RVA: 0x2129A40 Offset: 0x2129B41 VA: 0x2129A40
	|-Enumerable.Repeat<int>
	*/

	[IteratorStateMachineAttribute] // RVA: 0xBFE00 Offset: 0xBFF01 VA: 0xBFE00
	// RVA: -1 Offset: -1
	private static IEnumerable<TResult> RepeatIterator<TResult>(TResult element, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2129BF0 Offset: 0x2129CF1 VA: 0x2129BF0
	|-Enumerable.RepeatIterator<MiningPointSaveData>
	|
	|-RVA: 0x2129CB0 Offset: 0x2129DB1 VA: 0x2129CB0
	|-Enumerable.RepeatIterator<bool>
	|
	|-RVA: 0x2129D30 Offset: 0x2129E31 VA: 0x2129D30
	|-Enumerable.RepeatIterator<int>
	|
	|-RVA: 0x2129DB0 Offset: 0x2129EB1 VA: 0x2129DB0
	|-Enumerable.RepeatIterator<Int32Enum>
	|
	|-RVA: 0x2129E30 Offset: 0x2129F31 VA: 0x2129E30
	|-Enumerable.RepeatIterator<object>
	*/

	[ExtensionAttribute] // RVA: 0xBFE70 Offset: 0xBFF71 VA: 0xBFE70
	// RVA: -1 Offset: -1
	public static bool Any<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22C9C90 Offset: 0x22C9D91 VA: 0x22C9C90
	|-Enumerable.Any<PlayerTeleport>
	|-Enumerable.Any<object>
	|-Enumerable.Any<string>
	|-Enumerable.Any<string[]>
	|-Enumerable.Any<SpringBone>
	|-Enumerable.Any<SpringBoneSerialization.PivotSerializer>
	|-Enumerable.Any<SpringColliderSerialization.CapsuleColliderSerializer>
	|-Enumerable.Any<SpringColliderSerialization.PanelColliderSerializer>
	|-Enumerable.Any<SpringColliderSerialization.SphereColliderSerializer>
	|-Enumerable.Any<SpringColliderSerialization.TransformSerializer>
	|-Enumerable.Any<GameObject>
	|-Enumerable.Any<GameObject[]>
	|-Enumerable.Any<PlayerEditorConnectionEvents.MessageTypeSubscribers>
	|-Enumerable.Any<AsyncOperationHandle<SceneInstance>[]>
	|
	|-RVA: 0x22CA240 Offset: 0x22CA341 VA: 0x22CA240
	|-Enumerable.Any<AsyncOperationHandle<SceneInstance>>
	*/

	[ExtensionAttribute] // RVA: 0xBFE80 Offset: 0xBFF81 VA: 0xBFE80
	// RVA: -1 Offset: -1
	public static bool Any<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22C9F00 Offset: 0x22CA001 VA: 0x22C9F00
	|-Enumerable.Any<Character>
	|-Enumerable.Any<ObjectSerializationInfo.EmittableMemberAndConstructorParameter>
	|-Enumerable.Any<PartyData>
	|-Enumerable.Any<InfoEntry>
	|-Enumerable.Any<object>
	|-Enumerable.Any<ConstructorInfo>
	|-Enumerable.Any<string>
	|-Enumerable.Any<Type>
	|-Enumerable.Any<SpringColliderSerialization.IColliderSerializer>
	|-Enumerable.Any<SpringColliderSerialization.TransformSerializer>
	|-Enumerable.Any<PlayerEditorConnectionEvents.MessageTypeSubscribers>
	|
	|-RVA: 0x22C9610 Offset: 0x22C9711 VA: 0x22C9610
	|-Enumerable.Any<char>
	|
	|-RVA: 0x22C9950 Offset: 0x22C9A51 VA: 0x22C9950
	|-Enumerable.Any<int>
	*/

	[ExtensionAttribute] // RVA: 0xBFE90 Offset: 0xBFF91 VA: 0xBFE90
	// RVA: -1 Offset: -1
	public static bool All<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22C92E0 Offset: 0x22C93E1 VA: 0x22C92E0
	|-Enumerable.All<Expression>
	|-Enumerable.All<SwitchCase>
	|-Enumerable.All<object>
	*/

	[ExtensionAttribute] // RVA: 0xBFEA0 Offset: 0xBFFA1 VA: 0xBFEA0
	// RVA: -1 Offset: -1
	public static int Count<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x255A1E0 Offset: 0x255A2E1 VA: 0x255A1E0
	|-Enumerable.Count<SerializeClothShopDataTable>
	|-Enumerable.Count<HumanController>
	|-Enumerable.Count<EnvironmentSoundController>
	|-Enumerable.Count<SEController>
	|-Enumerable.Count<object>
	|-Enumerable.Count<ParameterInfo>
	|-Enumerable.Count<SpringBoneSerialization.PivotSerializer>
	|-Enumerable.Count<SpringBoneSerialization.SpringBoneSerializer>
	|-Enumerable.Count<SpringColliderSerialization.IColliderSerializer>
	|-Enumerable.Count<SpringColliderSerialization.TransformSerializer>
	|-Enumerable.Count<TextRecordParsing.Record>
	|
	|-RVA: 0x2559B30 Offset: 0x2559C31 VA: 0x2559B30
	|-Enumerable.Count<ClothShopID>
	|-Enumerable.Count<HotSpringID>
	|-Enumerable.Count<RecipePanShopID>
	|-Enumerable.Count<VaccinationID>
	|-Enumerable.Count<ItemID>
	|-Enumerable.Count<RecipeId>
	|-Enumerable.Count<Int32Enum>
	|
	|-RVA: 0x2559430 Offset: 0x2559531 VA: 0x2559430
	|-Enumerable.Count<KeyValuePair<object, object>>
	|-Enumerable.Count<KeyValuePair<string, ObjectSerializationInfo.EmittableMember>>
	|
	|-RVA: 0x25597B0 Offset: 0x25598B1 VA: 0x25597B0
	|-Enumerable.Count<int>
	|
	|-RVA: 0x255AC10 Offset: 0x255AD11 VA: 0x255AC10
	|-Enumerable.Count<ValueTuple<ActorID, int>>
	|-Enumerable.Count<ValueTuple<Int32Enum, int>>
	|
	|-RVA: 0x255A890 Offset: 0x255A991 VA: 0x255A890
	|-Enumerable.Count<ValueTuple<bool, ItemID>>
	|-Enumerable.Count<ValueTuple<bool, Int32Enum>>
	|
	|-RVA: 0x255AF90 Offset: 0x255B091 VA: 0x255AF90
	|-Enumerable.Count<Color>
	|
	|-RVA: 0x255B680 Offset: 0x255B781 VA: 0x255B680
	|-Enumerable.Count<Vector2>
	|
	|-RVA: 0x255BA00 Offset: 0x255BB01 VA: 0x255BA00
	|-Enumerable.Count<Vector3>
	|
	|-RVA: 0x255BD80 Offset: 0x255BE81 VA: 0x255BD80
	|-Enumerable.Count<Vector4>
	*/

	[ExtensionAttribute] // RVA: 0xBFEB0 Offset: 0xBFFB1 VA: 0xBFEB0
	// RVA: -1 Offset: -1
	public static int Count<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x255A560 Offset: 0x255A661 VA: 0x255A560
	|-Enumerable.Count<ItemData>
	|-Enumerable.Count<ObjectSerializationInfo.EmittableMember>
	|-Enumerable.Count<FriendMonsterIDAndHouseID>
	|-Enumerable.Count<PartyBase>
	|-Enumerable.Count<object>
	|
	|-RVA: 0x2559EB0 Offset: 0x2559FB1 VA: 0x2559EB0
	|-Enumerable.Count<ItemID>
	|-Enumerable.Count<Int32Enum>
	|
	|-RVA: 0x2558DA0 Offset: 0x2558EA1 VA: 0x2558DA0
	|-Enumerable.Count<MiningPointSaveData>
	|
	|-RVA: 0x2559100 Offset: 0x2559201 VA: 0x2559100
	|-Enumerable.Count<bool>
	|
	|-RVA: 0x255B310 Offset: 0x255B411 VA: 0x255B310
	|-Enumerable.Count<RaycastHit>
	*/

	[ExtensionAttribute] // RVA: 0xBFEC0 Offset: 0xBFFC1 VA: 0xBFEC0
	// RVA: -1 Offset: -1
	public static bool Contains<TSource>(IEnumerable<TSource> source, TSource value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22CAE70 Offset: 0x22CAF71 VA: 0x22CAE70
	|-Enumerable.Contains<EquipSubAttribute>
	|-Enumerable.Contains<EventPointID>
	|-Enumerable.Contains<ItemCategory>
	|-Enumerable.Contains<ItemID>
	|-Enumerable.Contains<Int32Enum>
	|
	|-RVA: 0x22CB350 Offset: 0x22CB451 VA: 0x22CB350
	|-Enumerable.Contains<FocusInterface>
	|-Enumerable.Contains<object>
	|-Enumerable.Contains<string>
	|-Enumerable.Contains<Type>
	|-Enumerable.Contains<Transform>
	|
	|-RVA: 0x22CA4B0 Offset: 0x22CA5B1 VA: 0x22CA4B0
	|-Enumerable.Contains<char>
	|
	|-RVA: 0x22CA990 Offset: 0x22CAA91 VA: 0x22CA990
	|-Enumerable.Contains<int>
	*/

	[ExtensionAttribute] // RVA: 0xBFED0 Offset: 0xBFFD1 VA: 0xBFED0
	// RVA: -1 Offset: -1
	public static bool Contains<TSource>(IEnumerable<TSource> source, TSource value, IEqualityComparer<TSource> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22CA5B0 Offset: 0x22CA6B1 VA: 0x22CA5B0
	|-Enumerable.Contains<char>
	|
	|-RVA: 0x22CAA90 Offset: 0x22CAB91 VA: 0x22CAA90
	|-Enumerable.Contains<int>
	|
	|-RVA: 0x22CAF70 Offset: 0x22CB071 VA: 0x22CAF70
	|-Enumerable.Contains<Int32Enum>
	|
	|-RVA: 0x22CB450 Offset: 0x22CB551 VA: 0x22CB450
	|-Enumerable.Contains<object>
	*/

	[ExtensionAttribute] // RVA: 0xBFEE0 Offset: 0xBFFE1 VA: 0xBFEE0
	// RVA: 0x16A5B40 Offset: 0x16A5C41 VA: 0x16A5B40
	public static int Sum(IEnumerable<int> source) { }

	[ExtensionAttribute] // RVA: 0xBFEF0 Offset: 0xBFFF1 VA: 0xBFEF0
	// RVA: 0x16A5E60 Offset: 0x16A5F61 VA: 0x16A5E60
	public static float Sum(IEnumerable<float> source) { }

	[ExtensionAttribute] // RVA: 0xBFF00 Offset: 0xC0001 VA: 0xBFF00
	// RVA: -1 Offset: -1
	public static int Sum<TSource>(IEnumerable<TSource> source, Func<TSource, int> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x255C160 Offset: 0x255C261 VA: 0x255C160
	|-Enumerable.Sum<CropDataTable>
	|
	|-RVA: 0x255C190 Offset: 0x255C291 VA: 0x255C190
	|-Enumerable.Sum<object>
	|-Enumerable.Sum<Face>
	*/

	[ExtensionAttribute] // RVA: 0xBFF10 Offset: 0xC0011 VA: 0xBFF10
	// RVA: 0x16A6100 Offset: 0x16A6201 VA: 0x16A6100
	public static int Min(IEnumerable<int> source) { }

	[ExtensionAttribute] // RVA: 0xBFF20 Offset: 0xC0021 VA: 0xBFF20
	// RVA: -1 Offset: -1
	public static int Min<TSource>(IEnumerable<TSource> source, Func<TSource, int> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x255C130 Offset: 0x255C231 VA: 0x255C130
	|-Enumerable.Min<SerializeDualWorkDataTable>
	|-Enumerable.Min<SerializeDualWorkSmithDataTable>
	|-Enumerable.Min<object>
	*/

	[ExtensionAttribute] // RVA: 0xBFF30 Offset: 0xC0031 VA: 0xBFF30
	// RVA: 0x16A6440 Offset: 0x16A6541 VA: 0x16A6440
	public static int Max(IEnumerable<int> source) { }

	[ExtensionAttribute] // RVA: 0xBFF40 Offset: 0xC0041 VA: 0xBFF40
	// RVA: 0x16A6710 Offset: 0x16A6811 VA: 0x16A6710
	public static float Max(IEnumerable<float> source) { }

	[ExtensionAttribute] // RVA: 0xBFF50 Offset: 0xC0051 VA: 0xBFF50
	// RVA: -1 Offset: -1
	public static int Max<TSource>(IEnumerable<TSource> source, Func<TSource, int> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x255C100 Offset: 0x255C201 VA: 0x255C100
	|-Enumerable.Max<SerializeDualWorkDataTable>
	|-Enumerable.Max<SerializeDualWorkSmithDataTable>
	|-Enumerable.Max<object>
	*/

	[ExtensionAttribute] // RVA: 0xBFF60 Offset: 0xC0061 VA: 0xBFF60
	// RVA: 0x16A6A40 Offset: 0x16A6B41 VA: 0x16A6A40
	public static double Average(IEnumerable<int> source) { }

	[ExtensionAttribute] // RVA: 0xBFF70 Offset: 0xC0071 VA: 0xBFF70
	// RVA: -1 Offset: -1
	public static double Average<TSource>(IEnumerable<TSource> source, Func<TSource, int> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21ABBF0 Offset: 0x21ABCF1 VA: 0x21ABBF0
	|-Enumerable.Average<ItemData>
	|-Enumerable.Average<object>
	*/
}

