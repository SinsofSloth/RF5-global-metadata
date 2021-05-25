[DebuggerDisplayAttribute] // RVA: 0xBF200 Offset: 0xBF301 VA: 0xBF200
[DebuggerTypeProxyAttribute] // RVA: 0xBF200 Offset: 0xBF301 VA: 0xBF200
[Serializable]
public class HashSet<T> : ICollection<T>, IEnumerable<T>, IEnumerable, ISet<T>, IReadOnlyCollection<T>, ISerializable, IDeserializationCallback // TypeDefIndex: 2743
{
	// Fields
	private const int Lower31BitMask = 2147483647;
	private const int StackAllocThreshold = 100;
	private const int ShrinkThreshold = 3;
	private const string CapacityName = "Capacity";
	private const string ElementsName = "Elements";
	private const string ComparerName = "Comparer";
	private const string VersionName = "Version";
	private int[] _buckets; // 0x0
	private HashSet.Slot<T>[] _slots; // 0x0
	private int _count; // 0x0
	private int _lastIndex; // 0x0
	private int _freeList; // 0x0
	private IEqualityComparer<T> _comparer; // 0x0
	private int _version; // 0x0
	private SerializationInfo _siInfo; // 0x0

	// Properties
	public int Count { get; }
	private bool System.Collections.Generic.ICollection<T>.IsReadOnly { get; }
	public IEqualityComparer<T> Comparer { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2ED1200 Offset: 0x2ED1301 VA: 0x2ED1200
	|-HashSet<ActorController>..ctor
	|-HashSet<Character>..ctor
	|-HashSet<CharacterBase>..ctor
	|-HashSet<EnvironmentSoundPointController>..ctor
	|-HashSet<FieldHideItemSpawner>..ctor
	|-HashSet<FieldItemSpawner>..ctor
	|-HashSet<FieldRandomTreasureBoxSpawner>..ctor
	|-HashSet<FieldRewardTreasureBoxSpawner>..ctor
	|-HashSet<FieldUniqueTreasureBoxSpawner>..ctor
	|-HashSet<IndoorShadowFloor>..ctor
	|-HashSet<MaterialChangeTime>..ctor
	|-HashSet<ObjectChangeTime>..ctor
	|-HashSet<RendererChangeTime>..ctor
	|-HashSet<TextureChangeByFlag>..ctor
	|-HashSet<VisibleChangeByFlag>..ctor
	|-HashSet<BaseSpriteItemData>..ctor
	|-HashSet<GimmickBase>..ctor
	|-HashSet<MapFieldCollider>..ctor
	|-HashSet<MiningPoint>..ctor
	|-HashSet<SEController>..ctor
	|-HashSet<SeasonChangeObject>..ctor
	|-HashSet<SeasonVisibleObject>..ctor
	|-HashSet<Func<IEnumerator>>..ctor
	|-HashSet<LabelScopeInfo>..ctor
	|-HashSet<ParameterExpression>..ctor
	|-HashSet<object>..ctor
	|-HashSet<string>..ctor
	|-HashSet<Type>..ctor
	|-HashSet<TeleportDragonRope>..ctor
	|-HashSet<Collider>..ctor
	|-HashSet<GameObject>..ctor
	|-HashSet<Material>..ctor
	|-HashSet<Object>..ctor
	|-HashSet<ParticleSystem>..ctor
	|-HashSet<PlayableDirector>..ctor
	|-HashSet<IResourceLocation>..ctor
	|-HashSet<ResourceManager.InstanceOperation>..ctor
	|-HashSet<Transform>..ctor
	|-HashSet<IClippable>..ctor
	|-HashSet<MaskableGraphic>..ctor
	|-HashSet<Text>..ctor
	|
	|-RVA: 0x2ECDEC0 Offset: 0x2ECDFC1 VA: 0x2ECDEC0
	|-HashSet<CraftCategoryId>..ctor
	|-HashSet<EquipSubAttribute>..ctor
	|-HashSet<FieldHideItemSpawnID>..ctor
	|-HashSet<FieldItemSpawnID>..ctor
	|-HashSet<FieldRandomTreasureBoxSpawnID>..ctor
	|-HashSet<FieldRewardTreasureBoxSpawnID>..ctor
	|-HashSet<FieldUniqueTreasureBoxSpawnID>..ctor
	|-HashSet<FieldWoodBoxSpawnID>..ctor
	|-HashSet<GimmickLayoutID>..ctor
	|-HashSet<ItemID>..ctor
	|-HashSet<RecipeId>..ctor
	|-HashSet<Int32Enum>..ctor
	|
	|-RVA: 0x2ECAB80 Offset: 0x2ECAC81 VA: 0x2ECAB80
	|-HashSet<int>..ctor
	|
	|-RVA: 0x2ED44D0 Offset: 0x2ED45D1 VA: 0x2ED44D0
	|-HashSet<uint>..ctor
	|
	|-RVA: 0x2ED7810 Offset: 0x2ED7911 VA: 0x2ED7810
	|-HashSet<Edge>..ctor
	|
	|-RVA: 0x2EDAAB0 Offset: 0x2EDABB1 VA: 0x2EDAAB0
	|-HashSet<AsyncOperationHandle>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IEqualityComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2ECABE0 Offset: 0x2ECACE1 VA: 0x2ECABE0
	|-HashSet<int>..ctor
	|
	|-RVA: 0x2ECDF20 Offset: 0x2ECE021 VA: 0x2ECDF20
	|-HashSet<Int32Enum>..ctor
	|
	|-RVA: 0x2ED1260 Offset: 0x2ED1361 VA: 0x2ED1260
	|-HashSet<object>..ctor
	|
	|-RVA: 0x2ED4530 Offset: 0x2ED4631 VA: 0x2ED4530
	|-HashSet<uint>..ctor
	|
	|-RVA: 0x2ED7870 Offset: 0x2ED7971 VA: 0x2ED7870
	|-HashSet<Edge>..ctor
	|
	|-RVA: 0x2EDAB10 Offset: 0x2EDAC11 VA: 0x2EDAB10
	|-HashSet<AsyncOperationHandle>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IEnumerable<T> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2ED12E0 Offset: 0x2ED13E1 VA: 0x2ED12E0
	|-HashSet<BaseSpriteItemData>..ctor
	|-HashSet<ParameterExpression>..ctor
	|-HashSet<object>..ctor
	|
	|-RVA: 0x2ECAC60 Offset: 0x2ECAD61 VA: 0x2ECAC60
	|-HashSet<int>..ctor
	|
	|-RVA: 0x2ECDFA0 Offset: 0x2ECE0A1 VA: 0x2ECDFA0
	|-HashSet<Int32Enum>..ctor
	|
	|-RVA: 0x2ED45B0 Offset: 0x2ED46B1 VA: 0x2ED45B0
	|-HashSet<uint>..ctor
	|
	|-RVA: 0x2ED78F0 Offset: 0x2ED79F1 VA: 0x2ED78F0
	|-HashSet<Edge>..ctor
	|
	|-RVA: 0x2EDAB90 Offset: 0x2EDAC91 VA: 0x2EDAB90
	|-HashSet<AsyncOperationHandle>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IEnumerable<T> collection, IEqualityComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2ECACD0 Offset: 0x2ECADD1 VA: 0x2ECACD0
	|-HashSet<int>..ctor
	|
	|-RVA: 0x2ECE010 Offset: 0x2ECE111 VA: 0x2ECE010
	|-HashSet<Int32Enum>..ctor
	|
	|-RVA: 0x2ED1350 Offset: 0x2ED1451 VA: 0x2ED1350
	|-HashSet<object>..ctor
	|-HashSet<IResourceLocation>..ctor
	|
	|-RVA: 0x2ED4620 Offset: 0x2ED4721 VA: 0x2ED4620
	|-HashSet<uint>..ctor
	|
	|-RVA: 0x2ED7960 Offset: 0x2ED7A61 VA: 0x2ED7960
	|-HashSet<Edge>..ctor
	|
	|-RVA: 0x2EDAC00 Offset: 0x2EDAD01 VA: 0x2EDAC00
	|-HashSet<AsyncOperationHandle>..ctor
	*/

	// RVA: -1 Offset: -1
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2ECAF50 Offset: 0x2ECB051 VA: 0x2ECAF50
	|-HashSet<int>..ctor
	|
	|-RVA: 0x2ECE290 Offset: 0x2ECE391 VA: 0x2ECE290
	|-HashSet<Int32Enum>..ctor
	|
	|-RVA: 0x2ED15D0 Offset: 0x2ED16D1 VA: 0x2ED15D0
	|-HashSet<object>..ctor
	|
	|-RVA: 0x2ED48A0 Offset: 0x2ED49A1 VA: 0x2ED48A0
	|-HashSet<uint>..ctor
	|
	|-RVA: 0x2ED7BE0 Offset: 0x2ED7CE1 VA: 0x2ED7BE0
	|-HashSet<Edge>..ctor
	|
	|-RVA: 0x2EDAE80 Offset: 0x2EDAF81 VA: 0x2EDAE80
	|-HashSet<AsyncOperationHandle>..ctor
	*/

	// RVA: -1 Offset: -1
	private void CopyFrom(HashSet<T> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2ECAF90 Offset: 0x2ECB091 VA: 0x2ECAF90
	|-HashSet<int>.CopyFrom
	|
	|-RVA: 0x2ECE2D0 Offset: 0x2ECE3D1 VA: 0x2ECE2D0
	|-HashSet<Int32Enum>.CopyFrom
	|
	|-RVA: 0x2ED1610 Offset: 0x2ED1711 VA: 0x2ED1610
	|-HashSet<object>.CopyFrom
	|
	|-RVA: 0x2ED48E0 Offset: 0x2ED49E1 VA: 0x2ED48E0
	|-HashSet<uint>.CopyFrom
	|
	|-RVA: 0x2ED7C20 Offset: 0x2ED7D21 VA: 0x2ED7C20
	|-HashSet<Edge>.CopyFrom
	|
	|-RVA: 0x2EDAEC0 Offset: 0x2EDAFC1 VA: 0x2EDAEC0
	|-HashSet<AsyncOperationHandle>.CopyFrom
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private void System.Collections.Generic.ICollection<T>.Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2ECB1B0 Offset: 0x2ECB2B1 VA: 0x2ECB1B0
	|-HashSet<int>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2ECE4F0 Offset: 0x2ECE5F1 VA: 0x2ECE4F0
	|-HashSet<Int32Enum>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2ED1830 Offset: 0x2ED1931 VA: 0x2ED1830
	|-HashSet<object>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2ED4B00 Offset: 0x2ED4C01 VA: 0x2ED4B00
	|-HashSet<uint>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2ED7E40 Offset: 0x2ED7F41 VA: 0x2ED7E40
	|-HashSet<Edge>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2EDB110 Offset: 0x2EDB211 VA: 0x2EDB110
	|-HashSet<AsyncOperationHandle>.System.Collections.Generic.ICollection<T>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2ED1860 Offset: 0x2ED1961 VA: 0x2ED1860
	|-HashSet<ActorController>.Clear
	|-HashSet<CharacterBase>.Clear
	|-HashSet<object>.Clear
	|-HashSet<string>.Clear
	|-HashSet<Collider>.Clear
	|-HashSet<GameObject>.Clear
	|-HashSet<ParticleSystem>.Clear
	|-HashSet<IClippable>.Clear
	|-HashSet<MaskableGraphic>.Clear
	|
	|-RVA: 0x2ECB1E0 Offset: 0x2ECB2E1 VA: 0x2ECB1E0
	|-HashSet<int>.Clear
	|
	|-RVA: 0x2ECE520 Offset: 0x2ECE621 VA: 0x2ECE520
	|-HashSet<Int32Enum>.Clear
	|
	|-RVA: 0x2ED4B30 Offset: 0x2ED4C31 VA: 0x2ED4B30
	|-HashSet<uint>.Clear
	|
	|-RVA: 0x2ED7E70 Offset: 0x2ED7F71 VA: 0x2ED7E70
	|-HashSet<Edge>.Clear
	|
	|-RVA: 0x2EDB170 Offset: 0x2EDB271 VA: 0x2EDB170
	|-HashSet<AsyncOperationHandle>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2ED18D0 Offset: 0x2ED19D1 VA: 0x2ED18D0
	|-HashSet<Character>.Contains
	|-HashSet<CharacterBase>.Contains
	|-HashSet<LabelScopeInfo>.Contains
	|-HashSet<object>.Contains
	|-HashSet<string>.Contains
	|-HashSet<Type>.Contains
	|-HashSet<Collider>.Contains
	|-HashSet<GameObject>.Contains
	|-HashSet<Object>.Contains
	|-HashSet<ParticleSystem>.Contains
	|-HashSet<PlayableDirector>.Contains
	|
	|-RVA: 0x2ECE590 Offset: 0x2ECE691 VA: 0x2ECE590
	|-HashSet<EquipSubAttribute>.Contains
	|-HashSet<FieldHideItemSpawnID>.Contains
	|-HashSet<FieldItemSpawnID>.Contains
	|-HashSet<FieldRandomTreasureBoxSpawnID>.Contains
	|-HashSet<FieldRewardTreasureBoxSpawnID>.Contains
	|-HashSet<FieldUniqueTreasureBoxSpawnID>.Contains
	|-HashSet<FieldWoodBoxSpawnID>.Contains
	|-HashSet<GimmickLayoutID>.Contains
	|-HashSet<Int32Enum>.Contains
	|
	|-RVA: 0x2ECB250 Offset: 0x2ECB351 VA: 0x2ECB250
	|-HashSet<int>.Contains
	|
	|-RVA: 0x2ED4BA0 Offset: 0x2ED4CA1 VA: 0x2ED4BA0
	|-HashSet<uint>.Contains
	|
	|-RVA: 0x2ED7EE0 Offset: 0x2ED7FE1 VA: 0x2ED7EE0
	|-HashSet<Edge>.Contains
	|
	|-RVA: 0x2EDB1E0 Offset: 0x2EDB2E1 VA: 0x2EDB1E0
	|-HashSet<AsyncOperationHandle>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void CopyTo(T[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2ECB3E0 Offset: 0x2ECB4E1 VA: 0x2ECB3E0
	|-HashSet<int>.CopyTo
	|
	|-RVA: 0x2ECE720 Offset: 0x2ECE821 VA: 0x2ECE720
	|-HashSet<Int32Enum>.CopyTo
	|
	|-RVA: 0x2ED1A60 Offset: 0x2ED1B61 VA: 0x2ED1A60
	|-HashSet<object>.CopyTo
	|
	|-RVA: 0x2ED4D30 Offset: 0x2ED4E31 VA: 0x2ED4D30
	|-HashSet<uint>.CopyTo
	|
	|-RVA: 0x2ED8070 Offset: 0x2ED8171 VA: 0x2ED8070
	|-HashSet<Edge>.CopyTo
	|
	|-RVA: 0x2EDB3F0 Offset: 0x2EDB4F1 VA: 0x2EDB3F0
	|-HashSet<AsyncOperationHandle>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public bool Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2ED1A90 Offset: 0x2ED1B91 VA: 0x2ED1A90
	|-HashSet<ActorController>.Remove
	|-HashSet<EnvironmentSoundPointController>.Remove
	|-HashSet<FieldHideItemSpawner>.Remove
	|-HashSet<FieldItemSpawner>.Remove
	|-HashSet<FieldRandomTreasureBoxSpawner>.Remove
	|-HashSet<FieldRewardTreasureBoxSpawner>.Remove
	|-HashSet<FieldUniqueTreasureBoxSpawner>.Remove
	|-HashSet<IndoorShadowFloor>.Remove
	|-HashSet<MaterialChangeTime>.Remove
	|-HashSet<ObjectChangeTime>.Remove
	|-HashSet<RendererChangeTime>.Remove
	|-HashSet<TextureChangeByFlag>.Remove
	|-HashSet<VisibleChangeByFlag>.Remove
	|-HashSet<BaseSpriteItemData>.Remove
	|-HashSet<GimmickBase>.Remove
	|-HashSet<MapFieldCollider>.Remove
	|-HashSet<MiningPoint>.Remove
	|-HashSet<SEController>.Remove
	|-HashSet<SeasonChangeObject>.Remove
	|-HashSet<SeasonVisibleObject>.Remove
	|-HashSet<object>.Remove
	|-HashSet<TeleportDragonRope>.Remove
	|-HashSet<Collider>.Remove
	|-HashSet<GameObject>.Remove
	|-HashSet<Object>.Remove
	|-HashSet<PlayableDirector>.Remove
	|-HashSet<ResourceManager.InstanceOperation>.Remove
	|-HashSet<IClippable>.Remove
	|-HashSet<MaskableGraphic>.Remove
	|-HashSet<Text>.Remove
	|
	|-RVA: 0x2ECE750 Offset: 0x2ECE851 VA: 0x2ECE750
	|-HashSet<CraftCategoryId>.Remove
	|-HashSet<FieldHideItemSpawnID>.Remove
	|-HashSet<FieldItemSpawnID>.Remove
	|-HashSet<FieldRandomTreasureBoxSpawnID>.Remove
	|-HashSet<FieldRewardTreasureBoxSpawnID>.Remove
	|-HashSet<FieldUniqueTreasureBoxSpawnID>.Remove
	|-HashSet<FieldWoodBoxSpawnID>.Remove
	|-HashSet<GimmickLayoutID>.Remove
	|-HashSet<Int32Enum>.Remove
	|
	|-RVA: 0x2ECB410 Offset: 0x2ECB511 VA: 0x2ECB410
	|-HashSet<int>.Remove
	|
	|-RVA: 0x2ED4D60 Offset: 0x2ED4E61 VA: 0x2ED4D60
	|-HashSet<uint>.Remove
	|
	|-RVA: 0x2ED80A0 Offset: 0x2ED81A1 VA: 0x2ED80A0
	|-HashSet<Edge>.Remove
	|
	|-RVA: 0x2EDB420 Offset: 0x2EDB521 VA: 0x2EDB420
	|-HashSet<AsyncOperationHandle>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2ED1D40 Offset: 0x2ED1E41 VA: 0x2ED1D40
	|-HashSet<ActorController>.get_Count
	|-HashSet<IndoorShadowFloor>.get_Count
	|-HashSet<MaterialChangeTime>.get_Count
	|-HashSet<ObjectChangeTime>.get_Count
	|-HashSet<RendererChangeTime>.get_Count
	|-HashSet<BaseSpriteItemData>.get_Count
	|-HashSet<GimmickBase>.get_Count
	|-HashSet<object>.get_Count
	|-HashSet<string>.get_Count
	|-HashSet<Material>.get_Count
	|-HashSet<IResourceLocation>.get_Count
	|-HashSet<ResourceManager.InstanceOperation>.get_Count
	|-HashSet<Text>.get_Count
	|
	|-RVA: 0x2ECEA10 Offset: 0x2ECEB11 VA: 0x2ECEA10
	|-HashSet<CraftCategoryId>.get_Count
	|-HashSet<RecipeId>.get_Count
	|-HashSet<Int32Enum>.get_Count
	|
	|-RVA: 0x2ECB6D0 Offset: 0x2ECB7D1 VA: 0x2ECB6D0
	|-HashSet<int>.get_Count
	|
	|-RVA: 0x2ED5020 Offset: 0x2ED5121 VA: 0x2ED5020
	|-HashSet<uint>.get_Count
	|
	|-RVA: 0x2ED8330 Offset: 0x2ED8431 VA: 0x2ED8330
	|-HashSet<Edge>.get_Count
	|
	|-RVA: 0x2EDB760 Offset: 0x2EDB861 VA: 0x2EDB760
	|-HashSet<AsyncOperationHandle>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2ECB6E0 Offset: 0x2ECB7E1 VA: 0x2ECB6E0
	|-HashSet<int>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2ECEA20 Offset: 0x2ECEB21 VA: 0x2ECEA20
	|-HashSet<Int32Enum>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2ED1D50 Offset: 0x2ED1E51 VA: 0x2ED1D50
	|-HashSet<object>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2ED5030 Offset: 0x2ED5131 VA: 0x2ED5030
	|-HashSet<uint>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2ED8340 Offset: 0x2ED8441 VA: 0x2ED8340
	|-HashSet<Edge>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2EDB770 Offset: 0x2EDB871 VA: 0x2EDB770
	|-HashSet<AsyncOperationHandle>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1
	public HashSet.Enumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2ED1D60 Offset: 0x2ED1E61 VA: 0x2ED1D60
	|-HashSet<ActorController>.GetEnumerator
	|-HashSet<EnvironmentSoundPointController>.GetEnumerator
	|-HashSet<FieldHideItemSpawner>.GetEnumerator
	|-HashSet<FieldItemSpawner>.GetEnumerator
	|-HashSet<FieldRandomTreasureBoxSpawner>.GetEnumerator
	|-HashSet<FieldRewardTreasureBoxSpawner>.GetEnumerator
	|-HashSet<FieldUniqueTreasureBoxSpawner>.GetEnumerator
	|-HashSet<MaterialChangeTime>.GetEnumerator
	|-HashSet<ObjectChangeTime>.GetEnumerator
	|-HashSet<RendererChangeTime>.GetEnumerator
	|-HashSet<TextureChangeByFlag>.GetEnumerator
	|-HashSet<VisibleChangeByFlag>.GetEnumerator
	|-HashSet<BaseSpriteItemData>.GetEnumerator
	|-HashSet<GimmickBase>.GetEnumerator
	|-HashSet<MiningPoint>.GetEnumerator
	|-HashSet<SEController>.GetEnumerator
	|-HashSet<SeasonChangeObject>.GetEnumerator
	|-HashSet<SeasonVisibleObject>.GetEnumerator
	|-HashSet<Func<IEnumerator>>.GetEnumerator
	|-HashSet<TeleportDragonRope>.GetEnumerator
	|-HashSet<Collider>.GetEnumerator
	|-HashSet<Material>.GetEnumerator
	|-HashSet<Object>.GetEnumerator
	|-HashSet<ResourceManager.InstanceOperation>.GetEnumerator
	|-HashSet<IClippable>.GetEnumerator
	|-HashSet<MaskableGraphic>.GetEnumerator
	|-HashSet<Text>.GetEnumerator
	|-HashSet<LabelScopeInfo>.GetEnumerator
	|-HashSet<ParameterExpression>.GetEnumerator
	|-HashSet<object>.GetEnumerator
	|
	|-RVA: 0x2ECEA30 Offset: 0x2ECEB31 VA: 0x2ECEA30
	|-HashSet<CraftCategoryId>.GetEnumerator
	|-HashSet<FieldRandomTreasureBoxSpawnID>.GetEnumerator
	|-HashSet<ItemID>.GetEnumerator
	|-HashSet<RecipeId>.GetEnumerator
	|-HashSet<Int32Enum>.GetEnumerator
	|
	|-RVA: 0x2EDB780 Offset: 0x2EDB881 VA: 0x2EDB780
	|-HashSet<AsyncOperationHandle>.GetEnumerator
	|
	|-RVA: 0x2ECB6F0 Offset: 0x2ECB7F1 VA: 0x2ECB6F0
	|-HashSet<int>.GetEnumerator
	|
	|-RVA: 0x2ED5040 Offset: 0x2ED5141 VA: 0x2ED5040
	|-HashSet<uint>.GetEnumerator
	|
	|-RVA: 0x2ED8350 Offset: 0x2ED8451 VA: 0x2ED8350
	|-HashSet<Edge>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2ECB750 Offset: 0x2ECB851 VA: 0x2ECB750
	|-HashSet<int>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2ECEA90 Offset: 0x2ECEB91 VA: 0x2ECEA90
	|-HashSet<Int32Enum>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2ED1DC0 Offset: 0x2ED1EC1 VA: 0x2ED1DC0
	|-HashSet<object>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2ED50A0 Offset: 0x2ED51A1 VA: 0x2ED50A0
	|-HashSet<uint>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2ED83B0 Offset: 0x2ED84B1 VA: 0x2ED83B0
	|-HashSet<Edge>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2EDB7F0 Offset: 0x2EDB8F1 VA: 0x2EDB7F0
	|-HashSet<AsyncOperationHandle>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2ECB7E0 Offset: 0x2ECB8E1 VA: 0x2ECB7E0
	|-HashSet<int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2ECEB20 Offset: 0x2ECEC21 VA: 0x2ECEB20
	|-HashSet<Int32Enum>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2ED1E50 Offset: 0x2ED1F51 VA: 0x2ED1E50
	|-HashSet<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2ED5130 Offset: 0x2ED5231 VA: 0x2ED5130
	|-HashSet<uint>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2ED8440 Offset: 0x2ED8541 VA: 0x2ED8440
	|-HashSet<Edge>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2EDB8A0 Offset: 0x2EDB9A1 VA: 0x2EDB8A0
	|-HashSet<AsyncOperationHandle>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2ECB870 Offset: 0x2ECB971 VA: 0x2ECB870
	|-HashSet<int>.GetObjectData
	|
	|-RVA: 0x2ECEBB0 Offset: 0x2ECECB1 VA: 0x2ECEBB0
	|-HashSet<Int32Enum>.GetObjectData
	|
	|-RVA: 0x2ED1EE0 Offset: 0x2ED1FE1 VA: 0x2ED1EE0
	|-HashSet<object>.GetObjectData
	|
	|-RVA: 0x2ED51C0 Offset: 0x2ED52C1 VA: 0x2ED51C0
	|-HashSet<uint>.GetObjectData
	|
	|-RVA: 0x2ED84D0 Offset: 0x2ED85D1 VA: 0x2ED84D0
	|-HashSet<Edge>.GetObjectData
	|
	|-RVA: 0x2EDB950 Offset: 0x2EDBA51 VA: 0x2EDB950
	|-HashSet<AsyncOperationHandle>.GetObjectData
	*/

	// RVA: -1 Offset: -1 Slot: 17
	public virtual void OnDeserialization(object sender) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2ECBA60 Offset: 0x2ECBB61 VA: 0x2ECBA60
	|-HashSet<int>.OnDeserialization
	|
	|-RVA: 0x2ECEDA0 Offset: 0x2ECEEA1 VA: 0x2ECEDA0
	|-HashSet<Int32Enum>.OnDeserialization
	|
	|-RVA: 0x2ED20D0 Offset: 0x2ED21D1 VA: 0x2ED20D0
	|-HashSet<object>.OnDeserialization
	|
	|-RVA: 0x2ED53B0 Offset: 0x2ED54B1 VA: 0x2ED53B0
	|-HashSet<uint>.OnDeserialization
	|
	|-RVA: 0x2ED86C0 Offset: 0x2ED87C1 VA: 0x2ED86C0
	|-HashSet<Edge>.OnDeserialization
	|
	|-RVA: 0x2EDBB40 Offset: 0x2EDBC41 VA: 0x2EDBB40
	|-HashSet<AsyncOperationHandle>.OnDeserialization
	*/

	// RVA: -1 Offset: -1 Slot: 18
	public bool Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2ED23F0 Offset: 0x2ED24F1 VA: 0x2ED23F0
	|-HashSet<ActorController>.Add
	|-HashSet<Character>.Add
	|-HashSet<CharacterBase>.Add
	|-HashSet<EnvironmentSoundPointController>.Add
	|-HashSet<FieldHideItemSpawner>.Add
	|-HashSet<FieldItemSpawner>.Add
	|-HashSet<FieldRandomTreasureBoxSpawner>.Add
	|-HashSet<FieldRewardTreasureBoxSpawner>.Add
	|-HashSet<FieldUniqueTreasureBoxSpawner>.Add
	|-HashSet<IndoorShadowFloor>.Add
	|-HashSet<MaterialChangeTime>.Add
	|-HashSet<ObjectChangeTime>.Add
	|-HashSet<RendererChangeTime>.Add
	|-HashSet<TextureChangeByFlag>.Add
	|-HashSet<VisibleChangeByFlag>.Add
	|-HashSet<BaseSpriteItemData>.Add
	|-HashSet<GimmickBase>.Add
	|-HashSet<MapFieldCollider>.Add
	|-HashSet<MiningPoint>.Add
	|-HashSet<SEController>.Add
	|-HashSet<SeasonChangeObject>.Add
	|-HashSet<SeasonVisibleObject>.Add
	|-HashSet<Func<IEnumerator>>.Add
	|-HashSet<LabelScopeInfo>.Add
	|-HashSet<ParameterExpression>.Add
	|-HashSet<object>.Add
	|-HashSet<string>.Add
	|-HashSet<Type>.Add
	|-HashSet<TeleportDragonRope>.Add
	|-HashSet<Collider>.Add
	|-HashSet<GameObject>.Add
	|-HashSet<Material>.Add
	|-HashSet<Object>.Add
	|-HashSet<ParticleSystem>.Add
	|-HashSet<PlayableDirector>.Add
	|-HashSet<IResourceLocation>.Add
	|-HashSet<ResourceManager.InstanceOperation>.Add
	|-HashSet<Transform>.Add
	|-HashSet<IClippable>.Add
	|-HashSet<MaskableGraphic>.Add
	|-HashSet<Text>.Add
	|
	|-RVA: 0x2ECF0C0 Offset: 0x2ECF1C1 VA: 0x2ECF0C0
	|-HashSet<CraftCategoryId>.Add
	|-HashSet<EquipSubAttribute>.Add
	|-HashSet<FieldHideItemSpawnID>.Add
	|-HashSet<FieldItemSpawnID>.Add
	|-HashSet<FieldRandomTreasureBoxSpawnID>.Add
	|-HashSet<FieldRewardTreasureBoxSpawnID>.Add
	|-HashSet<FieldUniqueTreasureBoxSpawnID>.Add
	|-HashSet<FieldWoodBoxSpawnID>.Add
	|-HashSet<GimmickLayoutID>.Add
	|-HashSet<ItemID>.Add
	|-HashSet<RecipeId>.Add
	|-HashSet<Int32Enum>.Add
	|
	|-RVA: 0x2ECBD80 Offset: 0x2ECBE81 VA: 0x2ECBD80
	|-HashSet<int>.Add
	|
	|-RVA: 0x2ED56D0 Offset: 0x2ED57D1 VA: 0x2ED56D0
	|-HashSet<uint>.Add
	|
	|-RVA: 0x2ED89E0 Offset: 0x2ED8AE1 VA: 0x2ED89E0
	|-HashSet<Edge>.Add
	|
	|-RVA: 0x2EDBE70 Offset: 0x2EDBF71 VA: 0x2EDBE70
	|-HashSet<AsyncOperationHandle>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 19
	public void UnionWith(IEnumerable<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2ECBDB0 Offset: 0x2ECBEB1 VA: 0x2ECBDB0
	|-HashSet<int>.UnionWith
	|
	|-RVA: 0x2ECF0F0 Offset: 0x2ECF1F1 VA: 0x2ECF0F0
	|-HashSet<Int32Enum>.UnionWith
	|
	|-RVA: 0x2ED2420 Offset: 0x2ED2521 VA: 0x2ED2420
	|-HashSet<object>.UnionWith
	|-HashSet<IResourceLocation>.UnionWith
	|
	|-RVA: 0x2ED5700 Offset: 0x2ED5801 VA: 0x2ED5700
	|-HashSet<uint>.UnionWith
	|
	|-RVA: 0x2ED8A10 Offset: 0x2ED8B11 VA: 0x2ED8A10
	|-HashSet<Edge>.UnionWith
	|
	|-RVA: 0x2EDBED0 Offset: 0x2EDBFD1 VA: 0x2EDBED0
	|-HashSet<AsyncOperationHandle>.UnionWith
	*/

	// RVA: -1 Offset: -1 Slot: 20
	public void IntersectWith(IEnumerable<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2ECC1B0 Offset: 0x2ECC2B1 VA: 0x2ECC1B0
	|-HashSet<int>.IntersectWith
	|
	|-RVA: 0x2ECF4F0 Offset: 0x2ECF5F1 VA: 0x2ECF4F0
	|-HashSet<Int32Enum>.IntersectWith
	|
	|-RVA: 0x2ED2820 Offset: 0x2ED2921 VA: 0x2ED2820
	|-HashSet<object>.IntersectWith
	|-HashSet<IResourceLocation>.IntersectWith
	|
	|-RVA: 0x2ED5B00 Offset: 0x2ED5C01 VA: 0x2ED5B00
	|-HashSet<uint>.IntersectWith
	|
	|-RVA: 0x2ED8E10 Offset: 0x2ED8F11 VA: 0x2ED8E10
	|-HashSet<Edge>.IntersectWith
	|
	|-RVA: 0x2EDC340 Offset: 0x2EDC441 VA: 0x2EDC340
	|-HashSet<AsyncOperationHandle>.IntersectWith
	*/

	// RVA: -1 Offset: -1 Slot: 21
	public void ExceptWith(IEnumerable<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2ECC3F0 Offset: 0x2ECC4F1 VA: 0x2ECC3F0
	|-HashSet<int>.ExceptWith
	|
	|-RVA: 0x2ECF730 Offset: 0x2ECF831 VA: 0x2ECF730
	|-HashSet<Int32Enum>.ExceptWith
	|
	|-RVA: 0x2ED2A60 Offset: 0x2ED2B61 VA: 0x2ED2A60
	|-HashSet<object>.ExceptWith
	|
	|-RVA: 0x2ED5D40 Offset: 0x2ED5E41 VA: 0x2ED5D40
	|-HashSet<uint>.ExceptWith
	|
	|-RVA: 0x2ED9050 Offset: 0x2ED9151 VA: 0x2ED9050
	|-HashSet<Edge>.ExceptWith
	|
	|-RVA: 0x2EDC580 Offset: 0x2EDC681 VA: 0x2EDC580
	|-HashSet<AsyncOperationHandle>.ExceptWith
	*/

	// RVA: -1 Offset: -1
	public void CopyTo(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2ECC830 Offset: 0x2ECC931 VA: 0x2ECC830
	|-HashSet<int>.CopyTo
	|
	|-RVA: 0x2ECFB70 Offset: 0x2ECFC71 VA: 0x2ECFB70
	|-HashSet<Int32Enum>.CopyTo
	|
	|-RVA: 0x2ED2EA0 Offset: 0x2ED2FA1 VA: 0x2ED2EA0
	|-HashSet<object>.CopyTo
	|
	|-RVA: 0x2ED6180 Offset: 0x2ED6281 VA: 0x2ED6180
	|-HashSet<uint>.CopyTo
	|
	|-RVA: 0x2ED9490 Offset: 0x2ED9591 VA: 0x2ED9490
	|-HashSet<Edge>.CopyTo
	|
	|-RVA: 0x2EDCA30 Offset: 0x2EDCB31 VA: 0x2EDCA30
	|-HashSet<AsyncOperationHandle>.CopyTo
	*/

	// RVA: -1 Offset: -1
	public void CopyTo(T[] array, int arrayIndex, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2ECC860 Offset: 0x2ECC961 VA: 0x2ECC860
	|-HashSet<int>.CopyTo
	|
	|-RVA: 0x2ECFBA0 Offset: 0x2ECFCA1 VA: 0x2ECFBA0
	|-HashSet<Int32Enum>.CopyTo
	|
	|-RVA: 0x2ED2ED0 Offset: 0x2ED2FD1 VA: 0x2ED2ED0
	|-HashSet<object>.CopyTo
	|
	|-RVA: 0x2ED61B0 Offset: 0x2ED62B1 VA: 0x2ED61B0
	|-HashSet<uint>.CopyTo
	|
	|-RVA: 0x2ED94C0 Offset: 0x2ED95C1 VA: 0x2ED94C0
	|-HashSet<Edge>.CopyTo
	|
	|-RVA: 0x2EDCA60 Offset: 0x2EDCB61 VA: 0x2EDCA60
	|-HashSet<AsyncOperationHandle>.CopyTo
	*/

	// RVA: -1 Offset: -1
	public IEqualityComparer<T> get_Comparer() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2ECCA80 Offset: 0x2ECCB81 VA: 0x2ECCA80
	|-HashSet<int>.get_Comparer
	|
	|-RVA: 0x2ECFDC0 Offset: 0x2ECFEC1 VA: 0x2ECFDC0
	|-HashSet<Int32Enum>.get_Comparer
	|
	|-RVA: 0x2ED30F0 Offset: 0x2ED31F1 VA: 0x2ED30F0
	|-HashSet<object>.get_Comparer
	|
	|-RVA: 0x2ED63D0 Offset: 0x2ED64D1 VA: 0x2ED63D0
	|-HashSet<uint>.get_Comparer
	|
	|-RVA: 0x2ED96E0 Offset: 0x2ED97E1 VA: 0x2ED96E0
	|-HashSet<Edge>.get_Comparer
	|
	|-RVA: 0x2EDCCB0 Offset: 0x2EDCDB1 VA: 0x2EDCCB0
	|-HashSet<AsyncOperationHandle>.get_Comparer
	*/

	// RVA: -1 Offset: -1
	public void TrimExcess() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2ECCA90 Offset: 0x2ECCB91 VA: 0x2ECCA90
	|-HashSet<int>.TrimExcess
	|
	|-RVA: 0x2ECFDD0 Offset: 0x2ECFED1 VA: 0x2ECFDD0
	|-HashSet<Int32Enum>.TrimExcess
	|
	|-RVA: 0x2ED3100 Offset: 0x2ED3201 VA: 0x2ED3100
	|-HashSet<object>.TrimExcess
	|
	|-RVA: 0x2ED63E0 Offset: 0x2ED64E1 VA: 0x2ED63E0
	|-HashSet<uint>.TrimExcess
	|
	|-RVA: 0x2ED96F0 Offset: 0x2ED97F1 VA: 0x2ED96F0
	|-HashSet<Edge>.TrimExcess
	|
	|-RVA: 0x2EDCCC0 Offset: 0x2EDCDC1 VA: 0x2EDCCC0
	|-HashSet<AsyncOperationHandle>.TrimExcess
	*/

	// RVA: -1 Offset: -1
	private void Initialize(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2ECCD30 Offset: 0x2ECCE31 VA: 0x2ECCD30
	|-HashSet<int>.Initialize
	|
	|-RVA: 0x2ED0070 Offset: 0x2ED0171 VA: 0x2ED0070
	|-HashSet<Int32Enum>.Initialize
	|
	|-RVA: 0x2ED3350 Offset: 0x2ED3451 VA: 0x2ED3350
	|-HashSet<object>.Initialize
	|
	|-RVA: 0x2ED6680 Offset: 0x2ED6781 VA: 0x2ED6680
	|-HashSet<uint>.Initialize
	|
	|-RVA: 0x2ED9970 Offset: 0x2ED9A71 VA: 0x2ED9970
	|-HashSet<Edge>.Initialize
	|
	|-RVA: 0x2EDCF40 Offset: 0x2EDD041 VA: 0x2EDCF40
	|-HashSet<AsyncOperationHandle>.Initialize
	*/

	// RVA: -1 Offset: -1
	private void IncreaseCapacity() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2ECCE10 Offset: 0x2ECCF11 VA: 0x2ECCE10
	|-HashSet<int>.IncreaseCapacity
	|
	|-RVA: 0x2ED0150 Offset: 0x2ED0251 VA: 0x2ED0150
	|-HashSet<Int32Enum>.IncreaseCapacity
	|
	|-RVA: 0x2ED3430 Offset: 0x2ED3531 VA: 0x2ED3430
	|-HashSet<object>.IncreaseCapacity
	|
	|-RVA: 0x2ED6760 Offset: 0x2ED6861 VA: 0x2ED6760
	|-HashSet<uint>.IncreaseCapacity
	|
	|-RVA: 0x2ED9A50 Offset: 0x2ED9B51 VA: 0x2ED9A50
	|-HashSet<Edge>.IncreaseCapacity
	|
	|-RVA: 0x2EDD020 Offset: 0x2EDD121 VA: 0x2EDD020
	|-HashSet<AsyncOperationHandle>.IncreaseCapacity
	*/

	// RVA: -1 Offset: -1
	private void SetCapacity(int newSize) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2ECCEF0 Offset: 0x2ECCFF1 VA: 0x2ECCEF0
	|-HashSet<int>.SetCapacity
	|
	|-RVA: 0x2ED0230 Offset: 0x2ED0331 VA: 0x2ED0230
	|-HashSet<Int32Enum>.SetCapacity
	|
	|-RVA: 0x2ED3510 Offset: 0x2ED3611 VA: 0x2ED3510
	|-HashSet<object>.SetCapacity
	|
	|-RVA: 0x2ED6840 Offset: 0x2ED6941 VA: 0x2ED6840
	|-HashSet<uint>.SetCapacity
	|
	|-RVA: 0x2ED9B30 Offset: 0x2ED9C31 VA: 0x2ED9B30
	|-HashSet<Edge>.SetCapacity
	|
	|-RVA: 0x2EDD100 Offset: 0x2EDD201 VA: 0x2EDD100
	|-HashSet<AsyncOperationHandle>.SetCapacity
	*/

	// RVA: -1 Offset: -1
	private bool AddIfNotPresent(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2ECD060 Offset: 0x2ECD161 VA: 0x2ECD060
	|-HashSet<int>.AddIfNotPresent
	|
	|-RVA: 0x2ED03A0 Offset: 0x2ED04A1 VA: 0x2ED03A0
	|-HashSet<Int32Enum>.AddIfNotPresent
	|
	|-RVA: 0x2ED3680 Offset: 0x2ED3781 VA: 0x2ED3680
	|-HashSet<object>.AddIfNotPresent
	|
	|-RVA: 0x2ED69B0 Offset: 0x2ED6AB1 VA: 0x2ED69B0
	|-HashSet<uint>.AddIfNotPresent
	|
	|-RVA: 0x2ED9CA0 Offset: 0x2ED9DA1 VA: 0x2ED9CA0
	|-HashSet<Edge>.AddIfNotPresent
	|
	|-RVA: 0x2EDD270 Offset: 0x2EDD371 VA: 0x2EDD270
	|-HashSet<AsyncOperationHandle>.AddIfNotPresent
	*/

	// RVA: -1 Offset: -1
	private void AddValue(int index, int hashCode, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2ECD390 Offset: 0x2ECD491 VA: 0x2ECD390
	|-HashSet<int>.AddValue
	|
	|-RVA: 0x2ED06D0 Offset: 0x2ED07D1 VA: 0x2ED06D0
	|-HashSet<Int32Enum>.AddValue
	|
	|-RVA: 0x2ED3990 Offset: 0x2ED3A91 VA: 0x2ED3990
	|-HashSet<object>.AddValue
	|
	|-RVA: 0x2ED6CE0 Offset: 0x2ED6DE1 VA: 0x2ED6CE0
	|-HashSet<uint>.AddValue
	|
	|-RVA: 0x2ED9FB0 Offset: 0x2EDA0B1 VA: 0x2ED9FB0
	|-HashSet<Edge>.AddValue
	|
	|-RVA: 0x2EDD630 Offset: 0x2EDD731 VA: 0x2EDD630
	|-HashSet<AsyncOperationHandle>.AddValue
	*/

	// RVA: -1 Offset: -1
	private void IntersectWithHashSetWithSameEC(HashSet<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2ECD470 Offset: 0x2ECD571 VA: 0x2ECD470
	|-HashSet<int>.IntersectWithHashSetWithSameEC
	|
	|-RVA: 0x2ED07B0 Offset: 0x2ED08B1 VA: 0x2ED07B0
	|-HashSet<Int32Enum>.IntersectWithHashSetWithSameEC
	|
	|-RVA: 0x2ED3A90 Offset: 0x2ED3B91 VA: 0x2ED3A90
	|-HashSet<object>.IntersectWithHashSetWithSameEC
	|
	|-RVA: 0x2ED6DC0 Offset: 0x2ED6EC1 VA: 0x2ED6DC0
	|-HashSet<uint>.IntersectWithHashSetWithSameEC
	|
	|-RVA: 0x2EDA080 Offset: 0x2EDA181 VA: 0x2EDA080
	|-HashSet<Edge>.IntersectWithHashSetWithSameEC
	|
	|-RVA: 0x2EDD750 Offset: 0x2EDD851 VA: 0x2EDD750
	|-HashSet<AsyncOperationHandle>.IntersectWithHashSetWithSameEC
	*/

	// RVA: -1 Offset: -1
	private void IntersectWithEnumerable(IEnumerable<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2ECD580 Offset: 0x2ECD681 VA: 0x2ECD580
	|-HashSet<int>.IntersectWithEnumerable
	|
	|-RVA: 0x2ED08C0 Offset: 0x2ED09C1 VA: 0x2ED08C0
	|-HashSet<Int32Enum>.IntersectWithEnumerable
	|
	|-RVA: 0x2ED3BA0 Offset: 0x2ED3CA1 VA: 0x2ED3BA0
	|-HashSet<object>.IntersectWithEnumerable
	|
	|-RVA: 0x2ED6ED0 Offset: 0x2ED6FD1 VA: 0x2ED6ED0
	|-HashSet<uint>.IntersectWithEnumerable
	|
	|-RVA: 0x2EDA190 Offset: 0x2EDA291 VA: 0x2EDA190
	|-HashSet<Edge>.IntersectWithEnumerable
	|
	|-RVA: 0x2EDD8B0 Offset: 0x2EDD9B1 VA: 0x2EDD8B0
	|-HashSet<AsyncOperationHandle>.IntersectWithEnumerable
	*/

	// RVA: -1 Offset: -1
	private int InternalIndexOf(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2ECDB70 Offset: 0x2ECDC71 VA: 0x2ECDB70
	|-HashSet<int>.InternalIndexOf
	|
	|-RVA: 0x2ED0EB0 Offset: 0x2ED0FB1 VA: 0x2ED0EB0
	|-HashSet<Int32Enum>.InternalIndexOf
	|
	|-RVA: 0x2ED4180 Offset: 0x2ED4281 VA: 0x2ED4180
	|-HashSet<object>.InternalIndexOf
	|
	|-RVA: 0x2ED74C0 Offset: 0x2ED75C1 VA: 0x2ED74C0
	|-HashSet<uint>.InternalIndexOf
	|
	|-RVA: 0x2EDA770 Offset: 0x2EDA871 VA: 0x2EDA770
	|-HashSet<Edge>.InternalIndexOf
	|
	|-RVA: 0x2EDDF30 Offset: 0x2EDE031 VA: 0x2EDDF30
	|-HashSet<AsyncOperationHandle>.InternalIndexOf
	*/

	// RVA: -1 Offset: -1
	private static bool AreEqualityComparersEqual(HashSet<T> set1, HashSet<T> set2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2ECDD10 Offset: 0x2ECDE11 VA: 0x2ECDD10
	|-HashSet<int>.AreEqualityComparersEqual
	|
	|-RVA: 0x2ED1050 Offset: 0x2ED1151 VA: 0x2ED1050
	|-HashSet<Int32Enum>.AreEqualityComparersEqual
	|
	|-RVA: 0x2ED4310 Offset: 0x2ED4411 VA: 0x2ED4310
	|-HashSet<object>.AreEqualityComparersEqual
	|
	|-RVA: 0x2ED7660 Offset: 0x2ED7761 VA: 0x2ED7660
	|-HashSet<uint>.AreEqualityComparersEqual
	|
	|-RVA: 0x2EDA900 Offset: 0x2EDAA01 VA: 0x2EDA900
	|-HashSet<Edge>.AreEqualityComparersEqual
	|
	|-RVA: 0x2EDE150 Offset: 0x2EDE251 VA: 0x2EDE150
	|-HashSet<AsyncOperationHandle>.AreEqualityComparersEqual
	*/

	// RVA: -1 Offset: -1
	private int InternalGetHashCode(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2ECDE00 Offset: 0x2ECDF01 VA: 0x2ECDE00
	|-HashSet<int>.InternalGetHashCode
	|
	|-RVA: 0x2ED1140 Offset: 0x2ED1241 VA: 0x2ED1140
	|-HashSet<Int32Enum>.InternalGetHashCode
	|
	|-RVA: 0x2ED4400 Offset: 0x2ED4501 VA: 0x2ED4400
	|-HashSet<object>.InternalGetHashCode
	|
	|-RVA: 0x2ED7750 Offset: 0x2ED7851 VA: 0x2ED7750
	|-HashSet<uint>.InternalGetHashCode
	|
	|-RVA: 0x2EDA9F0 Offset: 0x2EDAAF1 VA: 0x2EDA9F0
	|-HashSet<Edge>.InternalGetHashCode
	|
	|-RVA: 0x2EDE240 Offset: 0x2EDE341 VA: 0x2EDE240
	|-HashSet<AsyncOperationHandle>.InternalGetHashCode
	*/
}

